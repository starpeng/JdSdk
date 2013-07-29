#region head comment
/*
Code generate by JdSdkTool.
2013-07-29 22:39:06.83330 +08:00
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
    public class JingdongWarePriceGetRequest : IJdRequest<JingdongWarePriceGetResponse>
    {
        /// <summary>
        /// 商品ID
        /// </summary>
        /// <example>J_100012</example>
        [XmlElement("sku_id")]
        [JsonProperty("sku_id")]
        public String SkuId
        {
            get;
            set;
        }

        public String ApiName
        {
            get{ return "jingdong.ware.price.get"; }
        }

        public String GetParamJson()
        {
            Dictionary<String, Object> paramters = new Dictionary<string, object>();
            paramters.Add("sku_id" ,this.SkuId);
            return JsonConvert.SerializeObject(paramters, JdUtils.GetJsonConverters());
        }

        public void Validate()
        {
            RequestValidator.ValidateRequired("sku_id", this.SkuId);
        }

    }
}
