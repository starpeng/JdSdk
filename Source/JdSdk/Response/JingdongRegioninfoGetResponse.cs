#region head comment
/*
Code generate by JdSdkTool.
2013-04-03 12:45:23.12566 +08:00
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
    /// 获取地区信息 Response
    /// </summary>
    public class JingdongRegioninfoGetResponse : JdResponse
    {
        /// <summary>
        /// 商品信息
        /// </summary>
        [XmlElement("regions")]
        [JsonProperty("regions")]
        public List<Region> Regions
        {
            get;
            set;
        }

    }
}
