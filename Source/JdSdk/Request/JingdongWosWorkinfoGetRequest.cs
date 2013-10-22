#region head comment
/*
Code generate by JdSdkTool.
2013-09-07 15:02:04.34725 +08:00
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
    ///  Request
    /// </summary>
    public class JingdongWosWorkinfoGetRequest : JdRequestBase<JingdongWosWorkinfoGetResponse>
    {
        /// <summary>
        /// 工单号 (通过jingdong.wos.worklist.get接口获取)
        /// </summary>
        [XmlElement("work_id")]
        [JsonProperty("work_id")]
        public Int64 WorkId
        {
            get;
            set;
        }

        public override String ApiName
        {
            get { return "jingdong.wos.workinfo.get"; }
        }

        protected override void PrepareParam(IDictionary<String, Object> paramters)
        {

            paramters.Add("work_id", this.WorkId);

        }

        public override void Validate()
        {
            RequestValidator.ValidateRequired("work_id", this.WorkId);
        }

    }
}
