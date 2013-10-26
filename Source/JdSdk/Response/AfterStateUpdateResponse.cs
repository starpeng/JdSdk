#region head comment
/*
Code generate by JdSdkTool.
Copyright © starpeng@vip.qq.com
2013-10-26 10:25:31.71038 +08:00
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
    /// 根据退货单id 进行退货确认操作 Response
    /// </summary>
    public class AfterStateUpdateResponse : JdResponse
    {
        /// <summary>
        /// return_id
        /// </summary>
        [XmlElement("return_id")]
        [JsonProperty("return_id")]
        public String ReturnId
        {
            get;
            set;
        }

        /// <summary>
        /// 商家ID
        /// </summary>
        [XmlElement("vender_id")]
        [JsonProperty("vender_id")]
        public String VenderId
        {
            get;
            set;
        }

        /// <summary>
        /// 售后确认操作时间
        /// </summary>
        /// <example>2011-06-22 10:14:45</example>
        [XmlElement("modified")]
        [JsonProperty("modified")]
        public String Modified
        {
            get;
            set;
        }

    }
}
