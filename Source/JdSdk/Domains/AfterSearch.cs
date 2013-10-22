#region head comment
/*
Code generate by JdSdkTool.
2013-01-31 10:56:47:858 +08:00
*/
#endregion

using System;
using System.Collections.Generic;
using System.Xml.Serialization;
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
