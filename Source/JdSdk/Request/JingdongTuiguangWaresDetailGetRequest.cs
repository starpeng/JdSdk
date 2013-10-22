#region head comment
/*
Code generate by JdSdkTool.
2013-04-03 12:45:23.73270 +08:00
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
    /// 获得商品详情页推广链接信息 Request
    /// </summary>
    public class JingdongTuiguangWaresDetailGetRequest : JdRequestBase<JingdongTuiguangWaresDetailGetResponse>
    {
        /// <summary>
        /// 需要返回的字段，可选字段：ware_id,title,price,m_url,ware_imgs,skus
        /// </summary>
        [XmlElement("fields")]
        [JsonProperty("fields")]
        public String Fields
        {
            get;
            set;
        }

        /// <summary>
        /// 商品的编号，只支持一个skuId  需要通过面向用户用户服务中的商品服务的jingdong.wares.searchbycid接口来获得的ware_id即为sku_ids；
        /// </summary>
        [XmlElement("sku_ids")]
        [JsonProperty("sku_ids")]
        public String SkuIds
        {
            get;
            set;
        }

        /// <summary>
        /// 标识一个应用是否来在无线或者手机应用,如果是true则会使用其他规则加密点击串.否则默认是false. 为保留字段
        /// </summary>
        [XmlElement("is_mobile")]
        [JsonProperty("is_mobile")]
        public String IsMobile
        {
            get;
            set;
        }

        /// <summary>
        /// 链接的形式有三种，图片+文字  对应的编号为3，图片  对应的编号为1，文字链  对应的编号为2，默认情况下为3
        /// </summary>
        [XmlElement("link_type")]
        [JsonProperty("link_type")]
        public String LinkType
        {
            get;
            set;
        }

        /// <summary>
        /// 表示显示区域的大小的类型，其中当link_type=3时，有四种取值，取值为5对应区域尺寸为258*88  ，取值为6对应区域尺寸为158*152 ，取值为7，对应区域尺寸为308*140，取值为8，对应区域尺寸为308*190 ；当link_type=1时，有两种取值，取值为14，对应160*160 ，取值为15，对应100*100 ；link_type=2时，取值为0，对应自适应  。默认取值为5 示例：当link_type=3,img_size_type=5时， 可以这样应用推广链接&lt;iframe scrolling="no"  frameborder="0"marginheight="0"marginwidth="0"width="258"  height="88" src="对应拿到的click_url "/iframe&gt;;
        /// </summary>
        [XmlElement("img_size_type")]
        [JsonProperty("img_size_type")]
        public String ImgSizeType
        {
            get;
            set;
        }

        public override String ApiName
        {
            get { return "jingdong.tuiguang.wares.detail.get"; }
        }

        protected override void PrepareParam(IDictionary<String, Object> paramters)
        {

            paramters.Add("fields", this.Fields);
            paramters.Add("sku_ids", this.SkuIds);
            paramters.Add("is_mobile", this.IsMobile);
            paramters.Add("link_type", this.LinkType);
            paramters.Add("img_size_type", this.ImgSizeType);

        }

        public override void Validate()
        {
            RequestValidator.ValidateRequired("sku_ids", this.SkuIds);
        }

    }
}
