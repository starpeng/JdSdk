#region head comment
/*
Code generate by JdSdkTool.
Copyright © starpeng@vip.qq.com
2013-07-29 22:39:05.41822 +08:00
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
    /// 搜索相关的店铺推广数据 Request
    /// </summary>
    public class JingdongUnionPromotionshopQueryRequest : JdRequestBase<JingdongUnionPromotionshopQueryResponse>
    {
        /// <summary>
        /// 店铺主题关键字,如果shop_categoryId和shop_keywords都不填或者输入的查询条件没有相匹配的结果则返回默认的推广数据
        /// </summary>
        /// <example>田云素衣</example>
        [XmlElement("keywords")]
        [JsonProperty("keywords")]
        public String Keywords
        {
            get;
            set;
        }

        /// <summary>
        /// 一级类目ID,如果shop_categoryId和shop_keywords都不填或者输入的查询条件没有相匹配的结果则返回默认的推广数据
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
        /// <example>commisionRatio/goodsVolume/promotionQuantity/praiseDegree</example>
        [XmlElement("property")]
        [JsonProperty("property")]
        public String Property
        {
            get;
            set;
        }

        /// <summary>
        /// 升序或降息排列,默认值DESC
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
        /// 每页显示的结果数,上限为20
        /// </summary>
        [XmlElement("pageSize")]
        [JsonProperty("pageSize")]
        public Int64 PageSize
        {
            get;
            set;
        }

        /// <summary>
        /// 返回的字段列表
        /// </summary>
        /// <example>shop_commRatio,shop_materialUrl,shop_goodsVolume,shop_praiseDegree,shop_promQuantity,shop_mainCategories,shop_pk,shop_promotionUrl,shop_name,totalCount</example>
        [XmlElement("fields")]
        [JsonProperty("fields")]
        public Nullable<Decimal> Fields
        {
            get;
            set;
        }

        public override String ApiName
        {
            get { return "jingdong.union.promotionshop.query"; }
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
