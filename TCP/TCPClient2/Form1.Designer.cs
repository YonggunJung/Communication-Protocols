namespace TCPClient2
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
            lblClient = new Label();
            btnConnect = new Button();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            nudRoomId = new NumericUpDown();
            txtName = new TextBox();
            txtMessage = new TextBox();
            btnStop = new Button();
            lbxMsg = new ListBox();
            ((System.ComponentModel.ISupportInitialize)nudRoomId).BeginInit();
            SuspendLayout();
            // 
            // lblClient
            // 
            lblClient.AutoSize = true;
            lblClient.Font = new Font("한컴 고딕", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 129);
            lblClient.Location = new Point(12, 9);
            lblClient.Name = "lblClient";
            lblClient.Size = new Size(67, 27);
            lblClient.TabIndex = 0;
            lblClient.Text = "Client";
            // 
            // btnConnect
            // 
            btnConnect.Location = new Point(489, 65);
            btnConnect.Name = "btnConnect";
            btnConnect.Size = new Size(108, 92);
            btnConnect.TabIndex = 1;
            btnConnect.Text = "연결";
            btnConnect.UseVisualStyleBackColor = true;
            btnConnect.Click += btnConnect_Click_1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("맑은 고딕", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 129);
            label1.Location = new Point(31, 54);
            label1.Name = "label1";
            label1.Size = new Size(89, 25);
            label1.TabIndex = 2;
            label1.Text = "Room ID";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("맑은 고딕", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 129);
            label2.Location = new Point(31, 92);
            label2.Name = "label2";
            label2.Size = new Size(64, 25);
            label2.TabIndex = 2;
            label2.Text = "Name";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("맑은 고딕", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 129);
            label3.Location = new Point(31, 132);
            label3.Name = "label3";
            label3.Size = new Size(86, 25);
            label3.TabIndex = 2;
            label3.Text = "Message";
            // 
            // nudRoomId
            // 
            nudRoomId.Location = new Point(126, 54);
            nudRoomId.Name = "nudRoomId";
            nudRoomId.Size = new Size(120, 23);
            nudRoomId.TabIndex = 3;
            // 
            // txtName
            // 
            txtName.Location = new Point(126, 94);
            txtName.Name = "txtName";
            txtName.Size = new Size(216, 23);
            txtName.TabIndex = 4;
            // 
            // txtMessage
            // 
            txtMessage.Location = new Point(126, 134);
            txtMessage.Name = "txtMessage";
            txtMessage.Size = new Size(357, 23);
            txtMessage.TabIndex = 4;
            // 
            // btnStop
            // 
            btnStop.Location = new Point(603, 65);
            btnStop.Name = "btnStop";
            btnStop.Size = new Size(108, 92);
            btnStop.TabIndex = 1;
            btnStop.Text = "종료";
            btnStop.UseVisualStyleBackColor = true;
            btnStop.Click += btnStop_Click_1;
            // 
            // lbxMsg
            // 
            lbxMsg.FormattingEnabled = true;
            lbxMsg.ItemHeight = 15;
            lbxMsg.Location = new Point(31, 163);
            lbxMsg.Name = "lbxMsg";
            lbxMsg.Size = new Size(680, 244);
            lbxMsg.TabIndex = 5;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(lbxMsg);
            Controls.Add(txtMessage);
            Controls.Add(txtName);
            Controls.Add(nudRoomId);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(btnStop);
            Controls.Add(btnConnect);
            Controls.Add(lblClient);
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)nudRoomId).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblClient;
        private Button btnConnect;
        private Label label1;
        private Label label2;
        private Label label3;
        private NumericUpDown nudRoomId;
        private TextBox txtName;
        private TextBox txtMessage;
        private Button btnStop;
        private ListBox lbxMsg;
    }
}
