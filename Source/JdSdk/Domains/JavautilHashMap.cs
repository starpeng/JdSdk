#region head comment
/*
Code generate by JdSdkTool.
Copyright © starpeng@vip.qq.com
2013-09-07 15:02:04.78627 +08:00
*/
#endregion

using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using Newtonsoft.Json;

namespace JdSdk.Domain
{
    /// <summary>
    /// java.util.HashMap 属性
    /// </summary>
    [Serializable]
    public class JavautilHashMap : JdObject
    {
        /// <summary>
        /// 
        /// </summary>
        [XmlElement("order_list")]
        [JsonProperty("order_list")]
        public List<ResponseOrderStatus> OrderList
        {
            get;
            set;
        }

    }
}
