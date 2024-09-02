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
    public class AutoFitTextBox : TextBox
    {

        private string text;
        private Font textFont;

        public string TextContent
        {
            get => text;
            set
            {
                text = value;
                AdjustFontSize();
                Invalidate(); // Redraw control
            }
        }

        public AutoFitTextBox()
        {
            // Set default properties
            text = "Sample Text"; // Default text
            textFont = new Font("Arial", 12); // Initial font size
            DoubleBuffered = true;
            Multiline = true;   
            TextChanged += AutoFitTextBoxTextChanged;
            AdjustFontSize();
        }

        private void AutoFitTextBoxTextChanged(object sender, EventArgs e)
        {
           Invalidate();
        }

        private void AdjustFontSize()
        {
            // Determine the maximum font size that fits within the control
            if (string.IsNullOrEmpty(text)) return;

            using (Graphics g = CreateGraphics())
            {
                float maxFontSize = 100; // Starting large
                float minFontSize = 1; // Minimum size
                SizeF textSize;

                // Binary search to find the maximum fitting font size
                while (maxFontSize - minFontSize > 0.5f)
                {
                    float testSize = (maxFontSize + minFontSize) / 2;
                    using (Font testFont = new Font(textFont.FontFamily, testSize))
                    {
                        textSize = g.MeasureString(text, testFont);

                        // Check if the text size fits within the control dimensions
                        if (textSize.Width <= Width && textSize.Height <= Height)
                        {
                            minFontSize = testSize;
                        }
                        else
                        {
                            maxFontSize = testSize;
                        }
                    }
                }

                textFont = new Font(textFont.FontFamily, minFontSize);
            }
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);

            // Clear the background
            e.Graphics.Clear(BackColor);

            // Draw the text at the center
            if (!string.IsNullOrEmpty(text))
            {
                SizeF textSize = e.Graphics.MeasureString(text, textFont);
                float x = (Width - textSize.Width) / 2;
                float y = (Height - textSize.Height) / 2;
                e.Graphics.DrawString(text, textFont, Brushes.Black, x, y);
            }
        }

        protected override void OnResize(EventArgs e)
        {
            base.OnResize(e);
            AdjustFontSize();
        }

        //public AutoFitTextBox()
        //{

        //    Multiline = true;
        //    //this.Resize += (s, e) => AdjustFontSize();
        //    //Leave+=(s,e)=> AdjustFontSize();
        //    //KeyPress += (s, e) => AdjustFontSize();
        //    TextChanged += AutoFitTextBoxTextChanged;
        //    Font = new Font(this.Font.FontFamily, 40, this.Font.Style);

        //    WordWrap = false;
        //}

        //private void AutoFitTextBoxTextAlignChanged(object sender, EventArgs e)
        //{
        //    AdjustFontSize();
        //}

        //private void AutoFitTextBoxTextChanged(object sender, EventArgs e)
        //{
        //    AdjustFontSize();
        //}

        //private void AdjustFontSize()
        //{
        //    if (string.IsNullOrEmpty(this.Text)) return;
        //    float FontSize = 100f;

        //    using (Graphics g = this.CreateGraphics())
        //    {
        //        while (FontSize > 0.5f)
        //        {
        //            Font testFont = new Font(this.Font.FontFamily, FontSize, this.Font.Style);
        //            SizeF textSize = TextRenderer.MeasureText(this.Text, testFont);

        //            if (textSize.Width <= this.ClientSize.Width && textSize.Height <= this.ClientSize.Height)
        //            {
        //                break;
        //            }
        //            else
        //            {
        //                FontSize -= 0.5f;
        //            }
        //        }
        //        this.Font = new Font(this.Font.FontFamily, FontSize, this.Font.Style);
        //    }

        //}

        //public AutoFitTextBox()
        //{
        //    this.Multiline = false; // Ensure the text box is single-line
        //    this.TextAlign = HorizontalAlignment.Center; // Center the text horizontally
        //}

        //protected override void OnTextChanged(EventArgs e)
        //{
        //    base.OnTextChanged(e);
        //    AdjustCaretPosition();
        //}

        //protected override void OnFontChanged(EventArgs e)
        //{
        //    base.OnFontChanged(e);
        //    AdjustCaretPosition();
        //}

        //private void AdjustCaretPosition()
        //{
        //    if (this.Text.Length == 0)
        //    {
        //        return;
        //    }

        //    int textBoxWidth = this.ClientSize.Width;
        //    int textWidth = TextRenderer.MeasureText(this.Text, this.Font).Width;

        //    if (textWidth < textBoxWidth)
        //    {
        //        // Calculate the caret position to be centered
        //        int position = this.Text.Length / 2;
        //        this.Select(position, 0);
        //        this.ScrollToCaret();
        //    }
        //}

        //protected override void OnPaint(PaintEventArgs e)
        //{
        //    base.OnPaint(e);
        //    // Custom painting code (if needed)
        //}
    }
}

