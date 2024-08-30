using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SerialNumberInspectionUI.Controls;
using WheelSettingManager.LanguagesManager;
using SerialNumberInspectionUI.Denomination.Controls.SNCharBox;
using MaterialLibrary;

namespace WheelSettingManager.Controls
{
    public partial class WheelSettingCreateOrEditControl : MaterialControl
    {
        public WheelSettingCreateOrEditControl()
        {
            InitializeComponent();
            
            ArrangleDragSetUp();
            Load += WheetCharacterCreateOrEditLoad;
            CharacterBoxCount = 1;
        }
        public WheelSettingCreateOrEditControl(WheelSettings wheelSettings)
        {
            InitializeComponent();
            WheelSettings = wheelSettings;
            ArrangleDragSetUp();
            characterBoxCountSpinBox.Value = wheelSettings.CharactersSet.Count;
            Load += WheetCharacterCreateOrEditLoad;
        }
        public event EventHandler OnClickBackButton;
        List<ContainerBox> characterBoxDragContainerBoxes = new List<ContainerBox>();
        Dictionary<string, LanguageCharactersHolder> SelectedCharacters = new Dictionary<string, LanguageCharactersHolder>();
        public ContainerBox SelectedContainerBox;
        private WheelSettings wheelSettings;
        public WheelSettings WheelSettings
        {
            set
            {
                wheelSettings = value;
                nameTextBox.Text = wheelSettings.Name;
            }
            get
            {
                return wheelSettings;
            }
        }
        private int characterBoxCount;
        private int characterBoxHeight = 60;
        private int characterBoxWidth = 55;
        private int maximumCountInRow = 8;
        private int maximumCount = 100;
        private Padding characterBoxMargin = new Padding(4);
        public int CharacterBoxCount
        {
            set
            {
                characterBoxCount = value;
                for (int i = 0; i < characterBoxDragContainerBoxes.Count; i++)
                {

                    if (i < CharacterBoxCount)
                    {
                        characterBoxDragContainerBoxes[i].Visible = true;
                    }
                    else
                    {
                        characterBoxDragContainerBoxes[i].Visible = false;
                        if (SelectedContainerBox == characterBoxDragContainerBoxes[i])
                        {
                            characterBoxDragContainerBoxes[i].IsSelected = false;
                            SelectedContainerBox = null;
                        }
                        if(characterBoxDragContainerBoxes[i].Controls.Count>0 )
                        {
                            if (((SNCharBox)characterBoxDragContainerBoxes[i].Controls[0]).LanguageCharactersHolder == languageComboBox.SelectedItem)
                                languageCharacterContainerPanel.Controls.Add((SNCharBox)characterBoxDragContainerBoxes[i].Controls[0]);
                            else
                                characterBoxDragContainerBoxes[i].Controls.Clear();
                        }
                       
                    }
                }
                CharBoxesContinarPanelSizeFix();
            }
            get
            {
                return characterBoxCount;
            }
        }



        private void WheetCharacterCreateOrEditLoad(object sender, EventArgs e)
        {
            languageComboBox.DataSource = LanguageCharactersManager.Source.Values.ToList();
        }

