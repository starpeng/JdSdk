#region head comment
/*
Code generate by JdSdkTool.
Copyright © starpeng@vip.qq.com
2013-07-29 22:39:03.39111 +08:00
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
    /// 查询店铺推广详情 Request
    /// </summary>
    public class JingdongUnionAdvdetailGetRequest : JdRequestBase<JingdongUnionAdvdetailGetResponse>
    {
        /// <summary>
        /// 计划id
        /// </summary>
        [XmlElement("plan_id")]
        [JsonProperty("plan_id")]
        public Int64 PlanId
        {
            get;
            set;
        }

        /// <summary>
        /// 商品列表每页显示条数
        /// </summary>
        [XmlElement("goods_page_size")]
        [JsonProperty("goods_page_size")]
        public Nullable<Int64> GoodsPageSize
        {
            get;
            set;
        }

        /// <summary>
        /// 商品列表第几页
        /// </summary>
        [XmlElement("goods_page_index")]
        [JsonProperty("goods_page_index")]
        public Nullable<Int64> GoodsPageIndex
        {
            get;
            set;
        }

        /// <summary>
        /// 商品列表排序列
        /// </summary>
        /// <example>price/commisionRatio/commision/promotionQuantity/praiseDegree/startDate</example>
        [XmlElement("goods_sort_column")]
        [JsonProperty("goods_sort_column")]
        public String GoodsSortColumn
        {
            get;
            set;
        }

        /// <summary>
        /// 商品列表排序方式：DESC/ASC
        /// </summary>
        /// <example>DESC/ASC</example>
        [XmlElement("goods_sort")]
        [JsonProperty("goods_sort")]
        public String GoodsSort
        {
            get;
            set;
        }

        /// <summary>
        /// 活动列表每页显示条数
        /// </summary>
        [XmlElement("activity_page_size")]
        [JsonProperty("activity_page_size")]
        public Nullable<Int64> ActivityPageSize
        {
            get;
            set;
        }

        /// <summary>
        /// 活动列表显示第几页
        /// </summary>
        [XmlElement("activity_page_index")]
        [JsonProperty("activity_page_index")]
        public Nullable<Int64> ActivityPageIndex
        {
            get;
            set;
        }

        /// <summary>
        /// 活动列表排序列
        /// </summary>
        /// <example>commisionRatio/startDate/width</example>
        [XmlElement("activity_sort_column")]
        [JsonProperty("activity_sort_column")]
        public String ActivitySortColumn
        {
            get;
            set;
        }

        /// <summary>
        /// 活动列表排序方式：DESC/ASC
        /// </summary>
        /// <example>DESC/ASC</example>
        [XmlElement("activity_sort")]
        [JsonProperty("activity_sort")]
        public String ActivitySort
        {
            get;
            set;
        }

        public override String ApiName
        {
            get { return "jingdong.union.advdetail.get"; }
        }

        protected override void PrepareParam(IDictionary<String, Object> paramters)
        {

            paramters.Add("plan_id", this.PlanId);
            paramters.Add("goods_page_size", this.GoodsPageSize);
            paramters.Add("goods_page_index", this.GoodsPageIndex);
            paramters.Add("goods_sort_column", this.GoodsSortColumn);
            paramters.Add("goods_sort", this.GoodsSort);
            paramters.Add("activity_page_size", this.ActivityPageSize);
            paramters.Add("activity_page_index", this.ActivityPageIndex);
            paramters.Add("activity_sort_column", this.ActivitySortColumn);
            paramters.Add("activity_sort", this.ActivitySort);

        }

        public override void Validate()
        {
            RequestValidator.ValidateRequired("plan_id", this.PlanId);
        }

    }
}
