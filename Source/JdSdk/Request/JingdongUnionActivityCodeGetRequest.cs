#region head comment
/*
Code generate by JdSdkTool.
Copyright © starpeng@vip.qq.com
2013-07-29 22:39:03.16409 +08:00
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
    /// 根据活动ID查询活动推广代码 Request
    /// </summary>
    public class JingdongUnionActivityCodeGetRequest : JdRequestBase<JingdongUnionActivityCodeGetResponse>
    {
        /// <summary>
        /// 活动ID
        /// </summary>
        /// <example>31345235</example>
        [XmlElement("activity_id")]
        [JsonProperty("activity_id")]
        public Int64 ActivityId
        {
            get;
            set;
        }

        public override String ApiName
        {
            get { return "jingdong.union.activity.code.get"; }
        }

        protected override void PrepareParam(IDictionary<String, Object> paramters)
        {

            paramters.Add("activity_id", this.ActivityId);

        }

        public override void Validate()
        {
            RequestValidator.ValidateRequired("activity_id", this.ActivityId);
        }

    }
}
