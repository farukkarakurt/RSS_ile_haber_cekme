namespace RSS_ile_Haber_Cekme
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
            this.Milliyet = new System.Windows.Forms.Button();
            this.cumhuriyet = new System.Windows.Forms.Button();
            this.fotomac = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.listBox1 = new System.Windows.Forms.ListBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.SuspendLayout();
            // 
            // Milliyet
            // 
            this.Milliyet.Location = new System.Drawing.Point(108, 558);
            this.Milliyet.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Milliyet.Name = "Milliyet";
            this.Milliyet.Size = new System.Drawing.Size(146, 32);
            this.Milliyet.TabIndex = 0;
            this.Milliyet.Text = "Milliyet";
            this.Milliyet.UseVisualStyleBackColor = true;
            this.Milliyet.Click += new System.EventHandler(this.Milliyet_Click);
            // 
            // cumhuriyet
            // 
            this.cumhuriyet.Location = new System.Drawing.Point(437, 558);
            this.cumhuriyet.Margin = new System.Windows.Forms.Padding(4);
            this.cumhuriyet.Name = "cumhuriyet";
            this.cumhuriyet.Size = new System.Drawing.Size(146, 32);
            this.cumhuriyet.TabIndex = 0;
            this.cumhuriyet.Text = "Cumhuriyet";
            this.cumhuriyet.UseVisualStyleBackColor = true;
            this.cumhuriyet.Click += new System.EventHandler(this.cumhuriyet_Click);
            // 
            // fotomac
            // 
            this.fotomac.Location = new System.Drawing.Point(739, 558);
            this.fotomac.Margin = new System.Windows.Forms.Padding(4);
            this.fotomac.Name = "fotomac";
            this.fotomac.Size = new System.Drawing.Size(146, 32);
            this.fotomac.TabIndex = 0;
            this.fotomac.Text = "FotoMaç";
            this.fotomac.UseVisualStyleBackColor = true;
            this.fotomac.Click += new System.EventHandler(this.fotomac_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(55, 502);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(260, 49);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(374, 502);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(260, 49);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 1;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox3.Image")));
            this.pictureBox3.Location = new System.Drawing.Point(681, 502);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(260, 49);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox3.TabIndex = 1;
            this.pictureBox3.TabStop = false;
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 22;
            this.listBox1.Location = new System.Drawing.Point(55, 12);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(886, 466);
            this.listBox1.TabIndex = 2;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 22F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(1000, 619);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.fotomac);
            this.Controls.Add(this.cumhuriyet);
            this.Controls.Add(this.Milliyet);
            this.Font = new System.Drawing.Font("Tahoma", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button Milliyet;
        private System.Windows.Forms.Button cumhuriyet;
        private System.Windows.Forms.Button fotomac;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.ListBox listBox1;
    }
}

