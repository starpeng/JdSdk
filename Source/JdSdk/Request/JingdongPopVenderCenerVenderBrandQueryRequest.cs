#region head comment
/*
Code generate by JdSdkTool.
2013-12-21 10:56:47.98521 +08:00
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
    /// 查询商家已授权的品牌 Request
    /// </summary>
    public class JingdongPopVenderCenerVenderBrandQueryRequest : JdRequestBase<JingdongPopVenderCenerVenderBrandQueryResponse>
    {
        public override String ApiName
        {
            get{ return "jingdong.pop.vender.cener.venderBrand.query"; }
        }

        protected override void PrepareParam(IDictionary<String, Object> paramters)
        {
        }

        public override void Validate()
        {
        }

    }
}
