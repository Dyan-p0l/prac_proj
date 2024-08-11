namespace prac_proj.forms
{
    partial class mainDashboard
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(mainDashboard));
            panel1 = new Panel();
            panel2 = new Panel();
            label1 = new Label();
            pictureBox1 = new PictureBox();
            depositButton = new Button();
            withdrawButton = new Button();
            balanceButton = new Button();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(1, 0, 72);
            panel1.Controls.Add(panel2);
            panel1.Dock = DockStyle.Left;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(176, 743);
            panel1.TabIndex = 0;
            // 
            // panel2
            // 
            panel2.BackColor = Color.FromArgb(3, 0, 46);
            panel2.Controls.Add(label1);
            panel2.Controls.Add(pictureBox1);
            panel2.Location = new Point(0, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(176, 152);
            panel2.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.White;
            label1.Location = new Point(54, 106);
            label1.Name = "label1";
            label1.Size = new Size(61, 28);
            label1.TabIndex = 1;
            label1.Text = "USER";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(36, 12);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(93, 81);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // depositButton
            // 
            depositButton.BackColor = Color.FromArgb(15, 66, 232);
            depositButton.FlatStyle = FlatStyle.Flat;
            depositButton.Font = new Font("Lexend Deca", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            depositButton.ForeColor = Color.White;
            depositButton.Location = new Point(333, 160);
            depositButton.Name = "depositButton";
            depositButton.Size = new Size(292, 223);
            depositButton.TabIndex = 1;
            depositButton.Text = "DEPOSIT";
            depositButton.UseVisualStyleBackColor = false;
            depositButton.Click += button1_Click;
            // 
            // withdrawButton
            // 
            withdrawButton.BackColor = Color.Red;
            withdrawButton.FlatStyle = FlatStyle.Flat;
            withdrawButton.Font = new Font("Lexend Deca", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            withdrawButton.ForeColor = Color.White;
            withdrawButton.Location = new Point(709, 160);
            withdrawButton.Name = "withdrawButton";
            withdrawButton.Size = new Size(292, 223);
            withdrawButton.TabIndex = 1;
            withdrawButton.Text = "WITHDRAW";
            withdrawButton.UseVisualStyleBackColor = false;
            withdrawButton.Click += withdrawButton_Click;
            // 
            // balanceButton
            // 
            balanceButton.BackColor = Color.Gray;
            balanceButton.FlatStyle = FlatStyle.Flat;
            balanceButton.Font = new Font("Lexend Deca", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            balanceButton.ForeColor = Color.White;
            balanceButton.Location = new Point(523, 442);
            balanceButton.Name = "balanceButton";
            balanceButton.Size = new Size(292, 223);
            balanceButton.TabIndex = 1;
            balanceButton.Text = "BALANCE";
            balanceButton.UseVisualStyleBackColor = false;
            // 
            // mainDashboard
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1131, 743);
            Controls.Add(balanceButton);
            Controls.Add(withdrawButton);
            Controls.Add(depositButton);
            Controls.Add(panel1);
            Name = "mainDashboard";
            Text = "mainDashboard";
            panel1.ResumeLayout(false);
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Panel panel2;
        private Label label1;
        private PictureBox pictureBox1;
        private Button depositButton;
        private Button withdrawButton;
        private Button balanceButton;
    }
}