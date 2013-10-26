#region head comment
/*
Code generate by JdSdkTool.
Copyright © starpeng@vip.qq.com
2013-07-29 22:39:04.00414 +08:00
*/
#endregion

using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using JdSdk.Domain;
using Newtonsoft.Json;

namespace JdSdk.Response
{
    /// <summary>
    /// 查询站长的结算单信息 Response
    /// </summary>
    public class JingdongUnionMasterBillSearchResponse : JdResponse
    {
        /// <summary>
        /// 结算数据
        /// </summary>
        [XmlElement("bill_list")]
        [JsonProperty("bill_list")]
        public List<MasterBillVo> BillList
        {
            get;
            set;
        }

        /// <summary>
        /// 总页数
        /// </summary>
        [XmlElement("page_total")]
        [JsonProperty("page_total")]
        public Nullable<Int64> PageTotal
        {
            get;
            set;
        }

        /// <summary>
        /// 页码
        /// </summary>
        [XmlElement("page_index")]
        [JsonProperty("page_index")]
        public Nullable<Int64> PageIndex
        {
            get;
            set;
        }

        /// <summary>
        /// 每页记录数
        /// </summary>
        [XmlElement("page_size")]
        [JsonProperty("page_size")]
        public Nullable<Int64> PageSize
        {
            get;
            set;
        }

    }
}
