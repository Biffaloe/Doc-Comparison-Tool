namespace Document_Compare_Tool
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
            this.btnCompare = new System.Windows.Forms.Button();
            this.txtboxResults = new System.Windows.Forms.TextBox();
            this.lblDoc2 = new System.Windows.Forms.Label();
            this.btnSelect1 = new System.Windows.Forms.Button();
            this.lblDoc1 = new System.Windows.Forms.Label();
            this.btnSelect2 = new System.Windows.Forms.Button();
            this.lblProcessing = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnCompare
            // 
            this.btnCompare.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCompare.Location = new System.Drawing.Point(219, 94);
            this.btnCompare.Name = "btnCompare";
            this.btnCompare.Size = new System.Drawing.Size(139, 28);
            this.btnCompare.TabIndex = 0;
            this.btnCompare.Text = "Compare";
            this.btnCompare.UseVisualStyleBackColor = true;
            this.btnCompare.Click += new System.EventHandler(this.btnCompare_Click);
            // 
            // txtboxResults
            // 
            this.txtboxResults.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtboxResults.BackColor = System.Drawing.Color.Gainsboro;
            this.txtboxResults.Location = new System.Drawing.Point(12, 128);
            this.txtboxResults.MaxLength = 100000;
            this.txtboxResults.Multiline = true;
            this.txtboxResults.Name = "txtboxResults";
            this.txtboxResults.ReadOnly = true;
            this.txtboxResults.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.txtboxResults.Size = new System.Drawing.Size(367, 532);
            this.txtboxResults.TabIndex = 1;
            // 
            // lblDoc2
            // 
            this.lblDoc2.AutoSize = true;
            this.lblDoc2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDoc2.Location = new System.Drawing.Point(17, 54);
            this.lblDoc2.Name = "lblDoc2";
            this.lblDoc2.Size = new System.Drawing.Size(168, 16);
            this.lblDoc2.TabIndex = 2;
            this.lblDoc2.Text = "Document 2 (txt doc format)";
            // 
            // btnSelect1
            // 
            this.btnSelect1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSelect1.Location = new System.Drawing.Point(20, 28);
            this.btnSelect1.Name = "btnSelect1";
            this.btnSelect1.Size = new System.Drawing.Size(86, 23);
            this.btnSelect1.TabIndex = 4;
            this.btnSelect1.Text = "Select";
            this.btnSelect1.UseVisualStyleBackColor = true;
            this.btnSelect1.Click += new System.EventHandler(this.btnSelect1_Click);
            // 
            // lblDoc1
            // 
            this.lblDoc1.AutoSize = true;
            this.lblDoc1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDoc1.Location = new System.Drawing.Point(17, 9);
            this.lblDoc1.Name = "lblDoc1";
            this.lblDoc1.Size = new System.Drawing.Size(168, 16);
            this.lblDoc1.TabIndex = 3;
            this.lblDoc1.Text = "Document 1 (txt doc format)";
            // 
            // btnSelect2
            // 
            this.btnSelect2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSelect2.Location = new System.Drawing.Point(20, 73);
            this.btnSelect2.Name = "btnSelect2";
            this.btnSelect2.Size = new System.Drawing.Size(86, 23);
            this.btnSelect2.TabIndex = 5;
            this.btnSelect2.Text = "Select";
            this.btnSelect2.UseVisualStyleBackColor = true;
            this.btnSelect2.Click += new System.EventHandler(this.btnSelect2_Click);
            // 
            // lblProcessing
            // 
            this.lblProcessing.AutoSize = true;
            this.lblProcessing.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProcessing.Location = new System.Drawing.Point(16, 217);
            this.lblProcessing.Name = "lblProcessing";
            this.lblProcessing.Size = new System.Drawing.Size(363, 120);
            this.lblProcessing.TabIndex = 6;
            this.lblProcessing.Text = "Processing...\r\nThe program may seem unresponsive but \r\ndon\'t worry. Thats merely " +
    "the result of Kevin \r\nnot wanting to deal with \r\nasynchronous programming.\r\nProc" +
    "essing...";
            this.lblProcessing.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(391, 672);
            this.Controls.Add(this.lblProcessing);
            this.Controls.Add(this.btnSelect2);
            this.Controls.Add(this.btnSelect1);
            this.Controls.Add(this.lblDoc1);
            this.Controls.Add(this.lblDoc2);
            this.Controls.Add(this.txtboxResults);
            this.Controls.Add(this.btnCompare);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnCompare;
        private System.Windows.Forms.TextBox txtboxResults;
        private System.Windows.Forms.Label lblDoc2;
        private System.Windows.Forms.Button btnSelect1;
        private System.Windows.Forms.Label lblDoc1;
        private System.Windows.Forms.Button btnSelect2;
        private System.Windows.Forms.Label lblProcessing;
    }
}

