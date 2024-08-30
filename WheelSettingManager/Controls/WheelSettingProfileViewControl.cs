using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WheelSettingManager.Controls;
using SerialNumberInspectionUI.Denomination.Controls.SNCharBox;
using MaterialLibrary;

namespace WheelSettingManager.Controls
{
    public partial class WheelSettingProfileViewControl :MaterialControl
    {
        private int characterCount;
        private int characterBoxHeight = 55;
        private int characterBoxWidth = 50;
        private Padding characterBoxMargin = new Padding(7,5,7,5);
        private int maximumCountInRow = 10;
        private WheelSettings selectedWheelSettings;
        private List<WheelSettings> wheelSettings;
        public int CharacterCount
        {
            set
            {
                characterCount = value;
                int columnCount = (characterCount >= maximumCountInRow ? maximumCountInRow : characterCount % maximumCountInRow);
                int rowCount = (characterCount / maximumCountInRow) + (characterCount % maximumCountInRow != 0 ? 1 : 0);
                int CharBoxesContinarParentPanelHeight = (rowCount * characterBoxHeight) + ((rowCount * (characterBoxMargin.Top + characterBoxMargin.Bottom))) + charBoxesContinarParentPanel.Padding.Top + charBoxesContinarParentPanel.Padding.Bottom + charBoxesContinarPanel.Padding.Top + charBoxesContinarPanel.Padding.Bottom;
                int CharBoxesContinarParentPanelWidth = (characterBoxWidth * columnCount) + (columnCount * (characterBoxMargin.Left + characterBoxMargin.Right)) + charBoxesContinarParentPanel.Padding.Left + charBoxesContinarParentPanel.Padding.Right + charBoxesContinarPanel.Padding.Right + charBoxesContinarPanel.Padding.Left;

                if (CharBoxesContinarParentPanelHeight < charBoxesMainPanel.Height)
                {
                    charBoxesContinarParentPanel.Height = CharBoxesContinarParentPanelHeight;
                    charBoxesContinarParentPanel.Width = CharBoxesContinarParentPanelWidth+10;
                }
                else
                {
                    charBoxesContinarParentPanel.Height = charBoxesMainPanel.Height - charBoxesMainPanel.Padding.Top - charBoxesMainPanel.Padding.Bottom;
                    charBoxesContinarParentPanel.Width = CharBoxesContinarParentPanelWidth+20 ;
                }
            }
            get
            {
                return characterCount;

            }
        }
        public WheelSettings SelectedWheelSettings
        {
            get
            {
                return (WheelSettings)wheelSettingsComboBox.SelectedItem;
            }
            set
            {
                selectedWheelSettings = value;
                CharacterCount = selectedWheelSettings.CharactersSet.Count;
                CharacterBoxesShowArrange();
            }
        }

        public List<WheelSettings> WheelSettings
        {
            get
            {
                return wheelSettings;
            }

            set
            {
                wheelSettings = value;
                wheelSettingsComboBox.DataSource = wheelSettings;
            }
        }

        public WheelSettingProfileViewControl(List<WheelSettings> wheelSettings)
        {
            InitializeComponent();
            WheelSettings = wheelSettings;
            wheelSettingsComboBox.SelectedValueChanged += WheelSettingsComboBoxValueMemberChanged;
            Load += WheelSettingCharBoxesViewControlLoad;
            typeof(Panel).InvokeMember("DoubleBuffered", System.Reflection.BindingFlags.NonPublic | System.Reflection.BindingFlags.SetProperty | System.Reflection.BindingFlags.Instance, null, charBoxesContinarPanel, new object[] { true });
        }
        public void CharacterBoxesShowArrange()
        {
            charBoxesContinarPanel.Controls.Clear();
            List<string> charBoxItem = ((WheelSettings)(wheelSettingsComboBox.SelectedItem)).CharactersSet;
            CharacterCount = charBoxItem.Count;
            denoteingSymbolLabel.Text = charBoxItem[0];
            foreach (var a in charBoxItem)
            {
                    charBoxesContinarPanel.Controls.Add(new SNCharBox() { Text = a, Font = new Font(new FontFamily("Calibri"), 34), Height = characterBoxHeight, Width = characterBoxWidth, Margin = characterBoxMargin });
            }
        }

        private void WheelSettingCharBoxesViewControlLoad(object sender, EventArgs e)
        {
            WheelSettingsComboBoxValueMemberChanged(this, EventArgs.Empty);
        }

        private void WheelSettingsComboBoxValueMemberChanged(object sender, EventArgs e)
        {
            SelectedWheelSettings = ((WheelSettings)(wheelSettingsComboBox.SelectedItem));
        }

        private void WheelSettingContanierPanelResize(object sender, EventArgs e)
        {
            wheelSettingsComboBox.Location = new Point(wheelSettingsComboBox.Parent.Width / 2 - wheelSettingsComboBox.Width / 2, wheelSettingsComboBox.Parent.Height / 2 - wheelSettingsComboBox.Height / 2);
            charBoxesContinarParentPanel.Location = new Point(charBoxesContinarParentPanel.Parent.Width / 2 - charBoxesContinarParentPanel.Width / 2, charBoxesContinarParentPanel.Parent.Height / 2 - charBoxesContinarParentPanel.Height / 2);
            materialPanel4.Location = new Point(materialPanel4.Parent.Width / 2 - materialPanel4.Width / 2, materialPanel4.Parent.Height / 2 - materialPanel4.Height / 2);
        }

        private void CharBoxesContinarPanelResize(object sender, EventArgs e)
        {
            if (charBoxesContinarParentPanel.Height < charBoxesMainPanel.Height)
            {
                charBoxesContinarParentPanel.Location = new Point(charBoxesContinarParentPanel.Parent.Width / 2 - charBoxesContinarParentPanel.Width / 2, charBoxesContinarParentPanel.Parent.Height / 2 - charBoxesContinarParentPanel.Height / 2);
            }
            else
            {
                charBoxesContinarParentPanel.Location = new Point(charBoxesContinarParentPanel.Parent.Width / 2 - charBoxesContinarParentPanel.Width / 2, charBoxesContinarParentPanel.Parent.Padding.Top);
            }
        }
    }
}
