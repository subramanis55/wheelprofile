using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WheelSettingManager.Controls
{
    class ExtendedTextBox1 : TextBox
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
            NumericLocations = numLocations;
        }
    }
}
