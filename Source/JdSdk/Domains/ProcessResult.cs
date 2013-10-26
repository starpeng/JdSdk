#region head comment
/*
Code generate by JdSdkTool.
Copyright © starpeng@vip.qq.com
2013-09-07 15:02:04.78827 +08:00
*/
#endregion

using System;
using System.Xml.Serialization;
using Newtonsoft.Json;

namespace JdSdk.Domain
{
    /// <summary>
    /// ProcessResult 属性
    /// </summary>
    [Serializable]
    public class ProcessResult : JdObject
    {
        /// <summary>
        /// 申请结果代码
        /// </summary>
        /// <example>1</example>
        [XmlElement("process_code")]
        [JsonProperty("process_code")]
        public Int64 ProcessCode
        {
            get;
            set;
        }

        /// <summary>
        /// 申请状态
        /// </summary>
        /// <example>SUCCESS</example>
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
        /// <example>该退货单不能重复申请</example>
        [XmlElement("error_message")]
        [JsonProperty("error_message")]
        public String ErrorMessage
        {
            get;
            set;
        }

        /// <summary>
        /// 成功申请的退货单号
        /// </summary>
        /// <example>JRI000001</example>
        [XmlElement("result_no")]
        [JsonProperty("result_no")]
        public String ResultNo
        {
            get;
            set;
        }

    }
}
