namespace ResourseAllocationApp
{
    partial class ResourceEntryForm
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
            this.NameEntryLbl = new System.Windows.Forms.Label();
            this.EmailEntryLbl = new System.Windows.Forms.Label();
            this.ThresholdEntryLbl = new System.Windows.Forms.Label();
            this.NameResEntryTxtBox = new System.Windows.Forms.TextBox();
            this.EmailResEntryTxtBox = new System.Windows.Forms.TextBox();
            this.ThresholdResEntryTxtBox = new System.Windows.Forms.TextBox();
            this.SaveResEntryBtn = new System.Windows.Forms.Button();
            this.CancelResEntryBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // NameEntryLbl
            // 
            this.NameEntryLbl.AutoSize = true;
            this.NameEntryLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NameEntryLbl.Location = new System.Drawing.Point(39, 37);
            this.NameEntryLbl.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.NameEntryLbl.Name = "NameEntryLbl";
            this.NameEntryLbl.Size = new System.Drawing.Size(89, 17);
            this.NameEntryLbl.TabIndex = 0;
            this.NameEntryLbl.Text = "Name       :";
            // 
            // EmailEntryLbl
            // 
            this.EmailEntryLbl.AutoSize = true;
            this.EmailEntryLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EmailEntryLbl.Location = new System.Drawing.Point(39, 77);
            this.EmailEntryLbl.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.EmailEntryLbl.Name = "EmailEntryLbl";
            this.EmailEntryLbl.Size = new System.Drawing.Size(87, 17);
            this.EmailEntryLbl.TabIndex = 1;
            this.EmailEntryLbl.Text = "Email       :";
            // 
            // ThresholdEntryLbl
            // 
            this.ThresholdEntryLbl.AutoSize = true;
            this.ThresholdEntryLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ThresholdEntryLbl.Location = new System.Drawing.Point(37, 118);
            this.ThresholdEntryLbl.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.ThresholdEntryLbl.Name = "ThresholdEntryLbl";
            this.ThresholdEntryLbl.Size = new System.Drawing.Size(91, 17);
            this.ThresholdEntryLbl.TabIndex = 2;
            this.ThresholdEntryLbl.Text = "Threshold :";
            // 
            // NameResEntryTxtBox
            // 
            this.NameResEntryTxtBox.Location = new System.Drawing.Point(130, 37);
            this.NameResEntryTxtBox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.NameResEntryTxtBox.Name = "NameResEntryTxtBox";
            this.NameResEntryTxtBox.Size = new System.Drawing.Size(191, 20);
            this.NameResEntryTxtBox.TabIndex = 3;
            // 
            // EmailResEntryTxtBox
            // 
            this.EmailResEntryTxtBox.Location = new System.Drawing.Point(130, 76);
            this.EmailResEntryTxtBox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.EmailResEntryTxtBox.Name = "EmailResEntryTxtBox";
            this.EmailResEntryTxtBox.Size = new System.Drawing.Size(191, 20);
            this.EmailResEntryTxtBox.TabIndex = 4;
            // 
            // ThresholdResEntryTxtBox
            // 
            this.ThresholdResEntryTxtBox.Location = new System.Drawing.Point(130, 115);
            this.ThresholdResEntryTxtBox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.ThresholdResEntryTxtBox.Name = "ThresholdResEntryTxtBox";
            this.ThresholdResEntryTxtBox.Size = new System.Drawing.Size(191, 20);
            this.ThresholdResEntryTxtBox.TabIndex = 5;
            // 
            // SaveResEntryBtn
            // 
            this.SaveResEntryBtn.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.SaveResEntryBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SaveResEntryBtn.Location = new System.Drawing.Point(297, 158);
            this.SaveResEntryBtn.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.SaveResEntryBtn.Name = "SaveResEntryBtn";
            this.SaveResEntryBtn.Size = new System.Drawing.Size(56, 29);
            this.SaveResEntryBtn.TabIndex = 6;
            this.SaveResEntryBtn.Text = "Save";
            this.SaveResEntryBtn.UseVisualStyleBackColor = false;
            this.SaveResEntryBtn.Click += new System.EventHandler(this.SaveResEntryBtn_ClickAsync);
            // 
            // CancelResEntryBtn
            // 
            this.CancelResEntryBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.CancelResEntryBtn.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.CancelResEntryBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CancelResEntryBtn.Location = new System.Drawing.Point(207, 158);
            this.CancelResEntryBtn.Name = "CancelResEntryBtn";
            this.CancelResEntryBtn.Size = new System.Drawing.Size(69, 29);
            this.CancelResEntryBtn.TabIndex = 7;
            this.CancelResEntryBtn.Text = "Cancel";
            this.CancelResEntryBtn.UseVisualStyleBackColor = false;
            // 
            // ResourceEntryForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(381, 206);
            this.Controls.Add(this.CancelResEntryBtn);
            this.Controls.Add(this.SaveResEntryBtn);
            this.Controls.Add(this.ThresholdResEntryTxtBox);
            this.Controls.Add(this.EmailResEntryTxtBox);
            this.Controls.Add(this.NameResEntryTxtBox);
            this.Controls.Add(this.ThresholdEntryLbl);
            this.Controls.Add(this.EmailEntryLbl);
            this.Controls.Add(this.NameEntryLbl);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "ResourceEntryForm";
            this.Text = "EntryForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label NameEntryLbl;
        private System.Windows.Forms.Label EmailEntryLbl;
        private System.Windows.Forms.Label ThresholdEntryLbl;
        private System.Windows.Forms.TextBox NameResEntryTxtBox;
        private System.Windows.Forms.TextBox EmailResEntryTxtBox;
        private System.Windows.Forms.TextBox ThresholdResEntryTxtBox;
        private System.Windows.Forms.Button SaveResEntryBtn;
        private System.Windows.Forms.Button CancelResEntryBtn;
    }
}