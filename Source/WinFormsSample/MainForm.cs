#region CopyRight
/**************************************************************
   Copyright (c) 2012 StarPeng. All rights reserved.
   CLR版本        :    4.0.30319.225
   命名空间名称   :    $rootnamespace$
   文件名         :    Form1
   创建时间       :    2012/7/1 10:26:53
   用户所在的域   :    SWKEJIT410
   登录用户名     :    StarPeng
   文件描述       :    
   版本           :    1.0.0
   历史           :    
   最后更新人     :   
   最后更新时间   :   
 **************************************************************/
#endregion CopyRight

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Diagnostics;
using JdSdk;
using JdSdk.Response;
using JdSdk.Request;
using JdSdk.Domain;

namespace WinFormsSample
{
    public partial class MainForm : Form
    {
        protected JdSdk.DefaultJdClient Client;

        public MainForm()
        {
            InitializeComponent();
        }

        private void btnWareList_Click(object sender, EventArgs e)
        {
            AllocConsole();
            if (CheckAuth(true))
            {
                Console.WriteLine("开始获取前100个商品！");
                try
                {
                    Decimal totalCount = 0;
                    List<Ware> list = GetWareList(1, 100, out totalCount);
                    Console.WriteLine("商品总计{0}个。", totalCount);
                    Console.WriteLine(Newtonsoft.Json.JsonConvert.SerializeObject(list));
                }
                catch (Exception ex)
                {
                    ShowError(ex.Message);
                }
            }
            else
            {
                ShowError("授权检查失败");
            }
        }

        private void btnOrderList_Click(object sender, EventArgs e)
        {
            AllocConsole();
            if (CheckAuth(true))
            {
                Console.WriteLine("开始获取最近两个星期待出库的订单！");
                try
                {
                    List<OrderInfo> list = GetOrderList(DateTime.Now.AddDays(-7), DateTime.Now, "WAIT_SELLER_STOCK_OUT");
                    Console.WriteLine(Newtonsoft.Json.JsonConvert.SerializeObject(list));
                }
                catch (Exception ex)
                {
                    ShowError(ex.Message);
                }
            }
            else
            {
                ShowError("授权检查失败");
            }
        }

        private void btnRegionList_Click(object sender, EventArgs e)
        {
            AllocConsole();
            if (CheckAuth(false))
            {
                Console.WriteLine("开始获取最区域列表！");
                try
                {
                    List<JdSdk.Domain.Region> list = GetRegionList();
                    Console.WriteLine(Newtonsoft.Json.JsonConvert.SerializeObject(list));
                }
                catch (Exception ex)
                {
                    ShowError(ex.Message);
                }
            }
            else
            {
                ShowError("授权检查失败");
            }
        }


