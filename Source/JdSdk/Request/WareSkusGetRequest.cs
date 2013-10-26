#region head comment
/*
Code generate by JdSdkTool.
Copyright © starpeng@vip.qq.com
2013-01-31 10:56:42:780 +08:00
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
    /// 获取多个商品下的所有sku。 Request
    /// </summary>
    public class WareSkusGetRequest : JdRequestBase<WareSkusGetResponse>
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
        /// sku所属商品id，必选。ware_ids个数不能超过10个
        /// </summary>
        /// <example>1311,12312,1212</example>
        [XmlElement("ware_ids")]
        [JsonProperty("ware_ids")]
        public String WareIds
        {
            get;
            set;
        }

        public override String ApiName
        {
            get { return "360buy.ware.skus.get"; }
        }

        protected override void PrepareParam(IDictionary<String, Object> paramters)
        {

            paramters.Add("fields", this.Fields);
            paramters.Add("ware_ids", this.WareIds);

        }

        public override void Validate()
        {
            RequestValidator.ValidateRequired("fields", this.Fields);
            RequestValidator.ValidateRequired("ware_ids", this.WareIds);
        }

    }
}
