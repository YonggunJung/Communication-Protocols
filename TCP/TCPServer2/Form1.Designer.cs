namespace TCPServer2
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
            lblServer = new Label();
            btnStart = new Button();
            btnStop = new Button();
            label1 = new Label();
            label2 = new Label();
            LB1 = new ListBox();
            LB2 = new ListBox();
            SuspendLayout();
            // 
            // lblServer
            // 
            lblServer.AutoSize = true;
            lblServer.Font = new Font("한컴 고딕", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 129);
            lblServer.Location = new Point(12, 9);
            lblServer.Name = "lblServer";
            lblServer.Size = new Size(75, 27);
            lblServer.TabIndex = 0;
            lblServer.Text = "Server";
            // 
            // btnStart
            // 
            btnStart.Location = new Point(32, 39);
            btnStart.Name = "btnStart";
            btnStart.Size = new Size(146, 78);
            btnStart.TabIndex = 1;
            btnStart.Text = "시작";
            btnStart.UseVisualStyleBackColor = true;
            btnStart.Click += btnStart_Click;
            // 
            // btnStop
            // 
            btnStop.Location = new Point(212, 39);
            btnStop.Name = "btnStop";
            btnStop.Size = new Size(146, 78);
            btnStop.TabIndex = 1;
            btnStop.Text = "중지";
            btnStop.UseVisualStyleBackColor = true;
            btnStop.Click += btnStop_Click_1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("맑은 고딕", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 129);
            label1.Location = new Point(32, 131);
            label1.Name = "label1";
            label1.Size = new Size(169, 25);
            label1.TabIndex = 2;
            label1.Text = "Connected Clients";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("맑은 고딕", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 129);
            label2.Location = new Point(269, 131);
            label2.Name = "label2";
            label2.Size = new Size(86, 25);
            label2.TabIndex = 2;
            label2.Text = "Message";
            // 
            // LB1
            // 
            LB1.FormattingEnabled = true;
            LB1.ItemHeight = 15;
            LB1.Location = new Point(32, 159);
            LB1.Name = "LB1";
            LB1.Size = new Size(208, 259);
            LB1.TabIndex = 3;
            // 
            // LB2
            // 
            LB2.FormattingEnabled = true;
            LB2.ItemHeight = 15;
            LB2.Location = new Point(269, 159);
            LB2.Name = "LB2";
            LB2.Size = new Size(383, 259);
            LB2.TabIndex = 3;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(LB2);
            Controls.Add(LB1);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(btnStop);
            Controls.Add(btnStart);
            Controls.Add(lblServer);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblServer;
        private Button btnStart;
        private Button btnStop;
        private Label label1;
        private Label label2;
        private ListBox LB1;
        private ListBox LB2;
    }
}
