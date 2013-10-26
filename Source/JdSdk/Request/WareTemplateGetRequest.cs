#region head comment
/*
Code generate by JdSdkTool.
Copyright © starpeng@vip.qq.com
2013-10-26 10:25:33.32847 +08:00
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
    /// 查询关联版式详情。 Request
    /// </summary>
    public class WareTemplateGetRequest : JdRequestBase<WareTemplateGetResponse>
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

        /// <summary>
        /// 需返回的字段列表。可选值：WareTemplate结构体中的所有字段；字段之间用&quot;,&quot;分隔
        /// </summary>
        [XmlElement("fields")]
        [JsonProperty("fields")]
        public String Fields
        {
            get;
            set;
        }

        public override String ApiName
        {
            get{ return "360buy.ware.template.get"; }
        }

        protected override void PrepareParam(IDictionary<String, Object> paramters)
        {
            paramters.Add("id" ,this.Id);
            paramters.Add("fields" ,this.Fields);
        }

        public override void Validate()
        {
            RequestValidator.ValidateRequired("id", this.Id);
        }

    }
}
