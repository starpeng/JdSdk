#region head comment
/*
Code generate by JdSdkTool.
Copyright © starpeng@vip.qq.com
2013-07-29 22:39:05.21621 +08:00
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
    /// 查询站长的推广效果数据 Request
    /// </summary>
    public class JingdongUnionPromotionreportQueryRequest : JdRequestBase<JingdongUnionPromotionreportQueryResponse>
    {
        /// <summary>
        /// 起始时间,日期格式:yyyy-MM-ddHH:mm:ss
        /// </summary>
        /// <example>2013-05-0900:00:00</example>
        [XmlElement("startDate")]
        [JsonProperty("startDate")]
        public DateTime StartDate
        {
            get;
            set;
        }

        /// <summary>
        /// 结束时间,日期格式:yyyy-MM-ddHH:mm:ss
        /// </summary>
        /// <example>2013-05-3000:00:00</example>
        [XmlElement("endDate")]
        [JsonProperty("endDate")]
        public DateTime EndDate
        {
            get;
            set;
        }

        /// <summary>
        /// 页码
        /// </summary>
        /// <example>1</example>
        [XmlElement("pageIndex")]
        [JsonProperty("pageIndex")]
        public Int64 PageIndex
        {
            get;
            set;
        }

        /// <summary>
        /// 每页显示条数,上限为20
        /// </summary>
        /// <example>20</example>
        [XmlElement("pageSize")]
        [JsonProperty("pageSize")]
        public Int64 PageSize
        {
            get;
            set;
        }

        /// <summary>
        /// 需要返回返回的字段列表
        /// </summary>
        /// <example>report_skuId,report_itemNum,report_shopName,report_itemPrice,report_commRatio,report_sourceType,report_orderNo,report_unionId,report_commision,report_itemName,report_orderStatus,totalCount</example>
        [XmlElement("fields")]
        [JsonProperty("fields")]
        public Nullable<Decimal> Fields
        {
            get;
            set;
        }

        public override String ApiName
        {
            get { return "jingdong.union.promotionreport.query"; }
        }

        protected override void PrepareParam(IDictionary<String, Object> paramters)
        {

            paramters.Add("startdate", this.StartDate);
            paramters.Add("enddate", this.EndDate);
            paramters.Add("pageindex", this.PageIndex);
            paramters.Add("pagesize", this.PageSize);
            paramters.Add("fields", this.Fields);

        }

        public override void Validate()
        {
            RequestValidator.ValidateRequired("startDate", this.StartDate);
            RequestValidator.ValidateRequired("endDate", this.EndDate);
            RequestValidator.ValidateRequired("pageIndex", this.PageIndex);
            RequestValidator.ValidateRequired("pageSize", this.PageSize);
        }

    }
}