        public void ArrangleDragSetUp()
        {
            int col = (maximumCount >= maximumCountInRow ? maximumCountInRow : (int)maximumCount % maximumCountInRow);
            int row = ((int)maximumCount / maximumCountInRow) + ((int)maximumCount % maximumCountInRow != 0 ? 1 : 0);
            for (int i = 1; i <= row; i++)
            {
                for (int j = 1; j <= col; j++)
                {
                    if (maximumCount <= characterBoxDragContainerBoxes.Count)
                    {
                        break;
                    }
                    ContainerBox containerBox = new ContainerBox
                    {
                        AllowDrop = true,
                        Name = "" + (characterBoxDragContainerBoxes.Count + 1),
                        Margin = characterBoxMargin,
                        Padding = new Padding(4),
                        Height = characterBoxHeight,
                        Width = characterBoxWidth,
                        Visible = false,
                    };
                    containerBox.DragEnter += CharacterContainerDragEnter;
                    containerBox.DragDrop += CharacterContainerDragDrop;
                    containerBox.ControlAdded += ContainerBoxControlAdded;
                    containerBox.ControlRemoved += ContainerBoxControlRemoved;
                    containerBox.MouseClick += ContainerBoxClick;
                    if (WheelSettings != null && WheelSettings.ID != 0 && characterBoxDragContainerBoxes.Count < WheelSettings.CharactersSet.Count)
                    {
                        SNCharBox SNCharBox = new SNCharBox() { Dock = DockStyle.Fill, Font = new Font(new FontFamily("Calibri"), 26), Height = characterBoxHeight - 4, Width = characterBoxWidth - 4, Margin = new Padding(4, 4, 4, 4) };
                        SNCharBox.OnMouseDown += SNCharBoxChildMouseDown;
                        SNCharBox.Text = WheelSettings.CharactersSet[characterBoxDragContainerBoxes.Count];
                        containerBox.Controls.Add(SNCharBox);
                    }

                    charBoxesContinarPanel.Controls.Add(containerBox);
                    characterBoxDragContainerBoxes.Add(containerBox);
                }
            }
        }

        private void ContainerBoxControlRemoved(object sender, ControlEventArgs e)
        {
            if (e.Control is SNCharBox)
            {
                e.Control.Dock = DockStyle.None;
                SelectedCharacters.Remove(((SNCharBox)e.Control).Text);
            }
        }

        private void ContainerBoxControlAdded(object sender, ControlEventArgs e)
        {
            if (e.Control is SNCharBox)
            {
                e.Control.Dock = DockStyle.Fill;
                SelectedCharacters.Add(((SNCharBox)e.Control).Text, ((SNCharBox)e.Control).LanguageCharactersHolder);
            }
            ContainerBox containerBox = (ContainerBox)(sender);
            if (SelectedContainerBox == containerBox)
            {
                containerBox.IsSelected = false;
                SelectedContainerBox = null;
            }
        }

        private void ContainerBoxClick(object sender, MouseEventArgs e)
        {
            if (((ContainerBox)(sender)).Controls.Count == 0)
            {
                if (SelectedContainerBox != null)
                    SelectedContainerBox.IsSelected = false;
                SelectedContainerBox = (ContainerBox)(sender);
                SelectedContainerBox.IsSelected = true;
            }
        }

        private void CharBoxParentClick(object sender, EventArgs e)
        {
            SNCharBox sNCharBoxParent = (SNCharBox)sender;
        }

        private void SNCharBoxChildMouseDown(object sender, MouseEventArgs e)
        {
            SNCharBox sNCharBox = (SNCharBox)sender;
            if (e.Button == MouseButtons.Left)
            {
                DataObject data = new DataObject();
                data.SetData(typeof(SNCharBox), sender);
                //data.SetData(DataFormats.StringFormat, "Dragged Char");
                sNCharBox.DoDragDrop(data, DragDropEffects.Move);
            }
        }

        private void SNCharBoxParentMouseDown(object sender, MouseEventArgs e)
        {
            SNCharBox sNCharBox = (SNCharBox)sender;
            SNCharBox dragingSNCharBox = new SNCharBox() { Text = sNCharBox.Text };
            dragingSNCharBox.OnMouseDown += SNCharBoxChildMouseDown;
            if (e.Button == MouseButtons.Left)
            {
                DataObject data = new DataObject();
                data.SetData(typeof(SNCharBox), dragingSNCharBox);
                //data.SetData(DataFormats.StringFormat, "Dragged Char");
                dragingSNCharBox.DoDragDrop(data, DragDropEffects.Move);
            }
        }
        private void CharacterContainerDragEnter(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(typeof(SNCharBox)))
            {
                e.Effect = DragDropEffects.Move;
            }
            else
            {
                e.Effect = DragDropEffects.None;
            }
        }

