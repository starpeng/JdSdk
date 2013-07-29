#region head comment
/*
Code generate by JdSdkTool.
2013-01-31 10:56:47:849 +08:00
*/
#endregion

using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace JdSdk.Domain
{
    /// <summary>
    /// ApiCompanyCustom结构
    /// </summary>
    [Serializable]
    public class ApiCompanyCustom : JdObject
    {
        /// <summary>
        /// 物流公司ID
        /// </summary>
        [XmlElement("logistics_id")]
        [JsonProperty("logistics_id")]
        public Int32 LogisticsId
        {
            get;
            set;
        }

        /// <summary>
        /// 物流公司名称
        /// </summary>
        [XmlElement("logistics_name")]
        [JsonProperty("logistics_name")]
        public String LogisticsName
        {
            get;
            set;
        }

        /// <summary>
        /// 备注说明
        /// </summary>
        [XmlElement("logistics_remark")]
        [JsonProperty("logistics_remark")]
        public String LogisticsRemark
        {
            get;
            set;
        }

        /// <summary>
        /// 序列
        /// </summary>
        [XmlElement("sequence")]
        [JsonProperty("sequence")]
        public Int32 Sequence
        {
            get;
            set;
        }

    }
}
