#region head comment
/*
Code generate by JdSdkTool.
Copyright © starpeng@vip.qq.com
2013-10-26 10:25:32.72243 +08:00
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
    /// 设置某个商品的限购区域。 Response
    /// </summary>
    public class WareAreaLimitUpdateResponse : JdResponse
    {
        /// <summary>
        /// 商品编号
        /// </summary>
        [XmlElement("wareId")]
        [JsonProperty("wareId")]
        public Int64 WareId
        {
            get;
            set;
        }

    }
}
