using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Collections.ObjectModel;
using System.Threading;
using System.Diagnostics;
using CANBusSerialport;

namespace UserControl
{
    public partial class LineControl : System.Windows.Forms.UserControl
    {
        int dataID = 0;

        public LineControl()
        {
            InitializeComponent();
        }

        private void button_remove_Click(object sender, EventArgs e)
        {
            this.Parent.Controls.Remove(this);
        }

        public void received(Protocol protocol)
        {
            var id = int.Parse(protocol.dataID.Replace(" ", ""), System.Globalization.NumberStyles.HexNumber);
            if (this.dataID == id)
            {
                int tmp = protocol.time;
                int ms = tmp % 1000;
                tmp /= 1000;
                int s = tmp % 60;
                tmp /= 60;
                int m = tmp % 60;
                tmp /= 60;
                int h = tmp % 60;

                string strtime = string.Format("{0}时{1}分{2}秒{3:d4}ms", h, m, s, ms);

                label_data.Text = string.Format("时间：{0}\t类型：{1:x2}\tID：{2:x2}\t长度：{3}\t数据：{4}\t{5}", strtime, protocol.dataType, protocol.dataID, protocol.dataLength, protocol.data, "");
            }
        }

        private void textBox_dataID_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                int newid;
                try
                {
                    newid = int.Parse(textBox_dataID.Text, System.Globalization.NumberStyles.HexNumber);
                    dataID = newid;
                    textBox_dataID.Enabled = false;
                    if (textBox_dataID.Text.Length % 2 == 1)
                    {
                        textBox_dataID.Text = "0x0" + textBox_dataID.Text;
                    }
                    else
                    {
                        textBox_dataID.Text = "0x" + textBox_dataID.Text;
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "输入的数据ID有误");
                }
            }
        }

    }
}
