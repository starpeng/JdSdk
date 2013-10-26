#region head comment
/*
Code generate by JdSdkTool.
Copyright © starpeng@vip.qq.com
2013-07-29 22:39:06.02426 +08:00
*/
#endregion

using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using JdSdk.Response;
using Newtonsoft.Json;

namespace JdSdk.Request
{
    /// <summary>
    /// 获取专柜推广报表详细信息 Request
    /// </summary>
    public class JingdongUnionReportWindowSearchRequest : JdRequestBase<JingdongUnionReportWindowSearchResponse>
    {
        /// <summary>
        /// 页码
        /// </summary>
        [XmlElement("page_index")]
        [JsonProperty("page_index")]
        public Int64 PageIndex
        {
            get;
            set;
        }

        /// <summary>
        /// 每页显示的记录数
        /// </summary>
        [XmlElement("page_size")]
        [JsonProperty("page_size")]
        public Int64 PageSize
        {
            get;
            set;
        }

        /// <summary>
        /// 开始时间,格式:yyyy-MM-dd HH:mm:ss
        /// </summary>
        /// <example>2013-07-03 00:00:00</example>
        [XmlElement("start_date")]
        [JsonProperty("start_date")]
        public DateTime StartDate
        {
            get;
            set;
        }

        /// <summary>
        /// 结束时间,格式:yyyy-MM-dd HH:mm:ss
        /// </summary>
        /// <example>2013-07-03 00:00:00</example>
        [XmlElement("end_date")]
        [JsonProperty("end_date")]
        public DateTime EndDate
        {
            get;
            set;
        }

        public override String ApiName
        {
            get { return "jingdong.union.report.window.search"; }
        }

        protected override void PrepareParam(IDictionary<String, Object> paramters)
        {

            paramters.Add("page_index", this.PageIndex);
            paramters.Add("page_size", this.PageSize);
            paramters.Add("start_date", this.StartDate);
            paramters.Add("end_date", this.EndDate);

        }

        public override void Validate()
        {
            RequestValidator.ValidateRequired("page_index", this.PageIndex);
            RequestValidator.ValidateRequired("page_size", this.PageSize);
            RequestValidator.ValidateRequired("start_date", this.StartDate);
            RequestValidator.ValidateRequired("end_date", this.EndDate);
        }

    }
}
