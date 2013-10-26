#region head comment
/*
Code generate by JdSdkTool.
Copyright © starpeng@vip.qq.com
2013-09-07 15:02:04.78927 +08:00
*/
#endregion

using System;
using System.Xml.Serialization;
using Newtonsoft.Json;

namespace JdSdk.Domain
{
    /// <summary>
    /// WarehouseDetail属性
    /// </summary>
    [Serializable]
    public class WarehouseDetail : JdObject
    {
        /// <summary>
        /// 仓库编号
        /// </summary>
        [XmlElement("warehouse_no")]
        [JsonProperty("warehouse_no")]
        public String WarehouseNo
        {
            get;
            set;
        }

        /// <summary>
        /// 仓库名称
        /// </summary>
        [XmlElement("warehouse_name")]
        [JsonProperty("warehouse_name")]
        public String WarehouseName
        {
            get;
            set;
        }

        /// <summary>
        /// 仓库地址
        /// </summary>
        [XmlElement("warehouse_address")]
        [JsonProperty("warehouse_address")]
        public String WarehouseAddress
        {
            get;
            set;
        }

        /// <summary>
        /// 仓库电话
        /// </summary>
        [XmlElement("warehouse_phone")]
        [JsonProperty("warehouse_phone")]
        public String WarehousePhone
        {
            get;
            set;
        }

    }
}
