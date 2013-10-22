#region head comment
/*
Code generate by JdSdkTool.
2013-01-31 10:56:47:849 +08:00
*/
#endregion

using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using Newtonsoft.Json;

namespace JdSdk.Domain
{
    /// <summary>
    /// LogisticsCompany结构
    /// </summary>
    [Serializable]
    public class LogisticsCompany : JdObject
    {
        /// <summary>
        /// 物流公司信息
        /// </summary>
        [XmlElement("logistics_list")]
        [JsonProperty("logistics_list")]
        public List<ApiCompanyCustom> LogisticsList
        {
            get;
            set;
        }

        /// <summary>
        /// 商家ID
        /// </summary>
        [XmlElement("vender_id")]
        [JsonProperty("vender_id")]
        public String VenderId
        {
            get;
            set;
        }

    }
}
