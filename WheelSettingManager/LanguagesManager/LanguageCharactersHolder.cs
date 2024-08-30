using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace WheelSettingManager.LanguagesManager
{
   public class LanguageCharactersHolder
    {
        private string languageNameInEnglish;
        private string languageNameInNative;
        private List<string> characters;
        private string denoteingCharacter;
        [XmlAttribute]
        public string LanguageNameInEnglish
        {
            get
            {
                return languageNameInEnglish;
            }

            set
            {
                languageNameInEnglish = value;
            }
        }
        [XmlAttribute]
        public string LanguageNameInNative
        {
            get
            {
                return languageNameInNative;
            }

            set
            {
                languageNameInNative = value;
            }
        }
        [XmlAttribute]
        public List<string> Characters
        {
            get
            {
                return characters;
            }

            set
            {
                characters = value;
            }
        }
        [XmlAttribute]
        public string DenoteingCharacter
        {
            get
            {
                return denoteingCharacter;
            }

            set
            {
                denoteingCharacter = value;
            }
        }
    }
}
