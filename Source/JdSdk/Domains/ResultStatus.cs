#region head comment
/*
Code generate by JdSdkTool.
2013-09-07 15:02:04.78427 +08:00
*/
#endregion

using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace JdSdk.Domain
{
    /// <summary>
    /// ResultStatus 属性
    /// </summary>
    [Serializable]
    public class ResultStatus : JdObject
    {
        /// <summary>
        /// 状态码：0：失败;1:成功
        /// </summary>
        /// <example>0</example>
        [XmlElement("code")]
        [JsonProperty("code")]
        public Int64 Code
        {
            get;
            set;
        }

        /// <summary>
        /// 失败信息描述
        /// </summary>
        /// <example>投放计划名称不能为空！</example>
        [XmlElement("message")]
        [JsonProperty("message")]
        public String Message
        {
            get;
            set;
        }

    }
}
