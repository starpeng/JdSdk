#region head comment
/*
Code generate by JdSdkTool.
2013-04-03 12:45:24.74476 +08:00
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
    /// 获取类目。 Request
    /// </summary>
    public class JingdongWarecategoryGetRequest : JdRequestBase<JingdongWarecategoryGetResponse>
    {
        /// <summary>
        /// 类目id，默认为0
        /// </summary>
        /// <example>1002</example>
        [XmlElement("cid")]
        [JsonProperty("cid")]
        public String Cid
        {
            get;
            set;
        }

        /// <summary>
        /// 等级(类目分为1、2、3级，对应值为0、1、2)
        /// </summary>
        /// <example>1</example>
        [XmlElement("level")]
        [JsonProperty("level")]
        public String Level
        {
            get;
            set;
        }

        /// <summary>
        /// 需返回的字段列表。支持的字段：cid,fid,level,name,index
        /// </summary>
        /// <example>cid,fid,level,name,index</example>
        [XmlElement("fields")]
        [JsonProperty("fields")]
        public String Fields
        {
            get;
            set;
        }

        public override String ApiName
        {
            get { return "jingdong.warecategory.get"; }
        }

        protected override void PrepareParam(IDictionary<String, Object> paramters)
        {

            paramters.Add("cid", this.Cid);
            paramters.Add("level", this.Level);
            paramters.Add("fields", this.Fields);

        }

        public override void Validate()
        {
            RequestValidator.ValidateRequired("cid", this.Cid);
            RequestValidator.ValidateRequired("level", this.Level);
        }

    }
}
