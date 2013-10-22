#region head comment
/*
Code generate by JdSdkTool.
2013-09-07 15:01:46.55123 +08:00
*/
#endregion

using System;
using System.Collections.Generic;
using JdSdk.Response;

namespace JdSdk.Request
{
    /// <summary>
    ///  Request
    /// </summary>
    public class JingdongImgzonePictureUpdateRequest : JdRequestBase<JingdongImgzonePictureUpdateResponse>
    {
        public override String ApiName
        {
            get { return "jingdong.imgzone.picture.update"; }
        }

        protected override void PrepareParam(IDictionary<String, Object> paramters)
        {


        }

        public override void Validate()
        {
        }

    }
}
