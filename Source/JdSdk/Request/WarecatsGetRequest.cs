#region head comment
/*
Code generate by JdSdkTool.
2013-01-31 10:56:45:617 +08:00
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
    /// 获取商家已经开通的类目。 Request
    /// </summary>
    public class WarecatsGetRequest : IJdRequest<WarecatsGetResponse>
    {
        /// <summary>
        /// 需返回的字段列表。
        /// </summary>
        /// <example>id,fid,status,lev,name,index_id</example>
        [XmlElement("fields")]
        [JsonProperty("fields")]
        public String Fields
        {
            get;
            set;
        }

        public String ApiName
        {
            get{ return "360buy.warecats.get"; }
        }

        public String GetParamJson()
        {
            Dictionary<String, Object> paramters = new Dictionary<string, object>();
            paramters.Add("fields" ,this.Fields);
            return JsonConvert.SerializeObject(paramters, JdUtils.GetJsonConverters());
        }

        public void Validate()
        {
            RequestValidator.ValidateRequired("fields", this.Fields);
        }

    }
}
