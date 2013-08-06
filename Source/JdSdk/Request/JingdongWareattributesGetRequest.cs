#region head comment
/*
Code generate by JdSdkTool.
2013-04-03 12:45:24.54274 +08:00
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
    /// 获取类目下的属性属性值信息。 Request
    /// </summary>
    public class JingdongWareattributesGetRequest : IJdRequest<JingdongWareattributesGetResponse>
    {
        /// <summary>
        /// 三级类目id，通过&#61656;jingdong.warecategory.get获得三级类目id
        /// </summary>
        /// <example>1002</example>
        [XmlElement("cid")]
        [JsonProperty("cid")]
        public Int64 Cid
        {
            get;
            set;
        }

        /// <summary>
        /// 可选返回字段。可选值：aid,name,attributeValues
        /// </summary>
        /// <example>aid,name,attributeValues</example>
        [XmlElement("fields")]
        [JsonProperty("fields")]
        public String Fields
        {
            get;
            set;
        }

        public String ApiName
        {
            get{ return "jingdong.wareattributes.get"; }
        }

        public String GetParamJson()
        {
            Dictionary<String, Object> paramters = new Dictionary<string, object>();
            paramters.Add("cid" ,this.Cid);
            paramters.Add("fields" ,this.Fields);
            return JsonConvert.SerializeObject(paramters, JdUtils.GetJsonConverters());
        }

        public void Validate()
        {
            RequestValidator.ValidateRequired("cid", this.Cid);
        }

    }
}
