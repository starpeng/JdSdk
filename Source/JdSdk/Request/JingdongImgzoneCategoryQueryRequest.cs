#region head comment
/*
Code generate by JdSdkTool.
Copyright © starpeng@vip.qq.com
2013-10-26 10:25:39.80584 +08:00
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
    /// 查询图片分类 Request
    /// </summary>
    public class JingdongImgzoneCategoryQueryRequest : JdRequestBase<JingdongImgzoneCategoryQueryResponse>
    {
        /// <summary>
        /// 分类ID
        /// </summary>
        /// <example>1</example>
        [XmlElement("cate_id")]
        [JsonProperty("cate_id")]
        public Int64 CateId
        {
            get;
            set;
        }

        /// <summary>
        /// 分类名称，不支持模糊查询
        /// </summary>
        /// <example>分类名abc</example>
        [XmlElement("cate_name")]
        [JsonProperty("cate_name")]
        public String CateName
        {
            get;
            set;
        }

        /// <summary>
        /// 父分类ID，查询二级分类时为对应父分类id，查询一级分类时为0，查询全部分类的时候为空
        /// </summary>
        /// <example>1</example>
        [XmlElement("parent_cate_id")]
        [JsonProperty("parent_cate_id")]
        public Int64 ParentCateId
        {
            get;
            set;
        }

        public override String ApiName
        {
            get{ return "jingdong.imgzone.category.query"; }
        }

        protected override void PrepareParam(IDictionary<String, Object> paramters)
        {
            paramters.Add("cate_id" ,this.CateId);
            paramters.Add("cate_name" ,this.CateName);
            paramters.Add("parent_cate_id" ,this.ParentCateId);
        }

        public override void Validate()
        {
        }

    }
}
