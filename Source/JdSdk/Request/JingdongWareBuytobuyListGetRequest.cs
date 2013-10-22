#region head comment
/*
Code generate by JdSdkTool.
2013-09-07 15:02:02.12312 +08:00
*/
#endregion

using System;
using System.Collections.Generic;
using JdSdk.Response;

namespace JdSdk.Request
{
    /// <summary>
    ///  Request
    /// </summary>
    public class JingdongWareBuytobuyListGetRequest : JdRequestBase<JingdongWareBuytobuyListGetResponse>
    {
        public override String ApiName
        {
            get { return "jingdong.ware.buytobuy.list.get"; }
        }

        protected override void PrepareParam(IDictionary<String, Object> paramters)
        {


        }

        public override void Validate()
        {
        }

    }
}
