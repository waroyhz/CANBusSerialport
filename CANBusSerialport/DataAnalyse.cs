using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading;

namespace CANBusSerialport
{
    public class DataAnalyse
    {

        //0  1  2  3  4  5  6  7  8  9  10 11 12 13 14 15 16 17 18 19 20
        //8F 25 C2 09 00 8A 01 0D 05 00 00 08 00 00 00 00 10 00 00 00 8D
        //8F 开始符  
        //25 C2 09 00 时间毫秒
        //8A 分隔符  
        //01 数据类型 
        //0D 05 00 00 数据ID 
        //08 数据长度
        //00 00 00 00 10 00 00 00 数据 
        //8D 结束符


        List<byte> buffer = new List<byte>();
        int bufferPos = 0;

        public Protocol Received(byte[] buf)
        {
            Protocol protocol = null;
            if (buf != null)
            {
                buffer.AddRange(buf);
            }

            parseReset();

            while (buffer.Count > 0 && buffer[0] != 0x8f)
            {
                buffer.RemoveAt(0);
            }

            if (buffer.Count >= 21)
            {
                if (buffer[5] != 0x8a || buffer[20] != 0x8d)
                {                        //如果结束符不对
                    buffer.RemoveAt(0);
                    Received(null);
                }
                else
                {                        //处理时间
                    protocol = new Protocol();
                    protocol.hand = parseInt8();
                    protocol.time = parseInt32();
                    protocol.split = parseInt8();
                    protocol.dataType = parseInt8();
                    protocol.dataID = parseHexStrings(4);
                    protocol.dataLength = parseInt8();
                    protocol.data = parseHexStrings(8); //protocol.dataLength
                    protocol.end = parseInt8();

                    Debug.Assert(protocol.end == 0x8d);


                }
            }
            return protocol;
        }

        private void parseReset()
        {
            if (bufferPos > 0)
            {
                buffer.RemoveRange(0, bufferPos);
            }
            bufferPos = 0;
        }

        private byte[] parseBytes(int dataLength)
        {
            var ret = new byte[dataLength];
            buffer.CopyTo(bufferPos, ret, 0, dataLength);
            bufferPos += dataLength;
            return ret;
        }

        private string parseHexStrings(int dataLength)
        {
            var ret = new StringBuilder();
            for (int i = dataLength -1; i >=0 ; i--)
                ret.AppendFormat("{0:x2} ", buffer[i + bufferPos]);
            bufferPos += dataLength;
            return ret.ToString();
        }

        private int parseInt8()
        {
            return parseIntValue(1);
        }

        private int parseInt32()
        {
            return parseIntValue(4);
        }

        private int parseIntValue(int count)
        {
            int ret = 0, v = 0;
            for (int i = 0; i < count; i++)
            {
                v = buffer[i + bufferPos];
                ret = (v << (i* 8))+ ret;
            }

            bufferPos += count;
            return ret;
        }
    }
}
