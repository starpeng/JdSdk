#region head comment
/*
Code generate by JdSdkTool.
2013-06-03 12:29:14.50695 +08:00
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
    /// 根据商品的一些信息进行搜索。 Request
    /// </summary>
    public class WaresSearchRequest : IJdRequest<WaresSearchResponse>
    {
        /// <summary>
        /// 类目id
        /// </summary>
        [XmlElement("cid")]
        [JsonProperty("cid")]
        public Nullable<Decimal> Cid
        {
            get;
            set;
        }

        /// <summary>
        /// 最小价格（分）
        /// </summary>
        [XmlElement("start_price")]
        [JsonProperty("start_price")]
        public Nullable<Decimal> StartPrice
        {
            get;
            set;
        }

        /// <summary>
        /// 最大价格（分
        /// </summary>
        [XmlElement("end_price")]
        [JsonProperty("end_price")]
        public Nullable<Decimal> EndPrice
        {
            get;
            set;
        }

        /// <summary>
        /// 分页
        /// </summary>
        [XmlElement("page")]
        [JsonProperty("page")]
        public Decimal Page
        {
            get;
            set;
        }

        /// <summary>
        /// 每页多少条
        /// </summary>
        [XmlElement("page_size")]
        [JsonProperty("page_size")]
        public Decimal PageSize
        {
            get;
            set;
        }

        /// <summary>
        /// 商品名称
        /// </summary>
        [XmlElement("title")]
        [JsonProperty("title")]
        public String Title
        {
            get;
            set;
        }

        /// <summary>
        /// 排序（默认onlineTime ）(offlineTime,onlineTime)
        /// </summary>
        [XmlElement("order_by")]
        [JsonProperty("order_by")]
        public String OrderBy
        {
            get;
            set;
        }


        /// <summary>
        /// 起始创建时间
        /// </summary>
        [XmlElement("start_time")]
        [JsonProperty("start_time")]
        public Nullable<DateTime> StartTime
        {
            get;
            set;
        }

        /// <summary>
        /// 结束创建时间
        /// </summary>
        [XmlElement("end_time")]
        [JsonProperty("end_time")]
        public Nullable<DateTime> EndTime
        {
            get;
            set;
        }

        /// <summary>
        /// 需返回的字段列表。可选值：ware结构体中的所有字段；字段之间用","分隔
        /// </summary>
        /// <example>ware_id,spu_idcid,created</example>
        [XmlElement("fields")]
        [JsonProperty("fields")]
        public String Fields
        {
            get;
            set;
        }

        public String ApiName
        {
            get{ return "360buy.wares.search"; }
        }

        public String GetParamJson()
        {
            Dictionary<String, Object> paramters = new Dictionary<string, object>();
            paramters.Add("cid" ,this.Cid);
            paramters.Add("start_price" ,this.StartPrice);
            paramters.Add("end_price" ,this.EndPrice);
            paramters.Add("page" ,this.Page);
            paramters.Add("page_size" ,this.PageSize);
            paramters.Add("title" ,this.Title);
            paramters.Add("order_by" ,this.OrderBy);
            paramters.Add("start_time", this.StartTime);
            paramters.Add("end_time", this.EndTime);
            paramters.Add("fields", this.Fields);
            return JsonConvert.SerializeObject(paramters, JdUtils.GetJsonConverters());
        }

        public void Validate()
        {
            RequestValidator.ValidateRequired("page", this.Page);
            RequestValidator.ValidateRequired("page_size", this.PageSize);
        }

    }
}
