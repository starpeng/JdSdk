#region head comment
/*
Code generate by JdSdkTool.
Copyright © starpeng@vip.qq.com
2013-09-07 15:01:55.65575 +08:00
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
    /// 促销创建完毕，提交保存促销命令。完成创建促销，必须调用该接口，否则相关数据将会被清除 Request
    /// </summary>
    public class JingdongSellerPromotionCommitRequest : JdRequestBase<JingdongSellerPromotionCommitResponse>
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

        public override String ApiName
        {
            get { return "jingdong.seller.promotion.commit"; }
        }

        protected override void PrepareParam(IDictionary<String, Object> paramters)
        {

            paramters.Add("promo_id", this.PromoId);

        }

        public override void Validate()
        {
            RequestValidator.ValidateRequired("promo_id", this.PromoId);
        }

    }
}
