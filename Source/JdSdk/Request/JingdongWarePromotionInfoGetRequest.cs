#region head comment
/*
Code generate by JdSdkTool.
Copyright © starpeng@vip.qq.com
2013-07-29 22:39:07.03531 +08:00
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
    ///  Request
    /// </summary>
    public class JingdongWarePromotionInfoGetRequest : JdRequestBase<JingdongWarePromotionInfoGetResponse>
    {
        /// <summary>
        /// 商品编号
        /// </summary>
        [XmlElement("skuId")]
        [JsonProperty("skuId")]
        public Int64 SkuId
        {
            get;
            set;
        }

        /// <summary>
        /// 站点,1-京东、2-千寻、3-ept海外购
        /// </summary>
        [XmlElement("webSite")]
        [JsonProperty("webSite")]
        public Decimal WebSite
        {
            get;
            set;
        }

        /// <summary>
        /// 来源（默认为1）,1-网站交易、2-手机包括ipad
        /// </summary>
        [XmlElement("origin")]
        [JsonProperty("origin")]
        public Decimal Origin
        {
            get;
            set;
        }

        public override String ApiName
        {
            get { return "jingdong.ware.promotionInfo.get"; }
        }

        protected override void PrepareParam(IDictionary<String, Object> paramters)
        {

            paramters.Add("skuid", this.SkuId);
            paramters.Add("website", this.WebSite);
            paramters.Add("origin", this.Origin);

        }

        public override void Validate()
        {
            RequestValidator.ValidateRequired("skuId", this.SkuId);
            RequestValidator.ValidateRequired("webSite", this.WebSite);
            RequestValidator.ValidateRequired("origin", this.Origin);
        }

    }
}
