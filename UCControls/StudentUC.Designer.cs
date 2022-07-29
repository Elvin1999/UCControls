namespace UCControls
{
    partial class StudentUC
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.noLbl = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.fullnameLbl = new System.Windows.Forms.Label();
            this.ageLbl = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // noLbl
            // 
            this.noLbl.AutoSize = true;
            this.noLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.noLbl.Location = new System.Drawing.Point(29, 32);
            this.noLbl.Name = "noLbl";
            this.noLbl.Size = new System.Drawing.Size(57, 20);
            this.noLbl.TabIndex = 0;
            this.noLbl.Text = "label1";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(101, 20);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(46, 43);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // fullnameLbl
            // 
            this.fullnameLbl.AutoSize = true;
            this.fullnameLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.fullnameLbl.Location = new System.Drawing.Point(184, 32);
            this.fullnameLbl.Name = "fullnameLbl";
            this.fullnameLbl.Size = new System.Drawing.Size(57, 20);
            this.fullnameLbl.TabIndex = 2;
            this.fullnameLbl.Text = "label2";
            // 
            // ageLbl
            // 
            this.ageLbl.AutoSize = true;
            this.ageLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ageLbl.Location = new System.Drawing.Point(290, 32);
            this.ageLbl.Name = "ageLbl";
            this.ageLbl.Size = new System.Drawing.Size(57, 20);
            this.ageLbl.TabIndex = 3;
            this.ageLbl.Text = "label2";
            // 
            // StudentUC
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Moccasin;
            this.Controls.Add(this.ageLbl);
            this.Controls.Add(this.fullnameLbl);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.noLbl);
            this.Name = "StudentUC";
            this.Size = new System.Drawing.Size(854, 78);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label noLbl;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label fullnameLbl;
        private System.Windows.Forms.Label ageLbl;
    }
}
