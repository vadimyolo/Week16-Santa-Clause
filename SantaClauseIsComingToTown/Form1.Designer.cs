namespace SantaClauseIsComingToTown
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.santaFly = new System.Windows.Forms.PictureBox();
            this.snowFlake = new System.Windows.Forms.PictureBox();
            this.tree = new System.Windows.Forms.PictureBox();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.moon = new System.Windows.Forms.PictureBox();
            this.house = new System.Windows.Forms.PictureBox();
            this.scoreLabel = new System.Windows.Forms.Label();
            this.timer1_Tick = new System.Windows.Forms.Timer(this.components);
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.santaFly)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.snowFlake)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tree)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.moon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.house)).BeginInit();
            this.SuspendLayout();
            // 
            // santaFly
            // 
            this.santaFly.Image = ((System.Drawing.Image)(resources.GetObject("santaFly.Image")));
            this.santaFly.Location = new System.Drawing.Point(39, 288);
            this.santaFly.Name = "santaFly";
            this.santaFly.Size = new System.Drawing.Size(211, 101);
            this.santaFly.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.santaFly.TabIndex = 0;
            this.santaFly.TabStop = false;
            this.santaFly.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // snowFlake
            // 
            this.snowFlake.Image = ((System.Drawing.Image)(resources.GetObject("snowFlake.Image")));
            this.snowFlake.Location = new System.Drawing.Point(392, 12);
            this.snowFlake.Name = "snowFlake";
            this.snowFlake.Size = new System.Drawing.Size(171, 179);
            this.snowFlake.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.snowFlake.TabIndex = 1;
            this.snowFlake.TabStop = false;
            // 
            // tree
            // 
            this.tree.Image = ((System.Drawing.Image)(resources.GetObject("tree.Image")));
            this.tree.Location = new System.Drawing.Point(417, 411);
            this.tree.Name = "tree";
            this.tree.Size = new System.Drawing.Size(171, 249);
            this.tree.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.tree.TabIndex = 2;
            this.tree.TabStop = false;
            this.tree.Click += new System.EventHandler(this.pictureBox3_Click);
            // 
            // pictureBox4
            // 
            this.pictureBox4.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox4.Image")));
            this.pictureBox4.Location = new System.Drawing.Point(-1, 642);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(701, 76);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox4.TabIndex = 3;
            this.pictureBox4.TabStop = false;
            // 
            // moon
            // 
            this.moon.Image = ((System.Drawing.Image)(resources.GetObject("moon.Image")));
            this.moon.Location = new System.Drawing.Point(-17, -26);
            this.moon.Name = "moon";
            this.moon.Size = new System.Drawing.Size(207, 136);
            this.moon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.moon.TabIndex = 4;
            this.moon.TabStop = false;
            this.moon.Click += new System.EventHandler(this.pictureBox5_Click);
            // 
            // house
            // 
            this.house.Image = ((System.Drawing.Image)(resources.GetObject("house.Image")));
            this.house.Location = new System.Drawing.Point(-1, 528);
            this.house.Name = "house";
            this.house.Size = new System.Drawing.Size(111, 132);
            this.house.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.house.TabIndex = 5;
            this.house.TabStop = false;
            // 
            // scoreLabel
            // 
            this.scoreLabel.AutoSize = true;
            this.scoreLabel.Font = new System.Drawing.Font("Sitka Small", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.scoreLabel.Location = new System.Drawing.Point(-1, 192);
            this.scoreLabel.Name = "scoreLabel";
            this.scoreLabel.Size = new System.Drawing.Size(186, 54);
            this.scoreLabel.TabIndex = 6;
            this.scoreLabel.Text = "Score : 0";
            this.scoreLabel.Click += new System.EventHandler(this.label1_Click);
            // 
            // timer1_Tick
            // 
            this.timer1_Tick.Enabled = true;
            this.timer1_Tick.Interval = 20;
            this.timer1_Tick.Tick += new System.EventHandler(this.timer1_Tick_Tick);
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button1.Location = new System.Drawing.Point(256, 352);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(112, 63);
            this.button1.TabIndex = 7;
            this.button1.Text = "PLAY AGAIN";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Visible = false;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.ClientSize = new System.Drawing.Size(558, 679);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.scoreLabel);
            this.Controls.Add(this.house);
            this.Controls.Add(this.moon);
            this.Controls.Add(this.pictureBox4);
            this.Controls.Add(this.tree);
            this.Controls.Add(this.snowFlake);
            this.Controls.Add(this.santaFly);
            this.Name = "Form1";
            this.Text = "Form1";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyUp);
            ((System.ComponentModel.ISupportInitialize)(this.santaFly)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.snowFlake)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tree)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.moon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.house)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox santaFly;
        private System.Windows.Forms.PictureBox snowFlake;
        private System.Windows.Forms.PictureBox tree;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.PictureBox moon;
        private System.Windows.Forms.PictureBox pictureBox6;
        private System.Windows.Forms.Label scoreLabel;
        private System.Windows.Forms.Timer timer1_Tick;
        private System.Windows.Forms.PictureBox house;
        private System.Windows.Forms.Button button1;
    }
}

