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
    /// ResponseOrderOtherDetail属性
    /// </summary>
    [Serializable]
    public class ResponseOrderOtherDetail : JdObject
    {
        /// <summary>
        /// jos商品编码
        /// </summary>
        [XmlElement("josl_good_no")]
        [JsonProperty("josl_good_no")]
        public String JoslGoodNo
        {
            get;
            set;
        }

        /// <summary>
        /// isv商品编号
        /// </summary>
        [XmlElement("isv_good_no")]
        [JsonProperty("isv_good_no")]
        public String IsvGoodNo
        {
            get;
            set;
        }

        /// <summary>
        /// 实际出库数量
        /// </summary>
        [XmlElement("qty")]
        [JsonProperty("qty")]
        public Int64 Qty
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
