/*----------------------------------------------------------------------------------------
 Program Name       | Configuration.cs
 Language           | C#
 Name               | 設定クラス
 Preparation person | T.Ryumura(CTC)
 Note               | 
------------------------------------------------------------------------------------------
 2017-11-24         | Original Source Release
------------------------------------------------------------------------------------------*/
namespace ObyBoxUpDownload.ObyBoxCommon.Config
{
    using System.Collections.Generic;

    /// <summary>
    /// 設定クラス
    /// </summary>
    [System.Xml.Serialization.XmlRoot("configuration")]
    public class Configuration
    {
        /// <summary>
        /// アップロードフォルダ情報
        /// </summary>
        [DisplayName("アップロードフォルダ")]
        [System.Xml.Serialization.XmlArray("UploadFolder")]
        public List<Folder> UploadFolder { get; set; }

        /// <summary>
        /// クライアントID
        /// </summary>
        [DisplayName("クライアントID")]
        [System.Xml.Serialization.XmlElement("ClientId")]
        public string ClientId { get; set; }

        /// <summary>
        /// クライアント秘密鍵
        /// </summary>
        [DisplayName("クライアント秘密鍵")]
        [System.Xml.Serialization.XmlElement("ClientSecret")]
        public string ClientSecret { get; set; }

        /// <summary>
        /// リダイレクトURL
        /// </summary>
        [DisplayName("リダイレクトURL")]
        [System.Xml.Serialization.XmlElement("RedirectUrl")]
        public string RedirectUrl { get; set; }

        /// <summary>
        /// トークンタイプ
        /// </summary>
        [DisplayName("トークンタイプ")]
        [System.Xml.Serialization.XmlElement("TokenType")]
        public string TokenType { get; set; }

        /// <summary>
        /// フォルダ作成処理の並列実行数
        /// </summary>
        [DisplayName("フォルダ作成処理の並列実行数")]
        [System.Xml.Serialization.XmlElement("DegreeOfParallelismOfFolder")]
        public int DegreeOfParallelismOfFolder { get; set; }

        /// <summary>
        /// ファイル作成処理の並列実行数
        /// </summary>
        [DisplayName("ファイル作成処理の並列実行数")]
        [System.Xml.Serialization.XmlElement("DegreeOfParallelismOfFile")]
        public int DegreeOfParallelismOfFile { get; set; }

        /// <summary>
        /// ファイルアップロード処理のタイムアウト時間（分）
        /// </summary>
        [DisplayName("ファイルアップロード処理のタイムアウト時間（分）")]
        [System.Xml.Serialization.XmlElement("UploadTimeout")]
        public int UploadTimeout { get; set; }

        /// <summary>
        /// 変更検知除外ファイル名パターン（正規表現）
        /// </summary>
        [DisplayName("アップロード除外ファイル名パターン（正規表現）")]
        [System.Xml.Serialization.XmlElement("IgnoreFilePattern")]
        public string IgnoreFilePattern { get; set; }

        /// <summary>
        /// ファイル走査待機間隔（ファイル数）
        /// </summary>
        [DisplayName("ファイル走査待機間隔")]
        [System.Xml.Serialization.XmlElement("ScanInterval")]
        public int ScanInterval { get; set; }

        /// <summary>
        /// ダウンロードモード
        /// </summary>
        [DisplayName("ダウンロードプログラムの起動モード")]
        [System.Xml.Serialization.XmlElement("DownloadMode")]
        public string DownloadMode { get; set; }

        /// <summary>
        /// フォルダIDリストファイルパス
        /// </summary>
        [DisplayName("フォルダIDリストファイルパス")]
        [System.Xml.Serialization.XmlElement("FolderIdListFilePath")]
        public string FolderIdListFilePath { get; set; }

        /// <summary>
        /// フォルダIDリストバックアップフォルダパス
        /// </summary>
        [DisplayName("フォルダIDリストバックアップフォルダパス")]
        [System.Xml.Serialization.XmlElement("FolderIdBackupFolderPath")]
        public string FolderIdBackupFolderPath { get; set; }

