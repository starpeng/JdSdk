#region head comment
/*
Code generate by JdSdkTool.
Copyright © starpeng@vip.qq.com
2013-09-07 15:02:04.79327 +08:00
*/
#endregion

using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using Newtonsoft.Json;

namespace JdSdk.Domain
{
    /// <summary>
    /// ResultVO属性
    /// </summary>
    [Serializable]
    public class ResultVO : JdObject
    {
        /// <summary>
        /// 查询状态
        /// </summary>
        [XmlElement("successed")]
        [JsonProperty("successed")]
        public Boolean Successed
        {
            get;
            set;
        }

        /// <summary>
        /// 状态码，0成功，1失败
        /// </summary>
        [XmlElement("code")]
        [JsonProperty("code")]
        public Int64 Code
        {
            get;
            set;
        }

        /// <summary>
        /// 状态信息 ，成功时为空，失败时为失败原因
        /// </summary>
        [XmlElement("message")]
        [JsonProperty("message")]
        public String Message
        {
            get;
            set;
        }

        /// <summary>
        /// 类目对象列表
        /// </summary>
        [XmlElement("result")]
        [JsonProperty("result")]
        public List<CategoryCommisionVO> Result
        {
            get;
            set;
        }

    }
}
