#region head comment
/*
Code generate by JdSdkTool.
2013-08-02 16:22:54.16168 +08:00
*/
#endregion

using System.Xml.Serialization;
using JdSdk.Domain;
using Newtonsoft.Json;

namespace JdSdk.Response
{
    /// <summary>
    /// 根据skuId获取商品信息（需所属商家授权） Response
    /// </summary>
    public class JingdongKuaicheGoodsGetResponse : JdResponse
    {
        /// <summary>
        /// 专柜推广代码
        /// </summary>
        [XmlElement("result")]
        [JsonProperty("result")]
        public JosGoodsInfo Result
        {
            get;
            set;
        }

    }
}
