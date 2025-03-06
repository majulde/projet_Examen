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
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.panel1 = new System.Windows.Forms.Panel();
            this.comboclassassoc = new System.Windows.Forms.ComboBox();
            this.comboallclasses = new System.Windows.Forms.ComboBox();
            this.btndissocier = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.btnassocier = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.txtrecherch = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.combomatiereassoc = new System.Windows.Forms.ComboBox();
            this.comboallmatieres = new System.Windows.Forms.ComboBox();
            this.button1 = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.label11 = new System.Windows.Forms.Label();
            this.txtprofchoisi = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.btnannuler = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(63, 136);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 19);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nom";
            // 
            // txtnomprof
            // 
            this.txtnomprof.Location = new System.Drawing.Point(150, 136);
            this.txtnomprof.Name = "txtnomprof";
            this.txtnomprof.Size = new System.Drawing.Size(100, 22);
            this.txtnomprof.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(63, 196);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(68, 19);
            this.label2.TabIndex = 2;
            this.label2.Text = "Prenom";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(63, 254);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(54, 19);
            this.label3.TabIndex = 3;
            this.label3.Text = "Email";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(48, 303);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(83, 19);
            this.label4.TabIndex = 4;
            this.label4.Text = "Telephone";
            // 
            // txtprenomprof
            // 
            this.txtprenomprof.Location = new System.Drawing.Point(150, 196);
            this.txtprenomprof.Name = "txtprenomprof";
            this.txtprenomprof.Size = new System.Drawing.Size(100, 22);
            this.txtprenomprof.TabIndex = 5;
            // 
            // txtemailprof
            // 
            this.txtemailprof.Location = new System.Drawing.Point(150, 254);
            this.txtemailprof.Name = "txtemailprof";
            this.txtemailprof.Size = new System.Drawing.Size(100, 22);
            this.txtemailprof.TabIndex = 6;
            this.txtemailprof.Validating += new System.ComponentModel.CancelEventHandler(this.txtemailprof_Validating);
            // 
            // txttelephoneprof
            // 
            this.txttelephoneprof.Location = new System.Drawing.Point(150, 303);
            this.txttelephoneprof.Name = "txttelephoneprof";
            this.txttelephoneprof.Size = new System.Drawing.Size(100, 22);
            this.txttelephoneprof.TabIndex = 7;
            this.txttelephoneprof.Validating += new System.ComponentModel.CancelEventHandler(this.txttelephoneprof_Validating);
            // 
            // btnajouterprof
            // 
            this.btnajouterprof.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnajouterprof.Location = new System.Drawing.Point(326, 159);
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
            this.btneffacerprof.Location = new System.Drawing.Point(507, 159);
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
            this.btnmodifprof.Location = new System.Drawing.Point(326, 285);
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
            this.btnsupprimerprof.Location = new System.Drawing.Point(507, 285);
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
            this.dataGridView1.Location = new System.Drawing.Point(702, 114);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(546, 258);
            this.dataGridView1.TabIndex = 13;
            this.dataGridView1.CellMouseDoubleClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dataGridView1_CellMouseDoubleClick);
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.comboclassassoc);
            this.panel1.Controls.Add(this.comboallclasses);
            this.panel1.Controls.Add(this.btndissocier);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.btnassocier);
            this.panel1.Location = new System.Drawing.Point(82, 480);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(493, 157);
            this.panel1.TabIndex = 16;
            // 
            // comboclassassoc
            // 
            this.comboclassassoc.FormattingEnabled = true;
            this.comboclassassoc.Location = new System.Drawing.Point(161, 90);
            this.comboclassassoc.Name = "comboclassassoc";
            this.comboclassassoc.Size = new System.Drawing.Size(121, 24);
            this.comboclassassoc.TabIndex = 16;
            this.comboclassassoc.SelectedIndexChanged += new System.EventHandler(this.comboclassassoc_SelectedIndexChanged);
            this.comboclassassoc.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.coboclassassoc_KeyPress);
            // 
            // comboallclasses
            // 
            this.comboallclasses.FormattingEnabled = true;
            this.comboallclasses.Location = new System.Drawing.Point(161, 30);
            this.comboallclasses.Name = "comboallclasses";
            this.comboallclasses.Size = new System.Drawing.Size(121, 24);
            this.comboallclasses.TabIndex = 15;
            this.comboallclasses.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtallcours_KeyPress);
            // 
            // btndissocier
            // 
            this.btndissocier.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btndissocier.Location = new System.Drawing.Point(320, 84);
            this.btndissocier.Name = "btndissocier";
            this.btndissocier.Size = new System.Drawing.Size(96, 33);
            this.btndissocier.TabIndex = 11;
            this.btndissocier.Text = "Dissocier";
            this.btndissocier.UseVisualStyleBackColor = true;
            this.btndissocier.Click += new System.EventHandler(this.btndissocier_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(3, 90);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(152, 19);
            this.label6.TabIndex = 13;
            this.label6.Text = "Classe(s) associé(s)";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(3, 30);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(140, 19);
            this.label7.TabIndex = 12;
            this.label7.Text = "Toutes les Classes";
            // 
            // btnassocier
            // 
            this.btnassocier.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnassocier.Location = new System.Drawing.Point(320, 29);
            this.btnassocier.Name = "btnassocier";
            this.btnassocier.Size = new System.Drawing.Size(96, 33);
            this.btnassocier.TabIndex = 9;
            this.btnassocier.Text = "Associer";
            this.btnassocier.UseVisualStyleBackColor = true;
            this.btnassocier.Click += new System.EventHandler(this.btnassocier_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(78, 442);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(270, 23);
            this.label5.TabIndex = 14;
            this.label5.Text = "Association Classes Professeur";
            // 
            // txtrecherch
            // 
            this.txtrecherch.Location = new System.Drawing.Point(748, 69);
            this.txtrecherch.Name = "txtrecherch";
            this.txtrecherch.Size = new System.Drawing.Size(500, 22);
            this.txtrecherch.TabIndex = 17;
            this.txtrecherch.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(698, 69);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(44, 19);
            this.label8.TabIndex = 18;
            this.label8.Text = "Nom";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.button3);
            this.panel2.Controls.Add(this.combomatiereassoc);
            this.panel2.Controls.Add(this.comboallmatieres);
            this.panel2.Controls.Add(this.button1);
            this.panel2.Controls.Add(this.label9);
            this.panel2.Controls.Add(this.label10);
            this.panel2.Controls.Add(this.button2);
            this.panel2.Location = new System.Drawing.Point(735, 480);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(494, 157);
            this.panel2.TabIndex = 17;
            // 
            // combomatiereassoc
            // 
            this.combomatiereassoc.FormattingEnabled = true;
            this.combomatiereassoc.Location = new System.Drawing.Point(181, 90);
            this.combomatiereassoc.Name = "combomatiereassoc";
            this.combomatiereassoc.Size = new System.Drawing.Size(121, 24);
            this.combomatiereassoc.TabIndex = 16;
            this.combomatiereassoc.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.combomatiereassoc_KeyPress);
            // 
            // comboallmatieres
            // 
            this.comboallmatieres.FormattingEnabled = true;
            this.comboallmatieres.Location = new System.Drawing.Point(191, 29);
            this.comboallmatieres.Name = "comboallmatieres";
            this.comboallmatieres.Size = new System.Drawing.Size(121, 24);
            this.comboallmatieres.TabIndex = 15;
            this.comboallmatieres.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.comboallmatieres_KeyPress);
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(348, 81);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(96, 33);
            this.button1.TabIndex = 11;
            this.button1.Text = "Dissocier";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(3, 90);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(172, 19);
            this.label9.TabIndex = 13;
            this.label9.Text = "Matiere(s) associée(s)";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(3, 30);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(156, 19);
            this.label10.TabIndex = 12;
            this.label10.Text = "Matiere de la classe";
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(348, 23);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(96, 33);
            this.button2.TabIndex = 9;
            this.button2.Text = "Associer";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(874, 442);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(275, 23);
            this.label11.TabIndex = 19;
            this.label11.Text = "Association Matiere Professeur";
            // 
            // txtprofchoisi
            // 
            this.txtprofchoisi.Location = new System.Drawing.Point(402, 442);
            this.txtprofchoisi.Name = "txtprofchoisi";
            this.txtprofchoisi.ReadOnly = true;
            this.txtprofchoisi.Size = new System.Drawing.Size(407, 22);
            this.txtprofchoisi.TabIndex = 20;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(531, 411);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(177, 19);
            this.label12.TabIndex = 21;
            this.label12.Text = "Professeur selectionné";
            // 
            // btnannuler
            // 
            this.btnannuler.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnannuler.Location = new System.Drawing.Point(581, 539);
            this.btnannuler.Name = "btnannuler";
            this.btnannuler.Size = new System.Drawing.Size(143, 37);
            this.btnannuler.TabIndex = 22;
            this.btnannuler.Text = "Annuler";
            this.btnannuler.UseVisualStyleBackColor = true;
            this.btnannuler.Click += new System.EventHandler(this.btnannuler_Click);
            // 
            // button3
            // 
            this.button3.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.Location = new System.Drawing.Point(7, 24);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(162, 33);
            this.button3.TabIndex = 17;
            this.button3.Text = "Look ";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // FormProfesseur
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1260, 649);
            this.Controls.Add(this.btnannuler);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.txtprofchoisi);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.txtrecherch);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.dataGridView1);
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
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
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
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ComboBox comboclassassoc;
        private System.Windows.Forms.ComboBox comboallclasses;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btndissocier;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btnassocier;
        private System.Windows.Forms.TextBox txtrecherch;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.ComboBox combomatiereassoc;
        private System.Windows.Forms.ComboBox comboallmatieres;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TextBox txtprofchoisi;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Button btnannuler;
        private System.Windows.Forms.Button button3;
    }
}