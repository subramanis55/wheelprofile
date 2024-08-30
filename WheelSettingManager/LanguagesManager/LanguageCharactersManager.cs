using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WheelSettingManager.LanguagesManager;
using System.Xml.Serialization;
using System.IO;

namespace WheelSettingManager
{
    public static class LanguageCharactersManager
    {
        public static string LanguageFilePath= "D:/Language";
        public static Dictionary<string, LanguageCharactersHolder> Source = new Dictionary<string, LanguageCharactersHolder>();

        public static void Initialize()
        {
            Source = new Dictionary<string, LanguageCharactersHolder>() { { "Numbers", new LanguageCharactersHolder() { DenoteingCharacter = "0", LanguageNameInEnglish = "Numbers",LanguageNameInNative= "Numbers", Characters = Numbers } }, { "English", new LanguageCharactersHolder() { DenoteingCharacter = "A", LanguageNameInNative = "English", LanguageNameInEnglish = "English", Characters = EnglishCharacters } }, { "Tamil", new LanguageCharactersHolder() { DenoteingCharacter = "அ", LanguageNameInEnglish="Tamil", LanguageNameInNative = "தமிழ்", Characters = TamilCharacters } }, { "Bangla", new LanguageCharactersHolder() { DenoteingCharacter = "অ", LanguageNameInEnglish= "Bangla", LanguageNameInNative = "বাংলা", Characters = BanglaCharacters } }, { "Hindi", new LanguageCharactersHolder() { DenoteingCharacter = "अ", LanguageNameInEnglish="Hindi",LanguageNameInNative = "हिन्दी", Characters = HindiCharacters } }, { "Japanese", new LanguageCharactersHolder() { DenoteingCharacter = "お",LanguageNameInNative = "日本語", LanguageNameInEnglish = "Japanese", Characters = JapaneseCharacters } } };

            //foreach (var language in Source.Values.ToList())
            //{
            //    string xmlContent = SerializeObjectToXml(language);
            //    string filepath = Path.Combine(LanguageFilePath, ((LanguageCharactersHolder)language).LanguageNameInEnglish);
                
            //    File.WriteAllText(LanguageFilePath, filepath);
            //}
        }

