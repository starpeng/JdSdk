#region head comment
/*
Code generate by JdSdkTool.
2013-08-02 16:22:56.17079 +08:00
*/
#endregion

using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace JdSdk.Domain
{
    /// <summary>
    /// RankReturnJO属性
    /// </summary>
    [Serializable]
    public class RankReturnJO : JdObject
    {
        /// <summary>
        /// 
        /// </summary>
        /// <example>否</example>
        [XmlElement("response")]
        [JsonProperty("response")]
        public Nullable<Decimal> Response
        {
            get;
            set;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <example>否</example>
        [XmlElement("rank")]
        [JsonProperty("rank")]
        public List<Decimal> Rank
        {
            get;
            set;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <example>否</example>
        [XmlElement("description")]
        [JsonProperty("description")]
        public String Description
        {
            get;
            set;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <example>否</example>
        [XmlElement("plan_date")]
        [JsonProperty("plan_date")]
        public String PlanDate
        {
            get;
            set;
        }

    }
}
