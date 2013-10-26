#region head comment
/*
Code generate by JdSdkTool.
Copyright © starpeng@vip.qq.com
2013-01-31 10:56:44:806 +08:00
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
    /// 根据sku_id获取所对应的sku数据，sku_id对应的sku要属于传入的vender_id对应的商家 Request
    /// </summary>
    public class WareSkuGetRequest : JdRequestBase<WareSkuGetResponse>
    {
        /// <summary>
        /// 需返回的字段列表。可选值：Sku结构体中的所有字段；字段之间用","分隔
        /// </summary>
        /// <example>sku_id,ware_id,status,attributes</example>
        [XmlElement("fields")]
        [JsonProperty("fields")]
        public String Fields
        {
            get;
            set;
        }

        /// <summary>
        /// sku id
        /// </summary>
        /// <example>100000012</example>
        [XmlElement("sku_id")]
        [JsonProperty("sku_id")]
        public Int64 SkuId
        {
            get;
            set;
        }

        public override String ApiName
        {
            get { return "360buy.ware.sku.get"; }
        }

        protected override void PrepareParam(IDictionary<String, Object> paramters)
        {

            paramters.Add("fields", this.Fields);
            paramters.Add("sku_id", this.SkuId);

        }

        public override void Validate()
        {
            RequestValidator.ValidateRequired("fields", this.Fields);
            RequestValidator.ValidateRequired("sku_id", this.SkuId);
        }

    }
}
