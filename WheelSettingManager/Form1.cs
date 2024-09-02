using MaterialLibrary;
using SerialNumberInspectionUI.Denomination.Controls.SNCharBox;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WheelSettingManager.Controls;

namespace WheelSettingManager
{
    public partial class Form1 : MaterialAnimatedForm
    {
        private InputLanguage defaultLanguage;
        public Form1()
        {

            InitializeComponent();
            defaultLanguage = InputLanguage.CurrentInputLanguage;
            LanguageCharactersManager.Initialize();
            InputLanguageChanged += Form1InputLanguageChanged;
            KeyPreview = true;
            Load += DenominationPatternCreateFormLoad;
            WheelSettings = new List<WheelSettings>(){new WheelSettings() { ID = 1, Name ="aaa",CharactersSet=new List<string>() { "அ", "ஆ", "இ", "ஈ", "உ", "ஊ", "எ", "ஏ", "ஐ", "ஒ", "ஓ", "ஔ" } }, new WheelSettings() { ID=2,Name = "bbb", CharactersSet = new List<string>() { "কা", "কি", "কী", "কু", "কূ", "কৃ", "কে", "কৈ", "কো", "কৌ" } ,}, new WheelSettings (){ ID = 2, Name = "bbb", CharactersSet = new List<string>() {"あ", "い", "う", "え", "お",
            "か", "き", "く", "け", "こ",  // K consonants
            "さ", "し", "す", "せ", "そ",  // S consonants
            "た", "ち", "つ", "て", "と",  // T consonants
            "な", "に", "ぬ", "ね", "の",  // N consonants
            "は", "ひ", "ふ", "へ", "ほ",  // H consonants
            "ま", "み", "む", "め", "も",  // M consonants
            "や", "ゆ", "よ",                // Y consonants
            "ら", "り", "る", "れ", "ろ",  // R consonants
            "わ", "を", "ん",                // W and N
            // Combinations
            "きゃ", "きゅ", "きょ",  // Kya, Kyu, Kyo
            "しゃ", "しゅ", "しょ",  // Sha, Shu, Sho
            "ちゃ", "ちゅ", "ちょ",  // Cha, Chu, Cho
            "にゃ", "にゅ", "にょ",  // Nya, Nyu, Nyo
            "ひゃ", "ひゅ", "ひょ",  // Hya, Hyu, Hyo
            "みゃ", "みゅ", "みょ",  // Mya, Myu, Myo
            "りゃ", "りゅ", "りょ",   // Rya, Ryu, Ryo
            "ア", "イ", "ウ", "エ", "オ",  // Vowels
            "カ", "キ", "ク", "ケ", "コ",  // K consonants
            "サ", "シ", "ス", "セ", "ソ",  // S consonants
            "タ", "チ", "ツ", "テ", "ト",  // T consonants
            "ナ", "ニ", "ヌ", "ネ", "ノ",  // N consonants
            "ハ", "ヒ", "フ", "ヘ", "ホ",  // H consonants
            "マ", "ミ", "ム", "メ", "モ",  // M consonants
            "ヤ", "ユ", "ヨ",                // Y consonants
            "ラ", "リ", "ル", "レ", "ロ",  // R consonants
            "ワ", "ヲ", "ン"                 } }};

            wheelSettingProfileViewControl = new WheelSettingProfileViewControl(WheelSettings) { Dock = DockStyle.Fill };
            mainPanel.Controls.Add(wheelSettingProfileViewControl);
            //DenominationEditOrCreateControl denominationEditOrCreateControl = new DenominationEditOrCreateControl() { Dock = Dock = DockStyle.Fill };
            //mainPanel.Controls.Add(denominationEditOrCreateControl);
            KeyPress += Form1_KeyPress;
        }

        private void Form1_KeyPress(object sender, KeyPressEventArgs e)
        {
            //if (ActiveControl == textBox1)
            //{
            //    e.Handled = true; // Prevents the form from showing any text input
            //}
        }

        private void Form1InputLanguageChanged(object sender, InputLanguageChangedEventArgs e)
        {
            //if (ActiveControl != textBox1)
            //{
            //    // Reset the input language to the default one
            //    InputLanguage.CurrentInputLanguage = defaultLanguage;
            //}
        }

        public bool isWheelSettingsEditMode;
        private bool isWheelSettingsCreateMode;
        public bool IsWheelSettingsEditMode
        {
            set
            {
                isWheelSettingsEditMode = value;
                if (isWheelSettingsEditMode)
                {
                    wheelProfileDeleteBtn.Visible = wheelProfileCreateBtn.Visible = false;
                    wheelProfileEditBtn.IconDisplayType = IconType.Done;
                }
                else
                {
                    wheelProfileDeleteBtn.Visible = wheelProfileCreateBtn.Visible = true;
                    wheelProfileEditBtn.IconDisplayType = IconType.ModeEdit;
                }
            }
            get
            {
                return isWheelSettingsEditMode;
            }
        }

