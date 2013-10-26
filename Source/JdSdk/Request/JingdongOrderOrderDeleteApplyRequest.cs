#region head comment
/*
Code generate by JdSdkTool.
Copyright © starpeng@vip.qq.com
2013-10-26 10:25:45.47916 +08:00
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
    /// 删单申请 Request
    /// </summary>
    public class JingdongOrderOrderDeleteApplyRequest : JdRequestBase<JingdongOrderOrderDeleteApplyResponse>
    {
        public override String ApiName
        {
            get{ return "jingdong.order.orderDelete.apply"; }
        }

        protected override void PrepareParam(IDictionary<String, Object> paramters)
        {
        }

        public override void Validate()
        {
        }

    }
}
