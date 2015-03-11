namespace WH1602_RUS_Encoder
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
            this.label1 = new System.Windows.Forms.Label();
            this.original = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.trans = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Оригинал";
            // 
            // original
            // 
            this.original.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.original.Location = new System.Drawing.Point(96, 13);
            this.original.Name = "original";
            this.original.Size = new System.Drawing.Size(179, 20);
            this.original.TabIndex = 1;
            this.original.TextChanged += new System.EventHandler(this.original_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 43);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(72, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Для вставки";
            // 
            // trans
            // 
            this.trans.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.trans.Location = new System.Drawing.Point(96, 40);
            this.trans.Name = "trans";
            this.trans.Size = new System.Drawing.Size(179, 20);
            this.trans.TabIndex = 3;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(287, 75);
            this.Controls.Add(this.trans);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.original);
            this.Controls.Add(this.label1);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(303, 114);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(303, 114);
            this.Name = "Form1";
            this.Text = "WH1602 RUS Trans";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox original;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox trans;
    }
}

