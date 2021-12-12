namespace NameSorter
{
    partial class NameSorter
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
            this.openFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.btnBrowseFile = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.tbFileName = new System.Windows.Forms.TextBox();
            this.btnSortName = new System.Windows.Forms.Button();
            this.rtbBefore = new System.Windows.Forms.RichTextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.rtbAfter = new System.Windows.Forms.RichTextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnBrowseFile
            // 
            this.btnBrowseFile.Location = new System.Drawing.Point(50, 57);
            this.btnBrowseFile.Name = "btnBrowseFile";
            this.btnBrowseFile.Size = new System.Drawing.Size(75, 23);
            this.btnBrowseFile.TabIndex = 0;
            this.btnBrowseFile.Text = "Browse...";
            this.btnBrowseFile.UseVisualStyleBackColor = true;
            this.btnBrowseFile.Click += new System.EventHandler(this.btnBrowseFile_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(15, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(29, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "File :";
            // 
            // tbFileName
            // 
            this.tbFileName.Location = new System.Drawing.Point(50, 12);
            this.tbFileName.Multiline = true;
            this.tbFileName.Name = "tbFileName";
            this.tbFileName.ReadOnly = true;
            this.tbFileName.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.tbFileName.Size = new System.Drawing.Size(328, 39);
            this.tbFileName.TabIndex = 2;
            // 
            // btnSortName
            // 
            this.btnSortName.Location = new System.Drawing.Point(131, 57);
            this.btnSortName.Name = "btnSortName";
            this.btnSortName.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btnSortName.Size = new System.Drawing.Size(75, 23);
            this.btnSortName.TabIndex = 3;
            this.btnSortName.Text = "Sort";
            this.btnSortName.UseVisualStyleBackColor = true;
            this.btnSortName.Click += new System.EventHandler(this.btnSortName_Click);
            // 
            // rtbBefore
            // 
            this.rtbBefore.Location = new System.Drawing.Point(18, 102);
            this.rtbBefore.Name = "rtbBefore";
            this.rtbBefore.ReadOnly = true;
            this.rtbBefore.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.ForcedVertical;
            this.rtbBefore.Size = new System.Drawing.Size(239, 176);
            this.rtbBefore.TabIndex = 4;
            this.rtbBefore.Text = "";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(15, 86);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Unsorted :";
            // 
            // rtbAfter
            // 
            this.rtbAfter.Location = new System.Drawing.Point(276, 102);
            this.rtbAfter.Name = "rtbAfter";
            this.rtbAfter.ReadOnly = true;
            this.rtbAfter.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.ForcedVertical;
            this.rtbAfter.Size = new System.Drawing.Size(239, 176);
            this.rtbAfter.TabIndex = 6;
            this.rtbAfter.Text = "";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(273, 86);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(44, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Sorted :";
            // 
            // NameSorter
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(533, 290);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.rtbAfter);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.rtbBefore);
            this.Controls.Add(this.btnSortName);
            this.Controls.Add(this.tbFileName);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnBrowseFile);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "NameSorter";
            this.Text = "Name Sorter";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.OpenFileDialog openFileDialog;
        private System.Windows.Forms.Button btnBrowseFile;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbFileName;
        private System.Windows.Forms.Button btnSortName;
        private System.Windows.Forms.RichTextBox rtbBefore;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.RichTextBox rtbAfter;
    }
}

