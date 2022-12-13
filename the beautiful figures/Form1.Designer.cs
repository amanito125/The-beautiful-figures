namespace the_beautiful_figures
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.btnRectangle = new System.Windows.Forms.Button();
            this.btnTriangle = new System.Windows.Forms.Button();
            this.btnSquare = new System.Windows.Forms.Button();
            this.btnCircle = new System.Windows.Forms.Button();
            this.btnRestart = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnCount = new System.Windows.Forms.Button();
            this.btnStop = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnRectangle
            // 
            this.btnRectangle.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btnRectangle.FlatAppearance.BorderSize = 2;
            this.btnRectangle.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRectangle.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnRectangle.Location = new System.Drawing.Point(12, 12);
            this.btnRectangle.Name = "btnRectangle";
            this.btnRectangle.Size = new System.Drawing.Size(177, 63);
            this.btnRectangle.TabIndex = 0;
            this.btnRectangle.Text = "Rectangle";
            this.btnRectangle.UseVisualStyleBackColor = true;
            this.btnRectangle.Click += new System.EventHandler(this.btnRectangle_Click);
            // 
            // btnTriangle
            // 
            this.btnTriangle.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btnTriangle.FlatAppearance.BorderSize = 2;
            this.btnTriangle.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTriangle.Location = new System.Drawing.Point(12, 112);
            this.btnTriangle.Name = "btnTriangle";
            this.btnTriangle.Size = new System.Drawing.Size(177, 63);
            this.btnTriangle.TabIndex = 1;
            this.btnTriangle.Text = "Triangle";
            this.btnTriangle.UseVisualStyleBackColor = true;
            this.btnTriangle.Click += new System.EventHandler(this.btnTriangle_Click);
            // 
            // btnSquare
            // 
            this.btnSquare.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btnSquare.FlatAppearance.BorderSize = 2;
            this.btnSquare.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSquare.Location = new System.Drawing.Point(12, 212);
            this.btnSquare.Name = "btnSquare";
            this.btnSquare.Size = new System.Drawing.Size(177, 63);
            this.btnSquare.TabIndex = 2;
            this.btnSquare.Text = "Square";
            this.btnSquare.UseVisualStyleBackColor = true;
            this.btnSquare.Click += new System.EventHandler(this.btnSquare_Click);
            // 
            // btnCircle
            // 
            this.btnCircle.FlatAppearance.BorderColor = System.Drawing.Color.Fuchsia;
            this.btnCircle.FlatAppearance.BorderSize = 2;
            this.btnCircle.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCircle.Location = new System.Drawing.Point(12, 312);
            this.btnCircle.Name = "btnCircle";
            this.btnCircle.Size = new System.Drawing.Size(177, 63);
            this.btnCircle.TabIndex = 3;
            this.btnCircle.Text = "Circle";
            this.btnCircle.UseVisualStyleBackColor = true;
            this.btnCircle.Click += new System.EventHandler(this.btnCircle_Click);
            // 
            // btnRestart
            // 
            this.btnRestart.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnRestart.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRestart.Location = new System.Drawing.Point(12, 680);
            this.btnRestart.Name = "btnRestart";
            this.btnRestart.Size = new System.Drawing.Size(177, 63);
            this.btnRestart.TabIndex = 4;
            this.btnRestart.Text = "Restart";
            this.btnRestart.UseVisualStyleBackColor = true;
            this.btnRestart.Click += new System.EventHandler(this.btnRestart_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.pictureBox1.Location = new System.Drawing.Point(-46, -16);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(250, 840);
            this.pictureBox1.TabIndex = 5;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // btnCount
            // 
            this.btnCount.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCount.Location = new System.Drawing.Point(12, 445);
            this.btnCount.Name = "btnCount";
            this.btnCount.Size = new System.Drawing.Size(177, 63);
            this.btnCount.TabIndex = 6;
            this.btnCount.Text = "Count figures";
            this.btnCount.UseVisualStyleBackColor = true;
            this.btnCount.Click += new System.EventHandler(this.btnCount_Click);
            // 
            // btnStop
            // 
            this.btnStop.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnStop.Location = new System.Drawing.Point(12, 514);
            this.btnStop.Name = "btnStop";
            this.btnStop.Size = new System.Drawing.Size(177, 63);
            this.btnStop.TabIndex = 7;
            this.btnStop.Text = "Stop generating";
            this.btnStop.UseVisualStyleBackColor = true;
            this.btnStop.Click += new System.EventHandler(this.btnStop_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 30F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(1727, 755);
            this.Controls.Add(this.btnStop);
            this.Controls.Add(this.btnCount);
            this.Controls.Add(this.btnTriangle);
            this.Controls.Add(this.btnRectangle);
            this.Controls.Add(this.btnRestart);
            this.Controls.Add(this.btnCircle);
            this.Controls.Add(this.btnSquare);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "THE BEAUTIFUL FIGURES";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Button btnRectangle;
        private Button btnTriangle;
        private Button btnSquare;
        private Button btnCircle;
        private Button btnRestart;
        private PictureBox pictureBox1;
        private Button btnCount;
        private Label lblCount;
        private Button btnStop;
    }
}