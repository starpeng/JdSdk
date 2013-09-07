#region head comment
/*
Code generate by JdSdkTool.
2013-09-07 15:02:04.14523 +08:00
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
    ///  Request
    /// </summary>
    public class JingdongWosSubbiztypelistGetRequest : IJdRequest<JingdongWosSubbiztypelistGetResponse>
    {
        /// <summary>
        /// 一级业务类型ID    (通过jingdong.wos.workinfo.get接口send_biztype_id字段获取)
        /// </summary>
        [XmlElement("biztype_id")]
        [JsonProperty("biztype_id")]
        public Int64 BiztypeId
        {
            get;
            set;
        }

        public String ApiName
        {
            get{ return "jingdong.wos.subbiztypelist.get"; }
        }

        public String GetParamJson()
        {
            Dictionary<String, Object> paramters = new Dictionary<string, object>();
            paramters.Add("biztype_id" ,this.BiztypeId);
            return JsonConvert.SerializeObject(paramters, JdUtils.GetJsonConverters());
        }

        public void Validate()
        {
            RequestValidator.ValidateRequired("biztype_id", this.BiztypeId);
        }

    }
}
