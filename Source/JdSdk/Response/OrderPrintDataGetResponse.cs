#region head comment
/*
Code generate by JdSdkTool.
2013-01-31 10:56:46:225 +08:00
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
    /// 输入单个订单id，得到面单打印单的数据 Response
    /// </summary>
    public class OrderPrintDataGetResponse : JdResponse
    {
        /// <summary>
        /// 面单打印数据
        /// </summary>
        [XmlElement("order_printdata")]
        [JsonProperty("order_printdata")]
        public OrderPrintData OrderPrintdata
        {
            get;
            set;
        }

    }
}
