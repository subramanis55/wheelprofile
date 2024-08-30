using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using GoLibrary;
using MaterialLibrary;

namespace SerialInspectionUI
{
    public partial class SerialNumberPartDisplayer : MaterialControl
    {
        public SerialNumberPartDisplayer()
        {
            InitializeComponent();
        }

        public event EventHandler DisplayTextChanged;

        private string snString = "";

        private bool triggerEvent = true, isInternal;

        public bool IsPrefix { get; set; }

        public bool ReadOnly
        {
            get => textBox.ReadOnly;
            set => textBox.ReadOnly = value;
        }

        public string SNPartString
        {
            get => snString;
            set
            {
                snString = value.IsNullOrEmpty() ? textBox.StringMask : value;
                triggerEvent = false;
                if (textBox != null) textBox.Text = value;
                triggerEvent = true;
            }
        }

        public string StringMask => textBox.StringMask;

        public float GetRequiredFontSize()
        {
            if (textBox == null) return MaterialResource.Font.Size;
            return MaterialStatics.GetFontSize(MaterialResource.Font, this, textBox.StringMask, 5f, 100f, textBox.Width,
                textBox.Height) - 0.5f;
        }

        public void SetFont(Font font)
        {
            if (textBox != null) textBox.Font = font;
        }

        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);
            snString = textBox.Text = SNPartString.IsNullOrEmpty() ? textBox.StringMask : SNPartString;
        }

        internal void UpdateNumericLocations(List<bool> numLocations)
        {
            textBox.SetStringMask(numLocations);
        }

        private void OnTextChanged(object sender, EventArgs e)
        {
            if (!triggerEvent || isInternal) return;
            isInternal = true;
            string text = textBox.Text.ToUpper();
            textBox.Text = text;
            isInternal = false;
            SNPartString = text;
            DisplayTextChanged?.Invoke(this, e);
        }

        private void OnControlClicked(object sender, EventArgs e)
        {
            OnClick(e);
        }

        private void OnTextBoxMouseDown(object sender, MouseEventArgs e)
        {
            OnClick(e);
        }
    }

    internal class ExtendedTextBox : TextBox
    {
        public event EventHandler ExtendedTextChanged;

        public List<bool> NumericLocations { get; private set; }

        public string StringMask { get; private set; }

        protected override void OnTextChanged(EventArgs e)
        {
            if (Text.Length < StringMask?.Length)
            {
                int diff = StringMask.Length - Text.Length;
                Text = StringMask.Substring(0, diff) + Text;
            }
            ExtendedTextChanged?.Invoke(this, EventArgs.Empty);
            base.OnTextChanged(e);
        }

        protected override void OnKeyPress(KeyPressEventArgs e)
        {
        try{
                if (ReadOnly)
                {
                    e.Handled = true;
                    return;
                }
                if (NumericLocations.Count == SelectionStart)
                {
                    e.Handled = true;
                    return;
                }
                if (NumericLocations[SelectionStart] && !char.IsDigit(e.KeyChar))
                {
                    e.Handled = true;
                    return;
                }
                if (!NumericLocations[SelectionStart] && !char.IsLetter(e.KeyChar))
                {
                    e.Handled = true;
                    return;
                }
                int selection = SelectionStart;
                if (selection < Text.Length)
                {
                    string value = Text.Remove(selection, 1);
                    value = value.Insert(selection, e.KeyChar.ToString());
                    Text = value;
                    SelectionStart = selection + 1;
                    e.Handled = true;
                }
                if (Text.Length >= StringMask.Length) e.Handled = true;
            }
            catch{

            }
        }

        protected override void OnKeyDown(KeyEventArgs e)
        {
            if (ReadOnly)
            {
                e.Handled = true;
                return;
            }
            if (e.KeyCode == Keys.Delete)
            {
                e.Handled = true;
                if (SelectionStart < Text.Length) SelectionStart += 1;
            }
            if (e.KeyCode != Keys.Back) return;
            e.Handled = true;
            if (SelectionStart > 0) SelectionStart -= 1;
        }

        internal void SetStringMask(List<bool> numLocations)
        {
            StringMask = numLocations.Aggregate("", (current, num) => current + (num ? "0" : "W"));
            NumericLocations = new List<bool> { false,false,false};
        }
    }
}
