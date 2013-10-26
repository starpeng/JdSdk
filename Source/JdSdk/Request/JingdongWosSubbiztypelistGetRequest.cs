#region head comment
/*
Code generate by JdSdkTool.
Copyright © starpeng@vip.qq.com
2013-10-26 10:25:50.12543 +08:00
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
    public class JingdongWosSubbiztypelistGetRequest : JdRequestBase<JingdongWosSubbiztypelistGetResponse>
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

        public override String ApiName
        {
            get{ return "jingdong.wos.subbiztypelist.get"; }
        }

        protected override void PrepareParam(IDictionary<String, Object> paramters)
        {
            paramters.Add("biztype_id" ,this.BiztypeId);
        }

        public override void Validate()
        {
            RequestValidator.ValidateRequired("biztype_id", this.BiztypeId);
        }

    }
}
