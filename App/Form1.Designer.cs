
namespace Laba10
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.panel1 = new System.Windows.Forms.Panel();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.gB = new System.Windows.Forms.GroupBox();
            this.l_d = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.nUD_timer = new System.Windows.Forms.NumericUpDown();
            this.label12 = new System.Windows.Forms.Label();
            this.b_Сreate_graph = new System.Windows.Forms.Button();
            this.l_n = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.l_y = new System.Windows.Forms.Label();
            this.l_x = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.b_restart = new System.Windows.Forms.Button();
            this.b_pause = new System.Windows.Forms.Button();
            this.b_start = new System.Windows.Forms.Button();
            this.nUD_r = new System.Windows.Forms.NumericUpDown();
            this.label8 = new System.Windows.Forms.Label();
            this.nUD_step = new System.Windows.Forms.NumericUpDown();
            this.label7 = new System.Windows.Forms.Label();
            this.nUD_finish_y = new System.Windows.Forms.NumericUpDown();
            this.label5 = new System.Windows.Forms.Label();
            this.nUD_finish_x = new System.Windows.Forms.NumericUpDown();
            this.label6 = new System.Windows.Forms.Label();
            this.nUD_start_y = new System.Windows.Forms.NumericUpDown();
            this.label4 = new System.Windows.Forms.Label();
            this.nUD_start_x = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.gB.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nUD_timer)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nUD_r)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nUD_step)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nUD_finish_y)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nUD_finish_x)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nUD_start_y)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nUD_start_x)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(580, 523);
            this.panel1.TabIndex = 0;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // gB
            // 
            this.gB.Controls.Add(this.l_d);
            this.gB.Controls.Add(this.label14);
            this.gB.Controls.Add(this.nUD_timer);
            this.gB.Controls.Add(this.label12);
            this.gB.Controls.Add(this.b_Сreate_graph);
            this.gB.Controls.Add(this.l_n);
            this.gB.Controls.Add(this.label11);
            this.gB.Controls.Add(this.l_y);
            this.gB.Controls.Add(this.l_x);
            this.gB.Controls.Add(this.label10);
            this.gB.Controls.Add(this.label9);
            this.gB.Controls.Add(this.b_restart);
            this.gB.Controls.Add(this.b_pause);
            this.gB.Controls.Add(this.b_start);
            this.gB.Controls.Add(this.nUD_r);
            this.gB.Controls.Add(this.label8);
            this.gB.Controls.Add(this.nUD_step);
            this.gB.Controls.Add(this.label7);
            this.gB.Controls.Add(this.nUD_finish_y);
            this.gB.Controls.Add(this.label5);
            this.gB.Controls.Add(this.nUD_finish_x);
            this.gB.Controls.Add(this.label6);
            this.gB.Controls.Add(this.nUD_start_y);
            this.gB.Controls.Add(this.label4);
            this.gB.Controls.Add(this.nUD_start_x);
            this.gB.Controls.Add(this.label3);
            this.gB.Controls.Add(this.label2);
            this.gB.Controls.Add(this.label1);
            this.gB.Dock = System.Windows.Forms.DockStyle.Right;
            this.gB.Location = new System.Drawing.Point(586, 0);
            this.gB.Name = "gB";
            this.gB.Size = new System.Drawing.Size(302, 523);
            this.gB.TabIndex = 1;
            this.gB.TabStop = false;
            // 
            // l_d
            // 
            this.l_d.AutoSize = true;
            this.l_d.Location = new System.Drawing.Point(124, 443);
            this.l_d.Name = "l_d";
            this.l_d.Size = new System.Drawing.Size(17, 20);
            this.l_d.TabIndex = 27;
            this.l_d.Text = "0";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(27, 443);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(91, 20);
            this.label14.TabIndex = 26;
            this.label14.Text = "Расстояние:";
            // 
            // nUD_timer
            // 
            this.nUD_timer.Location = new System.Drawing.Point(98, 294);
            this.nUD_timer.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.nUD_timer.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nUD_timer.Name = "nUD_timer";
            this.nUD_timer.Size = new System.Drawing.Size(90, 27);
            this.nUD_timer.TabIndex = 25;
            this.nUD_timer.Value = new decimal(new int[] {
            100,
            0,
            0,
            0});
            this.nUD_timer.ValueChanged += new System.EventHandler(this.nUD_timer_ValueChanged);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(27, 296);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(65, 20);
            this.label12.TabIndex = 24;
            this.label12.Text = "Таймер:";
            // 
            // b_Сreate_graph
            // 
            this.b_Сreate_graph.Location = new System.Drawing.Point(83, 475);
            this.b_Сreate_graph.Name = "b_Сreate_graph";
            this.b_Сreate_graph.Size = new System.Drawing.Size(149, 37);
            this.b_Сreate_graph.TabIndex = 23;
            this.b_Сreate_graph.Text = "Создать график";
            this.b_Сreate_graph.UseVisualStyleBackColor = true;
            this.b_Сreate_graph.Click += new System.EventHandler(this.b_Сreate_graph_Click);
            // 
            // l_n
            // 
            this.l_n.AutoSize = true;
            this.l_n.Location = new System.Drawing.Point(109, 418);
            this.l_n.Name = "l_n";
            this.l_n.Size = new System.Drawing.Size(17, 20);
            this.l_n.TabIndex = 22;
            this.l_n.Text = "0";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(27, 418);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(76, 20);
            this.label11.TabIndex = 21;
            this.label11.Text = "Точность:";
            // 
            // l_y
            // 
            this.l_y.AutoSize = true;
            this.l_y.Location = new System.Drawing.Point(190, 386);
            this.l_y.Name = "l_y";
            this.l_y.Size = new System.Drawing.Size(17, 20);
            this.l_y.TabIndex = 20;
            this.l_y.Text = "0";
            // 
            // l_x
            // 
            this.l_x.AutoSize = true;
            this.l_x.Location = new System.Drawing.Point(54, 386);
            this.l_x.Name = "l_x";
            this.l_x.Size = new System.Drawing.Size(17, 20);
            this.l_x.TabIndex = 19;
            this.l_x.Text = "0";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(163, 386);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(20, 20);
            this.label10.TabIndex = 18;
            this.label10.Text = "Y:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(27, 386);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(21, 20);
            this.label9.TabIndex = 17;
            this.label9.Text = "X:";
            // 
            // b_restart
            // 
            this.b_restart.Location = new System.Drawing.Point(164, 340);
            this.b_restart.Name = "b_restart";
            this.b_restart.Size = new System.Drawing.Size(116, 29);
            this.b_restart.TabIndex = 16;
            this.b_restart.Text = "Возобновить";
            this.b_restart.UseVisualStyleBackColor = true;
            this.b_restart.Click += new System.EventHandler(this.b_restart_Click);
            // 
            // b_pause
            // 
            this.b_pause.Location = new System.Drawing.Point(92, 340);
            this.b_pause.Name = "b_pause";
            this.b_pause.Size = new System.Drawing.Size(67, 29);
            this.b_pause.TabIndex = 15;
            this.b_pause.Text = "Пауза";
            this.b_pause.UseVisualStyleBackColor = true;
            this.b_pause.Click += new System.EventHandler(this.b_pause_Click);
            // 
            // b_start
            // 
            this.b_start.Location = new System.Drawing.Point(27, 340);
            this.b_start.Name = "b_start";
            this.b_start.Size = new System.Drawing.Size(59, 29);
            this.b_start.TabIndex = 14;
            this.b_start.Text = "Старт";
            this.b_start.UseVisualStyleBackColor = true;
            this.b_start.Click += new System.EventHandler(this.b_start_Click);
            // 
            // nUD_r
            // 
            this.nUD_r.Location = new System.Drawing.Point(173, 247);
            this.nUD_r.Maximum = new decimal(new int[] {
            2147483647,
            0,
            0,
            0});
            this.nUD_r.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nUD_r.Name = "nUD_r";
            this.nUD_r.Size = new System.Drawing.Size(90, 27);
            this.nUD_r.TabIndex = 13;
            this.nUD_r.Value = new decimal(new int[] {
            40,
            0,
            0,
            0});
            this.nUD_r.ValueChanged += new System.EventHandler(this.nUD_n_ValueChanged);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(27, 249);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(140, 20);
            this.label8.TabIndex = 12;
            this.label8.Text = "Радиус попадания:";
            // 
            // nUD_step
            // 
            this.nUD_step.Location = new System.Drawing.Point(73, 203);
            this.nUD_step.Maximum = new decimal(new int[] {
            2147483647,
            0,
            0,
            0});
            this.nUD_step.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nUD_step.Name = "nUD_step";
            this.nUD_step.Size = new System.Drawing.Size(90, 27);
            this.nUD_step.TabIndex = 11;
            this.nUD_step.Value = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.nUD_step.ValueChanged += new System.EventHandler(this.nUD_step_ValueChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(27, 205);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(40, 20);
            this.label7.TabIndex = 10;
            this.label7.Text = "Шаг:";
            // 
            // nUD_finish_y
            // 
            this.nUD_finish_y.Location = new System.Drawing.Point(190, 147);
            this.nUD_finish_y.Maximum = new decimal(new int[] {
            2147483647,
            0,
            0,
            0});
            this.nUD_finish_y.Minimum = new decimal(new int[] {
            -2147483648,
            0,
            0,
            -2147483648});
            this.nUD_finish_y.Name = "nUD_finish_y";
            this.nUD_finish_y.Size = new System.Drawing.Size(90, 27);
            this.nUD_finish_y.TabIndex = 9;
            this.nUD_finish_y.Value = new decimal(new int[] {
            500,
            0,
            0,
            0});
            this.nUD_finish_y.ValueChanged += new System.EventHandler(this.nUD_finish_y_ValueChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(163, 149);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(20, 20);
            this.label5.TabIndex = 8;
            this.label5.Text = "Y:";
            // 
            // nUD_finish_x
            // 
            this.nUD_finish_x.Location = new System.Drawing.Point(54, 147);
            this.nUD_finish_x.Maximum = new decimal(new int[] {
            2147483647,
            0,
            0,
            0});
            this.nUD_finish_x.Minimum = new decimal(new int[] {
            -2147483648,
            0,
            0,
            -2147483648});
            this.nUD_finish_x.Name = "nUD_finish_x";
            this.nUD_finish_x.Size = new System.Drawing.Size(90, 27);
            this.nUD_finish_x.TabIndex = 7;
            this.nUD_finish_x.Value = new decimal(new int[] {
            700,
            0,
            0,
            0});
            this.nUD_finish_x.ValueChanged += new System.EventHandler(this.nUD_finish_x_ValueChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(27, 149);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(21, 20);
            this.label6.TabIndex = 6;
            this.label6.Text = "X:";
            // 
            // nUD_start_y
            // 
            this.nUD_start_y.Location = new System.Drawing.Point(190, 73);
            this.nUD_start_y.Maximum = new decimal(new int[] {
            2147483647,
            0,
            0,
            0});
            this.nUD_start_y.Minimum = new decimal(new int[] {
            -2147483648,
            0,
            0,
            -2147483648});
            this.nUD_start_y.Name = "nUD_start_y";
            this.nUD_start_y.Size = new System.Drawing.Size(90, 27);
            this.nUD_start_y.TabIndex = 5;
            this.nUD_start_y.ValueChanged += new System.EventHandler(this.nUD_start_y_ValueChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(163, 75);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(20, 20);
            this.label4.TabIndex = 4;
            this.label4.Text = "Y:";
            // 
            // nUD_start_x
            // 
            this.nUD_start_x.Location = new System.Drawing.Point(54, 73);
            this.nUD_start_x.Maximum = new decimal(new int[] {
            2147483647,
            0,
            0,
            0});
            this.nUD_start_x.Minimum = new decimal(new int[] {
            -2147483648,
            0,
            0,
            -2147483648});
            this.nUD_start_x.Name = "nUD_start_x";
            this.nUD_start_x.Size = new System.Drawing.Size(90, 27);
            this.nUD_start_x.TabIndex = 3;
            this.nUD_start_x.ValueChanged += new System.EventHandler(this.nUD_start_x_ValueChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(27, 75);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(21, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "X:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(27, 116);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(175, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Конечная точка (синия)";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(27, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(197, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Начальная точка (красная)";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(888, 523);
            this.Controls.Add(this.gB);
            this.Controls.Add(this.panel1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.gB.ResumeLayout(false);
            this.gB.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nUD_timer)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nUD_r)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nUD_step)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nUD_finish_y)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nUD_finish_x)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nUD_start_y)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nUD_start_x)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.GroupBox gB;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown nUD_start_x;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.NumericUpDown nUD_finish_y;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.NumericUpDown nUD_finish_x;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.NumericUpDown nUD_start_y;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label l_y;
        private System.Windows.Forms.Label l_x;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button b_restart;
        private System.Windows.Forms.Button b_pause;
        private System.Windows.Forms.Button b_start;
        private System.Windows.Forms.NumericUpDown nUD_r;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.NumericUpDown nUD_step;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button b_Сreate_graph;
        private System.Windows.Forms.Label l_n;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.NumericUpDown nUD_timer;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label l_d;
        private System.Windows.Forms.Label label14;
    }
}

