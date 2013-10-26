#region head comment
/*
Code generate by JdSdkTool.
Copyright © starpeng@vip.qq.com
2013-10-26 10:25:50.74946 +08:00
*/
#endregion

using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace JdSdk.Domain
{
    /// <summary>
    /// WareAreaLimit结构
    /// </summary>
    [Serializable]
    public class WareAreaLimit : JdObject
    {
        /// <summary>
        /// 商品ID
        /// </summary>
        /// <example>1100000015 L</example>
        [XmlElement("ware_id")]
        [JsonProperty("ware_id")]
        public Int64 WareId
        {
            get;
            set;
        }

        /// <summary>
        /// 商家ID
        /// </summary>
        /// <example>20032 L</example>
        [XmlElement("vender_id")]
        [JsonProperty("vender_id")]
        public Int64 VenderId
        {
            get;
            set;
        }

        /// <summary>
        /// 区域父id，如果当前区域id无父区域id，用0表示。
        /// </summary>
        /// <example>12314</example>
        [XmlElement("area_fid")]
        [JsonProperty("area_fid")]
        public Int32 AreaFid
        {
            get;
            set;
        }

        /// <summary>
        /// 区域级别，1: 省，2:市，3:区
        /// </summary>
        /// <example>1</example>
        [XmlElement("lev")]
        [JsonProperty("lev")]
        public Int32 Lev
        {
            get;
            set;
        }

        /// <summary>
        /// 业务类型，1:限购
        /// </summary>
        /// <example>京东sop衬衫1</example>
        [XmlElement("type")]
        [JsonProperty("type")]
        public Int32 Type
        {
            get;
            set;
        }

        /// <summary>
        /// 区域id，同一个省下的不同城市使用英文逗号(,)分隔
        /// </summary>
        /// <example>23424</example>
        [XmlElement("area_ids")]
        [JsonProperty("area_ids")]
        public String AreaIds
        {
            get;
            set;
        }

        /// <summary>
        /// 创建日期
        /// </summary>
        /// <example>6948807910044</example>
        [XmlElement("created")]
        [JsonProperty("created")]
        public String Created
        {
            get;
            set;
        }

        /// <summary>
        /// 修改日期
        /// </summary>
        /// <example>333</example>
        [XmlElement("modified")]
        [JsonProperty("modified")]
        public String Modified
        {
            get;
            set;
        }

    }
}
