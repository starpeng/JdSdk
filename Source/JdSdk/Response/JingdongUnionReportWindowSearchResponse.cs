#region head comment
/*
Code generate by JdSdkTool.
2013-07-29 22:39:06.02526 +08:00
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
    /// 获取专柜推广报表详细信息 Response
    /// </summary>
    public class JingdongUnionReportWindowSearchResponse : JdResponse
    {
        /// <summary>
        /// 查询结果集合
        /// </summary>
        [XmlElement("datas")]
        [JsonProperty("datas")]
        public List<WindowAdvDetail> Datas
        {
            get;
            set;
        }

        /// <summary>
        /// 页码
        /// </summary>
        [XmlElement("page_index")]
        [JsonProperty("page_index")]
        public Nullable<Decimal> PageIndex
        {
            get;
            set;
        }

        /// <summary>
        /// 每页数据条数
        /// </summary>
        [XmlElement("page_size")]
        [JsonProperty("page_size")]
        public Nullable<Decimal> PageSize
        {
            get;
            set;
        }

        /// <summary>
        /// 是否成功
        /// </summary>
        /// <example>true,false</example>
        [XmlElement("success")]
        [JsonProperty("success")]
        public Nullable<Boolean> Success
        {
            get;
            set;
        }

        /// <summary>
        /// 操作结果描述
        /// </summary>
        /// <example>操作成功!</example>
        [XmlElement("message")]
        [JsonProperty("message")]
        public String Message
        {
            get;
            set;
        }

    }
}
