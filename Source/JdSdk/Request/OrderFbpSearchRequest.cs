#region head comment
/*
Code generate by JdSdkTool.
Copyright © starpeng@vip.qq.com
2013-10-26 10:25:32.11640 +08:00
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
    /// Fbp类型商家根据条件检索订单信息 Request
    /// </summary>
    public class OrderFbpSearchRequest : JdRequestBase<OrderFbpSearchResponse>
    {
        /// <summary>
        /// FBP订单查询的开始时间(开始时间和结束时间，不得相差超过1个月。此时间针对订单修改的时间)
        /// </summary>
        /// <example>2010-12-20 17:15:00</example>
        [XmlElement("start_date")]
        [JsonProperty("start_date")]
        public String StartDate
        {
            get;
            set;
        }

        /// <summary>
        /// FBP订单查询的结算时间(开始时间和结束时间，不得相差超过1个月。此时间针对订单修改的时间)
        /// </summary>
        /// <example>2010-12-20 17:15:00</example>
        [XmlElement("end_date")]
        [JsonProperty("end_date")]
        public String EndDate
        {
            get;
            set;
        }

        /// <summary>
        /// 查询的页数，取值范围:大于零的整数;最大值： 99999
        /// </summary>
        /// <example>1</example>
        [XmlElement("page")]
        [JsonProperty("page")]
        public String Page
        {
            get;
            set;
        }

        /// <summary>
        /// 每页的条数（取值范围:大于零的整数，最大page_size 100条）
        /// </summary>
        /// <example>12</example>
        [XmlElement("page_size")]
        [JsonProperty("page_size")]
        public String PageSize
        {
            get;
            set;
        }

        /// <summary>
        /// 商家希望返回的订单的信息字段, 可选值: OrderInfo数据结构中的以下字段:      order_id,vender_id,pay_type等每个字段以逗号分隔
        /// </summary>
        [XmlElement("optional_fields")]
        [JsonProperty("optional_fields")]
        public String OptionalFields
        {
            get;
            set;
        }

        public override String ApiName
        {
            get{ return "360buy.order.fbp.search"; }
        }

        protected override void PrepareParam(IDictionary<String, Object> paramters)
        {
            paramters.Add("start_date" ,this.StartDate);
            paramters.Add("end_date" ,this.EndDate);
            paramters.Add("page" ,this.Page);
            paramters.Add("page_size" ,this.PageSize);
            paramters.Add("optional_fields" ,this.OptionalFields);
        }

        public override void Validate()
        {
            RequestValidator.ValidateRequired("start_date", this.StartDate);
            RequestValidator.ValidateRequired("end_date", this.EndDate);
            RequestValidator.ValidateRequired("page", this.Page);
            RequestValidator.ValidateRequired("page_size", this.PageSize);
        }

    }
}
