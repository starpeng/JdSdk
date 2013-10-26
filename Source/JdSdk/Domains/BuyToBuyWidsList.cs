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
