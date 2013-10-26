#region head comment
/*
Code generate by JdSdkTool.
Copyright © starpeng@vip.qq.com
2013-10-26 10:25:43.04802 +08:00
*/
#endregion

using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using Newtonsoft.Json;
using JdSdk.Domain;

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
        public List<KeywordGroup> KeywordGroupList
        {
            get;
            set;
        }

    }
}
