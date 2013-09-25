#region head comment
/*
Code generate by JdSdkTool.
2013-01-31 10:56:44:604 +08:00
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
    /// 根据条件获取促销信息 Request
    /// </summary>
    public class PromotionSearchRequest : IJdRequest<PromotionSearchResponse>
    {
        /// <summary>
        /// 活动开始起始时间（格式是：2011-08-03)
        /// </summary>
        [XmlElement("time_begin_start")]
        [JsonProperty("time_begin_start")]
        public String TimeBeginStart
        {
            get;
            set;
        }

        /// <summary>
        /// 活动开始截止时间（格式是：2011-08-04)
        /// </summary>
        [XmlElement("time_begin_end")]
        [JsonProperty("time_begin_end")]
        public String TimeBeginEnd
        {
            get;
            set;
        }

        /// <summary>
        /// 活动结束起始时间（格式是：2011-08-07)
        /// </summary>
        [XmlElement("time_end_start")]
        [JsonProperty("time_end_start")]
        public String TimeEndStart
        {
            get;
            set;
        }

        /// <summary>
        /// 活动结束截止时间（格式是：2011-08-20)
        /// </summary>
        [XmlElement("time_end_end")]
        [JsonProperty("time_end_end")]
        public String TimeEndEnd
        {
            get;
            set;
        }

        /// <summary>
        /// 促销编号 17412
        /// </summary>
        [XmlElement("evt_id")]
        [JsonProperty("evt_id")]
        public String EvtId
        {
            get;
            set;
        }

        /// <summary>
        /// 商品编号 1001211212
        /// </summary>
        [XmlElement("ware_id")]
        [JsonProperty("ware_id")]
        public Int64 WareId
        {
            get;
            set;
        }

        /// <summary>
        /// 会员级别
        /// </summary>
        [XmlElement("level_member")]
        [JsonProperty("level_member")]
        public String LevelMember
        {
            get;
            set;
        }

        /// <summary>
        /// 促销类型
        /// </summary>
        [XmlElement("evt_type")]
        [JsonProperty("evt_type")]
        public String EvtType
        {
            get;
            set;
        }

        /// <summary>
        /// 促销状态
        /// </summary>
        [XmlElement("evt_status")]
        [JsonProperty("evt_status")]
        public String EvtStatus
        {
            get;
            set;
        }

        /// <summary>
        /// 审核状态
        /// </summary>
        [XmlElement("check_status")]
        [JsonProperty("check_status")]
        public String CheckStatus
        {
            get;
            set;
        }

        /// <summary>
        /// skuid
        /// </summary>
        [XmlElement("sku_id")]
        [JsonProperty("sku_id")]
        public Int64 SkuId
        {
            get;
            set;
        }

        /// <summary>
        /// 查询的页数,范围是0至100
        /// </summary>
        [XmlElement("page")]
        [JsonProperty("page")]
        public String Page
        {
            get;
            set;
        }

        /// <summary>
        /// 每页的条数,范围是0至20
        /// </summary>
        [XmlElement("page_size")]
        [JsonProperty("page_size")]
        public String PageSize
        {
            get;
            set;
        }

        public String ApiName
        {
            get{ return "360buy.promotion.search"; }
        }

        public String GetParamJson()
        {
            Dictionary<String, Object> paramters = new Dictionary<string, object>();
            paramters.Add("time_begin_start" ,this.TimeBeginStart);
            paramters.Add("time_begin_end" ,this.TimeBeginEnd);
            paramters.Add("time_end_start" ,this.TimeEndStart);
            paramters.Add("time_end_end" ,this.TimeEndEnd);
            paramters.Add("evt_id" ,this.EvtId);
            paramters.Add("ware_id" ,this.WareId);
            paramters.Add("level_member" ,this.LevelMember);
            paramters.Add("evt_type" ,this.EvtType);
            paramters.Add("evt_status" ,this.EvtStatus);
            paramters.Add("check_status" ,this.CheckStatus);
            paramters.Add("sku_id" ,this.SkuId);
            paramters.Add("page" ,this.Page);
            paramters.Add("page_size" ,this.PageSize);
            return JsonConvert.SerializeObject(paramters, JdUtils.GetJsonConverters());
        }

        public void Validate()
        {
            RequestValidator.ValidateRequired("sku_id", this.SkuId);
            RequestValidator.ValidateRequired("page", this.Page);
            RequestValidator.ValidateRequired("page_size", this.PageSize);
        }

    }
}
