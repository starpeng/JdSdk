#region head comment
/*
Code generate by JdSdkTool.
2013-04-03 12:45:24.74476 +08:00
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
    /// 获取类目。 Request
    /// </summary>
    public class JingdongWarecategoryGetRequest : IJdRequest<JingdongWarecategoryGetResponse>
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

        public String ApiName
        {
            get{ return "jingdong.warecategory.get"; }
        }

        public String GetParamJson()
        {
            Dictionary<String, Object> paramters = new Dictionary<string, object>();
            paramters.Add("cid" ,this.Cid);
            paramters.Add("level" ,this.Level);
            paramters.Add("fields" ,this.Fields);
            return JsonConvert.SerializeObject(paramters, JdUtils.GetJsonConverters());
        }

        public void Validate()
        {
            RequestValidator.ValidateRequired("cid", this.Cid);
            RequestValidator.ValidateRequired("level", this.Level);
        }

    }
}
