#region head comment
/*
Code generate by JdSdkTool.
2013-01-31 10:56:41:971 +08:00
*/
#endregion

using System.Xml.Serialization;
using JdSdk.Domain;
using Newtonsoft.Json;

namespace JdSdk.Response
{
    /// <summary>
    /// 检索商家物流公司信息 Response
    /// </summary>
    public class DeliveryLogisticsGetResponse : JdResponse
    {
        /// <summary>
        /// 物流公司信息
        /// </summary>
        [XmlElement("logistics_companies")]
        [JsonProperty("logistics_companies")]
        public LogisticsCompany LogisticsCompanies
        {
            get;
            set;
        }

    }
}
