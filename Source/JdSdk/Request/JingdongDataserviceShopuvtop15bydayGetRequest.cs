#region head comment
/*
Code generate by JdSdkTool.
2013-12-21 10:56:33.11459 +08:00
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
    public class JingdongDataserviceShopuvtop15bydayGetRequest : JdRequestBase<JingdongDataserviceShopuvtop15bydayGetResponse>
    {
        public override String ApiName
        {
            get{ return "jingdong.dataservice.shopuvtop15byday.get"; }
        }

        protected override void PrepareParam(IDictionary<String, Object> paramters)
        {
        }

        public override void Validate()
        {
        }

    }
}
