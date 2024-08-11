namespace prac_proj
{
    partial class loginForm
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
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(loginForm));
            label1 = new Label();
            panel2 = new Panel();
            button1 = new Button();
            registerLabel = new Label();
            forgotPassLabel = new Label();
            label4 = new Label();
            passwordField = new TextBox();
            accountIdField = new TextBox();
            label3 = new Label();
            label2 = new Label();
            logInPictureBox = new PictureBox();
            welcomeLabel = new Label();
            underWelcome = new Label();
            contextMenuStrip1 = new ContextMenuStrip(components);
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)logInPictureBox).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Lexend Deca", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.DarkBlue;
            label1.Location = new Point(127, 37);
            label1.Name = "label1";
            label1.Size = new Size(132, 54);
            label1.TabIndex = 1;
            label1.Text = "Log in";
            label1.Click += label1_Click;
            // 
            // panel2
            // 
            panel2.Controls.Add(button1);
            panel2.Controls.Add(registerLabel);
            panel2.Controls.Add(forgotPassLabel);
            panel2.Controls.Add(label4);
            panel2.Controls.Add(passwordField);
            panel2.Controls.Add(accountIdField);
            panel2.Controls.Add(label3);
            panel2.Controls.Add(label2);
            panel2.Controls.Add(label1);
            panel2.Location = new Point(528, 58);
            panel2.Name = "panel2";
            panel2.Size = new Size(376, 604);
            panel2.TabIndex = 2;
            panel2.TabStop = true;
            panel2.Paint += panel2_Paint;
            // 
            // button1
            // 
            button1.BackColor = Color.DarkBlue;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Font = new Font("Segoe UI Semibold", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button1.ForeColor = Color.White;
            button1.Location = new Point(123, 405);
            button1.Name = "button1";
            button1.Size = new Size(136, 47);
            button1.TabIndex = 7;
            button1.Text = "LOG IN";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click_1;
            // 
            // registerLabel
            // 
            registerLabel.AutoSize = true;
            registerLabel.ForeColor = Color.DodgerBlue;
            registerLabel.Location = new Point(151, 511);
            registerLabel.Name = "registerLabel";
            registerLabel.Size = new Size(63, 20);
            registerLabel.TabIndex = 6;
            registerLabel.Text = "Register";
            registerLabel.Click += registerLabel_Click;
            // 
            // forgotPassLabel
            // 
            forgotPassLabel.AutoSize = true;
            forgotPassLabel.ForeColor = Color.DodgerBlue;
            forgotPassLabel.Location = new Point(123, 347);
            forgotPassLabel.Name = "forgotPassLabel";
            forgotPassLabel.Size = new Size(125, 20);
            forgotPassLabel.TabIndex = 6;
            forgotPassLabel.Text = "Forgot Password?";
            forgotPassLabel.Click += forgotPassLabel_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(97, 482);
            label4.Name = "label4";
            label4.Size = new Size(187, 20);
            label4.TabIndex = 5;
            label4.Text = "Don't have an account yet?";
            label4.Click += label4_Click;
            // 
            // passwordField
            // 
            passwordField.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            passwordField.Location = new Point(36, 301);
            passwordField.Multiline = true;
            passwordField.Name = "passwordField";
            passwordField.PlaceholderText = "Enter password";
            passwordField.Size = new Size(303, 38);
            passwordField.TabIndex = 4;
            passwordField.UseSystemPasswordChar = true;
            passwordField.WordWrap = false;
            // 
            // accountIdField
            // 
            accountIdField.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            accountIdField.Location = new Point(36, 181);
            accountIdField.Multiline = true;
            accountIdField.Name = "accountIdField";
            accountIdField.PlaceholderText = "Enter account Id";
            accountIdField.Size = new Size(303, 38);
            accountIdField.TabIndex = 4;
            accountIdField.TextChanged += textBox2_TextChanged;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold);
            label3.ForeColor = Color.Indigo;
            label3.Location = new Point(36, 278);
            label3.Name = "label3";
            label3.Size = new Size(73, 20);
            label3.TabIndex = 3;
            label3.Text = "Password";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold);
            label2.ForeColor = Color.Indigo;
            label2.Location = new Point(36, 158);
            label2.Name = "label2";
            label2.Size = new Size(149, 20);
            label2.TabIndex = 2;
            label2.Text = "Account I.D Number";
            label2.Click += label2_Click;
            // 
            // logInPictureBox
            // 
            logInPictureBox.Dock = DockStyle.Left;
            logInPictureBox.Image = (Image)resources.GetObject("logInPictureBox.Image");
            logInPictureBox.Location = new Point(0, 0);
            logInPictureBox.Name = "logInPictureBox";
            logInPictureBox.Size = new Size(449, 731);
            logInPictureBox.SizeMode = PictureBoxSizeMode.Zoom;
            logInPictureBox.TabIndex = 3;
            logInPictureBox.TabStop = false;
            // 
            // welcomeLabel
            // 
            welcomeLabel.AutoSize = true;
            welcomeLabel.BackColor = Color.Transparent;
            welcomeLabel.Font = new Font("Lexend Deca", 24F, FontStyle.Bold, GraphicsUnit.Point, 0);
            welcomeLabel.ForeColor = SystemColors.ButtonHighlight;
            welcomeLabel.Location = new Point(115, 277);
            welcomeLabel.Name = "welcomeLabel";
            welcomeLabel.Size = new Size(237, 64);
            welcomeLabel.TabIndex = 4;
            welcomeLabel.Text = "WELCOME";
            welcomeLabel.Click += label5_Click_2;
            // 
            // underWelcome
            // 
            underWelcome.AutoSize = true;
            underWelcome.BackColor = Color.Transparent;
            underWelcome.Font = new Font("Lexend Deca", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            underWelcome.ForeColor = Color.White;
            underWelcome.Location = new Point(74, 355);
            underWelcome.Name = "underWelcome";
            underWelcome.Size = new Size(316, 37);
            underWelcome.TabIndex = 5;
            underWelcome.Text = "Please log in to get started";
            underWelcome.Click += underWelcome_Click;
            // 
            // contextMenuStrip1
            // 
            contextMenuStrip1.ImageScalingSize = new Size(20, 20);
            contextMenuStrip1.Name = "contextMenuStrip1";
            contextMenuStrip1.Size = new Size(61, 4);
            // 
            // loginForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(971, 731);
            Controls.Add(underWelcome);
            Controls.Add(welcomeLabel);
            Controls.Add(logInPictureBox);
            Controls.Add(panel2);
            Name = "loginForm";
            Text = "vxv....v.v.......cv..c/x  gn x,,,    . ";
            Load += Form1_Load;
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)logInPictureBox).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label label1;
        private Panel panel2;
        private Label label3;
        private Label label2;
        private Label label4;
        private PictureBox logInPictureBox;
        private Label welcomeLabel;
        private Label underWelcome;
        private TextBox accountIdField;
        private Label forgotPassLabel;
        private Label registerLabel;
        private TextBox passwordField;
        private ContextMenuStrip contextMenuStrip1;
        private Button button1;
    }
}
