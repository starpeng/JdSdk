#region head comment
/*
Code generate by JdSdkTool.
2013-08-02 16:22:56.16779 +08:00
*/
#endregion

using System;
using System.Xml.Serialization;
using Newtonsoft.Json;

namespace JdSdk.Domain
{
    /// <summary>
    /// BillVO属性
    /// </summary>
    [Serializable]
    public class BillVO : JdObject
    {
        /// <summary>
        /// 结算单号
        /// </summary>
        [XmlElement("bill_no")]
        [JsonProperty("bill_no")]
        public Nullable<Int64> BillNo
        {
            get;
            set;
        }

        /// <summary>
        /// 结算月份
        /// </summary>
        [XmlElement("bill_month")]
        [JsonProperty("bill_month")]
        public String BillMonth
        {
            get;
            set;
        }

        /// <summary>
        /// 总金额
        /// </summary>
        [XmlElement("cost")]
        [JsonProperty("cost")]
        public String Cost
        {
            get;
            set;
        }

    }
}
