#region head comment
/*
Code generate by JdSdkTool.
2013-01-31 10:56:42:780 +08:00
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
    /// 获取多个商品下的所有sku。 Request
    /// </summary>
    public class WareSkusGetRequest : IJdRequest<WareSkusGetResponse>
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

        public String ApiName
        {
            get{ return "360buy.ware.skus.get"; }
        }

        public String GetParamJson()
        {
            Dictionary<String, Object> paramters = new Dictionary<string, object>();
            paramters.Add("fields" ,this.Fields);
            paramters.Add("ware_ids" ,this.WareIds);
            return JsonConvert.SerializeObject(paramters, JdUtils.GetJsonConverters());
        }

        public void Validate()
        {
            RequestValidator.ValidateRequired("fields", this.Fields);
            RequestValidator.ValidateRequired("ware_ids", this.WareIds);
        }

    }
}
