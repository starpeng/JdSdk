#region head comment
/*
Code generate by JdSdkTool.
Copyright © starpeng@vip.qq.com
2013-07-29 22:39:03.59312 +08:00
*/
#endregion

using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using JdSdk.Response;
using Newtonsoft.Json;

namespace JdSdk.Request
{
    /// <summary>
    /// 根据商品ID查询商品推广代码 Request
    /// </summary>
    public class JingdongUnionGoodsCodeGetRequest : JdRequestBase<JingdongUnionGoodsCodeGetResponse>
    {
        /// <summary>
        /// 商品ID
        /// </summary>
        /// <example>30442010</example>
        [XmlElement("good_id")]
        [JsonProperty("good_id")]
        public Int64 GoodId
        {
            get;
            set;
        }

        public override String ApiName
        {
            get { return "jingdong.union.goods.code.get"; }
        }

        protected override void PrepareParam(IDictionary<String, Object> paramters)
        {

            paramters.Add("good_id", this.GoodId);

        }

        public override void Validate()
        {
            RequestValidator.ValidateRequired("good_id", this.GoodId);
        }

    }
}
