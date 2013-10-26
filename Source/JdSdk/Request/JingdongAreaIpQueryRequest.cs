#region head comment
/*
Code generate by JdSdkTool.
Copyright © starpeng@vip.qq.com
2013-09-07 15:01:44.12209 +08:00
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
    public class JingdongAreaIpQueryRequest : JdRequestBase<JingdongAreaIpQueryResponse>
    {
        public override String ApiName
        {
            get { return "jingdong.area.ip.query"; }
        }

        protected override void PrepareParam(IDictionary<String, Object> paramters)
        {


        }

        public override void Validate()
        {
        }

    }
}
