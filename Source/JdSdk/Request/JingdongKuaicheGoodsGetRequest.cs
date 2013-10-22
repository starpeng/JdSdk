#region head comment
/*
Code generate by JdSdkTool.
2013-08-02 16:22:54.16068 +08:00
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
    /// 根据skuId获取商品信息（需所属商家授权） Request
    /// </summary>
    public class JingdongKuaicheGoodsGetRequest : JdRequestBase<JingdongKuaicheGoodsGetResponse>
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

        public override String ApiName
        {
            get { return "jingdong.kuaiche.goods.get"; }
        }

        protected override void PrepareParam(IDictionary<String, Object> paramters)
        {

            paramters.Add("sku_id", this.SkuId);

        }

        public override void Validate()
        {
            RequestValidator.ValidateRequired("sku_id", this.SkuId);
        }

    }
}
