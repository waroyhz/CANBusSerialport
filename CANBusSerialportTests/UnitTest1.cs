using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Diagnostics;
using CANBusSerialport;
using System.Windows.Forms;
using System.Reflection;

namespace CANBusSerialportTests
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            var f = new FormMain();
            f.Show();
            
            var data= "8F 7D 7D 01 00 8A 01 22 03 00 00 08 BA 0C 47 7D E8 FE 00 F3 8D 8F 82 7D 01 00 8A 01 1F 01 00 00 05 B9 01 00 07 D9 00 FF 03 8D 8F 88 7D 01 00 8A 01 13 01 00 00 08 FF FF 79 00 F8 C8 AF 19 8D 8F 8D 7D 01 00 8A 01 1F 01 00 00 05 B9 01 00 07 EA FF FF C2 8D 8F 92 7D 01 00 8A 01 12 02 00 00 08 40 03 E1 06 00 00 03 D2 8D 8F 98 7D 01 00 8A 01 D0 01 00 00 08 EE EE EE 80 00 00 00 00 8D 8F 9D 7D 01 00 8A 01 10 04 00 00 08 00 3C 00 00 00 00 00 00 8D 8F A3 7D 01 00 8A 01 1F 01 00 00 05 B9 01 00 07 8C 00 FF 03 8D 8F A8 7D 01 00 8A 01 0E 01 00 00 08 15 10 C8 10 10 15 00 1E 8D 8F AD 7D 01 00 8A 01 22 03 00 00 08 BA 0C 47 7D E8 FE 00 F3 8D 8F B3 7D 01 00 8A 01 0D 02 00 00 08 C0 0B 24 00 00 00 FF 03 8D 8F B8 7D 01 00 8A 01 22 03 00 00 08 BA 0C 47 7D E8 FE 00 F3 8D";
            var datas= data.Split(' ');
            byte[] bytes = new byte[datas.Length];
            for (int i = 0; i < datas.Length; i++)
            {
                bytes[i] = (byte)int.Parse(datas[i], System.Globalization.NumberStyles.HexNumber);
            }


            f.button_addMonitor_Click(null, null);
            var obj = f.linePanel.Controls[0];
            Debug.Assert(obj.GetType() == typeof(UserControl.LineControl));
            var line = (UserControl.LineControl)obj;

            BindingFlags flag = BindingFlags.Instance | BindingFlags.NonPublic;
            var field_textBox_dataID = line.GetType().GetField("textBox_dataID", flag);
            var method = line.GetType().GetMethod("textBox_dataID_KeyUp",flag);
            var field_label_data = line.GetType().GetField("label_data", flag);
            TextBox textbox = (TextBox)field_textBox_dataID.GetValue(line);
            Label label = (Label)field_label_data.GetValue(line);

            var p = f.dataAnalyse.Received(bytes);

            do
            {
                textbox.Text = p.dataID.Replace(" ", "");
                method.Invoke(line, new object[] { null, new KeyEventArgs(Keys.Enter) });
                line.received(p);
                Console.WriteLine(label.Text);

            } while ((p = f.dataAnalyse.Received(null)) != null);




        }
    }
}
