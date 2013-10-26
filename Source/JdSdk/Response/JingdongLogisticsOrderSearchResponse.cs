#region head comment
/*
Code generate by JdSdkTool.
Copyright © starpeng@vip.qq.com
2013-09-07 15:01:51.40751 +08:00
*/
#endregion

using System.Collections.Generic;
using System.Xml.Serialization;
using JdSdk.Domain;
using Newtonsoft.Json;

namespace JdSdk.Response
{
    /// <summary>
    /// 获取多订单信息 Response
    /// </summary>
    public class JingdongLogisticsOrderSearchResponse : JdResponse
    {
        /// <summary>
        /// 
        /// </summary>
        [XmlElement("orders")]
        [JsonProperty("orders")]
        public List<ResponseOrderStatus> Orders
        {
            get;
            set;
        }

    }
}
