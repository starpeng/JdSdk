#region head comment
/*
Code generate by JdSdkTool.
2013-09-07 15:01:49.58640 +08:00
*/
#endregion

using System.Xml.Serialization;
using JdSdk.Domain;
using Newtonsoft.Json;

namespace JdSdk.Response
{
    /// <summary>
    /// 创建搜索页推广 Response
    /// </summary>
    public class JingdongKuaicheZnPlanSearchCreateResponse : JdResponse
    {
        /// <summary>
        /// 返回信息描述
        /// </summary>
        [XmlElement("result_status")]
        [JsonProperty("result_status")]
        public ResultStatus ResultStatus
        {
            get;
            set;
        }

    }
}
