#region head comment
/*
Code generate by JdSdkTool.
Copyright © starpeng@vip.qq.com
2013-10-26 10:25:32.72243 +08:00
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
    /// 设置某个商品的限购区域。 Request
    /// </summary>
    public class WareAreaLimitUpdateRequest : JdRequestBase<WareAreaLimitUpdateResponse>
    {
        /// <summary>
        /// 商品id，必选
        /// </summary>
        /// <example>1311</example>
        [XmlElement("ware_id")]
        [JsonProperty("ware_id")]
        public String WareId
        {
            get;
            set;
        }

        /// <summary>
        /// 业务类型 1:限购(目前只支持限购)
        /// </summary>
        [XmlElement("type")]
        [JsonProperty("type")]
        public String Type
        {
            get;
            set;
        }

        /// <summary>
        /// 区域层级列表， 1: 省， 2: 市， 3: 区（目前支持1和2）。以|分隔。       lev为area_ids的级别，levs，area_ids，area_fids个数保证一致。
        /// </summary>
        /// <example>lev1|lev2|lev3</example>
        [XmlElement("levs")]
        [JsonProperty("levs")]
        public String Levs
        {
            get;
            set;
        }

        /// <summary>
        /// 区域父编号列表，以|分隔。      如果设置区域id没有父区域，需用0表示。      levs，area_ids，area_fids个数保证一致
        /// </summary>
        /// <example>areaFid1|areaFid2|areaFid3</example>
        [XmlElement("area_fids")]
        [JsonProperty("area_fids")]
        public String AreaFids
        {
            get;
            set;
        }

        /// <summary>
        /// 区域编号列表，以|分隔，如果一个区域父编号对应多个区别编号，以英文逗号分隔。      area_ids最小只能到达市一级，不能到达区县级或者乡镇一级。      levs，area_ids，area_fids个数保证一致，区域id获取调用      http://help.jd.com/jos/question-827.html中的接口
        /// </summary>
        /// <example>areaId1,areaId11,areaId111|areaId2,areaId22,areaId222</example>
        [XmlElement("area_ids")]
        [JsonProperty("area_ids")]
        public String AreaIds
        {
            get;
            set;
        }

        public override String ApiName
        {
            get{ return "360buy.ware.area.limit.update"; }
        }

        protected override void PrepareParam(IDictionary<String, Object> paramters)
        {
            paramters.Add("ware_id" ,this.WareId);
            paramters.Add("type" ,this.Type);
            paramters.Add("levs" ,this.Levs);
            paramters.Add("area_fids" ,this.AreaFids);
            paramters.Add("area_ids" ,this.AreaIds);
        }

        public override void Validate()
        {
            RequestValidator.ValidateRequired("ware_id", this.WareId);
            RequestValidator.ValidateRequired("type", this.Type);
            RequestValidator.ValidateRequired("levs", this.Levs);
            RequestValidator.ValidateRequired("area_fids", this.AreaFids);
            RequestValidator.ValidateRequired("area_ids", this.AreaIds);
        }

    }
}
