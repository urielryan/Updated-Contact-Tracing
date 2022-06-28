namespace For_the_Contact_Tracing
{
    partial class filterform
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
            this.exitbttnform4 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // exitbttnform4
            // 
            this.exitbttnform4.Location = new System.Drawing.Point(12, 12);
            this.exitbttnform4.Name = "exitbttnform4";
            this.exitbttnform4.Size = new System.Drawing.Size(50, 23);
            this.exitbttnform4.TabIndex = 0;
            this.exitbttnform4.Text = "Return";
            this.exitbttnform4.UseVisualStyleBackColor = true;
            this.exitbttnform4.Click += new System.EventHandler(this.exitbttnform4_Click);
            // 
            // filterform
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(417, 450);
            this.Controls.Add(this.exitbttnform4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "filterform";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.ResumeLayout(false);

        }

        #endregion

        private Button exitbttnform4;
    }
}