#region head comment
/*
Code generate by JdSdkTool.
Copyright © starpeng@vip.qq.com
2013-09-07 15:01:54.84670 +08:00
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
    /// 限单品、赠品促销调用此接口，所有参数适用于单品促销，赠品促销只限设置单次最少购买数量有效（(多次调用时，最后一次规则有效)） Request
    /// </summary>
    public class JingdongSellerPromotionActivitymodeAddRequest : JdRequestBase<JingdongSellerPromotionActivitymodeAddResponse>
    {
        /// <summary>
        /// 促销编号
        /// </summary>
        /// <example>123456</example>
        [XmlElement("promo_id")]
        [JsonProperty("promo_id")]
        public Int64 PromoId
        {
            get;
            set;
        }

        /// <summary>
        /// 参与促销的SKU总数量。默认值为0，0：不限，或任意正整数；限时抢购时，该参数必须大于0
        /// </summary>
        /// <example>10</example>
        [XmlElement("num_bound")]
        [JsonProperty("num_bound")]
        public Int64 NumBound
        {
            get;
            set;
        }

        /// <summary>
        /// 是否限购一个。默认值为0，0：不限，1：限购一个；当设置为限购一个时，单次最多可购数量，单次最少可够数量的设置不再起作用，系统默认会设置为1
        /// </summary>
        /// <example>0</example>
        [XmlElement("freq_bound")]
        [JsonProperty("freq_bound")]
        public Int64 FreqBound
        {
            get;
            set;
        }

        /// <summary>
        /// 单次最多可购数量，默认值为0，0：不限，或任意正整数
        /// </summary>
        /// <example>3</example>
        [XmlElement("per_max_num")]
        [JsonProperty("per_max_num")]
        public Int64 PerMaxNum
        {
            get;
            set;
        }

        /// <summary>
        /// 单次最少可购数量，默认值为0，0：不限，或任意正整数。赠品促销也可设置且不能大于10
        /// </summary>
        /// <example>1</example>
        [XmlElement("per_min_num")]
        [JsonProperty("per_min_num")]
        public Int64 PerMinNum
        {
            get;
            set;
        }

        public override String ApiName
        {
            get { return "jingdong.seller.promotion.activitymode.add"; }
        }

        protected override void PrepareParam(IDictionary<String, Object> paramters)
        {

            paramters.Add("promo_id", this.PromoId);
            paramters.Add("num_bound", this.NumBound);
            paramters.Add("freq_bound", this.FreqBound);
            paramters.Add("per_max_num", this.PerMaxNum);
            paramters.Add("per_min_num", this.PerMinNum);

        }

        public override void Validate()
        {
            RequestValidator.ValidateRequired("promo_id", this.PromoId);
        }

    }
}
