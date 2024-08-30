using MaterialLibrary;
using System;
using System.Windows.Forms;
using WheelSettingManager.LanguagesManager;

namespace SerialNumberInspectionUI.Denomination.Controls.SNCharBox
{
    public partial class SNCharBox : MaterialControl
    {
        public event MouseEventHandler OnMouseDown;
        public event MouseEventHandler OnMouseUp;
        public event EventHandler OnMouseEnter;
        public event EventHandler OnMouseLeave;
        public event EventHandler OnClick;
        private LanguageCharactersHolder languageCharactersHolder;
        public LanguageCharactersHolder LanguageCharactersHolder
        {
            set
            {
                languageCharactersHolder = value;
            }
            get
            {
                return languageCharactersHolder;
            }
        }
        public SNCharBox()
        {
            InitializeComponent();
        }

        public override string Text { get => label.Text; set => label.Text = value; }

        private void LabelMouseDown(object sender, MouseEventArgs e)
        {
            OnMouseDown?.Invoke(this, e);
            OnClick?.Invoke(this, EventArgs.Empty);
        }

        private void LabelMouseUp(object sender, MouseEventArgs e)
        {
            OnMouseUp?.Invoke(this, e);

        }
        private void LabelMouseEnter(object sender, EventArgs e)
        {
            OnMouseEnter?.Invoke(this, e);
        }

        private void LabelMouseLeave(object sender, EventArgs e)
        {
            OnMouseLeave?.Invoke(this, e);
        }
    }
}
