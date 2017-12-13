﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WizSE.RPC
{
    /// <summary>
    /// (网络传送)信息包接口
    /// </summary>
    [Serializable]
    public class Packet
    {
        /// <summary>
        /// 构造方法
        /// </summary>
        /// <param name="data">网络传输包中的数据</param>
        public Packet(byte[] data)
        {
            Data = data;
            WaiteCallBack = true;
        }

        public Packet()
        {
            WaiteCallBack = true;
        }

        /// <summary>
        /// 信息包中的数据
        /// </summary>
        public byte[] Data { get; set; }

        /// <summary>
        /// 信息包是否需要等待一个回复
        /// </summary>
        public bool WaiteCallBack { get; set; }
    }
}
