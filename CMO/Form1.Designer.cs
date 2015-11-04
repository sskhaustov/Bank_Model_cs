namespace CMO
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
            this.components = new System.ComponentModel.Container();
            this.ADD = new System.Windows.Forms.Button();
            this.DEL = new System.Windows.Forms.Button();
            this.pool = new System.Windows.Forms.RichTextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label16 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.k2_state = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.k1_state = new System.Windows.Forms.TextBox();
            this.k1_max = new System.Windows.Forms.TextBox();
            this.k1_cur = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.label35 = new System.Windows.Forms.Label();
            this.type_req3 = new System.Windows.Forms.ComboBox();
            this.label34 = new System.Windows.Forms.Label();
            this.type_req2 = new System.Windows.Forms.ComboBox();
            this.label33 = new System.Windows.Forms.Label();
            this.label32 = new System.Windows.Forms.Label();
            this.max_num = new System.Windows.Forms.ComboBox();
            this.type_req = new System.Windows.Forms.ComboBox();
            this.label29 = new System.Windows.Forms.Label();
            this.label26 = new System.Windows.Forms.Label();
            this.label23 = new System.Windows.Forms.Label();
            this.label22 = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.k7_state = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.k6_state = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.k5_state = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.k4_state = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.k3_state = new System.Windows.Forms.TextBox();
            this.k3_max = new System.Windows.Forms.TextBox();
            this.k3_cur = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.pool2 = new System.Windows.Forms.RichTextBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.label10 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // ADD
            // 
            this.ADD.Location = new System.Drawing.Point(200, 257);
            this.ADD.Name = "ADD";
            this.ADD.Size = new System.Drawing.Size(75, 23);
            this.ADD.TabIndex = 0;
            this.ADD.Text = "Добавить";
            this.ADD.UseVisualStyleBackColor = true;
            this.ADD.Click += new System.EventHandler(this.ADD_Click);
            // 
            // DEL
            // 
            this.DEL.Location = new System.Drawing.Point(817, 478);
            this.DEL.Name = "DEL";
            this.DEL.Size = new System.Drawing.Size(75, 23);
            this.DEL.TabIndex = 1;
            this.DEL.Text = "Завершить";
            this.DEL.UseVisualStyleBackColor = true;
            this.DEL.Click += new System.EventHandler(this.DEL_Click);
            // 
            // pool
            // 
            this.pool.Location = new System.Drawing.Point(26, 168);
            this.pool.Name = "pool";
            this.pool.Size = new System.Drawing.Size(234, 285);
            this.pool.TabIndex = 2;
            this.pool.Text = "";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label16);
            this.groupBox1.Controls.Add(this.label13);
            this.groupBox1.Controls.Add(this.label12);
            this.groupBox1.Controls.Add(this.label11);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.k2_state);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.k1_state);
            this.groupBox1.Controls.Add(this.k1_max);
            this.groupBox1.Controls.Add(this.k1_cur);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.pool);
            this.groupBox1.Location = new System.Drawing.Point(0, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(281, 459);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Кассы 1-2 (XCHG)";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(144, 118);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(46, 13);
            this.label16.TabIndex = 24;
            this.label16.Text = "Клиент:";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(6, 118);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(46, 13);
            this.label13.TabIndex = 13;
            this.label13.Text = "Клиент:";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(35, 43);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(104, 13);
            this.label12.TabIndex = 12;
            this.label12.Text = "Мах. число заявок:";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(35, 17);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(103, 13);
            this.label11.TabIndex = 11;
            this.label11.Text = "Тек. число заявок:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(115, 152);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 13);
            this.label3.TabIndex = 10;
            this.label3.Text = "Очередь:";
            // 
            // k2_state
            // 
            this.k2_state.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.k2_state.Location = new System.Drawing.Point(196, 115);
            this.k2_state.Name = "k2_state";
            this.k2_state.ReadOnly = true;
            this.k2_state.Size = new System.Drawing.Size(79, 20);
            this.k2_state.TabIndex = 8;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(213, 77);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Касса 2";
            // 
            // k1_state
            // 
            this.k1_state.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.k1_state.Location = new System.Drawing.Point(58, 115);
            this.k1_state.Name = "k1_state";
            this.k1_state.ReadOnly = true;
            this.k1_state.Size = new System.Drawing.Size(80, 20);
            this.k1_state.TabIndex = 5;
            // 
            // k1_max
            // 
            this.k1_max.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.k1_max.Location = new System.Drawing.Point(147, 40);
            this.k1_max.Name = "k1_max";
            this.k1_max.ReadOnly = true;
            this.k1_max.Size = new System.Drawing.Size(86, 20);
            this.k1_max.TabIndex = 5;
            // 
            // k1_cur
            // 
            this.k1_cur.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.k1_cur.Location = new System.Drawing.Point(147, 14);
            this.k1_cur.Name = "k1_cur";
            this.k1_cur.ReadOnly = true;
            this.k1_cur.Size = new System.Drawing.Size(86, 20);
            this.k1_cur.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(74, 77);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Касса 1";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.groupBox3);
            this.groupBox2.Controls.Add(this.label29);
            this.groupBox2.Controls.Add(this.label26);
            this.groupBox2.Controls.Add(this.label23);
            this.groupBox2.Controls.Add(this.label22);
            this.groupBox2.Controls.Add(this.label19);
            this.groupBox2.Controls.Add(this.label18);
            this.groupBox2.Controls.Add(this.label17);
            this.groupBox2.Controls.Add(this.k7_state);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.k6_state);
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Controls.Add(this.k5_state);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.k4_state);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.k3_state);
            this.groupBox2.Controls.Add(this.k3_max);
            this.groupBox2.Controls.Add(this.k3_cur);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.pool2);
            this.groupBox2.Location = new System.Drawing.Point(287, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(677, 459);
            this.groupBox2.TabIndex = 4;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Кассы 3-7 (ACNT, CRED, CARD)";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.label35);
            this.groupBox3.Controls.Add(this.type_req3);
            this.groupBox3.Controls.Add(this.label34);
            this.groupBox3.Controls.Add(this.type_req2);
            this.groupBox3.Controls.Add(this.ADD);
            this.groupBox3.Controls.Add(this.label33);
            this.groupBox3.Controls.Add(this.label32);
            this.groupBox3.Controls.Add(this.max_num);
            this.groupBox3.Controls.Add(this.type_req);
            this.groupBox3.Location = new System.Drawing.Point(330, 152);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(339, 301);
            this.groupBox3.TabIndex = 38;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Новая заявка";
            // 
            // label35
            // 
            this.label35.AutoSize = true;
            this.label35.Location = new System.Drawing.Point(68, 168);
            this.label35.Name = "label35";
            this.label35.Size = new System.Drawing.Size(53, 13);
            this.label35.TabIndex = 7;
            this.label35.Text = "Заявка 3";
            // 
            // type_req3
            // 
            this.type_req3.FormattingEnabled = true;
            this.type_req3.Items.AddRange(new object[] {
            "ACNT",
            "XCHG",
            "CARD",
            "CRED"});
            this.type_req3.Location = new System.Drawing.Point(154, 165);
            this.type_req3.Name = "type_req3";
            this.type_req3.Size = new System.Drawing.Size(121, 21);
            this.type_req3.TabIndex = 6;
            // 
            // label34
            // 
            this.label34.AutoSize = true;
            this.label34.Location = new System.Drawing.Point(68, 141);
            this.label34.Name = "label34";
            this.label34.Size = new System.Drawing.Size(53, 13);
            this.label34.TabIndex = 5;
            this.label34.Text = "Заявка 2";
            // 
            // type_req2
            // 
            this.type_req2.FormattingEnabled = true;
            this.type_req2.Items.AddRange(new object[] {
            "ACNT",
            "XCHG",
            "CARD",
            "CRED"});
            this.type_req2.Location = new System.Drawing.Point(154, 138);
            this.type_req2.Name = "type_req2";
            this.type_req2.Size = new System.Drawing.Size(121, 21);
            this.type_req2.TabIndex = 4;
            // 
            // label33
            // 
            this.label33.AutoSize = true;
            this.label33.Location = new System.Drawing.Point(68, 114);
            this.label33.Name = "label33";
            this.label33.Size = new System.Drawing.Size(53, 13);
            this.label33.TabIndex = 3;
            this.label33.Text = "Заявка 1";
            // 
            // label32
            // 
            this.label32.AutoSize = true;
            this.label32.Location = new System.Drawing.Point(52, 87);
            this.label32.Name = "label32";
            this.label32.Size = new System.Drawing.Size(78, 13);
            this.label32.TabIndex = 2;
            this.label32.Text = "Число заявок";
            // 
            // max_num
            // 
            this.max_num.FormattingEnabled = true;
            this.max_num.Items.AddRange(new object[] {
            "1",
            "2",
            "3"});
            this.max_num.Location = new System.Drawing.Point(154, 84);
            this.max_num.Name = "max_num";
            this.max_num.Size = new System.Drawing.Size(121, 21);
            this.max_num.TabIndex = 1;
            // 
            // type_req
            // 
            this.type_req.Items.AddRange(new object[] {
            "ACNT",
            "XCHG",
            "CARD",
            "CRED"});
            this.type_req.Location = new System.Drawing.Point(154, 111);
            this.type_req.Name = "type_req";
            this.type_req.Size = new System.Drawing.Size(121, 21);
            this.type_req.TabIndex = 0;
            // 
            // label29
            // 
            this.label29.AutoSize = true;
            this.label29.Location = new System.Drawing.Point(543, 118);
            this.label29.Name = "label29";
            this.label29.Size = new System.Drawing.Size(46, 13);
            this.label29.TabIndex = 37;
            this.label29.Text = "Клиент:";
            // 
            // label26
            // 
            this.label26.AutoSize = true;
            this.label26.Location = new System.Drawing.Point(409, 118);
            this.label26.Name = "label26";
            this.label26.Size = new System.Drawing.Size(46, 13);
            this.label26.TabIndex = 34;
            this.label26.Text = "Клиент:";
            // 
            // label23
            // 
            this.label23.AutoSize = true;
            this.label23.Location = new System.Drawing.Point(275, 118);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(46, 13);
            this.label23.TabIndex = 31;
            this.label23.Text = "Клиент:";
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.Location = new System.Drawing.Point(143, 118);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(46, 13);
            this.label22.TabIndex = 28;
            this.label22.Text = "Клиент:";
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Location = new System.Drawing.Point(6, 118);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(46, 13);
            this.label19.TabIndex = 25;
            this.label19.Text = "Клиент:";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(208, 40);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(104, 13);
            this.label18.TabIndex = 24;
            this.label18.Text = "Мах. число заявок:";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(208, 14);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(103, 13);
            this.label17.TabIndex = 23;
            this.label17.Text = "Тек. число заявок:";
            // 
            // k7_state
            // 
            this.k7_state.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.k7_state.Location = new System.Drawing.Point(598, 115);
            this.k7_state.Name = "k7_state";
            this.k7_state.ReadOnly = true;
            this.k7_state.Size = new System.Drawing.Size(72, 20);
            this.k7_state.TabIndex = 21;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(609, 77);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(47, 13);
            this.label8.TabIndex = 19;
            this.label8.Text = "Касса 7";
            // 
            // k6_state
            // 
            this.k6_state.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.k6_state.Location = new System.Drawing.Point(459, 115);
            this.k6_state.Name = "k6_state";
            this.k6_state.ReadOnly = true;
            this.k6_state.Size = new System.Drawing.Size(77, 20);
            this.k6_state.TabIndex = 17;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(469, 77);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(47, 13);
            this.label9.TabIndex = 15;
            this.label9.Text = "Касса 6";
            // 
            // k5_state
            // 
            this.k5_state.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.k5_state.Location = new System.Drawing.Point(330, 115);
            this.k5_state.Name = "k5_state";
            this.k5_state.ReadOnly = true;
            this.k5_state.Size = new System.Drawing.Size(73, 20);
            this.k5_state.TabIndex = 13;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(339, 77);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(47, 13);
            this.label7.TabIndex = 11;
            this.label7.Text = "Касса 5";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(147, 152);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(53, 13);
            this.label4.TabIndex = 10;
            this.label4.Text = "Очередь:";
            // 
            // k4_state
            // 
            this.k4_state.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.k4_state.Location = new System.Drawing.Point(196, 115);
            this.k4_state.Name = "k4_state";
            this.k4_state.ReadOnly = true;
            this.k4_state.Size = new System.Drawing.Size(73, 20);
            this.k4_state.TabIndex = 8;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(205, 77);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(47, 13);
            this.label5.TabIndex = 6;
            this.label5.Text = "Касса 4";
            // 
            // k3_state
            // 
            this.k3_state.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.k3_state.Location = new System.Drawing.Point(58, 115);
            this.k3_state.Name = "k3_state";
            this.k3_state.ReadOnly = true;
            this.k3_state.Size = new System.Drawing.Size(79, 20);
            this.k3_state.TabIndex = 5;
            // 
            // k3_max
            // 
            this.k3_max.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.k3_max.Location = new System.Drawing.Point(321, 37);
            this.k3_max.Name = "k3_max";
            this.k3_max.ReadOnly = true;
            this.k3_max.Size = new System.Drawing.Size(107, 20);
            this.k3_max.TabIndex = 5;
            // 
            // k3_cur
            // 
            this.k3_cur.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.k3_cur.Location = new System.Drawing.Point(321, 11);
            this.k3_cur.Name = "k3_cur";
            this.k3_cur.ReadOnly = true;
            this.k3_cur.Size = new System.Drawing.Size(107, 20);
            this.k3_cur.TabIndex = 4;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(67, 77);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(47, 13);
            this.label6.TabIndex = 3;
            this.label6.Text = "Касса 3";
            // 
            // pool2
            // 
            this.pool2.Location = new System.Drawing.Point(58, 168);
            this.pool2.Name = "pool2";
            this.pool2.Size = new System.Drawing.Size(234, 285);
            this.pool2.TabIndex = 2;
            this.pool2.Text = "";
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(23, 483);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(41, 13);
            this.label10.TabIndex = 5;
            this.label10.Text = "label10";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(968, 513);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.DEL);
            this.Name = "Form1";
            this.Text = "CMO";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Form1_FormClosed);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button ADD;
        private System.Windows.Forms.Button DEL;
        private System.Windows.Forms.RichTextBox pool;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox k1_max;
        private System.Windows.Forms.TextBox k1_cur;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox k2_state;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox k1_state;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox k5_state;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox k4_state;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox k3_state;
        private System.Windows.Forms.TextBox k3_max;
        private System.Windows.Forms.TextBox k3_cur;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.RichTextBox pool2;
        private System.Windows.Forms.TextBox k7_state;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox k6_state;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.Label label23;
        private System.Windows.Forms.Label label29;
        private System.Windows.Forms.Label label26;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label label34;
        private System.Windows.Forms.ComboBox type_req2;
        private System.Windows.Forms.Label label33;
        private System.Windows.Forms.Label label32;
        private System.Windows.Forms.ComboBox max_num;
        private System.Windows.Forms.ComboBox type_req;
        private System.Windows.Forms.Label label35;
        private System.Windows.Forms.ComboBox type_req3;
    }
}

