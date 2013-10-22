#region head comment
/*
Code generate by JdSdkTool.
2013-09-07 15:02:02.32513 +08:00
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
    public class JingdongWareCombineListGetRequest : JdRequestBase<JingdongWareCombineListGetResponse>
    {
        public override String ApiName
        {
            get { return "jingdong.ware.combine.list.get"; }
        }

        protected override void PrepareParam(IDictionary<String, Object> paramters)
        {


        }

        public override void Validate()
        {
        }

    }
}