        private Boolean CheckAuth(Boolean needAccessToken)
        {
            Console.WriteLine("检查授权！");
            Boolean ok = false;
            if (!needAccessToken)
            {
                if (String.IsNullOrEmpty(AppContext.AppKey) || String.IsNullOrEmpty(AppContext.AppSecret))
                {
                    AuthForm authForm = new AuthForm();
                    if (authForm.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                    {
                        AppContext.AppKey = authForm.AppKey;
                        AppContext.AppSecret = authForm.AppSecret;
                        AppContext.AccessToken = null;
                        ok = true;
                    }
                }
                else
                {
                    ok = true;
                }
            }
            else
            {
                ok = AppContext.CheckAccessToken();
                if (!ok)
                {
                    Console.WriteLine("打开授权界面！");
                    AuthForm authForm = new AuthForm();
                    if (authForm.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                    {
                        Console.WriteLine("授权成功！");
                        AppContext.AppKey = authForm.AppKey;
                        AppContext.AppSecret = authForm.AppSecret;
                        AppContext.AccessToken = authForm.AccessToken;
                        ok = true;
                    }
                }
            }

            if (ok)
            {
                this.Client = new DefaultJdClient(AppContext.ServerURL, AppContext.AppKey, AppContext.AppSecret);
            }
            else
            {
                this.Client = null;
            }

            return ok;
        }

        private Boolean consoleAlloced = false;

        private void AllocConsole()
        {
            if (!consoleAlloced)
            {
                Utility.AllocConsole();
                consoleAlloced = true;
            }
        }

        private const String ErrorTitle = "错误";
        private const String InfoTitle = "信息";

        public void ShowError(string message)
        {
            ConsoleColor cc = Console.ForegroundColor;
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine(message);
            Console.ForegroundColor = cc;
        }

        #region 订单列表示例

        public List<OrderInfo> GetOrderList(DateTime startDate, DateTime endDate, string orderState)
        {
            Int32 totalCount;
            string newApiOrderStates = "WAIT_SELLER_STOCK_OUT,WAIT_SELLER_DELIVERY,TRADE_CANCELED";
            if (newApiOrderStates.IndexOf(orderState, StringComparison.InvariantCultureIgnoreCase) >= 0)
            {
                return GetOrderList(startDate, endDate, orderState, 1, 100, out totalCount, true);
            }
            else
            {
                totalCount = 0;
                return new List<OrderInfo>();
            }
        }

        public List<OrderInfo> GetOrderList(DateTime startDate, DateTime endDate, string orderState, int page, int pageSize, out Int32 totalCount)
        {
            string newApiOrderStates = "WAIT_SELLER_STOCK_OUT,WAIT_SELLER_DELIVERY,TRADE_CANCELED";
            if (newApiOrderStates.IndexOf(orderState, StringComparison.InvariantCultureIgnoreCase) >= 0)
            {
                return GetOrderList(startDate, endDate, orderState, 1, 100, out totalCount, false);
            }
            else
            {
                totalCount = 0;
                return new List<OrderInfo>();
            }
        }

        private List<OrderInfo> GetOrderList(DateTime startDate, DateTime endDate, string orderState, int page, int pageSize, out Int32 totalCount, bool recursive)
        {
            try
            {
                OrderSearchRequest request = new OrderSearchRequest();
                request.StartDate = startDate;
                request.EndDate = endDate;
                request.OrderState = orderState;
                request.Page = page;
                request.PageSize = pageSize;
                OrderSearchResponse response = Client.Execute(request, AppContext.AccessToken.Token);
                if (!response.IsError)
                {
                    List<OrderInfo> list = new List<OrderInfo>();
                    if (response.OrderSearch == null || response.OrderSearch.OrderInfoList == null || response.OrderSearch.OrderInfoList.Count == 0)
                    {
                        totalCount = 0;
                        return list;
                    }

                    list.AddRange(response.OrderSearch.OrderInfoList);
                    if (recursive && page * pageSize < response.OrderSearch.OrderTotal)
                    {
                        list.AddRange(GetOrderList(startDate, endDate, orderState, ++page, pageSize, out totalCount, true));
                    }

                    totalCount = response.OrderSearch.OrderTotal;
                    return list;
                }
                else
                {
                    throw new Exception(response.ErrCode + "：" + response.ErrMsg);
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        #endregion

        #region 订单列表示例

        public List<Ware> GetWareList()
        {
            return GetWareList(null, null, null, null);
        }

        public List<Ware> GetWareList(Int32 page, Int32 pageSize, out Decimal totalCount)
        {
            return GetWareList(null, null, null, null, page, pageSize, out totalCount, false);
        }

        public List<Ware> GetWareList(Nullable<Decimal> cid, Nullable<Decimal> startPrice, Nullable<Decimal> endPrice, String title)
        {
            Decimal totalCount = 0;
            return GetWareList(cid, startPrice, endPrice, title, 1, 100, out totalCount, true);
        }

        public List<Ware> GetWareList(Nullable<Decimal> cid, Nullable<Decimal> startPrice, Nullable<Decimal> endPrice, String title, Int32 page, Int32 pageSize, out Decimal totalCount)
        {
            return GetWareList(cid, startPrice, endPrice, title, 1, 100, out totalCount, false);
        }

        public List<Ware> GetWareList(Nullable<Decimal> cid, Nullable<Decimal> startPrice, Nullable<Decimal> endPrice, String title, Int32 page, Int32 pageSize, out Decimal totalCount, bool recursive)
        {
            try
            {
                WaresSearchRequest request = new WaresSearchRequest();
                request.Cid = cid;
                request.StartPrice = startPrice;
                request.EndPrice = endPrice;
                request.Page = page;
                request.Title = title;
                request.PageSize = pageSize;
                WaresSearchResponse response = Client.Execute(request, AppContext.AccessToken.Token);
                List<Ware> list = new List<Ware>();
                if (!response.IsError)
                {
                    if (response.Wares == null || response.Wares.Count == 0)
                    {
                        totalCount = 0;
                        return list;
                    }

                    list.AddRange(response.Wares);

                    if (recursive && page * pageSize < response.Total)
                    {
                        list.AddRange(GetWareList(cid, startPrice, endPrice, title, ++page, pageSize, out totalCount, true));
                    }

                    if (response.Total.HasValue)
                    {
                        totalCount = response.Total.Value;
                    }
                    else
                    {
                        totalCount = 0;
                    }

                    return list;
                }
                else
                {
                    throw new Exception(response.ErrCode + "：" + response.ErrMsg);
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        #endregion

        private List<JdSdk.Domain.Region> GetRegionList()
        {
            try
            {
                JingdongRegioninfoGetRequest request = new JingdongRegioninfoGetRequest();
                JingdongRegioninfoGetResponse response = Client.Execute(request, "NO");
                if (!response.IsError)
                {
                    List<JdSdk.Domain.Region> list = response.Regions;
                    Console.WriteLine("区域列表共计{0}个！", list.Count);
                    return list;
                }
                else
                {
                    throw new Exception(response.ErrCode + "：" + response.ErrMsg);
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}

