#region head comment
/*
Code generate by JdSdkTool.
Copyright © starpeng@vip.qq.com
2013-09-07 18:18:09.00221 +08:00
*/
#endregion

using System;
using System.Xml.Serialization;
using Newtonsoft.Json;

namespace JdSdk.Response
{
    /// <summary>
    /// 订购关系查询（根据购买用户名和收费项目代码获取订购关系时长） Response
    /// </summary>
    public class JingdongVasSubscribeGetResponse : JdResponse
    {
        /// <summary>
        /// 收费项目代码（可当做应用版本号）
        /// </summary>
        [XmlElement("item_code")]
        [JsonProperty("item_code")]
        public String ItemCode
        {
            get;
            set;
        }

        /// <summary>
        /// 订购关系到期时间
        /// </summary>
        [XmlElement("end_date")]
        [JsonProperty("end_date")]
        public String EndDate
        {
            get;
            set;
        }

    }
}
