namespace For_the_Contact_Tracing
{
    partial class Listoverview
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
            this.returnbttn = new System.Windows.Forms.Button();
            this.othershower = new System.Windows.Forms.Button();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.button1 = new System.Windows.Forms.Button();
            this.bttnforfilter = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // returnbttn
            // 
            this.returnbttn.Font = new System.Drawing.Font("Arial Unicode MS", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.returnbttn.Location = new System.Drawing.Point(332, 383);
            this.returnbttn.Name = "returnbttn";
            this.returnbttn.Size = new System.Drawing.Size(55, 23);
            this.returnbttn.TabIndex = 0;
            this.returnbttn.Text = "Return";
            this.returnbttn.UseVisualStyleBackColor = true;
            this.returnbttn.Click += new System.EventHandler(this.returnbttn_Click);
            // 
            // othershower
            // 
            this.othershower.Font = new System.Drawing.Font("Arial Unicode MS", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.othershower.Location = new System.Drawing.Point(332, 12);
            this.othershower.Name = "othershower";
            this.othershower.Size = new System.Drawing.Size(109, 23);
            this.othershower.TabIndex = 2;
            this.othershower.Text = "View all";
            this.othershower.UseVisualStyleBackColor = true;
            this.othershower.Click += new System.EventHandler(this.othershower_Click);
            // 
            // listBox1
            // 
            this.listBox1.Font = new System.Drawing.Font("Arial Unicode MS", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 16;
            this.listBox1.Location = new System.Drawing.Point(12, 12);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(312, 388);
            this.listBox1.TabIndex = 3;
            this.listBox1.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Arial Unicode MS", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.button1.Location = new System.Drawing.Point(393, 383);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(48, 23);
            this.button1.TabIndex = 5;
            this.button1.Text = "Exit";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // bttnforfilter
            // 
            this.bttnforfilter.Font = new System.Drawing.Font("Arial Unicode MS", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.bttnforfilter.Location = new System.Drawing.Point(332, 41);
            this.bttnforfilter.Name = "bttnforfilter";
            this.bttnforfilter.Size = new System.Drawing.Size(109, 23);
            this.bttnforfilter.TabIndex = 6;
            this.bttnforfilter.Text = "Filter";
            this.bttnforfilter.UseVisualStyleBackColor = true;
            this.bttnforfilter.Click += new System.EventHandler(this.button2_Click);
            // 
            // Listoverview
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LemonChiffon;
            this.ClientSize = new System.Drawing.Size(449, 418);
            this.Controls.Add(this.bttnforfilter);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.othershower);
            this.Controls.Add(this.returnbttn);
            this.MaximizeBox = false;
            this.MdiChildrenMinimizedAnchorBottom = false;
            this.Name = "Listoverview";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.ResumeLayout(false);

        }

        #endregion

        private Button returnbttn;
        private Button othershower;
        private ListBox listBox1;
        private Button button1;
        private Button bttnforfilter;
    }
}