        public static List<string> Numbers = new List<string>() {
       "0","1","2","3","4","5","6","7","8","9"
        };
        public static List<string> EnglishCharacters = new List<string>() {
           "A", "B", "C", "D", "E", "F", "G", "H", "I", "J", "K", "L", "M", "N", "O", "P", "Q", "R", "S", "T", "U", "V", "W", "X", "Y", "Z" , "a", "b", "c", "d", "e", "f", "g", "h", "i", "j", "k", "l", "m", "n", "o", "p", "q", "r", "s", "t", "u", "v", "w", "x", "y", "z"
        };
        public static List<string> TamilCharacters = new List<string>
       {
    // Tamil Vowels (Uyir Ezhuthukkal)
    "அ", "ஆ", "இ", "ஈ", "உ", "ஊ", "எ", "ஏ", "ஐ", "ஒ", "ஓ", "ஔ",
    
    // Tamil Consonants (Mei Ezhuthukkal)
    "க்", "ங்", "ச்", "ஞ்", "ட்", "ண்", "த்", "ந்", "ப்", "ம்", "ய்", "ர்", "ல்", "வ்", "ழ்", "ள்", "ற்", "ன்",
    
    // Tamil Combinations of Vowels and Consonants (Uyir-Mei Ezhuthukkal)
    // Ka Series
    "க", "கா", "கி", "கீ", "கு", "கூ", "கெ", "கே", "கை", "கொ", "கோ", "கௌ",
    // Nga Series
    "ங", "ஙா", "ஙி", "ஙீ", "ஙு", "ஙூ", "ஙெ", "ஙே", "ஙை", "ஙொ", "ஙோ", "ஙௌ",
    // Cha Series
    "ச", "சா", "சி", "சீ", "சு", "சூ", "செ", "சே", "சை", "சொ", "சோ", "சௌ",
    // Nya Series
    "ஞ", "ஞா", "ஞி", "ஞீ", "ஞு", "ஞூ", "ஞெ", "ஞே", "ஞை", "ஞொ", "ஞோ", "ஞௌ",
    // Ta Series
    "ட", "டா", "டி", "டீ", "டு", "டூ", "டெ", "டே", "டை", "டொ", "டோ", "டௌ",
    // Na Series
    "ண", "ணா", "ணி", "ணீ", "ணு", "ணூ", "ணெ", "ணே", "ணை", "ணொ", "ணோ", "ணௌ",
    // Tha Series
    "த", "தா", "தி", "தீ", "து", "தூ", "தெ", "தே", "தை", "தொ", "தோ", "தௌ",
    // Na Series
    "ந", "நா", "நி", "நீ", "நு", "நூ", "நெ", "நே", "நை", "நொ", "நோ", "நௌ",
    // Pa Series
    "ப", "பா", "பி", "பீ", "பு", "பூ", "பெ", "பே", "பை", "பொ", "போ", "பௌ",
    // Ma Series
    "ம", "மா", "மி", "மீ", "மு", "மூ", "மெ", "மே", "மை", "மொ", "மோ", "மௌ",
    // Ya Series
    "ய", "யா", "யி", "யீ", "யு", "யூ", "யெ", "யே", "யை", "யொ", "யோ", "யௌ",
    // Ra Series
    "ர", "ரா", "ரி", "ரீ", "ரு", "ரூ", "ரெ", "ரே", "ரை", "ரொ", "ரோ", "ரௌ",
    // La Series
    "ல", "லா", "லி", "லீ", "லு", "லூ", "லெ", "லே", "லை", "லொ", "லோ", "லௌ",
    // Va Series
    "வ", "வா", "வி", "வீ", "வு", "வூ", "வெ", "வே", "வை", "வொ", "வோ", "வௌ",
    // Zha Series
    "ழ", "ழா", "ழி", "ழீ", "ழு", "ழூ", "ழெ", "ழே", "ழை", "ழொ", "ழோ", "ழௌ",
    // La Series
    "ள", "ளா", "ளி", "ளீ", "ளு", "ளூ", "ளெ", "ளே", "ளை", "ளொ", "ளோ", "ளௌ",
    // Ra Series
    "ற", "றா", "றி", "றீ", "று", "றூ", "றெ", "றே", "றை", "றொ", "றோ", "றௌ",
    // Na Series
    "ன", "னா", "ணி", "னீ", "னு", "னூ", "னெ", "னே", "னை", "னொ", "னோ", "னௌ"
};
 public static List<string> BanglaCharacters = new List<string>
 {
    // Bengali Vowels (স্বরবর্ণ)
    "অ", "আ", "ই", "ঈ", "উ", "ঊ", "ঋ", "এ", "ঐ", "ও", "ঔ",
    
    // Bengali Consonants (ব্যঞ্জনবর্ণ)
    "ক", "খ", "গ", "ঘ", "ঙ",
    "চ", "ছ", "জ", "ঝ", "ঞ",
    "ট", "ঠ", "ড", "ঢ", "ণ",
    "ত", "থ", "দ", "ধ", "ন",
    "প", "ফ", "ব", "ভ", "ম",
    "য", "র", "ল", "শ", "ষ", "স", "হ",
    "ড়", "ঢ়", "য়", "ৎ", "ং", "ঃ", "ঁ",
    
    // Bengali Combinations of Vowels and Consonants (বর্ণ-স্বরবর্ণের সংমিশ্রণ)
    // Ka Series
    "কা", "কি", "কী", "কু", "কূ", "কৃ", "কে", "কৈ", "কো", "কৌ",
    // Kha Series
    "খা", "খি", "খী", "খু", "খূ", "খৃ", "খে", "খৈ", "খো", "খৌ",
    // Ga Series
    "গা", "গি", "গী", "গু", "গূ", "গৃ", "গে", "গৈ", "গো", "গৌ",
    // Gha Series
    "ঘা", "ঘি", "ঘী", "ঘু", "ঘূ", "ঘৃ", "ঘে", "ঘৈ", "ঘো", "ঘৌ",
    // Nga Series
    "ঙা", "ঙি", "ঙী", "ঙু", "ঙূ", "ঙৃ", "ঙে", "ঙৈ", "ঙো", "ঙৌ",
    // Cha Series
    "চা", "চি", "চী", "চু", "চূ", "চৃ", "চে", "চৈ", "চো", "চৌ",
    // Chha Series
    "ছা", "ছি", "ছী", "ছু", "ছূ", "ছৃ", "ছে", "ছৈ", "ছো", "ছৌ",
    // Ja Series
    "জা", "জি", "জী", "জু", "জূ", "জৃ", "জে", "জৈ", "জো", "জৌ",
    // Jha Series
    "ঝা", "ঝি", "ঝী", "ঝু", "ঝূ", "ঝৃ", "ঝে", "ঝৈ", "ঝো", "ঝৌ",
    // Nga Series
    "ঞা", "ঞি", "ঞী", "ঞু", "ঞূ", "ঞৃ", "ঞে", "ঞৈ", "ঞো", "ঞৌ",
    // Ta Series
    "টা", "টি", "টী", "টু", "টূ", "টৃ", "টে", "টৈ", "টো", "টৌ",
    // Tha Series
    "ঠা", "ঠি", "ঠী", "ঠু", "ঠূ", "ঠৃ", "ঠে", "ঠৈ", "ঠো", "ঠৌ",
    // Da Series
    "ডা", "ডি", "ডী", "ডু", "ডূ", "ডৃ", "ডে", "ডৈ", "ডো", "ডৌ",
    // Dha Series
    "ঢা", "ঢি", "ঢী", "ঢু", "ঢূ", "ঢৃ", "ঢে", "ঢৈ", "ঢো", "ঢৌ",
    // Na Series
    "ণা", "ণি", "ণী", "ণু", "ণূ", "ণৃ", "ণে", "ণৈ", "ণো", "ণৌ",
    // Ta Series
    "তা", "তি", "তী", "তু", "তূ", "তৃ", "তে", "তৈ", "তো", "তৌ",
    // Tha Series
    "থা", "থি", "থী", "থু", "থূ", "থৃ", "থে", "থৈ", "থো", "থৌ",
    // Da Series
    "দা", "দি", "দী", "দু", "দূ", "দৃ", "দে", "দৈ", "দো", "দৌ",
    // Dha Series
    "ধা", "ধি", "ধী", "ধু", "ধূ", "ধৃ", "ধে", "ধৈ", "ধো", "ধৌ",
    // Na Series
    "না", "নি", "নী", "নু", "নূ", "নৃ", "নে", "নৈ", "নো", "নৌ",
    // Pa Series
    "পা", "পি", "পী", "পু", "পূ", "পৃ", "পে", "পৈ", "পো", "পৌ",
    // Pha Series
    "ফা", "ফি", "ফী", "ফু", "ফূ", "ফৃ", "ফে", "ফৈ", "ফো", "ফৌ",
    // Ba Series
    "বা", "বি", "বী", "বু", "বূ", "বৃ", "বে", "বৈ", "বো", "বৌ",
    // Bha Series
    "ভা", "ভি", "ভী", "ভু", "ভূ", "ভৃ", "ভে", "ভৈ", "ভো", "ভৌ",
    // Ma Series
    "মা", "মি", "মী", "মু", "মূ", "মৃ", "মে", "মৈ", "মো", "মৌ",
    // Ya Series
    "য়া", "য়ি", "য়ী", "য়ু", "য়ূ", "য়ৃ", "য়ে", "য়ৈ", "য়ো", "য়ৌ",
    // Ra Series
    "রা", "রি", "রী", "রু", "রূ", "রৃ", "রে", "রৈ", "রো", "রৌ",
    // La Series
    "লা", "লি", "লী", "লু", "লূ", "লৃ", "লে", "লাই", "লো", "লৌ",
    // Sha Series
    "শা", "শি", "শী", "শু", "শূ", "শৃ", "শে", "শৈ", "শো", "শৌ",
    // SSA Series
    "ষা", "ষি", "ষী", "ষু", "ষূ", "ষৃ", "ষে", "ষৈ", "ষো", "ষৌ",
    // Sa Series
    "সা", "সি", "সী", "সু", "সূ", "সৃ", "সে", "সৈ", "সো", "সৌ",
    // Ha Series
    "হা", "হি", "হী", "হু", "হূ", "হৃ", "হে", "হৈ", "হো", "হৌ",
    // Rra Series
    "ড়া", "ড়ি", "ড়ী", "ড়ু", "ড়ূ", "ড়ৃ", "ড়ে", "ড়ৈ", "ড়ো", "ড়ৌ",
    // Rha Series
    "ঢ়া", "ঢ়ি", "ঢ়ী", "ঢ়ু", "ঢ়ূ", "ঢ়ৃ", "ঢ়ে", "ঢ়ৈ", "ঢ়ো", "ঢ়ৌ",
    // Ya Series
    "য়া", "য়ি", "য়ী", "য়ু", "য়ূ", "য়ৃ", "য়ে", "য়ৈ", "য়ো", "য়ৌ",
    // Various Other
    "ৎ", "ং", "ঃ", "ঁ"
};

