#region head comment
/*
Code generate by JdSdkTool.
Copyright © starpeng@vip.qq.com
2013-09-07 15:01:52.61958 +08:00
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
    /// 获取采购单信息 Request
    /// </summary>
    public class JingdongLogisticsPoGetRequest : JdRequestBase<JingdongLogisticsPoGetResponse>
    {
        /// <summary>
        /// JOSL唯一入库单号
        /// </summary>
        [XmlElement("inbound_no")]
        [JsonProperty("inbound_no")]
        public String InboundNo
        {
            get;
            set;
        }

        public override String ApiName
        {
            get { return "jingdong.logistics.po.get"; }
        }

        protected override void PrepareParam(IDictionary<String, Object> paramters)
        {

            paramters.Add("inbound_no", this.InboundNo);

        }

        public override void Validate()
        {
            RequestValidator.ValidateRequired("inbound_no", this.InboundNo);
        }

    }
}
