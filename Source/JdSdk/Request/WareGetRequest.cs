#region head comment
/*
Code generate by JdSdkTool.
Copyright © starpeng@vip.qq.com
2013-06-03 12:29:12.47783 +08:00
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
    /// 通过api接口，输入单个商品id，得到所有相关商品的全部信息 Request
    /// </summary>
    public class WareGetRequest : JdRequestBase<WareGetResponse>
    {
        /// <summary>
        /// 需返回的字段列表。可选值：ware结构体中的所有字段；字段之间用","分隔
        /// </summary>
        /// <example>ware_id,spu_idcid,created</example>
        [XmlElement("fields")]
        [JsonProperty("fields")]
        public String Fields
        {
            get;
            set;
        }

        /// <summary>
        /// 商品的id
        /// </summary>
        /// <example>1100000015</example>
        [XmlElement("ware_id")]
        [JsonProperty("ware_id")]
        public Int64 WareId
        {
            get;
            set;
        }

        public override String ApiName
        {
            get { return "360buy.ware.get"; }
        }

        protected override void PrepareParam(IDictionary<String, Object> paramters)
        {

            paramters.Add("fields", this.Fields);
            paramters.Add("ware_id", this.WareId);

        }

        public override void Validate()
        {
            RequestValidator.ValidateRequired("ware_id", this.WareId);
        }

    }
}
