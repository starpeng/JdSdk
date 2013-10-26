#region head comment
/*
Code generate by JdSdkTool.
Copyright © starpeng@vip.qq.com
2013-10-26 10:25:33.73249 +08:00
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
    /// 设置关联版式到商品。 Request
    /// </summary>
    public class WareTemplateToWaresUpdateRequest : JdRequestBase<WareTemplateToWaresUpdateResponse>
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
        /// 商品编号集合，最大不超过20个
        /// </summary>
        /// <example>“123313,12312123”</example>
        [XmlElement("ware_ids")]
        [JsonProperty("ware_ids")]
        public String WareIds
        {
            get;
            set;
        }

        public override String ApiName
        {
            get{ return "360buy.ware.template.to.wares.update"; }
        }

        protected override void PrepareParam(IDictionary<String, Object> paramters)
        {
            paramters.Add("id" ,this.Id);
            paramters.Add("ware_ids" ,this.WareIds);
        }

        public override void Validate()
        {
            RequestValidator.ValidateRequired("id", this.Id);
            RequestValidator.ValidateRequired("ware_ids", this.WareIds);
        }

    }
}
