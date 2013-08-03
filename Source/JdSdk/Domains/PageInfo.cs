#region head comment
/*
Code generate by JdSdkTool.
2013-08-02 16:22:56.15479 +08:00
*/
#endregion

using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace JdSdk.Domain
{
    /// <summary>
    /// PageInfo 属性
    /// </summary>
    [Serializable]
    public class PageInfo : JdObject
    {
        /// <summary>
        /// 当前页
        /// </summary>
        [XmlElement("page_index")]
        [JsonProperty("page_index")]
        public Nullable<Decimal> PageIndex
        {
            get;
            set;
        }

        /// <summary>
        /// 总页数
        /// </summary>
        [XmlElement("page_total")]
        [JsonProperty("page_total")]
        public Nullable<Decimal> PageTotal
        {
            get;
            set;
        }

        /// <summary>
        /// 每页记录数
        /// </summary>
        [XmlElement("page_size")]
        [JsonProperty("page_size")]
        public Nullable<Decimal> PageSize
        {
            get;
            set;
        }

        /// <summary>
        /// 数据集合
        /// </summary>
        [XmlElement("data")]
        [JsonProperty("data")]
        public IncomeExpenseVO[] Data
        {
            get;
            set;
        }

    }
}
