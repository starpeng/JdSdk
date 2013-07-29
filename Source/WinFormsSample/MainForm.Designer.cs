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

namespace WinFormsSample
{
    partial class MainForm
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.btnWareList = new System.Windows.Forms.Button();
            this.btnOrderList = new System.Windows.Forms.Button();
            this.btnRegionList = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnWareList
            // 
            this.btnWareList.Location = new System.Drawing.Point(15, 32);
            this.btnWareList.Name = "btnWareList";
            this.btnWareList.Size = new System.Drawing.Size(242, 23);
            this.btnWareList.TabIndex = 0;
            this.btnWareList.Text = "商品列表";
            this.btnWareList.UseVisualStyleBackColor = true;
            this.btnWareList.Click += new System.EventHandler(this.btnWareList_Click);
            // 
            // btnOrderList
            // 
            this.btnOrderList.Location = new System.Drawing.Point(15, 107);
            this.btnOrderList.Name = "btnOrderList";
            this.btnOrderList.Size = new System.Drawing.Size(242, 23);
            this.btnOrderList.TabIndex = 0;
            this.btnOrderList.Text = "待发货订单列表";
            this.btnOrderList.UseVisualStyleBackColor = true;
            this.btnOrderList.Click += new System.EventHandler(this.btnOrderList_Click);
            // 
            // btnRegionList
            // 
            this.btnRegionList.Location = new System.Drawing.Point(12, 184);
            this.btnRegionList.Name = "btnRegionList";
            this.btnRegionList.Size = new System.Drawing.Size(242, 23);
            this.btnRegionList.TabIndex = 0;
            this.btnRegionList.Text = "地区代码信息";
            this.btnRegionList.UseVisualStyleBackColor = true;
            this.btnRegionList.Click += new System.EventHandler(this.btnRegionList_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(280, 219);
            this.Controls.Add(this.btnOrderList);
            this.Controls.Add(this.btnRegionList);
            this.Controls.Add(this.btnWareList);
            this.Name = "MainForm";
            this.Text = "示例";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnWareList;
        private System.Windows.Forms.Button btnOrderList;
        private System.Windows.Forms.Button btnRegionList;

    }
}


