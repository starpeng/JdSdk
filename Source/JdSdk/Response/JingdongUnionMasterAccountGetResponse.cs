#region head comment
/*
Code generate by JdSdkTool.
2013-07-29 22:39:03.79513 +08:00
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
    /// 获取联盟用户详细信息 Response
    /// </summary>
    public class JingdongUnionMasterAccountGetResponse : JdResponse
    {
        /// <summary>
        /// 联盟id
        /// </summary>
        [XmlElement("union_id")]
        [JsonProperty("union_id")]
        public String UnionId
        {
            get;
            set;
        }

        /// <summary>
        /// 联盟类型:1-个人，2-公司
        /// </summary>
        /// <example>1,2</example>
        [XmlElement("type")]
        [JsonProperty("type")]
        public Nullable<Int64> Type
        {
            get;
            set;
        }

        /// <summary>
        /// 京东账号名称
        /// </summary>
        [XmlElement("pin")]
        [JsonProperty("pin")]
        public String Pin
        {
            get;
            set;
        }

        /// <summary>
        /// 昵称
        /// </summary>
        [XmlElement("nick")]
        [JsonProperty("nick")]
        public String Nick
        {
            get;
            set;
        }

        /// <summary>
        /// 联系电话
        /// </summary>
        [XmlElement("mobile")]
        [JsonProperty("mobile")]
        public String Mobile
        {
            get;
            set;
        }

        /// <summary>
        /// 电子邮件地址
        /// </summary>
        [XmlElement("email")]
        [JsonProperty("email")]
        public String Email
        {
            get;
            set;
        }

        /// <summary>
        /// 姓名
        /// </summary>
        [XmlElement("name")]
        [JsonProperty("name")]
        public String Name
        {
            get;
            set;
        }

        /// <summary>
        /// 公司名称（公司类型）
        /// </summary>
        [XmlElement("campany_name")]
        [JsonProperty("campany_name")]
        public String CampanyName
        {
            get;
            set;
        }

        /// <summary>
        /// 公司联系地址
        /// </summary>
        [XmlElement("campany_address")]
        [JsonProperty("campany_address")]
        public String CampanyAddress
        {
            get;
            set;
        }

        /// <summary>
        /// 收款银行名称
        /// </summary>
        [XmlElement("bank_name")]
        [JsonProperty("bank_name")]
        public String BankName
        {
            get;
            set;
        }

        /// <summary>
        /// 收款银行开户地址
        /// </summary>
        [XmlElement("bank_address")]
        [JsonProperty("bank_address")]
        public String BankAddress
        {
            get;
            set;
        }

        /// <summary>
        /// 银行账号（卡号）
        /// </summary>
        [XmlElement("card_no")]
        [JsonProperty("card_no")]
        public String CardNo
        {
            get;
            set;
        }

        /// <summary>
        /// 收款人姓名
        /// </summary>
        [XmlElement("owner_name")]
        [JsonProperty("owner_name")]
        public String OwnerName
        {
            get;
            set;
        }

        /// <summary>
        /// 收款人身份证号
        /// </summary>
        [XmlElement("owner_id")]
        [JsonProperty("owner_id")]
        public String OwnerId
        {
            get;
            set;
        }

    }
}
