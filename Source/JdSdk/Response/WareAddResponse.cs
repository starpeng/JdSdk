#region head comment
/*
Code generate by JdSdkTool.
2013-06-03 12:29:11.86880 +08:00
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
    /// 新增一个商品 Response
    /// </summary>
    public class WareAddResponse : JdResponse
    {
        /// <summary>
        /// 更改时间
        /// </summary>
        [XmlElement("created")]
        [JsonProperty("created")]
        public String Created
        {
            get;
            set;
        }

        /// <summary>
        /// 商品的id
        /// </summary>
        [XmlElement("ware_id")]
        [JsonProperty("ware_id")]
        public Int64 WareId
        {
            get;
            set;
        }

        /// <summary>
        /// SKU集合
        /// </summary>
        [XmlElement("skus")]
        [JsonProperty("skus")]
        public List< SkuInfo > Skus
        {
            get;
            set;
        }

        /// <summary>
        /// 用户自行输入的类目属性ID串 结构："pid1|pid2|pid3",属性的pid调用360buy.ware.get.attribute取得, 输入类型input_type=3即输入
        /// </summary>
        /// <example>String</example>
        [XmlElement("input_pids")]
        [JsonProperty("input_pids")]
        public String InputPids 
        {
            get;
            set;
        }

        /// <summary>
        /// 用户自行输入的属性值,结构:"输入值|输入值2|输入值3"
        /// </summary>
        /// <example>String</example>
        [XmlElement("input_strs")]
        [JsonProperty("input_strs")]
        public String InputStrs 
        {
            get;
            set;
        }
    }
}
