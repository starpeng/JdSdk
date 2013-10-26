#region head comment
/*
Code generate by JdSdkTool.
Copyright © starpeng@vip.qq.com
2013-10-26 10:25:50.76346 +08:00
*/
#endregion

using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace JdSdk.Domain
{
    /// <summary>
    /// PopDetailJos  属性
    /// </summary>
    [Serializable]
    public class PopDetailJos : JdObject
    {
        /// <summary>
        /// 返回结果编码：0：成功；-1：失败；-2：该商家不存在
        /// </summary>
        [XmlElement("reuslt_code")]
        [JsonProperty("reuslt_code")]
        public Int64 ReusltCode
        {
            get;
            set;
        }

        /// <summary>
        /// 返回结果描述
        /// </summary>
        [XmlElement("result_description")]
        [JsonProperty("result_description")]
        public String ResultDescription
        {
            get;
            set;
        }

        /// <summary>
        /// 商家名称
        /// </summary>
        [XmlElement("vender_name")]
        [JsonProperty("vender_name")]
        public String VenderName
        {
            get;
            set;
        }

        /// <summary>
        /// 商家联系方式
        /// </summary>
        [XmlElement("vender_contact")]
        [JsonProperty("vender_contact")]
        public String VenderContact
        {
            get;
            set;
        }

        /// <summary>
        /// 商家电话
        /// </summary>
        [XmlElement("vender_tel")]
        [JsonProperty("vender_tel")]
        public String VenderTel
        {
            get;
            set;
        }

        /// <summary>
        /// 商家传真
        /// </summary>
        [XmlElement("vender_fax")]
        [JsonProperty("vender_fax")]
        public String VenderFax
        {
            get;
            set;
        }

        /// <summary>
        /// 商家QQ
        /// </summary>
        [XmlElement("vender_qq")]
        [JsonProperty("vender_qq")]
        public String VenderQq
        {
            get;
            set;
        }

        /// <summary>
        /// 商家msn
        /// </summary>
        [XmlElement("vender_msn")]
        [JsonProperty("vender_msn")]
        public String VenderMsn
        {
            get;
            set;
        }

        /// <summary>
        /// 商家email
        /// </summary>
        [XmlElement("vender_email")]
        [JsonProperty("vender_email")]
        public String VenderEmail
        {
            get;
            set;
        }

        /// <summary>
        /// 商家地区编码
        /// </summary>
        [XmlElement("vender_areacode")]
        [JsonProperty("vender_areacode")]
        public String VenderAreacode
        {
            get;
            set;
        }

        /// <summary>
        /// 商家街道
        /// </summary>
        [XmlElement("vender_street")]
        [JsonProperty("vender_street")]
        public String VenderStreet
        {
            get;
            set;
        }

        /// <summary>
        /// 商家手机
        /// </summary>
        [XmlElement("vender_cellphone")]
        [JsonProperty("vender_cellphone")]
        public String VenderCellphone
        {
            get;
            set;
        }

    }
}
