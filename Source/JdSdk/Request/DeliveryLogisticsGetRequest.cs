#region head comment
/*
Code generate by JdSdkTool.
Copyright © starpeng@vip.qq.com
2013-01-31 10:56:41:970 +08:00
*/
#endregion

using System;
using System.Collections.Generic;
using JdSdk.Response;

namespace JdSdk.Request
{
    /// <summary>
    /// 检索商家物流公司信息 Request
    /// </summary>
    public class DeliveryLogisticsGetRequest : JdRequestBase<DeliveryLogisticsGetResponse>
    {
        public override String ApiName
        {
            get { return "360buy.delivery.logistics.get"; }
        }

        protected override void PrepareParam(IDictionary<String, Object> paramters)
        {


        }

        public override void Validate()
        {
        }

    }
}
