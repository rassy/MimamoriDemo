/*----------------------------------------------------------------------------------------
 Program Name       | Proxy.cs
 Language           | C#
 Name               | プロキシ設定クラス
 Preparation person | T.Ryumura(CTC)
 Note               | 
------------------------------------------------------------------------------------------
 2017-11-24         | Original Source Release
------------------------------------------------------------------------------------------*/
namespace ObyBoxUpDownload.ObyBoxCommon.Config
{
    /// <summary>
    /// プロキシ設定クラス
    /// </summary>
    public class Proxy
    {
        /// <summary>
        /// プロキシURｌ
        /// </summary>
        [DisplayName("プロキシURL")]
        [System.Xml.Serialization.XmlElement("URL")]
        public string URL { get; set; }

        /// <summary>
        /// プロキシ認証ユーザID
        /// </summary>
        [DisplayName("プロキシ認証ユーザID")]
        [System.Xml.Serialization.XmlElement("UserId")]
        public string UserId { get; set; }

        /// <summary>
        /// プロキシ認証パスワード
        /// </summary>
        [DisplayName("プロキシ認証パスワード")]
        [System.Xml.Serialization.XmlElement("Password")]
        public string Password { get; set; }

        /// <summary>
        /// プロパティ名
        /// </summary>
        public enum PropertyName
        {
            /// <summary>プロキシURL</summary>
            URL,
            /// <summary>プロキシ認証ユーザID</summary>
            UserId,
            /// <summary>プロキシ認証パスワード</summary>
            Password
        }
    }
}
