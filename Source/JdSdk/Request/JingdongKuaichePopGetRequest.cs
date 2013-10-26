#region head comment
/*
Code generate by JdSdkTool.
Copyright © starpeng@vip.qq.com
2013-10-26 10:25:42.64200 +08:00
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
    /// 经用户授权后，可以获得商家在快车系统的用户信息。 Request
    /// </summary>
    public class JingdongKuaichePopGetRequest : JdRequestBase<JingdongKuaichePopGetResponse>
    {

        public override String ApiName
        {
            get{ return "jingdong.kuaiche.pop.get"; }
        }

        protected override void PrepareParam(IDictionary<String, Object> paramters)
        {
        }

        public override void Validate()
        {
        }

    }
}
