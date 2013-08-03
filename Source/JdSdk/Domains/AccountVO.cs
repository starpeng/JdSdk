#region head comment
/*
Code generate by JdSdkTool.
2013-08-02 16:22:56.15179 +08:00
*/
#endregion

using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace JdSdk.Domain
{
    /// <summary>
    /// AccountVO 属性
    /// </summary>
    [Serializable]
    public class AccountVO : JdObject
    {
        /// <summary>
        /// 总余额
        /// </summary>
        [XmlElement("total_amount")]
        [JsonProperty("total_amount")]
        public String TotalAmount
        {
            get;
            set;
        }

        /// <summary>
        /// 可用余额
        /// </summary>
        [XmlElement("available_amount")]
        [JsonProperty("available_amount")]
        public String AvailableAmount
        {
            get;
            set;
        }

        /// <summary>
        /// 冻结金额
        /// </summary>
        [XmlElement("freeze_amount")]
        [JsonProperty("freeze_amount")]
        public String FreezeAmount
        {
            get;
            set;
        }

    }
}
