#region head comment
/*
Code generate by JdSdkTool.
2013-09-07 15:01:45.13315 +08:00
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
    /// 添加图片分类 Request
    /// </summary>
    public class JingdongImgzoneCategoryAddRequest : JdRequestBase<JingdongImgzoneCategoryAddResponse>
    {
        /// <summary>
        /// 分类名称，自动过滤特殊字符
        /// </summary>
        [XmlElement("cate_name")]
        [JsonProperty("cate_name")]
        public String CateName
        {
            get;
            set;
        }

        /// <summary>
        /// 父分类ID，为空默认添加顶级分类
        /// </summary>
        [XmlElement("parent_cate_id")]
        [JsonProperty("parent_cate_id")]
        public Int64 ParentCateId
        {
            get;
            set;
        }

        public override String ApiName
        {
            get { return "jingdong.imgzone.category.add"; }
        }

        protected override void PrepareParam(IDictionary<String, Object> paramters)
        {

            paramters.Add("cate_name", this.CateName);
            paramters.Add("parent_cate_id", this.ParentCateId);

        }

        public override void Validate()
        {
        }

    }
}
