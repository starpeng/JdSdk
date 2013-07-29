#region head comment
/*
Code generate by JdSdkTool.
2013-04-03 12:45:23.52969 +08:00
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
    /// 获得首页的推广链接信息 Response
    /// </summary>
    public class JingdongTuiguangHomepageGetResponse : JdResponse
    {
        /// <summary>
        /// 标题如
        ///<parp>  京东首页</parp>
        /// </summary>
        /// <example>京东首页</example>
        [XmlElement("title")]
        [JsonProperty("title")]
        public String Title
        {
            get;
            set;
        }

        /// <summary>
        /// 图片url
        /// </summary>
        [XmlElement("pic_url")]
        [JsonProperty("pic_url")]
        public String PicUrl
        {
            get;
            set;
        }

        /// <summary>
        /// 佣金，暂不返回
        /// </summary>
        [XmlElement("commission_fee")]
        [JsonProperty("commission_fee")]
        public Nullable<Decimal> CommissionFee
        {
            get;
            set;
        }

        /// <summary>
        /// 推广URL
        /// </summary>
        /// <example>http://click.union.360buy.com/JdClick/?unionId=联盟编号&amp;to=http://www.360buy.com</example>
        [XmlElement("click_url")]
        [JsonProperty("click_url")]
        public String ClickUrl
        {
            get;
            set;
        }
    }
}
