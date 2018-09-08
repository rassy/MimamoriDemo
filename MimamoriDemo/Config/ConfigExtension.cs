/*----------------------------------------------------------------------------------------
 Program Name       | ConfigNameExtension.cs
 Language           | C#
 Name               | 設定拡張クラス
 Preparation person | T.Ryumura(CTC)
 Note               | 
------------------------------------------------------------------------------------------
 2017-11-24         | Original Source Release
------------------------------------------------------------------------------------------*/
namespace ObyBoxUpDownload.ObyBoxCommon.Config
{
    /// <summary>
    /// PropertyName拡張メソッド
    /// </summary>
    public static class ConfigNameExtension
    {
        /// <summary>
        /// プロパティのDisplayName属性を取得する
        /// </summary>
        /// <param name="propertyName">プロパティ名</param>
        /// <returns>表示名</returns>
        public static string DisplayName(this Configuration.PropertyName propertyName)
        {
            return ((DisplayNameAttribute)System.Attribute.GetCustomAttribute(typeof(Configuration).GetProperty(propertyName.ToString()), typeof(DisplayNameAttribute))).Value;
        }
        /// <summary>
        /// プロパティのDisplayName属性を取得する
        /// </summary>
        /// <param name="propertyName">プロパティ名</param>
        /// <returns>表示名</returns>
        public static string DisplayName(this Folder.PropertyName propertyName)
        {
            return ((DisplayNameAttribute)System.Attribute.GetCustomAttribute(typeof(Folder).GetProperty(propertyName.ToString()), typeof(DisplayNameAttribute))).Value;
        }
        /// <summary>
        /// プロパティのDisplayName属性を取得する
        /// </summary>
        /// <param name="propertyName">プロパティ名</param>
        /// <returns>表示名</returns>
        public static string DisplayName(this Proxy.PropertyName propertyName)
        {
            return ((DisplayNameAttribute)System.Attribute.GetCustomAttribute(typeof(Proxy).GetProperty(propertyName.ToString()), typeof(DisplayNameAttribute))).Value;
        }
    }
    /// <summary>
    /// Propertyのカスタム属性
    /// </summary>
    public class DisplayNameAttribute : System.Attribute
    {
        /// <summary>
        /// 表示名
        /// </summary>
        public string Value { get; set; }
        /// <summary>
        /// 表示名を設定する
        /// </summary>
        /// <param name="name">表示名</param>
        public DisplayNameAttribute(string name)
        {
            this.Value = name;
        }
    }
}
