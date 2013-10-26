#region head comment
/*
Code generate by JdSdkTool.
Copyright © starpeng@vip.qq.com
2013-09-07 15:01:43.71807 +08:00
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
    public class JingdongAreaCityGetRequest : JdRequestBase<JingdongAreaCityGetResponse>
    {
        public override String ApiName
        {
            get { return "jingdong.area.city.get"; }
        }

        protected override void PrepareParam(IDictionary<String, Object> paramters)
        {


        }

        public override void Validate()
        {
        }

    }
}