        private void CharacterContainerDragDrop(object sender, DragEventArgs e)
        {
            int scrollPosition = charBoxesContinarPanel.VerticalScroll.Value;
            charBoxesContinarPanel.SuspendLayout();
            ContainerBox container = (ContainerBox)sender;
            SNCharBox draggedSNCharBox = (SNCharBox)e.Data.GetData(typeof(SNCharBox));
            //draggedSNCharBox.Dock = DockStyle.Fill;

            Point dropPoint = container.PointToClient(new Point(e.X, e.Y));
            if (container.Controls.Count > 0 && draggedSNCharBox.Parent != null && draggedSNCharBox.Parent is ContainerBox)
            {
                ((ContainerBox)draggedSNCharBox.Parent).Controls.Add(container.Controls[0]);
            }
            else
            {
                container.Controls.Clear();
            }
            container.Controls.Add(draggedSNCharBox);
            draggedSNCharBox.Location = dropPoint;
            charBoxesContinarPanel.VerticalScroll.Value = scrollPosition;
            charBoxesContinarPanel.ResumeLayout();
            charBoxesContinarPanel.PerformLayout();
        }

        private void languageComboBoxSelectedIndexChanged(object sender, EventArgs e)
        {

            languageCharacterContainerPanel.Controls.Clear();
            List<string> charBoxItem = ((LanguageCharactersHolder)languageComboBox.SelectedItem).Characters;
            foreach (var a in charBoxItem)
            {
                if (!SelectedCharacters.ContainsKey(a))
                {
                    SNCharBox sNCharBox = new SNCharBox() { Text = a, LanguageCharactersHolder = ((LanguageCharactersHolder)languageComboBox.SelectedItem), Font = new Font(new FontFamily("Calibri"), 26), Height = characterBoxHeight - 4, Width = characterBoxWidth - 4, Margin = new Padding(characterBoxMargin.Left + 1, characterBoxMargin.Top + 2, characterBoxMargin.Right + 1, characterBoxMargin.Bottom + 2) };
                    sNCharBox.OnMouseDown += SNCharBoxChildMouseDown;
                    sNCharBox.OnClick += SNCharBoxOnClick;
                    languageCharacterContainerPanel.Controls.Add(sNCharBox);
                }
            }
            //LanguageCharacterContainerPanelSizeFix();
        }

        private void SNCharBoxOnClick(object sender, EventArgs e)
        {
            if (!(((SNCharBox)sender).Parent is ContainerBox) && SelectedContainerBox != null)
            {
                SelectedContainerBox.Controls.Add((SNCharBox)sender);
            }
        }

        private void SNCharBoxMouseLeave(object sender, EventArgs e)
        {
            if (((SNCharBox)sender).Parent is ContainerBox)
            {
                ((ContainerBox)((SNCharBox)sender).Parent).IsHover = true;
            }
        }

        private void SNCharBoxMouseHover(object sender, EventArgs e)
        {
            if (((SNCharBox)sender).Parent is ContainerBox)
            {
                ((ContainerBox)((SNCharBox)sender).Parent).IsHover = false;
            }
        }

