#region CopyRight
/**************************************************************
   Copyright (c) 2013 StarPeng. All rights reserved.
   CLR版本        :    4.0.30319.18052
   命名空间名称   :    JdSdk.Domains
   文件名         :    StockDetail
   创建时间       :    2013/9/7 17:46:44
   用户所在的域   :    XPC
   登录用户名     :    Star
   文件描述       :    
   版本           :    1.0.0
   历史           :    
   最后更新人     :   
   最后更新时间   :   
 **************************************************************/
#endregion CopyRight

using System;
using System.Xml.Serialization;
using Newtonsoft.Json;

namespace JdSdk.Domain
{
    /// <summary>
    /// 库存详情
    /// </summary>
    public class StockDetail
    {
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
        /// 仓库编号
        /// </summary>
        [XmlElement("warehouse_no")]
        [JsonProperty("warehouse_no")]
        public String WarehouseNo
        {
            get;
            set;
        }

        /// <summary>
        /// 商品编号
        /// </summary>
        [XmlElement("goods_no")]
        [JsonProperty("goods_no")]
        public String GoodsNo
        {
            get;
            set;
        }

        /// <summary>
        /// 可用数量
        /// </summary>
        [XmlElement("available_qty")]
        [JsonProperty("available_qty")]
        public String AvailableQty
        {
            get;
            set;
        }

        /// <summary>
        /// 占用数量
        /// </summary>
        [XmlElement("preemption_qty")]
        [JsonProperty("preemption_qty")]
        public String PreemptionQty
        {
            get;
            set;
        }

        /// <summary>
        /// 库存数量
        /// </summary>
        [XmlElement("stock_qty")]
        [JsonProperty("stock_qty")]
        public String StockQty
        {
            get;
            set;
        }
    }
}
