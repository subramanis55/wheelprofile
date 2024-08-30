namespace WheelSettingManager.Controls
{
    partial class WheelSettingProfileViewControl
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
            this.DenominationViewContanierPanel = new System.Windows.Forms.Panel();
            this.charBoxesMainPanel = new MaterialLibrary.MaterialPanel();
            this.charBoxesContinarParentPanel = new MaterialLibrary.MaterialAutoPanel();
            this.charBoxesContinarPanel = new MaterialLibrary.MaterialFlowLayoutPanel();
            this.materialPanel1 = new MaterialLibrary.MaterialPanel();
            this.materialPanel2 = new MaterialLibrary.MaterialPanel();
            this.autoFitTextBox1 = new WheelSettingManager.Controls.AutoFitTextBox();
            this.materialPanel4 = new MaterialLibrary.MaterialPanel();
            this.materialPanel5 = new MaterialLibrary.MaterialPanel();
            this.denoteingSymbolLabel = new SerialNumberInspectionUI.Denomination.Controls.SNCharBox.SNCharBox();
            this.materialLabel1 = new MaterialLibrary.MaterialLabel();
            this.nativeLanguageTrueLabel = new MaterialLibrary.MaterialLabel();
            this.materialPanel3 = new MaterialLibrary.MaterialPanel();
            this.wheelSettingsComboBox = new MaterialLibrary.MaterialComboBox();
            this.denominationHeaderLbl = new MaterialLibrary.MaterialLabel();
            this.serialNumberPartDisplayer1 = new SerialInspectionUI.SerialNumberPartDisplayer();
            this.DenominationViewContanierPanel.SuspendLayout();
            this.charBoxesMainPanel.SuspendLayout();
            this.charBoxesContinarParentPanel.SuspendLayout();
            this.materialPanel1.SuspendLayout();
            this.materialPanel2.SuspendLayout();
            this.materialPanel4.SuspendLayout();
            this.materialPanel5.SuspendLayout();
            this.materialPanel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // DenominationViewContanierPanel
            // 
            this.DenominationViewContanierPanel.Controls.Add(this.charBoxesMainPanel);
            this.DenominationViewContanierPanel.Controls.Add(this.materialPanel1);
            this.DenominationViewContanierPanel.Controls.Add(this.denominationHeaderLbl);
            this.DenominationViewContanierPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.DenominationViewContanierPanel.Location = new System.Drawing.Point(0, 0);
            this.DenominationViewContanierPanel.Name = "DenominationViewContanierPanel";
            this.DenominationViewContanierPanel.Size = new System.Drawing.Size(817, 513);
            this.DenominationViewContanierPanel.TabIndex = 2;
            this.DenominationViewContanierPanel.Resize += new System.EventHandler(this.WheelSettingContanierPanelResize);
            // 
            // charBoxesMainPanel
            // 
            this.charBoxesMainPanel.BorderRadius = ((byte)(5));
            this.charBoxesMainPanel.Controls.Add(this.charBoxesContinarParentPanel);
            this.charBoxesMainPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.charBoxesMainPanel.Location = new System.Drawing.Point(0, 214);
            this.charBoxesMainPanel.MaterialResource.UserColorPalette.DisabledColor.MainColor = System.Drawing.Color.DarkGray;
            this.charBoxesMainPanel.MaterialResource.UserColorPalette.DisabledColor.TextColor = System.Drawing.Color.DimGray;
            this.charBoxesMainPanel.MaterialResource.UserColorPalette.PrimaryColor.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.charBoxesMainPanel.MaterialResource.UserColorPalette.PrimaryColor.HighlightColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.charBoxesMainPanel.MaterialResource.UserColorPalette.PrimaryColor.HintColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(142)))), ((int)(((byte)(250)))));
            this.charBoxesMainPanel.MaterialResource.UserColorPalette.PrimaryColor.HoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.charBoxesMainPanel.MaterialResource.UserColorPalette.PrimaryColor.RippleColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.charBoxesMainPanel.MaterialResource.UserColorPalette.PrimaryColor.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.charBoxesMainPanel.MaterialResource.UserColorPalette.SecondaryColor.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.charBoxesMainPanel.MaterialResource.UserColorPalette.SecondaryColor.HintColor = System.Drawing.Color.DarkGray;
            this.charBoxesMainPanel.MaterialResource.UserColorPalette.SecondaryColor.MainColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.charBoxesMainPanel.MaterialResource.UserColorPalette.SecondaryDisabledColor.MainColor = System.Drawing.Color.DimGray;
            this.charBoxesMainPanel.MaterialResource.UserColorPalette.SecondaryDisabledColor.TextColor = System.Drawing.Color.DarkGray;
            this.charBoxesMainPanel.Name = "charBoxesMainPanel";
            this.charBoxesMainPanel.Padding = new System.Windows.Forms.Padding(10);
            this.charBoxesMainPanel.Size = new System.Drawing.Size(817, 299);
            this.charBoxesMainPanel.TabIndex = 1;
            this.charBoxesMainPanel.UseCustomBorderColor = true;
            this.charBoxesMainPanel.UseShade = true;
            // 
            // charBoxesContinarParentPanel
            // 
            this.charBoxesContinarParentPanel.BorderRadius = ((byte)(5));
            this.charBoxesContinarParentPanel.Controls.Add(this.charBoxesContinarPanel);
            this.charBoxesContinarParentPanel.DrawBorder = true;
            this.charBoxesContinarParentPanel.Location = new System.Drawing.Point(213, 55);
            this.charBoxesContinarParentPanel.MaterialResource.CustomPaletteMode.UseCustomBorderColor = true;
            this.charBoxesContinarParentPanel.MaterialResource.CustomPaletteMode.UseFullCustomPalette = false;
            this.charBoxesContinarParentPanel.MaterialResource.UserColorPalette.BorderWidth = 3F;
            this.charBoxesContinarParentPanel.MaterialResource.UserColorPalette.DisabledColor.MainColor = System.Drawing.Color.DarkGray;
            this.charBoxesContinarParentPanel.MaterialResource.UserColorPalette.DisabledColor.TextColor = System.Drawing.Color.DimGray;
            this.charBoxesContinarParentPanel.MaterialResource.UserColorPalette.LineWidth = 3F;
            this.charBoxesContinarParentPanel.MaterialResource.UserColorPalette.PrimaryColor.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.charBoxesContinarParentPanel.MaterialResource.UserColorPalette.PrimaryColor.BorderWidth = 3F;
            this.charBoxesContinarParentPanel.MaterialResource.UserColorPalette.PrimaryColor.HighlightColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.charBoxesContinarParentPanel.MaterialResource.UserColorPalette.PrimaryColor.HintColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(142)))), ((int)(((byte)(250)))));
            this.charBoxesContinarParentPanel.MaterialResource.UserColorPalette.PrimaryColor.HoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.charBoxesContinarParentPanel.MaterialResource.UserColorPalette.PrimaryColor.LineWidth = 3F;
            this.charBoxesContinarParentPanel.MaterialResource.UserColorPalette.PrimaryColor.RippleColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.charBoxesContinarParentPanel.MaterialResource.UserColorPalette.PrimaryColor.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.charBoxesContinarParentPanel.MaterialResource.UserColorPalette.SecondaryColor.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.charBoxesContinarParentPanel.MaterialResource.UserColorPalette.SecondaryColor.HintColor = System.Drawing.Color.DarkGray;
            this.charBoxesContinarParentPanel.MaterialResource.UserColorPalette.SecondaryColor.MainColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.charBoxesContinarParentPanel.MaterialResource.UserColorPalette.SecondaryDisabledColor.MainColor = System.Drawing.Color.DimGray;
            this.charBoxesContinarParentPanel.MaterialResource.UserColorPalette.SecondaryDisabledColor.TextColor = System.Drawing.Color.DarkGray;
            this.charBoxesContinarParentPanel.Name = "charBoxesContinarParentPanel";
            this.charBoxesContinarParentPanel.Padding = new System.Windows.Forms.Padding(5);
            this.charBoxesContinarParentPanel.Size = new System.Drawing.Size(200, 100);
            this.charBoxesContinarParentPanel.TabIndex = 2;
            // 
            // charBoxesContinarPanel
            // 
            this.charBoxesContinarPanel.AutoScroll = true;
            this.charBoxesContinarPanel.Location = new System.Drawing.Point(5, 5);
            this.charBoxesContinarPanel.Margin = new System.Windows.Forms.Padding(0);
            this.charBoxesContinarPanel.MaterialResource.UserColorPalette.DisabledColor.MainColor = System.Drawing.Color.DarkGray;
            this.charBoxesContinarPanel.MaterialResource.UserColorPalette.DisabledColor.TextColor = System.Drawing.Color.DimGray;
            this.charBoxesContinarPanel.MaterialResource.UserColorPalette.PrimaryColor.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.charBoxesContinarPanel.MaterialResource.UserColorPalette.PrimaryColor.HighlightColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.charBoxesContinarPanel.MaterialResource.UserColorPalette.PrimaryColor.HintColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(142)))), ((int)(((byte)(250)))));
            this.charBoxesContinarPanel.MaterialResource.UserColorPalette.PrimaryColor.HoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.charBoxesContinarPanel.MaterialResource.UserColorPalette.PrimaryColor.RippleColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.charBoxesContinarPanel.MaterialResource.UserColorPalette.PrimaryColor.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.charBoxesContinarPanel.MaterialResource.UserColorPalette.SecondaryColor.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.charBoxesContinarPanel.MaterialResource.UserColorPalette.SecondaryColor.HintColor = System.Drawing.Color.DarkGray;
            this.charBoxesContinarPanel.MaterialResource.UserColorPalette.SecondaryColor.MainColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.charBoxesContinarPanel.MaterialResource.UserColorPalette.SecondaryDisabledColor.MainColor = System.Drawing.Color.DimGray;
            this.charBoxesContinarPanel.MaterialResource.UserColorPalette.SecondaryDisabledColor.TextColor = System.Drawing.Color.DarkGray;
            this.charBoxesContinarPanel.Name = "charBoxesContinarPanel";
            this.charBoxesContinarPanel.Padding = new System.Windows.Forms.Padding(10, 0, 10, 0);
            this.charBoxesContinarPanel.Size = new System.Drawing.Size(190, 90);
            this.charBoxesContinarPanel.TabIndex = 1;
            this.charBoxesContinarPanel.Resize += new System.EventHandler(this.CharBoxesContinarPanelResize);
            // 
            // materialPanel1
            // 
            this.materialPanel1.BorderRadius = ((byte)(0));
            this.materialPanel1.Controls.Add(this.materialPanel2);
            this.materialPanel1.Controls.Add(this.materialPanel3);
            this.materialPanel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.materialPanel1.Location = new System.Drawing.Point(0, 38);
            this.materialPanel1.MaterialResource.UserColorPalette.DisabledColor.MainColor = System.Drawing.Color.DarkGray;
            this.materialPanel1.MaterialResource.UserColorPalette.DisabledColor.TextColor = System.Drawing.Color.DimGray;
            this.materialPanel1.MaterialResource.UserColorPalette.PrimaryColor.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.materialPanel1.MaterialResource.UserColorPalette.PrimaryColor.HighlightColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.materialPanel1.MaterialResource.UserColorPalette.PrimaryColor.HintColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(142)))), ((int)(((byte)(250)))));
            this.materialPanel1.MaterialResource.UserColorPalette.PrimaryColor.HoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.materialPanel1.MaterialResource.UserColorPalette.PrimaryColor.RippleColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.materialPanel1.MaterialResource.UserColorPalette.PrimaryColor.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.materialPanel1.MaterialResource.UserColorPalette.SecondaryColor.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.materialPanel1.MaterialResource.UserColorPalette.SecondaryColor.HintColor = System.Drawing.Color.DarkGray;
            this.materialPanel1.MaterialResource.UserColorPalette.SecondaryColor.MainColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.materialPanel1.MaterialResource.UserColorPalette.SecondaryDisabledColor.MainColor = System.Drawing.Color.DimGray;
            this.materialPanel1.MaterialResource.UserColorPalette.SecondaryDisabledColor.TextColor = System.Drawing.Color.DarkGray;
            this.materialPanel1.Name = "materialPanel1";
            this.materialPanel1.Size = new System.Drawing.Size(817, 176);
            this.materialPanel1.TabIndex = 2;
            // 
            // materialPanel2
            // 
            this.materialPanel2.BorderRadius = ((byte)(0));
            this.materialPanel2.Controls.Add(this.serialNumberPartDisplayer1);
            this.materialPanel2.Controls.Add(this.autoFitTextBox1);
            this.materialPanel2.Controls.Add(this.materialPanel4);
            this.materialPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.materialPanel2.Location = new System.Drawing.Point(0, 61);
            this.materialPanel2.MaterialResource.UserColorPalette.DisabledColor.MainColor = System.Drawing.Color.DarkGray;
            this.materialPanel2.MaterialResource.UserColorPalette.DisabledColor.TextColor = System.Drawing.Color.DimGray;
            this.materialPanel2.MaterialResource.UserColorPalette.PrimaryColor.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.materialPanel2.MaterialResource.UserColorPalette.PrimaryColor.HighlightColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.materialPanel2.MaterialResource.UserColorPalette.PrimaryColor.HintColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(142)))), ((int)(((byte)(250)))));
            this.materialPanel2.MaterialResource.UserColorPalette.PrimaryColor.HoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.materialPanel2.MaterialResource.UserColorPalette.PrimaryColor.RippleColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.materialPanel2.MaterialResource.UserColorPalette.PrimaryColor.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.materialPanel2.MaterialResource.UserColorPalette.SecondaryColor.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.materialPanel2.MaterialResource.UserColorPalette.SecondaryColor.HintColor = System.Drawing.Color.DarkGray;
            this.materialPanel2.MaterialResource.UserColorPalette.SecondaryColor.MainColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.materialPanel2.MaterialResource.UserColorPalette.SecondaryDisabledColor.MainColor = System.Drawing.Color.DimGray;
            this.materialPanel2.MaterialResource.UserColorPalette.SecondaryDisabledColor.TextColor = System.Drawing.Color.DarkGray;
            this.materialPanel2.Name = "materialPanel2";
            this.materialPanel2.Size = new System.Drawing.Size(817, 115);
            this.materialPanel2.TabIndex = 1;
            // 
            // autoFitTextBox1
            // 
            this.autoFitTextBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.121094F);
            this.autoFitTextBox1.Location = new System.Drawing.Point(671, 22);
            this.autoFitTextBox1.Name = "autoFitTextBox1";
            this.autoFitTextBox1.Size = new System.Drawing.Size(113, 57);
            this.autoFitTextBox1.TabIndex = 1;
            this.autoFitTextBox1.Text = "";
            // 
            // materialPanel4
            // 
            this.materialPanel4.BorderRadius = ((byte)(0));
            this.materialPanel4.Controls.Add(this.materialPanel5);
            this.materialPanel4.Controls.Add(this.nativeLanguageTrueLabel);
            this.materialPanel4.Location = new System.Drawing.Point(255, 6);
            this.materialPanel4.MaterialResource.CustomPaletteMode.UseCustomPalette = true;
            this.materialPanel4.MaterialResource.InvertColorPalette = true;
            this.materialPanel4.MaterialResource.UserColorPalette.DisabledColor.MainColor = System.Drawing.Color.DarkGray;
            this.materialPanel4.MaterialResource.UserColorPalette.DisabledColor.TextColor = System.Drawing.Color.DimGray;
            this.materialPanel4.MaterialResource.UserColorPalette.PrimaryColor.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.materialPanel4.MaterialResource.UserColorPalette.PrimaryColor.HighlightColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.materialPanel4.MaterialResource.UserColorPalette.PrimaryColor.HintColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(142)))), ((int)(((byte)(250)))));
            this.materialPanel4.MaterialResource.UserColorPalette.PrimaryColor.HoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.materialPanel4.MaterialResource.UserColorPalette.PrimaryColor.RippleColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.materialPanel4.MaterialResource.UserColorPalette.PrimaryColor.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.materialPanel4.MaterialResource.UserColorPalette.SecondaryColor.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.materialPanel4.MaterialResource.UserColorPalette.SecondaryColor.HintColor = System.Drawing.Color.DarkGray;
            this.materialPanel4.MaterialResource.UserColorPalette.SecondaryColor.MainColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.materialPanel4.MaterialResource.UserColorPalette.SecondaryDisabledColor.MainColor = System.Drawing.Color.DimGray;
            this.materialPanel4.MaterialResource.UserColorPalette.SecondaryDisabledColor.TextColor = System.Drawing.Color.DarkGray;
            this.materialPanel4.Name = "materialPanel4";
            this.materialPanel4.Size = new System.Drawing.Size(278, 107);
            this.materialPanel4.TabIndex = 0;
            // 
            // materialPanel5
            // 
            this.materialPanel5.BorderRadius = ((byte)(0));
            this.materialPanel5.Controls.Add(this.denoteingSymbolLabel);
            this.materialPanel5.Controls.Add(this.materialLabel1);
            this.materialPanel5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.materialPanel5.Location = new System.Drawing.Point(0, 0);
            this.materialPanel5.MaterialResource.UserColorPalette.DisabledColor.MainColor = System.Drawing.Color.DarkGray;
            this.materialPanel5.MaterialResource.UserColorPalette.DisabledColor.TextColor = System.Drawing.Color.DimGray;
            this.materialPanel5.MaterialResource.UserColorPalette.PrimaryColor.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.materialPanel5.MaterialResource.UserColorPalette.PrimaryColor.HighlightColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.materialPanel5.MaterialResource.UserColorPalette.PrimaryColor.HintColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(142)))), ((int)(((byte)(250)))));
            this.materialPanel5.MaterialResource.UserColorPalette.PrimaryColor.HoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.materialPanel5.MaterialResource.UserColorPalette.PrimaryColor.RippleColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.materialPanel5.MaterialResource.UserColorPalette.PrimaryColor.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.materialPanel5.MaterialResource.UserColorPalette.SecondaryColor.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.materialPanel5.MaterialResource.UserColorPalette.SecondaryColor.HintColor = System.Drawing.Color.DarkGray;
            this.materialPanel5.MaterialResource.UserColorPalette.SecondaryColor.MainColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.materialPanel5.MaterialResource.UserColorPalette.SecondaryDisabledColor.MainColor = System.Drawing.Color.DimGray;
            this.materialPanel5.MaterialResource.UserColorPalette.SecondaryDisabledColor.TextColor = System.Drawing.Color.DarkGray;
            this.materialPanel5.Name = "materialPanel5";
            this.materialPanel5.Padding = new System.Windows.Forms.Padding(5);
            this.materialPanel5.Size = new System.Drawing.Size(278, 64);
            this.materialPanel5.TabIndex = 1;
            // 
            // denoteingSymbolLabel
            // 
            this.denoteingSymbolLabel.Dock = System.Windows.Forms.DockStyle.Right;
            this.denoteingSymbolLabel.LanguageCharactersHolder = null;
            this.denoteingSymbolLabel.Location = new System.Drawing.Point(209, 5);
            this.denoteingSymbolLabel.MaterialResource.CustomPaletteMode.UseCustomPalette = true;
            this.denoteingSymbolLabel.MaterialResource.UserColorPalette.DisabledColor.MainColor = System.Drawing.Color.DarkGray;
            this.denoteingSymbolLabel.MaterialResource.UserColorPalette.DisabledColor.TextColor = System.Drawing.Color.DimGray;
            this.denoteingSymbolLabel.MaterialResource.UserColorPalette.PrimaryColor.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.denoteingSymbolLabel.MaterialResource.UserColorPalette.PrimaryColor.HighlightColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.denoteingSymbolLabel.MaterialResource.UserColorPalette.PrimaryColor.HintColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(142)))), ((int)(((byte)(250)))));
            this.denoteingSymbolLabel.MaterialResource.UserColorPalette.PrimaryColor.HoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.denoteingSymbolLabel.MaterialResource.UserColorPalette.PrimaryColor.RippleColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.denoteingSymbolLabel.MaterialResource.UserColorPalette.PrimaryColor.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.denoteingSymbolLabel.MaterialResource.UserColorPalette.SecondaryColor.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.denoteingSymbolLabel.MaterialResource.UserColorPalette.SecondaryColor.HintColor = System.Drawing.Color.DarkGray;
            this.denoteingSymbolLabel.MaterialResource.UserColorPalette.SecondaryColor.MainColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.denoteingSymbolLabel.MaterialResource.UserColorPalette.SecondaryDisabledColor.MainColor = System.Drawing.Color.DimGray;
            this.denoteingSymbolLabel.MaterialResource.UserColorPalette.SecondaryDisabledColor.TextColor = System.Drawing.Color.DarkGray;
            this.denoteingSymbolLabel.Name = "denoteingSymbolLabel";
            this.denoteingSymbolLabel.Size = new System.Drawing.Size(64, 54);
            this.denoteingSymbolLabel.TabIndex = 2;
            this.denoteingSymbolLabel.Text = "snCharBox1";
            // 
            // materialLabel1
            // 
            this.materialLabel1.AutoAdjustFont = true;
            this.materialLabel1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.materialLabel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.materialLabel1.Font = new System.Drawing.Font("Calibri", 15.76638F, System.Drawing.FontStyle.Bold);
            this.materialLabel1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.materialLabel1.Location = new System.Drawing.Point(5, 5);
            this.materialLabel1.MaterialResource.UserColorPalette.DisabledColor.MainColor = System.Drawing.Color.DarkGray;
            this.materialLabel1.MaterialResource.UserColorPalette.DisabledColor.TextColor = System.Drawing.Color.DimGray;
            this.materialLabel1.MaterialResource.UserColorPalette.PrimaryColor.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.materialLabel1.MaterialResource.UserColorPalette.PrimaryColor.HighlightColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.materialLabel1.MaterialResource.UserColorPalette.PrimaryColor.HintColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(142)))), ((int)(((byte)(250)))));
            this.materialLabel1.MaterialResource.UserColorPalette.PrimaryColor.HoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.materialLabel1.MaterialResource.UserColorPalette.PrimaryColor.RippleColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.materialLabel1.MaterialResource.UserColorPalette.PrimaryColor.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.materialLabel1.MaterialResource.UserColorPalette.SecondaryColor.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.materialLabel1.MaterialResource.UserColorPalette.SecondaryColor.HintColor = System.Drawing.Color.DarkGray;
            this.materialLabel1.MaterialResource.UserColorPalette.SecondaryColor.MainColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.materialLabel1.MaterialResource.UserColorPalette.SecondaryDisabledColor.MainColor = System.Drawing.Color.DimGray;
            this.materialLabel1.MaterialResource.UserColorPalette.SecondaryDisabledColor.TextColor = System.Drawing.Color.DarkGray;
            this.materialLabel1.Name = "materialLabel1";
            this.materialLabel1.NormalFont = new System.Drawing.Font("Calibri", 16F, System.Drawing.FontStyle.Bold);
            this.materialLabel1.Size = new System.Drawing.Size(172, 54);
            this.materialLabel1.TabIndex = 1;
            this.materialLabel1.Text = "Denoteing Symbol";
            this.materialLabel1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // nativeLanguageTrueLabel
            // 
            this.nativeLanguageTrueLabel.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.nativeLanguageTrueLabel.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.nativeLanguageTrueLabel.Font = new System.Drawing.Font("Calibri", 13F, System.Drawing.FontStyle.Bold);
            this.nativeLanguageTrueLabel.ForeColor = System.Drawing.SystemColors.ControlText;
            this.nativeLanguageTrueLabel.Location = new System.Drawing.Point(0, 64);
            this.nativeLanguageTrueLabel.MaterialResource.CustomPaletteMode.UseCustomPalette = true;
            this.nativeLanguageTrueLabel.MaterialResource.UserColorPalette.DisabledColor.MainColor = System.Drawing.Color.DarkGray;
            this.nativeLanguageTrueLabel.MaterialResource.UserColorPalette.DisabledColor.TextColor = System.Drawing.Color.DimGray;
            this.nativeLanguageTrueLabel.MaterialResource.UserColorPalette.PrimaryColor.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.nativeLanguageTrueLabel.MaterialResource.UserColorPalette.PrimaryColor.HighlightColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.nativeLanguageTrueLabel.MaterialResource.UserColorPalette.PrimaryColor.HintColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(142)))), ((int)(((byte)(250)))));
            this.nativeLanguageTrueLabel.MaterialResource.UserColorPalette.PrimaryColor.HoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.nativeLanguageTrueLabel.MaterialResource.UserColorPalette.PrimaryColor.RippleColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.nativeLanguageTrueLabel.MaterialResource.UserColorPalette.PrimaryColor.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.nativeLanguageTrueLabel.MaterialResource.UserColorPalette.SecondaryColor.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.nativeLanguageTrueLabel.MaterialResource.UserColorPalette.SecondaryColor.HintColor = System.Drawing.Color.DarkGray;
            this.nativeLanguageTrueLabel.MaterialResource.UserColorPalette.SecondaryColor.MainColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.nativeLanguageTrueLabel.MaterialResource.UserColorPalette.SecondaryDisabledColor.MainColor = System.Drawing.Color.DimGray;
            this.nativeLanguageTrueLabel.MaterialResource.UserColorPalette.SecondaryDisabledColor.TextColor = System.Drawing.Color.DarkGray;
            this.nativeLanguageTrueLabel.Name = "nativeLanguageTrueLabel";
            this.nativeLanguageTrueLabel.NormalFont = new System.Drawing.Font("Calibri", 13F, System.Drawing.FontStyle.Bold);
            this.nativeLanguageTrueLabel.Size = new System.Drawing.Size(278, 43);
            this.nativeLanguageTrueLabel.TabIndex = 0;
            this.nativeLanguageTrueLabel.Text = "NativeLanguage";
            this.nativeLanguageTrueLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // materialPanel3
            // 
            this.materialPanel3.BorderRadius = ((byte)(0));
            this.materialPanel3.Controls.Add(this.wheelSettingsComboBox);
            this.materialPanel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.materialPanel3.Location = new System.Drawing.Point(0, 0);
            this.materialPanel3.MaterialResource.UserColorPalette.DisabledColor.MainColor = System.Drawing.Color.DarkGray;
            this.materialPanel3.MaterialResource.UserColorPalette.DisabledColor.TextColor = System.Drawing.Color.DimGray;
            this.materialPanel3.MaterialResource.UserColorPalette.PrimaryColor.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.materialPanel3.MaterialResource.UserColorPalette.PrimaryColor.HighlightColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.materialPanel3.MaterialResource.UserColorPalette.PrimaryColor.HintColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(142)))), ((int)(((byte)(250)))));
            this.materialPanel3.MaterialResource.UserColorPalette.PrimaryColor.HoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.materialPanel3.MaterialResource.UserColorPalette.PrimaryColor.RippleColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.materialPanel3.MaterialResource.UserColorPalette.PrimaryColor.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.materialPanel3.MaterialResource.UserColorPalette.SecondaryColor.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.materialPanel3.MaterialResource.UserColorPalette.SecondaryColor.HintColor = System.Drawing.Color.DarkGray;
            this.materialPanel3.MaterialResource.UserColorPalette.SecondaryColor.MainColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.materialPanel3.MaterialResource.UserColorPalette.SecondaryDisabledColor.MainColor = System.Drawing.Color.DimGray;
            this.materialPanel3.MaterialResource.UserColorPalette.SecondaryDisabledColor.TextColor = System.Drawing.Color.DarkGray;
            this.materialPanel3.Name = "materialPanel3";
            this.materialPanel3.Size = new System.Drawing.Size(817, 61);
            this.materialPanel3.TabIndex = 2;
            // 
            // wheelSettingsComboBox
            // 
            this.wheelSettingsComboBox.DisplayMember = "Name";
            this.wheelSettingsComboBox.Font = new System.Drawing.Font("Calibri", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.wheelSettingsComboBox.FormattingEnabled = true;
            this.wheelSettingsComboBox.ItemHeight = 23;
            this.wheelSettingsComboBox.Location = new System.Drawing.Point(245, 17);
            this.wheelSettingsComboBox.MaterialResource.UserColorPalette.DisabledColor.MainColor = System.Drawing.Color.DarkGray;
            this.wheelSettingsComboBox.MaterialResource.UserColorPalette.DisabledColor.TextColor = System.Drawing.Color.DimGray;
            this.wheelSettingsComboBox.MaterialResource.UserColorPalette.PrimaryColor.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.wheelSettingsComboBox.MaterialResource.UserColorPalette.PrimaryColor.HighlightColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.wheelSettingsComboBox.MaterialResource.UserColorPalette.PrimaryColor.HintColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(142)))), ((int)(((byte)(250)))));
            this.wheelSettingsComboBox.MaterialResource.UserColorPalette.PrimaryColor.HoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.wheelSettingsComboBox.MaterialResource.UserColorPalette.PrimaryColor.RippleColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.wheelSettingsComboBox.MaterialResource.UserColorPalette.PrimaryColor.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.wheelSettingsComboBox.MaterialResource.UserColorPalette.SecondaryColor.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.wheelSettingsComboBox.MaterialResource.UserColorPalette.SecondaryColor.HintColor = System.Drawing.Color.DarkGray;
            this.wheelSettingsComboBox.MaterialResource.UserColorPalette.SecondaryColor.MainColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.wheelSettingsComboBox.MaterialResource.UserColorPalette.SecondaryDisabledColor.MainColor = System.Drawing.Color.DimGray;
            this.wheelSettingsComboBox.MaterialResource.UserColorPalette.SecondaryDisabledColor.TextColor = System.Drawing.Color.DarkGray;
            this.wheelSettingsComboBox.Name = "wheelSettingsComboBox";
            this.wheelSettingsComboBox.Size = new System.Drawing.Size(302, 29);
            this.wheelSettingsComboBox.TabIndex = 0;
            this.wheelSettingsComboBox.ValueMember = "ID";
            // 
            // denominationHeaderLbl
            // 
            this.denominationHeaderLbl.AutoAdjustFont = true;
            this.denominationHeaderLbl.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.denominationHeaderLbl.Dock = System.Windows.Forms.DockStyle.Top;
            this.denominationHeaderLbl.Font = new System.Drawing.Font("Calibri", 21.17852F, System.Drawing.FontStyle.Bold);
            this.denominationHeaderLbl.ForeColor = System.Drawing.SystemColors.ControlText;
            this.denominationHeaderLbl.Location = new System.Drawing.Point(0, 0);
            this.denominationHeaderLbl.MaterialResource.UserColorPalette.DisabledColor.MainColor = System.Drawing.Color.DarkGray;
            this.denominationHeaderLbl.MaterialResource.UserColorPalette.DisabledColor.TextColor = System.Drawing.Color.DimGray;
            this.denominationHeaderLbl.MaterialResource.UserColorPalette.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.denominationHeaderLbl.MaterialResource.UserColorPalette.PrimaryColor.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.denominationHeaderLbl.MaterialResource.UserColorPalette.PrimaryColor.HighlightColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.denominationHeaderLbl.MaterialResource.UserColorPalette.PrimaryColor.HintColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(142)))), ((int)(((byte)(250)))));
            this.denominationHeaderLbl.MaterialResource.UserColorPalette.PrimaryColor.HoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.denominationHeaderLbl.MaterialResource.UserColorPalette.PrimaryColor.RippleColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.denominationHeaderLbl.MaterialResource.UserColorPalette.PrimaryColor.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.denominationHeaderLbl.MaterialResource.UserColorPalette.SecondaryColor.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.denominationHeaderLbl.MaterialResource.UserColorPalette.SecondaryColor.HintColor = System.Drawing.Color.DarkGray;
            this.denominationHeaderLbl.MaterialResource.UserColorPalette.SecondaryColor.MainColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.denominationHeaderLbl.MaterialResource.UserColorPalette.SecondaryDisabledColor.MainColor = System.Drawing.Color.DimGray;
            this.denominationHeaderLbl.MaterialResource.UserColorPalette.SecondaryDisabledColor.TextColor = System.Drawing.Color.DarkGray;
            this.denominationHeaderLbl.Name = "denominationHeaderLbl";
            this.denominationHeaderLbl.NormalFont = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.denominationHeaderLbl.Size = new System.Drawing.Size(817, 38);
            this.denominationHeaderLbl.TabIndex = 2;
            this.denominationHeaderLbl.Text = "Wheel Profiles";
            this.denominationHeaderLbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // serialNumberPartDisplayer1
            // 
            this.serialNumberPartDisplayer1.IsPrefix = false;
            this.serialNumberPartDisplayer1.Location = new System.Drawing.Point(85, 27);
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
            this.serialNumberPartDisplayer1.Size = new System.Drawing.Size(112, 52);
            this.serialNumberPartDisplayer1.SNPartString = null;
            this.serialNumberPartDisplayer1.TabIndex = 2;
            this.serialNumberPartDisplayer1.Text = "serialNumberPartDisplayer1";
            // 
            // WheelSettingProfileViewControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.DenominationViewContanierPanel);
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
            this.Name = "WheelSettingProfileViewControl";
            this.Size = new System.Drawing.Size(817, 513);
            this.DenominationViewContanierPanel.ResumeLayout(false);
            this.charBoxesMainPanel.ResumeLayout(false);
            this.charBoxesContinarParentPanel.ResumeLayout(false);
            this.materialPanel1.ResumeLayout(false);
            this.materialPanel2.ResumeLayout(false);
            this.materialPanel4.ResumeLayout(false);
            this.materialPanel5.ResumeLayout(false);
            this.materialPanel3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel DenominationViewContanierPanel;
        private MaterialLibrary.MaterialPanel charBoxesMainPanel;
        private MaterialLibrary.MaterialComboBox wheelSettingsComboBox;
        private MaterialLibrary.MaterialPanel materialPanel1;
        private MaterialLibrary.MaterialFlowLayoutPanel charBoxesContinarPanel;
        private MaterialLibrary.MaterialAutoPanel charBoxesContinarParentPanel;
        private MaterialLibrary.MaterialLabel denominationHeaderLbl;
        private MaterialLibrary.MaterialPanel materialPanel2;
        private MaterialLibrary.MaterialPanel materialPanel3;
        private MaterialLibrary.MaterialPanel materialPanel4;
        private MaterialLibrary.MaterialPanel materialPanel5;
        private SerialNumberInspectionUI.Denomination.Controls.SNCharBox.SNCharBox denoteingSymbolLabel;
        private MaterialLibrary.MaterialLabel materialLabel1;
        private MaterialLibrary.MaterialLabel nativeLanguageTrueLabel;
        private AutoFitTextBox autoFitTextBox1;
        private SerialInspectionUI.SerialNumberPartDisplayer serialNumberPartDisplayer1;
    }
}
