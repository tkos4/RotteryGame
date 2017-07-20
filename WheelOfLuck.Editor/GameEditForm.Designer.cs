using DrawGame.Domain.Game;
using DrawGame.Domain.Model.Game;

namespace DrawGame.Editor
{
    partial class GameEditForm
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
            System.Windows.Forms.Label isActiveLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GameEditForm));
            this.wizDrawGameBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataLayoutControl1 = new DevExpress.XtraDataLayout.DataLayoutControl();
            this.PlayLostSimpleButton = new DevExpress.XtraEditors.SimpleButton();
            this.PlayWinSimpleButton = new DevExpress.XtraEditors.SimpleButton();
            this.NewSimpleButton = new DevExpress.XtraEditors.SimpleButton();
            this.DeleteSimpleButton = new DevExpress.XtraEditors.SimpleButton();
            this.dataLayoutControl2 = new DevExpress.XtraDataLayout.DataLayoutControl();
            this.ProductCodeTextEdit = new DevExpress.XtraEditors.TextEdit();
            this.gameItemsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.ProductNameTextEdit = new DevExpress.XtraEditors.TextEdit();
            this.IsActiveCheckEdit = new DevExpress.XtraEditors.CheckEdit();
            this.IsLoosingCheckEdit = new DevExpress.XtraEditors.CheckEdit();
            this.CaptionTextEdit = new DevExpress.XtraEditors.TextEdit();
            this.ImagePictureEdit = new DevExpress.XtraEditors.PictureEdit();
            this.GameDrawBeforeWinsCountSpinEdit = new DevExpress.XtraEditors.SpinEdit();
            this.WinningTitleTextEdit = new DevExpress.XtraEditors.TextEdit();
            this.ObjectStateTextEdit = new DevExpress.XtraEditors.TextEdit();
            this.BackColorColorEdit = new DevExpress.XtraEditors.ColorEdit();
            this.layoutControlGroup6 = new DevExpress.XtraLayout.LayoutControlGroup();
            this.layoutControlGroup7 = new DevExpress.XtraLayout.LayoutControlGroup();
            this.ItemForProductCode = new DevExpress.XtraLayout.LayoutControlItem();
            this.ItemForObjectState = new DevExpress.XtraLayout.LayoutControlItem();
            this.ItemForCaption = new DevExpress.XtraLayout.LayoutControlItem();
            this.ItemForImage = new DevExpress.XtraLayout.LayoutControlItem();
            this.ItemForProductName = new DevExpress.XtraLayout.LayoutControlItem();
            this.ItemForWinningTitle = new DevExpress.XtraLayout.LayoutControlItem();
            this.ItemForIsActive = new DevExpress.XtraLayout.LayoutControlItem();
            this.ItemForGameDrawBeforeWinsCount = new DevExpress.XtraLayout.LayoutControlItem();
            this.ItemForIsLoosing = new DevExpress.XtraLayout.LayoutControlItem();
            this.ItemForBackColor = new DevExpress.XtraLayout.LayoutControlItem();
            this.gameItemsGridControl = new DevExpress.XtraGrid.GridControl();
            this.GameItemsGridView = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colProductCode = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colProductName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colBackColor = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repositoryItemColorEdit1 = new DevExpress.XtraEditors.Repository.RepositoryItemColorEdit();
            this.colIsActive = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colIsLoosing = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCaption = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colImage = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colGameDrawBeforeWinsCount = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colWinningTitle = new DevExpress.XtraGrid.Columns.GridColumn();
            this.GameIdTextEdit = new DevExpress.XtraEditors.TextEdit();
            this.wizDrawGameInfoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.NameTextEdit = new DevExpress.XtraEditors.TextEdit();
            this.GameTypeLookUpEdit = new DevExpress.XtraEditors.LookUpEdit();
            this.BackgroundImagePictureEdit = new DevExpress.XtraEditors.PictureEdit();
            this.WinImagePictureEdit = new DevExpress.XtraEditors.PictureEdit();
            this.LostImagePictureEdit = new DevExpress.XtraEditors.PictureEdit();
            this.WinSoundPictureEdit = new DevExpress.XtraEditors.ButtonEdit();
            this.LostSoundPictureEdit = new DevExpress.XtraEditors.ButtonEdit();
            this.checkEdit1 = new DevExpress.XtraEditors.CheckEdit();
            this.ribbonControl1 = new DevExpress.XtraBars.Ribbon.RibbonControl();
            this.SaveBarButtonItem = new DevExpress.XtraBars.BarButtonItem();
            this.ExitBarButtonItem = new DevExpress.XtraBars.BarButtonItem();
            this.ribbonPage1 = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.ribbonPageGroup1 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.layoutControlGroup1 = new DevExpress.XtraLayout.LayoutControlGroup();
            this.layoutControlGroup2 = new DevExpress.XtraLayout.LayoutControlGroup();
            this.ItemForGameId = new DevExpress.XtraLayout.LayoutControlItem();
            this.ItemForName = new DevExpress.XtraLayout.LayoutControlItem();
            this.ItemForGameType = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlGroup3 = new DevExpress.XtraLayout.LayoutControlGroup();
            this.layoutControlItem1 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem2 = new DevExpress.XtraLayout.LayoutControlItem();
            this.emptySpaceItem1 = new DevExpress.XtraLayout.EmptySpaceItem();
            this.layoutControlItem4 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem3 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlGroup4 = new DevExpress.XtraLayout.LayoutControlGroup();
            this.ItemForWinSound = new DevExpress.XtraLayout.LayoutControlItem();
            this.ItemForLostSound = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem5 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem6 = new DevExpress.XtraLayout.LayoutControlItem();
            this.emptySpaceItem2 = new DevExpress.XtraLayout.EmptySpaceItem();
            this.layoutControlGroup5 = new DevExpress.XtraLayout.LayoutControlGroup();
            this.ItemForBackgroundImage = new DevExpress.XtraLayout.LayoutControlItem();
            this.ItemForWinImage = new DevExpress.XtraLayout.LayoutControlItem();
            this.ItemForLostImage = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem7 = new DevExpress.XtraLayout.LayoutControlItem();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            isActiveLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.wizDrawGameBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataLayoutControl1)).BeginInit();
            this.dataLayoutControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataLayoutControl2)).BeginInit();
            this.dataLayoutControl2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ProductCodeTextEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gameItemsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ProductNameTextEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.IsActiveCheckEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.IsLoosingCheckEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.CaptionTextEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ImagePictureEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.GameDrawBeforeWinsCountSpinEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.WinningTitleTextEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ObjectStateTextEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BackColorColorEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup7)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForProductCode)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForObjectState)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForCaption)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForImage)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForProductName)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForWinningTitle)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForIsActive)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForGameDrawBeforeWinsCount)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForIsLoosing)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForBackColor)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gameItemsGridControl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.GameItemsGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemColorEdit1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.GameIdTextEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.wizDrawGameInfoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.NameTextEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.GameTypeLookUpEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BackgroundImagePictureEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.WinImagePictureEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.LostImagePictureEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.WinSoundPictureEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.LostSoundPictureEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.checkEdit1.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ribbonControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForGameId)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForName)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForGameType)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForWinSound)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForLostSound)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForBackgroundImage)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForWinImage)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForLostImage)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem7)).BeginInit();
            this.SuspendLayout();
            // 
            // isActiveLabel
            // 
            isActiveLabel.Location = new System.Drawing.Point(12, 705);
            isActiveLabel.Name = "isActiveLabel";
            isActiveLabel.Size = new System.Drawing.Size(1096, 23);
            isActiveLabel.TabIndex = 18;
            // 
            // wizDrawGameBindingSource
            // 
            this.wizDrawGameBindingSource.DataSource = typeof(DrawGame.Domain.Model.Game.WizDrawGame);
            // 
            // dataLayoutControl1
            // 
            this.dataLayoutControl1.AllowCustomizationMenu = false;
            this.dataLayoutControl1.Controls.Add(this.PlayLostSimpleButton);
            this.dataLayoutControl1.Controls.Add(this.PlayWinSimpleButton);
            this.dataLayoutControl1.Controls.Add(this.NewSimpleButton);
            this.dataLayoutControl1.Controls.Add(this.DeleteSimpleButton);
            this.dataLayoutControl1.Controls.Add(this.dataLayoutControl2);
            this.dataLayoutControl1.Controls.Add(this.gameItemsGridControl);
            this.dataLayoutControl1.Controls.Add(this.GameIdTextEdit);
            this.dataLayoutControl1.Controls.Add(this.NameTextEdit);
            this.dataLayoutControl1.Controls.Add(this.GameTypeLookUpEdit);
            this.dataLayoutControl1.Controls.Add(this.BackgroundImagePictureEdit);
            this.dataLayoutControl1.Controls.Add(this.WinImagePictureEdit);
            this.dataLayoutControl1.Controls.Add(this.LostImagePictureEdit);
            this.dataLayoutControl1.Controls.Add(this.WinSoundPictureEdit);
            this.dataLayoutControl1.Controls.Add(this.LostSoundPictureEdit);
            this.dataLayoutControl1.Controls.Add(this.checkEdit1);
            this.dataLayoutControl1.DataSource = this.wizDrawGameBindingSource;
            this.dataLayoutControl1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dataLayoutControl1.Location = new System.Drawing.Point(0, 114);
            this.dataLayoutControl1.Name = "dataLayoutControl1";
            this.dataLayoutControl1.Root = this.layoutControlGroup1;
            this.dataLayoutControl1.Size = new System.Drawing.Size(1103, 705);
            this.dataLayoutControl1.TabIndex = 1;
            this.dataLayoutControl1.Text = "dataLayoutControl1";
            // 
            // PlayLostSimpleButton
            // 
            this.PlayLostSimpleButton.Image = ((System.Drawing.Image)(resources.GetObject("PlayLostSimpleButton.Image")));
            this.PlayLostSimpleButton.Location = new System.Drawing.Point(282, 236);
            this.PlayLostSimpleButton.Name = "PlayLostSimpleButton";
            this.PlayLostSimpleButton.Size = new System.Drawing.Size(149, 36);
            this.PlayLostSimpleButton.StyleController = this.dataLayoutControl1;
            this.PlayLostSimpleButton.TabIndex = 15;
            this.PlayLostSimpleButton.Text = "Play";
            this.PlayLostSimpleButton.Click += new System.EventHandler(this.PlayLostSimpleButton_Click);
            // 
            // PlayWinSimpleButton
            // 
            this.PlayWinSimpleButton.Image = ((System.Drawing.Image)(resources.GetObject("PlayWinSimpleButton.Image")));
            this.PlayWinSimpleButton.Location = new System.Drawing.Point(24, 236);
            this.PlayWinSimpleButton.Name = "PlayWinSimpleButton";
            this.PlayWinSimpleButton.Size = new System.Drawing.Size(149, 36);
            this.PlayWinSimpleButton.StyleController = this.dataLayoutControl1;
            this.PlayWinSimpleButton.TabIndex = 14;
            this.PlayWinSimpleButton.Text = "Play";
            this.PlayWinSimpleButton.Click += new System.EventHandler(this.PlayWinSimpleButton_Click);
            // 
            // NewSimpleButton
            // 
            this.NewSimpleButton.Image = ((System.Drawing.Image)(resources.GetObject("NewSimpleButton.Image")));
            this.NewSimpleButton.Location = new System.Drawing.Point(24, 319);
            this.NewSimpleButton.Name = "NewSimpleButton";
            this.NewSimpleButton.Size = new System.Drawing.Size(114, 36);
            this.NewSimpleButton.StyleController = this.dataLayoutControl1;
            this.NewSimpleButton.TabIndex = 13;
            this.NewSimpleButton.Text = "Νέο";
            this.NewSimpleButton.Click += new System.EventHandler(this.NewSimpleButton_Click);
            // 
            // DeleteSimpleButton
            // 
            this.DeleteSimpleButton.Image = ((System.Drawing.Image)(resources.GetObject("DeleteSimpleButton.Image")));
            this.DeleteSimpleButton.Location = new System.Drawing.Point(142, 319);
            this.DeleteSimpleButton.Name = "DeleteSimpleButton";
            this.DeleteSimpleButton.Size = new System.Drawing.Size(120, 36);
            this.DeleteSimpleButton.StyleController = this.dataLayoutControl1;
            this.DeleteSimpleButton.TabIndex = 12;
            this.DeleteSimpleButton.Text = "Διαγραφή";
            this.DeleteSimpleButton.Click += new System.EventHandler(this.DeleteSimpleButton_Click);
            // 
            // dataLayoutControl2
            // 
            this.dataLayoutControl2.AllowCustomizationMenu = false;
            this.dataLayoutControl2.Controls.Add(this.ProductCodeTextEdit);
            this.dataLayoutControl2.Controls.Add(this.ProductNameTextEdit);
            this.dataLayoutControl2.Controls.Add(this.IsActiveCheckEdit);
            this.dataLayoutControl2.Controls.Add(this.IsLoosingCheckEdit);
            this.dataLayoutControl2.Controls.Add(this.CaptionTextEdit);
            this.dataLayoutControl2.Controls.Add(this.ImagePictureEdit);
            this.dataLayoutControl2.Controls.Add(this.GameDrawBeforeWinsCountSpinEdit);
            this.dataLayoutControl2.Controls.Add(this.WinningTitleTextEdit);
            this.dataLayoutControl2.Controls.Add(this.ObjectStateTextEdit);
            this.dataLayoutControl2.Controls.Add(this.BackColorColorEdit);
            this.dataLayoutControl2.DataMember = "GameItems";
            this.dataLayoutControl2.DataSource = this.wizDrawGameBindingSource;
            this.dataLayoutControl2.Location = new System.Drawing.Point(679, 359);
            this.dataLayoutControl2.Name = "dataLayoutControl2";
            this.dataLayoutControl2.Root = this.layoutControlGroup6;
            this.dataLayoutControl2.Size = new System.Drawing.Size(400, 322);
            this.dataLayoutControl2.TabIndex = 2;
            this.dataLayoutControl2.Text = "dataLayoutControl2";
            // 
            // ProductCodeTextEdit
            // 
            this.ProductCodeTextEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.gameItemsBindingSource, "ProductCode", true));
            this.ProductCodeTextEdit.Location = new System.Drawing.Point(277, 12);
            this.ProductCodeTextEdit.Name = "ProductCodeTextEdit";
            this.ProductCodeTextEdit.Size = new System.Drawing.Size(50, 20);
            this.ProductCodeTextEdit.StyleController = this.dataLayoutControl2;
            this.ProductCodeTextEdit.TabIndex = 4;
            // 
            // gameItemsBindingSource
            // 
            this.gameItemsBindingSource.DataMember = "GameItems";
            this.gameItemsBindingSource.DataSource = this.wizDrawGameBindingSource;
            // 
            // ProductNameTextEdit
            // 
            this.ProductNameTextEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.gameItemsBindingSource, "ProductName", true));
            this.ProductNameTextEdit.Location = new System.Drawing.Point(106, 12);
            this.ProductNameTextEdit.Name = "ProductNameTextEdit";
            this.ProductNameTextEdit.Size = new System.Drawing.Size(73, 20);
            this.ProductNameTextEdit.StyleController = this.dataLayoutControl2;
            this.ProductNameTextEdit.TabIndex = 5;
            // 
            // IsActiveCheckEdit
            // 
            this.IsActiveCheckEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.gameItemsBindingSource, "IsActive", true));
            this.IsActiveCheckEdit.Location = new System.Drawing.Point(331, 12);
            this.IsActiveCheckEdit.Name = "IsActiveCheckEdit";
            this.IsActiveCheckEdit.Properties.Caption = "Ενεργό";
            this.IsActiveCheckEdit.Size = new System.Drawing.Size(57, 19);
            this.IsActiveCheckEdit.StyleController = this.dataLayoutControl2;
            this.IsActiveCheckEdit.TabIndex = 7;
            // 
            // IsLoosingCheckEdit
            // 
            this.IsLoosingCheckEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.gameItemsBindingSource, "IsLoosing", true));
            this.IsLoosingCheckEdit.Location = new System.Drawing.Point(183, 60);
            this.IsLoosingCheckEdit.Name = "IsLoosingCheckEdit";
            this.IsLoosingCheckEdit.Properties.Caption = "Χάνει";
            this.IsLoosingCheckEdit.Size = new System.Drawing.Size(205, 19);
            this.IsLoosingCheckEdit.StyleController = this.dataLayoutControl2;
            this.IsLoosingCheckEdit.TabIndex = 8;
            // 
            // CaptionTextEdit
            // 
            this.CaptionTextEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.gameItemsBindingSource, "Caption", true));
            this.CaptionTextEdit.Location = new System.Drawing.Point(277, 36);
            this.CaptionTextEdit.Name = "CaptionTextEdit";
            this.CaptionTextEdit.Size = new System.Drawing.Size(111, 20);
            this.CaptionTextEdit.StyleController = this.dataLayoutControl2;
            this.CaptionTextEdit.TabIndex = 9;
            // 
            // ImagePictureEdit
            // 
            this.ImagePictureEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.gameItemsBindingSource, "Image", true));
            this.ImagePictureEdit.Location = new System.Drawing.Point(106, 108);
            this.ImagePictureEdit.Name = "ImagePictureEdit";
            this.ImagePictureEdit.Properties.SizeMode = DevExpress.XtraEditors.Controls.PictureSizeMode.Squeeze;
            this.ImagePictureEdit.Size = new System.Drawing.Size(282, 178);
            this.ImagePictureEdit.StyleController = this.dataLayoutControl2;
            this.ImagePictureEdit.TabIndex = 10;
            this.ImagePictureEdit.ParseEditValue += new DevExpress.XtraEditors.Controls.ConvertEditValueEventHandler(this.ImagePictureEdit_ParseEditValue);
            // 
            // GameDrawBeforeWinsCountSpinEdit
            // 
            this.GameDrawBeforeWinsCountSpinEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.gameItemsBindingSource, "GameDrawBeforeWinsCount", true));
            this.GameDrawBeforeWinsCountSpinEdit.EditValue = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.GameDrawBeforeWinsCountSpinEdit.Location = new System.Drawing.Point(106, 60);
            this.GameDrawBeforeWinsCountSpinEdit.Name = "GameDrawBeforeWinsCountSpinEdit";
            this.GameDrawBeforeWinsCountSpinEdit.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.GameDrawBeforeWinsCountSpinEdit.Size = new System.Drawing.Size(73, 20);
            this.GameDrawBeforeWinsCountSpinEdit.StyleController = this.dataLayoutControl2;
            this.GameDrawBeforeWinsCountSpinEdit.TabIndex = 11;
            // 
            // WinningTitleTextEdit
            // 
            this.WinningTitleTextEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.gameItemsBindingSource, "WinningTitle", true));
            this.WinningTitleTextEdit.Location = new System.Drawing.Point(106, 36);
            this.WinningTitleTextEdit.Name = "WinningTitleTextEdit";
            this.WinningTitleTextEdit.Size = new System.Drawing.Size(73, 20);
            this.WinningTitleTextEdit.StyleController = this.dataLayoutControl2;
            this.WinningTitleTextEdit.TabIndex = 12;
            // 
            // ObjectStateTextEdit
            // 
            this.ObjectStateTextEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.gameItemsBindingSource, "ObjectState", true));
            this.ObjectStateTextEdit.Location = new System.Drawing.Point(106, 290);
            this.ObjectStateTextEdit.Name = "ObjectStateTextEdit";
            this.ObjectStateTextEdit.Size = new System.Drawing.Size(282, 20);
            this.ObjectStateTextEdit.StyleController = this.dataLayoutControl2;
            this.ObjectStateTextEdit.TabIndex = 13;
            // 
            // BackColorColorEdit
            // 
            this.BackColorColorEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.gameItemsBindingSource, "BackColor", true));
            this.BackColorColorEdit.EditValue = System.Drawing.Color.Empty;
            this.BackColorColorEdit.Location = new System.Drawing.Point(106, 84);
            this.BackColorColorEdit.Name = "BackColorColorEdit";
            this.BackColorColorEdit.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.BackColorColorEdit.Size = new System.Drawing.Size(282, 20);
            this.BackColorColorEdit.StyleController = this.dataLayoutControl2;
            this.BackColorColorEdit.TabIndex = 6;
            // 
            // layoutControlGroup6
            // 
            this.layoutControlGroup6.CustomizationFormText = "layoutControlGroup6";
            this.layoutControlGroup6.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
            this.layoutControlGroup6.GroupBordersVisible = false;
            this.layoutControlGroup6.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutControlGroup7});
            this.layoutControlGroup6.Location = new System.Drawing.Point(0, 0);
            this.layoutControlGroup6.Name = "layoutControlGroup6";
            this.layoutControlGroup6.Size = new System.Drawing.Size(400, 322);
            this.layoutControlGroup6.Text = "layoutControlGroup6";
            this.layoutControlGroup6.TextVisible = false;
            // 
            // layoutControlGroup7
            // 
            this.layoutControlGroup7.AllowDrawBackground = false;
            this.layoutControlGroup7.CustomizationFormText = "autoGeneratedGroup0";
            this.layoutControlGroup7.GroupBordersVisible = false;
            this.layoutControlGroup7.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.ItemForProductCode,
            this.ItemForObjectState,
            this.ItemForCaption,
            this.ItemForImage,
            this.ItemForProductName,
            this.ItemForWinningTitle,
            this.ItemForIsActive,
            this.ItemForGameDrawBeforeWinsCount,
            this.ItemForIsLoosing,
            this.ItemForBackColor});
            this.layoutControlGroup7.Location = new System.Drawing.Point(0, 0);
            this.layoutControlGroup7.Name = "autoGeneratedGroup0";
            this.layoutControlGroup7.Size = new System.Drawing.Size(380, 302);
            this.layoutControlGroup7.Text = "autoGeneratedGroup0";
            // 
            // ItemForProductCode
            // 
            this.ItemForProductCode.Control = this.ProductCodeTextEdit;
            this.ItemForProductCode.CustomizationFormText = "Product Code";
            this.ItemForProductCode.Location = new System.Drawing.Point(171, 0);
            this.ItemForProductCode.Name = "ItemForProductCode";
            this.ItemForProductCode.Size = new System.Drawing.Size(148, 24);
            this.ItemForProductCode.Text = "Κωδ. Είδους";
            this.ItemForProductCode.TextSize = new System.Drawing.Size(91, 13);
            // 
            // ItemForObjectState
            // 
            this.ItemForObjectState.Control = this.ObjectStateTextEdit;
            this.ItemForObjectState.CustomizationFormText = "Object State";
            this.ItemForObjectState.Location = new System.Drawing.Point(0, 278);
            this.ItemForObjectState.Name = "ItemForObjectState";
            this.ItemForObjectState.Size = new System.Drawing.Size(380, 24);
            this.ItemForObjectState.Text = "Object State";
            this.ItemForObjectState.TextSize = new System.Drawing.Size(91, 13);
            // 
            // ItemForCaption
            // 
            this.ItemForCaption.Control = this.CaptionTextEdit;
            this.ItemForCaption.CustomizationFormText = "Caption";
            this.ItemForCaption.Location = new System.Drawing.Point(171, 24);
            this.ItemForCaption.Name = "ItemForCaption";
            this.ItemForCaption.Size = new System.Drawing.Size(209, 24);
            this.ItemForCaption.Text = "Λεζάντα";
            this.ItemForCaption.TextSize = new System.Drawing.Size(91, 13);
            // 
            // ItemForImage
            // 
            this.ItemForImage.Control = this.ImagePictureEdit;
            this.ItemForImage.CustomizationFormText = "Image";
            this.ItemForImage.Location = new System.Drawing.Point(0, 96);
            this.ItemForImage.Name = "ItemForImage";
            this.ItemForImage.Size = new System.Drawing.Size(380, 182);
            this.ItemForImage.Text = "Εικόνα";
            this.ItemForImage.TextSize = new System.Drawing.Size(91, 13);
            // 
            // ItemForProductName
            // 
            this.ItemForProductName.Control = this.ProductNameTextEdit;
            this.ItemForProductName.CustomizationFormText = "Product Name";
            this.ItemForProductName.Location = new System.Drawing.Point(0, 0);
            this.ItemForProductName.Name = "ItemForProductName";
            this.ItemForProductName.Size = new System.Drawing.Size(171, 24);
            this.ItemForProductName.Text = "Ονομασία Είδους";
            this.ItemForProductName.TextSize = new System.Drawing.Size(91, 13);
            // 
            // ItemForWinningTitle
            // 
            this.ItemForWinningTitle.Control = this.WinningTitleTextEdit;
            this.ItemForWinningTitle.CustomizationFormText = "Winning Title";
            this.ItemForWinningTitle.Location = new System.Drawing.Point(0, 24);
            this.ItemForWinningTitle.Name = "ItemForWinningTitle";
            this.ItemForWinningTitle.Size = new System.Drawing.Size(171, 24);
            this.ItemForWinningTitle.Text = "Τίτλος Νίκης";
            this.ItemForWinningTitle.TextSize = new System.Drawing.Size(91, 13);
            // 
            // ItemForIsActive
            // 
            this.ItemForIsActive.Control = this.IsActiveCheckEdit;
            this.ItemForIsActive.CustomizationFormText = "Is Active";
            this.ItemForIsActive.Location = new System.Drawing.Point(319, 0);
            this.ItemForIsActive.Name = "ItemForIsActive";
            this.ItemForIsActive.Size = new System.Drawing.Size(61, 24);
            this.ItemForIsActive.Text = "Is Active";
            this.ItemForIsActive.TextSize = new System.Drawing.Size(0, 0);
            this.ItemForIsActive.TextToControlDistance = 0;
            this.ItemForIsActive.TextVisible = false;
            // 
            // ItemForGameDrawBeforeWinsCount
            // 
            this.ItemForGameDrawBeforeWinsCount.Control = this.GameDrawBeforeWinsCountSpinEdit;
            this.ItemForGameDrawBeforeWinsCount.CustomizationFormText = "Game Draw Before Wins Count";
            this.ItemForGameDrawBeforeWinsCount.Location = new System.Drawing.Point(0, 48);
            this.ItemForGameDrawBeforeWinsCount.Name = "ItemForGameDrawBeforeWinsCount";
            this.ItemForGameDrawBeforeWinsCount.Size = new System.Drawing.Size(171, 24);
            this.ItemForGameDrawBeforeWinsCount.Text = "Κληρώσεις για Νίκη";
            this.ItemForGameDrawBeforeWinsCount.TextSize = new System.Drawing.Size(91, 13);
            // 
            // ItemForIsLoosing
            // 
            this.ItemForIsLoosing.Control = this.IsLoosingCheckEdit;
            this.ItemForIsLoosing.CustomizationFormText = "Is Loosing";
            this.ItemForIsLoosing.Location = new System.Drawing.Point(171, 48);
            this.ItemForIsLoosing.Name = "ItemForIsLoosing";
            this.ItemForIsLoosing.Size = new System.Drawing.Size(209, 24);
            this.ItemForIsLoosing.Text = "Is Loosing";
            this.ItemForIsLoosing.TextSize = new System.Drawing.Size(0, 0);
            this.ItemForIsLoosing.TextToControlDistance = 0;
            this.ItemForIsLoosing.TextVisible = false;
            // 
            // ItemForBackColor
            // 
            this.ItemForBackColor.Control = this.BackColorColorEdit;
            this.ItemForBackColor.CustomizationFormText = "Back Color";
            this.ItemForBackColor.Location = new System.Drawing.Point(0, 72);
            this.ItemForBackColor.Name = "ItemForBackColor";
            this.ItemForBackColor.Size = new System.Drawing.Size(380, 24);
            this.ItemForBackColor.Text = "Χρώμα Φόντου";
            this.ItemForBackColor.TextSize = new System.Drawing.Size(91, 13);
            // 
            // gameItemsGridControl
            // 
            this.gameItemsGridControl.DataSource = this.gameItemsBindingSource;
            this.gameItemsGridControl.Location = new System.Drawing.Point(24, 359);
            this.gameItemsGridControl.MainView = this.GameItemsGridView;
            this.gameItemsGridControl.Name = "gameItemsGridControl";
            this.gameItemsGridControl.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.repositoryItemColorEdit1});
            this.gameItemsGridControl.Size = new System.Drawing.Size(651, 322);
            this.gameItemsGridControl.TabIndex = 1;
            this.gameItemsGridControl.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.GameItemsGridView});
            // 
            // GameItemsGridView
            // 
            this.GameItemsGridView.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colProductCode,
            this.colProductName,
            this.colBackColor,
            this.colIsActive,
            this.colIsLoosing,
            this.colCaption,
            this.colImage,
            this.colGameDrawBeforeWinsCount,
            this.colWinningTitle});
            this.GameItemsGridView.GridControl = this.gameItemsGridControl;
            this.GameItemsGridView.Name = "GameItemsGridView";
            this.GameItemsGridView.OptionsBehavior.Editable = false;
            this.GameItemsGridView.OptionsView.ShowGroupPanel = false;
            // 
            // colProductCode
            // 
            this.colProductCode.Caption = "Κωδ. Εϊδους";
            this.colProductCode.FieldName = "ProductCode";
            this.colProductCode.Name = "colProductCode";
            this.colProductCode.Visible = true;
            this.colProductCode.VisibleIndex = 0;
            this.colProductCode.Width = 70;
            // 
            // colProductName
            // 
            this.colProductName.Caption = "Ονομασία Είδους";
            this.colProductName.FieldName = "ProductName";
            this.colProductName.Name = "colProductName";
            this.colProductName.Visible = true;
            this.colProductName.VisibleIndex = 1;
            this.colProductName.Width = 88;
            // 
            // colBackColor
            // 
            this.colBackColor.Caption = "Χρώμα Φόντου";
            this.colBackColor.ColumnEdit = this.repositoryItemColorEdit1;
            this.colBackColor.FieldName = "BackColor";
            this.colBackColor.Name = "colBackColor";
            this.colBackColor.OptionsFilter.AllowFilter = false;
            this.colBackColor.Visible = true;
            this.colBackColor.VisibleIndex = 5;
            this.colBackColor.Width = 84;
            // 
            // repositoryItemColorEdit1
            // 
            this.repositoryItemColorEdit1.AutoHeight = false;
            this.repositoryItemColorEdit1.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.repositoryItemColorEdit1.Name = "repositoryItemColorEdit1";
            // 
            // colIsActive
            // 
            this.colIsActive.Caption = "Ενεργό";
            this.colIsActive.FieldName = "IsActive";
            this.colIsActive.Name = "colIsActive";
            this.colIsActive.Visible = true;
            this.colIsActive.VisibleIndex = 8;
            this.colIsActive.Width = 49;
            // 
            // colIsLoosing
            // 
            this.colIsLoosing.Caption = "Χάνει";
            this.colIsLoosing.FieldName = "IsLoosing";
            this.colIsLoosing.Name = "colIsLoosing";
            this.colIsLoosing.Visible = true;
            this.colIsLoosing.VisibleIndex = 6;
            this.colIsLoosing.Width = 35;
            // 
            // colCaption
            // 
            this.colCaption.Caption = "Λεζάντα";
            this.colCaption.FieldName = "Caption";
            this.colCaption.Name = "colCaption";
            this.colCaption.Visible = true;
            this.colCaption.VisibleIndex = 2;
            this.colCaption.Width = 66;
            // 
            // colImage
            // 
            this.colImage.Caption = "Εικόνα";
            this.colImage.FieldName = "Image";
            this.colImage.Name = "colImage";
            this.colImage.Visible = true;
            this.colImage.VisibleIndex = 4;
            this.colImage.Width = 66;
            // 
            // colGameDrawBeforeWinsCount
            // 
            this.colGameDrawBeforeWinsCount.Caption = "Κληρώσεις για Νίκη";
            this.colGameDrawBeforeWinsCount.FieldName = "GameDrawBeforeWinsCount";
            this.colGameDrawBeforeWinsCount.Name = "colGameDrawBeforeWinsCount";
            this.colGameDrawBeforeWinsCount.Visible = true;
            this.colGameDrawBeforeWinsCount.VisibleIndex = 7;
            this.colGameDrawBeforeWinsCount.Width = 110;
            // 
            // colWinningTitle
            // 
            this.colWinningTitle.Caption = "Τίτλος Νίκης";
            this.colWinningTitle.FieldName = "WinningTitle";
            this.colWinningTitle.Name = "colWinningTitle";
            this.colWinningTitle.Visible = true;
            this.colWinningTitle.VisibleIndex = 3;
            this.colWinningTitle.Width = 73;
            // 
            // GameIdTextEdit
            // 
            this.GameIdTextEdit.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.wizDrawGameBindingSource, "GameId", true));
            this.GameIdTextEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.wizDrawGameInfoBindingSource, "IsActive", true));
            this.GameIdTextEdit.Location = new System.Drawing.Point(113, 12);
            this.GameIdTextEdit.Name = "GameIdTextEdit";
            this.GameIdTextEdit.Size = new System.Drawing.Size(65, 20);
            this.GameIdTextEdit.StyleController = this.dataLayoutControl1;
            this.GameIdTextEdit.TabIndex = 4;
            // 
            // wizDrawGameInfoBindingSource
            // 
            this.wizDrawGameInfoBindingSource.DataSource = typeof(DrawGame.Domain.Model.Game.WizDrawGameInfo);
            // 
            // NameTextEdit
            // 
            this.NameTextEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.wizDrawGameBindingSource, "Name", true));
            this.NameTextEdit.Location = new System.Drawing.Point(350, 12);
            this.NameTextEdit.Name = "NameTextEdit";
            this.NameTextEdit.Size = new System.Drawing.Size(741, 20);
            this.NameTextEdit.StyleController = this.dataLayoutControl1;
            this.NameTextEdit.TabIndex = 5;
            // 
            // GameTypeLookUpEdit
            // 
            this.GameTypeLookUpEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.wizDrawGameBindingSource, "GameTypeId", true));
            this.GameTypeLookUpEdit.Location = new System.Drawing.Point(113, 36);
            this.GameTypeLookUpEdit.Name = "GameTypeLookUpEdit";
            this.GameTypeLookUpEdit.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.GameTypeLookUpEdit.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("Value", "Ονομασία")});
            this.GameTypeLookUpEdit.Properties.NullText = "";
            this.GameTypeLookUpEdit.Size = new System.Drawing.Size(978, 20);
            this.GameTypeLookUpEdit.StyleController = this.dataLayoutControl1;
            this.GameTypeLookUpEdit.TabIndex = 6;
            this.GameTypeLookUpEdit.ParseEditValue += new DevExpress.XtraEditors.Controls.ConvertEditValueEventHandler(this.GameTypeLookUpEdit_ParseEditValue);
            // 
            // BackgroundImagePictureEdit
            // 
            this.BackgroundImagePictureEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.wizDrawGameBindingSource, "BackgroundImage", true));
            this.BackgroundImagePictureEdit.Location = new System.Drawing.Point(24, 107);
            this.BackgroundImagePictureEdit.Name = "BackgroundImagePictureEdit";
            this.BackgroundImagePictureEdit.Properties.SizeMode = DevExpress.XtraEditors.Controls.PictureSizeMode.Stretch;
            this.BackgroundImagePictureEdit.Size = new System.Drawing.Size(428, 82);
            this.BackgroundImagePictureEdit.StyleController = this.dataLayoutControl1;
            this.BackgroundImagePictureEdit.TabIndex = 7;
            this.BackgroundImagePictureEdit.ParseEditValue += new DevExpress.XtraEditors.Controls.ConvertEditValueEventHandler(this.BackgroundImagePictureEdit_ParseEditValue);
            // 
            // WinImagePictureEdit
            // 
            this.WinImagePictureEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.wizDrawGameBindingSource, "WinImage", true));
            this.WinImagePictureEdit.Location = new System.Drawing.Point(456, 107);
            this.WinImagePictureEdit.Name = "WinImagePictureEdit";
            this.WinImagePictureEdit.Properties.SizeMode = DevExpress.XtraEditors.Controls.PictureSizeMode.Squeeze;
            this.WinImagePictureEdit.Size = new System.Drawing.Size(310, 82);
            this.WinImagePictureEdit.StyleController = this.dataLayoutControl1;
            this.WinImagePictureEdit.TabIndex = 8;
            this.WinImagePictureEdit.ParseEditValue += new DevExpress.XtraEditors.Controls.ConvertEditValueEventHandler(this.WinImagePictureEdit_ParseEditValue);
            // 
            // LostImagePictureEdit
            // 
            this.LostImagePictureEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.wizDrawGameBindingSource, "LostImage", true));
            this.LostImagePictureEdit.Location = new System.Drawing.Point(770, 107);
            this.LostImagePictureEdit.Name = "LostImagePictureEdit";
            this.LostImagePictureEdit.Properties.SizeMode = DevExpress.XtraEditors.Controls.PictureSizeMode.Squeeze;
            this.LostImagePictureEdit.Size = new System.Drawing.Size(309, 82);
            this.LostImagePictureEdit.StyleController = this.dataLayoutControl1;
            this.LostImagePictureEdit.TabIndex = 9;
            this.LostImagePictureEdit.ParseEditValue += new DevExpress.XtraEditors.Controls.ConvertEditValueEventHandler(this.LostImagePictureEdit_ParseEditValue);
            // 
            // WinSoundPictureEdit
            // 
            this.WinSoundPictureEdit.CausesValidation = false;
            this.WinSoundPictureEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.wizDrawGameBindingSource, "WinSound", true));
            this.WinSoundPictureEdit.EditValue = "<Null>";
            this.WinSoundPictureEdit.Location = new System.Drawing.Point(177, 252);
            this.WinSoundPictureEdit.Name = "WinSoundPictureEdit";
            this.WinSoundPictureEdit.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.WinSoundPictureEdit.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.HideTextEditor;
            this.WinSoundPictureEdit.Properties.ValidateOnEnterKey = true;
            this.WinSoundPictureEdit.Size = new System.Drawing.Size(101, 18);
            this.WinSoundPictureEdit.StyleController = this.dataLayoutControl1;
            this.WinSoundPictureEdit.TabIndex = 10;
            this.WinSoundPictureEdit.TabStop = false;
            this.WinSoundPictureEdit.ButtonClick += new DevExpress.XtraEditors.Controls.ButtonPressedEventHandler(this.WinSoundPictureEdit_ButtonClick);
            // 
            // LostSoundPictureEdit
            // 
            this.LostSoundPictureEdit.CausesValidation = false;
            this.LostSoundPictureEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.wizDrawGameBindingSource, "LostSound", true));
            this.LostSoundPictureEdit.EditValue = "<Null>";
            this.LostSoundPictureEdit.Location = new System.Drawing.Point(435, 252);
            this.LostSoundPictureEdit.Name = "LostSoundPictureEdit";
            this.LostSoundPictureEdit.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.LostSoundPictureEdit.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.HideTextEditor;
            this.LostSoundPictureEdit.Size = new System.Drawing.Size(101, 18);
            this.LostSoundPictureEdit.StyleController = this.dataLayoutControl1;
            this.LostSoundPictureEdit.TabIndex = 11;
            this.LostSoundPictureEdit.TabStop = false;
            this.LostSoundPictureEdit.ButtonClick += new DevExpress.XtraEditors.Controls.ButtonPressedEventHandler(this.LostSoundPictureEdit_ButtonClick);
            // 
            // checkEdit1
            // 
            this.checkEdit1.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.wizDrawGameBindingSource, "IsActive", true));
            this.checkEdit1.Location = new System.Drawing.Point(182, 12);
            this.checkEdit1.MenuManager = this.ribbonControl1;
            this.checkEdit1.Name = "checkEdit1";
            this.checkEdit1.Properties.Caption = "Ενεργό";
            this.checkEdit1.Size = new System.Drawing.Size(63, 19);
            this.checkEdit1.StyleController = this.dataLayoutControl1;
            this.checkEdit1.TabIndex = 16;
            // 
            // ribbonControl1
            // 
            this.ribbonControl1.ExpandCollapseItem.Id = 0;
            this.ribbonControl1.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.ribbonControl1.ExpandCollapseItem,
            this.SaveBarButtonItem,
            this.ExitBarButtonItem});
            this.ribbonControl1.Location = new System.Drawing.Point(0, 0);
            this.ribbonControl1.MaxItemId = 5;
            this.ribbonControl1.Name = "ribbonControl1";
            this.ribbonControl1.Pages.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPage[] {
            this.ribbonPage1});
            this.ribbonControl1.Size = new System.Drawing.Size(1103, 114);
            this.ribbonControl1.ToolbarLocation = DevExpress.XtraBars.Ribbon.RibbonQuickAccessToolbarLocation.Hidden;
            // 
            // SaveBarButtonItem
            // 
            this.SaveBarButtonItem.AllowGlyphSkinning = DevExpress.Utils.DefaultBoolean.False;
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
            // layoutControlGroup1
            // 
            this.layoutControlGroup1.CustomizationFormText = "layoutControlGroup1";
            this.layoutControlGroup1.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
            this.layoutControlGroup1.GroupBordersVisible = false;
            this.layoutControlGroup1.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutControlGroup2});
            this.layoutControlGroup1.Location = new System.Drawing.Point(0, 0);
            this.layoutControlGroup1.Name = "layoutControlGroup1";
            this.layoutControlGroup1.Size = new System.Drawing.Size(1103, 705);
            this.layoutControlGroup1.Text = "layoutControlGroup1";
            this.layoutControlGroup1.TextVisible = false;
            // 
            // layoutControlGroup2
            // 
            this.layoutControlGroup2.AllowDrawBackground = false;
            this.layoutControlGroup2.CustomizationFormText = "autoGeneratedGroup0";
            this.layoutControlGroup2.GroupBordersVisible = false;
            this.layoutControlGroup2.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.ItemForGameId,
            this.ItemForName,
            this.ItemForGameType,
            this.layoutControlGroup3,
            this.layoutControlGroup4,
            this.layoutControlGroup5,
            this.layoutControlItem7});
            this.layoutControlGroup2.Location = new System.Drawing.Point(0, 0);
            this.layoutControlGroup2.Name = "autoGeneratedGroup0";
            this.layoutControlGroup2.Size = new System.Drawing.Size(1083, 685);
            this.layoutControlGroup2.Text = "autoGeneratedGroup0";
            // 
            // ItemForGameId
            // 
            this.ItemForGameId.Control = this.GameIdTextEdit;
            this.ItemForGameId.CustomizationFormText = "Game Id";
            this.ItemForGameId.Location = new System.Drawing.Point(0, 0);
            this.ItemForGameId.Name = "ItemForGameId";
            this.ItemForGameId.Size = new System.Drawing.Size(170, 24);
            this.ItemForGameId.Text = "Κωδ. Παιχνιδιου";
            this.ItemForGameId.TextSize = new System.Drawing.Size(98, 13);
            // 
            // ItemForName
            // 
            this.ItemForName.Control = this.NameTextEdit;
            this.ItemForName.CustomizationFormText = "Name";
            this.ItemForName.Location = new System.Drawing.Point(237, 0);
            this.ItemForName.Name = "ItemForName";
            this.ItemForName.Size = new System.Drawing.Size(846, 24);
            this.ItemForName.Text = "Ονομασία Παιχνιδιού";
            this.ItemForName.TextSize = new System.Drawing.Size(98, 13);
            // 
            // ItemForGameType
            // 
            this.ItemForGameType.Control = this.GameTypeLookUpEdit;
            this.ItemForGameType.CustomizationFormText = "Game Type";
            this.ItemForGameType.Location = new System.Drawing.Point(0, 24);
            this.ItemForGameType.Name = "ItemForGameType";
            this.ItemForGameType.Size = new System.Drawing.Size(1083, 24);
            this.ItemForGameType.Text = "Τύπος Παιχνιδιου";
            this.ItemForGameType.TextSize = new System.Drawing.Size(98, 13);
            // 
            // layoutControlGroup3
            // 
            this.layoutControlGroup3.CustomizationFormText = "Τμήματα Παιχνιδιού";
            this.layoutControlGroup3.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutControlItem1,
            this.layoutControlItem2,
            this.emptySpaceItem1,
            this.layoutControlItem4,
            this.layoutControlItem3});
            this.layoutControlGroup3.Location = new System.Drawing.Point(0, 276);
            this.layoutControlGroup3.Name = "layoutControlGroup3";
            this.layoutControlGroup3.Size = new System.Drawing.Size(1083, 409);
            this.layoutControlGroup3.Text = "Τμήματα Παιχνιδιού";
            // 
            // layoutControlItem1
            // 
            this.layoutControlItem1.Control = this.gameItemsGridControl;
            this.layoutControlItem1.CustomizationFormText = "layoutControlItem1";
            this.layoutControlItem1.Location = new System.Drawing.Point(0, 40);
            this.layoutControlItem1.Name = "layoutControlItem1";
            this.layoutControlItem1.Size = new System.Drawing.Size(655, 326);
            this.layoutControlItem1.Text = "layoutControlItem1";
            this.layoutControlItem1.TextLocation = DevExpress.Utils.Locations.Top;
            this.layoutControlItem1.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem1.TextToControlDistance = 0;
            this.layoutControlItem1.TextVisible = false;
            // 
            // layoutControlItem2
            // 
            this.layoutControlItem2.Control = this.dataLayoutControl2;
            this.layoutControlItem2.CustomizationFormText = "layoutControlItem2";
            this.layoutControlItem2.Location = new System.Drawing.Point(655, 40);
            this.layoutControlItem2.Name = "layoutControlItem2";
            this.layoutControlItem2.Size = new System.Drawing.Size(404, 326);
            this.layoutControlItem2.Text = "layoutControlItem2";
            this.layoutControlItem2.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem2.TextToControlDistance = 0;
            this.layoutControlItem2.TextVisible = false;
            // 
            // emptySpaceItem1
            // 
            this.emptySpaceItem1.AllowHotTrack = false;
            this.emptySpaceItem1.CustomizationFormText = "emptySpaceItem1";
            this.emptySpaceItem1.Location = new System.Drawing.Point(242, 0);
            this.emptySpaceItem1.Name = "emptySpaceItem1";
            this.emptySpaceItem1.Size = new System.Drawing.Size(817, 40);
            this.emptySpaceItem1.Text = "emptySpaceItem1";
            this.emptySpaceItem1.TextSize = new System.Drawing.Size(0, 0);
            // 
            // layoutControlItem4
            // 
            this.layoutControlItem4.Control = this.NewSimpleButton;
            this.layoutControlItem4.CustomizationFormText = "layoutControlItem4";
            this.layoutControlItem4.Location = new System.Drawing.Point(0, 0);
            this.layoutControlItem4.Name = "layoutControlItem4";
            this.layoutControlItem4.Size = new System.Drawing.Size(118, 40);
            this.layoutControlItem4.Text = "layoutControlItem4";
            this.layoutControlItem4.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem4.TextToControlDistance = 0;
            this.layoutControlItem4.TextVisible = false;
            // 
            // layoutControlItem3
            // 
            this.layoutControlItem3.Control = this.DeleteSimpleButton;
            this.layoutControlItem3.CustomizationFormText = "layoutControlItem3";
            this.layoutControlItem3.Location = new System.Drawing.Point(118, 0);
            this.layoutControlItem3.Name = "layoutControlItem3";
            this.layoutControlItem3.Size = new System.Drawing.Size(124, 40);
            this.layoutControlItem3.Text = "layoutControlItem3";
            this.layoutControlItem3.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem3.TextToControlDistance = 0;
            this.layoutControlItem3.TextVisible = false;
            // 
            // layoutControlGroup4
            // 
            this.layoutControlGroup4.CustomizationFormText = "Ηχοι";
            this.layoutControlGroup4.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.ItemForWinSound,
            this.ItemForLostSound,
            this.layoutControlItem5,
            this.layoutControlItem6,
            this.emptySpaceItem2});
            this.layoutControlGroup4.Location = new System.Drawing.Point(0, 193);
            this.layoutControlGroup4.Name = "layoutControlGroup4";
            this.layoutControlGroup4.Size = new System.Drawing.Size(1083, 83);
            this.layoutControlGroup4.Text = "Ηχοι";
            // 
            // ItemForWinSound
            // 
            this.ItemForWinSound.Control = this.WinSoundPictureEdit;
            this.ItemForWinSound.CustomizationFormText = "Win Sound";
            this.ItemForWinSound.Location = new System.Drawing.Point(153, 0);
            this.ItemForWinSound.Name = "ItemForWinSound";
            this.ItemForWinSound.Size = new System.Drawing.Size(105, 40);
            this.ItemForWinSound.Text = "Νίκης";
            this.ItemForWinSound.TextLocation = DevExpress.Utils.Locations.Top;
            this.ItemForWinSound.TextSize = new System.Drawing.Size(98, 13);
            // 
            // ItemForLostSound
            // 
            this.ItemForLostSound.Control = this.LostSoundPictureEdit;
            this.ItemForLostSound.CustomizationFormText = "Lost Sound";
            this.ItemForLostSound.Location = new System.Drawing.Point(411, 0);
            this.ItemForLostSound.Name = "ItemForLostSound";
            this.ItemForLostSound.Size = new System.Drawing.Size(105, 40);
            this.ItemForLostSound.Text = "Ηττας";
            this.ItemForLostSound.TextLocation = DevExpress.Utils.Locations.Top;
            this.ItemForLostSound.TextSize = new System.Drawing.Size(98, 13);
            // 
            // layoutControlItem5
            // 
            this.layoutControlItem5.Control = this.PlayWinSimpleButton;
            this.layoutControlItem5.CustomizationFormText = "layoutControlItem5";
            this.layoutControlItem5.Location = new System.Drawing.Point(0, 0);
            this.layoutControlItem5.Name = "layoutControlItem5";
            this.layoutControlItem5.Size = new System.Drawing.Size(153, 40);
            this.layoutControlItem5.Text = "layoutControlItem5";
            this.layoutControlItem5.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem5.TextToControlDistance = 0;
            this.layoutControlItem5.TextVisible = false;
            // 
            // layoutControlItem6
            // 
            this.layoutControlItem6.Control = this.PlayLostSimpleButton;
            this.layoutControlItem6.CustomizationFormText = "layoutControlItem6";
            this.layoutControlItem6.Location = new System.Drawing.Point(258, 0);
            this.layoutControlItem6.Name = "layoutControlItem6";
            this.layoutControlItem6.Size = new System.Drawing.Size(153, 40);
            this.layoutControlItem6.Text = "layoutControlItem6";
            this.layoutControlItem6.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem6.TextToControlDistance = 0;
            this.layoutControlItem6.TextVisible = false;
            // 
            // emptySpaceItem2
            // 
            this.emptySpaceItem2.AllowHotTrack = false;
            this.emptySpaceItem2.CustomizationFormText = "emptySpaceItem2";
            this.emptySpaceItem2.Location = new System.Drawing.Point(516, 0);
            this.emptySpaceItem2.Name = "emptySpaceItem2";
            this.emptySpaceItem2.Size = new System.Drawing.Size(543, 40);
            this.emptySpaceItem2.Text = "emptySpaceItem2";
            this.emptySpaceItem2.TextSize = new System.Drawing.Size(0, 0);
            // 
            // layoutControlGroup5
            // 
            this.layoutControlGroup5.CustomizationFormText = "Εικόνες";
            this.layoutControlGroup5.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.ItemForBackgroundImage,
            this.ItemForWinImage,
            this.ItemForLostImage});
            this.layoutControlGroup5.Location = new System.Drawing.Point(0, 48);
            this.layoutControlGroup5.Name = "layoutControlGroup5";
            this.layoutControlGroup5.Size = new System.Drawing.Size(1083, 145);
            this.layoutControlGroup5.Text = "Εικόνες";
            // 
            // ItemForBackgroundImage
            // 
            this.ItemForBackgroundImage.Control = this.BackgroundImagePictureEdit;
            this.ItemForBackgroundImage.CustomizationFormText = "Background Image";
            this.ItemForBackgroundImage.Location = new System.Drawing.Point(0, 0);
            this.ItemForBackgroundImage.Name = "ItemForBackgroundImage";
            this.ItemForBackgroundImage.Size = new System.Drawing.Size(432, 102);
            this.ItemForBackgroundImage.Text = "Φόντου";
            this.ItemForBackgroundImage.TextLocation = DevExpress.Utils.Locations.Top;
            this.ItemForBackgroundImage.TextSize = new System.Drawing.Size(98, 13);
            // 
            // ItemForWinImage
            // 
            this.ItemForWinImage.Control = this.WinImagePictureEdit;
            this.ItemForWinImage.CustomizationFormText = "Win Image";
            this.ItemForWinImage.Location = new System.Drawing.Point(432, 0);
            this.ItemForWinImage.Name = "ItemForWinImage";
            this.ItemForWinImage.Size = new System.Drawing.Size(314, 102);
            this.ItemForWinImage.Text = "Νίκης";
            this.ItemForWinImage.TextLocation = DevExpress.Utils.Locations.Top;
            this.ItemForWinImage.TextSize = new System.Drawing.Size(98, 13);
            // 
            // ItemForLostImage
            // 
            this.ItemForLostImage.Control = this.LostImagePictureEdit;
            this.ItemForLostImage.CustomizationFormText = "Lost Image";
            this.ItemForLostImage.Location = new System.Drawing.Point(746, 0);
            this.ItemForLostImage.Name = "ItemForLostImage";
            this.ItemForLostImage.Size = new System.Drawing.Size(313, 102);
            this.ItemForLostImage.Text = "Ήττας";
            this.ItemForLostImage.TextLocation = DevExpress.Utils.Locations.Top;
            this.ItemForLostImage.TextSize = new System.Drawing.Size(98, 13);
            // 
            // layoutControlItem7
            // 
            this.layoutControlItem7.Control = this.checkEdit1;
            this.layoutControlItem7.CustomizationFormText = "Is Active";
            this.layoutControlItem7.Location = new System.Drawing.Point(170, 0);
            this.layoutControlItem7.Name = "ItemForIsActive";
            this.layoutControlItem7.Size = new System.Drawing.Size(67, 24);
            this.layoutControlItem7.Text = "Is Active";
            this.layoutControlItem7.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem7.TextToControlDistance = 0;
            this.layoutControlItem7.TextVisible = false;
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // GameEditForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(1120, 741);
            this.Controls.Add(this.ribbonControl1);
            this.Controls.Add(this.dataLayoutControl1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "GameEditForm";
            this.Text = "GameEditForm";
            ((System.ComponentModel.ISupportInitialize)(this.wizDrawGameBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataLayoutControl1)).EndInit();
            this.dataLayoutControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataLayoutControl2)).EndInit();
            this.dataLayoutControl2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.ProductCodeTextEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gameItemsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ProductNameTextEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.IsActiveCheckEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.IsLoosingCheckEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.CaptionTextEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ImagePictureEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.GameDrawBeforeWinsCountSpinEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.WinningTitleTextEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ObjectStateTextEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BackColorColorEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup7)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForProductCode)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForObjectState)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForCaption)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForImage)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForProductName)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForWinningTitle)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForIsActive)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForGameDrawBeforeWinsCount)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForIsLoosing)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForBackColor)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gameItemsGridControl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.GameItemsGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemColorEdit1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.GameIdTextEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.wizDrawGameInfoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.NameTextEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.GameTypeLookUpEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BackgroundImagePictureEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.WinImagePictureEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.LostImagePictureEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.WinSoundPictureEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.LostSoundPictureEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.checkEdit1.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ribbonControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForGameId)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForName)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForGameType)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForWinSound)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForLostSound)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForBackgroundImage)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForWinImage)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForLostImage)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem7)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.BindingSource wizDrawGameBindingSource;
        private DevExpress.XtraDataLayout.DataLayoutControl dataLayoutControl1;
        private DevExpress.XtraGrid.GridControl gameItemsGridControl;
        private System.Windows.Forms.BindingSource gameItemsBindingSource;
        private DevExpress.XtraGrid.Views.Grid.GridView GameItemsGridView;
        private DevExpress.XtraGrid.Columns.GridColumn colProductCode;
        private DevExpress.XtraGrid.Columns.GridColumn colProductName;
        private DevExpress.XtraGrid.Columns.GridColumn colBackColor;
        private DevExpress.XtraEditors.Repository.RepositoryItemColorEdit repositoryItemColorEdit1;
        private DevExpress.XtraGrid.Columns.GridColumn colIsActive;
        private DevExpress.XtraGrid.Columns.GridColumn colIsLoosing;
        private DevExpress.XtraGrid.Columns.GridColumn colCaption;
        private DevExpress.XtraGrid.Columns.GridColumn colImage;
        private DevExpress.XtraGrid.Columns.GridColumn colGameDrawBeforeWinsCount;
        private DevExpress.XtraGrid.Columns.GridColumn colWinningTitle;
        private DevExpress.XtraEditors.TextEdit GameIdTextEdit;
        private DevExpress.XtraEditors.TextEdit NameTextEdit;
        private DevExpress.XtraEditors.LookUpEdit GameTypeLookUpEdit;
        private DevExpress.XtraEditors.PictureEdit BackgroundImagePictureEdit;
        private DevExpress.XtraEditors.PictureEdit WinImagePictureEdit;
        private DevExpress.XtraEditors.PictureEdit LostImagePictureEdit;
        private DevExpress.XtraLayout.LayoutControlGroup layoutControlGroup1;
        private DevExpress.XtraLayout.LayoutControlGroup layoutControlGroup2;
        private DevExpress.XtraLayout.LayoutControlItem ItemForGameId;
        private DevExpress.XtraLayout.LayoutControlItem ItemForName;
        private DevExpress.XtraLayout.LayoutControlItem ItemForGameType;
        private DevExpress.XtraLayout.LayoutControlGroup layoutControlGroup3;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem1;
        private DevExpress.XtraLayout.LayoutControlGroup layoutControlGroup4;
        private DevExpress.XtraLayout.LayoutControlItem ItemForWinSound;
        private DevExpress.XtraLayout.LayoutControlItem ItemForLostSound;
        private DevExpress.XtraLayout.LayoutControlGroup layoutControlGroup5;
        private DevExpress.XtraLayout.LayoutControlItem ItemForBackgroundImage;
        private DevExpress.XtraLayout.LayoutControlItem ItemForWinImage;
        private DevExpress.XtraLayout.LayoutControlItem ItemForLostImage;
        private DevExpress.XtraDataLayout.DataLayoutControl dataLayoutControl2;
        private DevExpress.XtraEditors.TextEdit ProductCodeTextEdit;
        private DevExpress.XtraEditors.TextEdit ProductNameTextEdit;
        private DevExpress.XtraEditors.CheckEdit IsActiveCheckEdit;
        private DevExpress.XtraEditors.CheckEdit IsLoosingCheckEdit;
        private DevExpress.XtraEditors.TextEdit CaptionTextEdit;
        private DevExpress.XtraEditors.PictureEdit ImagePictureEdit;
        private DevExpress.XtraEditors.SpinEdit GameDrawBeforeWinsCountSpinEdit;
        private DevExpress.XtraEditors.TextEdit WinningTitleTextEdit;
        private DevExpress.XtraEditors.TextEdit ObjectStateTextEdit;
        private DevExpress.XtraLayout.LayoutControlGroup layoutControlGroup6;
        private DevExpress.XtraLayout.LayoutControlGroup layoutControlGroup7;
        private DevExpress.XtraLayout.LayoutControlItem ItemForProductCode;
        private DevExpress.XtraLayout.LayoutControlItem ItemForProductName;
        private DevExpress.XtraLayout.LayoutControlItem ItemForBackColor;
        private DevExpress.XtraLayout.LayoutControlItem ItemForIsActive;
        private DevExpress.XtraLayout.LayoutControlItem ItemForIsLoosing;
        private DevExpress.XtraLayout.LayoutControlItem ItemForCaption;
        private DevExpress.XtraLayout.LayoutControlItem ItemForImage;
        private DevExpress.XtraLayout.LayoutControlItem ItemForGameDrawBeforeWinsCount;
        private DevExpress.XtraLayout.LayoutControlItem ItemForWinningTitle;
        private DevExpress.XtraLayout.LayoutControlItem ItemForObjectState;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem2;
        private DevExpress.XtraBars.Ribbon.RibbonControl ribbonControl1;
        private DevExpress.XtraBars.BarButtonItem SaveBarButtonItem;
        private DevExpress.XtraBars.BarButtonItem ExitBarButtonItem;
        private DevExpress.XtraBars.Ribbon.RibbonPage ribbonPage1;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup1;
        private DevExpress.XtraEditors.SimpleButton DeleteSimpleButton;
        private DevExpress.XtraLayout.EmptySpaceItem emptySpaceItem1;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem3;
        private DevExpress.XtraEditors.SimpleButton NewSimpleButton;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem4;
        private DevExpress.XtraEditors.ButtonEdit WinSoundPictureEdit;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private DevExpress.XtraEditors.ButtonEdit LostSoundPictureEdit;
        private DevExpress.XtraEditors.ColorEdit BackColorColorEdit;
        private DevExpress.XtraEditors.SimpleButton PlayLostSimpleButton;
        private DevExpress.XtraEditors.SimpleButton PlayWinSimpleButton;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem5;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem6;
        private DevExpress.XtraLayout.EmptySpaceItem emptySpaceItem2;
        private System.Windows.Forms.BindingSource wizDrawGameInfoBindingSource;
        private DevExpress.XtraEditors.CheckEdit checkEdit1;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem7;

    }
}