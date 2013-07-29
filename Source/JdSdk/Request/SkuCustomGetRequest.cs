#region head comment
/*
Code generate by JdSdkTool.
2013-01-31 10:56:44:195 +08:00
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
    /// 根据商家设定的sku的外部id获取所对应的sku数据，一个sku的外部id对应一个sku数据。 Request
    /// </summary>
    public class SkuCustomGetRequest : IJdRequest<SkuCustomGetResponse>
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
        /// sku的外部商家ID
        /// </summary>
        /// <example>21asf234</example>
        [XmlElement("outer_id")]
        [JsonProperty("outer_id")]
        public String OuterId
        {
            get;
            set;
        }

        public String ApiName
        {
            get{ return "360buy.sku.custom.get"; }
        }

        public String GetParamJson()
        {
            Dictionary<String, Object> paramters = new Dictionary<string, object>();
            paramters.Add("fields" ,this.Fields);
            paramters.Add("outer_id" ,this.OuterId);
            return JsonConvert.SerializeObject(paramters, JdUtils.GetJsonConverters());
        }

        public void Validate()
        {
            RequestValidator.ValidateRequired("fields", this.Fields);
            RequestValidator.ValidateRequired("outer_id", this.OuterId);
        }

    }
}
