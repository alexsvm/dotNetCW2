namespace dotNetCW2
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.Label prof_idLabel;
            System.Windows.Forms.Label prof_nameLabel;
            System.Windows.Forms.Label prof_descLabel;
            System.Windows.Forms.Label prof_imageLabel;
            System.Windows.Forms.Label prof_faculty_idLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            System.Windows.Forms.Label prof_faculty_idLabel1;
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.prof_faculty_idTextBox = new System.Windows.Forms.TextBox();
            this.professionBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.databaseDataSet = new dotNetCW2.databaseDataSet();
            this.prof_imagePictureBox = new System.Windows.Forms.PictureBox();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem3 = new System.Windows.Forms.ToolStripMenuItem();
            this.prof_descTextBox = new System.Windows.Forms.TextBox();
            this.prof_nameTextBox = new System.Windows.Forms.TextBox();
            this.prof_idTextBox = new System.Windows.Forms.TextBox();
            this.bindingNavigator1 = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorAddNewItem1 = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorCountItem1 = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorDeleteItem1 = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveFirstItem1 = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem1 = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem1 = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorSeparator4 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem1 = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem1 = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator5 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripButton1 = new System.Windows.Forms.ToolStripButton();
            this.professionDataGridView = new System.Windows.Forms.DataGridView();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.facultyDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.facultyBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.facultyBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorDeleteItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.facultyBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.facultyTableAdapter = new dotNetCW2.databaseDataSetTableAdapters.facultyTableAdapter();
            this.tableAdapterManager = new dotNetCW2.databaseDataSetTableAdapters.TableAdapterManager();
            this.professionTableAdapter = new dotNetCW2.databaseDataSetTableAdapters.professionTableAdapter();
            this.openFileDlg = new System.Windows.Forms.OpenFileDialog();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.prof_faculty_idComboBox = new System.Windows.Forms.ComboBox();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewImageColumn1 = new System.Windows.Forms.DataGridViewImageColumn();
            this.dataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.prof_faculty_id = new System.Windows.Forms.DataGridViewComboBoxColumn();
            prof_idLabel = new System.Windows.Forms.Label();
            prof_nameLabel = new System.Windows.Forms.Label();
            prof_descLabel = new System.Windows.Forms.Label();
            prof_imageLabel = new System.Windows.Forms.Label();
            prof_faculty_idLabel = new System.Windows.Forms.Label();
            prof_faculty_idLabel1 = new System.Windows.Forms.Label();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.professionBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.databaseDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.prof_imagePictureBox)).BeginInit();
            this.contextMenuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bindingNavigator1)).BeginInit();
            this.bindingNavigator1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.professionDataGridView)).BeginInit();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.facultyDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.facultyBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.facultyBindingNavigator)).BeginInit();
            this.facultyBindingNavigator.SuspendLayout();
            this.SuspendLayout();
            // 
            // prof_idLabel
            // 
            prof_idLabel.AutoSize = true;
            prof_idLabel.Location = new System.Drawing.Point(59, 277);
            prof_idLabel.Name = "prof_idLabel";
            prof_idLabel.Size = new System.Drawing.Size(39, 13);
            prof_idLabel.TabIndex = 2;
            prof_idLabel.Text = "prof id:";
            // 
            // prof_nameLabel
            // 
            prof_nameLabel.AutoSize = true;
            prof_nameLabel.Location = new System.Drawing.Point(59, 310);
            prof_nameLabel.Name = "prof_nameLabel";
            prof_nameLabel.Size = new System.Drawing.Size(57, 13);
            prof_nameLabel.TabIndex = 4;
            prof_nameLabel.Text = "prof name:";
            // 
            // prof_descLabel
            // 
            prof_descLabel.AutoSize = true;
            prof_descLabel.Location = new System.Drawing.Point(59, 355);
            prof_descLabel.Name = "prof_descLabel";
            prof_descLabel.Size = new System.Drawing.Size(54, 13);
            prof_descLabel.TabIndex = 6;
            prof_descLabel.Text = "prof desc:";
            // 
            // prof_imageLabel
            // 
            prof_imageLabel.AutoSize = true;
            prof_imageLabel.Location = new System.Drawing.Point(59, 400);
            prof_imageLabel.Name = "prof_imageLabel";
            prof_imageLabel.Size = new System.Drawing.Size(59, 13);
            prof_imageLabel.TabIndex = 8;
            prof_imageLabel.Text = "prof image:";
            // 
            // prof_faculty_idLabel
            // 
            prof_faculty_idLabel.AutoSize = true;
            prof_faculty_idLabel.Location = new System.Drawing.Point(59, 512);
            prof_faculty_idLabel.Name = "prof_faculty_idLabel";
            prof_faculty_idLabel.Size = new System.Drawing.Size(73, 13);
            prof_faculty_idLabel.TabIndex = 10;
            prof_faculty_idLabel.Text = "prof faculty id:";
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(889, 601);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(prof_faculty_idLabel1);
            this.tabPage1.Controls.Add(this.prof_faculty_idComboBox);
            this.tabPage1.Controls.Add(prof_faculty_idLabel);
            this.tabPage1.Controls.Add(this.prof_faculty_idTextBox);
            this.tabPage1.Controls.Add(prof_imageLabel);
            this.tabPage1.Controls.Add(this.prof_imagePictureBox);
            this.tabPage1.Controls.Add(prof_descLabel);
            this.tabPage1.Controls.Add(this.prof_descTextBox);
            this.tabPage1.Controls.Add(prof_nameLabel);
            this.tabPage1.Controls.Add(this.prof_nameTextBox);
            this.tabPage1.Controls.Add(prof_idLabel);
            this.tabPage1.Controls.Add(this.prof_idTextBox);
            this.tabPage1.Controls.Add(this.bindingNavigator1);
            this.tabPage1.Controls.Add(this.professionDataGridView);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(881, 575);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Специальности";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // prof_faculty_idTextBox
            // 
            this.prof_faculty_idTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.professionBindingSource, "prof_faculty_id", true));
            this.prof_faculty_idTextBox.Location = new System.Drawing.Point(138, 509);
            this.prof_faculty_idTextBox.Name = "prof_faculty_idTextBox";
            this.prof_faculty_idTextBox.Size = new System.Drawing.Size(100, 20);
            this.prof_faculty_idTextBox.TabIndex = 11;
            // 
            // professionBindingSource
            // 
            this.professionBindingSource.DataMember = "profession";
            this.professionBindingSource.DataSource = this.databaseDataSet;
            // 
            // databaseDataSet
            // 
            this.databaseDataSet.DataSetName = "databaseDataSet";
            this.databaseDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // prof_imagePictureBox
            // 
            this.prof_imagePictureBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.prof_imagePictureBox.ContextMenuStrip = this.contextMenuStrip1;
            this.prof_imagePictureBox.DataBindings.Add(new System.Windows.Forms.Binding("Image", this.professionBindingSource, "prof_image", true));
            this.prof_imagePictureBox.Location = new System.Drawing.Point(138, 400);
            this.prof_imagePictureBox.Name = "prof_imagePictureBox";
            this.prof_imagePictureBox.Size = new System.Drawing.Size(100, 88);
            this.prof_imagePictureBox.TabIndex = 9;
            this.prof_imagePictureBox.TabStop = false;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem1,
            this.toolStripMenuItem2,
            this.toolStripMenuItem3});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(191, 70);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(190, 22);
            this.toolStripMenuItem1.Text = "Загрузить из файла...";
            this.toolStripMenuItem1.Click += new System.EventHandler(this.toolStripMenuItem1_Click);
            // 
            // toolStripMenuItem2
            // 
            this.toolStripMenuItem2.Name = "toolStripMenuItem2";
            this.toolStripMenuItem2.Size = new System.Drawing.Size(190, 22);
            this.toolStripMenuItem2.Text = "Выгрузить в файл...";
            this.toolStripMenuItem2.Click += new System.EventHandler(this.toolStripMenuItem2_Click);
            // 
            // toolStripMenuItem3
            // 
            this.toolStripMenuItem3.Name = "toolStripMenuItem3";
            this.toolStripMenuItem3.Size = new System.Drawing.Size(190, 22);
            this.toolStripMenuItem3.Text = "Свойства";
            // 
            // prof_descTextBox
            // 
            this.prof_descTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.professionBindingSource, "prof_desc", true));
            this.prof_descTextBox.Location = new System.Drawing.Point(138, 352);
            this.prof_descTextBox.Multiline = true;
            this.prof_descTextBox.Name = "prof_descTextBox";
            this.prof_descTextBox.Size = new System.Drawing.Size(216, 42);
            this.prof_descTextBox.TabIndex = 7;
            // 
            // prof_nameTextBox
            // 
            this.prof_nameTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.professionBindingSource, "prof_name", true));
            this.prof_nameTextBox.Location = new System.Drawing.Point(138, 307);
            this.prof_nameTextBox.Name = "prof_nameTextBox";
            this.prof_nameTextBox.Size = new System.Drawing.Size(216, 20);
            this.prof_nameTextBox.TabIndex = 5;
            // 
            // prof_idTextBox
            // 
            this.prof_idTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.professionBindingSource, "prof_id", true));
            this.prof_idTextBox.Location = new System.Drawing.Point(138, 274);
            this.prof_idTextBox.Name = "prof_idTextBox";
            this.prof_idTextBox.Size = new System.Drawing.Size(100, 20);
            this.prof_idTextBox.TabIndex = 3;
            // 
            // bindingNavigator1
            // 
            this.bindingNavigator1.AddNewItem = this.bindingNavigatorAddNewItem1;
            this.bindingNavigator1.BindingSource = this.professionBindingSource;
            this.bindingNavigator1.CountItem = this.bindingNavigatorCountItem1;
            this.bindingNavigator1.DeleteItem = this.bindingNavigatorDeleteItem1;
            this.bindingNavigator1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorMoveFirstItem1,
            this.bindingNavigatorMovePreviousItem1,
            this.bindingNavigatorSeparator3,
            this.bindingNavigatorPositionItem1,
            this.bindingNavigatorCountItem1,
            this.bindingNavigatorSeparator4,
            this.bindingNavigatorMoveNextItem1,
            this.bindingNavigatorMoveLastItem1,
            this.bindingNavigatorSeparator5,
            this.bindingNavigatorAddNewItem1,
            this.bindingNavigatorDeleteItem1,
            this.toolStripButton1});
            this.bindingNavigator1.Location = new System.Drawing.Point(3, 223);
            this.bindingNavigator1.MoveFirstItem = this.bindingNavigatorMoveFirstItem1;
            this.bindingNavigator1.MoveLastItem = this.bindingNavigatorMoveLastItem1;
            this.bindingNavigator1.MoveNextItem = this.bindingNavigatorMoveNextItem1;
            this.bindingNavigator1.MovePreviousItem = this.bindingNavigatorMovePreviousItem1;
            this.bindingNavigator1.Name = "bindingNavigator1";
            this.bindingNavigator1.PositionItem = this.bindingNavigatorPositionItem1;
            this.bindingNavigator1.Size = new System.Drawing.Size(875, 25);
            this.bindingNavigator1.TabIndex = 1;
            this.bindingNavigator1.Text = "bindingNavigator1";
            // 
            // bindingNavigatorAddNewItem1
            // 
            this.bindingNavigatorAddNewItem1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorAddNewItem1.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorAddNewItem1.Image")));
            this.bindingNavigatorAddNewItem1.Name = "bindingNavigatorAddNewItem1";
            this.bindingNavigatorAddNewItem1.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorAddNewItem1.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorAddNewItem1.Text = "Добавить";
            // 
            // bindingNavigatorCountItem1
            // 
            this.bindingNavigatorCountItem1.Name = "bindingNavigatorCountItem1";
            this.bindingNavigatorCountItem1.Size = new System.Drawing.Size(43, 22);
            this.bindingNavigatorCountItem1.Text = "для {0}";
            this.bindingNavigatorCountItem1.ToolTipText = "Общее число элементов";
            // 
            // bindingNavigatorDeleteItem1
            // 
            this.bindingNavigatorDeleteItem1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorDeleteItem1.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem1.Image")));
            this.bindingNavigatorDeleteItem1.Name = "bindingNavigatorDeleteItem1";
            this.bindingNavigatorDeleteItem1.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorDeleteItem1.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorDeleteItem1.Text = "Удалить";
            // 
            // bindingNavigatorMoveFirstItem1
            // 
            this.bindingNavigatorMoveFirstItem1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem1.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem1.Image")));
            this.bindingNavigatorMoveFirstItem1.Name = "bindingNavigatorMoveFirstItem1";
            this.bindingNavigatorMoveFirstItem1.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem1.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveFirstItem1.Text = "Переместить в начало";
            // 
            // bindingNavigatorMovePreviousItem1
            // 
            this.bindingNavigatorMovePreviousItem1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem1.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem1.Image")));
            this.bindingNavigatorMovePreviousItem1.Name = "bindingNavigatorMovePreviousItem1";
            this.bindingNavigatorMovePreviousItem1.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem1.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMovePreviousItem1.Text = "Переместить назад";
            // 
            // bindingNavigatorSeparator3
            // 
            this.bindingNavigatorSeparator3.Name = "bindingNavigatorSeparator3";
            this.bindingNavigatorSeparator3.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorPositionItem1
            // 
            this.bindingNavigatorPositionItem1.AccessibleName = "Положение";
            this.bindingNavigatorPositionItem1.AutoSize = false;
            this.bindingNavigatorPositionItem1.Name = "bindingNavigatorPositionItem1";
            this.bindingNavigatorPositionItem1.Size = new System.Drawing.Size(50, 23);
            this.bindingNavigatorPositionItem1.Text = "0";
            this.bindingNavigatorPositionItem1.ToolTipText = "Текущее положение";
            // 
            // bindingNavigatorSeparator4
            // 
            this.bindingNavigatorSeparator4.Name = "bindingNavigatorSeparator4";
            this.bindingNavigatorSeparator4.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorMoveNextItem1
            // 
            this.bindingNavigatorMoveNextItem1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem1.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem1.Image")));
            this.bindingNavigatorMoveNextItem1.Name = "bindingNavigatorMoveNextItem1";
            this.bindingNavigatorMoveNextItem1.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem1.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveNextItem1.Text = "Переместить вперед";
            // 
            // bindingNavigatorMoveLastItem1
            // 
            this.bindingNavigatorMoveLastItem1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem1.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem1.Image")));
            this.bindingNavigatorMoveLastItem1.Name = "bindingNavigatorMoveLastItem1";
            this.bindingNavigatorMoveLastItem1.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem1.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveLastItem1.Text = "Переместить в конец";
            // 
            // bindingNavigatorSeparator5
            // 
            this.bindingNavigatorSeparator5.Name = "bindingNavigatorSeparator5";
            this.bindingNavigatorSeparator5.Size = new System.Drawing.Size(6, 25);
            // 
            // toolStripButton1
            // 
            this.toolStripButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton1.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton1.Image")));
            this.toolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton1.Name = "toolStripButton1";
            this.toolStripButton1.Size = new System.Drawing.Size(23, 22);
            this.toolStripButton1.Text = "toolStripButton1";
            this.toolStripButton1.Click += new System.EventHandler(this.toolStripButton1_Click);
            // 
            // professionDataGridView
            // 
            this.professionDataGridView.AllowUserToAddRows = false;
            this.professionDataGridView.AllowUserToDeleteRows = false;
            this.professionDataGridView.AutoGenerateColumns = false;
            this.professionDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.professionDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn6,
            this.dataGridViewImageColumn1,
            this.dataGridViewTextBoxColumn7,
            this.prof_faculty_id});
            this.professionDataGridView.DataSource = this.professionBindingSource;
            this.professionDataGridView.Dock = System.Windows.Forms.DockStyle.Top;
            this.professionDataGridView.Location = new System.Drawing.Point(3, 3);
            this.professionDataGridView.Name = "professionDataGridView";
            this.professionDataGridView.Size = new System.Drawing.Size(875, 220);
            this.professionDataGridView.TabIndex = 0;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.facultyDataGridView);
            this.tabPage2.Controls.Add(this.facultyBindingNavigator);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(881, 575);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Факультеты";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // facultyDataGridView
            // 
            this.facultyDataGridView.AutoGenerateColumns = false;
            this.facultyDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.facultyDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3});
            this.facultyDataGridView.DataSource = this.facultyBindingSource;
            this.facultyDataGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.facultyDataGridView.Location = new System.Drawing.Point(3, 28);
            this.facultyDataGridView.Name = "facultyDataGridView";
            this.facultyDataGridView.Size = new System.Drawing.Size(875, 544);
            this.facultyDataGridView.TabIndex = 3;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "faculty_id";
            this.dataGridViewTextBoxColumn1.HeaderText = "Код";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "faculty_name";
            this.dataGridViewTextBoxColumn2.HeaderText = "Наименование";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.Width = 200;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "faculty_desc";
            this.dataGridViewTextBoxColumn3.HeaderText = "Описание";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.Width = 400;
            // 
            // facultyBindingSource
            // 
            this.facultyBindingSource.DataMember = "faculty";
            this.facultyBindingSource.DataSource = this.databaseDataSet;
            // 
            // facultyBindingNavigator
            // 
            this.facultyBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.facultyBindingNavigator.BindingSource = this.facultyBindingSource;
            this.facultyBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.facultyBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.facultyBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorMoveFirstItem,
            this.bindingNavigatorMovePreviousItem,
            this.bindingNavigatorSeparator,
            this.bindingNavigatorPositionItem,
            this.bindingNavigatorCountItem,
            this.bindingNavigatorSeparator1,
            this.bindingNavigatorMoveNextItem,
            this.bindingNavigatorMoveLastItem,
            this.bindingNavigatorSeparator2,
            this.bindingNavigatorAddNewItem,
            this.bindingNavigatorDeleteItem,
            this.facultyBindingNavigatorSaveItem});
            this.facultyBindingNavigator.Location = new System.Drawing.Point(3, 3);
            this.facultyBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.facultyBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.facultyBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.facultyBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.facultyBindingNavigator.Name = "facultyBindingNavigator";
            this.facultyBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.facultyBindingNavigator.Size = new System.Drawing.Size(875, 25);
            this.facultyBindingNavigator.TabIndex = 2;
            this.facultyBindingNavigator.Text = "bindingNavigator1";
            // 
            // bindingNavigatorAddNewItem
            // 
            this.bindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorAddNewItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorAddNewItem.Image")));
            this.bindingNavigatorAddNewItem.Name = "bindingNavigatorAddNewItem";
            this.bindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorAddNewItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorAddNewItem.Text = "Добавить";
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(43, 22);
            this.bindingNavigatorCountItem.Text = "для {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Общее число элементов";
            // 
            // bindingNavigatorDeleteItem
            // 
            this.bindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorDeleteItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem.Image")));
            this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
            this.bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorDeleteItem.Text = "Удалить";
            // 
            // bindingNavigatorMoveFirstItem
            // 
            this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem.Image")));
            this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
            this.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveFirstItem.Text = "Переместить в начало";
            // 
            // bindingNavigatorMovePreviousItem
            // 
            this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem.Image")));
            this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
            this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMovePreviousItem.Text = "Переместить назад";
            // 
            // bindingNavigatorSeparator
            // 
            this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorPositionItem
            // 
            this.bindingNavigatorPositionItem.AccessibleName = "Положение";
            this.bindingNavigatorPositionItem.AutoSize = false;
            this.bindingNavigatorPositionItem.Name = "bindingNavigatorPositionItem";
            this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(50, 23);
            this.bindingNavigatorPositionItem.Text = "0";
            this.bindingNavigatorPositionItem.ToolTipText = "Текущее положение";
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator1";
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorMoveNextItem
            // 
            this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem.Image")));
            this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
            this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveNextItem.Text = "Переместить вперед";
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveLastItem.Text = "Переместить в конец";
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator2";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // facultyBindingNavigatorSaveItem
            // 
            this.facultyBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.facultyBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("facultyBindingNavigatorSaveItem.Image")));
            this.facultyBindingNavigatorSaveItem.Name = "facultyBindingNavigatorSaveItem";
            this.facultyBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 22);
            this.facultyBindingNavigatorSaveItem.Text = "Сохранить данные";
            this.facultyBindingNavigatorSaveItem.Click += new System.EventHandler(this.facultyBindingNavigatorSaveItem_Click);
            // 
            // facultyTableAdapter
            // 
            this.facultyTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.facultyTableAdapter = this.facultyTableAdapter;
            this.tableAdapterManager.professionTableAdapter = this.professionTableAdapter;
            this.tableAdapterManager.UpdateOrder = dotNetCW2.databaseDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // professionTableAdapter
            // 
            this.professionTableAdapter.ClearBeforeFill = true;
            // 
            // openFileDlg
            // 
            this.openFileDlg.FileName = "openFileDlg";
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            this.openFileDialog1.Filter = "Jpeg files|*.jpg;*.jpeg|All files|*.*";
            // 
            // saveFileDialog1
            // 
            this.saveFileDialog1.DefaultExt = "jpeg";
            this.saveFileDialog1.Filter = "Jpeg files|*.jpg;*.jpeg|All files|*.*";
            // 
            // prof_faculty_idLabel1
            // 
            prof_faculty_idLabel1.AutoSize = true;
            prof_faculty_idLabel1.Location = new System.Drawing.Point(282, 512);
            prof_faculty_idLabel1.Name = "prof_faculty_idLabel1";
            prof_faculty_idLabel1.Size = new System.Drawing.Size(73, 13);
            prof_faculty_idLabel1.TabIndex = 12;
            prof_faculty_idLabel1.Text = "prof faculty id:";
            // 
            // prof_faculty_idComboBox
            // 
            this.prof_faculty_idComboBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.professionBindingSource, "prof_faculty_id", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.prof_faculty_idComboBox.DataSource = this.facultyBindingSource;
            this.prof_faculty_idComboBox.DisplayMember = "faculty_name";
            this.prof_faculty_idComboBox.Location = new System.Drawing.Point(361, 509);
            this.prof_faculty_idComboBox.Name = "prof_faculty_idComboBox";
            this.prof_faculty_idComboBox.Size = new System.Drawing.Size(178, 21);
            this.prof_faculty_idComboBox.TabIndex = 13;
            this.prof_faculty_idComboBox.ValueMember = "faculty_id";
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "prof_id";
            this.dataGridViewTextBoxColumn4.HeaderText = "prof_id";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "prof_name";
            this.dataGridViewTextBoxColumn5.HeaderText = "prof_name";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.DataPropertyName = "prof_desc";
            this.dataGridViewTextBoxColumn6.HeaderText = "prof_desc";
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            // 
            // dataGridViewImageColumn1
            // 
            this.dataGridViewImageColumn1.DataPropertyName = "prof_image";
            this.dataGridViewImageColumn1.HeaderText = "prof_image";
            this.dataGridViewImageColumn1.Name = "dataGridViewImageColumn1";
            // 
            // dataGridViewTextBoxColumn7
            // 
            this.dataGridViewTextBoxColumn7.DataPropertyName = "prof_faculty_id";
            this.dataGridViewTextBoxColumn7.HeaderText = "prof_faculty_id";
            this.dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            // 
            // prof_faculty_id
            // 
            this.prof_faculty_id.DataPropertyName = "prof_faculty_id";
            this.prof_faculty_id.DataSource = this.facultyBindingSource;
            this.prof_faculty_id.DisplayMember = "faculty_name";
            this.prof_faculty_id.DisplayStyle = System.Windows.Forms.DataGridViewComboBoxDisplayStyle.ComboBox;
            this.prof_faculty_id.HeaderText = "prof_faculty_id";
            this.prof_faculty_id.Name = "prof_faculty_id";
            this.prof_faculty_id.ValueMember = "faculty_id";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(889, 601);
            this.Controls.Add(this.tabControl1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.professionBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.databaseDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.prof_imagePictureBox)).EndInit();
            this.contextMenuStrip1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.bindingNavigator1)).EndInit();
            this.bindingNavigator1.ResumeLayout(false);
            this.bindingNavigator1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.professionDataGridView)).EndInit();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.facultyDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.facultyBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.facultyBindingNavigator)).EndInit();
            this.facultyBindingNavigator.ResumeLayout(false);
            this.facultyBindingNavigator.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private databaseDataSet databaseDataSet;
        private System.Windows.Forms.BindingSource facultyBindingSource;
        private databaseDataSetTableAdapters.facultyTableAdapter facultyTableAdapter;
        private databaseDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.DataGridView facultyDataGridView;
        private System.Windows.Forms.BindingNavigator facultyBindingNavigator;
        private System.Windows.Forms.ToolStripButton bindingNavigatorAddNewItem;
        private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorDeleteItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveFirstItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator;
        private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveLastItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator2;
        private System.Windows.Forms.ToolStripButton facultyBindingNavigatorSaveItem;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private databaseDataSetTableAdapters.professionTableAdapter professionTableAdapter;
        private System.Windows.Forms.BindingSource professionBindingSource;
        private System.Windows.Forms.TextBox prof_faculty_idTextBox;
        private System.Windows.Forms.PictureBox prof_imagePictureBox;
        private System.Windows.Forms.TextBox prof_descTextBox;
        private System.Windows.Forms.TextBox prof_nameTextBox;
        private System.Windows.Forms.TextBox prof_idTextBox;
        private System.Windows.Forms.BindingNavigator bindingNavigator1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorAddNewItem1;
        private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorDeleteItem1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveFirstItem1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem1;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator3;
        private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem1;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator4;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveLastItem1;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator5;
        private System.Windows.Forms.DataGridView professionDataGridView;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem3;
        private System.Windows.Forms.OpenFileDialog openFileDlg;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.ToolStripButton toolStripButton1;
        private System.Windows.Forms.ComboBox prof_faculty_idComboBox;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.DataGridViewImageColumn dataGridViewImageColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
        private System.Windows.Forms.DataGridViewComboBoxColumn prof_faculty_id;
    }
}

