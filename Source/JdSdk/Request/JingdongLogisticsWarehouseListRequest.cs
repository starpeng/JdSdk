#region head comment
/*
Code generate by JdSdkTool.
2013-09-07 15:01:54.24067 +08:00
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
    /// 获取仓库信息列表 Request
    /// </summary>
    public class JingdongLogisticsWarehouseListRequest : IJdRequest<JingdongLogisticsWarehouseListResponse>
    {

        public String ApiName
        {
            get{ return "jingdong.logistics.warehouse.list"; }
        }

        public String GetParamJson()
        {
            return "{}";
        }

        public void Validate()
        {
        }
    }
}
