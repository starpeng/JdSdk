#region head comment
/*
Code generate by JdSdkTool.
2013-01-31 10:56:39:641 +08:00
*/
#endregion

using System.Xml.Serialization;
using JdSdk.Domain;
using Newtonsoft.Json;

namespace JdSdk.Response
{
    /// <summary>
    /// 输入单个订单id，得到面单打印单的数据 Response
    /// </summary>
    public class OrderSoplPrintDataGetResponse : JdResponse
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
