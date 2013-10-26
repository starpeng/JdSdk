#region head comment
/*
Code generate by JdSdkTool.
Copyright © starpeng@vip.qq.com
2013-06-03 12:29:13.49289 +08:00
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
    /// 通过api 根据商品Id，销售属性值Id查询图片 Response
    /// </summary>
    public class WarePropimgsGetResponse : JdResponse
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
