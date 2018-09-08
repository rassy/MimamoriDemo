/*----------------------------------------------------------------------------------------
 Program Name       | MessageList.cs
 Language           | C#
 Name               | メッセージリストクラス
 Preparation person | T.Ryumura(CTC)
 Note               | 
------------------------------------------------------------------------------------------
 2017-11-24         | Original Source Release
------------------------------------------------------------------------------------------*/
namespace ObyBoxUpDownload.ObyBoxCommon.Messages
{
    using System.Collections.Generic;

    /// <summary>
    /// メッセージリストクラス
    /// </summary>
    [System.Xml.Serialization.XmlRoot("messages")]
    public class MessageList
    {
        /// <summary>
        /// メッセージリスト
        /// </summary>
        [System.Xml.Serialization.XmlElement("message")]
        public List<Message> Messages { get; set; }
    }
}
