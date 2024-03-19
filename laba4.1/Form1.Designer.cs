namespace laba4._1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lblResult = new System.Windows.Forms.Label();
            this.txtArray = new System.Windows.Forms.TextBox();
            this.btnOk1 = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnOk3 = new System.Windows.Forms.Button();
            this.btnOk2 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(84, 300);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "label1";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(84, 374);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "label2";
            // 
            // lblResult
            // 
            this.lblResult.AutoSize = true;
            this.lblResult.Location = new System.Drawing.Point(214, 374);
            this.lblResult.Name = "lblResult";
            this.lblResult.Size = new System.Drawing.Size(35, 13);
            this.lblResult.TabIndex = 2;
            this.lblResult.Text = "label3";
            // 
            // txtArray
            // 
            this.txtArray.Location = new System.Drawing.Point(217, 293);
            this.txtArray.Name = "txtArray";
            this.txtArray.Size = new System.Drawing.Size(100, 20);
            this.txtArray.TabIndex = 4;
            // 
            // btnOk1
            // 
            this.btnOk1.Location = new System.Drawing.Point(217, 433);
            this.btnOk1.Name = "btnOk1";
            this.btnOk1.Size = new System.Drawing.Size(75, 23);
            this.btnOk1.TabIndex = 5;
            this.btnOk1.Text = "button1";
            this.btnOk1.UseVisualStyleBackColor = true;
            this.btnOk1.Click += new System.EventHandler(this.btnOk1_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(43, 35);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(809, 208);
            this.pictureBox1.TabIndex = 6;
            this.pictureBox1.TabStop = false;
            // 
            // btnOk3
            // 
            this.btnOk3.Location = new System.Drawing.Point(673, 433);
            this.btnOk3.Name = "btnOk3";
            this.btnOk3.Size = new System.Drawing.Size(75, 23);
            this.btnOk3.TabIndex = 8;
            this.btnOk3.Text = "button3";
            this.btnOk3.UseVisualStyleBackColor = true;
            this.btnOk3.Click += new System.EventHandler(this.btnOk3_Click);
            // 
            // btnOk2
            // 
            this.btnOk2.Location = new System.Drawing.Point(405, 433);
            this.btnOk2.Name = "btnOk2";
            this.btnOk2.Size = new System.Drawing.Size(156, 23);
            this.btnOk2.TabIndex = 7;
            this.btnOk2.Text = "button2";
            this.btnOk2.UseVisualStyleBackColor = true;
            this.btnOk2.Click += new System.EventHandler(this.btnOk2_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1463, 637);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnOk3);
            this.Controls.Add(this.txtArray);
            this.Controls.Add(this.lblResult);
            this.Controls.Add(this.btnOk2);
            this.Controls.Add(this.btnOk1);
            this.Name = "Form1";
            this.Text = "Lab4";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblResult;
        private System.Windows.Forms.TextBox txtArray;
        private System.Windows.Forms.Button btnOk1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnOk3;
        private System.Windows.Forms.Button btnOk2;
    }
}

