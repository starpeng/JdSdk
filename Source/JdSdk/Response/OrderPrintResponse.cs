#region head comment
/*
Code generate by JdSdkTool.
2013-01-31 10:56:47:642 +08:00
*/
#endregion

using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using Newtonsoft.Json;
using JdSdk.Domain;

namespace JdSdk.Response
{
    /// <summary>
    /// 输入单个订单id，得到面单打印内容 Response
    /// </summary>
    public class OrderPrintResponse : JdResponse
    {
        /// <summary>
        /// 订单数据
        /// </summary>
        [XmlElement("print_result")]
        [JsonProperty("print_result")]
        public PrintResult PrintResult
        {
            get;
            set;
        }

    }
}
