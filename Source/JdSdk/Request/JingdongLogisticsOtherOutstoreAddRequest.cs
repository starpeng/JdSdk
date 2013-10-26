#region head comment
/*
Code generate by JdSdkTool.
Copyright © starpeng@vip.qq.com
2013-09-07 15:01:52.01354 +08:00
*/
#endregion

using System;
using System.Collections.Generic;
using JdSdk.Response;

namespace JdSdk.Request
{
    /// <summary>
    /// 其他出库订单下传 Request
    /// </summary>
    public class JingdongLogisticsOtherOutstoreAddRequest : JdRequestBase<JingdongLogisticsOtherOutstoreAddResponse>
    {
        public override String ApiName
        {
            get { return "jingdong.logistics.otherOutstore.add"; }
        }

        protected override void PrepareParam(IDictionary<String, Object> paramters)
        {
        }

        public override void Validate()
        {
        }

    }
}
