#region head comment
/*
Code generate by JdSdkTool.
Copyright © starpeng@vip.qq.com
2013-10-26 10:25:32.52042 +08:00
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
    /// 查询某个商品的限购区域。 Request
    /// </summary>
    public class WareAreaLimitSearchRequest : JdRequestBase<WareAreaLimitSearchResponse>
    {
        /// <summary>
        /// 商品id，必选
        /// </summary>
        /// <example>1311</example>
        [XmlElement("ware_id")]
        [JsonProperty("ware_id")]
        public String WareId
        {
            get;
            set;
        }

        /// <summary>
        /// 业务类型,1:限购，目前只支持限购
        /// </summary>
        [XmlElement("type")]
        [JsonProperty("type")]
        public String Type
        {
            get;
            set;
        }

        /// <summary>
        /// 商家希望返回的限购区域的信息字段, 可选值: WareAreaLimit数据结构中的以下字段:      order_id,vender_id, area_fid等每个字段以逗号分隔
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
            get{ return "360buy.ware.area.limit.search"; }
        }

        protected override void PrepareParam(IDictionary<String, Object> paramters)
        {
            paramters.Add("ware_id" ,this.WareId);
            paramters.Add("type" ,this.Type);
            paramters.Add("fields" ,this.Fields);
        }

        public override void Validate()
        {
            RequestValidator.ValidateRequired("ware_id", this.WareId);
            RequestValidator.ValidateRequired("type", this.Type);
        }

    }
}
