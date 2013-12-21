#region head comment
/*
Code generate by JdSdkTool.
Copyright © starpeng@vip.qq.com
2013-07-29 22:39:04.81219 +08:00
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
    /// 查询相关的商品推广数据 Request
    /// </summary>
    public class JingdongUnionPromotiongoodQueryRequest : JdRequestBase<JingdongUnionPromotiongoodQueryResponse>
    {
        /// <summary>
        /// 商品标题包含关键词,如果good_keywords和good_categoryId不填或者没有相匹配的查询结果,则会返回默认的推广数据
        /// </summary>
        [XmlElement("keywords")]
        [JsonProperty("keywords")]
        public String Keywords
        {
            get;
            set;
        }

        /// <summary>
        /// 商品类目ID,如果good_keywords和good_categoryId不填或者没有相匹配的查询结果,则会返回默认的推广数据
        /// </summary>
        [XmlElement("categoryId")]
        [JsonProperty("categoryId")]
        public Nullable<Int64> CategoryId
        {
            get;
            set;
        }

        /// <summary>
        /// 排序列的属性名,默认值commisionRatio
        /// </summary>
        /// <example>price/commisionRatio/promotionQuantity</example>
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
        /// 结果页数
        /// </summary>
        [XmlElement("pageIndex")]
        [JsonProperty("pageIndex")]
        public Int64 PageIndex
        {
            get;
            set;
        }

        /// <summary>
        /// 每页放回的结果数,每页上限为20
        /// </summary>
        [XmlElement("pageSize")]
        [JsonProperty("pageSize")]
        public Int64 PageSize
        {
            get;
            set;
        }

        /// <summary>
        /// 需要返回的字段列表
        /// </summary>
        /// <example>good_pk,good_skuId,good_shopName,good_name,good_price,good_praiseDegree,good_targetUrl,good_shopUrl,good_materialUrl,good_commRatio,good_commision,good_promQuantity,good_startDate,good_endDate,totalCount</example>
        [XmlElement("fields")]
        [JsonProperty("fields")]
        public String Fields
        {
            get;
            set;
        }

        public override String ApiName
        {
            get { return "jingdong.union.promotiongood.query"; }
        }

        protected override void PrepareParam(IDictionary<String, Object> paramters)
        {

            paramters.Add("keywords", this.Keywords);
            paramters.Add("categoryid", this.CategoryId);
            paramters.Add("property", this.Property);
            paramters.Add("sort", this.Sort);
            paramters.Add("pageindex", this.PageIndex);
            paramters.Add("pagesize", this.PageSize);
            paramters.Add("fields", this.Fields);

        }

        public override void Validate()
        {
            RequestValidator.ValidateRequired("pageIndex", this.PageIndex);
            RequestValidator.ValidateRequired("pageSize", this.PageSize);
        }

    }
}
