/*----------------------------------------------------------------------------------------
 Program Name       | MessageResources.cs
 Language           | C#
 Name               | メッセージアクセスクラス
 Preparation person | T.Ryumura(CTC)
 Note               | 
------------------------------------------------------------------------------------------
 2017-11-24         | Original Source Release
------------------------------------------------------------------------------------------*/
namespace ObyBoxUpDownload.ObyBoxCommon.Messages
{
    using System;
    using System.Collections.Generic;
    using System.IO;
    using System.Reflection;
    using System.Xml.Serialization;

    /// <summary>
    /// メッセージアクセスクラス
    /// </summary>
    public class MessageResources
    {
        // 本クラスのインスタンス
        private static MessageResources _Instance;

        // ロックオブジェクト
        private static object lockObject = new object();

        /// <summary>
        /// 設定プロパティ
        /// </summary>
        public Dictionary<string, string> Messages { get; set; }

        /// <summary>
        /// シングルトンインスタンス
        /// </summary>
        public static MessageResources Instance
        {
            get
            {
                if (_Instance == null)
                {
                    lock (lockObject)
                    {
                        if (_Instance == null)
                        {
                            _Instance = new MessageResources();
                            _Instance.Load();
                        }
                    }
                }
                return _Instance;
            }
        }

        /// <summary>
        /// メッセージを全て読み込む
        /// </summary>
        public void Load()
        {
            using (var fs = new FileStream(GetXmlFilePath(), FileMode.Open, FileAccess.Read, FileShare.ReadWrite))
            {
                var serializer = new XmlSerializer(typeof(MessageList));
                var messageList = serializer.Deserialize(fs) as MessageList;
                this.Messages = new Dictionary<string, string>();
                messageList.Messages.ForEach(x =>
                {
                    this.Messages.Add(x.Id, x.Value.Replace("\\r\\n", "\r\n"));
                });
                fs.Flush();
            }
        }

        /// <summary>
        /// メッセージ本文を取得します
        /// </summary>
        /// <param name="messageId">メッセージID</param>
        /// <param name="keyValuePairs">文字列に置換するKeyValue</param>
        /// <returns></returns>
        public string GetMessage(string messageId, object keyValuePairs = null)
        {
            string message = default(string);
            try
            {
                message = this.Messages[messageId];
                if (keyValuePairs != null)
                {
                    var properties = keyValuePairs.GetType().GetProperties();
                    foreach (var prop in properties)
                    {
                        message = message.Replace("{" + prop.Name + "}", prop.GetValue(keyValuePairs, null)?.ToString());
                    }
                }
            }
            catch(Exception ex)
            {
                message = "MessageResources.xmlの読み込みに失敗しているため、メッセージを取得出来ません";
                throw new Exception(message, ex);
            }
            return message;
        }
        /// <summary>
        /// 設定ファイルXMLのパスを取得する
        /// </summary>
        /// <returns>設定ファイルXMLのパス</returns>
        private string GetXmlFilePath()
        {
            return Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location) + @"\MessageResources.xml";
        }
    }
}
