#region head comment
/*
Code generate by JdSdkTool.
2013-12-21 10:56:34.53393 +08:00
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
    public class JingdongDataserviceShopvoltop15bymonthGetRequest : JdRequestBase<JingdongDataserviceShopvoltop15bymonthGetResponse>
    {
        public override String ApiName
        {
            get{ return "jingdong.dataservice.shopvoltop15bymonth.get"; }
        }

        protected override void PrepareParam(IDictionary<String, Object> paramters)
        {
        }

        public override void Validate()
        {
        }

    }
}
