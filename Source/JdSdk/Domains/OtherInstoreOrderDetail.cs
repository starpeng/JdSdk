#region head comment
/*
Code generate by JdSdkTool.
Copyright © starpeng@vip.qq.com
2013-09-07 15:02:04.78627 +08:00
*/
#endregion

using System;
using System.Xml.Serialization;
using Newtonsoft.Json;

namespace JdSdk.Domain
{
    /// <summary>
    /// OtherInstoreOrderDetail属性
    /// </summary>
    [Serializable]
    public class OtherInstoreOrderDetail : JdObject
    {
        /// <summary>
        /// jos商品编码
        /// </summary>
        [XmlElement("goods_no")]
        [JsonProperty("goods_no")]
        public String GoodsNo
        {
            get;
            set;
        }

        /// <summary>
        /// 差异描述
        /// </summary>
        [XmlElement("difference_remark")]
        [JsonProperty("difference_remark")]
        public String DifferenceRemark
        {
            get;
            set;
        }

        /// <summary>
        /// 商品状态
        /// </summary>
        [XmlElement("goods_status")]
        [JsonProperty("goods_status")]
        public String GoodsStatus
        {
            get;
            set;
        }

    }
}
