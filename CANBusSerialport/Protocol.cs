using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CANBusSerialport
{
    public class Protocol
    {
        /// <summary>
        /// 开始符  
        /// </summary>
        public int hand;
        /// <summary>
        /// 时间毫秒
        /// </summary>
        public int time;
        /// <summary>
        /// 分隔符
        /// </summary>
        public int split;
        /// <summary>
        /// 数据类型
        /// </summary>
        public int dataType;
        /// <summary>
        /// 数据ID
        /// </summary>
        public string dataID;
        /// <summary>
        /// 数据长度
        /// </summary>
        public int dataLength;
        /// <summary>
        /// 数据
        /// </summary>
        public string data;
        /// <summary>
        /// 结束符
        /// </summary>
        public int end;
    }
}
