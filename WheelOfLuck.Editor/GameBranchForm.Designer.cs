namespace DrawGame.Editor
{
    partial class GameBranchForm
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GameBranchForm));
            this.branchBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.branchGridControl = new DevExpress.XtraGrid.GridControl();
            this.branchGridView = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colBranchCode = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colBranchName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.branchGameBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.branchGameGridControl = new DevExpress.XtraGrid.GridControl();
            this.branchGameGridView = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colBranchCode1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.RightArrowSimpleButton = new DevExpress.XtraEditors.SimpleButton();
            this.LeftArrowSimpleButton = new DevExpress.XtraEditors.SimpleButton();
            this.ribbonControl1 = new DevExpress.XtraBars.Ribbon.RibbonControl();
            this.SaveBarButtonItem = new DevExpress.XtraBars.BarButtonItem();
            this.ExitBarButtonItem = new DevExpress.XtraBars.BarButtonItem();
            this.ribbonPage1 = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.ribbonPageGroup1 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            ((System.ComponentModel.ISupportInitialize)(this.branchBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.branchGridControl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.branchGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.branchGameBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.branchGameGridControl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.branchGameGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ribbonControl1)).BeginInit();
            this.SuspendLayout();
            // 
            // branchBindingSource
            // 
            this.branchBindingSource.DataSource = typeof(DrawGame.Domain.Model.Branch);
            // 
            // branchGridControl
            // 
            this.branchGridControl.DataSource = this.branchBindingSource;
            this.branchGridControl.Location = new System.Drawing.Point(116, 173);
            this.branchGridControl.MainView = this.branchGridView;
            this.branchGridControl.Name = "branchGridControl";
            this.branchGridControl.Size = new System.Drawing.Size(300, 407);
            this.branchGridControl.TabIndex = 0;
            this.branchGridControl.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.branchGridView});
            // 
            // branchGridView
            // 
            this.branchGridView.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colBranchCode,
            this.colBranchName});
            this.branchGridView.GridControl = this.branchGridControl;
            this.branchGridView.Name = "branchGridView";
            // 
            // colBranchCode
            // 
            this.colBranchCode.Caption = "Κωδ.  Υποκαταστήματος";
            this.colBranchCode.FieldName = "BranchCode";
            this.colBranchCode.Name = "colBranchCode";
            this.colBranchCode.Visible = true;
            this.colBranchCode.VisibleIndex = 0;
            // 
            // colBranchName
            // 
            this.colBranchName.Caption = "Όνομα Υποκαταστήματος";
            this.colBranchName.FieldName = "BranchName";
            this.colBranchName.Name = "colBranchName";
            this.colBranchName.Visible = true;
            this.colBranchName.VisibleIndex = 1;
            // 
            // branchGameBindingSource
            // 
            this.branchGameBindingSource.DataSource = typeof(DrawGame.Domain.Model.BranchGame);
            // 
            // branchGameGridControl
            // 
            this.branchGameGridControl.DataSource = this.branchGameBindingSource;
            this.branchGameGridControl.Location = new System.Drawing.Point(591, 173);
            this.branchGameGridControl.MainView = this.branchGameGridView;
            this.branchGameGridControl.Name = "branchGameGridControl";
            this.branchGameGridControl.Size = new System.Drawing.Size(300, 407);
            this.branchGameGridControl.TabIndex = 1;
            this.branchGameGridControl.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.branchGameGridView});
            // 
            // branchGameGridView
            // 
            this.branchGameGridView.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colBranchCode1});
            this.branchGameGridView.GridControl = this.branchGameGridControl;
            this.branchGameGridView.Name = "branchGameGridView";
            // 
            // colBranchCode1
            // 
            this.colBranchCode1.Caption = "Κωδ.  Υποκαταστήματος";
            this.colBranchCode1.FieldName = "BranchCode";
            this.colBranchCode1.Name = "colBranchCode1";
            this.colBranchCode1.Visible = true;
            this.colBranchCode1.VisibleIndex = 0;
            // 
            // RightArrowSimpleButton
            // 
            this.RightArrowSimpleButton.Image = ((System.Drawing.Image)(resources.GetObject("RightArrowSimpleButton.Image")));
            this.RightArrowSimpleButton.Location = new System.Drawing.Point(485, 303);
            this.RightArrowSimpleButton.Name = "RightArrowSimpleButton";
            this.RightArrowSimpleButton.Size = new System.Drawing.Size(41, 37);
            this.RightArrowSimpleButton.TabIndex = 2;
            this.RightArrowSimpleButton.Click += new System.EventHandler(this.RightArrowSimpleButton_Click);
            // 
            // LeftArrowSimpleButton
            // 
            this.LeftArrowSimpleButton.Image = ((System.Drawing.Image)(resources.GetObject("LeftArrowSimpleButton.Image")));
            this.LeftArrowSimpleButton.Location = new System.Drawing.Point(485, 361);
            this.LeftArrowSimpleButton.Name = "LeftArrowSimpleButton";
            this.LeftArrowSimpleButton.Size = new System.Drawing.Size(41, 37);
            this.LeftArrowSimpleButton.TabIndex = 3;
            this.LeftArrowSimpleButton.Click += new System.EventHandler(this.LeftArrowSimpleButton_Click);
            // 
            // ribbonControl1
            // 
            this.ribbonControl1.ExpandCollapseItem.Id = 0;
            this.ribbonControl1.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.ribbonControl1.ExpandCollapseItem,
            this.SaveBarButtonItem,
            this.ExitBarButtonItem});
            this.ribbonControl1.Location = new System.Drawing.Point(0, 0);
            this.ribbonControl1.MaxItemId = 3;
            this.ribbonControl1.Name = "ribbonControl1";
            this.ribbonControl1.Pages.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPage[] {
            this.ribbonPage1});
            this.ribbonControl1.Size = new System.Drawing.Size(1031, 114);
            this.ribbonControl1.ToolbarLocation = DevExpress.XtraBars.Ribbon.RibbonQuickAccessToolbarLocation.Hidden;
            // 
            // SaveBarButtonItem
            // 
            this.SaveBarButtonItem.Caption = "Αποθήκευση";
            this.SaveBarButtonItem.Glyph = ((System.Drawing.Image)(resources.GetObject("SaveBarButtonItem.Glyph")));
            this.SaveBarButtonItem.Id = 1;
            this.SaveBarButtonItem.LargeGlyph = ((System.Drawing.Image)(resources.GetObject("SaveBarButtonItem.LargeGlyph")));
            this.SaveBarButtonItem.Name = "SaveBarButtonItem";
            this.SaveBarButtonItem.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.SaveBarButtonItem_ItemClick);
            // 
            // ExitBarButtonItem
            // 
            this.ExitBarButtonItem.Caption = "Έξοδος";
            this.ExitBarButtonItem.Glyph = ((System.Drawing.Image)(resources.GetObject("ExitBarButtonItem.Glyph")));
            this.ExitBarButtonItem.Id = 2;
            this.ExitBarButtonItem.LargeGlyph = ((System.Drawing.Image)(resources.GetObject("ExitBarButtonItem.LargeGlyph")));
            this.ExitBarButtonItem.Name = "ExitBarButtonItem";
            this.ExitBarButtonItem.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.ExitBarButtonItem_ItemClick);
            // 
            // ribbonPage1
            // 
            this.ribbonPage1.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.ribbonPageGroup1});
            this.ribbonPage1.Name = "ribbonPage1";
            this.ribbonPage1.Text = "Αρχείο";
            // 
            // ribbonPageGroup1
            // 
            this.ribbonPageGroup1.ItemLinks.Add(this.SaveBarButtonItem);
            this.ribbonPageGroup1.ItemLinks.Add(this.ExitBarButtonItem);
            this.ribbonPageGroup1.Name = "ribbonPageGroup1";
            this.ribbonPageGroup1.Text = "Αρχείο";
            // 
            // GameBranchForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1031, 646);
            this.Controls.Add(this.ribbonControl1);
            this.Controls.Add(this.LeftArrowSimpleButton);
            this.Controls.Add(this.RightArrowSimpleButton);
            this.Controls.Add(this.branchGameGridControl);
            this.Controls.Add(this.branchGridControl);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "GameBranchForm";
            this.Text = "GameBranchForm";
            ((System.ComponentModel.ISupportInitialize)(this.branchBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.branchGridControl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.branchGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.branchGameBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.branchGameGridControl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.branchGameGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ribbonControl1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraGrid.GridControl branchGridControl;
        private DevExpress.XtraGrid.Views.Grid.GridView branchGridView;
        private DevExpress.XtraGrid.Columns.GridColumn colBranchCode;
        private DevExpress.XtraGrid.Columns.GridColumn colBranchName;
        private System.Windows.Forms.BindingSource branchGameBindingSource;
        private DevExpress.XtraGrid.GridControl branchGameGridControl;
        private DevExpress.XtraGrid.Views.Grid.GridView branchGameGridView;
        private DevExpress.XtraGrid.Columns.GridColumn colBranchCode1;
        private DevExpress.XtraEditors.SimpleButton RightArrowSimpleButton;
        private DevExpress.XtraEditors.SimpleButton LeftArrowSimpleButton;
        private System.Windows.Forms.BindingSource branchBindingSource;
        private DevExpress.XtraBars.Ribbon.RibbonControl ribbonControl1;
        private DevExpress.XtraBars.BarButtonItem SaveBarButtonItem;
        private DevExpress.XtraBars.BarButtonItem ExitBarButtonItem;
        private DevExpress.XtraBars.Ribbon.RibbonPage ribbonPage1;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup1;

    }
}