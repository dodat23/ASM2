namespace ASM2
{
    partial class Form3
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
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.label1 = new System.Windows.Forms.Label();
            this.lbname = new System.Windows.Forms.Label();
            this.lbused = new System.Windows.Forms.Label();
            this.lbthis = new System.Windows.Forms.Label();
            this.lblast = new System.Windows.Forms.Label();
            this.lbtype = new System.Windows.Forms.Label();
            this.lbphone = new System.Windows.Forms.Label();
            this.lbtotal = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txttotal = new System.Windows.Forms.TextBox();
            this.txtused = new System.Windows.Forms.TextBox();
            this.txtthis = new System.Windows.Forms.TextBox();
            this.txtlast = new System.Windows.Forms.TextBox();
            this.txttype = new System.Windows.Forms.TextBox();
            this.txtphone = new System.Windows.Forms.TextBox();
            this.txtname = new System.Windows.Forms.TextBox();
            this.btnback = new System.Windows.Forms.Button();
            this.btnexit = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 28F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label1.Location = new System.Drawing.Point(246, 51);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(278, 64);
            this.label1.TabIndex = 0;
            this.label1.Text = "Water Bill";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // lbname
            // 
            this.lbname.AutoSize = true;
            this.lbname.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lbname.Location = new System.Drawing.Point(18, 181);
            this.lbname.Name = "lbname";
            this.lbname.Size = new System.Drawing.Size(196, 29);
            this.lbname.TabIndex = 1;
            this.lbname.Text = "Name customer";
            // 
            // lbused
            // 
            this.lbused.AutoSize = true;
            this.lbused.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lbused.Location = new System.Drawing.Point(21, 583);
            this.lbused.Name = "lbused";
            this.lbused.Size = new System.Drawing.Size(239, 29);
            this.lbused.TabIndex = 4;
            this.lbused.Text = "Amout of used (m3)";
            // 
            // lbthis
            // 
            this.lbthis.AutoSize = true;
            this.lbthis.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lbthis.Location = new System.Drawing.Point(21, 510);
            this.lbthis.Name = "lbthis";
            this.lbthis.Size = new System.Drawing.Size(267, 29);
            this.lbthis.TabIndex = 5;
            this.lbthis.Text = "Water this month (m3)";
            // 
            // lblast
            // 
            this.lblast.AutoSize = true;
            this.lblast.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lblast.Location = new System.Drawing.Point(21, 433);
            this.lblast.Name = "lblast";
            this.lblast.Size = new System.Drawing.Size(267, 29);
            this.lblast.TabIndex = 6;
            this.lblast.Text = "Water last month (m3)";
            // 
            // lbtype
            // 
            this.lbtype.AutoSize = true;
            this.lbtype.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lbtype.Location = new System.Drawing.Point(21, 318);
            this.lbtype.Name = "lbtype";
            this.lbtype.Size = new System.Drawing.Size(191, 29);
            this.lbtype.TabIndex = 7;
            this.lbtype.Text = "Customer Type";
            // 
            // lbphone
            // 
            this.lbphone.AutoSize = true;
            this.lbphone.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lbphone.Location = new System.Drawing.Point(18, 251);
            this.lbphone.Name = "lbphone";
            this.lbphone.Size = new System.Drawing.Size(88, 29);
            this.lbphone.TabIndex = 8;
            this.lbphone.Text = "Phone";
            // 
            // lbtotal
            // 
            this.lbtotal.AutoSize = true;
            this.lbtotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lbtotal.Location = new System.Drawing.Point(21, 679);
            this.lbtotal.Name = "lbtotal";
            this.lbtotal.Size = new System.Drawing.Size(73, 29);
            this.lbtotal.TabIndex = 10;
            this.lbtotal.Text = "Total";
            this.lbtotal.Click += new System.EventHandler(this.label2_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label2.Location = new System.Drawing.Point(-1, 377);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(778, 29);
            this.label2.TabIndex = 11;
            this.label2.Text = "---------------------------------------------------------------------------------" +
    "----";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label3.Location = new System.Drawing.Point(0, 626);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(778, 29);
            this.label3.TabIndex = 12;
            this.label3.Text = "---------------------------------------------------------------------------------" +
    "----";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnexit);
            this.groupBox1.Controls.Add(this.btnback);
            this.groupBox1.Controls.Add(this.txttotal);
            this.groupBox1.Controls.Add(this.txtused);
            this.groupBox1.Controls.Add(this.txtthis);
            this.groupBox1.Controls.Add(this.txtlast);
            this.groupBox1.Controls.Add(this.txttype);
            this.groupBox1.Controls.Add(this.txtphone);
            this.groupBox1.Controls.Add(this.txtname);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.lbtotal);
            this.groupBox1.Controls.Add(this.lbphone);
            this.groupBox1.Controls.Add(this.lbtype);
            this.groupBox1.Controls.Add(this.lblast);
            this.groupBox1.Controls.Add(this.lbthis);
            this.groupBox1.Controls.Add(this.lbused);
            this.groupBox1.Controls.Add(this.lbname);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(612, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(775, 972);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            // 
            // txttotal
            // 
            this.txttotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.txttotal.Location = new System.Drawing.Point(459, 673);
            this.txttotal.Name = "txttotal";
            this.txttotal.Size = new System.Drawing.Size(197, 35);
            this.txttotal.TabIndex = 23;
            // 
            // txtused
            // 
            this.txtused.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.txtused.Location = new System.Drawing.Point(459, 577);
            this.txtused.Name = "txtused";
            this.txtused.Size = new System.Drawing.Size(197, 35);
            this.txtused.TabIndex = 19;
            // 
            // txtthis
            // 
            this.txtthis.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.txtthis.Location = new System.Drawing.Point(459, 504);
            this.txtthis.Name = "txtthis";
            this.txtthis.Size = new System.Drawing.Size(197, 35);
            this.txtthis.TabIndex = 18;
            // 
            // txtlast
            // 
            this.txtlast.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.txtlast.Location = new System.Drawing.Point(459, 427);
            this.txtlast.Name = "txtlast";
            this.txtlast.Size = new System.Drawing.Size(197, 35);
            this.txtlast.TabIndex = 17;
            // 
            // txttype
            // 
            this.txttype.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.txttype.Location = new System.Drawing.Point(459, 312);
            this.txttype.Name = "txttype";
            this.txttype.Size = new System.Drawing.Size(197, 35);
            this.txttype.TabIndex = 16;
            // 
            // txtphone
            // 
            this.txtphone.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.txtphone.Location = new System.Drawing.Point(459, 245);
            this.txtphone.Name = "txtphone";
            this.txtphone.Size = new System.Drawing.Size(197, 35);
            this.txtphone.TabIndex = 15;
            // 
            // txtname
            // 
            this.txtname.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.txtname.Location = new System.Drawing.Point(459, 175);
            this.txtname.Name = "txtname";
            this.txtname.Size = new System.Drawing.Size(197, 35);
            this.txtname.TabIndex = 14;
            // 
            // btnback
            // 
            this.btnback.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnback.Location = new System.Drawing.Point(471, 804);
            this.btnback.Name = "btnback";
            this.btnback.Size = new System.Drawing.Size(131, 52);
            this.btnback.TabIndex = 24;
            this.btnback.Text = "Back";
            this.btnback.UseVisualStyleBackColor = true;
            this.btnback.Click += new System.EventHandler(this.btnback_Click);
            // 
            // btnexit
            // 
            this.btnexit.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnexit.Location = new System.Drawing.Point(142, 804);
            this.btnexit.Name = "btnexit";
            this.btnexit.Size = new System.Drawing.Size(131, 52);
            this.btnexit.TabIndex = 25;
            this.btnexit.Text = "Exit";
            this.btnexit.UseVisualStyleBackColor = true;
            this.btnexit.Click += new System.EventHandler(this.btnexit_Click);
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1924, 1050);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form3";
            this.Text = "Form3";
            this.Load += new System.EventHandler(this.Form3_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lbname;
        private System.Windows.Forms.Label lbused;
        private System.Windows.Forms.Label lbthis;
        private System.Windows.Forms.Label lblast;
        private System.Windows.Forms.Label lbtype;
        private System.Windows.Forms.Label lbphone;
        private System.Windows.Forms.Label lbtotal;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtphone;
        private System.Windows.Forms.TextBox txtname;
        private System.Windows.Forms.TextBox txttotal;
        private System.Windows.Forms.TextBox txtused;
        private System.Windows.Forms.TextBox txtthis;
        private System.Windows.Forms.TextBox txtlast;
        private System.Windows.Forms.TextBox txttype;
        private System.Windows.Forms.Button btnexit;
        private System.Windows.Forms.Button btnback;
    }
}