#region head comment
/*
Code generate by JdSdkTool.
2013-07-29 13:02:46.25691 +08:00
*/
#endregion

using System;
using System.Xml.Serialization;
using Newtonsoft.Json;

namespace JdSdk.Domain
{
    /// <summary>
    /// MasterBillVo属性
    /// </summary>
    [Serializable]
    public class MasterBillVo : JdObject
    {
        /// <summary>
        /// 结算单号
        /// </summary>
        [XmlElement("bill_id")]
        [JsonProperty("bill_id")]
        public Nullable<Int64> BillId
        {
            get;
            set;
        }

        /// <summary>
        /// 联盟id
        /// </summary>
        [XmlElement("union_id")]
        [JsonProperty("union_id")]
        public Nullable<Int64> UnionId
        {
            get;
            set;
        }

        /// <summary>
        /// 佣金所属月份(如：201307)
        /// </summary>
        /// <example>201307</example>
        [XmlElement("pay_month")]
        [JsonProperty("pay_month")]
        public String PayMonth
        {
            get;
            set;
        }

        /// <summary>
        /// 支付时间,格式:yyyy-MM-dd HH:mm:ss
        /// </summary>
        /// <example>2013-07-03 00:00:00</example>
        [XmlElement("pay_time")]
        [JsonProperty("pay_time")]
        public Nullable<DateTime> PayTime
        {
            get;
            set;
        }

        /// <summary>
        /// 税前总佣金
        /// </summary>
        [XmlElement("total")]
        [JsonProperty("total")]
        public Int64 Total
        {
            get;
            set;
        }

        /// <summary>
        /// 扣税
        /// </summary>
        [XmlElement("tax")]
        [JsonProperty("tax")]
        public Nullable<Decimal> Tax
        {
            get;
            set;
        }

        /// <summary>
        /// 实际支付佣金
        /// </summary>
        [XmlElement("pay_amount")]
        [JsonProperty("pay_amount")]
        public Nullable<Decimal> PayAmount
        {
            get;
            set;
        }

        /// <summary>
        /// 税后总佣金
        /// </summary>
        [XmlElement("after_tax")]
        [JsonProperty("after_tax")]
        public Nullable<Decimal> AfterTax
        {
            get;
            set;
        }

        /// <summary>
        /// 手动调整佣金
        /// </summary>
        [XmlElement("adjust")]
        [JsonProperty("adjust")]
        public Nullable<Decimal> Adjust
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
        /// 收款银行卡号
        /// </summary>
        [XmlElement("bank_card")]
        [JsonProperty("bank_card")]
        public String BankCard
        {
            get;
            set;
        }

        /// <summary>
        /// 支付流水号
        /// </summary>
        [XmlElement("pay_id")]
        [JsonProperty("pay_id")]
        public String PayId
        {
            get;
            set;
        }

        /// <summary>
        /// 技术服务费
        /// </summary>
        [XmlElement("technical_fee")]
        [JsonProperty("technical_fee")]
        public Nullable<Decimal> TechnicalFee
        {
            get;
            set;
        }

        /// <summary>
        /// 结算单状态（0/1/2）
        /// </summary>
        /// <example>0/1/2</example>
        [XmlElement("status")]
        [JsonProperty("status")]
        public Nullable<Int64> Status
        {
            get;
            set;
        }

    }
}
