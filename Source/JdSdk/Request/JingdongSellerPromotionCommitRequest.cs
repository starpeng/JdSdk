#region head comment
/*
Code generate by JdSdkTool.
2013-09-07 15:01:55.65575 +08:00
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
    /// 促销创建完毕，提交保存促销命令。完成创建促销，必须调用该接口，否则相关数据将会被清除 Request
    /// </summary>
    public class JingdongSellerPromotionCommitRequest : IJdRequest<JingdongSellerPromotionCommitResponse>
    {
        /// <summary>
        /// 
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
            get{ return "jingdong.seller.promotion.commit"; }
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
