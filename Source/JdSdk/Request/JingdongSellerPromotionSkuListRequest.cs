#region head comment
/*
Code generate by JdSdkTool.
Copyright © starpeng@vip.qq.com
2013-09-07 15:01:57.27284 +08:00
*/
#endregion

using System;
using System.Collections.Generic;
using JdSdk.Response;

namespace JdSdk.Request
{
    /// <summary>
    /// 分页查询指定促销下符合条件的促销SKU，最多返回10个 Request
    /// </summary>
    public class JingdongSellerPromotionSkuListRequest : JdRequestBase<JingdongSellerPromotionSkuListResponse>
    {
        public override String ApiName
        {
            get { return "jingdong.seller.promotion.sku.list"; }
        }

        protected override void PrepareParam(IDictionary<String, Object> paramters)
        {


        }

        public override void Validate()
        {
        }

    }
}
