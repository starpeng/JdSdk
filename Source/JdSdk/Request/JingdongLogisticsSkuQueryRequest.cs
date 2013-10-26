#region head comment
/*
Code generate by JdSdkTool.
Copyright © starpeng@vip.qq.com
2013-09-07 15:01:53.63063 +08:00
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
    /// 查询商品信息接口 Request
    /// </summary>
    public class JingdongLogisticsSkuQueryRequest : JdRequestBase<JingdongLogisticsSkuQueryResponse>
    {
        /// <summary>
        /// josl商品编号
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

        public override String ApiName
        {
            get { return "jingdong.logistics.sku.query"; }
        }

        protected override void PrepareParam(IDictionary<String, Object> paramters)
        {

            paramters.Add("josl_good_no", this.JoslGoodNo);
            paramters.Add("isv_good_no", this.IsvGoodNo);

        }

        public override void Validate()
        {
        }

    }
}
