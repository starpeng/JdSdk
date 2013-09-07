#region head comment
/*
Code generate by JdSdkTool.
2013-09-07 15:01:54.03466 +08:00
*/
#endregion

using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using JdSdk.Domain;
using JdSdk.Response;

namespace JdSdk.Request
{
    /// <summary>
    /// 商家查询库存 Request
    /// </summary>
    public class JingdongLogisticsStockSearchRequest : IJdRequest<JingdongLogisticsStockSearchResponse>
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

        public String ApiName
        {
            get{ return "jingdong.logistics.stock.search"; }
        }

        public String GetParamJson()
        {
            Dictionary<String, Object> paramters = new Dictionary<string, object>();
            paramters.Add("warehouse_no" ,this.WarehouseNo);
            paramters.Add("goods_no" ,this.GoodsNo);
            paramters.Add("current_page" ,this.CurrentPage);
            return JsonConvert.SerializeObject(paramters, JdUtils.GetJsonConverters());
        }

        public void Validate()
        {
            RequestValidator.ValidateRequired("current_page", this.CurrentPage);
        }

    }
}
