namespace xArmBLE
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
            this.ServoBar1 = new System.Windows.Forms.TrackBar();
            this.ServoBar2 = new System.Windows.Forms.TrackBar();
            this.ServoBar3 = new System.Windows.Forms.TrackBar();
            this.ServoBar4 = new System.Windows.Forms.TrackBar();
            this.ServoBar5 = new System.Windows.Forms.TrackBar();
            this.ServoBar6 = new System.Windows.Forms.TrackBar();
            this.ValueBox1 = new System.Windows.Forms.TextBox();
            this.ValueBox2 = new System.Windows.Forms.TextBox();
            this.ValueBox3 = new System.Windows.Forms.TextBox();
            this.ValueBox4 = new System.Windows.Forms.TextBox();
            this.ValueBox5 = new System.Windows.Forms.TextBox();
            this.ValueBox6 = new System.Windows.Forms.TextBox();
            this.SendButton = new System.Windows.Forms.Button();
            this.ConnectButton = new System.Windows.Forms.Button();
            this.DisconnectButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.ConnStatusBox = new System.Windows.Forms.TextBox();
            this.TxStatusBox = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.ServoBar1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ServoBar2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ServoBar3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ServoBar4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ServoBar5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ServoBar6)).BeginInit();
            this.SuspendLayout();
            // 
            // ServoBar1
            // 
            this.ServoBar1.Location = new System.Drawing.Point(52, 6);
            this.ServoBar1.Maximum = 120;
            this.ServoBar1.Minimum = -120;
            this.ServoBar1.Name = "ServoBar1";
            this.ServoBar1.Size = new System.Drawing.Size(263, 45);
            this.ServoBar1.TabIndex = 0;
            this.ServoBar1.Scroll += new System.EventHandler(this.ServoBar1_Scroll);
            // 
            // ServoBar2
            // 
            this.ServoBar2.Location = new System.Drawing.Point(52, 57);
            this.ServoBar2.Maximum = 120;
            this.ServoBar2.Minimum = -120;
            this.ServoBar2.Name = "ServoBar2";
            this.ServoBar2.Size = new System.Drawing.Size(263, 45);
            this.ServoBar2.TabIndex = 1;
            this.ServoBar2.Scroll += new System.EventHandler(this.ServoBar2_Scroll);
            // 
            // ServoBar3
            // 
            this.ServoBar3.Location = new System.Drawing.Point(52, 108);
            this.ServoBar3.Maximum = 120;
            this.ServoBar3.Minimum = -120;
            this.ServoBar3.Name = "ServoBar3";
            this.ServoBar3.Size = new System.Drawing.Size(263, 45);
            this.ServoBar3.TabIndex = 2;
            this.ServoBar3.Scroll += new System.EventHandler(this.ServoBar3_Scroll);
            // 
            // ServoBar4
            // 
            this.ServoBar4.Location = new System.Drawing.Point(52, 159);
            this.ServoBar4.Maximum = 120;
            this.ServoBar4.Minimum = -120;
            this.ServoBar4.Name = "ServoBar4";
            this.ServoBar4.Size = new System.Drawing.Size(263, 45);
            this.ServoBar4.TabIndex = 3;
            this.ServoBar4.Scroll += new System.EventHandler(this.ServoBar4_Scroll);
            // 
            // ServoBar5
            // 
            this.ServoBar5.Location = new System.Drawing.Point(52, 210);
            this.ServoBar5.Maximum = 120;
            this.ServoBar5.Minimum = -120;
            this.ServoBar5.Name = "ServoBar5";
            this.ServoBar5.Size = new System.Drawing.Size(263, 45);
            this.ServoBar5.TabIndex = 4;
            this.ServoBar5.Scroll += new System.EventHandler(this.ServoBar5_Scroll);
            // 
            // ServoBar6
            // 
            this.ServoBar6.Location = new System.Drawing.Point(52, 261);
            this.ServoBar6.Maximum = 120;
            this.ServoBar6.Minimum = -120;
            this.ServoBar6.Name = "ServoBar6";
            this.ServoBar6.Size = new System.Drawing.Size(263, 45);
            this.ServoBar6.TabIndex = 5;
            this.ServoBar6.Scroll += new System.EventHandler(this.ServoBar6_Scroll);
            // 
            // ValueBox1
            // 
            this.ValueBox1.Location = new System.Drawing.Point(321, 6);
            this.ValueBox1.Name = "ValueBox1";
            this.ValueBox1.Size = new System.Drawing.Size(100, 20);
            this.ValueBox1.TabIndex = 6;
            this.ValueBox1.TextChanged += new System.EventHandler(this.ValueBox1_TextChanged);
            // 
            // ValueBox2
            // 
            this.ValueBox2.Location = new System.Drawing.Point(321, 57);
            this.ValueBox2.Name = "ValueBox2";
            this.ValueBox2.Size = new System.Drawing.Size(100, 20);
            this.ValueBox2.TabIndex = 7;
            this.ValueBox2.TextChanged += new System.EventHandler(this.ValueBox2_TextChanged);
            // 
            // ValueBox3
            // 
            this.ValueBox3.Location = new System.Drawing.Point(321, 108);
            this.ValueBox3.Name = "ValueBox3";
            this.ValueBox3.Size = new System.Drawing.Size(100, 20);
            this.ValueBox3.TabIndex = 8;
            this.ValueBox3.TextChanged += new System.EventHandler(this.ValueBox3_TextChanged);
            // 
            // ValueBox4
            // 
            this.ValueBox4.Location = new System.Drawing.Point(321, 159);
            this.ValueBox4.Name = "ValueBox4";
            this.ValueBox4.Size = new System.Drawing.Size(100, 20);
            this.ValueBox4.TabIndex = 9;
            this.ValueBox4.TextChanged += new System.EventHandler(this.ValueBox4_TextChanged);
            // 
            // ValueBox5
            // 
            this.ValueBox5.Location = new System.Drawing.Point(321, 210);
            this.ValueBox5.Name = "ValueBox5";
            this.ValueBox5.Size = new System.Drawing.Size(100, 20);
            this.ValueBox5.TabIndex = 10;
            this.ValueBox5.TextChanged += new System.EventHandler(this.ValueBox5_TextChanged);
            // 
            // ValueBox6
            // 
            this.ValueBox6.Location = new System.Drawing.Point(321, 261);
            this.ValueBox6.Name = "ValueBox6";
            this.ValueBox6.Size = new System.Drawing.Size(100, 20);
            this.ValueBox6.TabIndex = 11;
            this.ValueBox6.TextChanged += new System.EventHandler(this.ValueBox6_TextChanged);
            // 
            // SendButton
            // 
            this.SendButton.Location = new System.Drawing.Point(321, 326);
            this.SendButton.Name = "SendButton";
            this.SendButton.Size = new System.Drawing.Size(75, 23);
            this.SendButton.TabIndex = 12;
            this.SendButton.Text = "Send";
            this.SendButton.UseVisualStyleBackColor = true;
            this.SendButton.Click += new System.EventHandler(this.SendButton_Click);
            // 
            // ConnectButton
            // 
            this.ConnectButton.Location = new System.Drawing.Point(52, 339);
            this.ConnectButton.Name = "ConnectButton";
            this.ConnectButton.Size = new System.Drawing.Size(75, 23);
            this.ConnectButton.TabIndex = 13;
            this.ConnectButton.Text = "Connect";
            this.ConnectButton.UseVisualStyleBackColor = true;
            this.ConnectButton.Click += new System.EventHandler(this.ConnectButton_Click);
            // 
            // DisconnectButton
            // 
            this.DisconnectButton.Location = new System.Drawing.Point(52, 368);
            this.DisconnectButton.Name = "DisconnectButton";
            this.DisconnectButton.Size = new System.Drawing.Size(75, 23);
            this.DisconnectButton.TabIndex = 14;
            this.DisconnectButton.Text = "Disconnect";
            this.DisconnectButton.UseVisualStyleBackColor = true;
            this.DisconnectButton.Click += new System.EventHandler(this.DisconnectButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(7, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 13);
            this.label1.TabIndex = 15;
            this.label1.Text = "Servo 1";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(7, 60);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 13);
            this.label2.TabIndex = 16;
            this.label2.Text = "Servo 2";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(7, 115);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(44, 13);
            this.label3.TabIndex = 17;
            this.label3.Text = "Servo 3";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(7, 162);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(44, 13);
            this.label4.TabIndex = 18;
            this.label4.Text = "Servo 4";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(7, 213);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(44, 13);
            this.label5.TabIndex = 19;
            this.label5.Text = "Servo 5";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(7, 264);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(44, 13);
            this.label6.TabIndex = 20;
            this.label6.Text = "Servo 6";
            // 
            // ConnStatusBox
            // 
            this.ConnStatusBox.Location = new System.Drawing.Point(12, 397);
            this.ConnStatusBox.Name = "ConnStatusBox";
            this.ConnStatusBox.Size = new System.Drawing.Size(153, 20);
            this.ConnStatusBox.TabIndex = 21;
            this.ConnStatusBox.Text = "xArm Disconnected";
            this.ConnStatusBox.TextChanged += new System.EventHandler(this.ConnStatusBox_TextChanged);
            // 
            // TxStatusBox
            // 
            this.TxStatusBox.Location = new System.Drawing.Point(286, 368);
            this.TxStatusBox.Name = "TxStatusBox";
            this.TxStatusBox.Size = new System.Drawing.Size(135, 20);
            this.TxStatusBox.TabIndex = 22;
            this.TxStatusBox.TextChanged += new System.EventHandler(this.TxStatusBox_TextChanged);
            // 
            // Form1
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(451, 428);
            this.Controls.Add(this.TxStatusBox);
            this.Controls.Add(this.ConnStatusBox);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.DisconnectButton);
            this.Controls.Add(this.ConnectButton);
            this.Controls.Add(this.SendButton);
            this.Controls.Add(this.ValueBox6);
            this.Controls.Add(this.ValueBox5);
            this.Controls.Add(this.ValueBox4);
            this.Controls.Add(this.ValueBox3);
            this.Controls.Add(this.ValueBox2);
            this.Controls.Add(this.ValueBox1);
            this.Controls.Add(this.ServoBar6);
            this.Controls.Add(this.ServoBar5);
            this.Controls.Add(this.ServoBar4);
            this.Controls.Add(this.ServoBar3);
            this.Controls.Add(this.ServoBar2);
            this.Controls.Add(this.ServoBar1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "Form1";
            this.Text = "xArmBLE";
            ((System.ComponentModel.ISupportInitialize)(this.ServoBar1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ServoBar2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ServoBar3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ServoBar4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ServoBar5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ServoBar6)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TrackBar ServoBar1;
        private System.Windows.Forms.TrackBar ServoBar2;
        private System.Windows.Forms.TrackBar ServoBar3;
        private System.Windows.Forms.TrackBar ServoBar4;
        private System.Windows.Forms.TrackBar ServoBar5;
        private System.Windows.Forms.TrackBar ServoBar6;
        private System.Windows.Forms.TextBox ValueBox1;
        private System.Windows.Forms.TextBox ValueBox2;
        private System.Windows.Forms.TextBox ValueBox3;
        private System.Windows.Forms.TextBox ValueBox4;
        private System.Windows.Forms.TextBox ValueBox5;
        private System.Windows.Forms.TextBox ValueBox6;
        private System.Windows.Forms.Button SendButton;
        private System.Windows.Forms.Button ConnectButton;
        private System.Windows.Forms.Button DisconnectButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox ConnStatusBox;
        private System.Windows.Forms.TextBox TxStatusBox;
    }
}

