#region head comment
/*
Code generate by JdSdkTool.
2013-12-21 10:56:33.92578 +08:00
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
    ///  Request
    /// </summary>
    public class JingdongDataserviceShopvistop15bymonthGetRequest : JdRequestBase<JingdongDataserviceShopvistop15bymonthGetResponse>
    {
        public override String ApiName
        {
            get{ return "jingdong.dataservice.shopvistop15bymonth.get"; }
        }

        protected override void PrepareParam(IDictionary<String, Object> paramters)
        {
        }

        public override void Validate()
        {
        }

    }
}
