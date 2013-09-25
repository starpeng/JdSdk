#region head comment
/*
Code generate by JdSdkTool.
2013-08-02 16:22:54.16068 +08:00
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
    /// 根据skuId获取商品信息（需所属商家授权） Request
    /// </summary>
    public class JingdongKuaicheGoodsGetRequest : IJdRequest<JingdongKuaicheGoodsGetResponse>
    {
        /// <summary>
        /// 商品skuid
        /// </summary>
        [XmlElement("sku_id")]
        [JsonProperty("sku_id")]
        public Int64 SkuId
        {
            get;
            set;
        }

        public String ApiName
        {
            get{ return "jingdong.kuaiche.goods.get"; }
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