        public void CharBoxesContinarPanelSizeFix()
        {
            int columnCount = (characterBoxCount >= maximumCountInRow ? maximumCountInRow : characterBoxCount % maximumCountInRow);
            int rowCount = (characterBoxCount / maximumCountInRow) + (characterBoxCount % maximumCountInRow != 0 ? 1 : 0);
            int CharBoxesContinarPanelHeight = (rowCount * characterBoxHeight) + (rowCount * (characterBoxMargin.Top + characterBoxMargin.Bottom)) + charBoxesContinarPanel.Padding.Top + charBoxesContinarPanel.Padding.Bottom;
            int CharBoxesContinarPanelWidth = (characterBoxWidth * columnCount) + (columnCount * (characterBoxMargin.Left + characterBoxMargin.Right)) + charBoxesContinarPanel.Padding.Left + charBoxesContinarPanel.Padding.Right;
            if (CharBoxesContinarPanelHeight < charBoxesMainPanel.Height)
            {
                charBoxesContinarPanel.Height = CharBoxesContinarPanelHeight;
                charBoxesContinarPanel.Width = CharBoxesContinarPanelWidth + 20;
            }
            else
            {
                charBoxesContinarPanel.Width = CharBoxesContinarPanelWidth + 25;
                charBoxesContinarPanel.Height = charBoxesMainPanel.Height - charBoxesMainPanel.Padding.Top - charBoxesMainPanel.Padding.Bottom;
            }
        }
        public void LanguageCharacterContainerPanelSizeFix()
        {
            int columnCount = (((LanguageCharactersHolder)languageComboBox.SelectedItem).Characters.Count >= maximumCountInRow ? maximumCountInRow : characterBoxCount % maximumCountInRow);
            int rowCount = (((LanguageCharactersHolder)languageComboBox.SelectedItem).Characters.Count / maximumCountInRow) + (characterBoxCount % maximumCountInRow != 0 ? 1 : 0);

            int languageCharacterContainerPanelHeight = (rowCount * characterBoxHeight) + (rowCount * (characterBoxMargin.Top + characterBoxMargin.Bottom)) + languageCharacterContainerPanel.Padding.Top + languageCharacterContainerPanel.Padding.Bottom;
            int languageCharacterContainerPanelWidth = (characterBoxWidth * columnCount) + (columnCount * (characterBoxMargin.Left + characterBoxMargin.Right)) + languageCharacterContainerPanel.Padding.Left + languageCharacterContainerPanel.Padding.Right;
            if (languageCharacterContainerPanelHeight < charBoxesMainPanel.Height)
            {
                charBoxesContinarPanel.Height = languageCharacterContainerPanelHeight;
                charBoxesContinarPanel.Width = languageCharacterContainerPanelWidth + 20;
            }
            else
            {
                charBoxesContinarPanel.Width = languageCharacterContainerPanelWidth + 25;
                charBoxesContinarPanel.Height = languageCharBoxesMainPanel.Height - languageCharBoxesMainPanel.Padding.Top - languageCharBoxesMainPanel.Padding.Bottom;
            }
        }
        private void CharacterBoxCountSpinBoxValueChanged(object sender, EventArgs e)
        {
            CharacterBoxCount = (int)characterBoxCountSpinBox.Value;
        }

        private void CharacterBoxCountSpinBoxParentResize(object sender, EventArgs e)
        {

        }
        private void CharBoxesContinarPanelResize(object sender, EventArgs e)
        {
            charBoxesContinarPanel.Location = new Point(charBoxesContinarPanel.Parent.Padding.Left, charBoxesContinarPanel.Parent.Padding.Top);

        }

        private void backButtonClick(object sender, EventArgs e)
        {
            OnClickBackButton.Invoke(this, EventArgs.Empty);
        }

        private void WheelSettingCreateOrEditControlResize(object sender, EventArgs e)
        {
            characterBoxCountSpinBox.Location = new Point(characterBoxCountSpinBox.Parent.Width / 2 - characterBoxCountSpinBox.Width / 2, characterBoxCountSpinBox.Parent.Height / 2 - characterBoxCountSpinBox.Height / 2);
            languageCharBoxesMainPanel.Width = mainPanel.Width / 2;
            charBoxesMainPanel.Width = mainPanel.Width / 2;
        }

