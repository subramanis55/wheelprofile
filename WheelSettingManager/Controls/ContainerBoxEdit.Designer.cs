using SerialInspectionUI;

namespace WheelSettingManager.Controls
{
    partial class ContainerBoxEdit
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.serialNumberPartDisplayer1 = new SerialNumberPartDisplayer();
            this.centeredCharTextBox1 = new WheelSettingManager.Controls.AutoFitTextBox();
            this.SuspendLayout();
            // 
            // serialNumberPartDisplayer1
            // 
            this.serialNumberPartDisplayer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.serialNumberPartDisplayer1.IsPrefix = false;
            this.serialNumberPartDisplayer1.Location = new System.Drawing.Point(0, 0);
            this.serialNumberPartDisplayer1.MaterialResource.UserColorPalette.DisabledColor.MainColor = System.Drawing.Color.DarkGray;
            this.serialNumberPartDisplayer1.MaterialResource.UserColorPalette.DisabledColor.TextColor = System.Drawing.Color.DimGray;
            this.serialNumberPartDisplayer1.MaterialResource.UserColorPalette.PrimaryColor.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.serialNumberPartDisplayer1.MaterialResource.UserColorPalette.PrimaryColor.HighlightColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.serialNumberPartDisplayer1.MaterialResource.UserColorPalette.PrimaryColor.HintColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(142)))), ((int)(((byte)(250)))));
            this.serialNumberPartDisplayer1.MaterialResource.UserColorPalette.PrimaryColor.HoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.serialNumberPartDisplayer1.MaterialResource.UserColorPalette.PrimaryColor.RippleColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.serialNumberPartDisplayer1.MaterialResource.UserColorPalette.PrimaryColor.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.serialNumberPartDisplayer1.MaterialResource.UserColorPalette.SecondaryColor.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.serialNumberPartDisplayer1.MaterialResource.UserColorPalette.SecondaryColor.HintColor = System.Drawing.Color.DarkGray;
            this.serialNumberPartDisplayer1.MaterialResource.UserColorPalette.SecondaryColor.MainColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.serialNumberPartDisplayer1.MaterialResource.UserColorPalette.SecondaryDisabledColor.MainColor = System.Drawing.Color.DimGray;
            this.serialNumberPartDisplayer1.MaterialResource.UserColorPalette.SecondaryDisabledColor.TextColor = System.Drawing.Color.DarkGray;
            this.serialNumberPartDisplayer1.Name = "serialNumberPartDisplayer1";
            this.serialNumberPartDisplayer1.ReadOnly = false;
            this.serialNumberPartDisplayer1.Size = new System.Drawing.Size(86, 85);
            this.serialNumberPartDisplayer1.SNPartString = null;
            this.serialNumberPartDisplayer1.TabIndex = 0;
            this.serialNumberPartDisplayer1.Text = "serialNumberPartDisplayer1";
            // 
            // centeredCharTextBox1
            // 
            this.centeredCharTextBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.centeredCharTextBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 32.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.centeredCharTextBox1.Location = new System.Drawing.Point(0, 0);
            this.centeredCharTextBox1.Multiline = true;
            this.centeredCharTextBox1.Name = "centeredCharTextBox1";
            this.centeredCharTextBox1.Size = new System.Drawing.Size(86, 85);
            this.centeredCharTextBox1.TabIndex = 1;
            //this.centeredCharTextBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // ContainerBoxEdit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.centeredCharTextBox1);
            this.Controls.Add(this.serialNumberPartDisplayer1);
            this.Name = "ContainerBoxEdit";
            this.Size = new System.Drawing.Size(86, 85);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private SerialNumberPartDisplayer serialNumberPartDisplayer1;
        private AutoFitTextBox centeredCharTextBox1;
    }
}
