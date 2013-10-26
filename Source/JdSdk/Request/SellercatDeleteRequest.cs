#region head comment
/*
Code generate by JdSdkTool.
Copyright © starpeng@vip.qq.com
2013-04-03 12:45:17.00531 +08:00
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
    /// 删除店铺的类目 Request
    /// </summary>
    public class SellercatDeleteRequest : JdRequestBase<SellercatDeleteResponse>
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

        public override String ApiName
        {
            get { return "360buy.sellercat.delete"; }
        }

        protected override void PrepareParam(IDictionary<String, Object> paramters)
        {

            paramters.Add("cid", this.Cid);

        }

        public override void Validate()
        {
            RequestValidator.ValidateRequired("cid", this.Cid);
        }

    }
}
