#region head comment
/*
Code generate by JdSdkTool.
Copyright © starpeng@vip.qq.com
2013-09-07 18:18:08.79520 +08:00
*/
#endregion

using System.Xml.Serialization;
using JdSdk.Domain;
using Newtonsoft.Json;

namespace JdSdk.Response
{
    /// <summary>
    /// 根据pin返回供应商简码和三级分类列表 Response
    /// </summary>
    public class JingdongUserCategory3InfoGetResponse : JdResponse
    {
        /// <summary>
        /// 三级分类信息 
        /// </summary>
        [XmlElement("userCategory3Info")]
        [JsonProperty("userCategory3Info")]
        public UserCategory3InfoDto UserCategory3InfoDto
        {
            get;
            set;
        }
    }
}
