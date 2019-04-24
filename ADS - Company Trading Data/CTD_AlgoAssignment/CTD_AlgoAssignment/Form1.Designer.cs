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
            System.Windows.Forms.ListViewItem listViewItem2 = new System.Windows.Forms.ListViewItem("");
            this.companyList = new System.Windows.Forms.ListView();
            this.pathText = new System.Windows.Forms.TextBox();
            this.pathLabel = new System.Windows.Forms.Label();
            this.companyName = new System.Windows.Forms.Label();
            this.pathSubmit = new System.Windows.Forms.Button();
            this.browseButton = new System.Windows.Forms.Button();
            this.sortButton = new System.Windows.Forms.Button();
            this.searchBox = new System.Windows.Forms.TextBox();
            this.netIncomeLabel = new System.Windows.Forms.Label();
            this.searchButton = new System.Windows.Forms.Button();
            this.searchLabel = new System.Windows.Forms.Label();
            this.totalCompLabel = new System.Windows.Forms.Label();
            this.treeHeightLabel = new System.Windows.Forms.Label();
            this.editButton = new System.Windows.Forms.Button();
            this.removeButton = new System.Windows.Forms.Button();
            this.opIncomeLabel = new System.Windows.Forms.Label();
            this.totalAssetsLabel = new System.Windows.Forms.Label();
            this.numEmployeesLabel = new System.Windows.Forms.Label();
            this.buyLabel = new System.Windows.Forms.Label();
            this.buyList = new System.Windows.Forms.ListView();
            this.tradeButton = new System.Windows.Forms.Button();
            this.tradeLabel = new System.Windows.Forms.Label();
            this.opIncomeBox = new System.Windows.Forms.TextBox();
            this.totalAssetsBox = new System.Windows.Forms.TextBox();
            this.netIncomeBox = new System.Windows.Forms.TextBox();
            this.numEmployeesBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // companyList
            // 
            this.companyList.GridLines = true;
            this.companyList.Items.AddRange(new System.Windows.Forms.ListViewItem[] {
            listViewItem1});
            this.companyList.Location = new System.Drawing.Point(38, 42);
            this.companyList.Name = "companyList";
            this.companyList.Size = new System.Drawing.Size(136, 276);
            this.companyList.TabIndex = 0;
            this.companyList.UseCompatibleStateImageBehavior = false;
            this.companyList.SelectedIndexChanged += new System.EventHandler(this.companyList_SelectedIndexChanged);
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
            this.companyName.Location = new System.Drawing.Point(190, 81);
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
            // netIncomeLabel
            // 
            this.netIncomeLabel.AutoSize = true;
            this.netIncomeLabel.Location = new System.Drawing.Point(190, 105);
            this.netIncomeLabel.Name = "netIncomeLabel";
            this.netIncomeLabel.Size = new System.Drawing.Size(71, 13);
            this.netIncomeLabel.TabIndex = 4;
            this.netIncomeLabel.Text = "Net Income : ";
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
            this.editButton.Click += new System.EventHandler(this.editButton_Click);
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
            // opIncomeLabel
            // 
            this.opIncomeLabel.AutoSize = true;
            this.opIncomeLabel.Location = new System.Drawing.Point(190, 127);
            this.opIncomeLabel.Name = "opIncomeLabel";
            this.opIncomeLabel.Size = new System.Drawing.Size(97, 13);
            this.opIncomeLabel.TabIndex = 15;
            this.opIncomeLabel.Text = "Operating Income :";
            // 
            // totalAssetsLabel
            // 
            this.totalAssetsLabel.AutoSize = true;
            this.totalAssetsLabel.Location = new System.Drawing.Point(190, 152);
            this.totalAssetsLabel.Name = "totalAssetsLabel";
            this.totalAssetsLabel.Size = new System.Drawing.Size(71, 13);
            this.totalAssetsLabel.TabIndex = 16;
            this.totalAssetsLabel.Text = "Total Assets :";
            // 
            // numEmployeesLabel
            // 
            this.numEmployeesLabel.AutoSize = true;
            this.numEmployeesLabel.Location = new System.Drawing.Point(190, 176);
            this.numEmployeesLabel.Name = "numEmployeesLabel";
            this.numEmployeesLabel.Size = new System.Drawing.Size(116, 13);
            this.numEmployeesLabel.TabIndex = 17;
            this.numEmployeesLabel.Text = "Number of Employees :";
            // 
            // buyLabel
            // 
            this.buyLabel.AutoSize = true;
            this.buyLabel.Location = new System.Drawing.Point(190, 200);
            this.buyLabel.Name = "buyLabel";
            this.buyLabel.Size = new System.Drawing.Size(40, 13);
            this.buyLabel.TabIndex = 18;
            this.buyLabel.Text = "Buyer :";
            // 
            // buyList
            // 
            this.buyList.GridLines = true;
            this.buyList.Items.AddRange(new System.Windows.Forms.ListViewItem[] {
            listViewItem2});
            this.buyList.Location = new System.Drawing.Point(193, 222);
            this.buyList.Name = "buyList";
            this.buyList.Size = new System.Drawing.Size(196, 96);
            this.buyList.TabIndex = 19;
            this.buyList.UseCompatibleStateImageBehavior = false;
            this.buyList.SelectedIndexChanged += new System.EventHandler(this.buyList_SelectedIndexChanged);
            // 
            // tradeButton
            // 
            this.tradeButton.Location = new System.Drawing.Point(553, 129);
            this.tradeButton.Name = "tradeButton";
            this.tradeButton.Size = new System.Drawing.Size(75, 60);
            this.tradeButton.TabIndex = 20;
            this.tradeButton.Text = "Biggest Trade Potential";
            this.tradeButton.UseVisualStyleBackColor = true;
            this.tradeButton.Click += new System.EventHandler(this.tradeButton_Click);
            // 
            // tradeLabel
            // 
            this.tradeLabel.AutoSize = true;
            this.tradeLabel.Location = new System.Drawing.Point(553, 200);
            this.tradeLabel.Name = "tradeLabel";
            this.tradeLabel.Size = new System.Drawing.Size(0, 13);
            this.tradeLabel.TabIndex = 21;
            // 
            // opIncomeBox
            // 
            this.opIncomeBox.Location = new System.Drawing.Point(390, 127);
            this.opIncomeBox.Name = "opIncomeBox";
            this.opIncomeBox.Size = new System.Drawing.Size(100, 20);
            this.opIncomeBox.TabIndex = 22;
            // 
            // totalAssetsBox
            // 
            this.totalAssetsBox.Location = new System.Drawing.Point(390, 154);
            this.totalAssetsBox.Name = "totalAssetsBox";
            this.totalAssetsBox.Size = new System.Drawing.Size(100, 20);
            this.totalAssetsBox.TabIndex = 23;
            // 
            // netIncomeBox
            // 
            this.netIncomeBox.Location = new System.Drawing.Point(390, 100);
            this.netIncomeBox.Name = "netIncomeBox";
            this.netIncomeBox.Size = new System.Drawing.Size(100, 20);
            this.netIncomeBox.TabIndex = 24;
            // 
            // numEmployeesBox
            // 
            this.numEmployeesBox.Location = new System.Drawing.Point(390, 181);
            this.numEmployeesBox.Name = "numEmployeesBox";
            this.numEmployeesBox.Size = new System.Drawing.Size(100, 20);
            this.numEmployeesBox.TabIndex = 25;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(773, 450);
            this.Controls.Add(this.numEmployeesBox);
            this.Controls.Add(this.netIncomeBox);
            this.Controls.Add(this.totalAssetsBox);
            this.Controls.Add(this.opIncomeBox);
            this.Controls.Add(this.tradeLabel);
            this.Controls.Add(this.tradeButton);
            this.Controls.Add(this.buyList);
            this.Controls.Add(this.buyLabel);
            this.Controls.Add(this.numEmployeesLabel);
            this.Controls.Add(this.totalAssetsLabel);
            this.Controls.Add(this.opIncomeLabel);
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
            this.Controls.Add(this.netIncomeLabel);
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
        private System.Windows.Forms.Label netIncomeLabel;
        private System.Windows.Forms.Button searchButton;
        private System.Windows.Forms.Label searchLabel;
        private System.Windows.Forms.Label totalCompLabel;
        private System.Windows.Forms.Label treeHeightLabel;
        private System.Windows.Forms.Button editButton;
        private System.Windows.Forms.Button removeButton;
        private System.Windows.Forms.Label opIncomeLabel;
        private System.Windows.Forms.Label totalAssetsLabel;
        private System.Windows.Forms.Label numEmployeesLabel;
        private System.Windows.Forms.Label buyLabel;
        private System.Windows.Forms.ListView buyList;
        private System.Windows.Forms.Button tradeButton;
        private System.Windows.Forms.Label tradeLabel;
        private System.Windows.Forms.TextBox opIncomeBox;
        private System.Windows.Forms.TextBox totalAssetsBox;
        private System.Windows.Forms.TextBox netIncomeBox;
        private System.Windows.Forms.TextBox numEmployeesBox;
    }
}

