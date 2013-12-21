#region head comment
/*
Code generate by JdSdkTool.
2013-12-21 15:53:44.00434 +08:00
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
    /// 分页查询指定促销下符合条件的促销SKU，最多返回10个 Request
    /// </summary>
    public class JingdongSellerPromotionSkuListRequest : JdRequestBase<JingdongSellerPromotionSkuListResponse>
    {
        /// <summary>
        /// 商品ID(可选)
        /// </summary>
        [XmlElement("ware_id")]
        [JsonProperty("ware_id")]
        public Nullable<Int64> WareId
        {
            get;
            set;
        }

        /// <summary>
        /// skuId(可选)
        /// </summary>
        [XmlElement("sku_id")]
        [JsonProperty("sku_id")]
        public Nullable<Int64> SkuId
        {
            get;
            set;
        }

        /// <summary>
        /// 促销编号
        /// </summary>
        /// <example>21113</example>
        [XmlElement("promo_id")]
        [JsonProperty("promo_id")]
        public Int64 PromoId
        {
            get;
            set;
        }

        /// <summary>
        /// 页码
        /// </summary>
        /// <example>1</example>
        [XmlElement("page")]
        [JsonProperty("page")]
        public Int64 Page
        {
            get;
            set;
        }

        /// <summary>
        /// 每页记录个数（每页最少1个，最多10个）
        /// </summary>
        /// <example>10</example>
        [XmlElement("size")]
        [JsonProperty("size")]
        public Int64 Size
        {
            get;
            set;
        }

        public override String ApiName
        {
            get{ return "jingdong.seller.promotion.sku.list"; }
        }

        protected override void PrepareParam(IDictionary<String, Object> paramters)
        {
            paramters.Add("ware_id" ,this.WareId);
            paramters.Add("sku_id" ,this.SkuId);
            paramters.Add("promo_id" ,this.PromoId);
            paramters.Add("page" ,this.Page);
            paramters.Add("size" ,this.Size);
        }

        public override void Validate()
        {
            RequestValidator.ValidateRequired("promo_id", this.PromoId);
            RequestValidator.ValidateRequired("page", this.Page);
            RequestValidator.ValidateRequired("size", this.Size);
        }

    }
}
