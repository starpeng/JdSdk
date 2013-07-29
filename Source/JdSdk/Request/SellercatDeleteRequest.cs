#region head comment
/*
Code generate by JdSdkTool.
2013-04-03 12:45:17.00531 +08:00
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
    /// 删除店铺的类目 Request
    /// </summary>
    public class SellercatDeleteRequest : IJdRequest<SellercatDeleteResponse>
    {
        /// <summary>
        /// 类目ID
        /// </summary>
        /// <example>1</example>
        [XmlElement("cid")]
        [JsonProperty("cid")]
        public String Cid
        {
            get;
            set;
        }

        public String ApiName
        {
            get{ return "360buy.sellercat.delete"; }
        }

        public String GetParamJson()
        {
            Dictionary<String, Object> paramters = new Dictionary<string, object>();
            paramters.Add("cid" ,this.Cid);
            return JsonConvert.SerializeObject(paramters, JdUtils.GetJsonConverters());
        }

        public void Validate()
        {
            RequestValidator.ValidateRequired("cid", this.Cid);
        }

    }
}
