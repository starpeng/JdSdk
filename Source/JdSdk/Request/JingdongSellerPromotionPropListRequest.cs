#region head comment
/*
Code generate by JdSdkTool.
Copyright © starpeng@vip.qq.com
2013-09-07 15:01:56.66581 +08:00
*/
#endregion

using System;
using System.Collections.Generic;
using JdSdk.Response;

namespace JdSdk.Request
{
    /// <summary>
    /// 根据促销编号获取促销的道具列表 Request
    /// </summary>
    public class JingdongSellerPromotionPropListRequest : JdRequestBase<JingdongSellerPromotionPropListResponse>
    {
        public override String ApiName
        {
            get { return "jingdong.seller.promotion.prop.list"; }
        }

        protected override void PrepareParam(IDictionary<String, Object> paramters)
        {


        }

        public override void Validate()
        {
        }

    }
}
