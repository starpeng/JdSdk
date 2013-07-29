#region head comment
/*
Code generate by JdSdkTool.
2013-07-29 22:39:06.02426 +08:00
*/
#endregion

using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using JdSdk.Domain;
using JdSdk.Response;

namespace JdSdk.Request
{
    /// <summary>
    /// 获取专柜推广报表详细信息 Request
    /// </summary>
    public class JingdongUnionReportWindowSearchRequest : IJdRequest<JingdongUnionReportWindowSearchResponse>
    {
        /// <summary>
        /// 页码
        /// </summary>
        [XmlElement("page_index")]
        [JsonProperty("page_index")]
        public Decimal PageIndex
        {
            get;
            set;
        }

        /// <summary>
        /// 每页显示的记录数
        /// </summary>
        [XmlElement("page_size")]
        [JsonProperty("page_size")]
        public Decimal PageSize
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

        public String ApiName
        {
            get{ return "jingdong.union.report.window.search"; }
        }

        public String GetParamJson()
        {
            Dictionary<String, Object> paramters = new Dictionary<string, object>();
            paramters.Add("page_index" ,this.PageIndex);
            paramters.Add("page_size" ,this.PageSize);
            paramters.Add("start_date" ,this.StartDate);
            paramters.Add("end_date" ,this.EndDate);
            return JsonConvert.SerializeObject(paramters, JdUtils.GetJsonConverters());
        }

        public void Validate()
        {
            RequestValidator.ValidateRequired("page_index", this.PageIndex);
            RequestValidator.ValidateRequired("page_size", this.PageSize);
            RequestValidator.ValidateRequired("start_date", this.StartDate);
            RequestValidator.ValidateRequired("end_date", this.EndDate);
        }

    }
}
