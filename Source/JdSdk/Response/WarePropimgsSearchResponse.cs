#region head comment
/*
Code generate by JdSdkTool.
Copyright © starpeng@vip.qq.com
2013-09-07 15:01:41.29393 +08:00
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
    /// 根据商品Id，检索商品主图 Response
    /// </summary>
    public class WarePropimgsSearchResponse : JdResponse
    {
        /// <summary>
        /// 图片信息
        /// </summary>
        [XmlElement("propimgs")]
        [JsonProperty("propimgs")]
        public List<WarePropimg> Propimgs
        {
            get;
            set;
        }

        /// <summary>
        /// 图片信息数量
        /// </summary>
        [XmlElement("total")]
        [JsonProperty("total")]
        public Int64 Total
        {
            get;
            set;
        }

    }
}
