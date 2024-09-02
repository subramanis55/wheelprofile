using GoLibrary;
using System;
using System.ComponentModel;
using System.Drawing;
using System.Globalization;
using System.Runtime.CompilerServices;
using System.Threading;
using System.Windows.Forms;

namespace MaterialLibrary
{
	partial class MTextBox
	{
		private IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
		{
            this.components = new System.ComponentModel.Container();
            this.IncrementTimer = new System.Windows.Forms.Timer(this.components);
            this.IncStartTimer = new System.Windows.Forms.Timer(this.components);
            this.IncLbl = new MaterialLibrary.MaterialLabel();
            this.ButtonsContainerPanel = new MaterialLibrary.MaterialPanel();
            this.ButtonsContainerPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // IncrementTimer
            // 
            this.IncrementTimer.Interval = 350;
            // 
            // IncStartTimer
            // 
            this.IncStartTimer.Interval = 500;
            // 
            // IncLbl
            // 
            this.IncLbl.AutoAdjustFont = true;
            this.IncLbl.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.IncLbl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.IncLbl.EmbossColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.IncLbl.ForeColor = System.Drawing.Color.Black;
            this.IncLbl.Location = new System.Drawing.Point(0, 0);
            this.IncLbl.MaterialResource.UseParentPalette = true;
            this.IncLbl.MaterialResource.UserColorPalette.DisabledColor.MainColor = System.Drawing.Color.DarkGray;
            this.IncLbl.MaterialResource.UserColorPalette.DisabledColor.TextColor = System.Drawing.Color.DimGray;
            this.IncLbl.MaterialResource.UserColorPalette.PrimaryColor.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.IncLbl.MaterialResource.UserColorPalette.PrimaryColor.HighlightColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.IncLbl.MaterialResource.UserColorPalette.PrimaryColor.HintColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(142)))), ((int)(((byte)(250)))));
            this.IncLbl.MaterialResource.UserColorPalette.PrimaryColor.HoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.IncLbl.MaterialResource.UserColorPalette.PrimaryColor.RippleColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.IncLbl.MaterialResource.UserColorPalette.PrimaryColor.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.IncLbl.MaterialResource.UserColorPalette.SecondaryColor.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.IncLbl.MaterialResource.UserColorPalette.SecondaryColor.HintColor = System.Drawing.Color.DarkGray;
            this.IncLbl.MaterialResource.UserColorPalette.SecondaryColor.MainColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.IncLbl.MaterialResource.UserColorPalette.SecondaryDisabledColor.MainColor = System.Drawing.Color.DimGray;
            this.IncLbl.MaterialResource.UserColorPalette.SecondaryDisabledColor.TextColor = System.Drawing.Color.DarkGray;
            this.IncLbl.Name = "IncLbl";
            this.IncLbl.NormalFont = new System.Drawing.Font("Calibri", 35F, System.Drawing.FontStyle.Bold);
            this.IncLbl.Size = new System.Drawing.Size(259, 78);
            this.IncLbl.TabIndex = 3;
            this.IncLbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // ButtonsContainerPanel
            // 
            this.ButtonsContainerPanel.BorderRadius = ((byte)(0));
            this.ButtonsContainerPanel.Controls.Add(this.IncLbl);
            this.ButtonsContainerPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ButtonsContainerPanel.Location = new System.Drawing.Point(0, 0);
            this.ButtonsContainerPanel.MaterialResource.UserColorPalette.DisabledColor.MainColor = System.Drawing.Color.DarkGray;
            this.ButtonsContainerPanel.MaterialResource.UserColorPalette.DisabledColor.TextColor = System.Drawing.Color.DimGray;
            this.ButtonsContainerPanel.MaterialResource.UserColorPalette.PrimaryColor.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.ButtonsContainerPanel.MaterialResource.UserColorPalette.PrimaryColor.HighlightColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.ButtonsContainerPanel.MaterialResource.UserColorPalette.PrimaryColor.HintColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(142)))), ((int)(((byte)(250)))));
            this.ButtonsContainerPanel.MaterialResource.UserColorPalette.PrimaryColor.HoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.ButtonsContainerPanel.MaterialResource.UserColorPalette.PrimaryColor.RippleColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.ButtonsContainerPanel.MaterialResource.UserColorPalette.PrimaryColor.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.ButtonsContainerPanel.MaterialResource.UserColorPalette.SecondaryColor.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.ButtonsContainerPanel.MaterialResource.UserColorPalette.SecondaryColor.HintColor = System.Drawing.Color.DarkGray;
            this.ButtonsContainerPanel.MaterialResource.UserColorPalette.SecondaryColor.MainColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.ButtonsContainerPanel.MaterialResource.UserColorPalette.SecondaryDisabledColor.MainColor = System.Drawing.Color.DimGray;
            this.ButtonsContainerPanel.MaterialResource.UserColorPalette.SecondaryDisabledColor.TextColor = System.Drawing.Color.DarkGray;
            this.ButtonsContainerPanel.Name = "ButtonsContainerPanel";
            this.ButtonsContainerPanel.Size = new System.Drawing.Size(259, 78);
            this.ButtonsContainerPanel.TabIndex = 6;
            // 
            // MTextBox
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.ButtonsContainerPanel);
            this.MaterialResource.ColorPaletteName = "";
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
            this.Name = "MTextBox";
            this.Size = new System.Drawing.Size(259, 78);
            this.ButtonsContainerPanel.ResumeLayout(false);
            this.ResumeLayout(false);

		}

        private System.Windows.Forms.Timer IncrementTimer;
        private System.Windows.Forms.Timer IncStartTimer;
        private MaterialLibrary.MaterialLabel IncLbl;
        private MaterialPanel ButtonsContainerPanel;
    }
}