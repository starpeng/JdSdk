#region head comment
/*
Code generate by JdSdkTool.
Copyright © starpeng@vip.qq.com
2013-09-07 15:01:54.84670 +08:00
*/
#endregion

using System;
using System.Xml.Serialization;
using Newtonsoft.Json;

namespace JdSdk.Response
{
    /// <summary>
    /// 限单品、赠品促销调用此接口，所有参数适用于单品促销，赠品促销只限设置单次最少购买数量有效（(多次调用时，最后一次规则有效)） Response
    /// </summary>
    public class JingdongSellerPromotionActivitymodeAddResponse : JdResponse
    {
        /// <summary>
        /// 活动规则编号，如果数据保存成功，则返回活动规则编号，否则返回null
        /// </summary>
        /// <example>654321</example>
        [XmlElement("id")]
        [JsonProperty("id")]
        public Int64 Id
        {
            get;
            set;
        }

    }
}
