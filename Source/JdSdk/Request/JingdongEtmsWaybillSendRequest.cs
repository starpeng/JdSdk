#region head comment
/*
Code generate by JdSdkTool.
2013-12-21 10:56:35.14508 +08:00
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
    /// 向京东物流系统提交运单信息   相关文档下载：ERP对接方案【11月4日更新】   京东快递可配送区域 Request
    /// </summary>
    public class JingdongEtmsWaybillSendRequest : JdRequestBase<JingdongEtmsWaybillSendResponse>
    {
        /// <summary>
        /// 运单号（通过jingdong.etms.waybillcode.get获取到的运单号）
        /// </summary>
        [XmlElement("deliveryId")]
        [JsonProperty("deliveryId")]
        public String DeliveryId
        {
            get;
            set;
        }

        /// <summary>
        /// 京东快递物流系统为各平台维护了数据字典，如为京东平台，则传入0010001。如没有以下平台，可传入0030001（即其他），数据字典如下：       0010001 京东       0010002 天猫       0010003 苏宁       0010004 亚马逊中国       0020001 ChinaSkin      0030001 其他小型销售平台       务必保证该字段的正确
        /// </summary>
        [XmlElement("salePlat")]
        [JsonProperty("salePlat")]
        public String SalePlat
        {
            get;
            set;
        }

        /// <summary>
        /// 商家跟京东快递签订合同后京东快递给商家根据店铺创建的编号，需要唯一。       商家编码（登录京东物流网站（http://www.jd-ex.com/）查看。如无登录账号，可向配送运营人员索取。并非POP系统商家id。）
        /// </summary>
        [XmlElement("customerCode")]
        [JsonProperty("customerCode")]
        public String CustomerCode
        {
            get;
            set;
        }

        /// <summary>
        /// 商家发货商品的唯一标识，可能为ERP软件生成的新订单号，即商家订单号未必等于平台订单号
        /// </summary>
        [XmlElement("orderId")]
        [JsonProperty("orderId")]
        public String OrderId
        {
            get;
            set;
        }

        /// <summary>
        /// 如果订单为京东平台订单，此字段必填。       如果该订单为京东平台之外的订单，请为空。
        /// </summary>
        /// <example>如果销售平台编码为0010001（京东），则此字段不能为空。</example>
        [XmlElement("thrOrderId")]
        [JsonProperty("thrOrderId")]
        public String ThrOrderId
        {
            get;
            set;
        }

        /// <summary>
        /// 是否客户打印运单(是：1，否：0。不填或者超出范围，默认是1)
        /// </summary>
        /// <example>1</example>
        [XmlElement("selfPrintWayBill")]
        [JsonProperty("selfPrintWayBill")]
        public Int64 SelfPrintWayBill
        {
            get;
            set;
        }

        /// <summary>
        /// 取件方式(上门收货：1，自送：2。不填或者超出范围，默认是1)
        /// </summary>
        /// <example>1</example>
        [XmlElement("pickMethod")]
        [JsonProperty("pickMethod")]
        public String PickMethod
        {
            get;
            set;
        }

        /// <summary>
        /// 包装要求(不需包装：1，简单包装：2，特殊包装：3。不填或者超出范围，默认是1)
        /// </summary>
        /// <example>1</example>
        [XmlElement("packageRequired")]
        [JsonProperty("packageRequired")]
        public String PackageRequired
        {
            get;
            set;
        }

        /// <summary>
        /// 寄件人姓名
        /// </summary>
        [XmlElement("senderName")]
        [JsonProperty("senderName")]
        public String SenderName
        {
            get;
            set;
        }

        /// <summary>
        /// 寄件人地址
        /// </summary>
        [XmlElement("senderAddress")]
        [JsonProperty("senderAddress")]
        public String SenderAddress
        {
            get;
            set;
        }

        /// <summary>
        /// 寄件人电话
        /// </summary>
        [XmlElement("senderTel")]
        [JsonProperty("senderTel")]
        public String SenderTel
        {
            get;
            set;
        }

        /// <summary>
        /// 寄件人手机(寄件人电话、手机至少有一个不为空)
        /// </summary>
        [XmlElement("senderMobile")]
        [JsonProperty("senderMobile")]
        public String SenderMobile
        {
            get;
            set;
        }

        /// <summary>
        /// 寄件人邮编
        /// </summary>
        [XmlElement("senderPostcode")]
        [JsonProperty("senderPostcode")]
        public String SenderPostcode
        {
            get;
            set;
        }

        /// <summary>
        /// 收件人姓名
        /// </summary>
        [XmlElement("receiveName")]
        [JsonProperty("receiveName")]
        public String ReceiveName
        {
            get;
            set;
        }

        /// <summary>
        /// 收件人地址
        /// </summary>
        [XmlElement("receiveAddress")]
        [JsonProperty("receiveAddress")]
        public String ReceiveAddress
        {
            get;
            set;
        }

        /// <summary>
        /// 收件人省
        /// </summary>
        [XmlElement("province")]
        [JsonProperty("province")]
        public String Province
        {
            get;
            set;
        }

        /// <summary>
        /// 收件人市
        /// </summary>
        [XmlElement("city")]
        [JsonProperty("city")]
        public String City
        {
            get;
            set;
        }

        /// <summary>
        /// 收件人县
        /// </summary>
        [XmlElement("county")]
        [JsonProperty("county")]
        public String County
        {
            get;
            set;
        }

        /// <summary>
        /// 收件人镇
        /// </summary>
        [XmlElement("town")]
        [JsonProperty("town")]
        public String Town
        {
            get;
            set;
        }

        /// <summary>
        /// 收件人电话
        /// </summary>
        [XmlElement("receiveTel")]
        [JsonProperty("receiveTel")]
        public String ReceiveTel
        {
            get;
            set;
        }

        /// <summary>
        /// 收件人手机号(收件人电话、手机至少有一个不为空)
        /// </summary>
        [XmlElement("receiveMobile")]
        [JsonProperty("receiveMobile")]
        public String ReceiveMobile
        {
            get;
            set;
        }

        /// <summary>
        /// 收件人邮编
        /// </summary>
        [XmlElement("postcode")]
        [JsonProperty("postcode")]
        public String Postcode
        {
            get;
            set;
        }

        /// <summary>
        /// 该订单下的包裹数(大于0，小于1000)，几个包裹就需要打印几个快递单
        /// </summary>
        [XmlElement("packageCount")]
        [JsonProperty("packageCount")]
        public Int64 PackageCount
        {
            get;
            set;
        }

        /// <summary>
        /// 重量(单位：kg，保留小数点后两位，默认为0 )
        /// </summary>
        [XmlElement("weight")]
        [JsonProperty("weight")]
        public Int64 Weight
        {
            get;
            set;
        }

        /// <summary>
        /// 包裹长(单位：cm,保留小数点后两位)
        /// </summary>
        [XmlElement("vloumLong")]
        [JsonProperty("vloumLong")]
        public Int64 VloumLong
        {
            get;
            set;
        }

        /// <summary>
        /// 包裹宽(单位：cm，保留小数点后两位)
        /// </summary>
        [XmlElement("vloumWidth")]
        [JsonProperty("vloumWidth")]
        public Int64 VloumWidth
        {
            get;
            set;
        }

        /// <summary>
        /// 包裹高(单位：cm，保留小数点后两位)
        /// </summary>
        [XmlElement("vloumHeight")]
        [JsonProperty("vloumHeight")]
        public Int64 VloumHeight
        {
            get;
            set;
        }

        /// <summary>
        /// 体积(单位：CM3，保留小数点后两位，默认可传为0 )
        /// </summary>
        /// <example>10000</example>
        [XmlElement("vloumn")]
        [JsonProperty("vloumn")]
        public Int64 Vloumn
        {
            get;
            set;
        }

        /// <summary>
        /// 商品描述
        /// </summary>
        [XmlElement("description")]
        [JsonProperty("description")]
        public String Description
        {
            get;
            set;
        }

        /// <summary>
        /// 1为代收货款，0为非代收货款
        /// </summary>
        /// <example>1</example>
        [XmlElement("collectionValue")]
        [JsonProperty("collectionValue")]
        public Int64 CollectionValue
        {
            get;
            set;
        }

        /// <summary>
        /// 【是否代收货款】为1，则必填：保留小数点后两位，后台会校验       如果【是否代收货款】为0，则为空。 京东平台订单，此字段务必通过360buy.order.print.data.get接口should_pay字段获取。
        /// </summary>
        /// <example>98.00</example>
        [XmlElement("collectionMoney")]
        [JsonProperty("collectionMoney")]
        public Int64 CollectionMoney
        {
            get;
            set;
        }

        /// <summary>
        /// 是否保价(是：1，否：0。不填或者超出范围，默认是0)
        /// </summary>
        /// <example>1</example>
        [XmlElement("guaranteeValue")]
        [JsonProperty("guaranteeValue")]
        public Int64 GuaranteeValue
        {
            get;
            set;
        }

        /// <summary>
        /// 如果有保价，则保价金额(保留小数点后两位) 为必填，后台有校验。
        /// </summary>
        /// <example>100.00</example>
        [XmlElement("guaranteeValueAmount")]
        [JsonProperty("guaranteeValueAmount")]
        public Int64 GuaranteeValueAmount
        {
            get;
            set;
        }

        /// <summary>
        /// 签单返还(是：1，否：0。不填或者超出范围，默认是0)
        /// </summary>
        /// <example>1</example>
        [XmlElement("signReturn")]
        [JsonProperty("signReturn")]
        public Int64 SignReturn
        {
            get;
            set;
        }

        /// <summary>
        /// 时效(普通：1，工作日：2，非工作日：3，晚间：4。不填或者超出范围，默认是1)
        /// </summary>
        /// <example>1</example>
        [XmlElement("aging")]
        [JsonProperty("aging")]
        public Int64 Aging
        {
            get;
            set;
        }

        /// <summary>
        /// 运输类型(陆运：1，航空：2。不填或者超出范围，默认是1)
        /// </summary>
        /// <example>1</example>
        [XmlElement("transType")]
        [JsonProperty("transType")]
        public Int64 TransType
        {
            get;
            set;
        }

        public override String ApiName
        {
            get{ return "jingdong.etms.waybill.send"; }
        }

        protected override void PrepareParam(IDictionary<String, Object> paramters)
        {
            paramters.Add("deliveryid" ,this.DeliveryId);
            paramters.Add("saleplat" ,this.SalePlat);
            paramters.Add("customercode" ,this.CustomerCode);
            paramters.Add("orderid" ,this.OrderId);
            paramters.Add("throrderid" ,this.ThrOrderId);
            paramters.Add("selfprintwaybill" ,this.SelfPrintWayBill);
            paramters.Add("pickmethod" ,this.PickMethod);
            paramters.Add("packagerequired" ,this.PackageRequired);
            paramters.Add("sendername" ,this.SenderName);
            paramters.Add("senderaddress" ,this.SenderAddress);
            paramters.Add("sendertel" ,this.SenderTel);
            paramters.Add("sendermobile" ,this.SenderMobile);
            paramters.Add("senderpostcode" ,this.SenderPostcode);
            paramters.Add("receivename" ,this.ReceiveName);
            paramters.Add("receiveaddress" ,this.ReceiveAddress);
            paramters.Add("province" ,this.Province);
            paramters.Add("city" ,this.City);
            paramters.Add("county" ,this.County);
            paramters.Add("town" ,this.Town);
            paramters.Add("receivetel" ,this.ReceiveTel);
            paramters.Add("receivemobile" ,this.ReceiveMobile);
            paramters.Add("postcode" ,this.Postcode);
            paramters.Add("packagecount" ,this.PackageCount);
            paramters.Add("weight" ,this.Weight);
            paramters.Add("vloumlong" ,this.VloumLong);
            paramters.Add("vloumwidth" ,this.VloumWidth);
            paramters.Add("vloumheight" ,this.VloumHeight);
            paramters.Add("vloumn" ,this.Vloumn);
            paramters.Add("description" ,this.Description);
            paramters.Add("collectionvalue" ,this.CollectionValue);
            paramters.Add("collectionmoney" ,this.CollectionMoney);
            paramters.Add("guaranteevalue" ,this.GuaranteeValue);
            paramters.Add("guaranteevalueamount" ,this.GuaranteeValueAmount);
            paramters.Add("signreturn" ,this.SignReturn);
            paramters.Add("aging" ,this.Aging);
            paramters.Add("transtype" ,this.TransType);
        }

        public override void Validate()
        {
            RequestValidator.ValidateRequired("deliveryId", this.DeliveryId);
            RequestValidator.ValidateRequired("salePlat", this.SalePlat);
            RequestValidator.ValidateRequired("customerCode", this.CustomerCode);
            RequestValidator.ValidateRequired("orderId", this.OrderId);
            RequestValidator.ValidateRequired("senderName", this.SenderName);
            RequestValidator.ValidateRequired("senderAddress", this.SenderAddress);
            RequestValidator.ValidateRequired("receiveName", this.ReceiveName);
            RequestValidator.ValidateRequired("receiveAddress", this.ReceiveAddress);
            RequestValidator.ValidateRequired("packageCount", this.PackageCount);
            RequestValidator.ValidateRequired("weight", this.Weight);
            RequestValidator.ValidateRequired("vloumn", this.Vloumn);
            RequestValidator.ValidateRequired("collectionValue", this.CollectionValue);
        }

    }
}
