/*----------------------------------------------------------------------------------------
 Program Name       | Folder.cs
 Language           | C#
 Name               | アップロードフォルダ設定クラス
 Preparation person | T.Ryumura(CTC)
 Note               | 
------------------------------------------------------------------------------------------
 2017-11-24         | Original Source Release
------------------------------------------------------------------------------------------*/
namespace ObyBoxUpDownload.ObyBoxCommon.Config
{
    /// <summary>
    /// アップロードフォルダ設定クラス
    /// </summary>
    public class Folder
    {
        /// <summary>
        /// アップロードフォルダ名
        /// </summary>
        [DisplayName("アップロードフォルダ名")]
        [System.Xml.Serialization.XmlAttribute("name")]
        public string Name { get; set; }

        /// <summary>
        /// アップロードフォルダ区分
        /// </summary>
        [DisplayName("アップロードフォルダ区分")]
        [System.Xml.Serialization.XmlAttribute("type")]
        public string Type { get; set; }

        /// <summary>
        /// ローカルパス
        /// </summary>
        [DisplayName("ローカルパス")]
        [System.Xml.Serialization.XmlElement("LocalPath")]
        public string LocalPath { get; set; }

        /// <summary>
        /// BoxフォルダID
        /// </summary>
        [DisplayName("BoxフォルダID")]
        [System.Xml.Serialization.XmlElement("BoxFolderId")]
        public string BoxFolderId { get; set; }

        /// <summary>
        /// 作成時0バイトファイル無視
        /// </summary>
        [DisplayName("作成時0バイトファイル無視")]
        [System.Xml.Serialization.XmlElement("IgnoreCreateZero")]
        public string IgnoreCreateZero { get; set; }

        /// <summary>
        /// プロパティ名
        /// </summary>
        public enum PropertyName
        {
            /// <summary>アップロードフォルダ名</summary>
            Name,
            /// <summary>アップロードフォルダ区分</summary>
            Type,
            /// <summary>ローカルパス</summary>
            LocalPath,
            /// <summary>BoxフォルダID</summary>
            BoxFolderId,
            /// <summary>作成時0バイトファイル無視</summary>
            IgnoreCreateZero
        }
    }
}
