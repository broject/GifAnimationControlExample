namespace GifAnimationControlExample
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
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.gifImageControl1 = new HiimelOyun.App.Base.Controls.GifImageControl();
            ((System.ComponentModel.ISupportInitialize)(this.gifImageControl1)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(152, 227);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(120, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "Form2";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(152, 198);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(120, 23);
            this.button2.TabIndex = 2;
            this.button2.Text = "Gif Солих";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // gifImageControl1
            // 
            this.gifImageControl1.AnimationSpeed = 200;
            this.gifImageControl1.BackColor = System.Drawing.Color.White;
            this.gifImageControl1.FrameCount = 8;
            this.gifImageControl1.FrameIndex = 4;
            this.gifImageControl1.Image = ((System.Drawing.Image)(resources.GetObject("gifImageControl1.Image")));
            this.gifImageControl1.IsCycleByImages = false;
            this.gifImageControl1.LoadingImage = ((System.Drawing.Image)(resources.GetObject("gifImageControl1.LoadingImage")));
            this.gifImageControl1.Location = new System.Drawing.Point(152, 12);
            this.gifImageControl1.Name = "gifImageControl1";
            this.gifImageControl1.Size = new System.Drawing.Size(120, 100);
            this.gifImageControl1.TabIndex = 1;
            this.gifImageControl1.TabStop = false;
            this.gifImageControl1.Click += new System.EventHandler(this.gifImageControl1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 262);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.gifImageControl1);
            this.Controls.Add(this.button1);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.gifImageControl1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private HiimelOyun.App.Base.Controls.GifImageControl gifImageControl1;
        private System.Windows.Forms.Button button2;
    }
}

