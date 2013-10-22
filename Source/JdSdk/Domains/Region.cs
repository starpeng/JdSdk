#region head comment
/*
Code generate by JdSdkTool.
2013-04-03 12:45:25.18178 +08:00
*/
#endregion

using System;
using System.Xml.Serialization;
using Newtonsoft.Json;

namespace JdSdk.Domain
{
    /// <summary>
    /// Region结构
    /// </summary>
    [Serializable]
    public class Region : JdObject
    {
        /// <summary>
        /// 地区ID
        /// </summary>
        /// <example>1</example>
        [XmlElement("region_id")]
        [JsonProperty("region_id")]
        public Nullable<Int64> RegionId
        {
            get;
            set;
        }

        /// <summary>
        /// 地区名称
        /// </summary>
        /// <example>北京</example>
        [XmlElement("region_name")]
        [JsonProperty("region_name")]
        public String RegionName
        {
            get;
            set;
        }

    }
}
