#region head comment
/*
Code generate by JdSdkTool.
2013-09-07 15:02:04.79927 +08:00
*/
#endregion

using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace JdSdk.Domain
{
    /// <summary>
    /// BuyToBuyWidsList属性
    /// </summary>
    [Serializable]
    public class BuyToBuyWidsList : JdObject
    {
        /// <summary>
        /// 接口返回信息码
        /// </summary>
        [XmlElement("resultCode")]
        [JsonProperty("resultCode")]
        public Int64 ResultCode
        {
            get;
            set;
        }

        /// <summary>
        /// 
        /// </summary>
        [XmlElement("buyToBuyWids")]
        [JsonProperty("buyToBuyWids")]
        public List<CmsActivityWare> BuyToBuyWids
        {
            get;
            set;
        }

    }
}
