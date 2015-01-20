namespace CodeChallenge7 {
    partial class Form1 {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            this.cmdValidate = new System.Windows.Forms.Button();
            this.txtISBN = new System.Windows.Forms.TextBox();
            this.lblResult = new System.Windows.Forms.Label();
            this.cmdGenerate = new System.Windows.Forms.Button();
            this.lblNewISBN = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // cmdValidate
            // 
            this.cmdValidate.Location = new System.Drawing.Point(25, 33);
            this.cmdValidate.Name = "cmdValidate";
            this.cmdValidate.Size = new System.Drawing.Size(75, 23);
            this.cmdValidate.TabIndex = 0;
            this.cmdValidate.Text = "Validate";
            this.cmdValidate.UseVisualStyleBackColor = true;
            this.cmdValidate.Click += new System.EventHandler(this.cmdValidate_Click);
            // 
            // txtISBN
            // 
            this.txtISBN.Location = new System.Drawing.Point(130, 35);
            this.txtISBN.Name = "txtISBN";
            this.txtISBN.Size = new System.Drawing.Size(133, 20);
            this.txtISBN.TabIndex = 1;
            // 
            // lblResult
            // 
            this.lblResult.AutoSize = true;
            this.lblResult.Location = new System.Drawing.Point(288, 42);
            this.lblResult.Name = "lblResult";
            this.lblResult.Size = new System.Drawing.Size(0, 13);
            this.lblResult.TabIndex = 2;
            // 
            // cmdGenerate
            // 
            this.cmdGenerate.Location = new System.Drawing.Point(25, 74);
            this.cmdGenerate.Name = "cmdGenerate";
            this.cmdGenerate.Size = new System.Drawing.Size(75, 23);
            this.cmdGenerate.TabIndex = 3;
            this.cmdGenerate.Text = "Generate";
            this.cmdGenerate.UseVisualStyleBackColor = true;
            this.cmdGenerate.Click += new System.EventHandler(this.cmdGenerate_Click);
            // 
            // lblNewISBN
            // 
            this.lblNewISBN.AutoSize = true;
            this.lblNewISBN.Location = new System.Drawing.Point(127, 74);
            this.lblNewISBN.Name = "lblNewISBN";
            this.lblNewISBN.Size = new System.Drawing.Size(0, 13);
            this.lblNewISBN.TabIndex = 4;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(449, 124);
            this.Controls.Add(this.lblNewISBN);
            this.Controls.Add(this.cmdGenerate);
            this.Controls.Add(this.lblResult);
            this.Controls.Add(this.txtISBN);
            this.Controls.Add(this.cmdValidate);
            this.Name = "Form1";
            this.Text = "Code Challenge 7 - ISBN";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button cmdValidate;
        private System.Windows.Forms.TextBox txtISBN;
        private System.Windows.Forms.Label lblResult;
        private System.Windows.Forms.Button cmdGenerate;
        private System.Windows.Forms.Label lblNewISBN;
    }
}

