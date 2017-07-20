namespace DrawGame.Editor
{
    partial class WizGameListForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(WizGameListForm));
            this.wizDrawGameInfoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.wizDrawGameInfoGridControl = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colGameId = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colGameName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colIsActive = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colGameTypeName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.ribbonControl1 = new DevExpress.XtraBars.Ribbon.RibbonControl();
            this.NewBarButtonItem = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItem2 = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonGroup1 = new DevExpress.XtraBars.BarButtonGroup();
            this.DeleteBarButtonItem = new DevExpress.XtraBars.BarButtonItem();
            this.BranchBarButtonItem = new DevExpress.XtraBars.BarButtonItem();
            this.ribbonPage1 = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.ribbonPageGroup1 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonPageGroup2 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.defaultLookAndFeel1 = new DevExpress.LookAndFeel.DefaultLookAndFeel(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.wizDrawGameInfoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.wizDrawGameInfoGridControl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ribbonControl1)).BeginInit();
            this.SuspendLayout();
            // 
            // wizDrawGameInfoBindingSource
            // 
            this.wizDrawGameInfoBindingSource.DataSource = typeof(DrawGame.Domain.Model.Game.WizDrawGameInfo);
            // 
            // wizDrawGameInfoGridControl
            // 
            this.wizDrawGameInfoGridControl.DataSource = this.wizDrawGameInfoBindingSource;
            this.wizDrawGameInfoGridControl.Dock = System.Windows.Forms.DockStyle.Top;
            this.wizDrawGameInfoGridControl.Location = new System.Drawing.Point(0, 114);
            this.wizDrawGameInfoGridControl.MainView = this.gridView1;
            this.wizDrawGameInfoGridControl.Name = "wizDrawGameInfoGridControl";
            this.wizDrawGameInfoGridControl.Size = new System.Drawing.Size(1051, 574);
            this.wizDrawGameInfoGridControl.TabIndex = 1;
            this.wizDrawGameInfoGridControl.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            this.wizDrawGameInfoGridControl.DoubleClick += new System.EventHandler(this.wizDrawGameInfoGridControl_DoubleClick);
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colGameId,
            this.colGameName,
            this.colIsActive,
            this.colGameTypeName});
            this.gridView1.GridControl = this.wizDrawGameInfoGridControl;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsBehavior.Editable = false;
            // 
            // colGameId
            // 
            this.colGameId.Caption = "Κωδ. Παιχνιδιού";
            this.colGameId.FieldName = "GameId";
            this.colGameId.Name = "colGameId";
            this.colGameId.Visible = true;
            this.colGameId.VisibleIndex = 0;
            // 
            // colGameName
            // 
            this.colGameName.Caption = "Ονομασία Παιχνιδιού";
            this.colGameName.FieldName = "GameName";
            this.colGameName.Name = "colGameName";
            this.colGameName.Visible = true;
            this.colGameName.VisibleIndex = 1;
            // 
            // colIsActive
            // 
            this.colIsActive.Caption = "Ενεργό";
            this.colIsActive.FieldName = "IsActive";
            this.colIsActive.Name = "colIsActive";
            this.colIsActive.Visible = true;
            this.colIsActive.VisibleIndex = 3;
            // 
            // colGameTypeName
            // 
            this.colGameTypeName.Caption = "Τύπος Παιχνιδιού";
            this.colGameTypeName.FieldName = "GameTypeName";
            this.colGameTypeName.Name = "colGameTypeName";
            this.colGameTypeName.Visible = true;
            this.colGameTypeName.VisibleIndex = 2;
            // 
            // ribbonControl1
            // 
            this.ribbonControl1.ExpandCollapseItem.Id = 0;
            this.ribbonControl1.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.ribbonControl1.ExpandCollapseItem,
            this.NewBarButtonItem,
            this.barButtonItem2,
            this.barButtonGroup1,
            this.DeleteBarButtonItem,
            this.BranchBarButtonItem});
            this.ribbonControl1.Location = new System.Drawing.Point(0, 0);
            this.ribbonControl1.MaxItemId = 10;
            this.ribbonControl1.Name = "ribbonControl1";
            this.ribbonControl1.Pages.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPage[] {
            this.ribbonPage1});
            this.ribbonControl1.Size = new System.Drawing.Size(1051, 114);
            this.ribbonControl1.ToolbarLocation = DevExpress.XtraBars.Ribbon.RibbonQuickAccessToolbarLocation.Hidden;
            // 
            // NewBarButtonItem
            // 
            this.NewBarButtonItem.Caption = "Νέο Παιχνίδι";
            this.NewBarButtonItem.Glyph = ((System.Drawing.Image)(resources.GetObject("NewBarButtonItem.Glyph")));
            this.NewBarButtonItem.Id = 1;
            this.NewBarButtonItem.LargeGlyph = ((System.Drawing.Image)(resources.GetObject("NewBarButtonItem.LargeGlyph")));
            this.NewBarButtonItem.Name = "NewBarButtonItem";
            this.NewBarButtonItem.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.NewBarButtonItem_ItemClick);
            // 
            // barButtonItem2
            // 
            this.barButtonItem2.Caption = "barButtonItem2";
            this.barButtonItem2.Id = 4;
            this.barButtonItem2.Name = "barButtonItem2";
            // 
            // barButtonGroup1
            // 
            this.barButtonGroup1.Caption = "barButtonGroup1";
            this.barButtonGroup1.Id = 5;
            this.barButtonGroup1.Name = "barButtonGroup1";
            // 
            // DeleteBarButtonItem
            // 
            this.DeleteBarButtonItem.Caption = "Διαγραφή";
            this.DeleteBarButtonItem.Glyph = ((System.Drawing.Image)(resources.GetObject("DeleteBarButtonItem.Glyph")));
            this.DeleteBarButtonItem.Id = 8;
            this.DeleteBarButtonItem.LargeGlyph = ((System.Drawing.Image)(resources.GetObject("DeleteBarButtonItem.LargeGlyph")));
            this.DeleteBarButtonItem.Name = "DeleteBarButtonItem";
            this.DeleteBarButtonItem.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.DeleteBarButtonItem_ItemClick);
            // 
            // BranchBarButtonItem
            // 
            this.BranchBarButtonItem.Caption = "Υποκαταστήματα";
            this.BranchBarButtonItem.Glyph = ((System.Drawing.Image)(resources.GetObject("BranchBarButtonItem.Glyph")));
            this.BranchBarButtonItem.Id = 9;
            this.BranchBarButtonItem.LargeGlyph = ((System.Drawing.Image)(resources.GetObject("BranchBarButtonItem.LargeGlyph")));
            this.BranchBarButtonItem.Name = "BranchBarButtonItem";
            this.BranchBarButtonItem.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.BranchBarButtonItem_ItemClick);
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
            this.ribbonPageGroup1.ItemLinks.Add(this.NewBarButtonItem);
            this.ribbonPageGroup1.ItemLinks.Add(this.DeleteBarButtonItem);
            this.ribbonPageGroup1.ItemLinks.Add(this.BranchBarButtonItem);
            this.ribbonPageGroup1.Name = "ribbonPageGroup1";
            this.ribbonPageGroup1.Text = "Αρχείο";
            // 
            // ribbonPageGroup2
            // 
            this.ribbonPageGroup2.ItemLinks.Add(this.NewBarButtonItem);
            this.ribbonPageGroup2.Name = "ribbonPageGroup2";
            this.ribbonPageGroup2.Text = "ribbonPageGroup1";
            // 
            // defaultLookAndFeel1
            // 
            this.defaultLookAndFeel1.LookAndFeel.SkinName = "Visual Studio 2013 Dark";
            // 
            // WizGameListForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1051, 687);
            this.Controls.Add(this.wizDrawGameInfoGridControl);
            this.Controls.Add(this.ribbonControl1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "WizGameListForm";
            this.Text = "WizGameListForm";
            ((System.ComponentModel.ISupportInitialize)(this.wizDrawGameInfoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.wizDrawGameInfoGridControl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ribbonControl1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.BindingSource wizDrawGameInfoBindingSource;
        private DevExpress.XtraGrid.GridControl wizDrawGameInfoGridControl;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraGrid.Columns.GridColumn colGameId;
        private DevExpress.XtraGrid.Columns.GridColumn colGameName;
        private DevExpress.XtraGrid.Columns.GridColumn colIsActive;
        private DevExpress.XtraGrid.Columns.GridColumn colGameTypeName;
        private DevExpress.XtraBars.Ribbon.RibbonControl ribbonControl1;
        private DevExpress.XtraBars.BarButtonItem NewBarButtonItem;
        private DevExpress.XtraBars.BarButtonItem barButtonItem2;
        private DevExpress.XtraBars.BarButtonGroup barButtonGroup1;
        private DevExpress.XtraBars.BarButtonItem DeleteBarButtonItem;
        private DevExpress.XtraBars.Ribbon.RibbonPage ribbonPage1;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup1;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup2;
        private DevExpress.LookAndFeel.DefaultLookAndFeel defaultLookAndFeel1;
        private DevExpress.XtraBars.BarButtonItem BranchBarButtonItem;
    }
}