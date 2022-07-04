namespace For_the_Contact_Tracing
{
    partial class AutoFillFormPage
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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.buttongenerator = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.pictureBoxqrcode = new System.Windows.Forms.PictureBox();
            this.fullNametxtbox = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.dateTimePicker2 = new System.Windows.Forms.DateTimePicker();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.Sex2 = new System.Windows.Forms.RadioButton();
            this.Sex1 = new System.Windows.Forms.RadioButton();
            this.label14 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.vaccinated2 = new System.Windows.Forms.RadioButton();
            this.Vaccinated1 = new System.Windows.Forms.RadioButton();
            this.label15 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxqrcode)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.LemonChiffon;
            this.pictureBox1.Location = new System.Drawing.Point(404, -9);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(397, 688);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // buttongenerator
            // 
            this.buttongenerator.BackColor = System.Drawing.Color.Transparent;
            this.buttongenerator.Location = new System.Drawing.Point(156, 449);
            this.buttongenerator.Name = "buttongenerator";
            this.buttongenerator.Size = new System.Drawing.Size(75, 23);
            this.buttongenerator.TabIndex = 1;
            this.buttongenerator.UseVisualStyleBackColor = false;
            this.buttongenerator.Click += new System.EventHandler(this.buttongenerator_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.LightGoldenrodYellow;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 15);
            this.label1.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial Unicode MS", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(-5, -2);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(205, 64);
            this.label2.TabIndex = 3;
            this.label2.Text = "STEP 1:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial Unicode MS", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(186, 6);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(216, 60);
            this.label3.TabIndex = 4;
            this.label3.Text = "Fill up the needed information below then\r\nclick the generate button to create yo" +
    "ur\r\npersonal QR code. Afterwards, proceed to \r\nSTEP 2.\r\n";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial Unicode MS", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(122, 77);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(133, 16);
            this.label4.TabIndex = 5;
            this.label4.Text = "QR Code Generator";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Arial Unicode MS", 6F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label5.Location = new System.Drawing.Point(154, 435);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(82, 11);
            this.label5.TabIndex = 6;
            this.label5.Text = "Click Create QR Code";
            // 
            // pictureBoxqrcode
            // 
            this.pictureBoxqrcode.BackColor = System.Drawing.Color.White;
            this.pictureBoxqrcode.Location = new System.Drawing.Point(98, 478);
            this.pictureBoxqrcode.Name = "pictureBoxqrcode";
            this.pictureBoxqrcode.Size = new System.Drawing.Size(193, 188);
            this.pictureBoxqrcode.TabIndex = 7;
            this.pictureBoxqrcode.TabStop = false;
            // 
            // fullNametxtbox
            // 
            this.fullNametxtbox.Location = new System.Drawing.Point(39, 112);
            this.fullNametxtbox.Name = "fullNametxtbox";
            this.fullNametxtbox.Size = new System.Drawing.Size(319, 23);
            this.fullNametxtbox.TabIndex = 8;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.LightGoldenrodYellow;
            this.label6.Font = new System.Drawing.Font("Arial Unicode MS", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label6.Location = new System.Drawing.Point(596, 9);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(176, 45);
            this.label6.TabIndex = 10;
            this.label6.Text = "After getting your own QR Code,\r\nscan it in the camera section. Then\r\nclick submi" +
    "t.\r\n";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.LightGoldenrodYellow;
            this.label7.Font = new System.Drawing.Font("Arial Unicode MS", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label7.Location = new System.Drawing.Point(406, -2);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(205, 64);
            this.label7.TabIndex = 9;
            this.label7.Text = "STEP 2:";
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(39, 163);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(319, 23);
            this.textBox2.TabIndex = 11;
            // 
            // textBox5
            // 
            this.textBox5.Location = new System.Drawing.Point(280, 263);
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(78, 23);
            this.textBox5.TabIndex = 14;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Arial Unicode MS", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label8.Location = new System.Drawing.Point(11, 97);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(81, 15);
            this.label8.TabIndex = 16;
            this.label8.Text = "Complete name";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Arial Unicode MS", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label9.Location = new System.Drawing.Point(11, 147);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(67, 15);
            this.label9.TabIndex = 17;
            this.label9.Text = "Full address";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(39, 216);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(319, 23);
            this.dateTimePicker1.TabIndex = 18;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Arial Unicode MS", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label10.Location = new System.Drawing.Point(11, 201);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(66, 15);
            this.label10.TabIndex = 19;
            this.label10.Text = "Date of birth";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Arial Unicode MS", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label11.Location = new System.Drawing.Point(265, 248);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(26, 15);
            this.label11.TabIndex = 20;
            this.label11.Text = "Age";
            // 
            // dateTimePicker2
            // 
            this.dateTimePicker2.Location = new System.Drawing.Point(154, 349);
            this.dateTimePicker2.Name = "dateTimePicker2";
            this.dateTimePicker2.Size = new System.Drawing.Size(202, 23);
            this.dateTimePicker2.TabIndex = 21;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Arial Unicode MS", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label12.Location = new System.Drawing.Point(132, 333);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(64, 15);
            this.label12.TabIndex = 22;
            this.label12.Text = "Date visited";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Arial Unicode MS", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label13.Location = new System.Drawing.Point(10, 335);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(69, 15);
            this.label13.TabIndex = 24;
            this.label13.Text = "Temperature";
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(37, 350);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(67, 23);
            this.textBox3.TabIndex = 23;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.Sex2);
            this.groupBox1.Controls.Add(this.Sex1);
            this.groupBox1.Location = new System.Drawing.Point(38, 253);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(152, 38);
            this.groupBox1.TabIndex = 25;
            this.groupBox1.TabStop = false;
            // 
            // Sex2
            // 
            this.Sex2.AutoSize = true;
            this.Sex2.Font = new System.Drawing.Font("Arial Unicode MS", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Sex2.Location = new System.Drawing.Point(74, 13);
            this.Sex2.Name = "Sex2";
            this.Sex2.Size = new System.Drawing.Size(67, 20);
            this.Sex2.TabIndex = 1;
            this.Sex2.TabStop = true;
            this.Sex2.Text = "Female";
            this.Sex2.UseVisualStyleBackColor = true;
            // 
            // Sex1
            // 
            this.Sex1.AutoSize = true;
            this.Sex1.Font = new System.Drawing.Font("Arial Unicode MS", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Sex1.Location = new System.Drawing.Point(6, 13);
            this.Sex1.Name = "Sex1";
            this.Sex1.Size = new System.Drawing.Size(52, 20);
            this.Sex1.TabIndex = 0;
            this.Sex1.TabStop = true;
            this.Sex1.Text = "Male";
            this.Sex1.UseVisualStyleBackColor = true;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Arial Unicode MS", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label14.Location = new System.Drawing.Point(14, 248);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(26, 15);
            this.label14.TabIndex = 9;
            this.label14.Text = "Sex";
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.MediumAquamarine;
            this.groupBox2.Controls.Add(this.vaccinated2);
            this.groupBox2.Controls.Add(this.Vaccinated1);
            this.groupBox2.Location = new System.Drawing.Point(37, 398);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(134, 29);
            this.groupBox2.TabIndex = 27;
            this.groupBox2.TabStop = false;
            // 
            // vaccinated2
            // 
            this.vaccinated2.AutoSize = true;
            this.vaccinated2.Font = new System.Drawing.Font("Arial Unicode MS", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.vaccinated2.Location = new System.Drawing.Point(86, 8);
            this.vaccinated2.Name = "vaccinated2";
            this.vaccinated2.Size = new System.Drawing.Size(41, 20);
            this.vaccinated2.TabIndex = 1;
            this.vaccinated2.TabStop = true;
            this.vaccinated2.Text = "No";
            this.vaccinated2.UseVisualStyleBackColor = true;
            // 
            // Vaccinated1
            // 
            this.Vaccinated1.AutoSize = true;
            this.Vaccinated1.Font = new System.Drawing.Font("Arial Unicode MS", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Vaccinated1.Location = new System.Drawing.Point(6, 8);
            this.Vaccinated1.Name = "Vaccinated1";
            this.Vaccinated1.Size = new System.Drawing.Size(46, 20);
            this.Vaccinated1.TabIndex = 0;
            this.Vaccinated1.TabStop = true;
            this.Vaccinated1.Text = "Yes";
            this.Vaccinated1.UseVisualStyleBackColor = true;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.BackColor = System.Drawing.Color.MediumAquamarine;
            this.label15.Font = new System.Drawing.Font("Arial Unicode MS", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label15.Location = new System.Drawing.Point(14, 385);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(67, 15);
            this.label15.TabIndex = 26;
            this.label15.Text = "Vaccinated?";
            // 
            // AutoFillFormPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MediumAquamarine;
            this.ClientSize = new System.Drawing.Size(775, 673);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.dateTimePicker2);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.textBox5);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.fullNametxtbox);
            this.Controls.Add(this.pictureBoxqrcode);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.buttongenerator);
            this.Controls.Add(this.pictureBox1);
            this.MaximizeBox = false;
            this.MdiChildrenMinimizedAnchorBottom = false;
            this.Name = "AutoFillFormPage";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "  ";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxqrcode)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private PictureBox pictureBox1;
        private Button buttongenerator;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private PictureBox pictureBoxqrcode;
        private TextBox fullNametxtbox;
        private Label label6;
        private Label label7;
        private TextBox textBox2;
        private TextBox textBox5;
        private Label label8;
        private Label label9;
        private DateTimePicker dateTimePicker1;
        private Label label10;
        private Label label11;
        private DateTimePicker dateTimePicker2;
        private Label label12;
        private Label label13;
        private TextBox textBox3;
        private GroupBox groupBox1;
        private RadioButton Sex2;
        private Label label14;
        private RadioButton Sex1;
        private GroupBox groupBox2;
        private RadioButton vaccinated2;
        private RadioButton Vaccinated1;
        private Label label15;
    }
}