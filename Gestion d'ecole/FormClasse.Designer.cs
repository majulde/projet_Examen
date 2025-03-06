namespace Gestion_d_ecole
{
    partial class FormClasse
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
            this.txtclassenom = new System.Windows.Forms.TextBox();
            this.btnajouter = new System.Windows.Forms.Button();
            this.btneffacer = new System.Windows.Forms.Button();
            this.btnmodifier = new System.Windows.Forms.Button();
            this.btnsupprimer = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Classe = new System.Windows.Forms.Label();
            this.txtClassechoisi = new System.Windows.Forms.TextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.comboallcours = new System.Windows.Forms.ComboBox();
            this.combocoursassoc = new System.Windows.Forms.ComboBox();
            this.btndissocier = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.btnassocier = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtrecherch = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(74, 137);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 19);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nom";
            // 
            // txtclassenom
            // 
            this.txtclassenom.Location = new System.Drawing.Point(181, 143);
            this.txtclassenom.Multiline = true;
            this.txtclassenom.Name = "txtclassenom";
            this.txtclassenom.Size = new System.Drawing.Size(130, 31);
            this.txtclassenom.TabIndex = 1;
            this.txtclassenom.TextChanged += new System.EventHandler(this.txtclassenom_TextChanged);
            // 
            // btnajouter
            // 
            this.btnajouter.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnajouter.Location = new System.Drawing.Point(51, 225);
            this.btnajouter.Name = "btnajouter";
            this.btnajouter.Size = new System.Drawing.Size(96, 33);
            this.btnajouter.TabIndex = 2;
            this.btnajouter.Text = "Ajouter";
            this.btnajouter.UseVisualStyleBackColor = true;
            this.btnajouter.Click += new System.EventHandler(this.btnajouter_Click);
            // 
            // btneffacer
            // 
            this.btneffacer.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btneffacer.Location = new System.Drawing.Point(207, 225);
            this.btneffacer.Name = "btneffacer";
            this.btneffacer.Size = new System.Drawing.Size(96, 33);
            this.btneffacer.TabIndex = 3;
            this.btneffacer.Text = "Effacer";
            this.btneffacer.UseVisualStyleBackColor = true;
            this.btneffacer.Click += new System.EventHandler(this.btneffacer_Click);
            // 
            // btnmodifier
            // 
            this.btnmodifier.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnmodifier.Location = new System.Drawing.Point(51, 309);
            this.btnmodifier.Name = "btnmodifier";
            this.btnmodifier.Size = new System.Drawing.Size(96, 33);
            this.btnmodifier.TabIndex = 4;
            this.btnmodifier.Text = "Modifier";
            this.btnmodifier.UseVisualStyleBackColor = true;
            this.btnmodifier.Click += new System.EventHandler(this.btnmodifier_Click);
            // 
            // btnsupprimer
            // 
            this.btnsupprimer.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnsupprimer.Location = new System.Drawing.Point(207, 309);
            this.btnsupprimer.Name = "btnsupprimer";
            this.btnsupprimer.Size = new System.Drawing.Size(104, 33);
            this.btnsupprimer.TabIndex = 5;
            this.btnsupprimer.Text = "Supprimer";
            this.btnsupprimer.UseVisualStyleBackColor = true;
            this.btnsupprimer.Click += new System.EventHandler(this.btnsupprimer_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(335, 105);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(324, 411);
            this.dataGridView1.TabIndex = 6;
            this.dataGridView1.CellMouseDoubleClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dataGridView1_CellMouseDoubleClick);
            // 
            // Classe
            // 
            this.Classe.AutoSize = true;
            this.Classe.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Classe.Location = new System.Drawing.Point(718, 155);
            this.Classe.Name = "Classe";
            this.Classe.Size = new System.Drawing.Size(44, 19);
            this.Classe.TabIndex = 7;
            this.Classe.Text = "Nom";
            // 
            // txtClassechoisi
            // 
            this.txtClassechoisi.Location = new System.Drawing.Point(793, 154);
            this.txtClassechoisi.Multiline = true;
            this.txtClassechoisi.Name = "txtClassechoisi";
            this.txtClassechoisi.ReadOnly = true;
            this.txtClassechoisi.Size = new System.Drawing.Size(130, 31);
            this.txtClassechoisi.TabIndex = 8;
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(995, 148);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(96, 33);
            this.button2.TabIndex = 10;
            this.button2.Text = "Annuler";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.comboallcours);
            this.panel2.Controls.Add(this.combocoursassoc);
            this.panel2.Controls.Add(this.btndissocier);
            this.panel2.Controls.Add(this.label7);
            this.panel2.Controls.Add(this.label8);
            this.panel2.Controls.Add(this.btnassocier);
            this.panel2.Location = new System.Drawing.Point(683, 203);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(411, 313);
            this.panel2.TabIndex = 17;
            // 
            // comboallcours
            // 
            this.comboallcours.FormattingEnabled = true;
            this.comboallcours.Location = new System.Drawing.Point(172, 101);
            this.comboallcours.Name = "comboallcours";
            this.comboallcours.Size = new System.Drawing.Size(121, 24);
            this.comboallcours.TabIndex = 16;
            this.comboallcours.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.comboallcours_KeyPress);
            // 
            // combocoursassoc
            // 
            this.combocoursassoc.FormattingEnabled = true;
            this.combocoursassoc.Location = new System.Drawing.Point(172, 220);
            this.combocoursassoc.Name = "combocoursassoc";
            this.combocoursassoc.Size = new System.Drawing.Size(121, 24);
            this.combocoursassoc.TabIndex = 15;
            this.combocoursassoc.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.comboBox4_KeyPress);
            // 
            // btndissocier
            // 
            this.btndissocier.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btndissocier.Location = new System.Drawing.Point(312, 214);
            this.btndissocier.Name = "btndissocier";
            this.btndissocier.Size = new System.Drawing.Size(96, 33);
            this.btndissocier.TabIndex = 11;
            this.btndissocier.Text = "Dissocier";
            this.btndissocier.UseVisualStyleBackColor = true;
            this.btndissocier.Click += new System.EventHandler(this.btndissocier_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(22, 106);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(112, 19);
            this.label7.TabIndex = 13;
            this.label7.Text = "Tous les cours";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(11, 221);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(145, 19);
            this.label8.TabIndex = 12;
            this.label8.Text = "Cours deja associe";
            // 
            // btnassocier
            // 
            this.btnassocier.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnassocier.Location = new System.Drawing.Point(312, 95);
            this.btnassocier.Name = "btnassocier";
            this.btnassocier.Size = new System.Drawing.Size(96, 33);
            this.btnassocier.TabIndex = 9;
            this.btnassocier.Text = "Associer";
            this.btnassocier.UseVisualStyleBackColor = true;
            this.btnassocier.Click += new System.EventHandler(this.btnassocier_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(776, 59);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(221, 23);
            this.label6.TabIndex = 14;
            this.label6.Text = "Association Cours Classe";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(399, 72);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 19);
            this.label2.TabIndex = 18;
            this.label2.Text = "Nom";
            // 
            // txtrecherch
            // 
            this.txtrecherch.Location = new System.Drawing.Point(470, 69);
            this.txtrecherch.Name = "txtrecherch";
            this.txtrecherch.Size = new System.Drawing.Size(130, 22);
            this.txtrecherch.TabIndex = 19;
            this.txtrecherch.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // FormClasse
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1183, 606);
            this.Controls.Add(this.txtrecherch);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.txtClassechoisi);
            this.Controls.Add(this.Classe);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btnsupprimer);
            this.Controls.Add(this.btnmodifier);
            this.Controls.Add(this.btneffacer);
            this.Controls.Add(this.btnajouter);
            this.Controls.Add(this.txtclassenom);
            this.Controls.Add(this.label1);
            this.Name = "FormClasse";
            this.Text = "FormClasse";
            this.Load += new System.EventHandler(this.FormClasse_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtclassenom;
        private System.Windows.Forms.Button btnajouter;
        private System.Windows.Forms.Button btneffacer;
        private System.Windows.Forms.Button btnmodifier;
        private System.Windows.Forms.Button btnsupprimer;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label Classe;
        private System.Windows.Forms.TextBox txtClassechoisi;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.ComboBox comboallcours;
        private System.Windows.Forms.ComboBox combocoursassoc;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btndissocier;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button btnassocier;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtrecherch;
    }
}