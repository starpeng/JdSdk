#region head comment
/*
Code generate by JdSdkTool.
Copyright © starpeng@vip.qq.com
2013-09-07 15:02:04.78927 +08:00
*/
#endregion

using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using Newtonsoft.Json;

namespace JdSdk.Domain
{
    /// <summary>
    /// ResponseStock属性
    /// </summary>
    [Serializable]
    public class ResponseStock : JdObject
    {
        /// <summary>
        /// 处理结果code 1:为成功,其他均为错误
        /// </summary>
        /// <example>1</example>
        [XmlElement("process_code")]
        [JsonProperty("process_code")]
        public String ProcessCode
        {
            get;
            set;
        }

        /// <summary>
        /// 处理状态 含义
        /// </summary>
        /// <example>1</example>
        [XmlElement("process_status")]
        [JsonProperty("process_status")]
        public String ProcessStatus
        {
            get;
            set;
        }

        /// <summary>
        /// 处理错误信息
        /// </summary>
        /// <example>1</example>
        [XmlElement("error_message")]
        [JsonProperty("error_message")]
        public String ErrorMessage
        {
            get;
            set;
        }

        /// <summary>
        /// 总页数
        /// </summary>
        /// <example>32</example>
        [XmlElement("total_page")]
        [JsonProperty("total_page")]
        public Int64 TotalPage
        {
            get;
            set;
        }

        /// <summary>
        /// 查询结果详细信息
        /// </summary>
        /// <example>32</example>
        [XmlElement("stock_details")]
        [JsonProperty("stock_details")]
        public List<StockDetail> StockDetails
        {
            get;
            set;
        }

    }
}
