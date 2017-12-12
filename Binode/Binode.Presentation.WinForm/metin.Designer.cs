namespace Binode.Presentation.WinForm
{
    partial class metin
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
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.MtnKaydet = new System.Windows.Forms.Button();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.SuspendLayout();
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(21, 12);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(389, 265);
            this.richTextBox1.TabIndex = 0;
            this.richTextBox1.Text = "";
            // 
            // MtnKaydet
            // 
            this.MtnKaydet.Location = new System.Drawing.Point(326, 283);
            this.MtnKaydet.Name = "MtnKaydet";
            this.MtnKaydet.Size = new System.Drawing.Size(72, 19);
            this.MtnKaydet.TabIndex = 1;
            this.MtnKaydet.Text = "KAYDET";
            this.MtnKaydet.UseVisualStyleBackColor = true;
            this.MtnKaydet.Click += new System.EventHandler(this.MtnKaydet_Click);
            // 
            // metin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(422, 324);
            this.Controls.Add(this.MtnKaydet);
            this.Controls.Add(this.richTextBox1);
            this.Name = "metin";
            this.Text = "metin";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.Button MtnKaydet;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
    }
}