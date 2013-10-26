#region head comment
/*
Code generate by JdSdkTool.
Copyright © starpeng@vip.qq.com
2013-09-07 15:01:52.01454 +08:00
*/
#endregion

using System;
using System.Xml.Serialization;
using Newtonsoft.Json;

namespace JdSdk.Response
{
    /// <summary>
    /// 其他出库订单下传 Response
    /// </summary>
    public class JingdongLogisticsOtherOutstoreAddResponse : JdResponse
    {
        /// <summary>
        /// 处理结果Code
        /// </summary>
        [XmlElement("process_code")]
        [JsonProperty("process_code")]
        public Int64 ProcessCode
        {
            get;
            set;
        }

        /// <summary>
        /// 处理状态含义
        /// </summary>
        [XmlElement("process_status")]
        [JsonProperty("process_status")]
        public String ProcessStatus
        {
            get;
            set;
        }

        /// <summary>
        /// 错误信息
        /// </summary>
        [XmlElement("error_message")]
        [JsonProperty("error_message")]
        public String ErrorMessage
        {
            get;
            set;
        }

        /// <summary>
        /// 返回操作单号
        /// </summary>
        [XmlElement("result_no")]
        [JsonProperty("result_no")]
        public String ResultNo
        {
            get;
            set;
        }

    }
}
