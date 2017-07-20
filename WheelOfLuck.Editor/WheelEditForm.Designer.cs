using DrawGame.Domain.Game;
using DrawGame;
using DrawGame.Domain.Model.Game;
using DrawGame = DrawGame.Domain.Game;

namespace DrawGame.Editor
{
    partial class WheelEditForm
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle11 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(WheelEditForm));
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ProductCode = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ProductName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Caption = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.AmountOfPeople = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Image = new System.Windows.Forms.DataGridViewImageColumn();
            this.GameItemBackColor1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.IsActive = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.IsLoosingPie = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.del = new System.Windows.Forms.DataGridViewButtonColumn();
            this.wheelBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.ImageForGamePartButton = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.SaveButton = new System.Windows.Forms.Button();
            this.BackgroundForGameButton = new System.Windows.Forms.Button();
            this.WinImageForGameButton = new System.Windows.Forms.Button();
            this.LostImageForGameButton = new System.Windows.Forms.Button();
            this.WinSoundForGameButton = new System.Windows.Forms.Button();
            this.LostSoundForGameButton = new System.Windows.Forms.Button();
            this.ColorForGamePartButton = new System.Windows.Forms.Button();
            this.colorDialog1 = new System.Windows.Forms.ColorDialog();
            this.bindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.nameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewComboBoxColumn1 = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.combo = new System.Windows.Forms.BindingSource(this.components);
            this.Delete = new System.Windows.Forms.DataGridViewButtonColumn();
            this.Background = new System.Windows.Forms.DataGridViewImageColumn();
            this.WinImage = new System.Windows.Forms.DataGridViewImageColumn();
            this.LostImage = new System.Windows.Forms.DataGridViewImageColumn();
            this.WinSound = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.LostSound = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.wheelBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.combo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToResizeColumns = false;
            this.dataGridView1.AllowUserToResizeRows = false;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.White;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.ProductCode,
            this.ProductName,
            this.Caption,
            this.AmountOfPeople,
            this.Image,
            this.GameItemBackColor1,
            this.IsActive,
            this.IsLoosingPie,
            this.del});
            this.dataGridView1.DataMember = "GameItems";
            this.dataGridView1.DataSource = this.wheelBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(12, 267);
            this.dataGridView1.MultiSelect = false;
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.RowTemplate.Height = 50;
            this.dataGridView1.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView1.Size = new System.Drawing.Size(880, 316);
            this.dataGridView1.TabIndex = 2;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            this.dataGridView1.CellValidating += new System.Windows.Forms.DataGridViewCellValidatingEventHandler(this.dataGridView1_CellValidating);
            this.dataGridView1.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellValueChanged);
            this.dataGridView1.SelectionChanged += new System.EventHandler(this.dataGridView1_SelectionChanged);
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "WheelId";
            this.dataGridViewTextBoxColumn1.HeaderText = "κωδικος κυκλου";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            this.dataGridViewTextBoxColumn1.Width = 70;
            // 
            // ProductCode
            // 
            this.ProductCode.DataPropertyName = "ProductCode";
            this.ProductCode.HeaderText = "κωδ.  προιον";
            this.ProductCode.MaxInputLength = 50;
            this.ProductCode.Name = "ProductCode";
            // 
            // ProductName
            // 
            this.ProductName.DataPropertyName = "ProductName";
            this.ProductName.HeaderText = "Ετικετα Νικης";
            this.ProductName.MaxInputLength = 36;
            this.ProductName.Name = "ProductName";
            // 
            // Caption
            // 
            this.Caption.DataPropertyName = "Caption";
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.Caption.DefaultCellStyle = dataGridViewCellStyle1;
            this.Caption.HeaderText = "τιτλος";
            this.Caption.MaxInputLength = 14;
            this.Caption.Name = "Caption";
            // 
            // AmountOfPeople
            // 
            this.AmountOfPeople.DataPropertyName = "WheelDrawBeforeWinsCount";
            this.AmountOfPeople.HeaderText = "Πληθος ανθρωπων ανα ενα δωρο";
            this.AmountOfPeople.MaxInputLength = 9;
            this.AmountOfPeople.Name = "AmountOfPeople";
            this.AmountOfPeople.Width = 130;
            // 
            // Image
            // 
            this.Image.DataPropertyName = "Image";
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.NullValue = null;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.Image.DefaultCellStyle = dataGridViewCellStyle2;
            this.Image.HeaderText = "εικονα";
            this.Image.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Zoom;
            this.Image.Name = "Image";
            this.Image.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Image.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // GameItemBackColor1
            // 
            this.GameItemBackColor1.DataPropertyName = "GameItemBackColor1";
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.Transparent;
            this.GameItemBackColor1.DefaultCellStyle = dataGridViewCellStyle3;
            this.GameItemBackColor1.HeaderText = "χρωμα";
            this.GameItemBackColor1.Name = "GameItemBackColor1";
            this.GameItemBackColor1.ReadOnly = true;
            // 
            // IsActive
            // 
            this.IsActive.DataPropertyName = "IsActive";
            this.IsActive.HeaderText = "ενεργο";
            this.IsActive.Name = "IsActive";
            this.IsActive.Width = 50;
            // 
            // IsLoosingPie
            // 
            this.IsLoosingPie.DataPropertyName = "IsLoosingPie";
            this.IsLoosingPie.HeaderText = "χανει";
            this.IsLoosingPie.Name = "IsLoosingPie";
            this.IsLoosingPie.Width = 50;
            // 
            // del
            // 
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.Red;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.NullValue = "x";
            this.del.DefaultCellStyle = dataGridViewCellStyle4;
            this.del.HeaderText = "Διαγραφη";
            this.del.Name = "del";
            this.del.Width = 60;
            // 
            // wheelBindingSource
            // 
            this.wheelBindingSource.DataSource = typeof(WizDrawGame);
            // 
            // ImageForGamePartButton
            // 
            this.ImageForGamePartButton.Location = new System.Drawing.Point(576, 276);
            this.ImageForGamePartButton.Name = "ImageForGamePartButton";
            this.ImageForGamePartButton.Size = new System.Drawing.Size(34, 21);
            this.ImageForGamePartButton.TabIndex = 3;
            this.ImageForGamePartButton.Text = "...";
            this.ImageForGamePartButton.UseVisualStyleBackColor = true;
            this.ImageForGamePartButton.Click += new System.EventHandler(this.ImageForGamePartButton_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // SaveButton
            // 
            this.SaveButton.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.SaveButton.Location = new System.Drawing.Point(397, 599);
            this.SaveButton.Name = "SaveButton";
            this.SaveButton.Size = new System.Drawing.Size(110, 46);
            this.SaveButton.TabIndex = 4;
            this.SaveButton.Text = "αποθήκευση ";
            this.SaveButton.UseVisualStyleBackColor = false;
            this.SaveButton.Click += new System.EventHandler(this.SaveButton_Click);
            // 
            // BackgroundForGameButton
            // 
            this.BackgroundForGameButton.Location = new System.Drawing.Point(349, 42);
            this.BackgroundForGameButton.Name = "BackgroundForGameButton";
            this.BackgroundForGameButton.Size = new System.Drawing.Size(30, 20);
            this.BackgroundForGameButton.TabIndex = 15;
            this.BackgroundForGameButton.Text = "...";
            this.BackgroundForGameButton.UseVisualStyleBackColor = true;
            this.BackgroundForGameButton.Click += new System.EventHandler(this.BackgroundForGameButton_Click);
            // 
            // WinImageForGameButton
            // 
            this.WinImageForGameButton.Location = new System.Drawing.Point(459, 42);
            this.WinImageForGameButton.Name = "WinImageForGameButton";
            this.WinImageForGameButton.Size = new System.Drawing.Size(30, 20);
            this.WinImageForGameButton.TabIndex = 16;
            this.WinImageForGameButton.Text = "...";
            this.WinImageForGameButton.UseVisualStyleBackColor = true;
            this.WinImageForGameButton.Click += new System.EventHandler(this.WinImageForGameButton_Click);
            // 
            // LostImageForGameButton
            // 
            this.LostImageForGameButton.Location = new System.Drawing.Point(573, 42);
            this.LostImageForGameButton.Name = "LostImageForGameButton";
            this.LostImageForGameButton.Size = new System.Drawing.Size(30, 20);
            this.LostImageForGameButton.TabIndex = 17;
            this.LostImageForGameButton.Text = "...";
            this.LostImageForGameButton.UseVisualStyleBackColor = true;
            this.LostImageForGameButton.Click += new System.EventHandler(this.LostImageForGameButton_Click);
            // 
            // WinSoundForGameButton
            // 
            this.WinSoundForGameButton.Location = new System.Drawing.Point(681, 42);
            this.WinSoundForGameButton.Name = "WinSoundForGameButton";
            this.WinSoundForGameButton.Size = new System.Drawing.Size(30, 20);
            this.WinSoundForGameButton.TabIndex = 18;
            this.WinSoundForGameButton.Text = "...";
            this.WinSoundForGameButton.UseVisualStyleBackColor = true;
            this.WinSoundForGameButton.Click += new System.EventHandler(this.WinSoundForGameButton_Click);
            // 
            // LostSoundForGameButton
            // 
            this.LostSoundForGameButton.Location = new System.Drawing.Point(791, 42);
            this.LostSoundForGameButton.Name = "LostSoundForGameButton";
            this.LostSoundForGameButton.Size = new System.Drawing.Size(30, 20);
            this.LostSoundForGameButton.TabIndex = 19;
            this.LostSoundForGameButton.Text = "...";
            this.LostSoundForGameButton.UseVisualStyleBackColor = true;
            this.LostSoundForGameButton.Click += new System.EventHandler(this.LostSoundForGameButton_Click);
            // 
            // ColorForGamePartButton
            // 
            this.ColorForGamePartButton.Location = new System.Drawing.Point(668, 276);
            this.ColorForGamePartButton.Name = "ColorForGamePartButton";
            this.ColorForGamePartButton.Size = new System.Drawing.Size(32, 21);
            this.ColorForGamePartButton.TabIndex = 21;
            this.ColorForGamePartButton.Text = "...";
            this.ColorForGamePartButton.UseVisualStyleBackColor = true;
            this.ColorForGamePartButton.Click += new System.EventHandler(this.ColorForGamePartButton_Click);
            // 
            // dataGridView2
            // 
            this.dataGridView2.AllowUserToResizeColumns = false;
            this.dataGridView2.AllowUserToResizeRows = false;
            this.dataGridView2.AutoGenerateColumns = false;
            this.dataGridView2.BackgroundColor = System.Drawing.Color.White;
            this.dataGridView2.ColumnHeadersHeight = 30;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dataGridView2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.nameDataGridViewTextBoxColumn,
            this.dataGridViewComboBoxColumn1,
            this.Delete,
            this.Background,
            this.WinImage,
            this.LostImage,
            this.WinSound,
            this.LostSound});
            this.dataGridView2.DataSource = this.wheelBindingSource;
            dataGridViewCellStyle11.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle11.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle11.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle11.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle11.NullValue = "null";
            dataGridViewCellStyle11.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle11.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle11.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView2.DefaultCellStyle = dataGridViewCellStyle11;
            this.dataGridView2.GridColor = System.Drawing.SystemColors.ControlText;
            this.dataGridView2.Location = new System.Drawing.Point(12, 36);
            this.dataGridView2.MultiSelect = false;
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.RowHeadersVisible = false;
            this.dataGridView2.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dataGridView2.RowTemplate.Height = 40;
            this.dataGridView2.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView2.Size = new System.Drawing.Size(880, 198);
            this.dataGridView2.TabIndex = 27;
            this.dataGridView2.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView2_CellContentClick);
            this.dataGridView2.CellEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView2_CellEnter);
            this.dataGridView2.KeyDown += new System.Windows.Forms.KeyEventHandler(this.dataGridView2_KeyDown);
            // 
            // nameDataGridViewTextBoxColumn
            // 
            this.nameDataGridViewTextBoxColumn.DataPropertyName = "Name";
            this.nameDataGridViewTextBoxColumn.HeaderText = "Name";
            this.nameDataGridViewTextBoxColumn.Name = "nameDataGridViewTextBoxColumn";
            // 
            // dataGridViewComboBoxColumn1
            // 
            this.dataGridViewComboBoxColumn1.DataPropertyName = "GameType";
            this.dataGridViewComboBoxColumn1.DataSource = this.combo;
            this.dataGridViewComboBoxColumn1.HeaderText = "GameType";
            this.dataGridViewComboBoxColumn1.Name = "dataGridViewComboBoxColumn1";
            this.dataGridViewComboBoxColumn1.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewComboBoxColumn1.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // Delete
            // 
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.Red;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle5.NullValue = "x";
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.Color.White;
            this.Delete.DefaultCellStyle = dataGridViewCellStyle5;
            this.Delete.HeaderText = "Διαγραφη";
            this.Delete.Name = "Delete";
            this.Delete.Text = "";
            this.Delete.Width = 60;
            // 
            // Background
            // 
            this.Background.DataPropertyName = "Background";
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.Background.DefaultCellStyle = dataGridViewCellStyle6;
            this.Background.HeaderText = "Background";
            this.Background.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Zoom;
            this.Background.Name = "Background";
            this.Background.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Background.Width = 110;
            // 
            // WinImage
            // 
            this.WinImage.DataPropertyName = "WinImage";
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.WinImage.DefaultCellStyle = dataGridViewCellStyle7;
            this.WinImage.HeaderText = "Εικονα νικης";
            this.WinImage.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Zoom;
            this.WinImage.Name = "WinImage";
            this.WinImage.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.WinImage.Width = 110;
            // 
            // LostImage
            // 
            this.LostImage.DataPropertyName = "LostImage";
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.LostImage.DefaultCellStyle = dataGridViewCellStyle8;
            this.LostImage.HeaderText = "Εικονα ηττας";
            this.LostImage.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Zoom;
            this.LostImage.Name = "LostImage";
            this.LostImage.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.LostImage.Width = 110;
            // 
            // WinSound
            // 
            this.WinSound.DataPropertyName = "WinSound";
            dataGridViewCellStyle9.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.WinSound.DefaultCellStyle = dataGridViewCellStyle9;
            this.WinSound.HeaderText = "Ηχος νικης";
            this.WinSound.Name = "WinSound";
            this.WinSound.ReadOnly = true;
            this.WinSound.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.WinSound.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.WinSound.Width = 110;
            // 
            // LostSound
            // 
            this.LostSound.DataPropertyName = "LostSound";
            dataGridViewCellStyle10.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.LostSound.DefaultCellStyle = dataGridViewCellStyle10;
            this.LostSound.HeaderText = "Ηχος ηττας";
            this.LostSound.Name = "LostSound";
            this.LostSound.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.LostSound.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.LostSound.Width = 110;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(118, 13);
            this.label1.TabIndex = 30;
            this.label1.Text = "Δημιουργία παιχνιδιού";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 251);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(172, 13);
            this.label2.TabIndex = 31;
            this.label2.Text = "Δημιουργία κομματιου παιχνιδιού";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(767, 12);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(125, 13);
            this.label3.TabIndex = 33;
            this.label3.Text = "* Μη υποχρεωτικό πεδίο";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.pictureBox1.Location = new System.Drawing.Point(748, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(13, 14);
            this.pictureBox1.TabIndex = 34;
            this.pictureBox1.TabStop = false;
            // 
            // WheelEditForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MintCream;
            this.ClientSize = new System.Drawing.Size(911, 657);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.LostSoundForGameButton);
            this.Controls.Add(this.WinSoundForGameButton);
            this.Controls.Add(this.LostImageForGameButton);
            this.Controls.Add(this.WinImageForGameButton);
            this.Controls.Add(this.BackgroundForGameButton);
            this.Controls.Add(this.dataGridView2);
            this.Controls.Add(this.ColorForGamePartButton);
            this.Controls.Add(this.SaveButton);
            this.Controls.Add(this.ImageForGamePartButton);
            this.Controls.Add(this.dataGridView1);
            this.ForeColor = System.Drawing.Color.Black;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "WheelEditForm";
            this.Text = "Wheel Editor";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.WheelEditForm_FormClosing);
            this.Shown += new System.EventHandler(this.WheelEditForm_Shown);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.wheelBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.combo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button ImageForGamePartButton;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Button SaveButton;
        private System.Windows.Forms.Button BackgroundForGameButton;
        private System.Windows.Forms.Button WinImageForGameButton;
        private System.Windows.Forms.Button LostImageForGameButton;
        private System.Windows.Forms.Button WinSoundForGameButton;
        private System.Windows.Forms.Button LostSoundForGameButton;
        private System.Windows.Forms.Button ColorForGamePartButton;
        private System.Windows.Forms.ColorDialog colorDialog1;
        private System.Windows.Forms.DataGridViewTextBoxColumn wheelIdDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource wheelBindingSource;
        private System.Windows.Forms.BindingSource bindingSource1;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.BindingSource combo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewComboBoxColumn dataGridViewComboBoxColumn1;
        private System.Windows.Forms.DataGridViewButtonColumn Delete;
        private System.Windows.Forms.DataGridViewImageColumn Background;
        private System.Windows.Forms.DataGridViewImageColumn WinImage;
        private System.Windows.Forms.DataGridViewImageColumn LostImage;
        private System.Windows.Forms.DataGridViewTextBoxColumn WinSound;
        private System.Windows.Forms.DataGridViewTextBoxColumn LostSound;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn ProductCode;
        private System.Windows.Forms.DataGridViewTextBoxColumn ProductName;
        private System.Windows.Forms.DataGridViewTextBoxColumn Caption;
        private System.Windows.Forms.DataGridViewTextBoxColumn AmountOfPeople;
        private System.Windows.Forms.DataGridViewImageColumn Image;
        private System.Windows.Forms.DataGridViewTextBoxColumn GameItemBackColor1;
        private System.Windows.Forms.DataGridViewCheckBoxColumn IsActive;
        private System.Windows.Forms.DataGridViewCheckBoxColumn IsLoosingPie;
        private System.Windows.Forms.DataGridViewButtonColumn del;
    }
}