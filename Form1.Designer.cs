namespace test6
{
    partial class Form1
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
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txt_nom = new System.Windows.Forms.TextBox();
            this.txt_profession = new System.Windows.Forms.TextBox();
            this.txt_salaire = new System.Windows.Forms.TextBox();
            this.rbt_male = new System.Windows.Forms.RadioButton();
            this.rbt_female = new System.Windows.Forms.RadioButton();
            this.CKB_tv = new System.Windows.Forms.CheckBox();
            this.CKB_CINEMA = new System.Windows.Forms.CheckBox();
            this.btn_envoyer = new System.Windows.Forms.Button();
            this.btn_annuler = new System.Windows.Forms.Button();
            this.LBL_save = new System.Windows.Forms.Label();
            this.rtbox_afficher = new System.Windows.Forms.RichTextBox();
            this.txt_genre = new System.Windows.Forms.TextBox();
            this.txt_hobbies = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.White;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(65, 76);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(156, 46);
            this.label1.TabIndex = 0;
            this.label1.Text = "NOM";
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.Color.White;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(65, 133);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(218, 46);
            this.label2.TabIndex = 0;
            this.label2.Text = "PROFESSION";
            // 
            // label3
            // 
            this.label3.BackColor = System.Drawing.Color.White;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(65, 199);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(218, 46);
            this.label3.TabIndex = 0;
            this.label3.Text = "SALAIRE";
            // 
            // label4
            // 
            this.label4.BackColor = System.Drawing.Color.White;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(65, 276);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(218, 46);
            this.label4.TabIndex = 0;
            this.label4.Text = "GENRE";
            // 
            // label5
            // 
            this.label5.BackColor = System.Drawing.Color.White;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(65, 334);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(218, 46);
            this.label5.TabIndex = 0;
            this.label5.Text = "HOBBIES";
            // 
            // txt_nom
            // 
            this.txt_nom.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.txt_nom.Font = new System.Drawing.Font("Algerian", 10.2F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_nom.Location = new System.Drawing.Point(254, 71);
            this.txt_nom.Name = "txt_nom";
            this.txt_nom.Size = new System.Drawing.Size(198, 30);
            this.txt_nom.TabIndex = 1;
            this.txt_nom.Text = "votre nom ic";
            // 
            // txt_profession
            // 
            this.txt_profession.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.txt_profession.Font = new System.Drawing.Font("Algerian", 10.2F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_profession.Location = new System.Drawing.Point(254, 128);
            this.txt_profession.Name = "txt_profession";
            this.txt_profession.Size = new System.Drawing.Size(198, 30);
            this.txt_profession.TabIndex = 1;
            this.txt_profession.Text = "votre profession ici";
            // 
            // txt_salaire
            // 
            this.txt_salaire.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.txt_salaire.Font = new System.Drawing.Font("Algerian", 10.2F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_salaire.Location = new System.Drawing.Point(254, 199);
            this.txt_salaire.Name = "txt_salaire";
            this.txt_salaire.Size = new System.Drawing.Size(198, 30);
            this.txt_salaire.TabIndex = 1;
            this.txt_salaire.Text = "votre salaire ici";
            // 
            // rbt_male
            // 
            this.rbt_male.AutoSize = true;
            this.rbt_male.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbt_male.Location = new System.Drawing.Point(237, 276);
            this.rbt_male.Name = "rbt_male";
            this.rbt_male.Size = new System.Drawing.Size(70, 21);
            this.rbt_male.TabIndex = 2;
            this.rbt_male.TabStop = true;
            this.rbt_male.Text = "MALE";
            this.rbt_male.UseVisualStyleBackColor = true;
            // 
            // rbt_female
            // 
            this.rbt_female.AutoSize = true;
            this.rbt_female.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbt_female.Location = new System.Drawing.Point(371, 276);
            this.rbt_female.Name = "rbt_female";
            this.rbt_female.Size = new System.Drawing.Size(81, 21);
            this.rbt_female.TabIndex = 2;
            this.rbt_female.TabStop = true;
            this.rbt_female.Text = "Female";
            this.rbt_female.UseVisualStyleBackColor = true;
            // 
            // CKB_tv
            // 
            this.CKB_tv.AutoSize = true;
            this.CKB_tv.Location = new System.Drawing.Point(250, 338);
            this.CKB_tv.Name = "CKB_tv";
            this.CKB_tv.Size = new System.Drawing.Size(48, 21);
            this.CKB_tv.TabIndex = 3;
            this.CKB_tv.Text = "TV";
            this.CKB_tv.UseVisualStyleBackColor = true;
            // 
            // CKB_CINEMA
            // 
            this.CKB_CINEMA.AutoSize = true;
            this.CKB_CINEMA.Location = new System.Drawing.Point(356, 338);
            this.CKB_CINEMA.Name = "CKB_CINEMA";
            this.CKB_CINEMA.Size = new System.Drawing.Size(77, 21);
            this.CKB_CINEMA.TabIndex = 3;
            this.CKB_CINEMA.Text = "Cinema";
            this.CKB_CINEMA.UseVisualStyleBackColor = true;
            // 
            // btn_envoyer
            // 
            this.btn_envoyer.BackColor = System.Drawing.Color.Black;
            this.btn_envoyer.ForeColor = System.Drawing.Color.White;
            this.btn_envoyer.Location = new System.Drawing.Point(112, 383);
            this.btn_envoyer.Name = "btn_envoyer";
            this.btn_envoyer.Size = new System.Drawing.Size(144, 48);
            this.btn_envoyer.TabIndex = 4;
            this.btn_envoyer.Text = "Envoyer";
            this.btn_envoyer.UseVisualStyleBackColor = false;
            this.btn_envoyer.Click += new System.EventHandler(this.btn_envoyer_Click);
            // 
            // btn_annuler
            // 
            this.btn_annuler.BackColor = System.Drawing.Color.Black;
            this.btn_annuler.ForeColor = System.Drawing.Color.White;
            this.btn_annuler.Location = new System.Drawing.Point(302, 383);
            this.btn_annuler.Name = "btn_annuler";
            this.btn_annuler.Size = new System.Drawing.Size(144, 48);
            this.btn_annuler.TabIndex = 4;
            this.btn_annuler.Text = "Annuler";
            this.btn_annuler.UseVisualStyleBackColor = false;
            this.btn_annuler.Click += new System.EventHandler(this.btn_annuler_Click);
            // 
            // LBL_save
            // 
            this.LBL_save.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.LBL_save.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.LBL_save.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LBL_save.Location = new System.Drawing.Point(-4, 9);
            this.LBL_save.Name = "LBL_save";
            this.LBL_save.Size = new System.Drawing.Size(1015, 38);
            this.LBL_save.TabIndex = 5;
            this.LBL_save.Text = "ENREGISTREMENT";
            this.LBL_save.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.LBL_save.Click += new System.EventHandler(this.LBL_save_Click);
            // 
            // rtbox_afficher
            // 
            this.rtbox_afficher.Font = new System.Drawing.Font("Algerian", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rtbox_afficher.Location = new System.Drawing.Point(514, 50);
            this.rtbox_afficher.Name = "rtbox_afficher";
            this.rtbox_afficher.Size = new System.Drawing.Size(442, 381);
            this.rtbox_afficher.TabIndex = 6;
            this.rtbox_afficher.Text = "";
            this.rtbox_afficher.TextChanged += new System.EventHandler(this.rtbox_afficher_TextChanged);
            // 
            // txt_genre
            // 
            this.txt_genre.BackColor = System.Drawing.Color.White;
            this.txt_genre.Font = new System.Drawing.Font("Algerian", 16.2F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_genre.Location = new System.Drawing.Point(229, 264);
            this.txt_genre.Name = "txt_genre";
            this.txt_genre.Size = new System.Drawing.Size(263, 43);
            this.txt_genre.TabIndex = 1;
            // 
            // txt_hobbies
            // 
            this.txt_hobbies.BackColor = System.Drawing.Color.White;
            this.txt_hobbies.Font = new System.Drawing.Font("Algerian", 16.2F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_hobbies.Location = new System.Drawing.Point(229, 325);
            this.txt_hobbies.Name = "txt_hobbies";
            this.txt_hobbies.Size = new System.Drawing.Size(263, 43);
            this.txt_hobbies.TabIndex = 1;
            // 
            // label6
            // 
            this.label6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.label6.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(-4, 475);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(1015, 38);
            this.label6.TabIndex = 5;
            this.label6.Text = "KAKABI CHRISTIAN 😎👽👽";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label6.Click += new System.EventHandler(this.LBL_save_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1011, 522);
            this.Controls.Add(this.rtbox_afficher);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.LBL_save);
            this.Controls.Add(this.btn_annuler);
            this.Controls.Add(this.btn_envoyer);
            this.Controls.Add(this.CKB_CINEMA);
            this.Controls.Add(this.CKB_tv);
            this.Controls.Add(this.rbt_female);
            this.Controls.Add(this.rbt_male);
            this.Controls.Add(this.txt_hobbies);
            this.Controls.Add(this.txt_genre);
            this.Controls.Add(this.txt_salaire);
            this.Controls.Add(this.txt_profession);
            this.Controls.Add(this.txt_nom);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txt_nom;
        private System.Windows.Forms.TextBox txt_profession;
        private System.Windows.Forms.TextBox txt_salaire;
        private System.Windows.Forms.RadioButton rbt_male;
        private System.Windows.Forms.RadioButton rbt_female;
        private System.Windows.Forms.CheckBox CKB_tv;
        private System.Windows.Forms.CheckBox CKB_CINEMA;
        private System.Windows.Forms.Button btn_envoyer;
        private System.Windows.Forms.Button btn_annuler;
        private System.Windows.Forms.Label LBL_save;
        private System.Windows.Forms.RichTextBox rtbox_afficher;
        private System.Windows.Forms.TextBox txt_genre;
        private System.Windows.Forms.TextBox txt_hobbies;
        private System.Windows.Forms.Label label6;
    }
}

