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
            this.SuspendLayout();
            // 
            // returnbttn
            // 
            this.returnbttn.Location = new System.Drawing.Point(12, 430);
            this.returnbttn.Name = "returnbttn";
            this.returnbttn.Size = new System.Drawing.Size(75, 23);
            this.returnbttn.TabIndex = 0;
            this.returnbttn.Text = "Return";
            this.returnbttn.UseVisualStyleBackColor = true;
            this.returnbttn.Click += new System.EventHandler(this.returnbttn_Click);
            // 
            // othershower
            // 
            this.othershower.Location = new System.Drawing.Point(389, 430);
            this.othershower.Name = "othershower";
            this.othershower.Size = new System.Drawing.Size(119, 23);
            this.othershower.TabIndex = 2;
            this.othershower.Text = "View Others";
            this.othershower.UseVisualStyleBackColor = true;
            this.othershower.Click += new System.EventHandler(this.othershower_Click);
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 15;
            this.listBox1.Location = new System.Drawing.Point(12, 12);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(496, 409);
            this.listBox1.TabIndex = 3;
            // 
            // Listoverview
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(520, 462);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.othershower);
            this.Controls.Add(this.returnbttn);
            this.MaximizeBox = false;
            this.MdiChildrenMinimizedAnchorBottom = false;
            this.Name = "Listoverview";
            this.ShowIcon = false;
            this.ResumeLayout(false);

        }

        #endregion

        private Button returnbttn;
        private Button othershower;
        private ListBox listBox1;
    }
}