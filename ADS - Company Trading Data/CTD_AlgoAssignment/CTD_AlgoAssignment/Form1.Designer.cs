namespace CTD_AlgoAssignment
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
            System.Windows.Forms.ListViewItem listViewItem1 = new System.Windows.Forms.ListViewItem("");
            this.companyList = new System.Windows.Forms.ListView();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.pathLabel = new System.Windows.Forms.Label();
            this.companyName = new System.Windows.Forms.Label();
            this.companyDetails = new System.Windows.Forms.Label();
            this.pathSubmit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // companyList
            // 
            this.companyList.Items.AddRange(new System.Windows.Forms.ListViewItem[] {
            listViewItem1});
            this.companyList.Location = new System.Drawing.Point(38, 38);
            this.companyList.Name = "companyList";
            this.companyList.Size = new System.Drawing.Size(136, 337);
            this.companyList.TabIndex = 0;
            this.companyList.UseCompatibleStateImageBehavior = false;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(38, 404);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(599, 20);
            this.textBox1.TabIndex = 1;
            // 
            // pathLabel
            // 
            this.pathLabel.AutoSize = true;
            this.pathLabel.Location = new System.Drawing.Point(38, 382);
            this.pathLabel.Name = "pathLabel";
            this.pathLabel.Size = new System.Drawing.Size(29, 13);
            this.pathLabel.TabIndex = 2;
            this.pathLabel.Text = "Path";
            // 
            // companyName
            // 
            this.companyName.AutoSize = true;
            this.companyName.Location = new System.Drawing.Point(199, 42);
            this.companyName.Name = "companyName";
            this.companyName.Size = new System.Drawing.Size(82, 13);
            this.companyName.TabIndex = 3;
            this.companyName.Text = "Company Name";
            // 
            // companyDetails
            // 
            this.companyDetails.AutoSize = true;
            this.companyDetails.Location = new System.Drawing.Point(199, 77);
            this.companyDetails.Name = "companyDetails";
            this.companyDetails.Size = new System.Drawing.Size(86, 13);
            this.companyDetails.TabIndex = 4;
            this.companyDetails.Text = "Company Details";
            // 
            // pathSubmit
            // 
            this.pathSubmit.Location = new System.Drawing.Point(669, 401);
            this.pathSubmit.Name = "pathSubmit";
            this.pathSubmit.Size = new System.Drawing.Size(75, 23);
            this.pathSubmit.TabIndex = 5;
            this.pathSubmit.Text = "Get Data";
            this.pathSubmit.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.pathSubmit);
            this.Controls.Add(this.companyDetails);
            this.Controls.Add(this.companyName);
            this.Controls.Add(this.pathLabel);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.companyList);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView companyList;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label pathLabel;
        private System.Windows.Forms.Label companyName;
        private System.Windows.Forms.Label companyDetails;
        private System.Windows.Forms.Button pathSubmit;
    }
}

