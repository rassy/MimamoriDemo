/*----------------------------------------------------------------------------------------
 Program Name       | MessageId.cs
 Language           | C#
 Name               | メッセージID定義クラス
 Preparation person | T.Ryumura(CTC)
 Note               |
------------------------------------------------------------------------------------------
 2017-11-24         | Original Source Release
------------------------------------------------------------------------------------------*/
namespace ObyBoxUpDownload.ObyBoxCommon.Messages
{
    /// <summary>
    /// メッセージID定義クラス
    /// </summary>
    public class MessageId
    {
        /// <summary>
        /// {METHOD_NAME}で例外が発生したため、プログラムを終了します。\r\n{STACK_TRACE}
        /// </summary>
        public const string F0001="F0001";
        /// <summary>
        /// 設定ファイルから{CONFIG_NAME}の取得に失敗しため、プログラムを終了します。
        /// </summary>
        public const string F0002="F0002";
        /// <summary>
        /// {UPLOAD_FOLDER_NAME}が存在しないため、プログラムを終了します。[パス：{FOLDER_PATH}]
        /// </summary>
        public const string F0003="F0003";
        /// <summary>
        /// トークンが不正です。リフレッシュトークンの再取得を行ってください。
        /// </summary>
        public const string F0004="F0004";
        /// <summary>
        /// 設定ファイルのアップロードフォルダリストにフォルダ区分が同一のフォルダが存在するため、プログラムを終了します。[フォルダ区分：{FOLDER_TYPE}]
        /// </summary>
        public const string F0005="F0005";
        /// <summary>
        /// Boxの{ITEM_KIND}作成に失敗しました。[処理：{METHOD_NAME}][フォルダ区分：{FOLDER_TYPE}][パス：{PATH}][アイテム種別:{ITEM_KIND}]\r\n{STACK_TRACE}
        /// </summary>
        public const string F2001="F2001";
        /// <summary>
        /// Boxの{ITEM_KIND}更新に失敗しました。[処理：{METHOD_NAME}][フォルダ区分：{FOLDER_TYPE}][パス：{PATH}][アイテム種別:{ITEM_KIND}]\r\n{STACK_TRACE}
        /// </summary>
        public const string F2002="F2002";
        /// <summary>
        /// Boxの{ITEM_KIND}削除に失敗しました。[処理：{METHOD_NAME}][フォルダ区分：{FOLDER_TYPE}][パス：{PATH}][アイテム種別:{ITEM_KIND}]\r\n{STACK_TRACE}
        /// </summary>
        public const string F2003="F2003";
        /// <summary>
        /// 設定ファイルのBoxフォルダIDに設定されているフォルダがBoxに存在しないため、プログラムを終了します。[フォルダ区分：{FOLDER_TYPE}][フォルダID：{FOLDER_ID}]
        /// </summary>
        public const string F2004="F2004";
        /// <summary>
        /// フォルダIDリストへのアクセスに失敗したため、プログラムを終了します。[ファイルパス：{FILE_PATH}]
        /// </summary>
        public const string F3001="F3001";
        /// <summary>
        /// ファイルまたはフォルダのダウンロード中に例外が発生したため、プログラムを終了します。[ファイルID：{FILE_ID}][フォルダID：{FOLDER_ID}][パス：{PATH}]
        /// </summary>
        public const string F3002="F3002";
        /// <summary>
        /// Boxフォルダ情報取得のリトライ上限に達したため、プログラムを終了します。[フォルダID：{FOLDER_ID}][フォルダパス：{FOLDER_PATH}]
        /// </summary>
        public const string F3003="F3003";
        /// <summary>
        /// Box情報取得時に例外が発生しました。{MAX_CONTINUE_COUNT}回の継続処理を行いましたが改善されないため、プログラムを終了します。[フォルダID:{FOLDER_ID}][フォルダパス:{FOLDER_PATH}]
        /// </summary>
        public const string F3004="F3004";
        /// <summary>
        /// ファイルダウンロードまたはフォルダ作成時に例外が発生しました。{MAX_CONTINUE_COUNT}回の継続処理を行いましたが改善されないため、プログラムを終了します。[ファイルID:{FILE_ID}][フォルダID:{FOLDER_ID}][パス:{PATH}]
        /// </summary>
        public const string F3005="F3005";
        /// <summary>
        /// {METHOD_NAME}で例外が発生した。\r\n{STACK_TRACE}
        /// </summary>
        public const string E2000="E2000";
        /// <summary>
        /// 親フォルダ情報が存在しません。[フォルダ区分：{FOLDER_TYPE}][パス：{PATH}][アイテム種別:{ITEM_KIND}]
        /// </summary>
        public const string E2001="E2001";
        /// <summary>
        /// Boxの{ITEM_KIND}作成に失敗しました。[処理：{METHOD_NAME}][フォルダ区分：{FOLDER_TYPE}][パス：{PATH}][アイテム種別:{ITEM_KIND}]\r\n{STACK_TRACE}
        /// </summary>
        public const string E2002="E2002";
        /// <summary>
        /// Boxの{ITEM_KIND}更新に失敗しました。[処理：{METHOD_NAME}][フォルダ区分：{FOLDER_TYPE}][パス：{PATH}][アイテム種別:{ITEM_KIND}]\r\n{STACK_TRACE}
        /// </summary>
        public const string E2003="E2003";
        /// <summary>
        /// Boxの{ITEM_KIND}削除に失敗しました。[処理：{METHOD_NAME}][フォルダ区分：{FOLDER_TYPE}][パス：{PATH}][アイテム種別:{ITEM_KIND}]\r\n{STACK_TRACE}
        /// </summary>
        public const string E2004="E2004";
        /// <summary>
        /// 更新アップロード対象の{ITEM_KIND}がBoxに存在しません。[フォルダ区分：{FOLDER_TYPE}][パス：{PATH}][アイテム種別:{ITEM_KIND}]
        /// </summary>
        public const string E2005="E2005";
        /// <summary>
        /// 新規アップロード対象の{ITEM_KIND}が既にBoxに存在します。[フォルダ区分：{FOLDER_TYPE}][パス：{PATH}][アイテム種別:{ITEM_KIND}]
        /// </summary>
        public const string E2006="E2006";
        /// <summary>
        /// フォルダIDリストに設定されたフォルダIDが不正です。[フォルダID：{FOLDER_ID}]
        /// </summary>
        public const string E3001="E3001";
        /// <summary>
        /// Boxよりフォルダ内アイテムの取得に失敗しました。[フォルダID：{FOLDER_ID}][フォルダパス：{FOLDER_PATH}]
        /// </summary>
        public const string E3002="E3002";
        /// <summary>
        /// Boxよりファイルのダウンロードに失敗しました。[ファイルID：{FILE_ID}][ファイルパス：{FILE_PATH}]
        /// </summary>
        public const string E3003="E3003";
        /// <summary>
        /// リトライ回数が上限に達したため、このファイルのダウンロードは中止しました。[ファイルID：{FILE_ID}][ファイルパス：{FILE_PATH}]
        /// </summary>
        public const string E3004="E3004";
        /// <summary>
        /// 他のファイルのダウンロード処理で継続不能なエラーが発生したため、リトライ処理を中止します。
        /// </summary>
        public const string E3005="E3005";
        /// <summary>
        /// Box情報取得時に例外が発生しました。{CONTINUE_INTERVAL}秒待機の後、処理を再開します。({CONTINUE_COUNT}/{MAX_CONTINUE_COUNT})[フォルダID:{FOLDER_ID}][フォルダパス:{FOLDER_PATH}]
        /// </summary>
        public const string E3006="E3006";
        /// <summary>
        /// ファイルダウンロードまたはフォルダ作成時に例外が発生しました。{CONTINUE_INTERVAL}秒待機の後、処理を再開します。({CONTINUE_COUNT}/{MAX_CONTINUE_COUNT})[ファイルID:{FILE_ID}][フォルダID：{FOLDER_ID}][パス:{PATH}]
        /// </summary>
        public const string E3007="E3007";
        /// <summary>
        /// 指定されたパス、ファイル名、またはその両方が長すぎます。ファイルパスは 260 文字未満で指定し、フォルダパスは 248文字未満で指定してください。パス：{PATH}
        /// </summary>
        public const string E3008="E3008";
        /// <summary>
        /// 指定されたパス、ファイル名、またはその両方が長すぎます。ファイルパスは 260 文字未満で指定し、フォルダパスは 248文字未満で指定してください。パス：{PATH} (1つ前のパス：{PREVIOUS_PATH})
        /// </summary>
        public const string E3009="E3009";
        /// <summary>
        /// Boxに{ITEM_KIND}が既に存在します。[フォルダ区分：{FOLDER_TYPE}][パス：{PATH}][アイテム種別:{ITEM_KIND}]
        /// </summary>
        public const string W2001="W2001";
        /// <summary>
        /// Boxに{METHOD_NAME}対象{ITEM_KIND}が存在しません。[フォルダ区分：{FOLDER_TYPE}][パス：{PATH}][アイテム種別:{ITEM_KIND}]
        /// </summary>
        public const string W2002="W2002";
        /// <summary>
        /// アップロード対象の{ITEM_KIND}が存在しません。[処理：{METHOD_NAME}][フォルダ区分：{FOLDER_TYPE}][パス：{PATH}][アイテム種別:{ITEM_KIND}]
        /// </summary>
        public const string W2003="W2003";
        /// <summary>
        /// アップロード対象のファイルが開けません。[処理：{METHOD_NAME}][フォルダ区分：{FOLDER_TYPE}][パス：{PATH}][アイテム種別:{ITEM_KIND}]
        /// </summary>
        public const string W2004="W2004";
        /// <summary>
        /// フォルダIDリストにフォルダIDが設定されていません。[ファイルパス：{FILE_PATH}]
        /// </summary>
        public const string W3001="W3001";
        /// <summary>
        /// ファイルのダウンロードに失敗したため、リトライします。（{RETRY_COUNT}/{MAX_RETRY_COUNT}）[ファイルID：{FILE_ID}][ファイルパス：{FILE_PATH}]
        /// </summary>
        public const string W3002="W3002";
        /// <summary>
        /// Boxフォルダ情報の取得に失敗したため、リトライします。（{RETRY_COUNT}/{MAX_RETRY_COUNT}）[フォルダID：{FOLDER_ID}][フォルダパス：{FOLDER_PATH}]
        /// </summary>
        public const string W3003="W3003";
        /// <summary>
        /// ファイルのダウンロード時にサーバーから予期せぬレスポンスを受信しました。
        /// </summary>
        public const string W3004="W3004";
        /// <summary>
        /// {PROGRAM_NAME}が起動しました。
        /// </summary>
        public const string I0001="I0001";
        /// <summary>
        /// {PROGRAM_NAME}が終了しました。
        /// </summary>
        public const string I0002="I0002";
        /// <summary>
        /// アップロードまたは一括ダウンロードが既に実行されているため、起動することが出来ません。
        /// </summary>
        public const string I0003="I0003";
        /// <summary>
        /// {PROCESS_NAME}が開始しました。
        /// </summary>
        public const string I0004="I0004";
        /// <summary>
        /// {PROCESS_NAME}が完了しました。
        /// </summary>
        public const string I0005="I0005";
        /// <summary>
        /// トークンが更新されました。[アクセストークン:{ACCESS_TOKEN}][リフレッシュトークン:{REFRESH_TOKEN}][新しいアクセストークン:{NEW_ACCESS_TOKEN}][新しいリフレッシュトークン:{NEW_REFRESH_TOKEN}]
        /// </summary>
        public const string I0006="I0006";
        /// <summary>
        /// 除外対象ファイルのためスキップ[パス：{FILE_PATH}][検知除外パターン：{EXCLUDE_PATTERN}]
        /// </summary>
        public const string I1001="I1001";
        /// <summary>
        /// ローカルファイル一覧テーブルへの登録が完了しました。[ファイル数：{FILE_COUNT}][フォルダ数：{FOLDER_COUNT}]
        /// </summary>
        public const string I1002="I1002";
        /// <summary>
        /// アップロード対象のデータが存在しないため処理をスキップします。
        /// </summary>
        public const string I2001="I2001";
        /// <summary>
        /// BoxのAPIリクエストに成功しました。[処理：{METHOD_NAME}][フォルダ区分：{FOLDER_TYPE}][パス：{PATH}][アイテム種別:{ITEM_KIND}]
        /// </summary>
        public const string I2002="I2002";
        /// <summary>
        /// Boxに{ITEM_KIND}を作成しました。[処理：{METHOD_NAME}][フォルダ区分：{FOLDER_TYPE}][パス：{PATH}][アイテム種別:{ITEM_KIND}][ID：{ID}][サイズ：{SIZE}]
        /// </summary>
        public const string I2003="I2003";
        /// <summary>
        /// Boxの{ITEM_KIND}を更新しました。[処理：{METHOD_NAME}][フォルダ区分：{FOLDER_TYPE}][パス：{PATH}][アイテム種別:{ITEM_KIND}][ID：{ID}][サイズ：{SIZE}]
        /// </summary>
        public const string I2004="I2004";
        /// <summary>
        /// Boxの{ITEM_KIND}を削除しました。[処理：{METHOD_NAME}][フォルダ区分：{FOLDER_TYPE}][パス：{PATH}][アイテム種別:{ITEM_KIND}][ID：{ID}]
        /// </summary>
        public const string I2005="I2005";
        /// <summary>
        /// 処理結果：アップロード対象数[{TOTAL_COUNT}]
        /// </summary>
        public const string I2006="I2006";
        /// <summary>
        /// 処理結果（ファイル新規）：対象数[{TOTAL_COUNT}] 成功[{OK_COUNT}] 失敗[{NG_COUNT}] 未処理[{UNPROCESSED_COUNT}]
        /// </summary>
        public const string I2007="I2007";
        /// <summary>
        /// 処理結果（ファイル更新）：対象数[{TOTAL_COUNT}] 成功[{OK_COUNT}] 失敗[{NG_COUNT}] 未処理[{UNPROCESSED_COUNT}]
        /// </summary>
        public const string I2008="I2008";
        /// <summary>
        /// 処理結果（ファイル削除）：対象数[{TOTAL_COUNT}] 成功[{OK_COUNT}] 失敗[{NG_COUNT}] 未処理[{UNPROCESSED_COUNT}]
        /// </summary>
        public const string I2009="I2009";
        /// <summary>
        /// 処理結果（フォルダ新規）：対象数[{TOTAL_COUNT}] 成功[{OK_COUNT}] 失敗[{NG_COUNT}] 未処理[{UNPROCESSED_COUNT}]
        /// </summary>
        public const string I2010="I2010";
        /// <summary>
        /// 処理結果（フォルダ更新）：対象数[{TOTAL_COUNT}] 成功[{OK_COUNT}] 失敗[{NG_COUNT}] 未処理[{UNPROCESSED_COUNT}]
        /// </summary>
        public const string I2011="I2011";
        /// <summary>
        /// 処理結果（フォルダ削除）：対象数[{TOTAL_COUNT}] 成功[{OK_COUNT}] 失敗[{NG_COUNT}] 未処理[{UNPROCESSED_COUNT}]
        /// </summary>
        public const string I2012="I2012";
        /// <summary>
        /// アップロード処理中に例外が発生しました。実行中のアップロード処理の完了を待ち受けます・・・
        /// </summary>
        public const string I2013="I2013";
        /// <summary>
        /// アップロード中({PROGRESS}%)-[パス：{PATH}]
        /// </summary>
        public const string I2014="I2014";
        /// <summary>
        /// 一括ダウンロードを開始しました[フォルダID：{FOLDER_ID}]
        /// </summary>
        public const string I3001="I3001";
        /// <summary>
        /// 一括ダウンロードを終了しました[フォルダID：{FOLDER_ID}][ファイル総数：{FILE_COUNT}][成功数：{SUCCESS_COUNT}][失敗数：{FAILURE_COUNT}][総ファイルサイズ：{TOTAL_SIZE}]
        /// </summary>
        public const string I3002="I3002";
        /// <summary>
        /// ファイルのダウンロードに成功しました。[ファイルID：{FILE_ID}][ファイルパス：{FILE_PATH}]
        /// </summary>
        public const string I3003="I3003";
        /// <summary>
        /// 一括ダウンロードを{DOWNLOAD_MODE_NAME}(コード：{DOWNLOAD_MODE_VALUE})で実行します。
        /// </summary>
        public const string I3004="I3004";
        /// <summary>
        /// ダウンロードに失敗した可能性のあるフォルダがあります。エラーリストを確認してください。
        /// </summary>
        public const string I3005="I3005";
        /// <summary>
        /// 不正なリクエストです。リクエスト内容が正しいか確認して下さい。
        /// </summary>
        public const string EB001="EB001";
        /// <summary>
        /// 名前に問題があります。
        /// </summary>
        public const string EB002="EB002";
        /// <summary>
        /// フォルダが空でないため、削除できません。
        /// </summary>
        public const string EB003="EB003";
        /// <summary>
        /// リクエストパラメータに誤りがあります。
        /// </summary>
        public const string EB004="EB004";
        /// <summary>
        /// 名前が長すぎます。
        /// </summary>
        public const string EB005="EB005";
        /// <summary>
        /// 指定されたページは範囲外です。
        /// </summary>
        public const string EB006="EB006";
        /// <summary>
        /// 認証エラーです。
        /// </summary>
        public const string EB007="EB007";
        /// <summary>
        /// アクセスが禁止されています。
        /// </summary>
        public const string EB008="EB008";
        /// <summary>
        /// アカウントで使用できるサイズの上限に達しています。
        /// </summary>
        public const string EB009="EB009";
        /// <summary>
        /// 権限が不足しているため、アクセスを拒否されました。
        /// </summary>
        public const string EB010="EB010";
        /// <summary>
        /// アイテムがロックされているため、アクセスを拒否されました。
        /// </summary>
        public const string EB011="EB011";
        /// <summary>
        /// ファイルサイズが大きすぎます。
        /// </summary>
        public const string EB012="EB012";
        /// <summary>
        /// 管理者に承認されていない場所からBoxにログインしようとしています。
        /// </summary>
        public const string EB013="EB013";
        /// <summary>
        /// 指定されたファイルが見つかりません。
        /// </summary>
        public const string EB014="EB014";
        /// <summary>
        /// アイテムは既に削除されています。
        /// </summary>
        public const string EB015="EB015";
        /// <summary>
        /// URLまたはリクエストが不正です。
        /// </summary>
        public const string EB020="EB020";
        /// <summary>
        /// 同じ名前のファイル・フォルダが存在します。[{ITEM_NAME}]
        /// </summary>
        public const string EB016="EB016";
        /// <summary>
        /// APIリクエスト回数が上限に達しています。
        /// </summary>
        public const string EB017="EB017";
        /// <summary>
        /// Boxに問題があるため処理が出来ません。(500)
        /// </summary>
        public const string EB018="EB018";
        /// <summary>
        /// サーバに接続できません。(502)
        /// </summary>
        public const string EB021="EB021";
        /// <summary>
        /// 利用不可能なリクエストです。(503)
        /// </summary>
        public const string EB019="EB019";
    }
}
