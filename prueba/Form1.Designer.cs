namespace prueba
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.Sbar = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.BtnMinimize = new System.Windows.Forms.Button();
            this.Btnmaximized = new System.Windows.Forms.Button();
            this.BtnClose = new System.Windows.Forms.Button();
            this.panelogo = new System.Windows.Forms.Panel();
            this.SlideBar = new System.Windows.Forms.Panel();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.Edit = new System.Windows.Forms.Button();
            this.BtnArchive = new System.Windows.Forms.Button();
            this.PBAsubmenu = new System.Windows.Forms.Panel();
            this.BtnExit = new System.Windows.Forms.Button();
            this.BtnSaveas = new System.Windows.Forms.Button();
            this.BtnSave = new System.Windows.Forms.Button();
            this.BtnOpen = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.gradientPanel1 = new prueba.GradientPanel();
            this.gradientPanel4 = new prueba.GradientPanel();
            this.ViewRes = new System.Windows.Forms.DataGridView();
            this.Btnresults = new prueba.RJbutton();
            this.BtnError = new prueba.RJbutton();
            this.gradientPanel3 = new prueba.GradientPanel();
            this.viewsourcecompile = new System.Windows.Forms.DataGridView();
            this.BtnSource = new prueba.RJbutton();
            this.Btnsemantic = new prueba.RJbutton();
            this.Btnsyntactic = new prueba.RJbutton();
            this.Btnlexic = new prueba.RJbutton();
            this.gradientPanel2 = new prueba.GradientPanel();
            this.Textascompile = new System.Windows.Forms.RichTextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.Sbar.SuspendLayout();
            this.SlideBar.SuspendLayout();
            this.PBAsubmenu.SuspendLayout();
            this.gradientPanel1.SuspendLayout();
            this.gradientPanel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ViewRes)).BeginInit();
            this.gradientPanel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.viewsourcecompile)).BeginInit();
            this.gradientPanel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // Sbar
            // 
            this.Sbar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(49)))), ((int)(((byte)(55)))));
            this.Sbar.Controls.Add(this.label3);
            this.Sbar.Controls.Add(this.BtnMinimize);
            this.Sbar.Controls.Add(this.Btnmaximized);
            this.Sbar.Controls.Add(this.BtnClose);
            this.Sbar.Controls.Add(this.panelogo);
            this.Sbar.Dock = System.Windows.Forms.DockStyle.Top;
            this.Sbar.Location = new System.Drawing.Point(0, 0);
            this.Sbar.Name = "Sbar";
            this.Sbar.Size = new System.Drawing.Size(1154, 30);
            this.Sbar.TabIndex = 0;
            this.Sbar.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Sbar_MouseDown);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(47, 7);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(122, 19);
            this.label3.TabIndex = 4;
            this.label3.Text = "Compilador R++";
            // 
            // BtnMinimize
            // 
            this.BtnMinimize.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnMinimize.FlatAppearance.BorderSize = 0;
            this.BtnMinimize.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnMinimize.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.BtnMinimize.ForeColor = System.Drawing.Color.White;
            this.BtnMinimize.Location = new System.Drawing.Point(1064, 3);
            this.BtnMinimize.Name = "BtnMinimize";
            this.BtnMinimize.Size = new System.Drawing.Size(25, 25);
            this.BtnMinimize.TabIndex = 3;
            this.BtnMinimize.Text = "-";
            this.BtnMinimize.UseVisualStyleBackColor = true;
            this.BtnMinimize.Click += new System.EventHandler(this.BtnMinimize_Click);
            // 
            // Btnmaximized
            // 
            this.Btnmaximized.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Btnmaximized.FlatAppearance.BorderSize = 0;
            this.Btnmaximized.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btnmaximized.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Btnmaximized.ForeColor = System.Drawing.Color.White;
            this.Btnmaximized.Location = new System.Drawing.Point(1095, 3);
            this.Btnmaximized.Name = "Btnmaximized";
            this.Btnmaximized.Size = new System.Drawing.Size(25, 25);
            this.Btnmaximized.TabIndex = 2;
            this.Btnmaximized.Text = "O";
            this.Btnmaximized.UseVisualStyleBackColor = true;
            this.Btnmaximized.Click += new System.EventHandler(this.Btnmaximized_Click);
            // 
            // BtnClose
            // 
            this.BtnClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnClose.FlatAppearance.BorderSize = 0;
            this.BtnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnClose.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.BtnClose.ForeColor = System.Drawing.Color.White;
            this.BtnClose.Location = new System.Drawing.Point(1126, 3);
            this.BtnClose.Name = "BtnClose";
            this.BtnClose.Size = new System.Drawing.Size(25, 25);
            this.BtnClose.TabIndex = 1;
            this.BtnClose.Text = "X";
            this.BtnClose.UseVisualStyleBackColor = true;
            this.BtnClose.Click += new System.EventHandler(this.BtnClose_Click);
            // 
            // panelogo
            // 
            this.panelogo.BackColor = System.Drawing.Color.Transparent;
            this.panelogo.BackgroundImage = global::prueba.Properties.Resources.Rlogo;
            this.panelogo.ForeColor = System.Drawing.Color.White;
            this.panelogo.Location = new System.Drawing.Point(15, 2);
            this.panelogo.Margin = new System.Windows.Forms.Padding(0);
            this.panelogo.Name = "panelogo";
            this.panelogo.Size = new System.Drawing.Size(25, 25);
            this.panelogo.TabIndex = 0;
            this.panelogo.Paint += new System.Windows.Forms.PaintEventHandler(this.panelogo_Paint);
            // 
            // SlideBar
            // 
            this.SlideBar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(49)))), ((int)(((byte)(55)))));
            this.SlideBar.Controls.Add(this.button3);
            this.SlideBar.Controls.Add(this.button2);
            this.SlideBar.Controls.Add(this.button1);
            this.SlideBar.Controls.Add(this.Edit);
            this.SlideBar.Controls.Add(this.BtnArchive);
            this.SlideBar.Dock = System.Windows.Forms.DockStyle.Top;
            this.SlideBar.Location = new System.Drawing.Point(0, 30);
            this.SlideBar.Name = "SlideBar";
            this.SlideBar.Size = new System.Drawing.Size(1154, 40);
            this.SlideBar.TabIndex = 1;
            // 
            // button3
            // 
            this.button3.FlatAppearance.BorderSize = 0;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.ForeColor = System.Drawing.Color.White;
            this.button3.Image = global::prueba.Properties.Resources.help;
            this.button3.Location = new System.Drawing.Point(360, 5);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(80, 30);
            this.button3.TabIndex = 6;
            this.button3.Text = "Ayuda";
            this.button3.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.button3.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.FlatAppearance.BorderSize = 0;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.ForeColor = System.Drawing.Color.White;
            this.button2.Image = global::prueba.Properties.Resources.play;
            this.button2.Location = new System.Drawing.Point(270, 5);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(80, 30);
            this.button2.TabIndex = 5;
            this.button2.Text = "Compilar";
            this.button2.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.button2.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Image = global::prueba.Properties.Resources.info;
            this.button1.Location = new System.Drawing.Point(180, 5);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(80, 30);
            this.button1.TabIndex = 4;
            this.button1.Text = "Formato";
            this.button1.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.button1.UseVisualStyleBackColor = true;
            // 
            // Edit
            // 
            this.Edit.FlatAppearance.BorderSize = 0;
            this.Edit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Edit.ForeColor = System.Drawing.Color.White;
            this.Edit.Image = global::prueba.Properties.Resources.edit1;
            this.Edit.Location = new System.Drawing.Point(90, 5);
            this.Edit.Name = "Edit";
            this.Edit.Size = new System.Drawing.Size(80, 30);
            this.Edit.TabIndex = 3;
            this.Edit.Text = "Editar";
            this.Edit.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.Edit.UseVisualStyleBackColor = true;
            // 
            // BtnArchive
            // 
            this.BtnArchive.FlatAppearance.BorderSize = 0;
            this.BtnArchive.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnArchive.ForeColor = System.Drawing.Color.White;
            this.BtnArchive.Image = global::prueba.Properties.Resources.folder;
            this.BtnArchive.Location = new System.Drawing.Point(10, 5);
            this.BtnArchive.Name = "BtnArchive";
            this.BtnArchive.Size = new System.Drawing.Size(80, 30);
            this.BtnArchive.TabIndex = 0;
            this.BtnArchive.Text = "Archivo";
            this.BtnArchive.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.BtnArchive.UseVisualStyleBackColor = true;
            this.BtnArchive.Click += new System.EventHandler(this.BtnArchive_Click);
            // 
            // PBAsubmenu
            // 
            this.PBAsubmenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(49)))), ((int)(((byte)(55)))));
            this.PBAsubmenu.Controls.Add(this.BtnExit);
            this.PBAsubmenu.Controls.Add(this.BtnSaveas);
            this.PBAsubmenu.Controls.Add(this.BtnSave);
            this.PBAsubmenu.Controls.Add(this.BtnOpen);
            this.PBAsubmenu.Controls.Add(this.label1);
            this.PBAsubmenu.Location = new System.Drawing.Point(15, 0);
            this.PBAsubmenu.Name = "PBAsubmenu";
            this.PBAsubmenu.Size = new System.Drawing.Size(182, 108);
            this.PBAsubmenu.TabIndex = 0;
            // 
            // BtnExit
            // 
            this.BtnExit.Dock = System.Windows.Forms.DockStyle.Top;
            this.BtnExit.FlatAppearance.BorderSize = 0;
            this.BtnExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnExit.ForeColor = System.Drawing.Color.LightGray;
            this.BtnExit.Location = new System.Drawing.Point(0, 75);
            this.BtnExit.Name = "BtnExit";
            this.BtnExit.Padding = new System.Windows.Forms.Padding(25, 0, 0, 0);
            this.BtnExit.Size = new System.Drawing.Size(182, 25);
            this.BtnExit.TabIndex = 3;
            this.BtnExit.Text = "Salir";
            this.BtnExit.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnExit.UseVisualStyleBackColor = true;
            this.BtnExit.Click += new System.EventHandler(this.BtnExit_Click);
            // 
            // BtnSaveas
            // 
            this.BtnSaveas.Dock = System.Windows.Forms.DockStyle.Top;
            this.BtnSaveas.FlatAppearance.BorderSize = 0;
            this.BtnSaveas.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnSaveas.ForeColor = System.Drawing.Color.LightGray;
            this.BtnSaveas.Location = new System.Drawing.Point(0, 50);
            this.BtnSaveas.Name = "BtnSaveas";
            this.BtnSaveas.Padding = new System.Windows.Forms.Padding(25, 0, 0, 0);
            this.BtnSaveas.Size = new System.Drawing.Size(182, 25);
            this.BtnSaveas.TabIndex = 2;
            this.BtnSaveas.Text = "Guardar como...";
            this.BtnSaveas.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnSaveas.UseVisualStyleBackColor = true;
            // 
            // BtnSave
            // 
            this.BtnSave.Dock = System.Windows.Forms.DockStyle.Top;
            this.BtnSave.FlatAppearance.BorderSize = 0;
            this.BtnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnSave.ForeColor = System.Drawing.Color.LightGray;
            this.BtnSave.Location = new System.Drawing.Point(0, 25);
            this.BtnSave.Name = "BtnSave";
            this.BtnSave.Padding = new System.Windows.Forms.Padding(25, 0, 0, 0);
            this.BtnSave.Size = new System.Drawing.Size(182, 25);
            this.BtnSave.TabIndex = 1;
            this.BtnSave.Text = "Guardar...";
            this.BtnSave.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnSave.UseVisualStyleBackColor = true;
            this.BtnSave.Click += new System.EventHandler(this.BtnSave_Click);
            // 
            // BtnOpen
            // 
            this.BtnOpen.Dock = System.Windows.Forms.DockStyle.Top;
            this.BtnOpen.FlatAppearance.BorderSize = 0;
            this.BtnOpen.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnOpen.ForeColor = System.Drawing.Color.LightGray;
            this.BtnOpen.Location = new System.Drawing.Point(0, 0);
            this.BtnOpen.Name = "BtnOpen";
            this.BtnOpen.Padding = new System.Windows.Forms.Padding(25, 0, 0, 0);
            this.BtnOpen.Size = new System.Drawing.Size(182, 25);
            this.BtnOpen.TabIndex = 0;
            this.BtnOpen.Text = "Abrir";
            this.BtnOpen.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnOpen.UseVisualStyleBackColor = true;
            this.BtnOpen.Click += new System.EventHandler(this.BtnOpen_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft JhengHei UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.ImageAlign = System.Drawing.ContentAlignment.BottomLeft;
            this.label1.Location = new System.Drawing.Point(6, 66);
            this.label1.Name = "label1";
            this.label1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label1.Size = new System.Drawing.Size(139, 18);
            this.label1.TabIndex = 0;
            this.label1.Text = "Codigo a Compilar:";
            this.label1.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            // 
            // gradientPanel1
            // 
            this.gradientPanel1.Angle = 90F;
            this.gradientPanel1.AutoScroll = true;
            this.gradientPanel1.BottomColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(57)))), ((int)(((byte)(63)))));
            this.gradientPanel1.Controls.Add(this.gradientPanel4);
            this.gradientPanel1.Controls.Add(this.PBAsubmenu);
            this.gradientPanel1.Controls.Add(this.gradientPanel3);
            this.gradientPanel1.Controls.Add(this.gradientPanel2);
            this.gradientPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gradientPanel1.Location = new System.Drawing.Point(0, 70);
            this.gradientPanel1.MinimumSize = new System.Drawing.Size(1100, 560);
            this.gradientPanel1.Name = "gradientPanel1";
            this.gradientPanel1.Size = new System.Drawing.Size(1154, 562);
            this.gradientPanel1.TabIndex = 2;
            this.gradientPanel1.TopColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(64)))), ((int)(((byte)(70)))));
            // 
            // gradientPanel4
            // 
            this.gradientPanel4.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gradientPanel4.Angle = 135F;
            this.gradientPanel4.BottomColor = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(92)))), ((int)(((byte)(102)))));
            this.gradientPanel4.Controls.Add(this.ViewRes);
            this.gradientPanel4.Controls.Add(this.Btnresults);
            this.gradientPanel4.Controls.Add(this.BtnError);
            this.gradientPanel4.Location = new System.Drawing.Point(15, 337);
            this.gradientPanel4.Name = "gradientPanel4";
            this.gradientPanel4.Size = new System.Drawing.Size(1113, 200);
            this.gradientPanel4.TabIndex = 5;
            this.gradientPanel4.TopColor = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(92)))), ((int)(((byte)(102)))));
            // 
            // ViewRes
            // 
            this.ViewRes.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ViewRes.BackgroundColor = System.Drawing.Color.White;
            this.ViewRes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ViewRes.Location = new System.Drawing.Point(10, 41);
            this.ViewRes.Name = "ViewRes";
            this.ViewRes.RowTemplate.Height = 25;
            this.ViewRes.Size = new System.Drawing.Size(1093, 142);
            this.ViewRes.TabIndex = 4;
            // 
            // Btnresults
            // 
            this.Btnresults.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(9)))), ((int)(((byte)(197)))), ((int)(((byte)(116)))));
            this.Btnresults.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(9)))), ((int)(((byte)(197)))), ((int)(((byte)(116)))));
            this.Btnresults.BorderColor = System.Drawing.Color.MidnightBlue;
            this.Btnresults.BorderRadius = 5;
            this.Btnresults.BorderSize = 0;
            this.Btnresults.FlatAppearance.BorderSize = 0;
            this.Btnresults.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btnresults.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Btnresults.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(72)))), ((int)(((byte)(74)))));
            this.Btnresults.Location = new System.Drawing.Point(106, 5);
            this.Btnresults.Name = "Btnresults";
            this.Btnresults.Size = new System.Drawing.Size(115, 30);
            this.Btnresults.TabIndex = 1;
            this.Btnresults.Text = "Resultados";
            this.Btnresults.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(72)))), ((int)(((byte)(74)))));
            this.Btnresults.UseVisualStyleBackColor = false;
            // 
            // BtnError
            // 
            this.BtnError.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(9)))), ((int)(((byte)(197)))), ((int)(((byte)(116)))));
            this.BtnError.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(9)))), ((int)(((byte)(197)))), ((int)(((byte)(116)))));
            this.BtnError.BorderColor = System.Drawing.Color.MidnightBlue;
            this.BtnError.BorderRadius = 5;
            this.BtnError.BorderSize = 0;
            this.BtnError.FlatAppearance.BorderSize = 0;
            this.BtnError.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnError.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.BtnError.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(72)))), ((int)(((byte)(74)))));
            this.BtnError.Location = new System.Drawing.Point(10, 5);
            this.BtnError.Name = "BtnError";
            this.BtnError.Size = new System.Drawing.Size(90, 30);
            this.BtnError.TabIndex = 0;
            this.BtnError.Text = "Errores";
            this.BtnError.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(72)))), ((int)(((byte)(74)))));
            this.BtnError.UseVisualStyleBackColor = false;
            // 
            // gradientPanel3
            // 
            this.gradientPanel3.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gradientPanel3.Angle = 135F;
            this.gradientPanel3.BottomColor = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(92)))), ((int)(((byte)(102)))));
            this.gradientPanel3.Controls.Add(this.viewsourcecompile);
            this.gradientPanel3.Controls.Add(this.BtnSource);
            this.gradientPanel3.Controls.Add(this.Btnsemantic);
            this.gradientPanel3.Controls.Add(this.Btnsyntactic);
            this.gradientPanel3.Controls.Add(this.Btnlexic);
            this.gradientPanel3.Location = new System.Drawing.Point(584, 15);
            this.gradientPanel3.Name = "gradientPanel3";
            this.gradientPanel3.Size = new System.Drawing.Size(544, 288);
            this.gradientPanel3.TabIndex = 2;
            this.gradientPanel3.TopColor = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(92)))), ((int)(((byte)(102)))));
            // 
            // viewsourcecompile
            // 
            this.viewsourcecompile.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.viewsourcecompile.BackgroundColor = System.Drawing.Color.White;
            this.viewsourcecompile.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.viewsourcecompile.Location = new System.Drawing.Point(10, 50);
            this.viewsourcecompile.Name = "viewsourcecompile";
            this.viewsourcecompile.RowTemplate.Height = 25;
            this.viewsourcecompile.Size = new System.Drawing.Size(524, 228);
            this.viewsourcecompile.TabIndex = 4;
            // 
            // BtnSource
            // 
            this.BtnSource.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(9)))), ((int)(((byte)(197)))), ((int)(((byte)(116)))));
            this.BtnSource.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(9)))), ((int)(((byte)(197)))), ((int)(((byte)(116)))));
            this.BtnSource.BorderColor = System.Drawing.Color.MidnightBlue;
            this.BtnSource.BorderRadius = 5;
            this.BtnSource.BorderSize = 0;
            this.BtnSource.FlatAppearance.BorderSize = 0;
            this.BtnSource.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnSource.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.BtnSource.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(72)))), ((int)(((byte)(74)))));
            this.BtnSource.Location = new System.Drawing.Point(353, 5);
            this.BtnSource.Name = "BtnSource";
            this.BtnSource.Size = new System.Drawing.Size(181, 30);
            this.BtnSource.TabIndex = 3;
            this.BtnSource.Text = "Codigo Intermedio";
            this.BtnSource.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(72)))), ((int)(((byte)(74)))));
            this.BtnSource.UseVisualStyleBackColor = false;
            // 
            // Btnsemantic
            // 
            this.Btnsemantic.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(9)))), ((int)(((byte)(197)))), ((int)(((byte)(116)))));
            this.Btnsemantic.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(9)))), ((int)(((byte)(197)))), ((int)(((byte)(116)))));
            this.Btnsemantic.BorderColor = System.Drawing.Color.MidnightBlue;
            this.Btnsemantic.BorderRadius = 5;
            this.Btnsemantic.BorderSize = 0;
            this.Btnsemantic.FlatAppearance.BorderSize = 0;
            this.Btnsemantic.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btnsemantic.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Btnsemantic.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(72)))), ((int)(((byte)(74)))));
            this.Btnsemantic.Location = new System.Drawing.Point(238, 5);
            this.Btnsemantic.Name = "Btnsemantic";
            this.Btnsemantic.Size = new System.Drawing.Size(109, 30);
            this.Btnsemantic.TabIndex = 2;
            this.Btnsemantic.Text = "Semantico";
            this.Btnsemantic.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(72)))), ((int)(((byte)(74)))));
            this.Btnsemantic.UseVisualStyleBackColor = false;
            // 
            // Btnsyntactic
            // 
            this.Btnsyntactic.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(9)))), ((int)(((byte)(197)))), ((int)(((byte)(116)))));
            this.Btnsyntactic.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(9)))), ((int)(((byte)(197)))), ((int)(((byte)(116)))));
            this.Btnsyntactic.BorderColor = System.Drawing.Color.MidnightBlue;
            this.Btnsyntactic.BorderRadius = 5;
            this.Btnsyntactic.BorderSize = 0;
            this.Btnsyntactic.FlatAppearance.BorderSize = 0;
            this.Btnsyntactic.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btnsyntactic.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Btnsyntactic.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(72)))), ((int)(((byte)(74)))));
            this.Btnsyntactic.Location = new System.Drawing.Point(117, 5);
            this.Btnsyntactic.Name = "Btnsyntactic";
            this.Btnsyntactic.Size = new System.Drawing.Size(115, 30);
            this.Btnsyntactic.TabIndex = 1;
            this.Btnsyntactic.Text = "Sintactico";
            this.Btnsyntactic.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(72)))), ((int)(((byte)(74)))));
            this.Btnsyntactic.UseVisualStyleBackColor = false;
            // 
            // Btnlexic
            // 
            this.Btnlexic.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(9)))), ((int)(((byte)(197)))), ((int)(((byte)(116)))));
            this.Btnlexic.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(9)))), ((int)(((byte)(197)))), ((int)(((byte)(116)))));
            this.Btnlexic.BorderColor = System.Drawing.Color.MidnightBlue;
            this.Btnlexic.BorderRadius = 5;
            this.Btnlexic.BorderSize = 0;
            this.Btnlexic.FlatAppearance.BorderSize = 0;
            this.Btnlexic.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btnlexic.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Btnlexic.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(72)))), ((int)(((byte)(74)))));
            this.Btnlexic.Location = new System.Drawing.Point(10, 5);
            this.Btnlexic.Name = "Btnlexic";
            this.Btnlexic.Size = new System.Drawing.Size(101, 30);
            this.Btnlexic.TabIndex = 0;
            this.Btnlexic.Text = "Lexico";
            this.Btnlexic.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(72)))), ((int)(((byte)(74)))));
            this.Btnlexic.UseVisualStyleBackColor = false;
            // 
            // gradientPanel2
            // 
            this.gradientPanel2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.gradientPanel2.Angle = 135F;
            this.gradientPanel2.BottomColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(101)))), ((int)(((byte)(107)))));
            this.gradientPanel2.Controls.Add(this.Textascompile);
            this.gradientPanel2.Controls.Add(this.label2);
            this.gradientPanel2.Location = new System.Drawing.Point(15, 15);
            this.gradientPanel2.Name = "gradientPanel2";
            this.gradientPanel2.Size = new System.Drawing.Size(544, 288);
            this.gradientPanel2.TabIndex = 0;
            this.gradientPanel2.TopColor = System.Drawing.Color.FromArgb(((int)(((byte)(9)))), ((int)(((byte)(197)))), ((int)(((byte)(116)))));
            // 
            // Textascompile
            // 
            this.Textascompile.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.Textascompile.BackColor = System.Drawing.Color.White;
            this.Textascompile.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Textascompile.ForeColor = System.Drawing.Color.Black;
            this.Textascompile.Location = new System.Drawing.Point(10, 50);
            this.Textascompile.Name = "Textascompile";
            this.Textascompile.Size = new System.Drawing.Size(524, 228);
            this.Textascompile.TabIndex = 1;
            this.Textascompile.Text = "";
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(0, 16);
            this.label2.Name = "label2";
            this.label2.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.label2.Size = new System.Drawing.Size(525, 25);
            this.label2.TabIndex = 0;
            this.label2.Text = "Codigo a Compilar:";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1154, 632);
            this.Controls.Add(this.gradientPanel1);
            this.Controls.Add(this.SlideBar);
            this.Controls.Add(this.Sbar);
            this.MinimumSize = new System.Drawing.Size(1170, 670);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.Sbar.ResumeLayout(false);
            this.Sbar.PerformLayout();
            this.SlideBar.ResumeLayout(false);
            this.PBAsubmenu.ResumeLayout(false);
            this.PBAsubmenu.PerformLayout();
            this.gradientPanel1.ResumeLayout(false);
            this.gradientPanel4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.ViewRes)).EndInit();
            this.gradientPanel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.viewsourcecompile)).EndInit();
            this.gradientPanel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Panel Sbar;
        private Panel panelogo;
        private Panel SlideBar;
        private Button BtnArchive;
        private Button button3;
        private Button button2;
        private Button button1;
        private Button Edit;
        private Panel PBAsubmenu;
        private Button BtnExit;
        private Button BtnSaveas;
        private Button BtnSave;
        private Button BtnOpen;
        private GradientPanel gradientPanel1;
        private Label label1;
        private GradientPanel gradientPanel2;
        private RichTextBox Textascompile;
        private Label label2;
        private GradientPanel gradientPanel3;
        private RJbutton Btnlexic;
        private RJbutton BtnSource;
        private RJbutton Btnsemantic;
        private RJbutton Btnsyntactic;
        private DataGridView viewsourcecompile;
        private GradientPanel gradientPanel4;
        private DataGridView ViewRes;
        private RJbutton Btnresults;
        private RJbutton BtnError;
        private Button BtnMinimize;
        private Button Btnmaximized;
        private Button BtnClose;
        private Label label3;
        private OpenFileDialog openFileDialog1;
        private SaveFileDialog saveFileDialog1;
    }
}