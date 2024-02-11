namespace SharpRTSPClientDemo
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
            components = new System.ComponentModel.Container();
            groupBox1 = new GroupBox();
            tableLayoutPanel1 = new TableLayoutPanel();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            TextBoxIP = new TextBox();
            TextBoxUsername = new TextBox();
            TextBoxPassword = new TextBox();
            ToolTipInformation = new ToolTip(components);
            flowLayoutPanel1 = new FlowLayoutPanel();
            ButtonConnect = new Button();
            ButtonDisconnect = new Button();
            groupBox1.SuspendLayout();
            tableLayoutPanel1.SuspendLayout();
            flowLayoutPanel1.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(tableLayoutPanel1);
            groupBox1.Dock = DockStyle.Top;
            groupBox1.Location = new Point(0, 0);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(1254, 200);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Connection:";
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 3;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle());
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle());
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.Controls.Add(label1, 0, 0);
            tableLayoutPanel1.Controls.Add(label2, 0, 1);
            tableLayoutPanel1.Controls.Add(label3, 0, 2);
            tableLayoutPanel1.Controls.Add(TextBoxIP, 1, 0);
            tableLayoutPanel1.Controls.Add(TextBoxUsername, 1, 1);
            tableLayoutPanel1.Controls.Add(TextBoxPassword, 1, 2);
            tableLayoutPanel1.Controls.Add(flowLayoutPanel1, 2, 2);
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.Location = new Point(3, 35);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 3;
            tableLayoutPanel1.RowStyles.Add(new RowStyle());
            tableLayoutPanel1.RowStyles.Add(new RowStyle());
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel1.Size = new Size(1248, 162);
            tableLayoutPanel1.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(3, 0);
            label1.Name = "label1";
            label1.Size = new Size(33, 32);
            label1.TabIndex = 0;
            label1.Text = "IP";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(3, 45);
            label2.Name = "label2";
            label2.Size = new Size(121, 32);
            label2.TabIndex = 1;
            label2.Text = "Username";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(3, 90);
            label3.Name = "label3";
            label3.Size = new Size(111, 32);
            label3.TabIndex = 2;
            label3.Text = "Password";
            // 
            // TextBoxIP
            // 
            TextBoxIP.Location = new Point(130, 3);
            TextBoxIP.Name = "TextBoxIP";
            TextBoxIP.Size = new Size(320, 39);
            TextBoxIP.TabIndex = 3;
            ToolTipInformation.SetToolTip(TextBoxIP, "IP Address for camera (rtsp:// http://)");
            // 
            // TextBoxUsername
            // 
            TextBoxUsername.Location = new Point(130, 48);
            TextBoxUsername.Name = "TextBoxUsername";
            TextBoxUsername.Size = new Size(320, 39);
            TextBoxUsername.TabIndex = 4;
            // 
            // TextBoxPassword
            // 
            TextBoxPassword.Location = new Point(130, 93);
            TextBoxPassword.Name = "TextBoxPassword";
            TextBoxPassword.Size = new Size(320, 39);
            TextBoxPassword.TabIndex = 5;
            // 
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.Controls.Add(ButtonConnect);
            flowLayoutPanel1.Controls.Add(ButtonDisconnect);
            flowLayoutPanel1.Dock = DockStyle.Fill;
            flowLayoutPanel1.Location = new Point(456, 93);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Size = new Size(789, 66);
            flowLayoutPanel1.TabIndex = 6;
            // 
            // ButtonConnect
            // 
            ButtonConnect.Location = new Point(5, 5);
            ButtonConnect.Margin = new Padding(5);
            ButtonConnect.Name = "ButtonConnect";
            ButtonConnect.Size = new Size(150, 46);
            ButtonConnect.TabIndex = 0;
            ButtonConnect.Text = "Connect";
            ButtonConnect.UseVisualStyleBackColor = true;
            ButtonConnect.Click += ButtonConnect_Click;
            // 
            // ButtonDisconnect
            // 
            ButtonDisconnect.Location = new Point(163, 3);
            ButtonDisconnect.Name = "ButtonDisconnect";
            ButtonDisconnect.Size = new Size(150, 46);
            ButtonDisconnect.TabIndex = 1;
            ButtonDisconnect.Text = "Disconnect";
            ButtonDisconnect.UseVisualStyleBackColor = true;
            ButtonDisconnect.Click += ButtonDisconnect_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1254, 649);
            Controls.Add(groupBox1);
            MinimumSize = new Size(1280, 720);
            Name = "Form1";
            Text = "Form1";
            groupBox1.ResumeLayout(false);
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel1.PerformLayout();
            flowLayoutPanel1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private TableLayoutPanel tableLayoutPanel1;
        private Label label1;
        private Label label2;
        private Label label3;
        private TextBox TextBoxIP;
        private TextBox TextBoxUsername;
        private TextBox TextBoxPassword;
        private ToolTip ToolTipInformation;
        private FlowLayoutPanel flowLayoutPanel1;
        private Button ButtonConnect;
        private Button ButtonDisconnect;
    }
}
