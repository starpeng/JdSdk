#region head comment
/*
Code generate by JdSdkTool.
2013-01-31 10:56:47:858 +08:00
*/
#endregion

using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace JdSdk.Domain
{
    /// <summary>
    /// ReturnInfo结构
    /// </summary>
    [Serializable]
    public class ReturnInfo : JdObject
    {
        /// <summary>
        /// 退货单号
        /// </summary>
        [XmlElement("return_id")]
        [JsonProperty("return_id")]
        public String ReturnId
        {
            get;
            set;
        }

        /// <summary>
        /// 商家编号
        /// </summary>
        [XmlElement("vender_id")]
        [JsonProperty("vender_id")]
        public String VenderId
        {
            get;
            set;
        }

        /// <summary>
        /// 发货类型
        /// </summary>
        [XmlElement("send_type")]
        [JsonProperty("send_type")]
        public String SendType
        {
            get;
            set;
        }

        /// <summary>
        /// 收货状态:待收获WAITING、已收货RECEIVED
        /// </summary>
        [XmlElement("receive_state")]
        [JsonProperty("receive_state")]
        public String ReceiveState
        {
            get;
            set;
        }

        /// <summary>
        /// 商家联系人姓名
        /// </summary>
        [XmlElement("linkman")]
        [JsonProperty("linkman")]
        public String Linkman
        {
            get;
            set;
        }

        /// <summary>
        /// 商家联系人电话
        /// </summary>
        [XmlElement("phone")]
        [JsonProperty("phone")]
        public String Phone
        {
            get;
            set;
        }

        /// <summary>
        /// 商家收货地址
        /// </summary>
        [XmlElement("return_address")]
        [JsonProperty("return_address")]
        public String ReturnAddress
        {
            get;
            set;
        }

        /// <summary>
        /// 实际收货人
        /// </summary>
        [XmlElement("consignee")]
        [JsonProperty("consignee")]
        public String Consignee
        {
            get;
            set;
        }

        /// <summary>
        /// 京东的发货人姓名
        /// </summary>
        [XmlElement("consignor")]
        [JsonProperty("consignor")]
        public String Consignor
        {
            get;
            set;
        }

        /// <summary>
        /// 发货的时间
        /// </summary>
        [XmlElement("send_time")]
        [JsonProperty("send_time")]
        public String SendTime
        {
            get;
            set;
        }

        /// <summary>
        /// 收货的时间
        /// </summary>
        [XmlElement("receive_time")]
        [JsonProperty("receive_time")]
        public String ReceiveTime
        {
            get;
            set;
        }

        /// <summary>
        /// 更新时间
        /// </summary>
        [XmlElement("modifid_time")]
        [JsonProperty("modifid_time")]
        public String ModifidTime
        {
            get;
            set;
        }

        /// <summary>
        /// 货物信息列表
        /// </summary>
        [XmlElement("return_item_list")]
        [JsonProperty("return_item_list")]
        public List<ReturnItem> ReturnItemList
        {
            get;
            set;
        }

    }
}
