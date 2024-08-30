using MaterialLibrary;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WheelSettingManager.Controls;

namespace SerialNumberInspectionUI.Controls
{
   public class ContainerBox : MaterialPanel
    {
        public ContainerBox()
        {
            ControlAdded += ContainerBoxControlAdded;
            Padding = new Padding(3);
            MouseEnter += ContainerBoxMouseEnter;
            MouseLeave += ContainerBoxMouseLeave;
            DoubleClick += ContainerBoxEditDoubleClick;
            AutoFitTextBox.LostFocus += AutoFitTextBoxLostFocus;
        }
        private bool isSelected;
        private bool isHover = false;
        private Rectangle SelectedRectangle;
        private int borderRadius = 4;
        private Color selectedColor = Color.DodgerBlue;
        AutoFitTextBox AutoFitTextBox = new AutoFitTextBox() { Dock = DockStyle.Fill };
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
                Controls.Add(AutoFitTextBox);
                AutoFitTextBox.Focus();
            }
        }
        private void AutoFitTextBoxLostFocus(object sender, EventArgs e)
        {
            Controls.Remove(AutoFitTextBox);
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
            IsSelected = false;
        }
    }
}
