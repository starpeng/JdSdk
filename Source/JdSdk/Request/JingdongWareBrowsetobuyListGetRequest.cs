#region head comment
/*
Code generate by JdSdkTool.
2013-09-07 15:02:01.92011 +08:00
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
    public class JingdongWareBrowsetobuyListGetRequest : JdRequestBase<JingdongWareBrowsetobuyListGetResponse>
    {
        public override String ApiName
        {
            get { return "jingdong.ware.browsetobuy.list.get"; }
        }

        protected override void PrepareParam(IDictionary<String, Object> paramters)
        {


        }

        public override void Validate()
        {
        }

    }
}
