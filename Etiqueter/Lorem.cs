using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Etiqueter
{
    public partial class Lorem
    {
        public static string[] CambiaIdioma(string idioma)
        {
            switch (idioma)
            {
                case "esp":
                    return SpanishArray;

                case "eng":
                    return EnglishArray;

                case "ger":
                    return GermanArray;

                case "chn":
                    return ChineseArray;

                case "jpn":
                    return JapanArray;

                default:
                    return EnglishArray;
            }
        }


        public static string[] EnglishArray = new string[]
        {
            "Etiqueter",                //00
            "Configuration",            //01
            "Brand and store code",     //02
            "Country",                  //03
            "Amount of screens",        //04
            "Double labels",            //05
            "Double LED_",              //06
            "Prepare",                  //07
            "LABELS",                   //08
            "Screen",                   //09
            "Store",                    //10
            "Comment",                  //11
            "Global format",            //12
            "Porsche format",           //13
            "Working folder",
            "Select folder"

        };
        
        public static string[] SpanishArray = new string[]
        {
            "Etiqueter",
            "Configuración",
            "Cadena y número de tienda",
            "País",
            "Número de pantallas: ",
            "Duplicar etiquetas",
            "Duplicar LED_",
            "Preparar",
            "ETIQUETAS",
            "Pantalla ",
            "Tienda ",
            "Comentario",
            "Formato global",
            "Formato Porsche",
            "Carpeta",
            "Cambiar carpeta"

        };

        public static string[] GermanArray = new string[]
        {
            "Etiqueter",
            "Konfiguration",
            "Marke und Filialcode",
            "Land",
            "Anzahl der Bildschirme: ",
            "Doppelte Etiketten",
            "Doppelte LED_",
            "Vorbereiten",
            "LABELS",
            "Bildschirm",
            "Speichern",
            "Kommentar",
            "Globales Format",
            "Porsche-Format",
            "Ordner",
            "Ordner ändern"
        };
        
        public static string[] ChineseArray = new string[]
        {
            "Etiqueter",
            "配置",
            "品牌和商店代码",
            "国家",
            "屏幕数量: ",
            "双重标签",
            "双LED",
            "准备",
            "标签",
            "屏幕",
            "商店",
            "评论",
            "全球格式",
            "保时捷格式",
            "卡皮塔",
            "更改文件夹"
        };

        public static string[] JapanArray = new string[]
        {
            "Etiqueter",
            "構成",
            "ブランド・店舗コード",
            "国",
            "画面の数: ",
            "ダブルラベル",
            "ダブルLED",
            "準備",
            "ラベル",
            "スクリーン",
            "ストア",
            "コメント",
            "グローバルフォーマット",
            "ポルシェフォーマット",
            "カルペタ",
            "フォルダの変更"
        };
    }
}
