#region head comment
/*
Code generate by JdSdkTool.
2013-09-07 15:01:56.05977 +08:00
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
    /// 根据促销编号获取促销详细信息 Request
    /// </summary>
    public class JingdongSellerPromotionGetRequest : IJdRequest<JingdongSellerPromotionGetResponse>
    {
        /// <summary>
        /// 促销编号
        /// </summary>
        [XmlElement("promo_id")]
        [JsonProperty("promo_id")]
        public Int64 PromoId
        {
            get;
            set;
        }

        public String ApiName
        {
            get{ return "jingdong.seller.promotion.get"; }
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
