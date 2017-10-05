namespace Tengyu.ZDERP.Winform.Module
{
    partial class VerifyControl
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(VerifyControl));
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.navBarControl1 = new DevExpress.XtraNavBar.NavBarControl();
            this.navBarGroup1 = new DevExpress.XtraNavBar.NavBarGroup();
            this.navBarItem1 = new DevExpress.XtraNavBar.NavBarItem();
            this.navBarItem2 = new DevExpress.XtraNavBar.NavBarItem();
            this.navBarItem9 = new DevExpress.XtraNavBar.NavBarItem();
            this.navBarItem4 = new DevExpress.XtraNavBar.NavBarItem();
            this.navBarItem5 = new DevExpress.XtraNavBar.NavBarItem();
            this.navBarItem6 = new DevExpress.XtraNavBar.NavBarItem();
            this.navBarItem7 = new DevExpress.XtraNavBar.NavBarItem();
            this.navBarItem8 = new DevExpress.XtraNavBar.NavBarItem();
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colId = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colsubmiter = new DevExpress.XtraGrid.Columns.GridColumn();
            this.coltodoer = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colsubmitState = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repositoryItemComboBox1 = new DevExpress.XtraEditors.Repository.RepositoryItemComboBox();
            this.colcreatetime = new DevExpress.XtraGrid.Columns.GridColumn();
            this.coltodotime = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colsubmittime = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repositoryItemImageEdit1 = new DevExpress.XtraEditors.Repository.RepositoryItemImageEdit();
            this.navDing = new DevExpress.XtraNavBar.NavBarGroup();
            this.navBarItem3 = new DevExpress.XtraNavBar.NavBarItem();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.navBarControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemComboBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemImageEdit1)).BeginInit();
            this.SuspendLayout();
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.navBarControl1);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.gridControl1);
            this.splitContainer1.Size = new System.Drawing.Size(1132, 640);
            this.splitContainer1.SplitterDistance = 200;
            this.splitContainer1.TabIndex = 0;
            // 
            // navBarControl1
            // 
            this.navBarControl1.ActiveGroup = this.navBarGroup1;
            this.navBarControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.navBarControl1.Groups.AddRange(new DevExpress.XtraNavBar.NavBarGroup[] {
            this.navBarGroup1});
            this.navBarControl1.Items.AddRange(new DevExpress.XtraNavBar.NavBarItem[] {
            this.navBarItem1,
            this.navBarItem2,
            this.navBarItem4,
            this.navBarItem5,
            this.navBarItem6,
            this.navBarItem7,
            this.navBarItem8,
            this.navBarItem9});
            this.navBarControl1.Location = new System.Drawing.Point(0, 0);
            this.navBarControl1.LookAndFeel.SkinName = "Office 2013 Light Gray";
            this.navBarControl1.LookAndFeel.Style = DevExpress.LookAndFeel.LookAndFeelStyle.Office2003;
            this.navBarControl1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.navBarControl1.Name = "navBarControl1";
            this.navBarControl1.OptionsNavPane.ExpandedWidth = 200;
            this.navBarControl1.Size = new System.Drawing.Size(200, 640);
            this.navBarControl1.TabIndex = 1;
            this.navBarControl1.Text = "navBarControl1";
            // 
            // navBarGroup1
            // 
            this.navBarGroup1.Caption = "审批";
            this.navBarGroup1.Expanded = true;
            this.navBarGroup1.ItemLinks.AddRange(new DevExpress.XtraNavBar.NavBarItemLink[] {
            new DevExpress.XtraNavBar.NavBarItemLink(this.navBarItem1),
            new DevExpress.XtraNavBar.NavBarItemLink(this.navBarItem2),
            new DevExpress.XtraNavBar.NavBarItemLink(this.navBarItem9)});
            this.navBarGroup1.Name = "navBarGroup1";
            this.navBarGroup1.SmallImage = ((System.Drawing.Image)(resources.GetObject("navBarGroup1.SmallImage")));
            // 
            // navBarItem1
            // 
            this.navBarItem1.Caption = "待审批";
            this.navBarItem1.Name = "navBarItem1";
            this.navBarItem1.SmallImage = ((System.Drawing.Image)(resources.GetObject("navBarItem1.SmallImage")));
            // 
            // navBarItem2
            // 
            this.navBarItem2.Caption = "已通过";
            this.navBarItem2.Name = "navBarItem2";
            this.navBarItem2.SmallImage = ((System.Drawing.Image)(resources.GetObject("navBarItem2.SmallImage")));
            // 
            // navBarItem9
            // 
            this.navBarItem9.Caption = "已驳回";
            this.navBarItem9.Name = "navBarItem9";
            this.navBarItem9.SmallImage = ((System.Drawing.Image)(resources.GetObject("navBarItem9.SmallImage")));
            // 
            // navBarItem4
            // 
            this.navBarItem4.Caption = "营销部相关";
            this.navBarItem4.Name = "navBarItem4";
            this.navBarItem4.SmallImage = ((System.Drawing.Image)(resources.GetObject("navBarItem4.SmallImage")));
            // 
            // navBarItem5
            // 
            this.navBarItem5.Caption = "采购部相关";
            this.navBarItem5.Name = "navBarItem5";
            this.navBarItem5.SmallImage = ((System.Drawing.Image)(resources.GetObject("navBarItem5.SmallImage")));
            // 
            // navBarItem6
            // 
            this.navBarItem6.Caption = "生产部相关";
            this.navBarItem6.Name = "navBarItem6";
            this.navBarItem6.SmallImage = ((System.Drawing.Image)(resources.GetObject("navBarItem6.SmallImage")));
            // 
            // navBarItem7
            // 
            this.navBarItem7.Caption = "原料仓相关";
            this.navBarItem7.Name = "navBarItem7";
            this.navBarItem7.SmallImage = ((System.Drawing.Image)(resources.GetObject("navBarItem7.SmallImage")));
            // 
            // navBarItem8
            // 
            this.navBarItem8.Caption = "成品仓相关";
            this.navBarItem8.Name = "navBarItem8";
            this.navBarItem8.SmallImage = ((System.Drawing.Image)(resources.GetObject("navBarItem8.SmallImage")));
            // 
            // gridControl1
            // 
            this.gridControl1.DataMember = "Shenpi";
            this.gridControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridControl1.EmbeddedNavigator.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.gridControl1.Location = new System.Drawing.Point(0, 0);
            this.gridControl1.MainView = this.gridView1;
            this.gridControl1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.repositoryItemComboBox1,
            this.repositoryItemImageEdit1});
            this.gridControl1.Size = new System.Drawing.Size(928, 640);
            this.gridControl1.TabIndex = 3;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colId,
            this.colsubmiter,
            this.coltodoer,
            this.colsubmitState,
            this.colcreatetime,
            this.coltodotime,
            this.colsubmittime});
            this.gridView1.GridControl = this.gridControl1;
            this.gridView1.GroupPanelText = "分组";
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsFind.AlwaysVisible = true;
            this.gridView1.OptionsFind.FindNullPrompt = "输入关键字...";
            this.gridView1.OptionsFind.ShowClearButton = false;
            this.gridView1.OptionsFind.ShowCloseButton = false;
            this.gridView1.OptionsFind.ShowFindButton = false;
            this.gridView1.OptionsView.ShowAutoFilterRow = true;
            this.gridView1.OptionsView.ShowFilterPanelMode = DevExpress.XtraGrid.Views.Base.ShowFilterPanelMode.ShowAlways;
            this.gridView1.OptionsView.ShowFooter = true;
            // 
            // colId
            // 
            this.colId.Caption = "序号";
            this.colId.FieldName = "Id";
            this.colId.Name = "colId";
            this.colId.Visible = true;
            this.colId.VisibleIndex = 0;
            // 
            // colsubmiter
            // 
            this.colsubmiter.Caption = "提交人";
            this.colsubmiter.FieldName = "submiter";
            this.colsubmiter.Name = "colsubmiter";
            this.colsubmiter.Visible = true;
            this.colsubmiter.VisibleIndex = 1;
            // 
            // coltodoer
            // 
            this.coltodoer.Caption = "审批人";
            this.coltodoer.FieldName = "todoer";
            this.coltodoer.Name = "coltodoer";
            this.coltodoer.Visible = true;
            this.coltodoer.VisibleIndex = 2;
            // 
            // colsubmitState
            // 
            this.colsubmitState.Caption = "审批状态";
            this.colsubmitState.ColumnEdit = this.repositoryItemComboBox1;
            this.colsubmitState.FieldName = "submitState";
            this.colsubmitState.Name = "colsubmitState";
            this.colsubmitState.Visible = true;
            this.colsubmitState.VisibleIndex = 3;
            // 
            // repositoryItemComboBox1
            // 
            this.repositoryItemComboBox1.AutoHeight = false;
            this.repositoryItemComboBox1.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.repositoryItemComboBox1.Items.AddRange(new object[] {
            "未审批",
            "审批通过",
            "审批驳回"});
            this.repositoryItemComboBox1.Name = "repositoryItemComboBox1";
            // 
            // colcreatetime
            // 
            this.colcreatetime.Caption = "创建时间";
            this.colcreatetime.FieldName = "createtime";
            this.colcreatetime.Name = "colcreatetime";
            this.colcreatetime.Visible = true;
            this.colcreatetime.VisibleIndex = 4;
            // 
            // coltodotime
            // 
            this.coltodotime.Caption = "审批时间";
            this.coltodotime.FieldName = "todotime";
            this.coltodotime.Name = "coltodotime";
            this.coltodotime.Visible = true;
            this.coltodotime.VisibleIndex = 5;
            // 
            // colsubmittime
            // 
            this.colsubmittime.Caption = "提交审批时间";
            this.colsubmittime.FieldName = "submittime";
            this.colsubmittime.Name = "colsubmittime";
            this.colsubmittime.Visible = true;
            this.colsubmittime.VisibleIndex = 6;
            // 
            // repositoryItemImageEdit1
            // 
            this.repositoryItemImageEdit1.AutoHeight = false;
            this.repositoryItemImageEdit1.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.repositoryItemImageEdit1.Name = "repositoryItemImageEdit1";
            // 
            // navDing
            // 
            this.navDing.Caption = "审批";
            this.navDing.Expanded = true;
            this.navDing.Name = "navDing";
            this.navDing.SmallImage = ((System.Drawing.Image)(resources.GetObject("navDing.SmallImage")));
            // 
            // navBarItem3
            // 
            this.navBarItem3.Caption = "已驳回";
            this.navBarItem3.Name = "navBarItem3";
            this.navBarItem3.SmallImage = ((System.Drawing.Image)(resources.GetObject("navBarItem3.SmallImage")));
            // 
            // VerifyControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.splitContainer1);
            this.Name = "VerifyControl";
            this.Size = new System.Drawing.Size(1132, 640);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.navBarControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemComboBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemImageEdit1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer1;
        private DevExpress.XtraNavBar.NavBarGroup navDing;
        private DevExpress.XtraNavBar.NavBarControl navBarControl1;
        private DevExpress.XtraNavBar.NavBarGroup navBarGroup1;
        private DevExpress.XtraNavBar.NavBarItem navBarItem1;
        private DevExpress.XtraNavBar.NavBarItem navBarItem2;
        private DevExpress.XtraNavBar.NavBarItem navBarItem4;
        private DevExpress.XtraNavBar.NavBarItem navBarItem5;
        private DevExpress.XtraNavBar.NavBarItem navBarItem6;
        private DevExpress.XtraNavBar.NavBarItem navBarItem7;
        private DevExpress.XtraNavBar.NavBarItem navBarItem8;
        private DevExpress.XtraGrid.GridControl gridControl1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraGrid.Columns.GridColumn colId;
        private DevExpress.XtraGrid.Columns.GridColumn colsubmiter;
        private DevExpress.XtraGrid.Columns.GridColumn coltodoer;
        private DevExpress.XtraGrid.Columns.GridColumn colsubmitState;
        private DevExpress.XtraEditors.Repository.RepositoryItemComboBox repositoryItemComboBox1;
        private DevExpress.XtraGrid.Columns.GridColumn colcreatetime;
        private DevExpress.XtraGrid.Columns.GridColumn coltodotime;
        private DevExpress.XtraGrid.Columns.GridColumn colsubmittime;
        private DevExpress.XtraEditors.Repository.RepositoryItemImageEdit repositoryItemImageEdit1;
        private DevExpress.XtraNavBar.NavBarItem navBarItem3;
        private DevExpress.XtraNavBar.NavBarItem navBarItem9;
    }
}
