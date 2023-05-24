namespace DirectoryFilesForEver
{
    partial class DirectoryFilesForever
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DirectoryFilesForever));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.arxiuToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.obrirToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.guardarJSONToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.llegirJSONToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dataGridView = new System.Windows.Forms.DataGridView();
            this.labelRuta = new System.Windows.Forms.Label();
            this.labelTipus = new System.Windows.Forms.Label();
            this.comboBoxVeure = new System.Windows.Forms.ComboBox();
            this.textBoxNom = new System.Windows.Forms.TextBox();
            this.checkBoxNom = new System.Windows.Forms.CheckBox();
            this.checkBoxCreatDespres = new System.Windows.Forms.CheckBox();
            this.checkBoxCreatAbans = new System.Windows.Forms.CheckBox();
            this.dateTimePickerAbansData = new System.Windows.Forms.DateTimePicker();
            this.dateTimePickerDespresData = new System.Windows.Forms.DateTimePicker();
            this.groupBoxFiltres = new System.Windows.Forms.GroupBox();
            this.dateTimePickerDespresTemps = new System.Windows.Forms.DateTimePicker();
            this.dateTimePickerAbansTemps = new System.Windows.Forms.DateTimePicker();
            this.groupBoxRuta = new System.Windows.Forms.GroupBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.comboBoxOrdenar = new System.Windows.Forms.ComboBox();
            this.labelOrdenar = new System.Windows.Forms.Label();
            this.radioButtonAsc = new System.Windows.Forms.RadioButton();
            this.radioButtonDesc = new System.Windows.Forms.RadioButton();
            this.buttonModificarNom = new System.Windows.Forms.Button();
            this.buttonCrear = new System.Windows.Forms.Button();
            this.buttonBorrar = new System.Windows.Forms.Button();
            this.pictureBoxBuscar = new System.Windows.Forms.PictureBox();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).BeginInit();
            this.groupBoxFiltres.SuspendLayout();
            this.groupBoxRuta.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxBuscar)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(144)))), ((int)(((byte)(202)))), ((int)(((byte)(249)))));
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.arxiuToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(942, 27);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // arxiuToolStripMenuItem
            // 
            this.arxiuToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.obrirToolStripMenuItem,
            this.toolStripSeparator1,
            this.guardarJSONToolStripMenuItem,
            this.llegirJSONToolStripMenuItem});
            this.arxiuToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.arxiuToolStripMenuItem.Name = "arxiuToolStripMenuItem";
            this.arxiuToolStripMenuItem.Size = new System.Drawing.Size(52, 23);
            this.arxiuToolStripMenuItem.Text = "Arxiu";
            // 
            // obrirToolStripMenuItem
            // 
            this.obrirToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.obrirToolStripMenuItem.Name = "obrirToolStripMenuItem";
            this.obrirToolStripMenuItem.Size = new System.Drawing.Size(180, 24);
            this.obrirToolStripMenuItem.Text = "Obrir directori";
            this.obrirToolStripMenuItem.Click += new System.EventHandler(this.obrirToolStripMenuItem_Click);
            // 
            // guardarJSONToolStripMenuItem
            // 
            this.guardarJSONToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.guardarJSONToolStripMenuItem.Name = "guardarJSONToolStripMenuItem";
            this.guardarJSONToolStripMenuItem.Size = new System.Drawing.Size(165, 24);
            this.guardarJSONToolStripMenuItem.Text = "Guardar JSON";
            this.guardarJSONToolStripMenuItem.Click += new System.EventHandler(this.guardarJSONToolStripMenuItem_Click);
            // 
            // llegirJSONToolStripMenuItem
            // 
            this.llegirJSONToolStripMenuItem.Name = "llegirJSONToolStripMenuItem";
            this.llegirJSONToolStripMenuItem.Size = new System.Drawing.Size(165, 24);
            this.llegirJSONToolStripMenuItem.Text = "Llegir JSON";
            this.llegirJSONToolStripMenuItem.Click += new System.EventHandler(this.llegirJSONToolStripMenuItem_Click);
            // 
            // dataGridView
            // 
            this.dataGridView.AllowUserToAddRows = false;
            this.dataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(230)))), ((int)(((byte)(252)))));
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle7.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            dataGridViewCellStyle7.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle7;
            this.dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle8.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            dataGridViewCellStyle8.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView.DefaultCellStyle = dataGridViewCellStyle8;
            this.dataGridView.Location = new System.Drawing.Point(22, 120);
            this.dataGridView.MultiSelect = false;
            this.dataGridView.Name = "dataGridView";
            this.dataGridView.ReadOnly = true;
            this.dataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView.Size = new System.Drawing.Size(564, 365);
            this.dataGridView.TabIndex = 0;
            // 
            // labelRuta
            // 
            this.labelRuta.AutoSize = true;
            this.labelRuta.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(230)))), ((int)(((byte)(252)))));
            this.labelRuta.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelRuta.Location = new System.Drawing.Point(15, 31);
            this.labelRuta.Name = "labelRuta";
            this.labelRuta.Size = new System.Drawing.Size(0, 20);
            this.labelRuta.TabIndex = 2;
            // 
            // labelTipus
            // 
            this.labelTipus.AutoSize = true;
            this.labelTipus.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.labelTipus.Location = new System.Drawing.Point(606, 135);
            this.labelTipus.Name = "labelTipus";
            this.labelTipus.Size = new System.Drawing.Size(46, 17);
            this.labelTipus.TabIndex = 3;
            this.labelTipus.Text = "Veure";
            // 
            // comboBoxVeure
            // 
            this.comboBoxVeure.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxVeure.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxVeure.FormattingEnabled = true;
            this.comboBoxVeure.Items.AddRange(new object[] {
            "Tot",
            "Arxius",
            "Directoris"});
            this.comboBoxVeure.Location = new System.Drawing.Point(658, 132);
            this.comboBoxVeure.Name = "comboBoxVeure";
            this.comboBoxVeure.Size = new System.Drawing.Size(258, 24);
            this.comboBoxVeure.TabIndex = 4;
            this.comboBoxVeure.SelectedIndexChanged += new System.EventHandler(this.comboBoxVeure_SelectedIndexChanged);
            // 
            // textBoxNom
            // 
            this.textBoxNom.Enabled = false;
            this.textBoxNom.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.textBoxNom.Location = new System.Drawing.Point(13, 56);
            this.textBoxNom.Name = "textBoxNom";
            this.textBoxNom.Size = new System.Drawing.Size(277, 23);
            this.textBoxNom.TabIndex = 6;
            this.textBoxNom.TextChanged += new System.EventHandler(this.textBoxNom_TextChanged);
            // 
            // checkBoxNom
            // 
            this.checkBoxNom.AutoSize = true;
            this.checkBoxNom.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.checkBoxNom.Location = new System.Drawing.Point(21, 29);
            this.checkBoxNom.Name = "checkBoxNom";
            this.checkBoxNom.Size = new System.Drawing.Size(56, 21);
            this.checkBoxNom.TabIndex = 8;
            this.checkBoxNom.Text = "Nom";
            this.checkBoxNom.UseVisualStyleBackColor = true;
            this.checkBoxNom.CheckedChanged += new System.EventHandler(this.checkBoxNom_CheckedChanged);
            // 
            // checkBoxCreatDespres
            // 
            this.checkBoxCreatDespres.AutoSize = true;
            this.checkBoxCreatDespres.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.checkBoxCreatDespres.Location = new System.Drawing.Point(21, 90);
            this.checkBoxCreatDespres.Name = "checkBoxCreatDespres";
            this.checkBoxCreatDespres.Size = new System.Drawing.Size(136, 21);
            this.checkBoxCreatDespres.TabIndex = 9;
            this.checkBoxCreatDespres.Text = "Creat després de";
            this.checkBoxCreatDespres.UseVisualStyleBackColor = true;
            this.checkBoxCreatDespres.CheckedChanged += new System.EventHandler(this.checkBoxCreatDespres_CheckedChanged);
            // 
            // checkBoxCreatAbans
            // 
            this.checkBoxCreatAbans.AutoSize = true;
            this.checkBoxCreatAbans.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.checkBoxCreatAbans.Location = new System.Drawing.Point(21, 155);
            this.checkBoxCreatAbans.Name = "checkBoxCreatAbans";
            this.checkBoxCreatAbans.Size = new System.Drawing.Size(124, 21);
            this.checkBoxCreatAbans.TabIndex = 10;
            this.checkBoxCreatAbans.Text = "Creat abans de";
            this.checkBoxCreatAbans.UseVisualStyleBackColor = true;
            this.checkBoxCreatAbans.CheckedChanged += new System.EventHandler(this.checkBoxCreatAbans_CheckedChanged);
            // 
            // dateTimePickerAbansData
            // 
            this.dateTimePickerAbansData.CustomFormat = "dddd dd/MM/yyyy";
            this.dateTimePickerAbansData.Enabled = false;
            this.dateTimePickerAbansData.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.dateTimePickerAbansData.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePickerAbansData.Location = new System.Drawing.Point(13, 182);
            this.dateTimePickerAbansData.Name = "dateTimePickerAbansData";
            this.dateTimePickerAbansData.Size = new System.Drawing.Size(186, 23);
            this.dateTimePickerAbansData.TabIndex = 11;
            this.dateTimePickerAbansData.Value = new System.DateTime(2000, 1, 1, 0, 0, 0, 0);
            this.dateTimePickerAbansData.ValueChanged += new System.EventHandler(this.dateTimePickerAbansData_ValueChanged);
            // 
            // dateTimePickerDespresData
            // 
            this.dateTimePickerDespresData.CustomFormat = "dddd dd/MM/yyyy";
            this.dateTimePickerDespresData.Enabled = false;
            this.dateTimePickerDespresData.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.dateTimePickerDespresData.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePickerDespresData.Location = new System.Drawing.Point(13, 117);
            this.dateTimePickerDespresData.Name = "dateTimePickerDespresData";
            this.dateTimePickerDespresData.Size = new System.Drawing.Size(186, 23);
            this.dateTimePickerDespresData.TabIndex = 12;
            this.dateTimePickerDespresData.Value = new System.DateTime(2000, 1, 1, 0, 0, 0, 0);
            this.dateTimePickerDespresData.ValueChanged += new System.EventHandler(this.dateTimePickerDespresData_ValueChanged);
            // 
            // groupBoxFiltres
            // 
            this.groupBoxFiltres.Controls.Add(this.dateTimePickerDespresTemps);
            this.groupBoxFiltres.Controls.Add(this.dateTimePickerAbansTemps);
            this.groupBoxFiltres.Controls.Add(this.textBoxNom);
            this.groupBoxFiltres.Controls.Add(this.checkBoxNom);
            this.groupBoxFiltres.Controls.Add(this.dateTimePickerDespresData);
            this.groupBoxFiltres.Controls.Add(this.checkBoxCreatDespres);
            this.groupBoxFiltres.Controls.Add(this.checkBoxCreatAbans);
            this.groupBoxFiltres.Controls.Add(this.dateTimePickerAbansData);
            this.groupBoxFiltres.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.groupBoxFiltres.Location = new System.Drawing.Point(609, 256);
            this.groupBoxFiltres.Name = "groupBoxFiltres";
            this.groupBoxFiltres.Size = new System.Drawing.Size(307, 224);
            this.groupBoxFiltres.TabIndex = 15;
            this.groupBoxFiltres.TabStop = false;
            this.groupBoxFiltres.Text = "Filtres";
            // 
            // dateTimePickerDespresTemps
            // 
            this.dateTimePickerDespresTemps.CustomFormat = "HH:mm";
            this.dateTimePickerDespresTemps.Enabled = false;
            this.dateTimePickerDespresTemps.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.dateTimePickerDespresTemps.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePickerDespresTemps.Location = new System.Drawing.Point(205, 117);
            this.dateTimePickerDespresTemps.Name = "dateTimePickerDespresTemps";
            this.dateTimePickerDespresTemps.ShowUpDown = true;
            this.dateTimePickerDespresTemps.Size = new System.Drawing.Size(85, 23);
            this.dateTimePickerDespresTemps.TabIndex = 14;
            this.dateTimePickerDespresTemps.Value = new System.DateTime(2023, 1, 11, 0, 0, 0, 0);
            this.dateTimePickerDespresTemps.ValueChanged += new System.EventHandler(this.dateTimePickerDespresTemps_ValueChanged);
            // 
            // dateTimePickerAbansTemps
            // 
            this.dateTimePickerAbansTemps.CustomFormat = "HH:mm";
            this.dateTimePickerAbansTemps.Enabled = false;
            this.dateTimePickerAbansTemps.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.dateTimePickerAbansTemps.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePickerAbansTemps.Location = new System.Drawing.Point(205, 182);
            this.dateTimePickerAbansTemps.Name = "dateTimePickerAbansTemps";
            this.dateTimePickerAbansTemps.ShowUpDown = true;
            this.dateTimePickerAbansTemps.Size = new System.Drawing.Size(85, 23);
            this.dateTimePickerAbansTemps.TabIndex = 13;
            this.dateTimePickerAbansTemps.Value = new System.DateTime(2000, 1, 1, 0, 0, 0, 0);
            this.dateTimePickerAbansTemps.ValueChanged += new System.EventHandler(this.dateTimePickerAbansTemps_ValueChanged);
            // 
            // groupBoxRuta
            // 
            this.groupBoxRuta.Controls.Add(this.labelRuta);
            this.groupBoxRuta.Controls.Add(this.panel1);
            this.groupBoxRuta.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.groupBoxRuta.Location = new System.Drawing.Point(22, 40);
            this.groupBoxRuta.Name = "groupBoxRuta";
            this.groupBoxRuta.Size = new System.Drawing.Size(897, 70);
            this.groupBoxRuta.TabIndex = 16;
            this.groupBoxRuta.TabStop = false;
            this.groupBoxRuta.Text = "Ruta del directori actual";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(230)))), ((int)(((byte)(252)))));
            this.panel1.Location = new System.Drawing.Point(8, 21);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(881, 40);
            this.panel1.TabIndex = 3;
            // 
            // comboBoxOrdenar
            // 
            this.comboBoxOrdenar.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxOrdenar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxOrdenar.FormattingEnabled = true;
            this.comboBoxOrdenar.Items.AddRange(new object[] {
            "Nom",
            "Tipus",
            "Data de creació"});
            this.comboBoxOrdenar.Location = new System.Drawing.Point(698, 181);
            this.comboBoxOrdenar.Name = "comboBoxOrdenar";
            this.comboBoxOrdenar.Size = new System.Drawing.Size(218, 24);
            this.comboBoxOrdenar.TabIndex = 18;
            this.comboBoxOrdenar.SelectedIndexChanged += new System.EventHandler(this.comboBoxOrdenar_SelectedIndexChanged);
            // 
            // labelOrdenar
            // 
            this.labelOrdenar.AutoSize = true;
            this.labelOrdenar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.labelOrdenar.Location = new System.Drawing.Point(606, 184);
            this.labelOrdenar.Name = "labelOrdenar";
            this.labelOrdenar.Size = new System.Drawing.Size(86, 17);
            this.labelOrdenar.TabIndex = 17;
            this.labelOrdenar.Text = "Ordenar per";
            // 
            // radioButtonAsc
            // 
            this.radioButtonAsc.AutoSize = true;
            this.radioButtonAsc.Checked = true;
            this.radioButtonAsc.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.radioButtonAsc.Location = new System.Drawing.Point(698, 219);
            this.radioButtonAsc.Name = "radioButtonAsc";
            this.radioButtonAsc.Size = new System.Drawing.Size(93, 21);
            this.radioButtonAsc.TabIndex = 19;
            this.radioButtonAsc.TabStop = true;
            this.radioButtonAsc.Text = "Ascendent";
            this.radioButtonAsc.UseVisualStyleBackColor = true;
            // 
            // radioButtonDesc
            // 
            this.radioButtonDesc.AutoSize = true;
            this.radioButtonDesc.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.radioButtonDesc.Location = new System.Drawing.Point(814, 219);
            this.radioButtonDesc.Name = "radioButtonDesc";
            this.radioButtonDesc.Size = new System.Drawing.Size(102, 21);
            this.radioButtonDesc.TabIndex = 20;
            this.radioButtonDesc.Text = "Descendent";
            this.radioButtonDesc.UseVisualStyleBackColor = true;
            this.radioButtonDesc.CheckedChanged += new System.EventHandler(this.radioButtonDesc_CheckedChanged);
            // 
            // buttonModificarNom
            // 
            this.buttonModificarNom.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.buttonModificarNom.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(144)))), ((int)(((byte)(202)))), ((int)(((byte)(249)))));
            this.buttonModificarNom.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.buttonModificarNom.ForeColor = System.Drawing.Color.Black;
            this.buttonModificarNom.Location = new System.Drawing.Point(430, 498);
            this.buttonModificarNom.Name = "buttonModificarNom";
            this.buttonModificarNom.Size = new System.Drawing.Size(156, 37);
            this.buttonModificarNom.TabIndex = 26;
            this.buttonModificarNom.Text = "MODIFICAR NOM";
            this.buttonModificarNom.UseVisualStyleBackColor = false;
            this.buttonModificarNom.Click += new System.EventHandler(this.buttonModificarNom_Click);
            // 
            // buttonCrear
            // 
            this.buttonCrear.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.buttonCrear.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(144)))), ((int)(((byte)(202)))), ((int)(((byte)(249)))));
            this.buttonCrear.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.buttonCrear.ForeColor = System.Drawing.Color.Black;
            this.buttonCrear.Location = new System.Drawing.Point(106, 498);
            this.buttonCrear.Name = "buttonCrear";
            this.buttonCrear.Size = new System.Drawing.Size(156, 37);
            this.buttonCrear.TabIndex = 25;
            this.buttonCrear.Text = "CREAR";
            this.buttonCrear.UseVisualStyleBackColor = false;
            this.buttonCrear.Click += new System.EventHandler(this.buttonCrear_Click);
            // 
            // buttonBorrar
            // 
            this.buttonBorrar.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.buttonBorrar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(144)))), ((int)(((byte)(202)))), ((int)(((byte)(249)))));
            this.buttonBorrar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.buttonBorrar.ForeColor = System.Drawing.Color.Black;
            this.buttonBorrar.Location = new System.Drawing.Point(268, 498);
            this.buttonBorrar.Name = "buttonBorrar";
            this.buttonBorrar.Size = new System.Drawing.Size(156, 37);
            this.buttonBorrar.TabIndex = 24;
            this.buttonBorrar.Text = "ELIMINAR";
            this.buttonBorrar.UseVisualStyleBackColor = false;
            this.buttonBorrar.Click += new System.EventHandler(this.buttonBorrar_Click);
            // 
            // pictureBoxBuscar
            // 
            this.pictureBoxBuscar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(144)))), ((int)(((byte)(202)))), ((int)(((byte)(249)))));
            this.pictureBoxBuscar.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBoxBuscar.Enabled = false;
            this.pictureBoxBuscar.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxBuscar.Image")));
            this.pictureBoxBuscar.InitialImage = ((System.Drawing.Image)(resources.GetObject("pictureBoxBuscar.InitialImage")));
            this.pictureBoxBuscar.Location = new System.Drawing.Point(30, 176);
            this.pictureBoxBuscar.Name = "pictureBoxBuscar";
            this.pictureBoxBuscar.Size = new System.Drawing.Size(23, 23);
            this.pictureBoxBuscar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxBuscar.TabIndex = 7;
            this.pictureBoxBuscar.TabStop = false;
            this.pictureBoxBuscar.WaitOnLoad = true;
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(177, 6);
            // 
            // DirectoryFilesForever
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(245)))), ((int)(((byte)(246)))));
            this.ClientSize = new System.Drawing.Size(942, 548);
            this.Controls.Add(this.buttonModificarNom);
            this.Controls.Add(this.buttonCrear);
            this.Controls.Add(this.buttonBorrar);
            this.Controls.Add(this.radioButtonDesc);
            this.Controls.Add(this.radioButtonAsc);
            this.Controls.Add(this.comboBoxOrdenar);
            this.Controls.Add(this.labelOrdenar);
            this.Controls.Add(this.groupBoxRuta);
            this.Controls.Add(this.groupBoxFiltres);
            this.Controls.Add(this.comboBoxVeure);
            this.Controls.Add(this.labelTipus);
            this.Controls.Add(this.dataGridView);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.pictureBoxBuscar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "DirectoryFilesForever";
            this.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Directory & Files For Ever";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).EndInit();
            this.groupBoxFiltres.ResumeLayout(false);
            this.groupBoxFiltres.PerformLayout();
            this.groupBoxRuta.ResumeLayout(false);
            this.groupBoxRuta.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxBuscar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem arxiuToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem obrirToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem guardarJSONToolStripMenuItem;
        private System.Windows.Forms.DataGridView dataGridView;
        private System.Windows.Forms.Label labelRuta;
        private System.Windows.Forms.Label labelTipus;
        private System.Windows.Forms.ComboBox comboBoxVeure;
        private System.Windows.Forms.TextBox textBoxNom;
        private System.Windows.Forms.CheckBox checkBoxNom;
        private System.Windows.Forms.CheckBox checkBoxCreatDespres;
        private System.Windows.Forms.CheckBox checkBoxCreatAbans;
        private System.Windows.Forms.DateTimePicker dateTimePickerAbansData;
        private System.Windows.Forms.DateTimePicker dateTimePickerDespresData;
        private System.Windows.Forms.GroupBox groupBoxFiltres;
        private System.Windows.Forms.GroupBox groupBoxRuta;
        private System.Windows.Forms.ComboBox comboBoxOrdenar;
        private System.Windows.Forms.Label labelOrdenar;
        private System.Windows.Forms.RadioButton radioButtonAsc;
        private System.Windows.Forms.RadioButton radioButtonDesc;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button buttonModificarNom;
        private System.Windows.Forms.Button buttonCrear;
        private System.Windows.Forms.Button buttonBorrar;
        private System.Windows.Forms.DateTimePicker dateTimePickerDespresTemps;
        private System.Windows.Forms.DateTimePicker dateTimePickerAbansTemps;
        private System.Windows.Forms.PictureBox pictureBoxBuscar;
        private System.Windows.Forms.ToolStripMenuItem llegirJSONToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
    }
}

