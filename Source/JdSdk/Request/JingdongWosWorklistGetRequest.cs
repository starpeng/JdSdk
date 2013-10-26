#region head comment
/*
Code generate by JdSdkTool.
Copyright © starpeng@vip.qq.com
2013-10-26 10:25:50.54045 +08:00
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
    ///  Request
    /// </summary>
    public class JingdongWosWorklistGetRequest : JdRequestBase<JingdongWosWorklistGetResponse>
    {
        /// <summary>
        /// 工单状态(1代表待回复,2代表待确认,3代表已作废,4代表已关闭,5代表已驳回)
        /// </summary>
        [XmlElement("status")]
        [JsonProperty("status")]
        public Int64 Status
        {
            get;
            set;
        }

        /// <summary>
        /// 订单号
        /// </summary>
        [XmlElement("order_id")]
        [JsonProperty("order_id")]
        public Int64 OrderId
        {
            get;
            set;
        }

        /// <summary>
        /// 查询开始时间(不能早于60天)
        /// </summary>
        [XmlElement("begin_date")]
        [JsonProperty("begin_date")]
        public DateTime BeginDate
        {
            get;
            set;
        }

        /// <summary>
        /// 查询结束时间(不能早于60天)
        /// </summary>
        [XmlElement("end_date")]
        [JsonProperty("end_date")]
        public DateTime EndDate
        {
            get;
            set;
        }

        /// <summary>
        /// 分页页码
        /// </summary>
        [XmlElement("page_number")]
        [JsonProperty("page_number")]
        public Int64 PageNumber
        {
            get;
            set;
        }

        /// <summary>
        /// 每页显示条数(范围为10-30条)
        /// </summary>
        [XmlElement("page_size")]
        [JsonProperty("page_size")]
        public Int64 PageSize
        {
            get;
            set;
        }

        public override String ApiName
        {
            get{ return "jingdong.wos.worklist.get"; }
        }

        protected override void PrepareParam(IDictionary<String, Object> paramters)
        {
            paramters.Add("status" ,this.Status);
            paramters.Add("order_id" ,this.OrderId);
            paramters.Add("begin_date" ,this.BeginDate);
            paramters.Add("end_date" ,this.EndDate);
            paramters.Add("page_number" ,this.PageNumber);
            paramters.Add("page_size" ,this.PageSize);
        }

        public override void Validate()
        {
            RequestValidator.ValidateRequired("begin_date", this.BeginDate);
            RequestValidator.ValidateRequired("end_date", this.EndDate);
            RequestValidator.ValidateRequired("page_number", this.PageNumber);
            RequestValidator.ValidateRequired("page_size", this.PageSize);
        }

    }
}
