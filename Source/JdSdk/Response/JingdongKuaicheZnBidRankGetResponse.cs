#region head comment
/*
Code generate by JdSdkTool.
2013-08-02 16:22:54.65870 +08:00
*/
#endregion

using System.Xml.Serialization;
using JdSdk.Domain;
using Newtonsoft.Json;

namespace JdSdk.Response
{
    /// <summary>
    /// 根据计划信息获取排名信息 Response
    /// </summary>
    public class JingdongKuaicheZnBidRankGetResponse : JdResponse
    {
        /// <summary>
        /// 预测返回信息
        /// </summary>
        [XmlElement("rank_return")]
        [JsonProperty("rank_return")]
        public RankReturnJO RankReturn
        {
            get;
            set;
        }

    }
}
