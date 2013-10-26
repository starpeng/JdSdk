#region head comment
/*
Code generate by JdSdkTool.
Copyright © starpeng@vip.qq.com
2013-08-30 16:36:27.41003 +08:00
*/
#endregion

using System;
using System.Xml.Serialization;
using Newtonsoft.Json;

namespace JdSdk.Domain
{
    /// <summary>
    /// VatInvoiceInfo结构
    /// </summary>
    [Serializable]
    public class VatInvoiceInfo : JdObject
    {
        /// <summary>
        /// 纳税人识别号
        /// </summary>
        [XmlElement("taxpayer_ident")]
        [JsonProperty("taxpayer_ident")]
        public String TaxpayerIdent
        {
            get;
            set;
        }

        /// <summary>
        /// 注册地址
        /// </summary>
        [XmlElement("registered_address")]
        [JsonProperty("registered_address")]
        public String RegisteredAddress
        {
            get;
            set;
        }

        /// <summary>
        /// 注册电话
        /// </summary>
        [XmlElement("registered_phone")]
        [JsonProperty("registered_phone")]
        public String RegisteredPhone
        {
            get;
            set;
        }

        /// <summary>
        /// 开户银行
        /// </summary>
        [XmlElement("deposit_bank")]
        [JsonProperty("deposit_bank")]
        public String DepositBank
        {
            get;
            set;
        }

        /// <summary>
        /// 银行账户
        /// </summary>
        [XmlElement("bank_account")]
        [JsonProperty("bank_account")]
        public String BankAccount
        {
            get;
            set;
        }

    }
}
