#region head comment
/*
Code generate by JdSdkTool.
Copyright © starpeng@vip.qq.com
2013-10-26 10:25:38.38976 +08:00
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
    /// 查询客服组信息 Response
    /// </summary>
    public class JingdongImPopGroupinfoGetResponse : JdResponse
    {
        /// <summary>
        /// 店铺名字
        /// </summary>
        /// <example></example>
        [XmlElement("shopName")]
        [JsonProperty("shopName")]
        public String ShopName
        {
            get;
            set;
        }

        /// <summary>
        /// 店铺主页
        /// </summary>
        /// <example></example>
        [XmlElement("shopUrl")]
        [JsonProperty("shopUrl")]
        public String ShopUrl
        {
            get;
            set;
        }

        /// <summary>
        /// 客服数量
        /// </summary>
        /// <example></example>
        [XmlElement("waiterCount")]
        [JsonProperty("waiterCount")]
        public Int64 WaiterCount
        {
            get;
            set;
        }

        /// <summary>
        /// 客服列表
        /// </summary>
        /// <example></example>
        [XmlElement("waiterList")]
        [JsonProperty("waiterList")]
        public List<Waiter> WaiterList
        {
            get;
            set;
        }

    }
}