        public static List<string> HindiCharacters = new List<string>
{
    // Hindi Vowels (स्वर)
    "अ", "आ", "इ", "ई", "उ", "ऊ", "ऋ", "ए", "ऐ", "ओ", "औ",
    
    // Hindi Consonants (व्यंजन)
    "क", "ख", "ग", "घ", "ङ",
    "च", "छ", "ज", "झ", "ञ",
    "ट", "ठ", "ड", "ढ", "ण",
    "त", "थ", "द", "ध", "न",
    "प", "फ", "ब", "भ", "म",
    "य", "र", "ल", "व",
    "श", "ष", "स", "ह",
    "क्ष", "त्र", "ज्ञ",
    
    // Hindi Combinations of Vowels and Consonants (स्वर-व्यंजन संयोग)
    // Ka Series
    "का", "कि", "की", "कु", "कू", "कृ", "के", "कै", "को", "कौ",
    // Kha Series
    "खा", "खि", "खी", "खु", "खू", "खृ", "खे", "खै", "खो", "खौ",
    // Ga Series
    "गा", "गि", "गी", "गु", "गू", "गृ", "गे", "गै", "गो", "गौ",
    // Gha Series
    "घा", "घि", "घी", "घु", "घू", "घृ", "घे", "घै", "घो", "घौ",
    // Nga Series
    "ंगा", "ंगी", "ंगु", "ंगू", "ंगृ", "ंगे", "ंगै", "ंगो", "ंगौ",
    // Cha Series
    "चा", "ची", "चु", "चू", "चृ", "चे", "चै", "चो", "चौ",
    // Chha Series
    "छा", "छि", "छी", "छु", "छू", "छृ", "छे", "छै", "छो", "छौ",
    // Ja Series
    "जा", "जी", "जू", "जी", "जे", "जै", "जो", "जौ",
    // Jha Series
    "झा", "झि", "झी", "झु", "झू", "झृ", "झे", "झै", "झो", "झौ",
    // Nga Series
    "ञा", "ञि", "ञी", "ञु", "ञू", "ञृ", "ञे", "ञै", "ञो", "ञौ",
    // Ta Series
    "टा", "टी", "टू", "टृ", "टे", "टै", "टो", "टौ",
    // Tha Series
    "ठा", "ठि", "ठी", "ठु", "ठू", "ठृ", "ठे", "ठै", "ठो", "ठौ",
    // Da Series
    "डा", "डी", "डू", "डृ", "डे", "डै", "डो", "डौ",
    // Dha Series
    "ढा", "ढि", "ढी", "ढु", "ढू", "ढृ", "ढे", "ढै", "ढो", "ढौ",
    // Na Series
    "णा", "णी", "णु", "णू", "णृ", "णे", "णै", "णो", "णौ",
    // Ta Series
    "ता", "ति", "ती", "तु", "तू", "तृ", "ते", "तै", "तो", "तौ",
    // Tha Series
    "था", "थि", "थी", "थु", "थू", "थृ", "थे", "थै", "थो", "थौ",
    // Da Series
    "दा", "दि", "दी", "दु", "दू", "दृ", "दे", "दै", "दो", "दौ",
    // Dha Series
    "धा", "धि", "धी", "धु", "धू", "धृ", "धे", "धै", "धो", "धौ",
    // Na Series
    "ना", "नि", "नी", "नु", "नू", "नृ", "ने", "नै", "नो", "नौ",
    // Pa Series
    "पा", "पी", "पू", "पृ", "पे", "पै", "पो", "पौ",
    // Pha Series
    "फा", "फि", "फी", "फु", "फू", "फृ", "फे", "फै", "फो", "फौ",
    // Ba Series
    "बा", "बी", "बू", "बृ", "बे", "बै", "बो", "बौ",
    // Bha Series
    "भा", "भी", "भू", "भृ", "भे", "भै", "भो", "भौ",
    // Ma Series
    "मा", "मी", "मू", "मृ", "मे", "मै", "मो", "मौ",
    // Ya Series
    "या", "यी", "यु", "यू", "ये", "मै", "यो", "यौ",
    // Ra Series
    "रा", "री", "रु", "रू", "रे", "रै", "रो", "रौ",
    // La Series
    "ला", "ली", "लु", "लू", "ले", "लै", "लो", "लौ",
    // Sha Series
    "शा", "शी", "शु", "शू", "शे", "शै", "शो", "शौ",
    // SSA Series
    "षा", "षि", "षी", "षु", "षू", "षे", "षै", "षो", "षौ",
    // Sa Series
    "सा", "सी", "सु", "सू", "से", "सै", "सो", "सौ",
    // Ha Series
    "हा", "ही", "हु", "हू", "हे", "है", "हो", "हौ",
    // Various Other
    "ऀ", "ऽ", "ा", "ि", "ी", "ु", "ू", "ृ", "े", "ै", "ो", "ौ", "्"
};


