namespace ResourseAllocationApp
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
            this.FormTab = new System.Windows.Forms.TabControl();
            this.ResourceTabPage = new System.Windows.Forms.TabPage();
            this.AddResBtn = new System.Windows.Forms.Button();
            this.ResourceDataGrid = new System.Windows.Forms.DataGridView();
            this.ProjectTabPage = new System.Windows.Forms.TabPage();
            this.AddProBtn = new System.Windows.Forms.Button();
            this.ProjectDataGrid = new System.Windows.Forms.DataGridView();
            this.ResourceAllocationTabPage = new System.Windows.Forms.TabPage();
            this.ProjectAllocationDataGrid = new System.Windows.Forms.DataGridView();
            this.ChooseResNameCmbBox = new System.Windows.Forms.ComboBox();
            this.ResNameLbl = new System.Windows.Forms.Label();
            this.ChoosePrjNameCmbBox = new System.Windows.Forms.ComboBox();
            this.ResourceAllocationDataGrid = new System.Windows.Forms.DataGridView();
            this.PrtNameLbl = new System.Windows.Forms.Label();
            this.ResAllocationGrpBox = new System.Windows.Forms.GroupBox();
            this.AddResAllocationBtn = new System.Windows.Forms.Button();
            this.SelectResCmbBox = new System.Windows.Forms.ComboBox();
            this.SelectProCmbBox = new System.Windows.Forms.ComboBox();
            this.ResResAllocationLbl = new System.Windows.Forms.Label();
            this.PrjResAllocationLbl = new System.Windows.Forms.Label();
            this.FormTab.SuspendLayout();
            this.ResourceTabPage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ResourceDataGrid)).BeginInit();
            this.ProjectTabPage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ProjectDataGrid)).BeginInit();
            this.ResourceAllocationTabPage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ProjectAllocationDataGrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ResourceAllocationDataGrid)).BeginInit();
            this.ResAllocationGrpBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // FormTab
            // 
            this.FormTab.Controls.Add(this.ResourceTabPage);
            this.FormTab.Controls.Add(this.ProjectTabPage);
            this.FormTab.Controls.Add(this.ResourceAllocationTabPage);
            this.FormTab.Location = new System.Drawing.Point(2, 2);
            this.FormTab.Margin = new System.Windows.Forms.Padding(2);
            this.FormTab.Name = "FormTab";
            this.FormTab.SelectedIndex = 0;
            this.FormTab.Size = new System.Drawing.Size(614, 610);
            this.FormTab.TabIndex = 0;
            // 
            // ResourceTabPage
            // 
            this.ResourceTabPage.Controls.Add(this.AddResBtn);
            this.ResourceTabPage.Controls.Add(this.ResourceDataGrid);
            this.ResourceTabPage.Location = new System.Drawing.Point(4, 22);
            this.ResourceTabPage.Margin = new System.Windows.Forms.Padding(2);
            this.ResourceTabPage.Name = "ResourceTabPage";
            this.ResourceTabPage.Padding = new System.Windows.Forms.Padding(2);
            this.ResourceTabPage.Size = new System.Drawing.Size(606, 584);
            this.ResourceTabPage.TabIndex = 0;
            this.ResourceTabPage.Text = "                       Resources                       ";
            this.ResourceTabPage.UseVisualStyleBackColor = true;
            // 
            // AddResBtn
            // 
            this.AddResBtn.Location = new System.Drawing.Point(531, 5);
            this.AddResBtn.Margin = new System.Windows.Forms.Padding(2);
            this.AddResBtn.Name = "AddResBtn";
            this.AddResBtn.Size = new System.Drawing.Size(56, 29);
            this.AddResBtn.TabIndex = 1;
            this.AddResBtn.Text = "+ Add";
            this.AddResBtn.UseVisualStyleBackColor = true;
            this.AddResBtn.Click += new System.EventHandler(this.AddResBtn_ClickAsync);
            // 
            // ResourceDataGrid
            // 
            this.ResourceDataGrid.AllowUserToOrderColumns = true;
            this.ResourceDataGrid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.ResourceDataGrid.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedHeaders;
            this.ResourceDataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ResourceDataGrid.Location = new System.Drawing.Point(4, 37);
            this.ResourceDataGrid.Margin = new System.Windows.Forms.Padding(2);
            this.ResourceDataGrid.Name = "ResourceDataGrid";
            this.ResourceDataGrid.RowTemplate.Height = 24;
            this.ResourceDataGrid.Size = new System.Drawing.Size(597, 543);
            this.ResourceDataGrid.TabIndex = 0;
            // 
            // ProjectTabPage
            // 
            this.ProjectTabPage.Controls.Add(this.AddProBtn);
            this.ProjectTabPage.Controls.Add(this.ProjectDataGrid);
            this.ProjectTabPage.Location = new System.Drawing.Point(4, 22);
            this.ProjectTabPage.Margin = new System.Windows.Forms.Padding(2);
            this.ProjectTabPage.Name = "ProjectTabPage";
            this.ProjectTabPage.Padding = new System.Windows.Forms.Padding(2);
            this.ProjectTabPage.Size = new System.Drawing.Size(606, 584);
            this.ProjectTabPage.TabIndex = 1;
            this.ProjectTabPage.Text = "                       Projects                        ";
            this.ProjectTabPage.UseVisualStyleBackColor = true;
            // 
            // AddProBtn
            // 
            this.AddProBtn.Location = new System.Drawing.Point(532, 3);
            this.AddProBtn.Margin = new System.Windows.Forms.Padding(2);
            this.AddProBtn.Name = "AddProBtn";
            this.AddProBtn.Size = new System.Drawing.Size(56, 29);
            this.AddProBtn.TabIndex = 3;
            this.AddProBtn.Text = "+ Add";
            this.AddProBtn.UseVisualStyleBackColor = true;
            this.AddProBtn.Click += new System.EventHandler(this.AddProBtn_ClickAsync);
            // 
            // ProjectDataGrid
            // 
            this.ProjectDataGrid.AllowUserToOrderColumns = true;
            this.ProjectDataGrid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.ProjectDataGrid.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedHeaders;
            this.ProjectDataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ProjectDataGrid.Location = new System.Drawing.Point(5, 35);
            this.ProjectDataGrid.Margin = new System.Windows.Forms.Padding(2);
            this.ProjectDataGrid.Name = "ProjectDataGrid";
            this.ProjectDataGrid.RowTemplate.Height = 24;
            this.ProjectDataGrid.Size = new System.Drawing.Size(596, 545);
            this.ProjectDataGrid.TabIndex = 2;
            // 
            // ResourceAllocationTabPage
            // 
            this.ResourceAllocationTabPage.Controls.Add(this.ProjectAllocationDataGrid);
            this.ResourceAllocationTabPage.Controls.Add(this.ChooseResNameCmbBox);
            this.ResourceAllocationTabPage.Controls.Add(this.ResNameLbl);
            this.ResourceAllocationTabPage.Controls.Add(this.ChoosePrjNameCmbBox);
            this.ResourceAllocationTabPage.Controls.Add(this.ResourceAllocationDataGrid);
            this.ResourceAllocationTabPage.Controls.Add(this.PrtNameLbl);
            this.ResourceAllocationTabPage.Controls.Add(this.ResAllocationGrpBox);
            this.ResourceAllocationTabPage.Location = new System.Drawing.Point(4, 22);
            this.ResourceAllocationTabPage.Margin = new System.Windows.Forms.Padding(2);
            this.ResourceAllocationTabPage.Name = "ResourceAllocationTabPage";
            this.ResourceAllocationTabPage.Padding = new System.Windows.Forms.Padding(2);
            this.ResourceAllocationTabPage.Size = new System.Drawing.Size(606, 584);
            this.ResourceAllocationTabPage.TabIndex = 2;
            this.ResourceAllocationTabPage.Text = "                  Resource Allocation                  ";
            this.ResourceAllocationTabPage.UseVisualStyleBackColor = true;
            // 
            // ProjectAllocationDataGrid
            // 
            this.ProjectAllocationDataGrid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.ProjectAllocationDataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ProjectAllocationDataGrid.Location = new System.Drawing.Point(6, 395);
            this.ProjectAllocationDataGrid.Name = "ProjectAllocationDataGrid";
            this.ProjectAllocationDataGrid.Size = new System.Drawing.Size(594, 180);
            this.ProjectAllocationDataGrid.TabIndex = 8;
            // 
            // ChooseResNameCmbBox
            // 
            this.ChooseResNameCmbBox.FormattingEnabled = true;
            this.ChooseResNameCmbBox.Location = new System.Drawing.Point(127, 368);
            this.ChooseResNameCmbBox.Name = "ChooseResNameCmbBox";
            this.ChooseResNameCmbBox.Size = new System.Drawing.Size(417, 21);
            this.ChooseResNameCmbBox.TabIndex = 7;
            this.ChooseResNameCmbBox.SelectedIndexChanged += new System.EventHandler(this.ChooseResNameCmbBox_SelectedIndexChangedAsync);
            // 
            // ResNameLbl
            // 
            this.ResNameLbl.AutoSize = true;
            this.ResNameLbl.Location = new System.Drawing.Point(27, 371);
            this.ResNameLbl.Name = "ResNameLbl";
            this.ResNameLbl.Size = new System.Drawing.Size(90, 13);
            this.ResNameLbl.TabIndex = 6;
            this.ResNameLbl.Text = "Resource Name :";
            // 
            // ChoosePrjNameCmbBox
            // 
            this.ChoosePrjNameCmbBox.FormattingEnabled = true;
            this.ChoosePrjNameCmbBox.Location = new System.Drawing.Point(127, 163);
            this.ChoosePrjNameCmbBox.Name = "ChoosePrjNameCmbBox";
            this.ChoosePrjNameCmbBox.Size = new System.Drawing.Size(417, 21);
            this.ChoosePrjNameCmbBox.TabIndex = 5;
            this.ChoosePrjNameCmbBox.SelectedIndexChanged += new System.EventHandler(this.ChoosePrjNameCmbBox_SelectedIndexChangedAsync);
            // 
            // ResourceAllocationDataGrid
            // 
            this.ResourceAllocationDataGrid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.ResourceAllocationDataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ResourceAllocationDataGrid.Location = new System.Drawing.Point(7, 194);
            this.ResourceAllocationDataGrid.Name = "ResourceAllocationDataGrid";
            this.ResourceAllocationDataGrid.Size = new System.Drawing.Size(593, 168);
            this.ResourceAllocationDataGrid.TabIndex = 4;
            // 
            // PrtNameLbl
            // 
            this.PrtNameLbl.AutoSize = true;
            this.PrtNameLbl.Location = new System.Drawing.Point(27, 166);
            this.PrtNameLbl.Name = "PrtNameLbl";
            this.PrtNameLbl.Size = new System.Drawing.Size(77, 13);
            this.PrtNameLbl.TabIndex = 2;
            this.PrtNameLbl.Text = "Project Name :";
            // 
            // ResAllocationGrpBox
            // 
            this.ResAllocationGrpBox.Controls.Add(this.AddResAllocationBtn);
            this.ResAllocationGrpBox.Controls.Add(this.SelectResCmbBox);
            this.ResAllocationGrpBox.Controls.Add(this.SelectProCmbBox);
            this.ResAllocationGrpBox.Controls.Add(this.ResResAllocationLbl);
            this.ResAllocationGrpBox.Controls.Add(this.PrjResAllocationLbl);
            this.ResAllocationGrpBox.Location = new System.Drawing.Point(7, 6);
            this.ResAllocationGrpBox.Name = "ResAllocationGrpBox";
            this.ResAllocationGrpBox.Size = new System.Drawing.Size(593, 145);
            this.ResAllocationGrpBox.TabIndex = 0;
            this.ResAllocationGrpBox.TabStop = false;
            this.ResAllocationGrpBox.Text = "ResourceAllocation";
            // 
            // AddResAllocationBtn
            // 
            this.AddResAllocationBtn.Location = new System.Drawing.Point(499, 109);
            this.AddResAllocationBtn.Margin = new System.Windows.Forms.Padding(2);
            this.AddResAllocationBtn.Name = "AddResAllocationBtn";
            this.AddResAllocationBtn.Size = new System.Drawing.Size(67, 29);
            this.AddResAllocationBtn.TabIndex = 4;
            this.AddResAllocationBtn.Text = "+ Add";
            this.AddResAllocationBtn.UseVisualStyleBackColor = true;
            this.AddResAllocationBtn.Click += new System.EventHandler(this.AddResAllocationBtn_ClickAsync);
            // 
            // SelectResCmbBox
            // 
            this.SelectResCmbBox.FormattingEnabled = true;
            this.SelectResCmbBox.Location = new System.Drawing.Point(120, 74);
            this.SelectResCmbBox.Name = "SelectResCmbBox";
            this.SelectResCmbBox.Size = new System.Drawing.Size(417, 21);
            this.SelectResCmbBox.TabIndex = 3;
            // 
            // SelectProCmbBox
            // 
            this.SelectProCmbBox.FormattingEnabled = true;
            this.SelectProCmbBox.Location = new System.Drawing.Point(120, 29);
            this.SelectProCmbBox.Name = "SelectProCmbBox";
            this.SelectProCmbBox.Size = new System.Drawing.Size(417, 21);
            this.SelectProCmbBox.TabIndex = 2;
            this.SelectProCmbBox.SelectedIndexChanged += new System.EventHandler(this.SelectProCmbBox_SelectedIndexChangedAsync);
            // 
            // ResResAllocationLbl
            // 
            this.ResResAllocationLbl.AutoSize = true;
            this.ResResAllocationLbl.Location = new System.Drawing.Point(38, 77);
            this.ResResAllocationLbl.Name = "ResResAllocationLbl";
            this.ResResAllocationLbl.Size = new System.Drawing.Size(59, 13);
            this.ResResAllocationLbl.TabIndex = 1;
            this.ResResAllocationLbl.Text = "Resource :";
            // 
            // PrjResAllocationLbl
            // 
            this.PrjResAllocationLbl.AutoSize = true;
            this.PrjResAllocationLbl.Location = new System.Drawing.Point(51, 32);
            this.PrjResAllocationLbl.Name = "PrjResAllocationLbl";
            this.PrjResAllocationLbl.Size = new System.Drawing.Size(46, 13);
            this.PrjResAllocationLbl.TabIndex = 0;
            this.PrjResAllocationLbl.Text = "Project :";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(618, 611);
            this.Controls.Add(this.FormTab);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_LoadAsync);
            this.FormTab.ResumeLayout(false);
            this.ResourceTabPage.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.ResourceDataGrid)).EndInit();
            this.ProjectTabPage.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.ProjectDataGrid)).EndInit();
            this.ResourceAllocationTabPage.ResumeLayout(false);
            this.ResourceAllocationTabPage.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ProjectAllocationDataGrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ResourceAllocationDataGrid)).EndInit();
            this.ResAllocationGrpBox.ResumeLayout(false);
            this.ResAllocationGrpBox.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl FormTab;
        private System.Windows.Forms.TabPage ResourceTabPage;
        private System.Windows.Forms.Button AddResBtn;
        public System.Windows.Forms.DataGridView ResourceDataGrid;
        private System.Windows.Forms.TabPage ProjectTabPage;
        private System.Windows.Forms.TabPage ResourceAllocationTabPage;
        private System.Windows.Forms.Button AddProBtn;
        public System.Windows.Forms.DataGridView ProjectDataGrid;
        private System.Windows.Forms.DataGridView ResourceAllocationDataGrid;
        private System.Windows.Forms.Label PrtNameLbl;
        private System.Windows.Forms.GroupBox ResAllocationGrpBox;
        private System.Windows.Forms.ComboBox ChoosePrjNameCmbBox;
        private System.Windows.Forms.Button AddResAllocationBtn;
        private System.Windows.Forms.ComboBox SelectResCmbBox;
        private System.Windows.Forms.ComboBox SelectProCmbBox;
        private System.Windows.Forms.Label ResResAllocationLbl;
        private System.Windows.Forms.Label PrjResAllocationLbl;
        private System.Windows.Forms.ComboBox ChooseResNameCmbBox;
        private System.Windows.Forms.Label ResNameLbl;
        private System.Windows.Forms.DataGridView ProjectAllocationDataGrid;
    }
}

