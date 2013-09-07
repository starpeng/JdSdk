#region head comment
/*
Code generate by JdSdkTool.
2013-09-07 15:01:55.45274 +08:00
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
    /// 促销审核，只能对人工审核状态的促销进行审核 Request
    /// </summary>
    public class JingdongSellerPromotionCheckRequest : IJdRequest<JingdongSellerPromotionCheckResponse>
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
        /// 审核状态。可选值：通过（4），驳回（1）
        /// </summary>
        /// <example>4</example>
        [XmlElement("status")]
        [JsonProperty("status")]
        public Int64 Status
        {
            get;
            set;
        }

        public String ApiName
        {
            get{ return "jingdong.seller.promotion.check"; }
        }

        public String GetParamJson()
        {
            Dictionary<String, Object> paramters = new Dictionary<string, object>();
            paramters.Add("promo_id" ,this.PromoId);
            paramters.Add("status" ,this.Status);
            return JsonConvert.SerializeObject(paramters, JdUtils.GetJsonConverters());
        }

        public void Validate()
        {
            RequestValidator.ValidateRequired("promo_id", this.PromoId);
            RequestValidator.ValidateRequired("status", this.Status);
        }

    }
}
