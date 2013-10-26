#region head comment
/*
Code generate by JdSdkTool.
Copyright © starpeng@vip.qq.com
2013-10-26 10:25:50.76747 +08:00
*/
#endregion

using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace JdSdk.Domain
{
    /// <summary>
    /// ResultStatus属性
    /// </summary>
    [Serializable]
    public class ResultStatus : JdObject
    {
        /// <summary>
        /// 成功创建推广计划时返回的推广计划id
        /// </summary>
        /// <example>123456</example>
        [XmlElement("plan_id")]
        [JsonProperty("plan_id")]
        public Int64 PlanId
        {
            get;
            set;
        }

        /// <summary>
        /// 状态码，取值为0和10：表示创建推广计划失败;1: 表示创建推广计划成功
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
        /// 创建推广计划失败时的信息描述。
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