        public static List<string> JapaneseCharacters = new List<string>() {
            "あ", "い", "う", "え", "お",  // Vowels
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
            "ワ", "ヲ", "ン",                // W and N
            // Combinations
            "キャ", "キュ", "キョ",  // Kya, Kyu, Kyo
            "シャ", "シュ", "ショ",  // Sha, Shu, Sho
            "チャ", "チュ", "チョ",  // Cha, Chu, Cho
            "ニャ", "ニュ", "ニョ",  // Nya, Nyu, Nyo
            "ヒャ", "ヒュ", "ヒョ",  // Hya, Hyu, Hyo
            "ミャ", "ミュ", "ミョ",  // Mya, Myu, Myo
            "リャ", "リュ", "リョ"   // Rya, Ryu, Ryo
        };
        static string SerializeObjectToXml<T>(T obj)
        {
            XmlSerializer serializer = new XmlSerializer(typeof(T));
            using (StringWriter stringWriter = new StringWriter())
            {
                serializer.Serialize(stringWriter, obj);
                return stringWriter.ToString();
            }
        }

        // Method to deserialize XML string back to an object
        static T DeserializeXmlToObject<T>(string xml)
        {
            XmlSerializer serializer = new XmlSerializer(typeof(T));
            using (StringReader stringReader = new StringReader(xml))
            {
                return (T)serializer.Deserialize(stringReader);
            }
        }

        public static string ConvertToUnicodeEscape(string input)
        {
            StringBuilder sb = new StringBuilder();
            foreach (char c in input)
            {
                sb.AppendFormat("\\u{0:X4}", (int)c);
            }
            return sb.ToString();
        }
        public static string ConvertUnicodeToString(string unicodeSequence)
        {
            string hex = unicodeSequence.Substring(2);
            int codePoint = int.Parse(hex, System.Globalization.NumberStyles.HexNumber);
            char unicodeChar = (char)codePoint;
            return unicodeChar.ToString();
        }
    }
}
