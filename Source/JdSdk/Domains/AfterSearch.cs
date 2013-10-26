#region head comment
/*
Code generate by JdSdkTool.
Copyright © starpeng@vip.qq.com
2013-10-26 10:25:50.74246 +08:00
*/
#endregion

using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace JdSdk.Domain
{
    /// <summary>
    /// AfterSearch结构
    /// </summary>
    [Serializable]
    public class AfterSearch : JdObject
    {
        /// <summary>
        /// 退货信息
        /// </summary>
        [XmlElement("return_infos")]
        [JsonProperty("return_infos")]
        public List<ReturnInfo> ReturnInfos
        {
            get;
            set;
        }

        /// <summary>
        /// 总的数量
        /// </summary>
        [XmlElement("total_num")]
        [JsonProperty("total_num")]
        public Int32 TotalNum
        {
            get;
            set;
        }

    }
}
