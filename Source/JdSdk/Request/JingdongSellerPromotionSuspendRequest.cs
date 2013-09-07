#region head comment
/*
Code generate by JdSdkTool.
2013-09-07 15:01:57.47485 +08:00
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
    /// 暂停促销，使促销暂不生效，只能对已生效的促销进行暂停 Request
    /// </summary>
    public class JingdongSellerPromotionSuspendRequest : IJdRequest<JingdongSellerPromotionSuspendResponse>
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

        public String ApiName
        {
            get{ return "jingdong.seller.promotion.suspend"; }
        }

        public String GetParamJson()
        {
            Dictionary<String, Object> paramters = new Dictionary<string, object>();
            paramters.Add("promo_id" ,this.PromoId);
            return JsonConvert.SerializeObject(paramters, JdUtils.GetJsonConverters());
        }

        public void Validate()
        {
            RequestValidator.ValidateRequired("promo_id", this.PromoId);
        }

    }
}
