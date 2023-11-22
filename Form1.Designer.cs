namespace JoesDiner
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
            panel1 = new Panel();
            pictureBox1 = new PictureBox();
            label1 = new Label();
            timer1 = new System.Windows.Forms.Timer(components);
            richTextBox1 = new RichTextBox();
            tabControl1 = new TabControl();
            tabPage1 = new TabPage();
            textBox4 = new TextBox();
            textBox3 = new TextBox();
            textBox2 = new TextBox();
            textBox1 = new TextBox();
            checkBox4 = new CheckBox();
            checkBox3 = new CheckBox();
            checkBox2 = new CheckBox();
            checkBox1 = new CheckBox();
            pictureBox5 = new PictureBox();
            pictureBox4 = new PictureBox();
            pictureBox3 = new PictureBox();
            pictureBox2 = new PictureBox();
            tabPage2 = new TabPage();
            textBox7 = new TextBox();
            textBox6 = new TextBox();
            textBox5 = new TextBox();
            checkBox7 = new CheckBox();
            checkBox6 = new CheckBox();
            checkBox5 = new CheckBox();
            pictureBox8 = new PictureBox();
            pictureBox7 = new PictureBox();
            pictureBox6 = new PictureBox();
            exitbtn = new Button();
            resetbtn = new Button();
            lblSubTotal = new Label();
            lblTax = new Label();
            lblTotal = new Label();
            button1 = new Button();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            tabControl1.SuspendLayout();
            tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox5).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox8).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox7).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox6).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.White;
            panel1.Controls.Add(pictureBox1);
            panel1.Location = new Point(2, 2);
            panel1.Name = "panel1";
            panel1.Size = new Size(844, 81);
            panel1.TabIndex = 0;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.street;
            pictureBox1.Location = new Point(359, 10);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(138, 59);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 3;
            pictureBox1.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(764, 101);
            label1.Name = "label1";
            label1.Size = new Size(46, 21);
            label1.TabIndex = 1;
            label1.Text = "Time";
            // 
            // timer1
            // 
            timer1.Interval = 1000;
            timer1.Tick += timer1_Tick;
            // 
            // richTextBox1
            // 
            richTextBox1.Location = new Point(582, 125);
            richTextBox1.Name = "richTextBox1";
            richTextBox1.ReadOnly = true;
            richTextBox1.Size = new Size(251, 382);
            richTextBox1.TabIndex = 2;
            richTextBox1.Text = "";
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(tabPage1);
            tabControl1.Controls.Add(tabPage2);
            tabControl1.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            tabControl1.Location = new Point(7, 95);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(560, 412);
            tabControl1.TabIndex = 3;
            tabControl1.Click += tabControl1_Click;
            // 
            // tabPage1
            // 
            tabPage1.BackColor = Color.White;
            tabPage1.Controls.Add(textBox4);
            tabPage1.Controls.Add(textBox3);
            tabPage1.Controls.Add(textBox2);
            tabPage1.Controls.Add(textBox1);
            tabPage1.Controls.Add(checkBox4);
            tabPage1.Controls.Add(checkBox3);
            tabPage1.Controls.Add(checkBox2);
            tabPage1.Controls.Add(checkBox1);
            tabPage1.Controls.Add(pictureBox5);
            tabPage1.Controls.Add(pictureBox4);
            tabPage1.Controls.Add(pictureBox3);
            tabPage1.Controls.Add(pictureBox2);
            tabPage1.Location = new Point(4, 30);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new Padding(3);
            tabPage1.Size = new Size(552, 378);
            tabPage1.TabIndex = 0;
            tabPage1.Text = "Food";
            // 
            // textBox4
            // 
            textBox4.Location = new Point(394, 329);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(46, 29);
            textBox4.TabIndex = 15;
            textBox4.Text = "0";
            textBox4.TextAlign = HorizontalAlignment.Center;
            textBox4.KeyPress += NumbersOnly;
            // 
            // textBox3
            // 
            textBox3.Location = new Point(130, 329);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(46, 29);
            textBox3.TabIndex = 14;
            textBox3.Text = "0";
            textBox3.TextAlign = HorizontalAlignment.Center;
            textBox3.KeyPress += NumbersOnly;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(394, 144);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(46, 29);
            textBox2.TabIndex = 13;
            textBox2.Text = "0";
            textBox2.TextAlign = HorizontalAlignment.Center;
            textBox2.KeyPress += NumbersOnly;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(130, 144);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(46, 29);
            textBox1.TabIndex = 12;
            textBox1.Text = "0";
            textBox1.TextAlign = HorizontalAlignment.Center;
            textBox1.KeyPress += NumbersOnly;
            // 
            // checkBox4
            // 
            checkBox4.AutoSize = true;
            checkBox4.Font = new Font("Arial Rounded MT Bold", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            checkBox4.Location = new Point(350, 192);
            checkBox4.Name = "checkBox4";
            checkBox4.Size = new Size(90, 19);
            checkBox4.TabIndex = 11;
            checkBox4.Text = "Allyoucan";
            checkBox4.UseVisualStyleBackColor = true;
            checkBox4.CheckedChanged += checkBox4_CheckedChanged;
            // 
            // checkBox3
            // 
            checkBox3.AutoSize = true;
            checkBox3.Font = new Font("Arial Rounded MT Bold", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            checkBox3.Location = new Point(95, 192);
            checkBox3.Name = "checkBox3";
            checkBox3.Size = new Size(106, 19);
            checkBox3.TabIndex = 10;
            checkBox3.Text = "Burgersteak";
            checkBox3.UseVisualStyleBackColor = true;
            checkBox3.CheckedChanged += checkBox3_CheckedChanged;
            // 
            // checkBox2
            // 
            checkBox2.AutoSize = true;
            checkBox2.Font = new Font("Arial Rounded MT Bold", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            checkBox2.Location = new Point(350, 6);
            checkBox2.Name = "checkBox2";
            checkBox2.Size = new Size(59, 19);
            checkBox2.TabIndex = 9;
            checkBox2.Text = "Fries";
            checkBox2.UseVisualStyleBackColor = true;
            checkBox2.CheckedChanged += checkBox2_CheckedChanged;
            // 
            // checkBox1
            // 
            checkBox1.AutoSize = true;
            checkBox1.Font = new Font("Arial Rounded MT Bold", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            checkBox1.Location = new Point(95, 6);
            checkBox1.Name = "checkBox1";
            checkBox1.Size = new Size(71, 19);
            checkBox1.TabIndex = 8;
            checkBox1.Text = "Burger";
            checkBox1.UseVisualStyleBackColor = true;
            checkBox1.CheckedChanged += checkBox1_CheckedChanged;
            // 
            // pictureBox5
            // 
            pictureBox5.Image = (Image)resources.GetObject("pictureBox5.Image");
            pictureBox5.Location = new Point(350, 217);
            pictureBox5.Name = "pictureBox5";
            pictureBox5.Size = new Size(122, 110);
            pictureBox5.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox5.TabIndex = 3;
            pictureBox5.TabStop = false;
            // 
            // pictureBox4
            // 
            pictureBox4.Image = (Image)resources.GetObject("pictureBox4.Image");
            pictureBox4.Location = new Point(350, 28);
            pictureBox4.Name = "pictureBox4";
            pictureBox4.Size = new Size(122, 110);
            pictureBox4.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox4.TabIndex = 2;
            pictureBox4.TabStop = false;
            // 
            // pictureBox3
            // 
            pictureBox3.Image = (Image)resources.GetObject("pictureBox3.Image");
            pictureBox3.Location = new Point(95, 217);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(122, 110);
            pictureBox3.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox3.TabIndex = 1;
            pictureBox3.TabStop = false;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = Properties.Resources.burger;
            pictureBox2.Location = new Point(95, 28);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(122, 110);
            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox2.TabIndex = 0;
            pictureBox2.TabStop = false;
            // 
            // tabPage2
            // 
            tabPage2.BackColor = Color.White;
            tabPage2.Controls.Add(textBox7);
            tabPage2.Controls.Add(textBox6);
            tabPage2.Controls.Add(textBox5);
            tabPage2.Controls.Add(checkBox7);
            tabPage2.Controls.Add(checkBox6);
            tabPage2.Controls.Add(checkBox5);
            tabPage2.Controls.Add(pictureBox8);
            tabPage2.Controls.Add(pictureBox7);
            tabPage2.Controls.Add(pictureBox6);
            tabPage2.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            tabPage2.Location = new Point(4, 30);
            tabPage2.Name = "tabPage2";
            tabPage2.Padding = new Padding(3);
            tabPage2.Size = new Size(552, 378);
            tabPage2.TabIndex = 1;
            tabPage2.Text = "Drinks";
            // 
            // textBox7
            // 
            textBox7.Location = new Point(259, 347);
            textBox7.Name = "textBox7";
            textBox7.Size = new Size(41, 25);
            textBox7.TabIndex = 8;
            textBox7.Text = "0";
            textBox7.TextAlign = HorizontalAlignment.Center;
            textBox7.KeyPress += NumbersOnly2;
            // 
            // textBox6
            // 
            textBox6.Location = new Point(440, 185);
            textBox6.Name = "textBox6";
            textBox6.Size = new Size(41, 25);
            textBox6.TabIndex = 7;
            textBox6.Text = "0";
            textBox6.TextAlign = HorizontalAlignment.Center;
            textBox6.KeyPress += NumbersOnly2;
            // 
            // textBox5
            // 
            textBox5.Location = new Point(78, 185);
            textBox5.Name = "textBox5";
            textBox5.Size = new Size(41, 25);
            textBox5.TabIndex = 6;
            textBox5.Text = "0";
            textBox5.TextAlign = HorizontalAlignment.Center;
            textBox5.KeyPress += NumbersOnly2;
            // 
            // checkBox7
            // 
            checkBox7.AutoSize = true;
            checkBox7.Font = new Font("Arial Rounded MT Bold", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            checkBox7.Location = new Point(199, 185);
            checkBox7.Name = "checkBox7";
            checkBox7.Size = new Size(88, 19);
            checkBox7.TabIndex = 5;
            checkBox7.Text = "Fiji Water";
            checkBox7.UseVisualStyleBackColor = true;
            checkBox7.CheckedChanged += checkBox7_CheckedChanged;
            // 
            // checkBox6
            // 
            checkBox6.AutoSize = true;
            checkBox6.Font = new Font("Arial Rounded MT Bold", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            checkBox6.Location = new Point(382, 14);
            checkBox6.Name = "checkBox6";
            checkBox6.Size = new Size(81, 19);
            checkBox6.TabIndex = 4;
            checkBox6.Text = "Iced Tea";
            checkBox6.UseVisualStyleBackColor = true;
            checkBox6.CheckedChanged += checkBox6_CheckedChanged;
            // 
            // checkBox5
            // 
            checkBox5.AutoSize = true;
            checkBox5.Font = new Font("Arial Rounded MT Bold", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            checkBox5.Location = new Point(18, 14);
            checkBox5.Name = "checkBox5";
            checkBox5.Size = new Size(59, 19);
            checkBox5.TabIndex = 3;
            checkBox5.Text = "Soda";
            checkBox5.UseVisualStyleBackColor = true;
            checkBox5.CheckedChanged += checkBox5_CheckedChanged;
            // 
            // pictureBox8
            // 
            pictureBox8.Image = (Image)resources.GetObject("pictureBox8.Image");
            pictureBox8.Location = new Point(382, 39);
            pictureBox8.Name = "pictureBox8";
            pictureBox8.Size = new Size(164, 135);
            pictureBox8.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox8.TabIndex = 2;
            pictureBox8.TabStop = false;
            // 
            // pictureBox7
            // 
            pictureBox7.Image = (Image)resources.GetObject("pictureBox7.Image");
            pictureBox7.Location = new Point(199, 210);
            pictureBox7.Name = "pictureBox7";
            pictureBox7.Size = new Size(164, 135);
            pictureBox7.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox7.TabIndex = 1;
            pictureBox7.TabStop = false;
            // 
            // pictureBox6
            // 
            pictureBox6.Image = Properties.Resources.soda;
            pictureBox6.Location = new Point(18, 39);
            pictureBox6.Name = "pictureBox6";
            pictureBox6.Size = new Size(164, 135);
            pictureBox6.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox6.TabIndex = 0;
            pictureBox6.TabStop = false;
            // 
            // exitbtn
            // 
            exitbtn.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            exitbtn.Location = new Point(764, 516);
            exitbtn.Name = "exitbtn";
            exitbtn.Size = new Size(69, 34);
            exitbtn.TabIndex = 4;
            exitbtn.Text = "Exit";
            exitbtn.UseVisualStyleBackColor = true;
            exitbtn.Click += exitbtn_Click;
            // 
            // resetbtn
            // 
            resetbtn.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            resetbtn.Location = new Point(671, 516);
            resetbtn.Name = "resetbtn";
            resetbtn.Size = new Size(69, 34);
            resetbtn.TabIndex = 5;
            resetbtn.Text = "Reset";
            resetbtn.UseVisualStyleBackColor = true;
            resetbtn.Click += resetbtn_Click;
            // 
            // lblSubTotal
            // 
            lblSubTotal.AutoSize = true;
            lblSubTotal.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lblSubTotal.Location = new Point(185, 519);
            lblSubTotal.Name = "lblSubTotal";
            lblSubTotal.Size = new Size(16, 21);
            lblSubTotal.TabIndex = 9;
            lblSubTotal.Text = "-";
            // 
            // lblTax
            // 
            lblTax.AutoSize = true;
            lblTax.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lblTax.Location = new Point(185, 540);
            lblTax.Name = "lblTax";
            lblTax.Size = new Size(16, 21);
            lblTax.TabIndex = 10;
            lblTax.Text = "-";
            // 
            // lblTotal
            // 
            lblTotal.AutoSize = true;
            lblTotal.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lblTotal.Location = new Point(185, 561);
            lblTotal.Name = "lblTotal";
            lblTotal.Size = new Size(16, 21);
            lblTotal.TabIndex = 11;
            lblTotal.Text = "-";
            // 
            // button1
            // 
            button1.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            button1.Location = new Point(582, 516);
            button1.Name = "button1";
            button1.Size = new Size(69, 34);
            button1.TabIndex = 12;
            button1.Text = "Total";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(7, 519);
            label2.Name = "label2";
            label2.Size = new Size(73, 21);
            label2.TabIndex = 13;
            label2.Text = "SubTotal";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(7, 540);
            label3.Name = "label3";
            label3.Size = new Size(33, 21);
            label3.TabIndex = 14;
            label3.Text = "Tax";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label4.Location = new Point(7, 561);
            label4.Name = "label4";
            label4.Size = new Size(45, 21);
            label4.TabIndex = 15;
            label4.Text = "Total";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.LemonChiffon;
            ClientSize = new Size(845, 604);
            Controls.Add(label4);
            Controls.Add(label1);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(button1);
            Controls.Add(lblTotal);
            Controls.Add(lblTax);
            Controls.Add(lblSubTotal);
            Controls.Add(resetbtn);
            Controls.Add(exitbtn);
            Controls.Add(tabControl1);
            Controls.Add(richTextBox1);
            Controls.Add(panel1);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            tabControl1.ResumeLayout(false);
            tabPage1.ResumeLayout(false);
            tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox5).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            tabPage2.ResumeLayout(false);
            tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox8).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox7).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox6).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private System.Windows.Forms.Timer timer1;
        private Label label1;
        private RichTextBox richTextBox1;
        private PictureBox pictureBox1;
        private TabControl tabControl1;
        private TabPage tabPage1;
        private TabPage tabPage2;
        private PictureBox pictureBox2;
        private PictureBox pictureBox5;
        private PictureBox pictureBox4;
        private PictureBox pictureBox3;
        private CheckBox checkBox1;
        private TextBox textBox4;
        private TextBox textBox3;
        private TextBox textBox2;
        private TextBox textBox1;
        private CheckBox checkBox4;
        private CheckBox checkBox3;
        private CheckBox checkBox2;
        private CheckBox checkBox5;
        private PictureBox pictureBox8;
        private PictureBox pictureBox7;
        private PictureBox pictureBox6;
        private TextBox textBox7;
        private TextBox textBox6;
        private TextBox textBox5;
        private CheckBox checkBox7;
        private CheckBox checkBox6;
        private Button exitbtn;
        private Button resetbtn;
        private Label lblSubTotal;
        private Label lblTax;
        private Label lblTotal;
        private Button button1;
        private Label label2;
        private Label label3;
        private Label label4;
    }
}