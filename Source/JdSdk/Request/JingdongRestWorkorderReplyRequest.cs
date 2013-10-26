#region head comment
/*
Code generate by JdSdkTool.
Copyright © starpeng@vip.qq.com
2013-10-26 10:25:45.88319 +08:00
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
    ///  Request
    /// </summary>
    public class JingdongRestWorkorderReplyRequest : JdRequestBase<JingdongRestWorkorderReplyResponse>
    {
        /// <summary>
        /// 工单id
        /// </summary>
        [XmlElement("work_id")]
        [JsonProperty("work_id")]
        public Int64 WorkId
        {
            get;
            set;
        }

        /// <summary>
        /// 工单回复内容，不能超过1000个字节，也就是500个汉字，或1000个英文。
        /// </summary>
        [XmlElement("reply_content")]
        [JsonProperty("reply_content")]
        public String ReplyContent
        {
            get;
            set;
        }

        /// <summary>
        /// 一级业务类型  (通过jingdong.wos.workinfo.get  接口send_biztype_id字段获取)
        /// </summary>
        [XmlElement("work_type")]
        [JsonProperty("work_type")]
        public Int64 WorkType
        {
            get;
            set;
        }

        /// <summary>
        /// 二级业务类型 (通过jingdong.wos.subbiztypelist.get  接口sub_biztype_id字段获取)
        /// </summary>
        [XmlElement("work2_type")]
        [JsonProperty("work2_type")]
        public Int64 Work2Type
        {
            get;
            set;
        }

        public override String ApiName
        {
            get{ return "jingdong.rest.workorder.reply"; }
        }

        protected override void PrepareParam(IDictionary<String, Object> paramters)
        {
            paramters.Add("work_id" ,this.WorkId);
            paramters.Add("reply_content" ,this.ReplyContent);
            paramters.Add("work_type" ,this.WorkType);
            paramters.Add("work2_type" ,this.Work2Type);
        }

        public override void Validate()
        {
            RequestValidator.ValidateRequired("work_id", this.WorkId);
            RequestValidator.ValidateRequired("reply_content", this.ReplyContent);
            RequestValidator.ValidateRequired("work_type", this.WorkType);
            RequestValidator.ValidateRequired("work2_type", this.Work2Type);
        }

    }
}
