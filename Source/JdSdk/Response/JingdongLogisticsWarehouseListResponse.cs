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
using JdSdk.Domain;

namespace JdSdk.Response
{
    /// <summary>
    /// 获取仓库信息列表 Response
    /// </summary>
    public class JingdongLogisticsWarehouseListResponse : JdResponse
    {
        /// <summary>
        /// 
        /// </summary>
        [XmlElement("warehouse_details")]
        [JsonProperty("warehouse_details")]
        public List<WarehouseDetail> WarehouseDetails
        {
            get;
            set;
        }

    }
}
