#region head comment
/*
Code generate by JdSdkTool.
2013-12-21 10:56:55.90914 +08:00
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
    /// 查询商家店铺基本信息，包括商家编号，店铺编号，店铺名称，开店时间，logoUrl，店铺简介，主营类目编号，主营类目名称 Request
    /// </summary>
    public class JingdongVenderShopQueryRequest : JdRequestBase<JingdongVenderShopQueryResponse>
    {
        public override String ApiName
        {
            get{ return "jingdong.vender.shop.query"; }
        }

        protected override void PrepareParam(IDictionary<String, Object> paramters)
        {
        }

        public override void Validate()
        {
        }

    }
}
