#region head comment
/*
Code generate by JdSdkTool.
Copyright © starpeng@vip.qq.com
2013-10-26 10:25:42.03597 +08:00
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
    /// 查询月账单明细 Response
    /// </summary>
    public class JingdongKuaicheBillDetailsSearchResponse : JdResponse
    {
        /// <summary>
        /// 结算明细集合
        /// </summary>
        [XmlElement("list")]
        [JsonProperty("list")]
        public List<BillDetailVO> List
        {
            get;
            set;
        }

    }
}
