
namespace FractalGenerator
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.angleBox = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.fractalTypeComboBox = new System.Windows.Forms.ComboBox();
            this.animationBox = new System.Windows.Forms.GroupBox();
            this.stopAnimationButton = new System.Windows.Forms.Button();
            this.startAnimationButton = new System.Windows.Forms.Button();
            this.gpuRadioButton = new System.Windows.Forms.RadioButton();
            this.cpuRadioButton = new System.Windows.Forms.RadioButton();
            this.cImBox = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.cReBox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.iterationsBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.moveYBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.moveXBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.zoomBox = new System.Windows.Forms.TextBox();
            this.zoomLabel = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.pictureBox = new System.Windows.Forms.PictureBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.exitButton = new System.Windows.Forms.Button();
            this.startButton = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.animationBox.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).BeginInit();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.groupBox1.Controls.Add(this.angleBox);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.groupBox5);
            this.groupBox1.Controls.Add(this.animationBox);
            this.groupBox1.Controls.Add(this.gpuRadioButton);
            this.groupBox1.Controls.Add(this.cpuRadioButton);
            this.groupBox1.Controls.Add(this.cImBox);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.cReBox);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.iterationsBox);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.moveYBox);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.moveXBox);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.zoomBox);
            this.groupBox1.Controls.Add(this.zoomLabel);
            this.groupBox1.Location = new System.Drawing.Point(13, 13);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(248, 425);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Value";
            // 
            // angleBox
            // 
            this.angleBox.Location = new System.Drawing.Point(102, 192);
            this.angleBox.Name = "angleBox";
            this.angleBox.Size = new System.Drawing.Size(140, 22);
            this.angleBox.TabIndex = 17;
            this.angleBox.Text = "90";
            this.angleBox.TextChanged += new System.EventHandler(this.TextBox_TextChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(6, 195);
            this.label6.Name = "label6";
            this.label6.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label6.Size = new System.Drawing.Size(48, 17);
            this.label6.TabIndex = 16;
            this.label6.Text = "Angle:";
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.fractalTypeComboBox);
            this.groupBox5.Location = new System.Drawing.Point(7, 291);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(235, 62);
            this.groupBox5.TabIndex = 15;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Fractal Type";
            // 
            // fractalTypeComboBox
            // 
            this.fractalTypeComboBox.FormattingEnabled = true;
            this.fractalTypeComboBox.Items.AddRange(new object[] {
            "Mandelbrot",
            "Julia",
            "SierpinskiTriangle",
            "DragonCurve",
            "FractalTree"});
            this.fractalTypeComboBox.Location = new System.Drawing.Point(7, 22);
            this.fractalTypeComboBox.Name = "fractalTypeComboBox";
            this.fractalTypeComboBox.Size = new System.Drawing.Size(222, 24);
            this.fractalTypeComboBox.TabIndex = 0;
            this.fractalTypeComboBox.SelectedIndexChanged += new System.EventHandler(this.fractalTypeComboBox_SelectedIndexChanged);
            // 
            // animationBox
            // 
            this.animationBox.Controls.Add(this.stopAnimationButton);
            this.animationBox.Controls.Add(this.startAnimationButton);
            this.animationBox.Location = new System.Drawing.Point(7, 359);
            this.animationBox.Name = "animationBox";
            this.animationBox.Size = new System.Drawing.Size(235, 60);
            this.animationBox.TabIndex = 14;
            this.animationBox.TabStop = false;
            this.animationBox.Text = "Animation";
            // 
            // stopAnimationButton
            // 
            this.stopAnimationButton.Location = new System.Drawing.Point(95, 22);
            this.stopAnimationButton.Name = "stopAnimationButton";
            this.stopAnimationButton.Size = new System.Drawing.Size(75, 23);
            this.stopAnimationButton.TabIndex = 1;
            this.stopAnimationButton.Text = "Stop";
            this.stopAnimationButton.UseVisualStyleBackColor = true;
            this.stopAnimationButton.Click += new System.EventHandler(this.stopAnimationButton_Click);
            // 
            // startAnimationButton
            // 
            this.startAnimationButton.Location = new System.Drawing.Point(7, 22);
            this.startAnimationButton.Name = "startAnimationButton";
            this.startAnimationButton.Size = new System.Drawing.Size(75, 23);
            this.startAnimationButton.TabIndex = 0;
            this.startAnimationButton.Text = "Start";
            this.startAnimationButton.UseVisualStyleBackColor = true;
            this.startAnimationButton.Click += new System.EventHandler(this.startAnimationButton_Click);
            // 
            // gpuRadioButton
            // 
            this.gpuRadioButton.AutoSize = true;
            this.gpuRadioButton.Checked = true;
            this.gpuRadioButton.Location = new System.Drawing.Point(9, 254);
            this.gpuRadioButton.Name = "gpuRadioButton";
            this.gpuRadioButton.Size = new System.Drawing.Size(88, 21);
            this.gpuRadioButton.TabIndex = 13;
            this.gpuRadioButton.TabStop = true;
            this.gpuRadioButton.Text = "Use GPU";
            this.gpuRadioButton.UseVisualStyleBackColor = true;
            // 
            // cpuRadioButton
            // 
            this.cpuRadioButton.AutoSize = true;
            this.cpuRadioButton.Location = new System.Drawing.Point(9, 227);
            this.cpuRadioButton.Name = "cpuRadioButton";
            this.cpuRadioButton.Size = new System.Drawing.Size(86, 21);
            this.cpuRadioButton.TabIndex = 12;
            this.cpuRadioButton.Text = "Use CPU";
            this.cpuRadioButton.UseVisualStyleBackColor = true;
            // 
            // cImBox
            // 
            this.cImBox.Location = new System.Drawing.Point(102, 164);
            this.cImBox.Name = "cImBox";
            this.cImBox.Size = new System.Drawing.Size(140, 22);
            this.cImBox.TabIndex = 11;
            this.cImBox.Text = "0.156";
            this.cImBox.TextChanged += new System.EventHandler(this.TextBox_TextChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 167);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(35, 17);
            this.label5.TabIndex = 10;
            this.label5.Text = "CIm:";
            // 
            // cReBox
            // 
            this.cReBox.Location = new System.Drawing.Point(102, 136);
            this.cReBox.Name = "cReBox";
            this.cReBox.Size = new System.Drawing.Size(140, 22);
            this.cReBox.TabIndex = 9;
            this.cReBox.Text = "-0.8";
            this.cReBox.TextChanged += new System.EventHandler(this.TextBox_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 139);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(39, 17);
            this.label4.TabIndex = 8;
            this.label4.Text = "CRe:";
            // 
            // iterationsBox
            // 
            this.iterationsBox.Location = new System.Drawing.Point(102, 108);
            this.iterationsBox.Name = "iterationsBox";
            this.iterationsBox.Size = new System.Drawing.Size(140, 22);
            this.iterationsBox.TabIndex = 7;
            this.iterationsBox.Text = "500";
            this.iterationsBox.TextChanged += new System.EventHandler(this.TextBox_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 111);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(70, 17);
            this.label3.TabIndex = 6;
            this.label3.Text = "Iterations:";
            // 
            // moveYBox
            // 
            this.moveYBox.Location = new System.Drawing.Point(102, 80);
            this.moveYBox.Name = "moveYBox";
            this.moveYBox.Size = new System.Drawing.Size(140, 22);
            this.moveYBox.TabIndex = 5;
            this.moveYBox.Text = "0";
            this.moveYBox.TextChanged += new System.EventHandler(this.TextBox_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 83);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 17);
            this.label2.TabIndex = 4;
            this.label2.Text = "MoveY:";
            // 
            // moveXBox
            // 
            this.moveXBox.Location = new System.Drawing.Point(102, 52);
            this.moveXBox.Name = "moveXBox";
            this.moveXBox.Size = new System.Drawing.Size(140, 22);
            this.moveXBox.TabIndex = 3;
            this.moveXBox.Text = "-0.5";
            this.moveXBox.TextChanged += new System.EventHandler(this.TextBox_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 55);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 17);
            this.label1.TabIndex = 2;
            this.label1.Text = "MoveX: ";
            // 
            // zoomBox
            // 
            this.zoomBox.Location = new System.Drawing.Point(102, 24);
            this.zoomBox.Name = "zoomBox";
            this.zoomBox.Size = new System.Drawing.Size(140, 22);
            this.zoomBox.TabIndex = 1;
            this.zoomBox.Text = "1.5";
            this.zoomBox.TextChanged += new System.EventHandler(this.TextBox_TextChanged);
            // 
            // zoomLabel
            // 
            this.zoomLabel.AutoSize = true;
            this.zoomLabel.Location = new System.Drawing.Point(6, 27);
            this.zoomLabel.Name = "zoomLabel";
            this.zoomLabel.Size = new System.Drawing.Size(48, 17);
            this.zoomLabel.TabIndex = 0;
            this.zoomLabel.Text = "Zoom:";
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox2.Controls.Add(this.pictureBox);
            this.groupBox2.Location = new System.Drawing.Point(267, 13);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(521, 425);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Picture";
            // 
            // pictureBox
            // 
            this.pictureBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox.Location = new System.Drawing.Point(3, 18);
            this.pictureBox.Name = "pictureBox";
            this.pictureBox.Size = new System.Drawing.Size(515, 404);
            this.pictureBox.TabIndex = 0;
            this.pictureBox.TabStop = false;
            // 
            // groupBox3
            // 
            this.groupBox3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox3.Controls.Add(this.exitButton);
            this.groupBox3.Controls.Add(this.startButton);
            this.groupBox3.Location = new System.Drawing.Point(13, 444);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(775, 43);
            this.groupBox3.TabIndex = 2;
            this.groupBox3.TabStop = false;
            // 
            // exitButton
            // 
            this.exitButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.exitButton.Location = new System.Drawing.Point(694, 14);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(75, 23);
            this.exitButton.TabIndex = 1;
            this.exitButton.Text = "Exit";
            this.exitButton.UseVisualStyleBackColor = true;
            this.exitButton.Click += new System.EventHandler(this.ExitBtn_Click);
            // 
            // startButton
            // 
            this.startButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.startButton.Location = new System.Drawing.Point(613, 14);
            this.startButton.Name = "startButton";
            this.startButton.Size = new System.Drawing.Size(75, 23);
            this.startButton.TabIndex = 0;
            this.startButton.Text = "Start";
            this.startButton.UseVisualStyleBackColor = true;
            this.startButton.Click += new System.EventHandler(this.StartBtn_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 494);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Fractal";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.SizeChanged += new System.EventHandler(this.Form_FormChanged);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox5.ResumeLayout(false);
            this.animationBox.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox zoomBox;
        private System.Windows.Forms.Label zoomLabel;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox moveXBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox moveYBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox iterationsBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox cReBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox cImBox;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.PictureBox pictureBox;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button exitButton;
        private System.Windows.Forms.Button startButton;
        private System.Windows.Forms.RadioButton gpuRadioButton;
        private System.Windows.Forms.RadioButton cpuRadioButton;
        private System.Windows.Forms.GroupBox animationBox;
        private System.Windows.Forms.Button stopAnimationButton;
        private System.Windows.Forms.Button startAnimationButton;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.ComboBox fractalTypeComboBox;
        private System.Windows.Forms.TextBox angleBox;
        private System.Windows.Forms.Label label6;
    }
}

