using MaterialLibrary;
using SerialNumberInspectionUI.Denomination.Controls.SNCharBox;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WheelSettingManager.Controls;

namespace SerialNumberInspectionUI.Controls
{
   public class ContainerBox : MaterialPanel
    {

        // Import necessary functions from user32.dll
        [DllImport("user32.dll")]
        private static extern int ToUnicodeEx(
        uint wVirtKey,
        uint wScanCode,
        byte[] lpKeyState,
        [Out, MarshalAs(UnmanagedType.LPWStr)] StringBuilder pwszBuff,
        int cchBuff,
        uint wFlags,
        IntPtr dwhkl);

        [DllImport("user32.dll")]
        private static extern bool GetKeyboardState(byte[] lpKeyState);

        [DllImport("user32.dll")]
        private static extern IntPtr GetKeyboardLayout(uint idThread);
        public ContainerBox()
        {
            ControlAdded += ContainerBoxControlAdded;
            Padding = new Padding(3);
            MouseEnter += ContainerBoxMouseEnter;
            MouseLeave += ContainerBoxMouseLeave;
            Click += ContainerBox_Click;
            DoubleClick += ContainerBoxEditDoubleClick;
            AutoFitTextBox.LostFocus += AutoFitTextBoxLostFocus;
            LostFocus += ContainerBoxLostFocus;
            this.SetStyle(ControlStyles.Selectable, true);
            this.TabStop = true; // Allow the control to receive focus
            this.Focus();
        }

        protected override void OnKeyDown(KeyEventArgs e)
        {

            // Handle Backspace key
            if (e.KeyCode == Keys.Back)
            {
                if (label.Text.Length > 0)
                {
                    // Remove the last character from the label
                    label.Text = label.Text.Substring(0, label.Text.Length - 1);
                }
                e.SuppressKeyPress = true; // Prevents the backspace key from affecting the TextBox
            }
            // Handle Space key
            else if (e.KeyCode == Keys.Space)
            {
                label.Text += " ";
                e.SuppressKeyPress = true; // Prevents the space key from adding a space to the TextBox
            }
            // Handle Tab key
            else if (e.KeyCode == Keys.Tab)
            {
                label.Text += "    "; // Adds four spaces for a tab-like effect
                e.SuppressKeyPress = true; // Prevents the tab key from moving focus to the next control
            }
            // Handle normal characters via KeyPress event automatically
            else
            {
                // Appending uppercase letters to the label
                label.Text += ConvertKeyToText( e);
            }

            e.Handled = true;
        }
        private string ConvertKeyToText(KeyEventArgs e)
        {
            byte[] keyboardState = new byte[256];
            GetKeyboardState(keyboardState); // Get the current keyboard state

            // Get the current keyboard layout
            IntPtr keyboardLayout = GetKeyboardLayout(0); // 0 gets the current thread layout

            // Buffer to store the resulting character
            StringBuilder charBuffer = new StringBuilder(2);

            // Convert the key code and state to the actual character using ToUnicodeEx
            int result = ToUnicodeEx(
                (uint)e.KeyCode,
                (uint)e.KeyValue,
                keyboardState,
                charBuffer,
                charBuffer.Capacity,
                0,
                keyboardLayout);

            // Return the resulting character if conversion was successful
            return result > 0 ? charBuffer.ToString() : string.Empty;
        }
        private void ContainerBoxLostFocus(object sender, EventArgs e)
        {
            
        }

        private void ContainerBox_Click(object sender, EventArgs e)
        {
           //Focus();
        }
        
        private bool isSelected;
        private bool isHover = false;
        private Rectangle SelectedRectangle;
        private int borderRadius = 4;
        private Color selectedColor = Color.DodgerBlue;
        
        AutoFitTextBox AutoFitTextBox = new AutoFitTextBox() { Dock = DockStyle.Fill,WordWrap=false };
        MaterialLabel label=new MaterialLabel() {Dock=DockStyle.Fill ,AutoAdjustFont=true,TextAlign=ContentAlignment.MiddleCenter};    
        public bool IsHover
        {
            set
            {
                if(Controls.Count==0) {
                    isHover = value;
                    Invalidate();
                }
                else{
                    isHover = false;
                    Invalidate();
                }
               
            }
            get
            {
                return isHover;
            }
        }
        public Color SelectedColor
        {
            set
            {
                selectedColor = value;
            }
            get
            {
                return selectedColor;
            }
        }
        public int BorderRadius
        {
            set
            {
                borderRadius = value;
            }
            get
            {
                return borderRadius;
            }
        }
        public bool IsSelected
        {
            set
            {
                isSelected = value;
                Invalidate();
            }
            get
            {
                return isSelected;
            }

        }
       
        private void ContainerBoxEditDoubleClick(object sender, EventArgs e)
        {
            if (!(Controls.Count > 0))
            {
                //Controls.Add(AutoFitTextBox);
                Controls.Add(label);
                this.Focus();
            }
        }
        private void AutoFitTextBoxLostFocus(object sender, EventArgs e)
        {
            Controls.Remove(label);
            //Controls.Remove(AutoFitTextBox);
        }


        private void ContainerBoxMouseLeave(object sender, EventArgs e)
        {
            IsHover = false;
          
        }

        private void ContainerBoxMouseEnter(object sender, EventArgs e)
        {
            IsHover = true;

        }

        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);
            e.Graphics.SmoothingMode = SmoothingMode.AntiAlias;
            if (isSelected || isHover)
            {
                using (Pen OuterBrush = new Pen(selectedColor, 2))
                {
                    GraphicsPath OuterPath = CreateRoundRectPath(new Rectangle(1, 1, Width - 3, Height - 3), BorderRadius);

                    e.Graphics.DrawPath(OuterBrush, OuterPath);
                }
            }
            else
            {
                using (Pen OuterBrush = new Pen(Color.Gainsboro, 2))
                {
                    GraphicsPath OuterPath = CreateRoundRectPath(new Rectangle(1, 1, Width - 3, Height - 3), BorderRadius);
                    e.Graphics.DrawPath(OuterBrush, OuterPath);
                }
            }

            using (Brush OuterBrush = new SolidBrush(Color.White))
            {
                GraphicsPath OuterPath = CreateRoundRectPath(new Rectangle(2, 2, Width - 5, Height - 5), BorderRadius);
                e.Graphics.FillPath(OuterBrush, OuterPath);
            }
        }

        private GraphicsPath CreateRoundRectPath(Rectangle rect, int radius)
        {
            radius *= 2;
            GraphicsPath path = new GraphicsPath();
            path.StartFigure();
            path.AddArc(rect.X, rect.Y, radius, radius, 180, 90);
            path.AddArc(rect.Right - radius, rect.Y, radius, radius, 270, 90);
            path.AddArc(rect.Right - radius, rect.Bottom - radius, radius, radius, 0, 90);
            path.AddArc(rect.X, rect.Bottom - radius, radius, radius, 90, 90);
            path.CloseFigure();
            return path;
        }

        private void ContainerBoxControlAdded(object sender, ControlEventArgs e)
        {
            if(e.Control is SNCharBox) 
            IsSelected = false;
        }
    }
}
