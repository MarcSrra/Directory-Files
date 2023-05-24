namespace DirectoryFilesForEver
{
    partial class Crear
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Crear));
            this.comboBoxTipus = new System.Windows.Forms.ComboBox();
            this.labelTipus = new System.Windows.Forms.Label();
            this.labelNom = new System.Windows.Forms.Label();
            this.textBoxNom = new System.Windows.Forms.TextBox();
            this.buttonCrear = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // comboBoxTipus
            // 
            this.comboBoxTipus.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxTipus.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxTipus.FormattingEnabled = true;
            this.comboBoxTipus.Items.AddRange(new object[] {
            "Arxiu",
            "Directori"});
            this.comboBoxTipus.Location = new System.Drawing.Point(69, 68);
            this.comboBoxTipus.Name = "comboBoxTipus";
            this.comboBoxTipus.Size = new System.Drawing.Size(271, 24);
            this.comboBoxTipus.TabIndex = 6;
            // 
            // labelTipus
            // 
            this.labelTipus.AutoSize = true;
            this.labelTipus.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.labelTipus.Location = new System.Drawing.Point(17, 71);
            this.labelTipus.Name = "labelTipus";
            this.labelTipus.Size = new System.Drawing.Size(43, 17);
            this.labelTipus.TabIndex = 5;
            this.labelTipus.Text = "Tipus";
            // 
            // labelNom
            // 
            this.labelNom.AutoSize = true;
            this.labelNom.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.labelNom.Location = new System.Drawing.Point(17, 32);
            this.labelNom.Name = "labelNom";
            this.labelNom.Size = new System.Drawing.Size(37, 17);
            this.labelNom.TabIndex = 7;
            this.labelNom.Text = "Nom";
            // 
            // textBoxNom
            // 
            this.textBoxNom.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.textBoxNom.Location = new System.Drawing.Point(69, 29);
            this.textBoxNom.Name = "textBoxNom";
            this.textBoxNom.Size = new System.Drawing.Size(271, 23);
            this.textBoxNom.TabIndex = 8;
            // 
            // buttonCrear
            // 
            this.buttonCrear.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(144)))), ((int)(((byte)(202)))), ((int)(((byte)(249)))));
            this.buttonCrear.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.buttonCrear.ForeColor = System.Drawing.Color.Black;
            this.buttonCrear.Location = new System.Drawing.Point(107, 118);
            this.buttonCrear.Name = "buttonCrear";
            this.buttonCrear.Size = new System.Drawing.Size(156, 37);
            this.buttonCrear.TabIndex = 26;
            this.buttonCrear.Text = "CREAR";
            this.buttonCrear.UseVisualStyleBackColor = false;
            this.buttonCrear.Click += new System.EventHandler(this.buttonCrear_Click);
            // 
            // Crear
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(245)))), ((int)(((byte)(246)))));
            this.ClientSize = new System.Drawing.Size(367, 177);
            this.Controls.Add(this.buttonCrear);
            this.Controls.Add(this.textBoxNom);
            this.Controls.Add(this.labelNom);
            this.Controls.Add(this.comboBoxTipus);
            this.Controls.Add(this.labelTipus);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Crear";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Crear";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox comboBoxTipus;
        private System.Windows.Forms.Label labelTipus;
        private System.Windows.Forms.Label labelNom;
        private System.Windows.Forms.TextBox textBoxNom;
        private System.Windows.Forms.Button buttonCrear;
    }
}