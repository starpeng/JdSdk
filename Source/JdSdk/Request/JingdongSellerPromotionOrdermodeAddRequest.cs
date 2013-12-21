#region head comment
/*
Code generate by JdSdkTool.
2013-12-21 10:56:50.01971 +08:00
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
    ///  Request
    /// </summary>
    public class JingdongSellerPromotionOrdermodeAddRequest : JdRequestBase<JingdongSellerPromotionOrdermodeAddResponse>
    {
        public override String ApiName
        {
            get{ return "jingdong.seller.promotion.ordermode.add"; }
        }

        protected override void PrepareParam(IDictionary<String, Object> paramters)
        {
        }

        public override void Validate()
        {
        }

    }
}
