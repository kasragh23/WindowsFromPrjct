namespace WindowsFormsApplication2
{
    partial class FrmLooser
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
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.grpCinemas = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.picTick = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.picC4 = new System.Windows.Forms.PictureBox();
            this.picC3 = new System.Windows.Forms.PictureBox();
            this.picC2 = new System.Windows.Forms.PictureBox();
            this.picC1 = new System.Windows.Forms.PictureBox();
            this.btnBack = new System.Windows.Forms.Button();
            this.grpCinemas.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picTick)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picC4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picC3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picC2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picC1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("B Nazanin", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label1.Location = new System.Drawing.Point(701, 44);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(107, 40);
            this.label1.TabIndex = 1;
            this.label1.Text = "مرد بازنده";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(495, 87);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(289, 207);
            this.richTextBox1.TabIndex = 2;
            this.richTextBox1.Text = "یک فیلم جنایی همراه با ...";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("B Nazanin", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label2.Location = new System.Drawing.Point(31, 343);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(110, 24);
            this.label2.TabIndex = 1;
            this.label2.Text = "Availabe in :";
            // 
            // grpCinemas
            // 
            this.grpCinemas.Controls.Add(this.picC4);
            this.grpCinemas.Controls.Add(this.picC3);
            this.grpCinemas.Controls.Add(this.picC2);
            this.grpCinemas.Controls.Add(this.picC1);
            this.grpCinemas.Location = new System.Drawing.Point(20, 370);
            this.grpCinemas.Name = "grpCinemas";
            this.grpCinemas.Size = new System.Drawing.Size(781, 139);
            this.grpCinemas.TabIndex = 1;
            this.grpCinemas.TabStop = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("B Nazanin", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label3.Location = new System.Drawing.Point(287, 103);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(98, 24);
            this.label3.TabIndex = 1;
            this.label3.Text = "Buy Ticket";
            this.label3.Click += new System.EventHandler(this.label1_Click);
            // 
            // picTick
            // 
            this.picTick.Image = global::WindowsFormsApplication2.Properties.Resources.tick;
            this.picTick.Location = new System.Drawing.Point(291, 50);
            this.picTick.Name = "picTick";
            this.picTick.Size = new System.Drawing.Size(54, 50);
            this.picTick.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picTick.TabIndex = 3;
            this.picTick.TabStop = false;
            this.picTick.Click += new System.EventHandler(this.picTick_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::WindowsFormsApplication2.Properties.Resources.photo_2022_01_31_11_23_07_Copy;
            this.pictureBox1.Location = new System.Drawing.Point(12, 50);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(242, 244);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // picC4
            // 
            this.picC4.BackColor = System.Drawing.SystemColors.Control;
            this.picC4.Image = global::WindowsFormsApplication2.Properties.Resources.hv2;
            this.picC4.Location = new System.Drawing.Point(603, 10);
            this.picC4.Name = "picC4";
            this.picC4.Size = new System.Drawing.Size(172, 123);
            this.picC4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picC4.TabIndex = 0;
            this.picC4.TabStop = false;
            // 
            // picC3
            // 
            this.picC3.BackColor = System.Drawing.SystemColors.Control;
            this.picC3.Image = global::WindowsFormsApplication2.Properties.Resources.azadi;
            this.picC3.Location = new System.Drawing.Point(411, 10);
            this.picC3.Name = "picC3";
            this.picC3.Size = new System.Drawing.Size(186, 124);
            this.picC3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picC3.TabIndex = 0;
            this.picC3.TabStop = false;
            // 
            // picC2
            // 
            this.picC2.BackColor = System.Drawing.SystemColors.Control;
            this.picC2.Image = global::WindowsFormsApplication2.Properties.Resources.inside;
            this.picC2.Location = new System.Drawing.Point(206, 10);
            this.picC2.Name = "picC2";
            this.picC2.Size = new System.Drawing.Size(199, 124);
            this.picC2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picC2.TabIndex = 0;
            this.picC2.TabStop = false;
            // 
            // picC1
            // 
            this.picC1.BackColor = System.Drawing.SystemColors.Control;
            this.picC1.Image = global::WindowsFormsApplication2.Properties.Resources.cinema;
            this.picC1.Location = new System.Drawing.Point(6, 10);
            this.picC1.Name = "picC1";
            this.picC1.Size = new System.Drawing.Size(194, 124);
            this.picC1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picC1.TabIndex = 0;
            this.picC1.TabStop = false;
            // 
            // btnBack
            // 
            this.btnBack.BackColor = System.Drawing.Color.Teal;
            this.btnBack.Location = new System.Drawing.Point(12, 12);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(25, 22);
            this.btnBack.TabIndex = 4;
            this.btnBack.Text = "<-";
            this.btnBack.UseVisualStyleBackColor = false;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // FrmLooser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(820, 521);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.picTick);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.grpCinemas);
            this.Name = "FrmLooser";
            this.Text = "FrmLooser";
            this.Load += new System.EventHandler(this.FrmLooser_Load);
            this.grpCinemas.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.picTick)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picC4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picC3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picC2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picC1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox grpCinemas;
        private System.Windows.Forms.PictureBox picC4;
        private System.Windows.Forms.PictureBox picC3;
        private System.Windows.Forms.PictureBox picC2;
        private System.Windows.Forms.PictureBox picC1;
        private System.Windows.Forms.PictureBox picTick;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnBack;
    }
}