namespace Gestion_d_ecole
{
    partial class FormProfesseur
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
            this.label1 = new System.Windows.Forms.Label();
            this.txtnomprof = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtprenomprof = new System.Windows.Forms.TextBox();
            this.txtemailprof = new System.Windows.Forms.TextBox();
            this.txttelephoneprof = new System.Windows.Forms.TextBox();
            this.btnajouterprof = new System.Windows.Forms.Button();
            this.btneffacerprof = new System.Windows.Forms.Button();
            this.btnmodifprof = new System.Windows.Forms.Button();
            this.btnsupprimerprof = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(331, 134);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 19);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nom";
            // 
            // txtnomprof
            // 
            this.txtnomprof.Location = new System.Drawing.Point(453, 133);
            this.txtnomprof.Name = "txtnomprof";
            this.txtnomprof.Size = new System.Drawing.Size(100, 22);
            this.txtnomprof.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(322, 184);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(68, 19);
            this.label2.TabIndex = 2;
            this.label2.Text = "Prenom";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(336, 242);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(54, 19);
            this.label3.TabIndex = 3;
            this.label3.Text = "Email";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(307, 303);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(83, 19);
            this.label4.TabIndex = 4;
            this.label4.Text = "Telephone";
            // 
            // txtprenomprof
            // 
            this.txtprenomprof.Location = new System.Drawing.Point(453, 184);
            this.txtprenomprof.Name = "txtprenomprof";
            this.txtprenomprof.Size = new System.Drawing.Size(100, 22);
            this.txtprenomprof.TabIndex = 5;
            // 
            // txtemailprof
            // 
            this.txtemailprof.Location = new System.Drawing.Point(453, 239);
            this.txtemailprof.Name = "txtemailprof";
            this.txtemailprof.Size = new System.Drawing.Size(100, 22);
            this.txtemailprof.TabIndex = 6;
            this.txtemailprof.Validating += new System.ComponentModel.CancelEventHandler(this.txtemailprof_Validating);
            // 
            // txttelephoneprof
            // 
            this.txttelephoneprof.Location = new System.Drawing.Point(453, 300);
            this.txttelephoneprof.Name = "txttelephoneprof";
            this.txttelephoneprof.Size = new System.Drawing.Size(100, 22);
            this.txttelephoneprof.TabIndex = 7;
            this.txttelephoneprof.Validating += new System.ComponentModel.CancelEventHandler(this.txttelephoneprof_Validating);
            // 
            // btnajouterprof
            // 
            this.btnajouterprof.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnajouterprof.Location = new System.Drawing.Point(134, 381);
            this.btnajouterprof.Name = "btnajouterprof";
            this.btnajouterprof.Size = new System.Drawing.Size(143, 37);
            this.btnajouterprof.TabIndex = 8;
            this.btnajouterprof.Text = "Ajouter";
            this.btnajouterprof.UseVisualStyleBackColor = true;
            this.btnajouterprof.Click += new System.EventHandler(this.btnajouterprof_Click);
            // 
            // btneffacerprof
            // 
            this.btneffacerprof.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btneffacerprof.Location = new System.Drawing.Point(340, 381);
            this.btneffacerprof.Name = "btneffacerprof";
            this.btneffacerprof.Size = new System.Drawing.Size(143, 37);
            this.btneffacerprof.TabIndex = 9;
            this.btneffacerprof.Text = "effacer";
            this.btneffacerprof.UseVisualStyleBackColor = true;
            this.btneffacerprof.Click += new System.EventHandler(this.btneffacerprof_Click);
            // 
            // btnmodifprof
            // 
            this.btnmodifprof.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnmodifprof.Location = new System.Drawing.Point(542, 381);
            this.btnmodifprof.Name = "btnmodifprof";
            this.btnmodifprof.Size = new System.Drawing.Size(143, 37);
            this.btnmodifprof.TabIndex = 10;
            this.btnmodifprof.Text = "Modifier";
            this.btnmodifprof.UseVisualStyleBackColor = true;
            this.btnmodifprof.Click += new System.EventHandler(this.btnmodifprof_Click);
            // 
            // btnsupprimerprof
            // 
            this.btnsupprimerprof.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnsupprimerprof.Location = new System.Drawing.Point(749, 381);
            this.btnsupprimerprof.Name = "btnsupprimerprof";
            this.btnsupprimerprof.Size = new System.Drawing.Size(143, 37);
            this.btnsupprimerprof.TabIndex = 11;
            this.btnsupprimerprof.Text = "Supprimer";
            this.btnsupprimerprof.UseVisualStyleBackColor = true;
            this.btnsupprimerprof.Click += new System.EventHandler(this.btnsupprimerprof_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(631, 62);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(526, 258);
            this.dataGridView1.TabIndex = 13;
            this.dataGridView1.CellMouseDoubleClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dataGridView1_CellMouseDoubleClick);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Gestion_d_ecole.Properties.Resources.OIP;
            this.pictureBox1.Location = new System.Drawing.Point(48, 62);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(229, 260);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 12;
            this.pictureBox1.TabStop = false;
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // FormProfesseur
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1169, 527);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btnsupprimerprof);
            this.Controls.Add(this.btnmodifprof);
            this.Controls.Add(this.btneffacerprof);
            this.Controls.Add(this.btnajouterprof);
            this.Controls.Add(this.txttelephoneprof);
            this.Controls.Add(this.txtemailprof);
            this.Controls.Add(this.txtprenomprof);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtnomprof);
            this.Controls.Add(this.label1);
            this.Name = "FormProfesseur";
            this.Text = "FormProfesseur";
            this.Load += new System.EventHandler(this.FormProfesseur_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtnomprof;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtprenomprof;
        private System.Windows.Forms.TextBox txtemailprof;
        private System.Windows.Forms.TextBox txttelephoneprof;
        private System.Windows.Forms.Button btnajouterprof;
        private System.Windows.Forms.Button btneffacerprof;
        private System.Windows.Forms.Button btnmodifprof;
        private System.Windows.Forms.Button btnsupprimerprof;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.ErrorProvider errorProvider1;
    }
}