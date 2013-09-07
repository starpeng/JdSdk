#region head comment
/*
Code generate by JdSdkTool.
2013-07-29 22:39:04.61018 +08:00
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
    /// 查询相关的活动推广数据 Request
    /// </summary>
    public class JingdongUnionPromotionactivityQueryRequest : IJdRequest<JingdongUnionPromotionactivityQueryResponse>
    {
        /// <summary>
        /// 活动名称关键字,如果activity_keywords和activity_categoryId为空或者是没有找到相匹配的结果，则返回默认的广数据
        /// </summary>
        [XmlElement("keywords")]
        [JsonProperty("keywords")]
        public String Keywords
        {
            get;
            set;
        }

        /// <summary>
        /// 活动所属类目ID,如果activity_keywords和activity_categoryId为空或者是没有找到相匹配的结果，则返回默认的推广数据
        /// </summary>
        [XmlElement("categoryId")]
        [JsonProperty("categoryId")]
        public Nullable<Int64> CategoryId
        {
            get;
            set;
        }

        /// <summary>
        /// 排序列的属性名，默认值commisionRatio
        /// </summary>
        /// <example>commisionRatio</example>
        [XmlElement("property")]
        [JsonProperty("property")]
        public String Property
        {
            get;
            set;
        }

        /// <summary>
        /// 升序或降序排列,默认值DESC
        /// </summary>
        /// <example>DESC/ASC</example>
        [XmlElement("sort")]
        [JsonProperty("sort")]
        public String Sort
        {
            get;
            set;
        }

        /// <summary>
        /// 页码，当输入页码小于1时候默认pageIndex为1
        /// </summary>
        [XmlElement("pageIndex")]
        [JsonProperty("pageIndex")]
        public Int64 PageIndex
        {
            get;
            set;
        }

        /// <summary>
        /// 每页条数，当输入条数小于1时候默认pageSize为10
        /// </summary>
        [XmlElement("pageSize")]
        [JsonProperty("pageSize")]
        public Int64 PageSize
        {
            get;
            set;
        }

        /// <summary>
        /// 需要返回的字段
        /// </summary>
        /// <example>activity_pk,activity_name,activity_url,activity_width,activity_height,activity_start,activity_end,activity_shopName,activity_mainCategory,activity_commRatio,totalCount</example>
        [XmlElement("fields")]
        [JsonProperty("fields")]
        public Nullable<Decimal> Fields
        {
            get;
            set;
        }

        public String ApiName
        {
            get{ return "jingdong.union.promotionactivity.query"; }
        }

        public String GetParamJson()
        {
            Dictionary<String, Object> paramters = new Dictionary<string, object>();
            paramters.Add("keywords" ,this.Keywords);
            paramters.Add("categoryid" ,this.CategoryId);
            paramters.Add("property" ,this.Property);
            paramters.Add("sort" ,this.Sort);
            paramters.Add("pageindex" ,this.PageIndex);
            paramters.Add("pagesize" ,this.PageSize);
            paramters.Add("fields" ,this.Fields);
            return JsonConvert.SerializeObject(paramters, JdUtils.GetJsonConverters());
        }

        public void Validate()
        {
            RequestValidator.ValidateRequired("pageIndex", this.PageIndex);
            RequestValidator.ValidateRequired("pageSize", this.PageSize);
        }

    }
}
