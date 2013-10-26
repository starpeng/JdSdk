#region head comment
/*
Code generate by JdSdkTool.
Copyright © starpeng@vip.qq.com
2013-10-26 10:25:41.63094 +08:00
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
    /// 获得商家账户余额，可用余额，冻结金额信息 Response
    /// </summary>
    public class JingdongKuaicheAccountGetResponse : JdResponse
    {
        /// <summary>
        /// 账户信息
        /// </summary>
        [XmlElement("account")]
        [JsonProperty("account")]
        public AccountVO Account
        {
            get;
            set;
        }

    }
}
