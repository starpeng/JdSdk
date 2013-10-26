#region head comment
/*
Code generate by JdSdkTool.
Copyright © starpeng@vip.qq.com
2013-07-29 22:39:06.42928 +08:00
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
    /// 根据指定专柜id获取转化代码 Request
    /// </summary>
    public class JingdongUnionZoneCodeGetRequest : JdRequestBase<JingdongUnionZoneCodeGetResponse>
    {
        /// <summary>
        /// 专柜ID
        /// </summary>
        [XmlElement("Zone_id")]
        [JsonProperty("Zone_id")]
        public Int64 ZoneId
        {
            get;
            set;
        }

        public override String ApiName
        {
            get { return "jingdong.union.zone.code.get"; }
        }

        protected override void PrepareParam(IDictionary<String, Object> paramters)
        {

            paramters.Add("zone_id", this.ZoneId);

        }

        public override void Validate()
        {
            RequestValidator.ValidateRequired("Zone_id", this.ZoneId);
        }

    }
}