        /// <summary>
        /// ダウンロード先フォルダパス
        /// </summary>
        [DisplayName("ダウンロード先フォルダパス")]
        [System.Xml.Serialization.XmlElement("DownloadFolderPath")]
        public string DownloadFolderPath { get; set; }

        /// <summary>
        /// ダウンロード時の非同期ファイル処理数
        /// </summary>
        [DisplayName("ダウンロード時の非同期ファイル処理数")]
        [System.Xml.Serialization.XmlElement("AsyncFileDownloadNum")]
        public int AsyncFileDownloadNum { get; set; }

        /// <summary>
        /// DB接続文字列
        /// </summary>
        [DisplayName("DB接続文字列")]
        [System.Xml.Serialization.XmlElement("ConnectionString")]
        public string ConnectionString { get; set; }

        /// <summary>
        /// ダウンロードリトライ回数
        /// </summary>
        [DisplayName("ダウンロードリトライ回数")]
        [System.Xml.Serialization.XmlElement("DownloadRetryCount")]
        public int DownloadRetryCount { get; set; }

        /// <summary>
        /// ダウンロード例外発生時の待機時間（秒）
        /// </summary>
        [DisplayName("ダウンロード例外発生時の待機時間（秒）")]
        [System.Xml.Serialization.XmlElement("DownloadExceptionWaitTime")]
        public int DownloadExceptionWaitTime { get; set; }

        /// <summary>
        /// プロキシサーバ設定
        /// </summary>
        [DisplayName("プロキシ")]
        [System.Xml.Serialization.XmlElement("Proxy")]
        public Proxy WebProxy { get; set; }

        /// <summary>
        /// ローカルアイテム一覧に1回で登録する件数
        /// </summary>
        [DisplayName("ローカルアイテム一覧追加単位（件数）")]
        [System.Xml.Serialization.XmlElement("LocalItemInfoInsertCount")]
        public int LocalItemInfoInsertCount { get; set; }

        /// <summary>
        /// プロパティ名
        /// </summary>
        public enum PropertyName
        {
            /// <summary>アップロードフォルダ</summary>
            UploadFolder,
            /// <summary>クライアントID</summary>
            ClientId,
            /// <summary>クライアント秘密鍵</summary>
            ClientSecret,
            /// <summary>リダイレクトURL</summary>
            RedirectUrl,
            /// <summary>トークンタイプ</summary>
            TokenType,
            /// <summary>フォルダ作成処理の並列実行数</summary>
            DegreeOfParallelismOfFolder,
            /// <summary>ファイル作成処理の並列実行数</summary>
            DegreeOfParallelismOfFile,
            /// <summary>ファイルアップロード処理のタイムアウト時間（分）</summary>
            UploadTimeout,
            /// <summary>アップロード除外ファイル名パターン（正規表現）</summary>
            IgnoreFilePattern,
            /// <summary>ファイル走査待機間隔</summary>
            ScanInterval,
            /// <summary>ダウンロードプログラムの起動モード</summary>
            DownloadMode,
            /// <summary>フォルダIDリストファイルパス</summary>
            FolderIdListFilePath,
            /// <summary>フォルダIDリストバックアップフォルダパス</summary>
            FolderIdBackupFolderPath,
            /// <summary>ダウンロード先フォルダパス</summary>
            DownloadFolderPath,
            /// <summary>ダウンロード時の非同期ファイル処理数</summary>
            AsyncFileDownloadNum,
            /// <summary>ファイルダウンロード処理のタイムアウトリトライ回数</summary>
            DownloadRetryCount,
            /// <summary>ダウンロード例外発生時の待機時間（秒）</summary>
            DownloadExceptionWaitTime,
            /// <summary>プロキシ</summary>
            Proxy,
            /// <summary>ローカルアイテム一覧追加単位（件数）</summary>
            LocalItemInfoInsertCount,
            /// <summary>DB接続文字列</summary>
            ConnectionString,
        }
    }
}
