#region head comment
/*
Code generate by JdSdkTool.
Copyright © starpeng@vip.qq.com
2013-06-03 12:29:13.28888 +08:00
*/
#endregion

using System;
using System.Xml.Serialization;
using Newtonsoft.Json;

namespace JdSdk.Response
{
    /// <summary>
    /// 通过api 根据商品Id，销售属性值Id设置图片 Response
    /// </summary>
    public class WarePropimgUpdateResponse : JdResponse
    {
        /// <summary>
        /// 图片Id
        /// </summary>
        [XmlElement("image_id")]
        [JsonProperty("image_id")]
        public String ImageId
        {
            get;
            set;
        }

        /// <summary>
        /// 更改时间
        /// </summary>
        [XmlElement("created")]
        [JsonProperty("created")]
        public String Created
        {
            get;
            set;
        }

    }
}
