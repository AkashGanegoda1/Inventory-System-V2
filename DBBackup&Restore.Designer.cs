namespace Inventory_System
{
    partial class DBBackup_Restore
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DBBackup_Restore));
            this.guna2Elipse1 = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.cmb_databases = new Guna.UI2.WinForms.Guna2ComboBox();
            this.txt_source = new Guna.UI2.WinForms.Guna2TextBox();
            this.txt_restorepath = new Guna.UI2.WinForms.Guna2TextBox();
            this.txt_bckuppath = new Guna.UI2.WinForms.Guna2TextBox();
            this.btn_browsebckup = new Guna.UI2.WinForms.Guna2GradientButton();
            this.btn_disconnect = new Guna.UI2.WinForms.Guna2GradientButton();
            this.btn_browserestore = new Guna.UI2.WinForms.Guna2GradientButton();
            this.btn_backup = new Guna.UI2.WinForms.Guna2GradientButton();
            this.btn_restore = new Guna.UI2.WinForms.Guna2GradientButton();
            this.btn_connect = new Guna.UI2.WinForms.Guna2GradientButton();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.bunifuLabel2 = new Bunifu.UI.WinForms.BunifuLabel();
            this.bunifuLabel1 = new Bunifu.UI.WinForms.BunifuLabel();
            this.guna2ProgressIndicator1 = new Guna.UI2.WinForms.Guna2ProgressIndicator();
            this.label5 = new System.Windows.Forms.Label();
            this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.SuspendLayout();
            // 
            // guna2Elipse1
            // 
            this.guna2Elipse1.BorderRadius = 20;
            this.guna2Elipse1.TargetControl = this;
            // 
            // cmb_databases
            // 
            this.cmb_databases.BackColor = System.Drawing.Color.Transparent;
            this.cmb_databases.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cmb_databases.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb_databases.FocusedColor = System.Drawing.Color.Empty;
            this.cmb_databases.FocusedState.Parent = this.cmb_databases;
            this.cmb_databases.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cmb_databases.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.cmb_databases.FormattingEnabled = true;
            this.cmb_databases.HoverState.Parent = this.cmb_databases;
            this.cmb_databases.ItemHeight = 30;
            this.cmb_databases.ItemsAppearance.Parent = this.cmb_databases;
            this.cmb_databases.Location = new System.Drawing.Point(606, 59);
            this.cmb_databases.Name = "cmb_databases";
            this.cmb_databases.ShadowDecoration.Parent = this.cmb_databases;
            this.cmb_databases.Size = new System.Drawing.Size(254, 36);
            this.cmb_databases.TabIndex = 146;
            this.cmb_databases.SelectedIndexChanged += new System.EventHandler(this.Cmb_databases_SelectedIndexChanged);
            // 
            // txt_source
            // 
            this.txt_source.BackColor = System.Drawing.SystemColors.Control;
            this.txt_source.BorderColor = System.Drawing.Color.Silver;
            this.txt_source.BorderRadius = 5;
            this.txt_source.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_source.DefaultText = "";
            this.txt_source.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txt_source.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txt_source.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txt_source.DisabledState.Parent = this.txt_source;
            this.txt_source.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txt_source.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txt_source.FocusedState.Parent = this.txt_source;
            this.txt_source.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.txt_source.ForeColor = System.Drawing.Color.Black;
            this.txt_source.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txt_source.HoverState.Parent = this.txt_source;
            this.txt_source.Location = new System.Drawing.Point(140, 58);
            this.txt_source.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txt_source.Name = "txt_source";
            this.txt_source.PasswordChar = '\0';
            this.txt_source.PlaceholderText = "";
            this.txt_source.ReadOnly = true;
            this.txt_source.SelectedText = "";
            this.txt_source.ShadowDecoration.Parent = this.txt_source;
            this.txt_source.Size = new System.Drawing.Size(281, 37);
            this.txt_source.TabIndex = 158;
            this.txt_source.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txt_restorepath
            // 
            this.txt_restorepath.BackColor = System.Drawing.SystemColors.Control;
            this.txt_restorepath.BorderColor = System.Drawing.Color.Silver;
            this.txt_restorepath.BorderRadius = 5;
            this.txt_restorepath.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_restorepath.DefaultText = "";
            this.txt_restorepath.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txt_restorepath.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txt_restorepath.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txt_restorepath.DisabledState.Parent = this.txt_restorepath;
            this.txt_restorepath.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txt_restorepath.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txt_restorepath.FocusedState.Parent = this.txt_restorepath;
            this.txt_restorepath.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.txt_restorepath.ForeColor = System.Drawing.Color.Black;
            this.txt_restorepath.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txt_restorepath.HoverState.Parent = this.txt_restorepath;
            this.txt_restorepath.Location = new System.Drawing.Point(185, 411);
            this.txt_restorepath.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txt_restorepath.Name = "txt_restorepath";
            this.txt_restorepath.PasswordChar = '\0';
            this.txt_restorepath.PlaceholderText = "Restore Path of the Database";
            this.txt_restorepath.ReadOnly = true;
            this.txt_restorepath.SelectedText = "";
            this.txt_restorepath.ShadowDecoration.Parent = this.txt_restorepath;
            this.txt_restorepath.Size = new System.Drawing.Size(519, 37);
            this.txt_restorepath.TabIndex = 159;
            // 
            // txt_bckuppath
            // 
            this.txt_bckuppath.BackColor = System.Drawing.SystemColors.Control;
            this.txt_bckuppath.BorderColor = System.Drawing.Color.Silver;
            this.txt_bckuppath.BorderRadius = 5;
            this.txt_bckuppath.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_bckuppath.DefaultText = "";
            this.txt_bckuppath.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txt_bckuppath.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txt_bckuppath.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txt_bckuppath.DisabledState.Parent = this.txt_bckuppath;
            this.txt_bckuppath.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txt_bckuppath.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txt_bckuppath.FocusedState.Parent = this.txt_bckuppath;
            this.txt_bckuppath.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.txt_bckuppath.ForeColor = System.Drawing.Color.Black;
            this.txt_bckuppath.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txt_bckuppath.HoverState.Parent = this.txt_bckuppath;
            this.txt_bckuppath.Location = new System.Drawing.Point(185, 255);
            this.txt_bckuppath.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txt_bckuppath.Name = "txt_bckuppath";
            this.txt_bckuppath.PasswordChar = '\0';
            this.txt_bckuppath.PlaceholderText = "Backup Path of the Database";
            this.txt_bckuppath.ReadOnly = true;
            this.txt_bckuppath.SelectedText = "";
            this.txt_bckuppath.ShadowDecoration.Parent = this.txt_bckuppath;
            this.txt_bckuppath.Size = new System.Drawing.Size(519, 37);
            this.txt_bckuppath.TabIndex = 160;
            // 
            // btn_browsebckup
            // 
            this.btn_browsebckup.Animated = true;
            this.btn_browsebckup.BackColor = System.Drawing.Color.Transparent;
            this.btn_browsebckup.BorderColor = System.Drawing.Color.Transparent;
            this.btn_browsebckup.BorderRadius = 10;
            this.btn_browsebckup.CheckedState.Parent = this.btn_browsebckup;
            this.btn_browsebckup.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_browsebckup.CustomImages.Parent = this.btn_browsebckup;
            this.btn_browsebckup.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(81)))), ((int)(((byte)(81)))));
            this.btn_browsebckup.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(81)))), ((int)(((byte)(81)))));
            this.btn_browsebckup.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_browsebckup.ForeColor = System.Drawing.Color.White;
            this.btn_browsebckup.HoverState.Parent = this.btn_browsebckup;
            this.btn_browsebckup.Location = new System.Drawing.Point(722, 255);
            this.btn_browsebckup.Name = "btn_browsebckup";
            this.btn_browsebckup.ShadowDecoration.Parent = this.btn_browsebckup;
            this.btn_browsebckup.Size = new System.Drawing.Size(138, 37);
            this.btn_browsebckup.TabIndex = 161;
            this.btn_browsebckup.Text = "Browse";
            this.btn_browsebckup.Click += new System.EventHandler(this.Btn_browsebckup_Click);
            // 
            // btn_disconnect
            // 
            this.btn_disconnect.Animated = true;
            this.btn_disconnect.BackColor = System.Drawing.Color.Transparent;
            this.btn_disconnect.BorderColor = System.Drawing.Color.Transparent;
            this.btn_disconnect.BorderRadius = 10;
            this.btn_disconnect.CheckedState.Parent = this.btn_disconnect;
            this.btn_disconnect.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_disconnect.CustomImages.Parent = this.btn_disconnect;
            this.btn_disconnect.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(81)))), ((int)(((byte)(81)))));
            this.btn_disconnect.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(81)))), ((int)(((byte)(81)))));
            this.btn_disconnect.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_disconnect.ForeColor = System.Drawing.Color.White;
            this.btn_disconnect.HoverState.Parent = this.btn_disconnect;
            this.btn_disconnect.Location = new System.Drawing.Point(284, 102);
            this.btn_disconnect.Name = "btn_disconnect";
            this.btn_disconnect.ShadowDecoration.Parent = this.btn_disconnect;
            this.btn_disconnect.Size = new System.Drawing.Size(137, 39);
            this.btn_disconnect.TabIndex = 162;
            this.btn_disconnect.Text = "Disconnect";
            this.btn_disconnect.Click += new System.EventHandler(this.Btn_disconnect_Click);
            // 
            // btn_browserestore
            // 
            this.btn_browserestore.Animated = true;
            this.btn_browserestore.BackColor = System.Drawing.Color.Transparent;
            this.btn_browserestore.BorderColor = System.Drawing.Color.Transparent;
            this.btn_browserestore.BorderRadius = 10;
            this.btn_browserestore.CheckedState.Parent = this.btn_browserestore;
            this.btn_browserestore.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_browserestore.CustomImages.Parent = this.btn_browserestore;
            this.btn_browserestore.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(81)))), ((int)(((byte)(81)))));
            this.btn_browserestore.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(81)))), ((int)(((byte)(81)))));
            this.btn_browserestore.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_browserestore.ForeColor = System.Drawing.Color.White;
            this.btn_browserestore.HoverState.Parent = this.btn_browserestore;
            this.btn_browserestore.Location = new System.Drawing.Point(722, 411);
            this.btn_browserestore.Name = "btn_browserestore";
            this.btn_browserestore.ShadowDecoration.Parent = this.btn_browserestore;
            this.btn_browserestore.Size = new System.Drawing.Size(138, 37);
            this.btn_browserestore.TabIndex = 163;
            this.btn_browserestore.Text = "Browse";
            this.btn_browserestore.Click += new System.EventHandler(this.Btn_browserestore_Click);
            // 
            // btn_backup
            // 
            this.btn_backup.Animated = true;
            this.btn_backup.BackColor = System.Drawing.Color.Transparent;
            this.btn_backup.BorderColor = System.Drawing.Color.Transparent;
            this.btn_backup.BorderRadius = 10;
            this.btn_backup.CheckedState.Parent = this.btn_backup;
            this.btn_backup.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_backup.CustomImages.Parent = this.btn_backup;
            this.btn_backup.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(81)))), ((int)(((byte)(81)))));
            this.btn_backup.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(81)))), ((int)(((byte)(81)))));
            this.btn_backup.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_backup.ForeColor = System.Drawing.Color.White;
            this.btn_backup.HoverState.Parent = this.btn_backup;
            this.btn_backup.Location = new System.Drawing.Point(722, 302);
            this.btn_backup.Name = "btn_backup";
            this.btn_backup.ShadowDecoration.Parent = this.btn_backup;
            this.btn_backup.Size = new System.Drawing.Size(138, 37);
            this.btn_backup.TabIndex = 164;
            this.btn_backup.Text = "Backup";
            this.btn_backup.Click += new System.EventHandler(this.Btn_backup_Click);
            // 
            // btn_restore
            // 
            this.btn_restore.Animated = true;
            this.btn_restore.BackColor = System.Drawing.Color.Transparent;
            this.btn_restore.BorderColor = System.Drawing.Color.Transparent;
            this.btn_restore.BorderRadius = 10;
            this.btn_restore.CheckedState.Parent = this.btn_restore;
            this.btn_restore.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_restore.CustomImages.Parent = this.btn_restore;
            this.btn_restore.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(81)))), ((int)(((byte)(81)))));
            this.btn_restore.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(81)))), ((int)(((byte)(81)))));
            this.btn_restore.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_restore.ForeColor = System.Drawing.Color.White;
            this.btn_restore.HoverState.Parent = this.btn_restore;
            this.btn_restore.Location = new System.Drawing.Point(722, 457);
            this.btn_restore.Name = "btn_restore";
            this.btn_restore.ShadowDecoration.Parent = this.btn_restore;
            this.btn_restore.Size = new System.Drawing.Size(138, 37);
            this.btn_restore.TabIndex = 165;
            this.btn_restore.Text = "Restore";
            this.btn_restore.Click += new System.EventHandler(this.Btn_restore_Click);
            // 
            // btn_connect
            // 
            this.btn_connect.Animated = true;
            this.btn_connect.BackColor = System.Drawing.Color.Transparent;
            this.btn_connect.BorderColor = System.Drawing.Color.Transparent;
            this.btn_connect.BorderRadius = 10;
            this.btn_connect.CheckedState.Parent = this.btn_connect;
            this.btn_connect.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_connect.CustomImages.Parent = this.btn_connect;
            this.btn_connect.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(81)))), ((int)(((byte)(81)))));
            this.btn_connect.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(81)))), ((int)(((byte)(81)))));
            this.btn_connect.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_connect.ForeColor = System.Drawing.Color.White;
            this.btn_connect.HoverState.Parent = this.btn_connect;
            this.btn_connect.Location = new System.Drawing.Point(140, 102);
            this.btn_connect.Name = "btn_connect";
            this.btn_connect.ShadowDecoration.Parent = this.btn_connect;
            this.btn_connect.Size = new System.Drawing.Size(137, 39);
            this.btn_connect.TabIndex = 166;
            this.btn_connect.Text = "Connect";
            this.btn_connect.Click += new System.EventHandler(this.Btn_connect_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label1.Location = new System.Drawing.Point(505, 68);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(83, 16);
            this.label1.TabIndex = 167;
            this.label1.Text = "Database :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label2.Location = new System.Drawing.Point(59, 68);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(64, 16);
            this.label2.TabIndex = 168;
            this.label2.Text = "Source :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label3.Location = new System.Drawing.Point(59, 265);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(102, 16);
            this.label3.TabIndex = 169;
            this.label3.Text = "Backup Path :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label4.Location = new System.Drawing.Point(59, 422);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(105, 16);
            this.label4.TabIndex = 170;
            this.label4.Text = "Restore Path :";
            // 
            // bunifuLabel2
            // 
            this.bunifuLabel2.AllowParentOverrides = false;
            this.bunifuLabel2.AutoEllipsis = false;
            this.bunifuLabel2.AutoSize = false;
            this.bunifuLabel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.bunifuLabel2.Cursor = System.Windows.Forms.Cursors.Default;
            this.bunifuLabel2.CursorType = System.Windows.Forms.Cursors.Default;
            this.bunifuLabel2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.bunifuLabel2.Location = new System.Drawing.Point(914, 38);
            this.bunifuLabel2.Name = "bunifuLabel2";
            this.bunifuLabel2.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.bunifuLabel2.Size = new System.Drawing.Size(273, 175);
            this.bunifuLabel2.TabIndex = 173;
            this.bunifuLabel2.Text = "Note \r\n\r\n\r\nCan\'t Backup Database Without Having a Empty folder in Disk C because " +
    "of the Security of Windows\r\n";
            this.bunifuLabel2.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            this.bunifuLabel2.TextFormat = Bunifu.UI.WinForms.BunifuLabel.TextFormattingOptions.Default;
            // 
            // bunifuLabel1
            // 
            this.bunifuLabel1.AllowParentOverrides = false;
            this.bunifuLabel1.AutoEllipsis = false;
            this.bunifuLabel1.AutoSize = false;
            this.bunifuLabel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.bunifuLabel1.CursorType = null;
            this.bunifuLabel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.bunifuLabel1.Location = new System.Drawing.Point(62, 534);
            this.bunifuLabel1.Name = "bunifuLabel1";
            this.bunifuLabel1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.bunifuLabel1.Size = new System.Drawing.Size(1112, 186);
            this.bunifuLabel1.TabIndex = 174;
            this.bunifuLabel1.Text = resources.GetString("bunifuLabel1.Text");
            this.bunifuLabel1.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            this.bunifuLabel1.TextFormat = Bunifu.UI.WinForms.BunifuLabel.TextFormattingOptions.Default;
            // 
            // guna2ProgressIndicator1
            // 
            this.guna2ProgressIndicator1.CircleSize = 1F;
            this.guna2ProgressIndicator1.Location = new System.Drawing.Point(1002, 302);
            this.guna2ProgressIndicator1.Name = "guna2ProgressIndicator1";
            this.guna2ProgressIndicator1.Size = new System.Drawing.Size(90, 90);
            this.guna2ProgressIndicator1.TabIndex = 177;
            // 
            // label5
            // 
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.label5.Location = new System.Drawing.Point(914, 414);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(273, 16);
            this.label5.TabIndex = 178;
            this.label5.Text = "Result";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // DBBackup_Restore
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1217, 773);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.guna2ProgressIndicator1);
            this.Controls.Add(this.bunifuLabel1);
            this.Controls.Add(this.bunifuLabel2);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_connect);
            this.Controls.Add(this.btn_restore);
            this.Controls.Add(this.btn_backup);
            this.Controls.Add(this.btn_browserestore);
            this.Controls.Add(this.btn_disconnect);
            this.Controls.Add(this.btn_browsebckup);
            this.Controls.Add(this.txt_bckuppath);
            this.Controls.Add(this.txt_restorepath);
            this.Controls.Add(this.txt_source);
            this.Controls.Add(this.cmb_databases);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "DBBackup_Restore";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "DBBackup_Restore";
            this.Load += new System.EventHandler(this.DBBackup_Restore_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse1;
        private Guna.UI2.WinForms.Guna2ComboBox cmb_databases;
        private Guna.UI2.WinForms.Guna2TextBox txt_bckuppath;
        private Guna.UI2.WinForms.Guna2TextBox txt_restorepath;
        private Guna.UI2.WinForms.Guna2TextBox txt_source;
        private Guna.UI2.WinForms.Guna2GradientButton btn_connect;
        private Guna.UI2.WinForms.Guna2GradientButton btn_restore;
        private Guna.UI2.WinForms.Guna2GradientButton btn_backup;
        private Guna.UI2.WinForms.Guna2GradientButton btn_browserestore;
        private Guna.UI2.WinForms.Guna2GradientButton btn_disconnect;
        private Guna.UI2.WinForms.Guna2GradientButton btn_browsebckup;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private Bunifu.UI.WinForms.BunifuLabel bunifuLabel2;
        private Bunifu.UI.WinForms.BunifuLabel bunifuLabel1;
        private Guna.UI2.WinForms.Guna2ProgressIndicator guna2ProgressIndicator1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog1;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
    }
}