#region head comment
/*
Code generate by JdSdkTool.
Copyright © starpeng@vip.qq.com
2013-04-03 12:45:24.13772 +08:00
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
    /// 搜索商品信息。 Request
    /// </summary>
    public class JingdongWareGetRequest : JdRequestBase<JingdongWareGetResponse>
    {
        /// <summary>
        /// 商品id
        /// </summary>
        [XmlElement("ware_id")]
        [JsonProperty("ware_id")]
        public Int64 WareId
        {
            get;
            set;
        }

        /// <summary>
        /// 搜索关键字
        /// </summary>
        [XmlElement("region_id")]
        [JsonProperty("region_id")]
        public Int64 RegionId
        {
            get;
            set;
        }

        /// <summary>
        /// 返回字段信息。支持的值：ware_id, title, jd_price,  ware_imgs, skus
        /// </summary>
        [XmlElement("fields")]
        [JsonProperty("fields")]
        public String Fields
        {
            get;
            set;
        }

        public override String ApiName
        {
            get { return "jingdong.ware.get"; }
        }

        protected override void PrepareParam(IDictionary<String, Object> paramters)
        {

            paramters.Add("ware_id", this.WareId);
            paramters.Add("region_id", this.RegionId);
            paramters.Add("fields", this.Fields);

        }

        public override void Validate()
        {
            RequestValidator.ValidateRequired("ware_id", this.WareId);
            RequestValidator.ValidateRequired("region_id", this.RegionId);
        }

    }
}
