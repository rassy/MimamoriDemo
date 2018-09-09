namespace jp.co.brycen.MimamoriDemo
{
    partial class MainForm
    {
        /// <summary>
        /// 必要なデザイナー変数です。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 使用中のリソースをすべてクリーンアップします。
        /// </summary>
        /// <param name="disposing">マネージ リソースを破棄する場合は true を指定し、その他の場合は false を指定します。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows フォーム デザイナーで生成されたコード

        /// <summary>
        /// デザイナー サポートに必要なメソッドです。このメソッドの内容を
        /// コード エディターで変更しないでください。
        /// </summary>
        private void InitializeComponent()
        {
            this.graphControl1 = new jp.co.brycen.MimamoriDemo.GraphControl();
            this.ucDynamicFlow1 = new jp.co.brycen.MimamoriDemo.UcDynamicFlow();
            this.SuspendLayout();
            // 
            // graphControl1
            // 
            this.graphControl1.Location = new System.Drawing.Point(941, 18);
            this.graphControl1.Name = "graphControl1";
            this.graphControl1.Size = new System.Drawing.Size(900, 1017);
            this.graphControl1.TabIndex = 0;
            // 
            // ucDynamicFlow1
            // 
            this.ucDynamicFlow1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.ucDynamicFlow1.Location = new System.Drawing.Point(83, 18);
            this.ucDynamicFlow1.Name = "ucDynamicFlow1";
            this.ucDynamicFlow1.Size = new System.Drawing.Size(770, 950);
            this.ucDynamicFlow1.TabIndex = 1;
            // 
            // MainForm
            // 
            this.ClientSize = new System.Drawing.Size(1904, 1041);
            this.Controls.Add(this.ucDynamicFlow1);
            this.Controls.Add(this.graphControl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "MainForm";
            this.ResumeLayout(false);

        }

        #endregion

        private GraphControl graphControl1;
        private UcDynamicFlow ucDynamicFlow1;
    }
}

