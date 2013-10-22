#region head comment
/*
Code generate by JdSdkTool.
2013-08-02 16:22:53.31063 +08:00
*/
#endregion

using System.Xml.Serialization;
using JdSdk.Domain;
using Newtonsoft.Json;

namespace JdSdk.Response
{
    /// <summary>
    /// 获得商家账户余额，可用余额，冻结金额信息 Response
    /// </summary>
    public class JingdongKuaicheAccountGetResponse : JdResponse
    {
        /// <summary>
        /// 账户信息
        /// </summary>
        [XmlElement("account")]
        [JsonProperty("account")]
        public AccountVO Account
        {
            get;
            set;
        }

    }
}
