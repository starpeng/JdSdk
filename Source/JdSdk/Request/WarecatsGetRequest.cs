#region head comment
/*
Code generate by JdSdkTool.
2013-01-31 10:56:45:617 +08:00
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
    /// 获取商家已经开通的类目。 Request
    /// </summary>
    public class WarecatsGetRequest : JdRequestBase<WarecatsGetResponse>
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

        public override String ApiName
        {
            get { return "360buy.warecats.get"; }
        }

        protected override void PrepareParam(IDictionary<String, Object> paramters)
        {

            paramters.Add("fields", this.Fields);

        }

        public override void Validate()
        {
            RequestValidator.ValidateRequired("fields", this.Fields);
        }

    }
}
