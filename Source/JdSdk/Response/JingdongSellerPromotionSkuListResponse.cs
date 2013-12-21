#region head comment
/*
Code generate by JdSdkTool.
2013-12-21 15:53:44.00533 +08:00
*/
#endregion

using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using Newtonsoft.Json;
using JdSdk.Domain;

namespace JdSdk.Response
{
    /// <summary>
    /// 分页查询指定促销下符合条件的促销SKU，最多返回10个 Response
    /// </summary>
    public class JingdongSellerPromotionSkuListResponse : JdResponse
    {
        /// <summary>
        /// SKU总数量
        /// </summary>
        [XmlElement("total_count")]
        [JsonProperty("total_count")]
        public Nullable<Int64> TotalCount
        {
            get;
            set;
        }

        /// <summary>
        /// 促销SKU列表
        /// </summary>
        [XmlElement("promo_sku_v_o_s")]
        [JsonProperty("promo_sku_v_o_s")]
        public List<PromoSkuVO> PromoSkuVOS
        {
            get;
            set;
        }

    }
}
