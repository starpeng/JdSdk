#region head comment
/*
Code generate by JdSdkTool.
Copyright © starpeng@vip.qq.com
2013-09-07 15:01:56.46480 +08:00
*/
#endregion

using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using Newtonsoft.Json;

namespace JdSdk.Response
{
    /// <summary>
    /// 添加促销道具, 道具类型允许组合，但不允许重复(相同类型的道具，最后一次添加有效，只适用于单品促销) Response
    /// </summary>
    public class JingdongSellerPromotionPropAddResponse : JdResponse
    {
        /// <summary>
        /// 生效的促销道具编号列表
        /// </summary>
        /// <example>654321</example>
        [XmlElement("ids")]
        [JsonProperty("ids")]
        public List<Int64> Ids
        {
            get;
            set;
        }
    }
}
