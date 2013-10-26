#region head comment
/*
Code generate by JdSdkTool.
Copyright © starpeng@vip.qq.com
2013-07-29 23:04:28.12232 +08:00
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
    /// 查询商家基本信息，包括商家编号、商家类型、店铺编号、店铺名称、主营类目编号。 Request
    /// </summary>
    public class JingdongSellerVenderInfoGetRequest : JdRequestBase<JingdongSellerVenderInfoGetResponse>
    {
        /// <summary>
        /// ext_json_param暂时无意义。因此此接口无需输入应用级参数，但需要构建空参数360buy_param_json={}
        /// </summary>
        [XmlElement("ext_json_param")]
        [JsonProperty("ext_json_param")]
        public String ExtJsonParam
        {
            get;
            set;
        }

        public override String ApiName
        {
            get { return "jingdong.seller.vender.info.get"; }
        }

        protected override void PrepareParam(IDictionary<String, Object> paramters)
        {


        }

        public override void Validate()
        {
        }

    }
}
