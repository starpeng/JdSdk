#region head comment
/*
Code generate by JdSdkTool.
2013-07-29 22:39:07.03531 +08:00
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
    ///  Request
    /// </summary>
    public class JingdongWarePromotionInfoGetRequest : IJdRequest<JingdongWarePromotionInfoGetResponse>
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

        public String ApiName
        {
            get{ return "jingdong.ware.promotionInfo.get"; }
        }

        public String GetParamJson()
        {
            Dictionary<String, Object> paramters = new Dictionary<string, object>();
            paramters.Add("skuid" ,this.SkuId);
            paramters.Add("website" ,this.WebSite);
            paramters.Add("origin" ,this.Origin);
            return JsonConvert.SerializeObject(paramters, JdUtils.GetJsonConverters());
        }

        public void Validate()
        {
            RequestValidator.ValidateRequired("skuId", this.SkuId);
            RequestValidator.ValidateRequired("webSite", this.WebSite);
            RequestValidator.ValidateRequired("origin", this.Origin);
        }

    }
}
