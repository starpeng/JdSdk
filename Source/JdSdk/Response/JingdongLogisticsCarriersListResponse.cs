#region head comment
/*
Code generate by JdSdkTool.
2013-09-07 15:01:50.59746 +08:00
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
    /// 获取承运商信息列表 Response
    /// </summary>
    public class JingdongLogisticsCarriersListResponse : JdResponse
    {
        /// <summary>
        /// 
        /// </summary>
        [XmlElement("carriers_details")]
        [JsonProperty("carriers_details")]
        public List<CarriersDetail> CarriersDetails
        {
            get;
            set;
        }

    }
}
