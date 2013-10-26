#region head comment
/*
Code generate by JdSdkTool.
Copyright © starpeng@vip.qq.com
2013-10-26 10:25:45.68117 +08:00
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
    /// 查询商家备注 Request
    /// </summary>
    public class JingdongOrderVenderRemarkQueryByOrderIdRequest : JdRequestBase<JingdongOrderVenderRemarkQueryByOrderIdResponse>
    {
        public override String ApiName
        {
            get{ return "jingdong.order.venderRemark.queryByOrderId"; }
        }

        protected override void PrepareParam(IDictionary<String, Object> paramters)
        {
        }

        public override void Validate()
        {
        }

    }
}
