#region head comment
/*
Code generate by JdSdkTool.
2013-04-03 12:45:17.40934 +08:00
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
    /// 根据商家编号获取店内分类 Request
    /// </summary>
    public class SellercatsGetRequest : JdRequestBase<SellercatsGetResponse>
    {
        /// <summary>
        /// 可选字段
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
            get { return "360buy.sellercats.get"; }
        }

        protected override void PrepareParam(IDictionary<String, Object> paramters)
        {

            paramters.Add("fields", this.Fields);

        }

        public override void Validate()
        {
        }

    }
}