        public bool IsBoxSettingCreateMode
        {
            get
            {
                return isWheelSettingsCreateMode;
            }
            set
            {
                isWheelSettingsCreateMode = value;
                if (isWheelSettingsCreateMode)
                {
                    wheelProfileDeleteBtn.Visible = wheelProfileEditBtn.Visible = false;
                    wheelProfileCreateBtn.IconDisplayType = IconType.ContentSave;
                }
                else
                {
                    wheelProfileDeleteBtn.Visible = wheelProfileEditBtn.Visible = true;
                    wheelProfileCreateBtn.IconDisplayType = IconType.Add;
                }
            }
        }

        public List<WheelSettings> WheelSettings;
        private WheelSettingProfileViewControl wheelSettingProfileViewControl;
        private WheelSettingCreateOrEditControl wheelSettingCreateOrEditControl;

        private void DenominationPatternManagerFormDisposed(object sender, EventArgs e)
        {
            if (wheelSettingProfileViewControl != null)
            {
                wheelSettingProfileViewControl.Dispose();
            }
            if (wheelSettingProfileViewControl != null)
            {
                wheelSettingProfileViewControl.Dispose();
            }
        }

        private void DenominationPatternCreateFormLoad(object sender, EventArgs e)
        {
            KeyPreview = true;
        }


        private void WheelSettingEditOrCreateControlOnClickBackButton(object sender, EventArgs e)
        {
            mainPanel.Controls.Clear();
            wheelSettingProfileViewControl = new WheelSettingProfileViewControl(WheelSettings) { Dock = DockStyle.Fill };
            wheelSettingCreateOrEditControl.Dispose();
            wheelSettingCreateOrEditControl.OnClickBackButton -= WheelSettingEditOrCreateControlOnClickBackButton;
            wheelSettingCreateOrEditControl = null;
            mainPanel.Controls.Add(wheelSettingProfileViewControl);
            IsWheelSettingsEditMode = false;
            IsBoxSettingCreateMode = false;
        }

        private void DenominationPatternManagerFormKeyDown(object sender, KeyEventArgs e)
        {
            //if (e.Control && e.KeyCode == Keys.A)
            //{
            //    if (denominationEditOrCreateControl != null)
            //    {
            //        denominationEditOrCreateControl.ControlAllDown();
            //    }
            //}
        }
      


        private void WheelProfileCreateClick(object sender, EventArgs e)
        {
            if (!IsBoxSettingCreateMode && !IsWheelSettingsEditMode)
            {
                mainPanel.Controls.Clear();
                IsBoxSettingCreateMode = true;
                wheelSettingCreateOrEditControl = new WheelSettingCreateOrEditControl() { Dock = DockStyle.Fill };
                wheelSettingCreateOrEditControl.OnClickBackButton += WheelSettingEditOrCreateControlOnClickBackButton;
                mainPanel.Controls.Add(wheelSettingCreateOrEditControl);
            }
            else
            {
                if (wheelSettingCreateOrEditControl.Validate())
                {
                    this.Close();
                }
            }
        }

        private void WheelProfileEditBtnClick(object sender, EventArgs e)
        {
            if (!IsWheelSettingsEditMode && !IsBoxSettingCreateMode)
            {
                mainPanel.Controls.Clear();
                IsWheelSettingsEditMode = true;
                wheelSettingCreateOrEditControl = new WheelSettingCreateOrEditControl(wheelSettingProfileViewControl.SelectedWheelSettings) { Dock = DockStyle.Fill };
                wheelSettingCreateOrEditControl.OnClickBackButton += WheelSettingEditOrCreateControlOnClickBackButton;
                mainPanel.Controls.Add(wheelSettingCreateOrEditControl);
                wheelSettingCreateOrEditControl.CharBoxesContinarPanelSizeFix();
            }
        }

        private void WheelProfileDeleteBtnClick(object sender, EventArgs e)
        {
            if (MaterialMessageBox.Show(this, "Do you want to delete this pattern", "Confirmation", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                //ProfileCollection.DeleteBoxSettings((ushort)wheelSettingProfileViewControl.SelectedWheelSettings.ID);
                //this.Invoke((Action)(() => { wheelSettingProfileViewControl.WheelSettings = new List<WheelSettings>(ProfileCollection.GetAllBoxes()); }));
            }
        }

        private void materialCircleButton2_Click(object sender, EventArgs e)
        {
            string path = @"C:\Windows\System32\tabtip.exe";

            try
            {
                Process.Start(path);
            }
            catch (System.ComponentModel.Win32Exception ex)
            {
                Console.WriteLine($"Error: {ex.Message}");
            }
        }
    }
}
