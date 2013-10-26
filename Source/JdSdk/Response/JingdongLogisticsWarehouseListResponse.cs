#region head comment
/*
Code generate by JdSdkTool.
Copyright © starpeng@vip.qq.com
2013-09-07 15:01:54.24067 +08:00
*/
#endregion

using System.Collections.Generic;
using System.Xml.Serialization;
using JdSdk.Domain;
using Newtonsoft.Json;

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
