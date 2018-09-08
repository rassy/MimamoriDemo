/*----------------------------------------------------------------------------------------
 Program Name       | Message.cs
 Language           | C#
 Name               | メッセージクラス
 Preparation person | T.Ryumura(CTC)
 Note               | 
------------------------------------------------------------------------------------------
 2017-11-24         | Original Source Release
------------------------------------------------------------------------------------------*/
namespace ObyBoxUpDownload.ObyBoxCommon.Messages
{
    /// <summary>
    /// メッセージクラス
    /// </summary>
    public class Message
    {
        /// <summary>
        /// メッセージID
        /// </summary>
        [System.Xml.Serialization.XmlAttribute("id")]
        public string Id { get; set; }

        /// <summary>
        /// メッセージ文言
        /// </summary>
        [System.Xml.Serialization.XmlText]
        public string Value { get; set; }
    }
}
