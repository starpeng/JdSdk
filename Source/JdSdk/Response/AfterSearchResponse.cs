#region head comment
/*
Code generate by JdSdkTool.
Copyright © starpeng@vip.qq.com
2013-10-26 10:25:31.50936 +08:00
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
    /// 根据条件检索订单信息（仅适用于京东售后，即由京东代为收取退货商品的售后方式） Response
    /// </summary>
    public class AfterSearchResponse : JdResponse
    {
        /// <summary>
        /// 退货信息
        /// </summary>
        [XmlElement("after")]
        [JsonProperty("after")]
        public AfterSearch After
        {
            get;
            set;
        }

    }
}
