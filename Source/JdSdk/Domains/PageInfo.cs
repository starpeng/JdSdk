#region head comment
/*
Code generate by JdSdkTool.
Copyright © starpeng@vip.qq.com
2013-10-26 10:25:50.76046 +08:00
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
        public Int64 PageIndex
        {
            get;
            set;
        }

        /// <summary>
        /// 总页数
        /// </summary>
        [XmlElement("page_total")]
        [JsonProperty("page_total")]
        public Int64 PageTotal
        {
            get;
            set;
        }

        /// <summary>
        /// 每页记录数
        /// </summary>
        [XmlElement("page_size")]
        [JsonProperty("page_size")]
        public Int64 PageSize
        {
            get;
            set;
        }

        /// <summary>
        /// 数据集合
        /// </summary>
        [XmlElement("data")]
        [JsonProperty("data")]
        public List<IncomeExpenseVO> Data
        {
            get;
            set;
        }

    }
}
