namespace Gestion_d_ecole
{
    partial class FormNotes
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.btnajouter = new System.Windows.Forms.Button();
            this.txtclasse = new System.Windows.Forms.ComboBox();
            this.txtcours = new System.Windows.Forms.ComboBox();
            this.txtmatiere = new System.Windows.Forms.ComboBox();
            this.txtetudiant = new System.Windows.Forms.TextBox();
            this.txtnote = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(514, 86);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(695, 294);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellMouseDoubleClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dataGridView1_CellMouseDoubleClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(72, 51);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "Classe";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(67, 120);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "Cours";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(61, 181);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(69, 20);
            this.label3.TabIndex = 3;
            this.label3.Text = "Matiere";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(61, 250);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(76, 20);
            this.label4.TabIndex = 4;
            this.label4.Text = "Etudiant";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(66, 312);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(46, 20);
            this.label5.TabIndex = 5;
            this.label5.Text = "Note";
            // 
            // btnajouter
            // 
            this.btnajouter.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnajouter.Location = new System.Drawing.Point(153, 360);
            this.btnajouter.Name = "btnajouter";
            this.btnajouter.Size = new System.Drawing.Size(199, 43);
            this.btnajouter.TabIndex = 6;
            this.btnajouter.Text = "Ajouter la note";
            this.btnajouter.UseVisualStyleBackColor = true;
            // 
            // txtclasse
            // 
            this.txtclasse.FormattingEnabled = true;
            this.txtclasse.Location = new System.Drawing.Point(175, 47);
            this.txtclasse.Name = "txtclasse";
            this.txtclasse.Size = new System.Drawing.Size(121, 24);
            this.txtclasse.TabIndex = 7;
            this.txtclasse.SelectedIndexChanged += new System.EventHandler(this.txtclasse_SelectedIndexChanged);
            this.txtclasse.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtclasse_KeyPress);
            // 
            // txtcours
            // 
            this.txtcours.FormattingEnabled = true;
            this.txtcours.Location = new System.Drawing.Point(175, 116);
            this.txtcours.Name = "txtcours";
            this.txtcours.Size = new System.Drawing.Size(121, 24);
            this.txtcours.TabIndex = 8;
            this.txtcours.SelectedIndexChanged += new System.EventHandler(this.comboBox2_SelectedIndexChanged);
            this.txtcours.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtcours_KeyPress);
            // 
            // txtmatiere
            // 
            this.txtmatiere.FormattingEnabled = true;
            this.txtmatiere.Location = new System.Drawing.Point(175, 181);
            this.txtmatiere.Name = "txtmatiere";
            this.txtmatiere.Size = new System.Drawing.Size(121, 24);
            this.txtmatiere.TabIndex = 9;
            this.txtmatiere.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtmatiere_KeyPress);
            // 
            // txtetudiant
            // 
            this.txtetudiant.Location = new System.Drawing.Point(175, 248);
            this.txtetudiant.Name = "txtetudiant";
            this.txtetudiant.ReadOnly = true;
            this.txtetudiant.Size = new System.Drawing.Size(187, 22);
            this.txtetudiant.TabIndex = 10;
            // 
            // txtnote
            // 
            this.txtnote.Location = new System.Drawing.Point(175, 295);
            this.txtnote.Multiline = true;
            this.txtnote.Name = "txtnote";
            this.txtnote.Size = new System.Drawing.Size(187, 37);
            this.txtnote.TabIndex = 11;
            // 
            // FormNotes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1221, 450);
            this.Controls.Add(this.txtnote);
            this.Controls.Add(this.txtetudiant);
            this.Controls.Add(this.txtmatiere);
            this.Controls.Add(this.txtcours);
            this.Controls.Add(this.txtclasse);
            this.Controls.Add(this.btnajouter);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridView1);
            this.Name = "FormNotes";
            this.Text = "FormNotes";
            this.Load += new System.EventHandler(this.FormNotes_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnajouter;
        private System.Windows.Forms.ComboBox txtclasse;
        private System.Windows.Forms.ComboBox txtcours;
        private System.Windows.Forms.ComboBox txtmatiere;
        private System.Windows.Forms.TextBox txtetudiant;
        private System.Windows.Forms.TextBox txtnote;
    }
}