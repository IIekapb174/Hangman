namespace Hangman
{
    partial class new_game
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(new_game));
            this.pictureBox = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.chances_left = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.wrong_guesses = new System.Windows.Forms.Label();
            this.give_up_button = new System.Windows.Forms.Button();
            this.word_choosen = new System.Windows.Forms.Label();
            this.output_word = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.word_name = new System.Windows.Forms.Label();
            this.a_label = new System.Windows.Forms.Label();
            this.b_label = new System.Windows.Forms.Label();
            this.c_label = new System.Windows.Forms.Label();
            this.d_label = new System.Windows.Forms.Label();
            this.e_label = new System.Windows.Forms.Label();
            this.f_label = new System.Windows.Forms.Label();
            this.g_label = new System.Windows.Forms.Label();
            this.h_label = new System.Windows.Forms.Label();
            this.i_label = new System.Windows.Forms.Label();
            this.j_label = new System.Windows.Forms.Label();
            this.k_label = new System.Windows.Forms.Label();
            this.l_label = new System.Windows.Forms.Label();
            this.m_label = new System.Windows.Forms.Label();
            this.n_label = new System.Windows.Forms.Label();
            this.p_label = new System.Windows.Forms.Label();
            this.q_label = new System.Windows.Forms.Label();
            this.r_label = new System.Windows.Forms.Label();
            this.s_label = new System.Windows.Forms.Label();
            this.t_label = new System.Windows.Forms.Label();
            this.u_label = new System.Windows.Forms.Label();
            this.v_label = new System.Windows.Forms.Label();
            this.w_label = new System.Windows.Forms.Label();
            this.x_label = new System.Windows.Forms.Label();
            this.y_label = new System.Windows.Forms.Label();
            this.z_label = new System.Windows.Forms.Label();
            this.ш_label = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label = new System.Windows.Forms.Label();
            this.ss_label = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox
            // 
            this.pictureBox.BackColor = System.Drawing.SystemColors.Control;
            this.pictureBox.Image = global::Hangman.Properties.Resources.hangman_0;
            this.pictureBox.Location = new System.Drawing.Point(12, 311);
            this.pictureBox.Name = "pictureBox";
            this.pictureBox.Size = new System.Drawing.Size(225, 234);
            this.pictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox.TabIndex = 0;
            this.pictureBox.TabStop = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(184, 30);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(71, 16);
            this.label2.TabIndex = 2;
            this.label2.Text = "Попыток :";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // chances_left
            // 
            this.chances_left.AutoSize = true;
            this.chances_left.BackColor = System.Drawing.Color.Yellow;
            this.chances_left.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chances_left.Location = new System.Drawing.Point(261, 30);
            this.chances_left.Name = "chances_left";
            this.chances_left.Size = new System.Drawing.Size(24, 16);
            this.chances_left.TabIndex = 3;
            this.chances_left.Text = "10";
            this.chances_left.Click += new System.EventHandler(this.chances_left_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Tomato;
            this.label4.Font = new System.Drawing.Font("Segoe Print", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(356, 17);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(186, 28);
            this.label4.TabIndex = 4;
            this.label4.Text = "Неправильные буквы:";
            this.label4.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // wrong_guesses
            // 
            this.wrong_guesses.AutoSize = true;
            this.wrong_guesses.Font = new System.Drawing.Font("Segoe Print", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.wrong_guesses.Location = new System.Drawing.Point(356, 58);
            this.wrong_guesses.Name = "wrong_guesses";
            this.wrong_guesses.Size = new System.Drawing.Size(111, 23);
            this.wrong_guesses.TabIndex = 5;
            this.wrong_guesses.Text = "Неправильные:";
            this.wrong_guesses.Click += new System.EventHandler(this.wrong_guesses_Click);
            // 
            // give_up_button
            // 
            this.give_up_button.BackColor = System.Drawing.Color.CornflowerBlue;
            this.give_up_button.Cursor = System.Windows.Forms.Cursors.Hand;
            this.give_up_button.Location = new System.Drawing.Point(12, 12);
            this.give_up_button.Name = "give_up_button";
            this.give_up_button.Size = new System.Drawing.Size(108, 23);
            this.give_up_button.TabIndex = 32;
            this.give_up_button.Text = "Это слово было...";
            this.give_up_button.UseVisualStyleBackColor = false;
            this.give_up_button.Click += new System.EventHandler(this.give_up_button_Click);
            // 
            // word_choosen
            // 
            this.word_choosen.AutoSize = true;
            this.word_choosen.Location = new System.Drawing.Point(314, 17);
            this.word_choosen.Name = "word_choosen";
            this.word_choosen.Size = new System.Drawing.Size(38, 13);
            this.word_choosen.TabIndex = 33;
            this.word_choosen.Text = "Слово";
            this.word_choosen.Visible = false;
            this.word_choosen.Click += new System.EventHandler(this.word_choosen_Click);
            // 
            // output_word
            // 
            this.output_word.AutoSize = true;
            this.output_word.Location = new System.Drawing.Point(314, 30);
            this.output_word.Name = "output_word";
            this.output_word.Size = new System.Drawing.Size(37, 13);
            this.output_word.TabIndex = 34;
            this.output_word.Text = "Буква";
            this.output_word.Visible = false;
            this.output_word.Click += new System.EventHandler(this.output_word_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(430, 467);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 35;
            this.label1.Text = "label1";
            this.label1.Visible = false;
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Hangman.Properties.Resources._123;
            this.pictureBox1.Location = new System.Drawing.Point(12, 49);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(225, 269);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 44;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // word_name
            // 
            this.word_name.AutoSize = true;
            this.word_name.BackColor = System.Drawing.Color.Yellow;
            this.word_name.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.word_name.Location = new System.Drawing.Point(392, 117);
            this.word_name.Name = "word_name";
            this.word_name.Size = new System.Drawing.Size(98, 31);
            this.word_name.TabIndex = 1;
            this.word_name.Text = "Слово";
            // 
            // a_label
            // 
            this.a_label.AutoSize = true;
            this.a_label.BackColor = System.Drawing.Color.CornflowerBlue;
            this.a_label.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.a_label.Cursor = System.Windows.Forms.Cursors.Hand;
            this.a_label.Font = new System.Drawing.Font("Segoe Print", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.a_label.Location = new System.Drawing.Point(349, 168);
            this.a_label.Name = "a_label";
            this.a_label.Size = new System.Drawing.Size(28, 30);
            this.a_label.TabIndex = 6;
            this.a_label.Text = "А";
            this.a_label.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.a_label.Click += new System.EventHandler(this.label_Click);
            // 
            // b_label
            // 
            this.b_label.AutoSize = true;
            this.b_label.BackColor = System.Drawing.Color.CornflowerBlue;
            this.b_label.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.b_label.Cursor = System.Windows.Forms.Cursors.Hand;
            this.b_label.Font = new System.Drawing.Font("Segoe Print", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.b_label.Location = new System.Drawing.Point(390, 168);
            this.b_label.Name = "b_label";
            this.b_label.Size = new System.Drawing.Size(25, 30);
            this.b_label.TabIndex = 7;
            this.b_label.Text = "Б";
            this.b_label.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.b_label.Click += new System.EventHandler(this.label_Click);
            // 
            // c_label
            // 
            this.c_label.AutoSize = true;
            this.c_label.BackColor = System.Drawing.Color.CornflowerBlue;
            this.c_label.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.c_label.Cursor = System.Windows.Forms.Cursors.Hand;
            this.c_label.Font = new System.Drawing.Font("Segoe Print", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.c_label.Location = new System.Drawing.Point(433, 168);
            this.c_label.Name = "c_label";
            this.c_label.Size = new System.Drawing.Size(26, 30);
            this.c_label.TabIndex = 8;
            this.c_label.Text = "В";
            this.c_label.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.c_label.Click += new System.EventHandler(this.label_Click);
            // 
            // d_label
            // 
            this.d_label.AutoSize = true;
            this.d_label.BackColor = System.Drawing.Color.CornflowerBlue;
            this.d_label.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.d_label.Cursor = System.Windows.Forms.Cursors.Hand;
            this.d_label.Font = new System.Drawing.Font("Segoe Print", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.d_label.Location = new System.Drawing.Point(473, 168);
            this.d_label.Name = "d_label";
            this.d_label.Size = new System.Drawing.Size(25, 30);
            this.d_label.TabIndex = 9;
            this.d_label.Text = "Г";
            this.d_label.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.d_label.Click += new System.EventHandler(this.label_Click);
            // 
            // e_label
            // 
            this.e_label.AutoSize = true;
            this.e_label.BackColor = System.Drawing.Color.CornflowerBlue;
            this.e_label.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.e_label.Cursor = System.Windows.Forms.Cursors.Hand;
            this.e_label.Font = new System.Drawing.Font("Segoe Print", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.e_label.Location = new System.Drawing.Point(516, 168);
            this.e_label.Name = "e_label";
            this.e_label.Size = new System.Drawing.Size(29, 30);
            this.e_label.TabIndex = 10;
            this.e_label.Text = "Д";
            this.e_label.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.e_label.Click += new System.EventHandler(this.label_Click);
            // 
            // f_label
            // 
            this.f_label.AutoSize = true;
            this.f_label.BackColor = System.Drawing.Color.CornflowerBlue;
            this.f_label.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.f_label.Cursor = System.Windows.Forms.Cursors.Hand;
            this.f_label.Font = new System.Drawing.Font("Segoe Print", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.f_label.Location = new System.Drawing.Point(349, 207);
            this.f_label.Name = "f_label";
            this.f_label.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.f_label.Size = new System.Drawing.Size(26, 30);
            this.f_label.TabIndex = 11;
            this.f_label.Text = "Е";
            this.f_label.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.f_label.Click += new System.EventHandler(this.label_Click);
            // 
            // g_label
            // 
            this.g_label.AutoSize = true;
            this.g_label.BackColor = System.Drawing.Color.CornflowerBlue;
            this.g_label.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.g_label.Cursor = System.Windows.Forms.Cursors.Hand;
            this.g_label.Font = new System.Drawing.Font("Segoe Print", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.g_label.Location = new System.Drawing.Point(390, 207);
            this.g_label.Name = "g_label";
            this.g_label.Size = new System.Drawing.Size(26, 30);
            this.g_label.TabIndex = 12;
            this.g_label.Text = "Ё";
            this.g_label.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.g_label.Click += new System.EventHandler(this.label_Click);
            // 
            // h_label
            // 
            this.h_label.AutoSize = true;
            this.h_label.BackColor = System.Drawing.Color.CornflowerBlue;
            this.h_label.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.h_label.Cursor = System.Windows.Forms.Cursors.Hand;
            this.h_label.Font = new System.Drawing.Font("Segoe Print", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.h_label.Location = new System.Drawing.Point(433, 207);
            this.h_label.Name = "h_label";
            this.h_label.Size = new System.Drawing.Size(30, 30);
            this.h_label.TabIndex = 13;
            this.h_label.Text = "Ж";
            this.h_label.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.h_label.Click += new System.EventHandler(this.label_Click);
            // 
            // i_label
            // 
            this.i_label.AutoSize = true;
            this.i_label.BackColor = System.Drawing.Color.CornflowerBlue;
            this.i_label.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.i_label.Cursor = System.Windows.Forms.Cursors.Hand;
            this.i_label.Font = new System.Drawing.Font("Segoe Print", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.i_label.Location = new System.Drawing.Point(474, 207);
            this.i_label.Name = "i_label";
            this.i_label.Size = new System.Drawing.Size(24, 30);
            this.i_label.TabIndex = 14;
            this.i_label.Text = "З";
            this.i_label.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.i_label.Click += new System.EventHandler(this.label_Click);
            // 
            // j_label
            // 
            this.j_label.AutoSize = true;
            this.j_label.BackColor = System.Drawing.Color.CornflowerBlue;
            this.j_label.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.j_label.Cursor = System.Windows.Forms.Cursors.Hand;
            this.j_label.Font = new System.Drawing.Font("Segoe Print", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.j_label.Location = new System.Drawing.Point(516, 207);
            this.j_label.Name = "j_label";
            this.j_label.Size = new System.Drawing.Size(29, 30);
            this.j_label.TabIndex = 15;
            this.j_label.Text = "И";
            this.j_label.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.j_label.Click += new System.EventHandler(this.label_Click);
            // 
            // k_label
            // 
            this.k_label.AutoSize = true;
            this.k_label.BackColor = System.Drawing.Color.CornflowerBlue;
            this.k_label.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.k_label.Cursor = System.Windows.Forms.Cursors.Hand;
            this.k_label.Font = new System.Drawing.Font("Segoe Print", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.k_label.Location = new System.Drawing.Point(349, 246);
            this.k_label.Name = "k_label";
            this.k_label.Size = new System.Drawing.Size(29, 30);
            this.k_label.TabIndex = 16;
            this.k_label.Text = "Й";
            this.k_label.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.k_label.Click += new System.EventHandler(this.label_Click);
            // 
            // l_label
            // 
            this.l_label.AutoSize = true;
            this.l_label.BackColor = System.Drawing.Color.CornflowerBlue;
            this.l_label.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.l_label.Cursor = System.Windows.Forms.Cursors.Hand;
            this.l_label.Font = new System.Drawing.Font("Segoe Print", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.l_label.Location = new System.Drawing.Point(390, 246);
            this.l_label.Name = "l_label";
            this.l_label.Size = new System.Drawing.Size(29, 30);
            this.l_label.TabIndex = 17;
            this.l_label.Text = "К";
            this.l_label.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.l_label.Click += new System.EventHandler(this.label_Click);
            // 
            // m_label
            // 
            this.m_label.AutoSize = true;
            this.m_label.BackColor = System.Drawing.Color.CornflowerBlue;
            this.m_label.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.m_label.Cursor = System.Windows.Forms.Cursors.Hand;
            this.m_label.Font = new System.Drawing.Font("Segoe Print", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.m_label.Location = new System.Drawing.Point(433, 246);
            this.m_label.Name = "m_label";
            this.m_label.Size = new System.Drawing.Size(28, 30);
            this.m_label.TabIndex = 18;
            this.m_label.Text = "Л";
            this.m_label.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.m_label.Click += new System.EventHandler(this.label_Click);
            // 
            // n_label
            // 
            this.n_label.AutoSize = true;
            this.n_label.BackColor = System.Drawing.Color.CornflowerBlue;
            this.n_label.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.n_label.Cursor = System.Windows.Forms.Cursors.Hand;
            this.n_label.Font = new System.Drawing.Font("Segoe Print", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.n_label.Location = new System.Drawing.Point(474, 246);
            this.n_label.Name = "n_label";
            this.n_label.Size = new System.Drawing.Size(30, 30);
            this.n_label.TabIndex = 19;
            this.n_label.Text = "М";
            this.n_label.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.n_label.Click += new System.EventHandler(this.label_Click);
            // 
            // p_label
            // 
            this.p_label.AutoSize = true;
            this.p_label.BackColor = System.Drawing.Color.CornflowerBlue;
            this.p_label.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.p_label.Cursor = System.Windows.Forms.Cursors.Hand;
            this.p_label.Font = new System.Drawing.Font("Segoe Print", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.p_label.Location = new System.Drawing.Point(516, 246);
            this.p_label.Name = "p_label";
            this.p_label.Size = new System.Drawing.Size(27, 30);
            this.p_label.TabIndex = 21;
            this.p_label.Text = "Н";
            this.p_label.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.p_label.Click += new System.EventHandler(this.label_Click);
            // 
            // q_label
            // 
            this.q_label.AutoSize = true;
            this.q_label.BackColor = System.Drawing.Color.CornflowerBlue;
            this.q_label.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.q_label.Cursor = System.Windows.Forms.Cursors.Hand;
            this.q_label.Font = new System.Drawing.Font("Segoe Print", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.q_label.Location = new System.Drawing.Point(349, 288);
            this.q_label.Name = "q_label";
            this.q_label.Size = new System.Drawing.Size(29, 30);
            this.q_label.TabIndex = 22;
            this.q_label.Text = "О";
            this.q_label.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.q_label.Click += new System.EventHandler(this.label_Click);
            // 
            // r_label
            // 
            this.r_label.AutoSize = true;
            this.r_label.BackColor = System.Drawing.Color.CornflowerBlue;
            this.r_label.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.r_label.Cursor = System.Windows.Forms.Cursors.Hand;
            this.r_label.Font = new System.Drawing.Font("Segoe Print", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.r_label.Location = new System.Drawing.Point(390, 288);
            this.r_label.Name = "r_label";
            this.r_label.Size = new System.Drawing.Size(26, 30);
            this.r_label.TabIndex = 23;
            this.r_label.Text = "П";
            this.r_label.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.r_label.Click += new System.EventHandler(this.label_Click);
            // 
            // s_label
            // 
            this.s_label.AutoSize = true;
            this.s_label.BackColor = System.Drawing.Color.CornflowerBlue;
            this.s_label.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.s_label.Cursor = System.Windows.Forms.Cursors.Hand;
            this.s_label.Font = new System.Drawing.Font("Segoe Print", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.s_label.Location = new System.Drawing.Point(433, 288);
            this.s_label.Name = "s_label";
            this.s_label.Size = new System.Drawing.Size(25, 30);
            this.s_label.TabIndex = 24;
            this.s_label.Text = "Р";
            this.s_label.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.s_label.Click += new System.EventHandler(this.label_Click);
            // 
            // t_label
            // 
            this.t_label.AutoSize = true;
            this.t_label.BackColor = System.Drawing.Color.CornflowerBlue;
            this.t_label.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.t_label.Cursor = System.Windows.Forms.Cursors.Hand;
            this.t_label.Font = new System.Drawing.Font("Segoe Print", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.t_label.Location = new System.Drawing.Point(474, 288);
            this.t_label.Name = "t_label";
            this.t_label.Size = new System.Drawing.Size(25, 30);
            this.t_label.TabIndex = 25;
            this.t_label.Text = "С";
            this.t_label.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.t_label.Click += new System.EventHandler(this.label_Click);
            // 
            // u_label
            // 
            this.u_label.AutoSize = true;
            this.u_label.BackColor = System.Drawing.Color.CornflowerBlue;
            this.u_label.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.u_label.Cursor = System.Windows.Forms.Cursors.Hand;
            this.u_label.Font = new System.Drawing.Font("Segoe Print", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.u_label.Location = new System.Drawing.Point(518, 288);
            this.u_label.Name = "u_label";
            this.u_label.Size = new System.Drawing.Size(25, 30);
            this.u_label.TabIndex = 26;
            this.u_label.Text = "Т";
            this.u_label.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.u_label.Click += new System.EventHandler(this.label_Click);
            // 
            // v_label
            // 
            this.v_label.AutoSize = true;
            this.v_label.BackColor = System.Drawing.Color.CornflowerBlue;
            this.v_label.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.v_label.Cursor = System.Windows.Forms.Cursors.Hand;
            this.v_label.Font = new System.Drawing.Font("Segoe Print", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.v_label.Location = new System.Drawing.Point(349, 332);
            this.v_label.Name = "v_label";
            this.v_label.Size = new System.Drawing.Size(25, 30);
            this.v_label.TabIndex = 27;
            this.v_label.Text = "У";
            this.v_label.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.v_label.Click += new System.EventHandler(this.label_Click);
            // 
            // w_label
            // 
            this.w_label.AutoSize = true;
            this.w_label.BackColor = System.Drawing.Color.CornflowerBlue;
            this.w_label.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.w_label.Cursor = System.Windows.Forms.Cursors.Hand;
            this.w_label.Font = new System.Drawing.Font("Segoe Print", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.w_label.Location = new System.Drawing.Point(390, 332);
            this.w_label.Name = "w_label";
            this.w_label.Size = new System.Drawing.Size(28, 30);
            this.w_label.TabIndex = 28;
            this.w_label.Text = "Ф";
            this.w_label.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.w_label.Click += new System.EventHandler(this.label_Click);
            // 
            // x_label
            // 
            this.x_label.AutoSize = true;
            this.x_label.BackColor = System.Drawing.Color.CornflowerBlue;
            this.x_label.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.x_label.Cursor = System.Windows.Forms.Cursors.Hand;
            this.x_label.Font = new System.Drawing.Font("Segoe Print", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.x_label.Location = new System.Drawing.Point(433, 332);
            this.x_label.Name = "x_label";
            this.x_label.Size = new System.Drawing.Size(26, 30);
            this.x_label.TabIndex = 29;
            this.x_label.Text = "Х";
            this.x_label.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.x_label.Click += new System.EventHandler(this.label_Click);
            // 
            // y_label
            // 
            this.y_label.AutoSize = true;
            this.y_label.BackColor = System.Drawing.Color.CornflowerBlue;
            this.y_label.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.y_label.Cursor = System.Windows.Forms.Cursors.Hand;
            this.y_label.Font = new System.Drawing.Font("Segoe Print", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.y_label.Location = new System.Drawing.Point(474, 332);
            this.y_label.Name = "y_label";
            this.y_label.Size = new System.Drawing.Size(28, 30);
            this.y_label.TabIndex = 30;
            this.y_label.Text = "Ц";
            this.y_label.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.y_label.Click += new System.EventHandler(this.label_Click);
            // 
            // z_label
            // 
            this.z_label.AutoSize = true;
            this.z_label.BackColor = System.Drawing.Color.CornflowerBlue;
            this.z_label.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.z_label.Cursor = System.Windows.Forms.Cursors.Hand;
            this.z_label.Font = new System.Drawing.Font("Segoe Print", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.z_label.Location = new System.Drawing.Point(518, 332);
            this.z_label.Name = "z_label";
            this.z_label.Size = new System.Drawing.Size(27, 30);
            this.z_label.TabIndex = 31;
            this.z_label.Text = "Ч";
            this.z_label.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.z_label.Click += new System.EventHandler(this.label_Click);
            // 
            // ш_label
            // 
            this.ш_label.AutoSize = true;
            this.ш_label.BackColor = System.Drawing.Color.CornflowerBlue;
            this.ш_label.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.ш_label.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ш_label.Font = new System.Drawing.Font("Segoe Print", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ш_label.Location = new System.Drawing.Point(349, 372);
            this.ш_label.Name = "ш_label";
            this.ш_label.Size = new System.Drawing.Size(34, 30);
            this.ш_label.TabIndex = 36;
            this.ш_label.Text = "Ш";
            this.ш_label.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.ш_label.Click += new System.EventHandler(this.label_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.CornflowerBlue;
            this.label5.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label5.Cursor = System.Windows.Forms.Cursors.Hand;
            this.label5.Font = new System.Drawing.Font("Segoe Print", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.Location = new System.Drawing.Point(390, 372);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(35, 30);
            this.label5.TabIndex = 37;
            this.label5.Text = "Щ";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label5.Click += new System.EventHandler(this.label_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.CornflowerBlue;
            this.label6.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label6.Cursor = System.Windows.Forms.Cursors.Hand;
            this.label6.Font = new System.Drawing.Font("Segoe Print", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label6.Location = new System.Drawing.Point(433, 372);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(27, 30);
            this.label6.TabIndex = 38;
            this.label6.Text = "Ъ";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label6.Click += new System.EventHandler(this.label_Click);
            // 
            // label
            // 
            this.label.AutoSize = true;
            this.label.BackColor = System.Drawing.Color.CornflowerBlue;
            this.label.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label.Cursor = System.Windows.Forms.Cursors.Hand;
            this.label.Font = new System.Drawing.Font("Segoe Print", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label.Location = new System.Drawing.Point(516, 372);
            this.label.Name = "label";
            this.label.Size = new System.Drawing.Size(26, 30);
            this.label.TabIndex = 39;
            this.label.Text = "Ь";
            this.label.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label.Click += new System.EventHandler(this.label_Click);
            // 
            // ss_label
            // 
            this.ss_label.AutoSize = true;
            this.ss_label.BackColor = System.Drawing.Color.CornflowerBlue;
            this.ss_label.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.ss_label.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ss_label.Font = new System.Drawing.Font("Segoe Print", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ss_label.Location = new System.Drawing.Point(391, 413);
            this.ss_label.Name = "ss_label";
            this.ss_label.Size = new System.Drawing.Size(25, 30);
            this.ss_label.TabIndex = 40;
            this.ss_label.Text = "Э";
            this.ss_label.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.ss_label.Click += new System.EventHandler(this.label_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.CornflowerBlue;
            this.label9.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label9.Cursor = System.Windows.Forms.Cursors.Hand;
            this.label9.Font = new System.Drawing.Font("Segoe Print", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label9.Location = new System.Drawing.Point(433, 413);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(30, 30);
            this.label9.TabIndex = 41;
            this.label9.Text = "Ю";
            this.label9.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label9.Click += new System.EventHandler(this.label_Click);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.BackColor = System.Drawing.Color.CornflowerBlue;
            this.label10.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label10.Cursor = System.Windows.Forms.Cursors.Hand;
            this.label10.Font = new System.Drawing.Font("Segoe Print", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label10.Location = new System.Drawing.Point(478, 413);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(26, 30);
            this.label10.TabIndex = 42;
            this.label10.Text = "Я";
            this.label10.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label10.Click += new System.EventHandler(this.label_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.CornflowerBlue;
            this.label3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.label3.Font = new System.Drawing.Font("Segoe Print", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(474, 372);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(30, 30);
            this.label3.TabIndex = 43;
            this.label3.Text = "Ы";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label3.Click += new System.EventHandler(this.label_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.CornflowerBlue;
            this.button2.BackgroundImage = global::Hangman.Properties.Resources.Background;
            this.button2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button2.Font = new System.Drawing.Font("Segoe Print", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button2.Location = new System.Drawing.Point(533, 507);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(72, 33);
            this.button2.TabIndex = 45;
            this.button2.Text = "Выход";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // new_game
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Hangman.Properties.Resources.Striped_Texture_jpg_640x640;
            this.ClientSize = new System.Drawing.Size(617, 552);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.ss_label);
            this.Controls.Add(this.label);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.ш_label);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.output_word);
            this.Controls.Add(this.word_choosen);
            this.Controls.Add(this.give_up_button);
            this.Controls.Add(this.z_label);
            this.Controls.Add(this.y_label);
            this.Controls.Add(this.x_label);
            this.Controls.Add(this.w_label);
            this.Controls.Add(this.v_label);
            this.Controls.Add(this.u_label);
            this.Controls.Add(this.t_label);
            this.Controls.Add(this.s_label);
            this.Controls.Add(this.r_label);
            this.Controls.Add(this.q_label);
            this.Controls.Add(this.p_label);
            this.Controls.Add(this.n_label);
            this.Controls.Add(this.m_label);
            this.Controls.Add(this.l_label);
            this.Controls.Add(this.k_label);
            this.Controls.Add(this.j_label);
            this.Controls.Add(this.i_label);
            this.Controls.Add(this.h_label);
            this.Controls.Add(this.g_label);
            this.Controls.Add(this.f_label);
            this.Controls.Add(this.e_label);
            this.Controls.Add(this.d_label);
            this.Controls.Add(this.c_label);
            this.Controls.Add(this.b_label);
            this.Controls.Add(this.a_label);
            this.Controls.Add(this.wrong_guesses);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.chances_left);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.word_name);
            this.Controls.Add(this.pictureBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "new_game";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Game";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label chances_left;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label wrong_guesses;
        private System.Windows.Forms.Button give_up_button;
        private System.Windows.Forms.Label word_choosen;
        private System.Windows.Forms.Label output_word;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label word_name;
        private System.Windows.Forms.Label a_label;
        private System.Windows.Forms.Label b_label;
        private System.Windows.Forms.Label c_label;
        private System.Windows.Forms.Label d_label;
        private System.Windows.Forms.Label e_label;
        private System.Windows.Forms.Label f_label;
        private System.Windows.Forms.Label g_label;
        private System.Windows.Forms.Label h_label;
        private System.Windows.Forms.Label i_label;
        private System.Windows.Forms.Label j_label;
        private System.Windows.Forms.Label k_label;
        private System.Windows.Forms.Label l_label;
        private System.Windows.Forms.Label m_label;
        private System.Windows.Forms.Label n_label;
        private System.Windows.Forms.Label p_label;
        private System.Windows.Forms.Label q_label;
        private System.Windows.Forms.Label r_label;
        private System.Windows.Forms.Label s_label;
        private System.Windows.Forms.Label t_label;
        private System.Windows.Forms.Label u_label;
        private System.Windows.Forms.Label v_label;
        private System.Windows.Forms.Label w_label;
        private System.Windows.Forms.Label x_label;
        private System.Windows.Forms.Label y_label;
        private System.Windows.Forms.Label z_label;
        private System.Windows.Forms.Label ш_label;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label;
        private System.Windows.Forms.Label ss_label;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button button2;
    }
}

