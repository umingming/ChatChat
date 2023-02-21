﻿namespace BytePacketClient
{
    partial class ChatForm
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ChatForm));
            this.txtMsg = new System.Windows.Forms.TextBox();
            this.btnInput = new System.Windows.Forms.Button();
            this.cmbMax = new System.Windows.Forms.ComboBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.rtxChat = new System.Windows.Forms.RichTextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.fileSystemWatcher1 = new System.IO.FileSystemWatcher();
            this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.label3 = new System.Windows.Forms.Label();
            this.txtRoom = new System.Windows.Forms.TextBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fileSystemWatcher1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // txtMsg
            // 
            this.txtMsg.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtMsg.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtMsg.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.txtMsg.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(59)))), ((int)(((byte)(76)))));
            this.txtMsg.Location = new System.Drawing.Point(59, 338);
            this.txtMsg.Margin = new System.Windows.Forms.Padding(2);
            this.txtMsg.MaxLength = 200;
            this.txtMsg.Name = "txtMsg";
            this.txtMsg.Size = new System.Drawing.Size(208, 17);
            this.txtMsg.TabIndex = 1;
            this.txtMsg.KeyDown += new System.Windows.Forms.KeyEventHandler(this.EnterMsgByEnterKeyDown);
            // 
            // btnInput
            // 
            this.btnInput.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(214)))), ((int)(((byte)(160)))));
            this.btnInput.Cursor = System.Windows.Forms.Cursors.Default;
            this.btnInput.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnInput.Font = new System.Drawing.Font("이사만루체 Medium", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btnInput.ForeColor = System.Drawing.Color.White;
            this.btnInput.Location = new System.Drawing.Point(281, 330);
            this.btnInput.Margin = new System.Windows.Forms.Padding(0);
            this.btnInput.Name = "btnInput";
            this.btnInput.Size = new System.Drawing.Size(90, 34);
            this.btnInput.TabIndex = 2;
            this.btnInput.Text = "Send";
            this.btnInput.UseVisualStyleBackColor = false;
            this.btnInput.Click += new System.EventHandler(this.EnterMsg);
            this.btnInput.KeyDown += new System.Windows.Forms.KeyEventHandler(this.EnterMsgByEnterKeyDown);
            // 
            // cmbMax
            // 
            this.cmbMax.AllowDrop = true;
            this.cmbMax.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cmbMax.BackColor = System.Drawing.Color.White;
            this.cmbMax.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbMax.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmbMax.Font = new System.Drawing.Font("이사만루체 Medium", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.cmbMax.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(214)))), ((int)(((byte)(160)))));
            this.cmbMax.FormattingEnabled = true;
            this.errorProvider1.SetIconAlignment(this.cmbMax, System.Windows.Forms.ErrorIconAlignment.MiddleLeft);
            this.cmbMax.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.cmbMax.Items.AddRange(new object[] {
            "4",
            "10",
            "50",
            "100",
            "150",
            "200"});
            this.cmbMax.Location = new System.Drawing.Point(314, 89);
            this.cmbMax.Margin = new System.Windows.Forms.Padding(2);
            this.cmbMax.Name = "cmbMax";
            this.cmbMax.Size = new System.Drawing.Size(59, 26);
            this.cmbMax.TabIndex = 3;
            this.cmbMax.DropDownClosed += new System.EventHandler(this.SetMax);
            this.cmbMax.Enter += new System.EventHandler(this.SelectMax);
            this.cmbMax.MouseDown += new System.Windows.Forms.MouseEventHandler(this.SelectMax);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(249)))), ((int)(((byte)(235)))));
            this.panel1.Controls.Add(this.rtxChat);
            this.panel1.Font = new System.Drawing.Font("맑은 고딕", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.panel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(59)))), ((int)(((byte)(76)))));
            this.panel1.Location = new System.Drawing.Point(51, 119);
            this.panel1.Margin = new System.Windows.Forms.Padding(2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(321, 199);
            this.panel1.TabIndex = 15;
            // 
            // rtxChat
            // 
            this.rtxChat.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(249)))), ((int)(((byte)(235)))));
            this.rtxChat.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.rtxChat.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.rtxChat.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(59)))), ((int)(((byte)(76)))));
            this.rtxChat.Location = new System.Drawing.Point(0, 6);
            this.rtxChat.Margin = new System.Windows.Forms.Padding(8, 8, 8, 8);
            this.rtxChat.Name = "rtxChat";
            this.rtxChat.ReadOnly = true;
            this.rtxChat.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.ForcedVertical;
            this.rtxChat.ShowSelectionMargin = true;
            this.rtxChat.Size = new System.Drawing.Size(321, 193);
            this.rtxChat.TabIndex = 17;
            this.rtxChat.Text = "";
            this.rtxChat.WordWrap = false;
            // 
            // label5
            // 
            this.label5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(242)))), ((int)(((byte)(211)))));
            this.label5.Font = new System.Drawing.Font("이사만루체 Bold", 26F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(214)))), ((int)(((byte)(160)))));
            this.label5.Image = ((System.Drawing.Image)(resources.GetObject("label5.Image")));
            this.label5.Location = new System.Drawing.Point(78, 21);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(264, 62);
            this.label5.TabIndex = 16;
            this.label5.Text = "ChatChat";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // fileSystemWatcher1
            // 
            this.fileSystemWatcher1.EnableRaisingEvents = true;
            this.fileSystemWatcher1.SynchronizingObject = this;
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // label3
            // 
            this.label3.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.label3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label3.Location = new System.Drawing.Point(51, 332);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(228, 29);
            this.label3.TabIndex = 10;
            // 
            // txtRoom
            // 
            this.txtRoom.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtRoom.Font = new System.Drawing.Font("ONE 모바일고딕 Regular", 9F);
            this.txtRoom.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(59)))), ((int)(((byte)(76)))));
            this.txtRoom.Location = new System.Drawing.Point(74, 112);
            this.txtRoom.Name = "txtRoom";
            this.txtRoom.Size = new System.Drawing.Size(265, 17);
            this.txtRoom.TabIndex = 17;
            // 
            // ChatForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(418, 427);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btnInput);
            this.Controls.Add(this.cmbMax);
            this.Controls.Add(this.txtMsg);
            this.Controls.Add(this.label3);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(436, 474);
            this.MinimumSize = new System.Drawing.Size(436, 474);
            this.Name = "ChatForm";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Quit);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.fileSystemWatcher1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox txtMsg;
        private System.Windows.Forms.Button btnInput;
        private System.Windows.Forms.ComboBox cmbMax;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label5;
        private System.IO.FileSystemWatcher fileSystemWatcher1;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog1;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.RichTextBox rtxChat;
        private System.Windows.Forms.TextBox txtRoom;
        private System.Windows.Forms.Label label3;
    }
}