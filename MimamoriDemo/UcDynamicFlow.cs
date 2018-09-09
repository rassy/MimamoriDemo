using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace jp.co.brycen.MimamoriDemo
{
    public partial class UcDynamicFlow : UserControl
    {
        /// <summary>
        /// デバイス状態クラスのリスト
        /// </summary>
        private List<ClsDeviceState> m_lstDeviceState = new List<ClsDeviceState>();

        /// <summary>
        /// CSV読み込み行数MAX
        /// </summary>
        private int m_intMaxNum = 0;

        /// <summary>
        /// CSV読み込み行数現在
        /// </summary>
        private int m_intCurNum = 0;

        /// <summary>
        /// NEW
        /// </summary>
        public UcDynamicFlow()
        {
            InitializeComponent();
            
            // CSVファイル読み込み
            this.ReadCSV();

            // タイマーセット（デバイス情報設定）
            Timer timer = new Timer();
            timer.Tick += Timer_Tick;
            timer.Interval = 3000;
            timer.Enabled = true;
        }

        /// <summary>
        /// タイマーイベント
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Timer_Tick(object sender, EventArgs e)
        {
            this.SetStsToUsrIcon();
        }

        /// <summary>
        /// CSVファイル読み込み
        /// </summary>
        private void ReadCSV()
        {
            this.m_lstDeviceState.Clear();

            StreamReader reader = new StreamReader(@"C:\Users\P0828\device_state.csv", Encoding.GetEncoding("Shift_JIS"));

            try
            {
                while (reader.Peek() >= 0)
                {
                    ClsDeviceState objDvcSts = new ClsDeviceState();

                    string[] cols = reader.ReadLine().Split(',');

                    // 変なデータは受け取らない
                    if (String.IsNullOrEmpty(cols[0]) || String.IsNullOrEmpty(cols[0]) || String.IsNullOrEmpty(cols[0]) || String.IsNullOrEmpty(cols[0]))
                    {
                        continue;
                    }

                    // データ格納
                    objDvcSts.DeviceId = cols[0].ToString();
                    objDvcSts.Indicater = Convert.ToInt32(cols[1]);
                    objDvcSts.LocationX = Convert.ToInt32(cols[2]);
                    objDvcSts.LocationY = Convert.ToInt32(cols[3]);

                    this.m_lstDeviceState.Add(objDvcSts);
                }
            }
            catch(Exception ex)
            {
                // CSVファイル読み込めないときはさすがにエラーにする
                throw ex;
            }
            finally
            {
                reader.Close();
                reader.Dispose();
            }
        }

        /// <summary>
        /// デバイス情報設定
        /// </summary>
        private void SetStsToUsrIcon()
        {
            if (this.m_lstDeviceState == null || !(this.m_lstDeviceState.Any()))
            {
                return;
            }

            this.m_intMaxNum = this.m_lstDeviceState.Count - 1;

            // デバイス名と同一のコントロール取得
            ClsDeviceState dvcSts = this.m_lstDeviceState[this.m_intCurNum];
            PictureBox pcbDevice = (PictureBox)this.Controls[dvcSts.DeviceId];

            if (pcbDevice != null)
            {
                // ロケーション画像設定
                pcbDevice.Location = new Point(dvcSts.LocationX, dvcSts.LocationY);
                pcbDevice.Image = dvcSts.IndicaterImage;
            }

            if (this.m_intMaxNum == this.m_intCurNum)
            {
                this.m_intCurNum = 0;
            }
            else
            {
                this.m_intCurNum++;
            }

        }
    }
}
