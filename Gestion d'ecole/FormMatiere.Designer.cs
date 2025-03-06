namespace Gestion_d_ecole
{
    partial class FormMatiere
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
            this.label1 = new System.Windows.Forms.Label();
            this.txtmatiere = new System.Windows.Forms.TextBox();
            this.btnajouter = new System.Windows.Forms.Button();
            this.btneffacer = new System.Windows.Forms.Button();
            this.btnassocier = new System.Windows.Forms.Button();
            this.combocours = new System.Windows.Forms.ComboBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            this.txtmatierechoisi = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.btnannuler = new System.Windows.Forms.Button();
            this.combodejaassocie = new System.Windows.Forms.ComboBox();
            this.btndissocier = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(120, 127);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(122, 23);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nom Matiere";
            // 
            // txtmatiere
            // 
            this.txtmatiere.Location = new System.Drawing.Point(124, 167);
            this.txtmatiere.Name = "txtmatiere";
            this.txtmatiere.Size = new System.Drawing.Size(118, 22);
            this.txtmatiere.TabIndex = 1;
            // 
            // btnajouter
            // 
            this.btnajouter.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnajouter.Location = new System.Drawing.Point(56, 268);
            this.btnajouter.Name = "btnajouter";
            this.btnajouter.Size = new System.Drawing.Size(108, 41);
            this.btnajouter.TabIndex = 2;
            this.btnajouter.Text = "Ajouter";
            this.btnajouter.UseVisualStyleBackColor = true;
            this.btnajouter.Click += new System.EventHandler(this.btnajouter_Click);
            // 
            // btneffacer
            // 
            this.btneffacer.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btneffacer.Location = new System.Drawing.Point(224, 268);
            this.btneffacer.Name = "btneffacer";
            this.btneffacer.Size = new System.Drawing.Size(108, 41);
            this.btneffacer.TabIndex = 3;
            this.btneffacer.Text = "Effacer";
            this.btneffacer.UseVisualStyleBackColor = true;
            this.btneffacer.Click += new System.EventHandler(this.btneffacer_Click);
            // 
            // btnassocier
            // 
            this.btnassocier.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnassocier.Location = new System.Drawing.Point(470, 498);
            this.btnassocier.Name = "btnassocier";
            this.btnassocier.Size = new System.Drawing.Size(108, 41);
            this.btnassocier.TabIndex = 4;
            this.btnassocier.Text = "Associer";
            this.btnassocier.UseVisualStyleBackColor = true;
            this.btnassocier.Click += new System.EventHandler(this.btnassocier_Click);
            // 
            // combocours
            // 
            this.combocours.FormattingEnabled = true;
            this.combocours.Location = new System.Drawing.Point(548, 427);
            this.combocours.Name = "combocours";
            this.combocours.Size = new System.Drawing.Size(127, 24);
            this.combocours.TabIndex = 5;
            this.combocours.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.combocours_KeyPress);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(430, 78);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(608, 255);
            this.dataGridView1.TabIndex = 6;
            this.dataGridView1.CellMouseDoubleClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dataGridView1_CellMouseDoubleClick);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(342, 23);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(169, 32);
            this.label2.TabIndex = 7;
            this.label2.Text = "Nom Matiere";
            // 
            // txtmatierechoisi
            // 
            this.txtmatierechoisi.Enabled = false;
            this.txtmatierechoisi.Location = new System.Drawing.Point(655, 358);
            this.txtmatierechoisi.Name = "txtmatierechoisi";
            this.txtmatierechoisi.Size = new System.Drawing.Size(317, 22);
            this.txtmatierechoisi.TabIndex = 8;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(454, 358);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(188, 23);
            this.label3.TabIndex = 9;
            this.label3.Text = "Matiere selectionée :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(364, 425);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(161, 23);
            this.label4.TabIndex = 10;
            this.label4.Text = "Cours a associée :";
            // 
            // btnannuler
            // 
            this.btnannuler.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnannuler.Location = new System.Drawing.Point(667, 498);
            this.btnannuler.Name = "btnannuler";
            this.btnannuler.Size = new System.Drawing.Size(108, 41);
            this.btnannuler.TabIndex = 11;
            this.btnannuler.Text = "Annuler";
            this.btnannuler.UseVisualStyleBackColor = true;
            this.btnannuler.Click += new System.EventHandler(this.btnannuler_Click);
            // 
            // combodejaassocie
            // 
            this.combodejaassocie.FormattingEnabled = true;
            this.combodejaassocie.Location = new System.Drawing.Point(937, 421);
            this.combodejaassocie.Name = "combodejaassocie";
            this.combodejaassocie.Size = new System.Drawing.Size(127, 24);
            this.combodejaassocie.TabIndex = 12;
            this.combodejaassocie.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.combodejaassocie_KeyPress);
            // 
            // btndissocier
            // 
            this.btndissocier.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btndissocier.Location = new System.Drawing.Point(845, 498);
            this.btndissocier.Name = "btndissocier";
            this.btndissocier.Size = new System.Drawing.Size(108, 41);
            this.btndissocier.TabIndex = 13;
            this.btndissocier.Text = "Dissocier";
            this.btndissocier.UseVisualStyleBackColor = true;
            this.btndissocier.Click += new System.EventHandler(this.btndissocier_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(739, 421);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(192, 23);
            this.label5.TabIndex = 14;
            this.label5.Text = "Cours Deja associée :";
            // 
            // FormMatiere
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1203, 551);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.btndissocier);
            this.Controls.Add(this.combodejaassocie);
            this.Controls.Add(this.btnannuler);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtmatierechoisi);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.combocours);
            this.Controls.Add(this.btnassocier);
            this.Controls.Add(this.btneffacer);
            this.Controls.Add(this.btnajouter);
            this.Controls.Add(this.txtmatiere);
            this.Controls.Add(this.label1);
            this.Name = "FormMatiere";
            this.Text = "Gestion Matiere";
            this.Load += new System.EventHandler(this.FormMatiere_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtmatiere;
        private System.Windows.Forms.Button btnajouter;
        private System.Windows.Forms.Button btneffacer;
        private System.Windows.Forms.Button btnassocier;
        private System.Windows.Forms.ComboBox combocours;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtmatierechoisi;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnannuler;
        private System.Windows.Forms.ComboBox combodejaassocie;
        private System.Windows.Forms.Button btndissocier;
        private System.Windows.Forms.Label label5;
    }
}