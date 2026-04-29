namespace MeasurementSystem.GUI
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
            label = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            lblTemperature = new Label();
            this.lblLaser = new Label();
            lblAngle = new Label();
            lblUltrasonic = new Label();
            SuspendLayout();
            // 
            // label
            // 
            label.AutoSize = true;
            label.Font = new Font("Segoe UI", 12F);
            label.Location = new Point(41, 54);
            label.Name = "label";
            label.Size = new Size(125, 38);
            label.TabIndex = 0;
            label.Text = "Nhiệt độ";
            label.Click += label_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F);
            label2.Location = new Point(261, 54);
            label2.Name = "label2";
            label2.Size = new Size(247, 38);
            label2.TabIndex = 1;
            label2.Text = "Khoảng cách Laser";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F);
            label3.Location = new Point(586, 54);
            label3.Name = "label3";
            label3.Size = new Size(133, 38);
            label3.TabIndex = 2;
            label3.Text = "Góc quay";
            label3.Click += label3_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 12F);
            label4.Location = new Point(803, 54);
            label4.Name = "label4";
            label4.Size = new Size(279, 38);
            label4.TabIndex = 3;
            label4.Text = "Khoảng cách siêu âm";
            label4.Click += label4_Click;
            // 
            // lblTemperature
            // 
            lblTemperature.AutoSize = true;
            lblTemperature.Font = new Font("Segoe UI", 12F);
            lblTemperature.Location = new Point(41, 93);
            lblTemperature.Name = "lblTemperature";
            lblTemperature.Size = new Size(53, 38);
            lblTemperature.TabIndex = 4;
            lblTemperature.Text = "0.0";
            lblTemperature.Click += label1_Click;
            // 
            // lblLaser
            // 
            this.lblLaser.AutoSize = true;
            this.lblLaser.Font = new Font("Segoe UI", 12F);
            this.lblLaser.Location = new Point(261, 93);
            this.lblLaser.Name = "lblLaser";
            this.lblLaser.Size = new Size(53, 38);
            this.lblLaser.TabIndex = 5;
            this.lblLaser.Text = "0.0";
            this.lblLaser.Click += this.label5_Click;
            // 
            // lblAngle
            // 
            lblAngle.AutoSize = true;
            lblAngle.Font = new Font("Segoe UI", 12F);
            lblAngle.Location = new Point(586, 93);
            lblAngle.Name = "lblAngle";
            lblAngle.Size = new Size(53, 38);
            lblAngle.TabIndex = 6;
            lblAngle.Text = "0.0";
            // 
            // lblUltrasonic
            // 
            lblUltrasonic.AutoSize = true;
            lblUltrasonic.Font = new Font("Segoe UI", 12F);
            lblUltrasonic.Location = new Point(803, 93);
            lblUltrasonic.Name = "lblUltrasonic";
            lblUltrasonic.Size = new Size(53, 38);
            lblUltrasonic.TabIndex = 7;
            lblUltrasonic.Text = "0.0";
            lblUltrasonic.Click += label7_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(12F, 30F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1131, 744);
            Controls.Add(lblUltrasonic);
            Controls.Add(lblAngle);
            Controls.Add(this.lblLaser);
            Controls.Add(lblTemperature);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label lblTemperature;
        private Label lblLaser;
        private Label lblAngle;
        private Label lblUltrasonic;
    }
}
