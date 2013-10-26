#region head comment
/*
Code generate by JdSdkTool.
Copyright © starpeng@vip.qq.com
2013-09-07 15:01:50.59746 +08:00
*/
#endregion

using System;
using System.Collections.Generic;
using JdSdk.Response;

namespace JdSdk.Request
{
    /// <summary>
    /// 获取承运商信息列表 Request
    /// </summary>
    public class JingdongLogisticsCarriersListRequest : JdRequestBase<JingdongLogisticsCarriersListResponse>
    {
        public override String ApiName
        {
            get { return "jingdong.logistics.carriers.list"; }
        }

        protected override void PrepareParam(IDictionary<String, Object> paramters)
        {
        }

        public override void Validate()
        {
        }

    }
}
