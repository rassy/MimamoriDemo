/*----------------------------------------------------------------------------------------
 Program Name       | ConfigurationAccessor.cs
 Language           | C#
 Name               | 設定アクセスクラス
 Preparation person | T.Ryumura(CTC)
 Note               | 
------------------------------------------------------------------------------------------
 2017-11-24         | Original Source Release
------------------------------------------------------------------------------------------*/
namespace ObyBoxUpDownload.ObyBoxCommon.Config
{
    using System;
    using System.Collections.Generic;
    using System.IO;
    using System.Reflection;
    using System.Xml.Serialization;
    using Exceptions;
    using Messages;

    /// <summary>
    /// 設定ファイル逆シリアライズクラス
    /// </summary>
    public class ConfigurationAccessor
    {
        // 本クラスのインスタンス
        private static ConfigurationAccessor _Instance;

        // ロックオブジェクト
        private static object lockObject = new object();

        /// <summary>
        /// 設定プロパティ
        /// </summary>
        public Configuration Config { get; set; }

        /// <summary>
        /// シングルトンインスタンス
        /// </summary>
        public static ConfigurationAccessor Instance
        {
            get
            {
                if (_Instance == null)
                {
                    lock (lockObject)
                    {
                        if (_Instance == null)
                        {
                            _Instance = new ConfigurationAccessor();
                            _Instance.Load();
                        }
                    }
                }
                return _Instance;
            }
        }

        /// <summary>
        /// 設定項目の必須チェック
        /// </summary>
        /// <param name="keys">PropertyName enumのリスト</param>
        /// <remarks>
        /// チェックNGの場合はAggregateExceptionがthrowされます。
        /// </remarks>
        public void CheckConfiguration(params object[] keys)
        {
            CheckConfiguration(_Instance.Config, keys);
        }

        /// <summary>
        /// 設定項目の必須チェック
        /// </summary>
        /// <param name="target">チェック対象のインスタンス</param>
        /// <param name="keys">PropertyName enumのリスト</param>
        private void CheckConfiguration(object target, params object[] keys)
        {
            var ex = new List<Exception>();
            foreach (var key in keys)
            {
                PropertyInfo pInfo = target.GetType().GetProperty(key.ToString());
                var value = pInfo.GetValue(target, null);
                if (value is string && string.IsNullOrEmpty(value as string))
                {
                    if (key is Configuration.PropertyName)
                    {
                        ex.Add(new AppUncontinuableException(MessageId.F0002, new { CONFIG_NAME = ((Configuration.PropertyName)key).DisplayName() }, null));
                    }
                    else if (key is Folder.PropertyName)
                    {
                        ex.Add(new AppUncontinuableException(MessageId.F0002, new { CONFIG_NAME = ((Folder.PropertyName)key).DisplayName() }, null));
                    }
                }
                if (value is List<Folder>)
                {
                    foreach (var folder in _Instance.Config.UploadFolder)
                    {
                        try
                        {
                            CheckConfiguration(folder, Folder.PropertyName.Name, Folder.PropertyName.Type, Folder.PropertyName.LocalPath, Folder.PropertyName.BoxFolderId, Folder.PropertyName.IgnoreCreateZero);
                        }
                        catch (AggregateException e)
                        {
                            ex.AddRange(e.Flatten().InnerExceptions);
                        }
                    }
                }
            }
            if (ex.Count > 0)
            {
                throw new AggregateException(ex);
            }
        }
        /// <summary>
        /// 設定項目を全て読み込む
        /// </summary>
        public void Load()
        {
            using (var fs = new FileStream(GetConfigurationPath(), FileMode.Open, FileAccess.Read, FileShare.ReadWrite))
            {
                try
                {
                    var serializer = new XmlSerializer(typeof(Configuration));
                    Config = serializer.Deserialize(fs) as Configuration;
                    fs.Flush();
                }
                catch (Exception e)
                {
                    throw new AppUncontinuableException(MessageId.F0001, new { METHOD_NAME = "設定取得", STACK_TRACE = e.ToString() }, e);
                }
            }
        }

        /// <summary>
        /// 設定ファイルXMLのパスを取得する
        /// </summary>
        /// <returns>設定ファイルXMLのパス</returns>
        private string GetConfigurationPath()
        {
            return Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location) + @"\Configuration.xml";
        }
    }
}
