#region head comment
/*
Code generate by JdSdkTool.
Copyright © starpeng@vip.qq.com
2013-09-07 15:01:55.65575 +08:00
*/
#endregion

using System;
using System.Xml.Serialization;
using Newtonsoft.Json;

namespace JdSdk.Response
{
    /// <summary>
    /// 促销创建完毕，提交保存促销命令。完成创建促销，必须调用该接口，否则相关数据将会被清除 Response
    /// </summary>
    public class JingdongSellerPromotionCommitResponse : JdResponse
    {
        /// <summary>
        /// 
        /// </summary>
        [XmlElement("success")]
        [JsonProperty("success")]
        public Nullable<Boolean> Success
        {
            get;
            set;
        }

    }
}
