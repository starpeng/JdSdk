#region head comment
/*
Code generate by JdSdkTool.
2013-07-29 22:39:06.22727 +08:00
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
    /// 根据店铺ID查询店铺推广代码 Request
    /// </summary>
    public class JingdongUnionShopCodeGetRequest : IJdRequest<JingdongUnionShopCodeGetResponse>
    {
        /// <summary>
        /// 店铺ID
        /// </summary>
        /// <example>30442004</example>
        [XmlElement("shop_id")]
        [JsonProperty("shop_id")]
        public Int64 ShopId
        {
            get;
            set;
        }

        public String ApiName
        {
            get{ return "jingdong.union.shop.code.get"; }
        }

        public String GetParamJson()
        {
            Dictionary<String, Object> paramters = new Dictionary<string, object>();
            paramters.Add("shop_id" ,this.ShopId);
            return JsonConvert.SerializeObject(paramters, JdUtils.GetJsonConverters());
        }

        public void Validate()
        {
            RequestValidator.ValidateRequired("shop_id", this.ShopId);
        }

    }
}
