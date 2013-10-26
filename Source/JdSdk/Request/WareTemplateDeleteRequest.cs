#region head comment
/*
Code generate by JdSdkTool.
Copyright © starpeng@vip.qq.com
2013-10-26 10:25:33.12646 +08:00
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
    /// 删除商品关联版式。 Request
    /// </summary>
    public class WareTemplateDeleteRequest : JdRequestBase<WareTemplateDeleteResponse>
    {
        /// <summary>
        /// 版式id,123
        /// </summary>
        /// <example>“112312”</example>
        [XmlElement("id")]
        [JsonProperty("id")]
        public String Id
        {
            get;
            set;
        }

        public override String ApiName
        {
            get{ return "360buy.ware.template.delete"; }
        }

        protected override void PrepareParam(IDictionary<String, Object> paramters)
        {
            paramters.Add("id" ,this.Id);
        }

        public override void Validate()
        {
            RequestValidator.ValidateRequired("id", this.Id);
        }

    }
}
