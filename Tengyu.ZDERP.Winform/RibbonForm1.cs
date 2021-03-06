﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraBars;
using DevExpress.XtraBars.Helpers;
using Tengyu.ZDERP.Winform.Module;
using DevExpress.XtraBars.Navigation;
using Tengyu.ZDERP.Infrastructure;
using Tengyu.ZDERP.Data;

namespace Tengyu.ZDERP.Winform
{
    public partial class RibbonForm1 : DevExpress.XtraBars.Ribbon.RibbonForm
    {
        /// <summary>
        /// 用户
        /// </summary>
        public User _User { get; set; }
        /// <summary>
        /// 生产计划
        /// </summary>
        public ProductionControl _ProductionControl { get; set; }
        /// <summary>
        /// 销售管理
        /// </summary>
        public SaleControl _SaleControl { get; set; }
        /// <summary>
        /// 审核管理
        /// </summary>
        public VerifyControl _VerifyControl { get; set; }

        public RibbonForm1()
        {
            InitializeComponent();
            // This line of code is generated by Data Source Configuration Wizard
            //shenpiTableAdapter1.Fill(comsDataSet1.Shenpi);
        }

        private void RibbonForm1_Load(object sender, EventArgs e)
        {
            //SkinHelper.InitSkinGallery(rgbi_Skins, true);
        }
        /// <summary>
        /// 销售管理
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void nBI_Sale_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            NavigationPageBase npb = new TabNavigationPage();
            npb.Name = "tP_SaleControl";
            npb.Caption = "销售管理";

            if (_SaleControl == null)
            {
                _SaleControl = new SaleControl();
                _SaleControl.Dock = DockStyle.Fill;
                npb.Controls.Add(_SaleControl);
            }

            if (tP_Main.Pages.Contains(npb, new NavClass()))
            {
                this.tP_Main.SelectedPage = (TabNavigationPage)tP_Main.Pages.First(q => q.Name == npb.Name);
            }
            else
            {
                this.tP_Main.Pages.Add(npb);
                this.tP_Main.SelectedPage = (TabNavigationPage)tP_Main.Pages.First(q => q.Name == npb.Name);
            }

            SetMenuDisplay(npb.Caption);
        }
        /// <summary>
        /// 审核管理
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void nBI_Verify_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            NavigationPageBase npb = new TabNavigationPage();
            npb.Name = "tP_VerifyControl";
            npb.Caption = "审核管理";
            if (_VerifyControl == null)
            {
                _VerifyControl = new VerifyControl();
                _VerifyControl.Dock = DockStyle.Fill;
                npb.Controls.Add(_VerifyControl);
            }

            if (tP_Main.Pages.Contains(npb, new NavClass()))
            {
                this.tP_Main.SelectedPage = (TabNavigationPage)tP_Main.Pages.First(q => q.Name == npb.Name);
            }
            else
            {
                this.tP_Main.Pages.Add(npb);
                this.tP_Main.SelectedPage = (TabNavigationPage)tP_Main.Pages.First(q => q.Name == npb.Name);
            }

