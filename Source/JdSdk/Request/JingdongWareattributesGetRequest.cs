#region head comment
/*
Code generate by JdSdkTool.
2013-04-03 12:45:24.54274 +08:00
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
    /// 获取类目下的属性属性值信息。 Request
    /// </summary>
    public class JingdongWareattributesGetRequest : JdRequestBase<JingdongWareattributesGetResponse>
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

        public override String ApiName
        {
            get { return "jingdong.wareattributes.get"; }
        }

        protected override void PrepareParam(IDictionary<String, Object> paramters)
        {

            paramters.Add("cid", this.Cid);
            paramters.Add("fields", this.Fields);

        }

        public override void Validate()
        {
            RequestValidator.ValidateRequired("cid", this.Cid);
        }

    }
}
