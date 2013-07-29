#region head comment
/*
Code generate by JdSdkTool.
2013-01-31 10:56:46:022 +08:00
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
    /// 获取类目下的属性值信息。 Request
    /// </summary>
    public class WareGetAttvalueRequest : IJdRequest<WareGetAttvalueResponse>
    {
        /// <summary>
        /// 需返回的字段列表。
        /// </summary>
        /// <example>aid,vid,name,status,index_id</example>
        [XmlElement("fields")]
        [JsonProperty("fields")]
        public String Fields
        {
            get;
            set;
        }

        /// <summary>
        /// 属性和属性值 id串，格式例如(aid)或(aid;aid)或(aid:vid)或(aid:vid;aid:vid)或(aid;aid:vid)
        /// </summary>
        [XmlElement("avs")]
        [JsonProperty("avs")]
        public String Avs
        {
            get;
            set;
        }

        public String ApiName
        {
            get{ return "360buy.ware.get.attvalue"; }
        }

        public String GetParamJson()
        {
            Dictionary<String, Object> paramters = new Dictionary<string, object>();
            paramters.Add("fields" ,this.Fields);
            paramters.Add("avs" ,this.Avs);
            return JsonConvert.SerializeObject(paramters, JdUtils.GetJsonConverters());
        }

        public void Validate()
        {
            RequestValidator.ValidateRequired("fields", this.Fields);
            RequestValidator.ValidateRequired("avs", this.Avs);
        }

    }
}
