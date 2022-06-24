namespace For_the_Contact_Tracing
{
    partial class Firstpage
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
            this.nextpage = new System.Windows.Forms.Button();
            this.exitbttn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // nextpage
            // 
            this.nextpage.Location = new System.Drawing.Point(331, 196);
            this.nextpage.Name = "nextpage";
            this.nextpage.Size = new System.Drawing.Size(103, 36);
            this.nextpage.TabIndex = 0;
            this.nextpage.Text = "Next";
            this.nextpage.UseVisualStyleBackColor = true;
            this.nextpage.Click += new System.EventHandler(this.nextpage_Click);
            // 
            // exitbttn
            // 
            this.exitbttn.Location = new System.Drawing.Point(12, 196);
            this.exitbttn.Name = "exitbttn";
            this.exitbttn.Size = new System.Drawing.Size(103, 36);
            this.exitbttn.TabIndex = 1;
            this.exitbttn.Text = "Exit";
            this.exitbttn.UseVisualStyleBackColor = true;
            this.exitbttn.Click += new System.EventHandler(this.exitbttn_Click);
            // 
            // Firstpage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(446, 240);
            this.Controls.Add(this.exitbttn);
            this.Controls.Add(this.nextpage);
            this.MaximizeBox = false;
            this.MdiChildrenMinimizedAnchorBottom = false;
            this.Name = "Firstpage";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.ResumeLayout(false);

        }

        #endregion

        private Button nextpage;
        private Button exitbttn;
    }
}