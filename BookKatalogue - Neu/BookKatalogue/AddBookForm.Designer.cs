﻿namespace BookKatalogue
{
    partial class AddBookForm
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
            this.tbTitel = new System.Windows.Forms.TextBox();
            this.tbAuthor = new System.Windows.Forms.TextBox();
            this.tbIsbn = new System.Windows.Forms.TextBox();
            this.lblTitle = new System.Windows.Forms.Label();
            this.lblAuthor = new System.Windows.Forms.Label();
            this.lblIsbn = new System.Windows.Forms.Label();
            this.btnOk = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.tbPath = new System.Windows.Forms.TextBox();
            this.lblPath = new System.Windows.Forms.Label();
            this.btnSelectPdf = new System.Windows.Forms.Button();
            this.btnChooseCover = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.tbCoverPath = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // tbTitel
            // 
            this.tbTitel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbTitel.Location = new System.Drawing.Point(12, 204);
            this.tbTitel.Name = "tbTitel";
            this.tbTitel.Size = new System.Drawing.Size(545, 20);
            this.tbTitel.TabIndex = 0;
            this.tbTitel.Text = "Titelname";
            // 
            // tbAuthor
            // 
            this.tbAuthor.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbAuthor.Location = new System.Drawing.Point(12, 252);
            this.tbAuthor.Name = "tbAuthor";
            this.tbAuthor.Size = new System.Drawing.Size(545, 20);
            this.tbAuthor.TabIndex = 1;
            this.tbAuthor.Text = "Authorname";
            // 
            // tbIsbn
            // 
            this.tbIsbn.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbIsbn.Location = new System.Drawing.Point(12, 304);
            this.tbIsbn.Name = "tbIsbn";
            this.tbIsbn.Size = new System.Drawing.Size(545, 20);
            this.tbIsbn.TabIndex = 2;
            this.tbIsbn.Text = "1223-2324-2323-6567";
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Location = new System.Drawing.Point(9, 188);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(27, 13);
            this.lblTitle.TabIndex = 3;
            this.lblTitle.Text = "Titel";
            // 
            // lblAuthor
            // 
            this.lblAuthor.AutoSize = true;
            this.lblAuthor.Location = new System.Drawing.Point(9, 236);
            this.lblAuthor.Name = "lblAuthor";
            this.lblAuthor.Size = new System.Drawing.Size(32, 13);
            this.lblAuthor.TabIndex = 4;
            this.lblAuthor.Text = "Autor";
            // 
            // lblIsbn
            // 
            this.lblIsbn.AutoSize = true;
            this.lblIsbn.Location = new System.Drawing.Point(9, 288);
            this.lblIsbn.Name = "lblIsbn";
            this.lblIsbn.Size = new System.Drawing.Size(32, 13);
            this.lblIsbn.TabIndex = 5;
            this.lblIsbn.Text = "ISBN";
            // 
            // btnOk
            // 
            this.btnOk.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnOk.Location = new System.Drawing.Point(397, 361);
            this.btnOk.Name = "btnOk";
            this.btnOk.Size = new System.Drawing.Size(75, 23);
            this.btnOk.TabIndex = 6;
            this.btnOk.Text = "Ok";
            this.btnOk.UseVisualStyleBackColor = true;
            this.btnOk.Click += new System.EventHandler(this.btnOk_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCancel.Location = new System.Drawing.Point(491, 361);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 7;
            this.btnCancel.Text = "Abbrechen";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // tbPath
            // 
            this.tbPath.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbPath.Enabled = false;
            this.tbPath.Location = new System.Drawing.Point(12, 63);
            this.tbPath.Name = "tbPath";
            this.tbPath.Size = new System.Drawing.Size(545, 20);
            this.tbPath.TabIndex = 8;
            // 
            // lblPath
            // 
            this.lblPath.AutoSize = true;
            this.lblPath.Location = new System.Drawing.Point(9, 47);
            this.lblPath.Name = "lblPath";
            this.lblPath.Size = new System.Drawing.Size(29, 13);
            this.lblPath.TabIndex = 9;
            this.lblPath.Text = "Pfad";
            // 
            // btnSelectPdf
            // 
            this.btnSelectPdf.Location = new System.Drawing.Point(12, 12);
            this.btnSelectPdf.Name = "btnSelectPdf";
            this.btnSelectPdf.Size = new System.Drawing.Size(102, 23);
            this.btnSelectPdf.TabIndex = 10;
            this.btnSelectPdf.Text = "PDF auswählen";
            this.btnSelectPdf.UseVisualStyleBackColor = true;
            this.btnSelectPdf.Click += new System.EventHandler(this.btnSelectPdf_Click);
            // 
            // btnChooseCover
            // 
            this.btnChooseCover.Location = new System.Drawing.Point(12, 101);
            this.btnChooseCover.Name = "btnChooseCover";
            this.btnChooseCover.Size = new System.Drawing.Size(102, 23);
            this.btnChooseCover.TabIndex = 13;
            this.btnChooseCover.Text = "Cover auswählen";
            this.btnChooseCover.UseVisualStyleBackColor = true;
            this.btnChooseCover.Click += new System.EventHandler(this.btnChooseCover_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 136);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(45, 13);
            this.label1.TabIndex = 12;
            this.label1.Text = "Bildpfad";
            // 
            // tbCoverPath
            // 
            this.tbCoverPath.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbCoverPath.Enabled = false;
            this.tbCoverPath.Location = new System.Drawing.Point(12, 152);
            this.tbCoverPath.Name = "tbCoverPath";
            this.tbCoverPath.Size = new System.Drawing.Size(545, 20);
            this.tbCoverPath.TabIndex = 11;
            // 
            // AddBookForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(581, 396);
            this.Controls.Add(this.btnChooseCover);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tbCoverPath);
            this.Controls.Add(this.btnSelectPdf);
            this.Controls.Add(this.lblPath);
            this.Controls.Add(this.tbPath);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnOk);
            this.Controls.Add(this.lblIsbn);
            this.Controls.Add(this.lblAuthor);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.tbIsbn);
            this.Controls.Add(this.tbAuthor);
            this.Controls.Add(this.tbTitel);
            this.Name = "AddBookForm";
            this.Text = "AddBookForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbTitel;
        private System.Windows.Forms.TextBox tbAuthor;
        private System.Windows.Forms.TextBox tbIsbn;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label lblAuthor;
        private System.Windows.Forms.Label lblIsbn;
        private System.Windows.Forms.Button btnOk;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.TextBox tbPath;
        private System.Windows.Forms.Label lblPath;
        private System.Windows.Forms.Button btnSelectPdf;
        private System.Windows.Forms.Button btnChooseCover;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbCoverPath;
    }
}