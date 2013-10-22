#region head comment
/*
Code generate by JdSdkTool.
2013-08-02 16:22:54.86472 +08:00
*/
#endregion

using System.Xml.Serialization;
using JdSdk.Domain;
using Newtonsoft.Json;

namespace JdSdk.Response
{
    /// <summary>
    /// 根据分类id查询该分类下的关键词组信息 Response
    /// </summary>
    public class JingdongKuaicheZnKeywordgroupListSearchResponse : JdResponse
    {
        /// <summary>
        /// 参数描述
        /// </summary>
        [XmlElement("keyword_group_list")]
        [JsonProperty("keyword_group_list")]
        public KeywordGroup[] KeywordGroupList
        {
            get;
            set;
        }

    }
}
