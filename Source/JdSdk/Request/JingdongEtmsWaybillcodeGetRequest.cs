#region head comment
/*
Code generate by JdSdkTool.
Copyright © starpeng@vip.qq.com
2013-10-26 10:25:37.16569 +08:00
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
    /// 获取京东物流预分配的运单号    相关文档下载：ERP对接方案【10月16日更新】   京东快递可配送区域 Request
    /// </summary>
    public class JingdongEtmsWaybillcodeGetRequest : JdRequestBase<JingdongEtmsWaybillcodeGetResponse>
    {
        /// <summary>
        /// 获取运单号数量（最大100）
        /// </summary>
        [XmlElement("preNum")]
        [JsonProperty("preNum")]
        public String PreNum
        {
            get;
            set;
        }

        /// <summary>
        /// 商家编码（区分英文大小写）（登录京东物流网站（http://www.jd-ex.com/）查看。如无登录账号，可向配送运营人员索取。并非POP系统商家id。）
        /// </summary>
        [XmlElement("customerCode")]
        [JsonProperty("customerCode")]
        public String CustomerCode
        {
            get;
            set;
        }

        public override String ApiName
        {
            get{ return "jingdong.etms.waybillcode.get"; }
        }

        protected override void PrepareParam(IDictionary<String, Object> paramters)
        {
            paramters.Add("prenum" ,this.PreNum);
            paramters.Add("customercode" ,this.CustomerCode);
        }

        public override void Validate()
        {
            RequestValidator.ValidateRequired("preNum", this.PreNum);
            RequestValidator.ValidateRequired("customerCode", this.CustomerCode);
        }

    }
}
