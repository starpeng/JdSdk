#region head comment
/*
Code generate by JdSdkTool.
Copyright © starpeng@vip.qq.com
2013-09-07 15:01:54.03466 +08:00
*/
#endregion

using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using JdSdk.Response;
using Newtonsoft.Json;

namespace JdSdk.Request
{
    /// <summary>
    /// 商家查询库存 Request
    /// </summary>
    public class JingdongLogisticsStockSearchRequest : JdRequestBase<JingdongLogisticsStockSearchResponse>
    {
        /// <summary>
        /// 库房编号
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
        /// 当前页码
        /// </summary>
        [XmlElement("current_page")]
        [JsonProperty("current_page")]
        public Int64 CurrentPage
        {
            get;
            set;
        }

        public override String ApiName
        {
            get { return "jingdong.logistics.stock.search"; }
        }

        protected override void PrepareParam(IDictionary<String, Object> paramters)
        {

            paramters.Add("warehouse_no", this.WarehouseNo);
            paramters.Add("goods_no", this.GoodsNo);
            paramters.Add("current_page", this.CurrentPage);

        }

        public override void Validate()
        {
            RequestValidator.ValidateRequired("current_page", this.CurrentPage);
        }

    }
}