            SetMenuDisplay(npb.Caption);
        }
        /// <summary>
        /// 生产计划
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void nBI_Production_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            NavigationPageBase npb = new TabNavigationPage();
            npb.Name = "tP_ProductionControl";
            npb.Caption = "生产计划";

            if (_ProductionControl == null)
            {
                _ProductionControl = new ProductionControl();
                _ProductionControl.Dock = DockStyle.Fill;
                npb.Controls.Add(_ProductionControl);
            }

            if (tP_Main.Pages.Contains(npb, new NavClass()))
            {
                this.tP_Main.SelectedPage = (TabNavigationPage)tP_Main.Pages.First(q => q.Name == npb.Name);
            }
            else
            {
                this.tP_Main.Pages.Add(npb);
                this.tP_Main.SelectedPage = (TabNavigationPage)tP_Main.Pages.First(q => q.Name == npb.Name);
            }
            SetMenuDisplay(npb.Caption);

        }
        /// <summary>
        /// 采购管理
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void nBI_Purchase_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {

        }
        /// <summary>
        /// 仓库管理
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void nBI_Store_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {

        }
        /// <summary>
        /// 存货核算
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void nBI_Stock_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {

        }
        /// <summary>
        /// 系统管理
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void nBI_System_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {

        }
        /// <summary>
        /// 显示菜单
        /// </summary>
        /// <param name="key"></param>
        private void SetMenuDisplay(string key)
        {
            this.rP_Production.Visible = false;
            this.rP_Purchase.Visible = false;
            this.rP_Sale.Visible = false;
            this.rP_Stock.Visible = false;
            this.rP_Store.Visible = false;
            this.rP_System.Visible = false;
            this.rP_Verify.Visible = false;

            switch (key)
            {
                case "销售管理":
                    this.rP_Sale.Visible = true;
                    break;
                case "审核管理":
                    this.rP_Verify.Visible = true;
                    break;
                case "生产计划":
                    this.rP_Production.Visible = true;
                    break;
                default:
                    break;
            }
        }
        /// <summary>
        /// 设置菜单改变
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void tP_Main_SelectedPageChanged(object sender, SelectedPageChangedEventArgs e)
        {
            if (!string.IsNullOrEmpty(((TabPane)sender).SelectedPage.Caption))
            {
                SetMenuDisplay(((TabPane)sender).SelectedPage.Caption);
            }
        }

        #region 销售订单
        /// <summary>
        /// 增加销售订单
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void bBi_AddSaleOrder_ItemClick(object sender, ItemClickEventArgs e)
        {
            //销售订单
            SalesOrder sales = new SalesOrder();
            //选中文件弹窗
            NewSaleForm nsf = new NewSaleForm(_User, sales);

            if (nsf.ShowDialog() == DialogResult.OK)
            {
                new SaleClass().AddSale(nsf._SalesOrder);
            }
        }
        /// <summary>
        /// 查看订单
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void bBi_ViewOrder_ItemClick(object sender, ItemClickEventArgs e)
        {

        }
        /// <summary>
        /// 提交订单
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void bBi_SubmitOrder_ItemClick(object sender, ItemClickEventArgs e)
        {

        }
        /// <summary>
        /// 撤回订单
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void bBi_WithdrawOrder_ItemClick(object sender, ItemClickEventArgs e)
        {

        }
        /// <summary>
        /// 删除订单
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void bBi_DeleteOrder_ItemClick(object sender, ItemClickEventArgs e)
        {

        }
        /// <summary>
        /// 刷新
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void bBi_RefreshOrder_ItemClick(object sender, ItemClickEventArgs e)
        {

        }
        #endregion

        #region 审批管理
        /// <summary>
        /// 审批通过
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void bBi_ApprovalVerify_ItemClick(object sender, ItemClickEventArgs e)
        {

        }
        /// <summary>
        /// 审批驳回
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void bBi_RejectedVerify_ItemClick(object sender, ItemClickEventArgs e)
        {

        }
        /// <summary>
        /// 撤销审批
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void bBi_WithdrawVerify_ItemClick(object sender, ItemClickEventArgs e)
        {

        }
        /// <summary>
        /// 刷新
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void bBi_RefreshVerify_ItemClick(object sender, ItemClickEventArgs e)
        {

        }
        #endregion

        #region 生产计划
        /// <summary>
        /// 添加生产计划
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void bBi_AddProduction_ItemClick(object sender, ItemClickEventArgs e)
        {

        }
        /// <summary>
        /// 删除生产计划
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void bBi_DeleteProduction_ItemClick(object sender, ItemClickEventArgs e)
        {

        }
        /// <summary>
        /// 刷新
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void bBi_RefreshProduction_ItemClick(object sender, ItemClickEventArgs e)
        {

        }
        #endregion
    }
    /// <summary>
    /// 比较器
    /// </summary>
    internal class NavClass : IEqualityComparer<NavigationPageBase>
    {

        bool IEqualityComparer<NavigationPageBase>.Equals(NavigationPageBase x, NavigationPageBase y)
        {
            return x.Name == y.Name;
        }

        int IEqualityComparer<NavigationPageBase>.GetHashCode(NavigationPageBase obj)
        {
            return obj.GetHashCode();
        }
    }
}