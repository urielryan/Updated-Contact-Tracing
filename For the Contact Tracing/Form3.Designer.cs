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
            this.forthelist = new System.Windows.Forms.ListView();
            this.Dateofvisitlist = new System.Windows.Forms.ColumnHeader();
            this.Namelist = new System.Windows.Forms.ColumnHeader();
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
            // forthelist
            // 
            this.forthelist.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.Dateofvisitlist,
            this.Namelist});
            this.forthelist.Location = new System.Drawing.Point(29, 35);
            this.forthelist.Name = "forthelist";
            this.forthelist.Size = new System.Drawing.Size(231, 351);
            this.forthelist.TabIndex = 1;
            this.forthelist.UseCompatibleStateImageBehavior = false;
            this.forthelist.View = System.Windows.Forms.View.Details;
            this.forthelist.SelectedIndexChanged += new System.EventHandler(this.listView1_SelectedIndexChanged);
            // 
            // Dateofvisitlist
            // 
            this.Dateofvisitlist.Text = "Date of Visit";
            this.Dateofvisitlist.Width = 100;
            // 
            // Namelist
            // 
            this.Namelist.Text = "Name";
            this.Namelist.Width = 120;
            // 
            // Listoverview
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(295, 464);
            this.Controls.Add(this.forthelist);
            this.Controls.Add(this.returnbttn);
            this.MaximizeBox = false;
            this.MdiChildrenMinimizedAnchorBottom = false;
            this.Name = "Listoverview";
            this.ShowIcon = false;
            this.ResumeLayout(false);

        }

        #endregion

        private Button returnbttn;
        private ListView forthelist;
        private ColumnHeader Dateofvisitlist;
        private ColumnHeader Namelist;
    }
}