#region head comment
/*
Code generate by JdSdkTool.
Copyright © starpeng@vip.qq.com
2013-10-26 10:25:32.52042 +08:00
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
    /// 查询某个商品的限购区域。 Response
    /// </summary>
    public class WareAreaLimitSearchResponse : JdResponse
    {
        /// <summary>
        /// 商品限购区域信息
        /// </summary>
        [XmlElement("ware_area_limits")]
        [JsonProperty("ware_area_limits")]
        public List<WareAreaLimit> WareAreaLimitList
        {
            get;
            set;
        }

        /// <summary>
        /// 限购区域总的记录数
        /// </summary>
        [XmlElement("total")]
        [JsonProperty("total")]
        public Int32 Total
        {
            get;
            set;
        }

    }
}
