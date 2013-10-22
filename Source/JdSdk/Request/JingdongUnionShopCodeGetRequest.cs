#region head comment
/*
Code generate by JdSdkTool.
2013-07-29 22:39:06.22727 +08:00
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
    /// 根据店铺ID查询店铺推广代码 Request
    /// </summary>
    public class JingdongUnionShopCodeGetRequest : JdRequestBase<JingdongUnionShopCodeGetResponse>
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

        public override String ApiName
        {
            get { return "jingdong.union.shop.code.get"; }
        }

        protected override void PrepareParam(IDictionary<String, Object> paramters)
        {

            paramters.Add("shop_id", this.ShopId);

        }

        public override void Validate()
        {
            RequestValidator.ValidateRequired("shop_id", this.ShopId);
        }

    }
}
