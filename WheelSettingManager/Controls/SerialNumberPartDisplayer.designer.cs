namespace SerialInspectionUI
{
    partial class SerialNumberPartDisplayer
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
            this.backPanel = new MaterialLibrary.MaterialPanel();
            this.txtBoxPnl = new MaterialLibrary.MaterialPanel();
            this.textBox = new SerialInspectionUI.ExtendedTextBox();
            this.backPanel.SuspendLayout();
            this.txtBoxPnl.SuspendLayout();
            this.SuspendLayout();
            // 
            // backPanel
            // 
            this.backPanel.BorderRadius = ((byte)(0));
            this.backPanel.Controls.Add(this.txtBoxPnl);
            this.backPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.backPanel.Location = new System.Drawing.Point(0, 0);
            this.backPanel.MaterialResource.UserColorPalette.DisabledColor.MainColor = System.Drawing.Color.DarkGray;
            this.backPanel.MaterialResource.UserColorPalette.DisabledColor.TextColor = System.Drawing.Color.DimGray;
            this.backPanel.MaterialResource.UserColorPalette.PrimaryColor.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.backPanel.MaterialResource.UserColorPalette.PrimaryColor.HighlightColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.backPanel.MaterialResource.UserColorPalette.PrimaryColor.HintColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(142)))), ((int)(((byte)(250)))));
            this.backPanel.MaterialResource.UserColorPalette.PrimaryColor.HoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.backPanel.MaterialResource.UserColorPalette.PrimaryColor.RippleColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.backPanel.MaterialResource.UserColorPalette.PrimaryColor.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.backPanel.MaterialResource.UserColorPalette.SecondaryColor.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.backPanel.MaterialResource.UserColorPalette.SecondaryColor.HintColor = System.Drawing.Color.DarkGray;
            this.backPanel.MaterialResource.UserColorPalette.SecondaryColor.MainColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.backPanel.MaterialResource.UserColorPalette.SecondaryDisabledColor.MainColor = System.Drawing.Color.DimGray;
            this.backPanel.MaterialResource.UserColorPalette.SecondaryDisabledColor.TextColor = System.Drawing.Color.DarkGray;
            this.backPanel.Name = "backPanel";
            this.backPanel.Size = new System.Drawing.Size(87, 78);
            this.backPanel.TabIndex = 0;
            // 
            // txtBoxPnl
            // 
            this.txtBoxPnl.BorderRadius = ((byte)(0));
            this.txtBoxPnl.Controls.Add(this.textBox);
            this.txtBoxPnl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtBoxPnl.DrawBorder = true;
            this.txtBoxPnl.Location = new System.Drawing.Point(0, 0);
            this.txtBoxPnl.MaterialResource.UserColorPalette.DisabledColor.MainColor = System.Drawing.Color.DarkGray;
            this.txtBoxPnl.MaterialResource.UserColorPalette.DisabledColor.TextColor = System.Drawing.Color.DimGray;
            this.txtBoxPnl.MaterialResource.UserColorPalette.PrimaryColor.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.txtBoxPnl.MaterialResource.UserColorPalette.PrimaryColor.HighlightColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.txtBoxPnl.MaterialResource.UserColorPalette.PrimaryColor.HintColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(142)))), ((int)(((byte)(250)))));
            this.txtBoxPnl.MaterialResource.UserColorPalette.PrimaryColor.HoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.txtBoxPnl.MaterialResource.UserColorPalette.PrimaryColor.RippleColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.txtBoxPnl.MaterialResource.UserColorPalette.PrimaryColor.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.txtBoxPnl.MaterialResource.UserColorPalette.SecondaryColor.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.txtBoxPnl.MaterialResource.UserColorPalette.SecondaryColor.HintColor = System.Drawing.Color.DarkGray;
            this.txtBoxPnl.MaterialResource.UserColorPalette.SecondaryColor.MainColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.txtBoxPnl.MaterialResource.UserColorPalette.SecondaryDisabledColor.MainColor = System.Drawing.Color.DimGray;
            this.txtBoxPnl.MaterialResource.UserColorPalette.SecondaryDisabledColor.TextColor = System.Drawing.Color.DarkGray;
            this.txtBoxPnl.Name = "txtBoxPnl";
            this.txtBoxPnl.Padding = new System.Windows.Forms.Padding(1);
            this.txtBoxPnl.Size = new System.Drawing.Size(87, 78);
            this.txtBoxPnl.TabIndex = 19;
            // 
            // textBox
            // 
            this.textBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(43)))), ((int)(((byte)(43)))));
            this.textBox.Location = new System.Drawing.Point(1, 1);
            this.textBox.Multiline = true;
            this.textBox.Name = "textBox";
            this.textBox.Size = new System.Drawing.Size(85, 76);
            this.textBox.TabIndex = 19;
            this.textBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textBox.ExtendedTextChanged += new System.EventHandler(this.OnTextChanged);
            this.textBox.Click += new System.EventHandler(this.OnControlClicked);
            this.textBox.MouseDown += new System.Windows.Forms.MouseEventHandler(this.OnTextBoxMouseDown);
            // 
            // SerialNumberPartDisplayer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.backPanel);
            this.MaterialResource.UserColorPalette.DisabledColor.MainColor = System.Drawing.Color.DarkGray;
            this.MaterialResource.UserColorPalette.DisabledColor.TextColor = System.Drawing.Color.DimGray;
            this.MaterialResource.UserColorPalette.PrimaryColor.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.MaterialResource.UserColorPalette.PrimaryColor.HighlightColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.MaterialResource.UserColorPalette.PrimaryColor.HintColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(142)))), ((int)(((byte)(250)))));
            this.MaterialResource.UserColorPalette.PrimaryColor.HoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.MaterialResource.UserColorPalette.PrimaryColor.RippleColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.MaterialResource.UserColorPalette.PrimaryColor.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.MaterialResource.UserColorPalette.SecondaryColor.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.MaterialResource.UserColorPalette.SecondaryColor.HintColor = System.Drawing.Color.DarkGray;
            this.MaterialResource.UserColorPalette.SecondaryColor.MainColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.MaterialResource.UserColorPalette.SecondaryDisabledColor.MainColor = System.Drawing.Color.DimGray;
            this.MaterialResource.UserColorPalette.SecondaryDisabledColor.TextColor = System.Drawing.Color.DarkGray;
            this.Name = "SerialNumberPartDisplayer";
            this.Size = new System.Drawing.Size(87, 78);
            this.backPanel.ResumeLayout(false);
            this.txtBoxPnl.ResumeLayout(false);
            this.txtBoxPnl.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private MaterialLibrary.MaterialPanel backPanel;
        private MaterialLibrary.MaterialPanel txtBoxPnl;
        private SerialInspectionUI.ExtendedTextBox textBox;
    }
}
