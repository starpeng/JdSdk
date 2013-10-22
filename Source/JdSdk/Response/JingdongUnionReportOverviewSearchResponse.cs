#region head comment
/*
Code generate by JdSdkTool.
2013-07-29 22:39:05.82324 +08:00
*/
#endregion

using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using JdSdk.Domain;
using Newtonsoft.Json;

namespace JdSdk.Response
{
    /// <summary>
    /// 查询站长的推广效果概况 Response
    /// </summary>
    public class JingdongUnionReportOverviewSearchResponse : JdResponse
    {
        /// <summary>
        /// 效果概况数据
        /// </summary>
        [XmlElement("data")]
        [JsonProperty("data")]
        public List<OverviewVo> Data
        {
            get;
            set;
        }

        /// <summary>
        /// 页码
        /// </summary>
        [XmlElement("page_index")]
        [JsonProperty("page_index")]
        public Nullable<Int64> PageIndex
        {
            get;
            set;
        }

        /// <summary>
        /// 每页记录数
        /// </summary>
        [XmlElement("page_size")]
        [JsonProperty("page_size")]
        public Nullable<Int64> PageSize
        {
            get;
            set;
        }

        /// <summary>
        /// 总页数
        /// </summary>
        [XmlElement("page_total")]
        [JsonProperty("page_total")]
        public Nullable<Int64> PageTotal
        {
            get;
            set;
        }

        /// <summary>
        /// 查询开始时间，格式：yyyy-MM-dd    HH:mm:ss
        /// </summary>
        /// <example>2013-07-03 00:00:00</example>
        [XmlElement("start_date")]
        [JsonProperty("start_date")]
        public Nullable<DateTime> StartDate
        {
            get;
            set;
        }

        /// <summary>
        /// 查询结束时间，格式：yyyy-MM-dd    HH:mm:ss
        /// </summary>
        /// <example>2013-07-03 00:00:00</example>
        [XmlElement("end_date")]
        [JsonProperty("end_date")]
        public Nullable<DateTime> EndDate
        {
            get;
            set;
        }

    }
}
