namespace ResourseAllocationApp
{
    partial class ProjectEntryForm
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
            this.NameProEntryTxtBox = new System.Windows.Forms.TextBox();
            this.ProjectNameLbl = new System.Windows.Forms.Label();
            this.CancelProEntryBtn = new System.Windows.Forms.Button();
            this.SaveProEntryBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // NameProEntryTxtBox
            // 
            this.NameProEntryTxtBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NameProEntryTxtBox.Location = new System.Drawing.Point(138, 50);
            this.NameProEntryTxtBox.Name = "NameProEntryTxtBox";
            this.NameProEntryTxtBox.Size = new System.Drawing.Size(231, 20);
            this.NameProEntryTxtBox.TabIndex = 0;
            // 
            // ProjectNameLbl
            // 
            this.ProjectNameLbl.AutoSize = true;
            this.ProjectNameLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ProjectNameLbl.Location = new System.Drawing.Point(12, 51);
            this.ProjectNameLbl.Name = "ProjectNameLbl";
            this.ProjectNameLbl.Size = new System.Drawing.Size(114, 16);
            this.ProjectNameLbl.TabIndex = 1;
            this.ProjectNameLbl.Text = "Project Name  :";
            // 
            // CancelProEntryBtn
            // 
            this.CancelProEntryBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.CancelProEntryBtn.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.CancelProEntryBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CancelProEntryBtn.Location = new System.Drawing.Point(211, 107);
            this.CancelProEntryBtn.Name = "CancelProEntryBtn";
            this.CancelProEntryBtn.Size = new System.Drawing.Size(69, 29);
            this.CancelProEntryBtn.TabIndex = 9;
            this.CancelProEntryBtn.Text = "Cancel";
            this.CancelProEntryBtn.UseVisualStyleBackColor = false;
            // 
            // SaveProEntryBtn
            // 
            this.SaveProEntryBtn.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.SaveProEntryBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SaveProEntryBtn.Location = new System.Drawing.Point(301, 107);
            this.SaveProEntryBtn.Margin = new System.Windows.Forms.Padding(2);
            this.SaveProEntryBtn.Name = "SaveProEntryBtn";
            this.SaveProEntryBtn.Size = new System.Drawing.Size(56, 29);
            this.SaveProEntryBtn.TabIndex = 8;
            this.SaveProEntryBtn.Text = "Save";
            this.SaveProEntryBtn.UseVisualStyleBackColor = false;
            this.SaveProEntryBtn.Click += new System.EventHandler(this.SaveProEntryBtn_ClickAsync);
            // 
            // ProjectEntryForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(381, 160);
            this.Controls.Add(this.CancelProEntryBtn);
            this.Controls.Add(this.SaveProEntryBtn);
            this.Controls.Add(this.ProjectNameLbl);
            this.Controls.Add(this.NameProEntryTxtBox);
            this.Name = "ProjectEntryForm";
            this.Text = "ProjectEntryForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox NameProEntryTxtBox;
        private System.Windows.Forms.Label ProjectNameLbl;
        private System.Windows.Forms.Button CancelProEntryBtn;
        private System.Windows.Forms.Button SaveProEntryBtn;
    }
}