using MaterialLibrary;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WheelSettingManager.Controls
{
    public class AutoFitTextBox : RichTextBox
    {

        public AutoFitTextBox()
        {

            Multiline = true;
            this.Resize += (s, e) => AdjustFontSize();
            Leave+=(s,e)=> AdjustFontSize();
            KeyPress += (s, e) => AdjustFontSize();
            TextChanged += AutoFitTextBoxTextChanged;
            ScrollBars = RichTextBoxScrollBars.None;
            Font = new Font(this.Font.FontFamily, 40, this.Font.Style);
            SelectionAlignment = HorizontalAlignment.Center;
            WordWrap = false;
        }

        private void AutoFitTextBoxTextAlignChanged(object sender, EventArgs e)
        {
            AdjustFontSize();
        }

        private void AutoFitTextBoxTextChanged(object sender, EventArgs e)
        {
            AdjustFontSize();
        }

        private void AdjustFontSize()
        {
            if (string.IsNullOrEmpty(this.Text)) return;
            float FontSize = 100f;

            using (Graphics g = this.CreateGraphics())
            {
                while (FontSize > 0.5f)
                {
                    Font testFont = new Font(this.Font.FontFamily, FontSize, this.Font.Style);
                    SizeF textSize = g.MeasureString(this.Text, testFont, Width);
                    if (textSize.Width <= this.ClientSize.Width && textSize.Height <= this.ClientSize.Height)
                    {
                        break;
                    }
                    else
                    {
                        FontSize -= 0.5f;
                    }
                }
                this.Font = new Font(this.Font.FontFamily, FontSize, this.Font.Style);
            }

        }

    }
}

