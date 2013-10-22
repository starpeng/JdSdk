#region head comment
/*
Code generate by JdSdkTool.
2013-09-07 15:02:02.72915 +08:00
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
    public class JingdongWarePacksGetRequest : JdRequestBase<JingdongWarePacksGetResponse>
    {
        public override String ApiName
        {
            get { return "jingdong.ware.packs.get"; }
        }

        protected override void PrepareParam(IDictionary<String, Object> paramters)
        {


        }

        public override void Validate()
        {
        }

    }
}
