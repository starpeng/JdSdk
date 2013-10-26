#region head comment
/*
Code generate by JdSdkTool.
Copyright © starpeng@vip.qq.com
2013-10-26 10:25:50.77447 +08:00
*/
#endregion

using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace JdSdk.Domain
{
    /// <summary>
    /// SafBiztypeDTO属性
    /// </summary>
    [Serializable]
    public class SafBiztypeDTO : JdObject
    {
        /// <summary>
        /// 二级业务类型ID
        /// </summary>
        [XmlElement("sub_biztype_id")]
        [JsonProperty("sub_biztype_id")]
        public Int64 SubBiztypeId
        {
            get;
            set;
        }

        /// <summary>
        /// 二级业务类型名称
        /// </summary>
        [XmlElement("sub_biztype_name")]
        [JsonProperty("sub_biztype_name")]
        public String SubBiztypeName
        {
            get;
            set;
        }

    }
}
