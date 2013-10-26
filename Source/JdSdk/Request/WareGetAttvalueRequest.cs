#region head comment
/*
Code generate by JdSdkTool.
Copyright © starpeng@vip.qq.com
2013-01-31 10:56:46:022 +08:00
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
    /// 获取类目下的属性值信息。 Request
    /// </summary>
    public class WareGetAttvalueRequest : JdRequestBase<WareGetAttvalueResponse>
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

        public override String ApiName
        {
            get { return "360buy.ware.get.attvalue"; }
        }

        protected override void PrepareParam(IDictionary<String, Object> paramters)
        {

            paramters.Add("fields", this.Fields);
            paramters.Add("avs", this.Avs);

        }

        public override void Validate()
        {
            RequestValidator.ValidateRequired("fields", this.Fields);
            RequestValidator.ValidateRequired("avs", this.Avs);
        }

    }
}
