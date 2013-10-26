#region head comment
/*
Code generate by JdSdkTool.
Copyright © starpeng@vip.qq.com
2013-10-26 10:25:41.83295 +08:00
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
    /// 获取用户收支列表，只能获取最近一周，最近一个月，最近三个月的信息 Response
    /// </summary>
    public class JingdongKuaicheAccountIncomeExpenseSearchResponse : JdResponse
    {
        /// <summary>
        /// 分页对象
        /// </summary>
        [XmlElement("page_info")]
        [JsonProperty("page_info")]
        public PageInfo PageInfo
        {
            get;
            set;
        }

    }
}
