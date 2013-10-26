#region head comment
/*
Code generate by JdSdkTool.
Copyright © starpeng@vip.qq.com
2013-09-07 15:01:54.24067 +08:00
*/
#endregion

using System;
using System.Collections.Generic;
using JdSdk.Response;

namespace JdSdk.Request
{
    /// <summary>
    /// 获取仓库信息列表 Request
    /// </summary>
    public class JingdongLogisticsWarehouseListRequest : JdRequestBase<JingdongLogisticsWarehouseListResponse>
    {
        public override String ApiName
        {
            get { return "jingdong.logistics.warehouse.list"; }
        }

        protected override void PrepareParam(IDictionary<String, Object> paramters)
        {
        }

        public override void Validate()
        {
        }
    }
}
