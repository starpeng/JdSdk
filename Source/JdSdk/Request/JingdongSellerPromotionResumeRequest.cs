#region head comment
/*
Code generate by JdSdkTool.
2013-09-07 15:01:56.86882 +08:00
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
    /// 重启促销，使暂停的促销重新生效，只能对暂停的促销进行重启操作。 Request
    /// </summary>
    public class JingdongSellerPromotionResumeRequest : IJdRequest<JingdongSellerPromotionResumeResponse>
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
            get{ return "jingdong.seller.promotion.resume"; }
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
