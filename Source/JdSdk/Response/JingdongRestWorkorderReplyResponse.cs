#region head comment
/*
Code generate by JdSdkTool.
Copyright © starpeng@vip.qq.com
2013-10-26 10:25:45.88419 +08:00
*/
#endregion

using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using Newtonsoft.Json;
using JdSdk.Domain;

namespace JdSdk.Response
{
    /// <summary>
    ///  Response
    /// </summary>
    public class JingdongRestWorkorderReplyResponse : JdResponse
    {
        /// <summary>
        /// 返回结果 resultCode[执行结果标识。1:代表执行成功，2：代表执行异常，3：有时候工单回复因为网络原因没有拿到结果，此状态代表工单已经是商家已回  复状态，不需要再次回复。],resultMsg [执行结果的参考信息]
        /// </summary>
        [XmlElement("work_order")]
        [JsonProperty("work_order")]
        public WorkOrderResponse WorkOrder
        {
            get;
            set;
        }

    }
}
