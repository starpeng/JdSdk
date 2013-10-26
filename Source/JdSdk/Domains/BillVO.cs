#region head comment
/*
Code generate by JdSdkTool.
Copyright © starpeng@vip.qq.com
2013-10-26 10:25:50.76246 +08:00
*/
#endregion

using System;
using System.Xml.Serialization;
using System.Collections.Generic;
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
        public Int64 BillNo
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
