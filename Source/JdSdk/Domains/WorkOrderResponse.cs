#region head comment
/*
Code generate by JdSdkTool.
Copyright © starpeng@vip.qq.com
2013-10-26 10:25:50.77347 +08:00
*/
#endregion

using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace JdSdk.Domain
{
    /// <summary>
    /// WorkOrderResponse属性
    /// </summary>
    [Serializable]
    public class WorkOrderResponse : JdObject
    {
        /// <summary>
        /// 执行结果标识。1:代表执行成功，2：代表执行异常，3：有时候工单回复因为网络原因没有拿到结果，此状态代表工单已经是商家已回复状态，不需要再次回复。
        /// </summary>
        [XmlElement("result_code")]
        [JsonProperty("result_code")]
        public Int64 ResultCode
        {
            get;
            set;
        }

        /// <summary>
        /// 执行结果参考信息
        /// </summary>
        [XmlElement("result_msg")]
        [JsonProperty("result_msg")]
        public String ResultMsg
        {
            get;
            set;
        }

    }
}
