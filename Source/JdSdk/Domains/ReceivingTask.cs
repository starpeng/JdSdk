#region head comment
/*
Code generate by JdSdkTool.
Copyright © starpeng@vip.qq.com
2013-09-07 15:02:04.78727 +08:00
*/
#endregion

using System;
using System.Xml.Serialization;
using Newtonsoft.Json;

namespace JdSdk.Domain
{
    /// <summary>
    /// ReceivingTask属性
    /// </summary>
    [Serializable]
    public class ReceivingTask : JdObject
    {
        /// <summary>
        /// JOSL唯一编号
        /// </summary>
        [XmlElement("goods_no")]
        [JsonProperty("goods_no")]
        public String GoodsNo
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

        /// <summary>
        /// 实际验收数量
        /// </summary>
        [XmlElement("qty")]
        [JsonProperty("qty")]
        public Int64 Qty
        {
            get;
            set;
        }

        /// <summary>
        /// 预期数量
        /// </summary>
        [XmlElement("expected_qty")]
        [JsonProperty("expected_qty")]
        public Int64 ExpectedQty
        {
            get;
            set;
        }

        /// <summary>
        /// 差异备注
        /// </summary>
        [XmlElement("difference_remark")]
        [JsonProperty("difference_remark")]
        public String DifferenceRemark
        {
            get;
            set;
        }

    }
}
