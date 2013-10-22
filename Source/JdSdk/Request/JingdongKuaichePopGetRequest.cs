#region head comment
/*
Code generate by JdSdkTool.
2013-08-02 16:22:54.45469 +08:00
*/
#endregion

using System;
using System.Collections.Generic;
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
            get { return "jingdong.kuaiche.pop.get"; }
        }

        protected override void PrepareParam(IDictionary<String, Object> paramters)
        {


        }

        public override void Validate()
        {
        }

    }
}
