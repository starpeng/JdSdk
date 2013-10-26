#region head comment
/*
Code generate by JdSdkTool.
Copyright © starpeng@vip.qq.com
2013-10-26 10:25:41.83195 +08:00
*/
#endregion

using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using JdSdk.Domain;
using JdSdk.Response;

namespace JdSdk.Request
{
    /// <summary>
    /// 获取用户收支列表，只能获取最近一周，最近一个月，最近三个月的信息 Request
    /// </summary>
    public class JingdongKuaicheAccountIncomeExpenseSearchRequest : JdRequestBase<JingdongKuaicheAccountIncomeExpenseSearchResponse>
    {
        /// <summary>
        /// 收支类型,1收入，2支出
        /// </summary>
        [XmlElement("in_out_type")]
        [JsonProperty("in_out_type")]
        public Int64 InOutType
        {
            get;
            set;
        }

        /// <summary>
        /// 投放类型：1201 列表页;1202 搜索页
        /// </summary>
        [XmlElement("type")]
        [JsonProperty("type")]
        public Int64 Type
        {
            get;
            set;
        }

        /// <summary>
        /// 0，最近一周1，最近一个月,2，最近三个月
        /// </summary>
        [XmlElement("check_type")]
        [JsonProperty("check_type")]
        public Int64 CheckType
        {
            get;
            set;
        }

        /// <summary>
        /// 当前页
        /// </summary>
        [XmlElement("page_index")]
        [JsonProperty("page_index")]
        public Int64 PageIndex
        {
            get;
            set;
        }

        /// <summary>
        /// 分页大小 范围大于0小于30
        /// </summary>
        [XmlElement("page_size")]
        [JsonProperty("page_size")]
        public Int64 PageSize
        {
            get;
            set;
        }

        public override String ApiName
        {
            get{ return "jingdong.kuaiche.account.income_expense.search"; }
        }

        protected override void PrepareParam(IDictionary<String, Object> paramters)
        {
            paramters.Add("in_out_type" ,this.InOutType);
            paramters.Add("type" ,this.Type);
            paramters.Add("check_type" ,this.CheckType);
            paramters.Add("page_index" ,this.PageIndex);
            paramters.Add("page_size" ,this.PageSize);
        }

        public override void Validate()
        {
        }

    }
}
