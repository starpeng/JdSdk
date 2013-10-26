#region head comment
/*
Code generate by JdSdkTool.
Copyright © starpeng@vip.qq.com
2013-07-29 22:39:03.39111 +08:00
*/
#endregion

using System.Xml.Serialization;
using JdSdk.Domain;
using Newtonsoft.Json;

namespace JdSdk.Response
{
    /// <summary>
    /// 查询店铺推广详情 Response
    /// </summary>
    public class JingdongUnionAdvdetailGetResponse : JdResponse
    {
        /// <summary>
        /// 店铺推广详情返回对象
        /// </summary>
        [XmlElement("adv_detail")]
        [JsonProperty("adv_detail")]
        public AdvDetailVo AdvDetail
        {
            get;
            set;
        }

    }
}
