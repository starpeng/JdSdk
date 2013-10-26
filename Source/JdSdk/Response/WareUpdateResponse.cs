#region head comment
/*
Code generate by JdSdkTool.
Copyright © starpeng@vip.qq.com
2013-06-03 12:29:14.10093 +08:00
*/
#endregion

using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using JdSdk.Domain;
using Newtonsoft.Json;

namespace JdSdk.Response
{
    /// <summary>
    /// 通过api 根据ware_id 商品编号 修改商品信息 Response
    /// </summary>
    public class WareUpdateResponse : JdResponse
    {
        /// <summary>
        /// 更改时间
        /// </summary>
        [XmlElement("modified")]
        [JsonProperty("modified")]
        public String Modified
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
        public List<SkuInfo> Skus
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