        private void LanguageCharacterContainerPanelDragEnter(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(typeof(SNCharBox)))
            {
                e.Effect = DragDropEffects.Move;
            }
            else
            {
                e.Effect = DragDropEffects.None;
            }
        }

        private void LanguageCharacterContainerPanelDragDrop(object sender, DragEventArgs e)
        {
            MaterialFlowLayoutPanel LanguageCharacterPanel = (MaterialFlowLayoutPanel)sender;
            SNCharBox draggedSNCharBox = (SNCharBox)e.Data.GetData(typeof(SNCharBox));
            if (draggedSNCharBox.Parent is MaterialFlowLayoutPanel)
                return;
            int scrollPosition = languageCharacterContainerPanel.VerticalScroll.Value;
            languageCharacterContainerPanel.SuspendLayout();
            draggedSNCharBox.Dock = DockStyle.None;
            LanguageCharacterPanel.Controls.Add(draggedSNCharBox);
            languageCharacterContainerPanel.VerticalScroll.Value = scrollPosition;
            languageCharacterContainerPanel.ResumeLayout();
            languageCharacterContainerPanel.PerformLayout();
        }

        private void DeleteButtonDragEnter(object sender, DragEventArgs e)
        {
            SNCharBox sNCharBox = (SNCharBox)e.Data.GetData(typeof(SNCharBox));
            if (sNCharBox != null && !(sNCharBox.Parent is MaterialFlowLayoutPanel))
            {
                deleteButton.MaterialResource.UserColorPalette.SecondaryColor.MainColor = ColorTranslator.FromHtml("#FF4527");
            }
            if (e.Data.GetDataPresent(typeof(SNCharBox)))
            {
                e.Effect = DragDropEffects.Move;
            }
            else
            {
                e.Effect = DragDropEffects.None;
            }
        }

        private void DeleteButtonDragDrop(object sender, DragEventArgs e)
        {
            SNCharBox sNCharBox = (SNCharBox)e.Data.GetData(typeof(SNCharBox));
            if (sNCharBox == null || sNCharBox.Parent is MaterialFlowLayoutPanel)
                return;
            if (sNCharBox.LanguageCharactersHolder != (LanguageCharactersHolder)languageComboBox.SelectedItem)
            {
                sNCharBox.Dispose();
            }
            else
            {
                languageCharacterContainerPanel.Controls.Add(sNCharBox); ;
            }
        }
        private void DeleteButtonDragLeave(object sender, EventArgs e)
        {
            deleteButton.MaterialResource.UserColorPalette.SecondaryColor.MainColor = materialResource.UserColorPalette.SecondaryColor.MainColor;
        }

        private void DeleteButtonMouseLeave(object sender, EventArgs e)
        {
            deleteButton.MaterialResource.UserColorPalette.SecondaryColor.MainColor = materialResource.UserColorPalette.SecondaryColor.MainColor;
        }
       
        private bool NameExitsCheck(){
            return false;
        }
        public bool Validate()
        {
            if (nameTextBox.Text == "")
            {
                MaterialToast.ShowToast(this, "Invalid profile name", "Warning", ToastAnimationType.Fade, 1);
                return false;
            }
            else if(NameExitsCheck())
            {
                MaterialToast.ShowToast(this, "Profile name already exits tryagain", "Warning", ToastAnimationType.Fade, 1);
                return false;
            }
            else 
            {
                if(SelectedCharacters.Count!=CharacterBoxCount) {
                    MaterialToast.ShowToast(this, "Fill all the character boxes", "Warning", ToastAnimationType.Fade, 1);
                    return false;
                }
                List<string> charactersSet = new List<string>();
                List<string> languageSet = new List<string>();
                foreach (var containerBox in characterBoxDragContainerBoxes)
                 {   
                    if(containerBox.Visible){
                        charactersSet.Add(LanguageCharactersManager.ConvertToUnicodeEscape(((SNCharBox)containerBox.Controls[0]).Text));
                        languageSet.Add(SelectedCharacters[((SNCharBox)containerBox.Controls[0]).Text].LanguageNameInEnglish);
                    }
                    else{
                        break;
                    } 
                }
                if (wheelSettings == null)
                {
                   
                    wheelSettings = new WheelSettings { Name = nameTextBox.Text,CharactersSet= charactersSet,LanguageSet= languageSet,DenotingCharacter="", };
                }
                else
                {
                    WheelSettings.Name = nameTextBox.Text;
                    WheelSettings.DenotingCharacter = "";
                    WheelSettings.CharactersSet = charactersSet;
                    WheelSettings.LanguageSet = languageSet;
                }
            }
     
            return true;
        }
    }
}
