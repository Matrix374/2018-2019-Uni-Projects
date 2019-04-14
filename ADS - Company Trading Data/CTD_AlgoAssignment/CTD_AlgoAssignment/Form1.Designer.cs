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
            this.pathText = new System.Windows.Forms.TextBox();
            this.pathLabel = new System.Windows.Forms.Label();
            this.companyName = new System.Windows.Forms.Label();
            this.pathSubmit = new System.Windows.Forms.Button();
            this.browseButton = new System.Windows.Forms.Button();
            this.sortButton = new System.Windows.Forms.Button();
            this.searchBox = new System.Windows.Forms.TextBox();
            this.companyDetails = new System.Windows.Forms.Label();
            this.searchButton = new System.Windows.Forms.Button();
            this.searchLabel = new System.Windows.Forms.Label();
            this.totalCompLabel = new System.Windows.Forms.Label();
            this.treeHeightLabel = new System.Windows.Forms.Label();
            this.editButton = new System.Windows.Forms.Button();
            this.removeButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // companyList
            // 
            this.companyList.Items.AddRange(new System.Windows.Forms.ListViewItem[] {
            listViewItem1});
            this.companyList.Location = new System.Drawing.Point(38, 42);
            this.companyList.Name = "companyList";
            this.companyList.Size = new System.Drawing.Size(136, 276);
            this.companyList.TabIndex = 0;
            this.companyList.UseCompatibleStateImageBehavior = false;
            // 
            // pathText
            // 
            this.pathText.Location = new System.Drawing.Point(38, 404);
            this.pathText.Name = "pathText";
            this.pathText.Size = new System.Drawing.Size(492, 20);
            this.pathText.TabIndex = 1;
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
            this.companyName.Location = new System.Drawing.Point(190, 78);
            this.companyName.Name = "companyName";
            this.companyName.Size = new System.Drawing.Size(82, 13);
            this.companyName.TabIndex = 3;
            this.companyName.Text = "Company Name";
            // 
            // pathSubmit
            // 
            this.pathSubmit.Location = new System.Drawing.Point(669, 401);
            this.pathSubmit.Name = "pathSubmit";
            this.pathSubmit.Size = new System.Drawing.Size(75, 23);
            this.pathSubmit.TabIndex = 5;
            this.pathSubmit.Text = "Get Data";
            this.pathSubmit.UseVisualStyleBackColor = true;
            this.pathSubmit.Click += new System.EventHandler(this.pathSubmit_Click);
            // 
            // browseButton
            // 
            this.browseButton.Location = new System.Drawing.Point(568, 401);
            this.browseButton.Name = "browseButton";
            this.browseButton.Size = new System.Drawing.Size(75, 23);
            this.browseButton.TabIndex = 6;
            this.browseButton.Text = "Browse";
            this.browseButton.UseVisualStyleBackColor = true;
            this.browseButton.Click += new System.EventHandler(this.browseButton_Click);
            // 
            // sortButton
            // 
            this.sortButton.Location = new System.Drawing.Point(38, 13);
            this.sortButton.Name = "sortButton";
            this.sortButton.Size = new System.Drawing.Size(136, 23);
            this.sortButton.TabIndex = 7;
            this.sortButton.Text = "Sort: Alphabetically";
            this.sortButton.UseVisualStyleBackColor = true;
            this.sortButton.Click += new System.EventHandler(this.sortButton_Click);
            // 
            // searchBox
            // 
            this.searchBox.Location = new System.Drawing.Point(193, 42);
            this.searchBox.Name = "searchBox";
            this.searchBox.Size = new System.Drawing.Size(337, 20);
            this.searchBox.TabIndex = 8;
            // 
            // companyDetails
            // 
            this.companyDetails.AutoSize = true;
            this.companyDetails.Location = new System.Drawing.Point(190, 100);
            this.companyDetails.Name = "companyDetails";
            this.companyDetails.Size = new System.Drawing.Size(86, 13);
            this.companyDetails.TabIndex = 4;
            this.companyDetails.Text = "Company Details";
            // 
            // searchButton
            // 
            this.searchButton.Location = new System.Drawing.Point(553, 42);
            this.searchButton.Name = "searchButton";
            this.searchButton.Size = new System.Drawing.Size(75, 23);
            this.searchButton.TabIndex = 9;
            this.searchButton.Text = "Search";
            this.searchButton.UseVisualStyleBackColor = true;
            this.searchButton.Click += new System.EventHandler(this.searchButton_Click);
            // 
            // searchLabel
            // 
            this.searchLabel.AutoSize = true;
            this.searchLabel.Location = new System.Drawing.Point(190, 18);
            this.searchLabel.Name = "searchLabel";
            this.searchLabel.Size = new System.Drawing.Size(82, 13);
            this.searchLabel.TabIndex = 10;
            this.searchLabel.Text = "Find Companies";
            // 
            // totalCompLabel
            // 
            this.totalCompLabel.AutoSize = true;
            this.totalCompLabel.Location = new System.Drawing.Point(38, 330);
            this.totalCompLabel.Name = "totalCompLabel";
            this.totalCompLabel.Size = new System.Drawing.Size(92, 13);
            this.totalCompLabel.TabIndex = 11;
            this.totalCompLabel.Text = "Total Companies :";
            // 
            // treeHeightLabel
            // 
            this.treeHeightLabel.AutoSize = true;
            this.treeHeightLabel.Location = new System.Drawing.Point(38, 352);
            this.treeHeightLabel.Name = "treeHeightLabel";
            this.treeHeightLabel.Size = new System.Drawing.Size(69, 13);
            this.treeHeightLabel.TabIndex = 12;
            this.treeHeightLabel.Text = "Tree Height :";
            // 
            // editButton
            // 
            this.editButton.Location = new System.Drawing.Point(553, 71);
            this.editButton.Name = "editButton";
            this.editButton.Size = new System.Drawing.Size(75, 23);
            this.editButton.TabIndex = 13;
            this.editButton.Text = "Edit";
            this.editButton.UseVisualStyleBackColor = true;
            // 
            // removeButton
            // 
            this.removeButton.Location = new System.Drawing.Point(553, 100);
            this.removeButton.Name = "removeButton";
            this.removeButton.Size = new System.Drawing.Size(75, 23);
            this.removeButton.TabIndex = 14;
            this.removeButton.Text = "Remove";
            this.removeButton.UseVisualStyleBackColor = true;
            this.removeButton.Click += new System.EventHandler(this.removeButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(773, 450);
            this.Controls.Add(this.removeButton);
            this.Controls.Add(this.editButton);
            this.Controls.Add(this.treeHeightLabel);
            this.Controls.Add(this.totalCompLabel);
            this.Controls.Add(this.searchLabel);
            this.Controls.Add(this.searchButton);
            this.Controls.Add(this.searchBox);
            this.Controls.Add(this.sortButton);
            this.Controls.Add(this.browseButton);
            this.Controls.Add(this.pathSubmit);
            this.Controls.Add(this.companyDetails);
            this.Controls.Add(this.companyName);
            this.Controls.Add(this.pathLabel);
            this.Controls.Add(this.pathText);
            this.Controls.Add(this.companyList);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView companyList;
        private System.Windows.Forms.TextBox pathText;
        private System.Windows.Forms.Label pathLabel;
        private System.Windows.Forms.Label companyName;
        private System.Windows.Forms.Button pathSubmit;
        private System.Windows.Forms.Button browseButton;
        private System.Windows.Forms.Button sortButton;
        private System.Windows.Forms.TextBox searchBox;
        private System.Windows.Forms.Label companyDetails;
        private System.Windows.Forms.Button searchButton;
        private System.Windows.Forms.Label searchLabel;
        private System.Windows.Forms.Label totalCompLabel;
        private System.Windows.Forms.Label treeHeightLabel;
        private System.Windows.Forms.Button editButton;
        private System.Windows.Forms.Button removeButton;
    }
}

