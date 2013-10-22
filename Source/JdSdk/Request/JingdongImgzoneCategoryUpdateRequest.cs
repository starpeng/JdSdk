#region head comment
/*
Code generate by JdSdkTool.
2013-09-07 15:01:45.53817 +08:00
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
    /// 更新图片分类 Request
    /// </summary>
    public class JingdongImgzoneCategoryUpdateRequest : JdRequestBase<JingdongImgzoneCategoryUpdateResponse>
    {
        /// <summary>
        /// 要更新的分类ID
        /// </summary>
        [XmlElement("cate_id")]
        [JsonProperty("cate_id")]
        public Int64 CateId
        {
            get;
            set;
        }

        /// <summary>
        /// 新的分类名称，自动过滤特殊字符，与新父分类ID不能同时为空
        /// </summary>
        [XmlElement("cate_name")]
        [JsonProperty("cate_name")]
        public String CateName
        {
            get;
            set;
        }

        /// <summary>
        /// 分类的新父分类ID，只能移动二级分类至默认分类或一级父分类，与新分类名称不能同时为空
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
            get { return "jingdong.imgzone.category.update"; }
        }

        protected override void PrepareParam(IDictionary<String, Object> paramters)
        {

            paramters.Add("cate_id", this.CateId);
            paramters.Add("cate_name", this.CateName);
            paramters.Add("parent_cate_id", this.ParentCateId);

        }

        public override void Validate()
        {
            RequestValidator.ValidateRequired("cate_id", this.CateId);
        }

    }
}
