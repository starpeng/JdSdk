#region head comment
/*
Code generate by JdSdkTool.
Copyright © starpeng@vip.qq.com
2013-09-07 15:01:51.81153 +08:00
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
    /// 其它入库单查询 Request
    /// </summary>
    public class JingdongLogisticsOtherInstoreQueryRequest : JdRequestBase<JingdongLogisticsOtherInstoreQueryResponse>
    {
        /// <summary>
        /// 其它入库入库单号
        /// </summary>
        /// <example>JBI0000000033</example>
        [XmlElement("in_bound_no")]
        [JsonProperty("in_bound_no")]
        public String InBoundNo
        {
            get;
            set;
        }

        public override String ApiName
        {
            get { return "jingdong.logistics.otherInstore.query"; }
        }

        protected override void PrepareParam(IDictionary<String, Object> paramters)
        {

            paramters.Add("in_bound_no", this.InBoundNo);

        }

        public override void Validate()
        {
            RequestValidator.ValidateRequired("in_bound_no", this.InBoundNo);
        }

    }
}
