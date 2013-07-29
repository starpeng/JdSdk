#region head comment
/*
Code generate by JdSdkTool.
2013-01-31 10:56:45:820 +08:00
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
    /// 获取类目下的属性信息。 Request
    /// </summary>
    public class WareGetAttributeRequest : IJdRequest<WareGetAttributeResponse>
    {
        /// <summary>
        /// 需返回的字段列表。
        /// </summary>
        /// <example>aid,name,is_key_prop,is_sale_prop,index_id,status,att_type,input_type,is_req,is_fet,is_nav,cid</example>
        [XmlElement("fields")]
        [JsonProperty("fields")]
        public String Fields
        {
            get;
            set;
        }

        /// <summary>
        /// 类目id
        /// </summary>
        [XmlElement("cid")]
        [JsonProperty("cid")]
        public Decimal Cid
        {
            get;
            set;
        }

        /// <summary>
        /// 是否关键属性(true/false)
        /// </summary>
        /// <example>true</example>
        [XmlElement("is_key_prop")]
        [JsonProperty("is_key_prop")]
        public Nullable<Boolean> IsKeyProp
        {
            get;
            set;
        }

        /// <summary>
        /// 是否销售属性(true/false)
        /// </summary>
        /// <example>false</example>
        [XmlElement("is_sale_prop")]
        [JsonProperty("is_sale_prop")]
        public Nullable<Boolean> IsSaleProp
        {
            get;
            set;
        }

        /// <summary>
        /// 属性id
        /// </summary>
        [XmlElement("aid")]
        [JsonProperty("aid")]
        public Nullable<Decimal> Aid
        {
            get;
            set;
        }

        public String ApiName
        {
            get{ return "360buy.ware.get.attribute"; }
        }

        public String GetParamJson()
        {
            Dictionary<String, Object> paramters = new Dictionary<string, object>();
            paramters.Add("fields" ,this.Fields);
            paramters.Add("cid" ,this.Cid);
            paramters.Add("is_key_prop" ,this.IsKeyProp);
            paramters.Add("is_sale_prop" ,this.IsSaleProp);
            paramters.Add("aid" ,this.Aid);
            return JsonConvert.SerializeObject(paramters, JdUtils.GetJsonConverters());
        }

        public void Validate()
        {
            RequestValidator.ValidateRequired("fields", this.Fields);
            RequestValidator.ValidateRequired("cid", this.Cid);
        }

    }
}
