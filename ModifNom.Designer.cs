namespace DirectoryFilesForEver
{
    partial class ModifNom
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ModifNom));
            this.buttonModificar = new System.Windows.Forms.Button();
            this.textBoxNom = new System.Windows.Forms.TextBox();
            this.labelNom = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // buttonModificar
            // 
            this.buttonModificar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(144)))), ((int)(((byte)(202)))), ((int)(((byte)(249)))));
            this.buttonModificar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.buttonModificar.ForeColor = System.Drawing.Color.Black;
            this.buttonModificar.Location = new System.Drawing.Point(112, 102);
            this.buttonModificar.Name = "buttonModificar";
            this.buttonModificar.Size = new System.Drawing.Size(156, 37);
            this.buttonModificar.TabIndex = 2;
            this.buttonModificar.Text = "MODIFICAR";
            this.buttonModificar.UseVisualStyleBackColor = false;
            this.buttonModificar.Click += new System.EventHandler(this.buttonModificar_Click);
            // 
            // textBoxNom
            // 
            this.textBoxNom.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.textBoxNom.Location = new System.Drawing.Point(74, 47);
            this.textBoxNom.Name = "textBoxNom";
            this.textBoxNom.Size = new System.Drawing.Size(271, 23);
            this.textBoxNom.TabIndex = 1;
            // 
            // labelNom
            // 
            this.labelNom.AutoSize = true;
            this.labelNom.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.labelNom.Location = new System.Drawing.Point(22, 50);
            this.labelNom.Name = "labelNom";
            this.labelNom.Size = new System.Drawing.Size(37, 17);
            this.labelNom.TabIndex = 27;
            this.labelNom.Text = "Nom";
            // 
            // ModifNom
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(245)))), ((int)(((byte)(246)))));
            this.ClientSize = new System.Drawing.Size(367, 177);
            this.Controls.Add(this.buttonModificar);
            this.Controls.Add(this.textBoxNom);
            this.Controls.Add(this.labelNom);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "ModifNom";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Modificar Nom";
            this.Load += new System.EventHandler(this.ModifNom_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonModificar;
        private System.Windows.Forms.TextBox textBoxNom;
        private System.Windows.Forms.Label labelNom;
    }
}