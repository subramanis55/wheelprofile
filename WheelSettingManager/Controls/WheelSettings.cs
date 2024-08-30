using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace WheelSettingManager.Controls
{
    public class WheelSettings
    {
        [XmlAttribute]
        public int ID { get; set; }

        [XmlAttribute]
        public string Name { get; set; }

        [XmlAttribute]
        public string DenotingCharacter { get; set; }

        [XmlAttribute]
        public List<string> CharactersSet { get; set; }

        [XmlAttribute]
        public bool IsNumericOnly { get; set; }

        [XmlAttribute]
        public bool IsNative { get; set; }

        [XmlAttribute]
        public List<string> LanguageSet { get; set; }
    }
}
