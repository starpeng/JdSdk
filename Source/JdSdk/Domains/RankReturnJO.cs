#region head comment
/*
Code generate by JdSdkTool.
Copyright © starpeng@vip.qq.com
2013-10-26 10:25:50.76547 +08:00
*/
#endregion

using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace JdSdk.Domain
{
    /// <summary>
    /// RankReturnJO属性
    /// </summary>
    [Serializable]
    public class RankReturnJO : JdObject
    {
        /// <summary>
        /// 标记码 （0：成功  1：参数错误 无法计算  2：服务器错误）
        /// </summary>
        /// <example>否</example>
        [XmlElement("response")]
        [JsonProperty("response")]
        public Int64 Response
        {
            get;
            set;
        }

        /// <summary>
        /// 排名信息按照1-n排序
        /// </summary>
        /// <example>否</example>
        [XmlElement("rank")]
        [JsonProperty("rank")]
        public List<Int64> Rank
        {
            get;
            set;
        }

        /// <summary>
        /// 参数描述reponse为1时，description有3种情况：Zero Rank：表示改预测计划的质量分为0，不能预测 Incorrect Parameter：表示参数出错No other biddings to compare：表示没有别的计划竞价
        /// </summary>
        /// <example>否</example>
        [XmlElement("description")]
        [JsonProperty("description")]
        public String Description
        {
            get;
            set;
        }

        /// <summary>
        /// 预测日期
        /// </summary>
        /// <example>否</example>
        [XmlElement("plan_date")]
        [JsonProperty("plan_date")]
        public String PlanDate
        {
            get;
            set;
        }

    }
}
