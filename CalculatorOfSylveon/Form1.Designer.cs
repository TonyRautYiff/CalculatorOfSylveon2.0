namespace CalculatorOfSylveon
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
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            otchet = new TextBox();
            btn1 = new Button();
            btn2 = new Button();
            btn3 = new Button();
            btn4 = new Button();
            btn5 = new Button();
            btn6 = new Button();
            btn7 = new Button();
            btn8 = new Button();
            btn9 = new Button();
            btn0 = new Button();
            btnclear = new Button();
            btnplus = new Button();
            btnminus = new Button();
            btnmultiply = new Button();
            btndivide = new Button();
            btnresult = new Button();
            sylveonspack = new GroupBox();
            pictureBox4 = new PictureBox();
            pictureBox3 = new PictureBox();
            pictureBox2 = new PictureBox();
            pictureBox1 = new PictureBox();
            button1 = new Button();
            monthCalendar1 = new MonthCalendar();
            timer1 = new System.Windows.Forms.Timer(components);
            labeltime = new Label();
            steamtime = new System.Windows.Forms.Timer(components);
            labelsteam = new Label();
            sylveonspack.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // otchet
            // 
            otchet.Font = new Font("Comic Sans MS", 27.75F, FontStyle.Regular, GraphicsUnit.Point);
            otchet.Location = new Point(12, 22);
            otchet.Multiline = true;
            otchet.Name = "otchet";
            otchet.Size = new Size(508, 59);
            otchet.TabIndex = 4;
            otchet.TextChanged += textBox1_TextChanged;
            // 
            // btn1
            // 
            btn1.Location = new Point(320, 100);
            btn1.Name = "btn1";
            btn1.Size = new Size(56, 51);
            btn1.TabIndex = 5;
            btn1.Text = "1";
            btn1.UseVisualStyleBackColor = true;
            btn1.Click += button5_Click;
            // 
            // btn2
            // 
            btn2.Location = new Point(382, 100);
            btn2.Name = "btn2";
            btn2.Size = new Size(56, 51);
            btn2.TabIndex = 6;
            btn2.Text = "2";
            btn2.UseVisualStyleBackColor = true;
            btn2.Click += button6_Click;
            // 
            // btn3
            // 
            btn3.Location = new Point(444, 100);
            btn3.Name = "btn3";
            btn3.Size = new Size(56, 51);
            btn3.TabIndex = 7;
            btn3.Text = "3";
            btn3.UseVisualStyleBackColor = true;
            btn3.Click += button7_Click;
            // 
            // btn4
            // 
            btn4.Location = new Point(320, 157);
            btn4.Name = "btn4";
            btn4.Size = new Size(56, 51);
            btn4.TabIndex = 8;
            btn4.Text = "4";
            btn4.UseVisualStyleBackColor = true;
            btn4.Click += button8_Click;
            // 
            // btn5
            // 
            btn5.Location = new Point(382, 157);
            btn5.Name = "btn5";
            btn5.Size = new Size(56, 51);
            btn5.TabIndex = 9;
            btn5.Text = "5";
            btn5.UseVisualStyleBackColor = true;
            btn5.Click += button9_Click;
            // 
            // btn6
            // 
            btn6.Location = new Point(444, 157);
            btn6.Name = "btn6";
            btn6.Size = new Size(56, 51);
            btn6.TabIndex = 10;
            btn6.Text = "6";
            btn6.UseVisualStyleBackColor = true;
            btn6.Click += button10_Click;
            // 
            // btn7
            // 
            btn7.Location = new Point(320, 214);
            btn7.Name = "btn7";
            btn7.Size = new Size(56, 51);
            btn7.TabIndex = 11;
            btn7.Text = "7";
            btn7.UseVisualStyleBackColor = true;
            btn7.Click += button11_Click;
            // 
            // btn8
            // 
            btn8.Location = new Point(382, 214);
            btn8.Name = "btn8";
            btn8.Size = new Size(56, 51);
            btn8.TabIndex = 12;
            btn8.Text = "8";
            btn8.UseVisualStyleBackColor = true;
            btn8.Click += button12_Click;
            // 
            // btn9
            // 
            btn9.Location = new Point(444, 214);
            btn9.Name = "btn9";
            btn9.Size = new Size(56, 51);
            btn9.TabIndex = 13;
            btn9.Text = "9";
            btn9.UseVisualStyleBackColor = true;
            btn9.Click += button13_Click;
            // 
            // btn0
            // 
            btn0.Location = new Point(382, 271);
            btn0.Name = "btn0";
            btn0.Size = new Size(56, 51);
            btn0.TabIndex = 14;
            btn0.Text = "0";
            btn0.UseVisualStyleBackColor = true;
            btn0.Click += button14_Click;
            // 
            // btnclear
            // 
            btnclear.Location = new Point(12, 416);
            btnclear.Name = "btnclear";
            btnclear.Size = new Size(262, 70);
            btnclear.TabIndex = 15;
            btnclear.Text = "Clear";
            btnclear.UseVisualStyleBackColor = true;
            btnclear.Click += button15_Click;
            // 
            // btnplus
            // 
            btnplus.Font = new Font("Comic Sans MS", 27.75F, FontStyle.Regular, GraphicsUnit.Point);
            btnplus.Location = new Point(12, 100);
            btnplus.Name = "btnplus";
            btnplus.Size = new Size(128, 70);
            btnplus.TabIndex = 16;
            btnplus.Text = "+";
            btnplus.UseVisualStyleBackColor = true;
            btnplus.Click += button2_Click;
            // 
            // btnminus
            // 
            btnminus.Font = new Font("Comic Sans MS", 27.75F, FontStyle.Regular, GraphicsUnit.Point);
            btnminus.Location = new Point(146, 100);
            btnminus.Name = "btnminus";
            btnminus.Size = new Size(128, 70);
            btnminus.TabIndex = 17;
            btnminus.Text = "-";
            btnminus.UseVisualStyleBackColor = true;
            btnminus.Click += button1_Click_1;
            // 
            // btnmultiply
            // 
            btnmultiply.Font = new Font("Comic Sans MS", 27.75F, FontStyle.Regular, GraphicsUnit.Point);
            btnmultiply.Location = new Point(12, 176);
            btnmultiply.Name = "btnmultiply";
            btnmultiply.Size = new Size(128, 70);
            btnmultiply.TabIndex = 18;
            btnmultiply.Text = "*";
            btnmultiply.UseVisualStyleBackColor = true;
            btnmultiply.Click += button3_Click;
            // 
            // btndivide
            // 
            btndivide.Font = new Font("Comic Sans MS", 27.75F, FontStyle.Regular, GraphicsUnit.Point);
            btndivide.Location = new Point(146, 176);
            btndivide.Name = "btndivide";
            btndivide.Size = new Size(128, 70);
            btndivide.TabIndex = 19;
            btndivide.Text = "/";
            btndivide.UseVisualStyleBackColor = true;
            btndivide.Click += button4_Click;
            // 
            // btnresult
            // 
            btnresult.Font = new Font("Comic Sans MS", 27.75F, FontStyle.Regular, GraphicsUnit.Point);
            btnresult.Location = new Point(12, 251);
            btnresult.Name = "btnresult";
            btnresult.Size = new Size(262, 70);
            btnresult.TabIndex = 20;
            btnresult.Text = "=";
            btnresult.UseVisualStyleBackColor = true;
            btnresult.Click += button16_Click;
            // 
            // sylveonspack
            // 
            sylveonspack.Controls.Add(pictureBox4);
            sylveonspack.Controls.Add(pictureBox3);
            sylveonspack.Controls.Add(pictureBox2);
            sylveonspack.Controls.Add(pictureBox1);
            sylveonspack.Location = new Point(660, 40);
            sylveonspack.Name = "sylveonspack";
            sylveonspack.Size = new Size(476, 325);
            sylveonspack.TabIndex = 22;
            sylveonspack.TabStop = false;
            sylveonspack.Text = "Sylveon";
            sylveonspack.Enter += sylveonspack_Enter;
            // 
            // pictureBox4
            // 
            pictureBox4.BackgroundImage = Properties.Resources.sylveon__10_1;
            pictureBox4.BackgroundImageLayout = ImageLayout.Zoom;
            pictureBox4.Location = new Point(373, 22);
            pictureBox4.Name = "pictureBox4";
            pictureBox4.Size = new Size(88, 108);
            pictureBox4.TabIndex = 3;
            pictureBox4.TabStop = false;
            pictureBox4.Click += pictureBox4_Click;
            // 
            // pictureBox3
            // 
            pictureBox3.BackgroundImage = Properties.Resources.sylveon__10_;
            pictureBox3.BackgroundImageLayout = ImageLayout.Zoom;
            pictureBox3.Location = new Point(263, 22);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(88, 108);
            pictureBox3.TabIndex = 2;
            pictureBox3.TabStop = false;
            pictureBox3.Click += pictureBox3_Click_1;
            // 
            // pictureBox2
            // 
            pictureBox2.BackgroundImage = (Image)resources.GetObject("pictureBox2.BackgroundImage");
            pictureBox2.BackgroundImageLayout = ImageLayout.Zoom;
            pictureBox2.Location = new Point(154, 22);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(88, 108);
            pictureBox2.TabIndex = 1;
            pictureBox2.TabStop = false;
            pictureBox2.Click += pictureBox2_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.BackgroundImage = (Image)resources.GetObject("pictureBox1.BackgroundImage");
            pictureBox1.BackgroundImageLayout = ImageLayout.Stretch;
            pictureBox1.Location = new Point(6, 22);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(125, 108);
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click;
            // 
            // button1
            // 
            button1.Font = new Font("Comic Sans MS", 27.75F, FontStyle.Regular, GraphicsUnit.Point);
            button1.Location = new Point(12, 327);
            button1.Name = "button1";
            button1.Size = new Size(262, 70);
            button1.TabIndex = 23;
            button1.Text = ",";
            button1.UseVisualStyleBackColor = true;
            // 
            // monthCalendar1
            // 
            monthCalendar1.CalendarDimensions = new Size(3, 2);
            monthCalendar1.Location = new Point(649, 386);
            monthCalendar1.Name = "monthCalendar1";
            monthCalendar1.TabIndex = 24;
            // 
            // timer1
            // 
            timer1.Enabled = true;
            timer1.Interval = 1000;
            timer1.Tick += timer1_Tick;
            // 
            // labeltime
            // 
            labeltime.AutoSize = true;
            labeltime.Font = new Font("Segoe UI", 26.25F, FontStyle.Regular, GraphicsUnit.Point);
            labeltime.Location = new Point(12, 667);
            labeltime.Name = "labeltime";
            labeltime.Size = new Size(30, 47);
            labeltime.TabIndex = 25;
            labeltime.Text = "‎ ";
            // 
            // steamtime
            // 
            steamtime.Enabled = true;
            steamtime.Interval = 1000;
            steamtime.Tick += steamtime_Tick;
            // 
            // labelsteam
            // 
            labelsteam.AutoSize = true;
            labelsteam.Font = new Font("Segoe UI", 26.25F, FontStyle.Regular, GraphicsUnit.Point);
            labelsteam.Location = new Point(12, 611);
            labelsteam.Name = "labelsteam";
            labelsteam.Size = new Size(30, 47);
            labelsteam.TabIndex = 26;
            labelsteam.Text = "‎ ";
            labelsteam.Click += label1_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.LavenderBlush;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(1212, 723);
            Controls.Add(labelsteam);
            Controls.Add(labeltime);
            Controls.Add(monthCalendar1);
            Controls.Add(button1);
            Controls.Add(sylveonspack);
            Controls.Add(btnresult);
            Controls.Add(btndivide);
            Controls.Add(btnmultiply);
            Controls.Add(btnminus);
            Controls.Add(btnplus);
            Controls.Add(btnclear);
            Controls.Add(btn0);
            Controls.Add(btn9);
            Controls.Add(btn8);
            Controls.Add(btn7);
            Controls.Add(btn6);
            Controls.Add(btn5);
            Controls.Add(btn4);
            Controls.Add(btn3);
            Controls.Add(btn2);
            Controls.Add(btn1);
            Controls.Add(otchet);
            DoubleBuffered = true;
            MaximizeBox = false;
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            sylveonspack.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox4).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private TextBox otchet;
        private Button btn1;
        private Button btn2;
        private Button btn3;
        private Button btn4;
        private Button btn5;
        private Button btn6;
        private Button btn7;
        private Button btn8;
        private Button btn9;
        private Button btn0;
        private Button btnclear;
        private Button btnplus;
        private Button btnminus;
        private Button btnmultiply;
        private Button btndivide;
        private Button btnresult;
        private GroupBox sylveonspack;
        private PictureBox pictureBox1;
        private PictureBox pictureBox2;
        private PictureBox pictureBox4;
        private PictureBox pictureBox3;
        private Button button1;
        private MonthCalendar monthCalendar1;
        private System.Windows.Forms.Timer timer1;
        private Label labeltime;
        private System.Windows.Forms.Timer steamtime;
        private Label labelsteam;
    }
}