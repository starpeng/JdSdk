﻿#region head comment
/*
Code generate by JdSdkTool.
Copyright © starpeng@vip.qq.com
2013-10-26 10:25:48.50834 +08:00
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
    public class JingdongWareProductStockListGetRequest : JdRequestBase<JingdongWareProductStockListGetResponse>
    {
        public override String ApiName
        {
            get{ return "jingdong.ware.product.stock.list.get"; }
        }

        protected override void PrepareParam(IDictionary<String, Object> paramters)
        {
        }

        public override void Validate()
        {
        }

    }
}
