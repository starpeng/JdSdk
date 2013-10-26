#region head comment
/*
Code generate by JdSdkTool.
Copyright © starpeng@vip.qq.com
2013-06-03 12:29:14.50695 +08:00
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
    /// 根据商品的一些信息进行搜索。 Request
    /// </summary>
    public class WaresSearchRequest : JdRequestBase<WaresSearchResponse>
    {
        /// <summary>
        /// 类目id
        /// </summary>
        [XmlElement("cid")]
        [JsonProperty("cid")]
        public Nullable<Int64> Cid
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
        public Int64 Page
        {
            get;
            set;
        }

        /// <summary>
        /// 每页多少条
        /// </summary>
        [XmlElement("page_size")]
        [JsonProperty("page_size")]
        public Int64 PageSize
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

        /// <summary>
        /// 商品状态
        /// 1:在售;2:待售
        /// </summary>
        /// <example>1</example>
        [XmlElement("ware_status")]
        [JsonProperty("ware_status")]
        public String WareStatus
        {
            get;
            set;
        }

        /// <summary>
        /// 起始创建时间
        /// </summary>
        [XmlElement("start_modified")]
        [JsonProperty("start_modified")]
        public Nullable<DateTime> StartModified
        {
            get;
            set;
        }

        /// <summary>
        /// 结束创建时间
        /// </summary>
        [XmlElement("end_modified")]
        [JsonProperty("end_modified")]
        public Nullable<DateTime> EndModified
        {
            get;
            set;
        }

        public override String ApiName
        {
            get { return "360buy.wares.search"; }
        }

        protected override void PrepareParam(IDictionary<String, Object> paramters)
        {
            paramters.Add("cid", this.Cid);
            paramters.Add("start_price", this.StartPrice);
            paramters.Add("end_price", this.EndPrice);
            paramters.Add("page", this.Page);
            paramters.Add("page_size", this.PageSize);
            paramters.Add("title", this.Title);
            paramters.Add("order_by", this.OrderBy);
            paramters.Add("start_time", this.StartTime);
            paramters.Add("end_time", this.EndTime);
            paramters.Add("fields", this.Fields);
            paramters.Add("ware_status", this.WareStatus);
            paramters.Add("start_modified", this.StartModified);
            paramters.Add("end_modified", this.EndModified);
        }

        public override void Validate()
        {
            RequestValidator.ValidateRequired("page", this.Page);
            RequestValidator.ValidateRequired("page_size", this.PageSize);
        }
    }
}
