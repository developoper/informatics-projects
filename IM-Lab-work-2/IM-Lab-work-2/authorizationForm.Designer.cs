namespace IM_Lab_work_2
{
    partial class authorizationForm
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
            this.closeButton = new System.Windows.Forms.Label();
            this.topPanel = new System.Windows.Forms.Panel();
            this.formLabel = new System.Windows.Forms.Label();
            this.logText = new System.Windows.Forms.TextBox();
            this.passText = new System.Windows.Forms.TextBox();
            this.showCheck = new System.Windows.Forms.CheckBox();
            this.authorizationButton = new System.Windows.Forms.Button();
            this.logTip = new System.Windows.Forms.ToolTip(this.components);
            this.passTip = new System.Windows.Forms.ToolTip(this.components);
            this.authorizationBox = new System.Windows.Forms.PictureBox();
            this.passPicture = new System.Windows.Forms.PictureBox();
            this.logPicture = new System.Windows.Forms.PictureBox();
            this.topPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.authorizationBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.passPicture)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.logPicture)).BeginInit();
            this.SuspendLayout();
            // 
            // closeButton
            // 
            this.closeButton.AutoSize = true;
            this.closeButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.closeButton.Font = new System.Drawing.Font("Segoe UI Light", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.closeButton.ForeColor = System.Drawing.Color.DimGray;
            this.closeButton.Location = new System.Drawing.Point(765, 9);
            this.closeButton.Margin = new System.Windows.Forms.Padding(0);
            this.closeButton.Name = "closeButton";
            this.closeButton.Size = new System.Drawing.Size(26, 17);
            this.closeButton.TabIndex = 0;
            this.closeButton.Text = "⚫";
            this.closeButton.Click += new System.EventHandler(this.closeButton_Click);
            this.closeButton.MouseEnter += new System.EventHandler(this.closeButton_MouseEnter);
            this.closeButton.MouseLeave += new System.EventHandler(this.closeButton_MouseLeave);
            // 
            // topPanel
            // 
            this.topPanel.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.topPanel.Controls.Add(this.formLabel);
            this.topPanel.Controls.Add(this.closeButton);
            this.topPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.topPanel.Location = new System.Drawing.Point(0, 0);
            this.topPanel.Name = "topPanel";
            this.topPanel.Size = new System.Drawing.Size(800, 35);
            this.topPanel.TabIndex = 1;
            this.topPanel.MouseDown += new System.Windows.Forms.MouseEventHandler(this.topPanel_MouseDown);
            this.topPanel.MouseMove += new System.Windows.Forms.MouseEventHandler(this.topPanel_MouseMove);
            // 
            // formLabel
            // 
            this.formLabel.AutoSize = true;
            this.formLabel.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.formLabel.Font = new System.Drawing.Font("Segoe UI Black", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.formLabel.ForeColor = System.Drawing.Color.DimGray;
            this.formLabel.Location = new System.Drawing.Point(12, 9);
            this.formLabel.Name = "formLabel";
            this.formLabel.Size = new System.Drawing.Size(96, 17);
            this.formLabel.TabIndex = 2;
            this.formLabel.Text = "Authorization";
            // 
            // logText
            // 
            this.logText.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.logText.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.logText.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.logText.Font = new System.Drawing.Font("Segoe UI", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.logText.Location = new System.Drawing.Point(156, 100);
            this.logText.Multiline = true;
            this.logText.Name = "logText";
            this.logText.Size = new System.Drawing.Size(594, 100);
            this.logText.TabIndex = 4;
            this.logText.MouseEnter += new System.EventHandler(this.logText_MouseEnter);
            // 
            // passText
            // 
            this.passText.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.passText.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.passText.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.passText.Font = new System.Drawing.Font("Segoe UI", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.passText.Location = new System.Drawing.Point(156, 260);
            this.passText.Multiline = true;
            this.passText.Name = "passText";
            this.passText.PasswordChar = '✱';
            this.passText.Size = new System.Drawing.Size(594, 100);
            this.passText.TabIndex = 5;
            this.passText.MouseEnter += new System.EventHandler(this.passText_MouseEnter);
            // 
            // showCheck
            // 
            this.showCheck.Appearance = System.Windows.Forms.Appearance.Button;
            this.showCheck.AutoSize = true;
            this.showCheck.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.showCheck.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.showCheck.CheckAlign = System.Drawing.ContentAlignment.TopCenter;
            this.showCheck.Cursor = System.Windows.Forms.Cursors.Hand;
            this.showCheck.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.showCheck.Font = new System.Drawing.Font("Segoe UI Black", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.showCheck.ForeColor = System.Drawing.Color.DimGray;
            this.showCheck.Location = new System.Drawing.Point(634, 366);
            this.showCheck.Name = "showCheck";
            this.showCheck.Size = new System.Drawing.Size(116, 27);
            this.showCheck.TabIndex = 6;
            this.showCheck.Text = "Show password";
            this.showCheck.UseVisualStyleBackColor = false;
            this.showCheck.Click += new System.EventHandler(this.showCheck_Click);
            // 
            // authorizationButton
            // 
            this.authorizationButton.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.authorizationButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.authorizationButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.authorizationButton.Font = new System.Drawing.Font("Segoe UI Black", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.authorizationButton.ForeColor = System.Drawing.Color.DimGray;
            this.authorizationButton.Location = new System.Drawing.Point(395, 470);
            this.authorizationButton.Margin = new System.Windows.Forms.Padding(0);
            this.authorizationButton.Name = "authorizationButton";
            this.authorizationButton.Size = new System.Drawing.Size(75, 75);
            this.authorizationButton.TabIndex = 7;
            this.authorizationButton.Text = "OK";
            this.authorizationButton.UseVisualStyleBackColor = false;
            this.authorizationButton.Click += new System.EventHandler(this.authorizationButton_Click);
            // 
            // logTip
            // 
            this.logTip.ToolTipTitle = "Enter your login here";
            // 
            // passTip
            // 
            this.passTip.ToolTipTitle = "Enter your password here";
            // 
            // authorizationBox
            // 
            this.authorizationBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(195)))));
            this.authorizationBox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.authorizationBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.authorizationBox.Image = global::IM_Lab_work_2.Properties.Resources.ok;
            this.authorizationBox.Location = new System.Drawing.Point(320, 470);
            this.authorizationBox.Margin = new System.Windows.Forms.Padding(0);
            this.authorizationBox.Name = "authorizationBox";
            this.authorizationBox.Size = new System.Drawing.Size(75, 75);
            this.authorizationBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.authorizationBox.TabIndex = 9;
            this.authorizationBox.TabStop = false;
            // 
            // passPicture
            // 
            this.passPicture.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.passPicture.Image = global::IM_Lab_work_2.Properties.Resources.password;
            this.passPicture.Location = new System.Drawing.Point(50, 260);
            this.passPicture.Name = "passPicture";
            this.passPicture.Size = new System.Drawing.Size(100, 100);
            this.passPicture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.passPicture.TabIndex = 3;
            this.passPicture.TabStop = false;
            // 
            // logPicture
            // 
            this.logPicture.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.logPicture.Image = global::IM_Lab_work_2.Properties.Resources.login;
            this.logPicture.Location = new System.Drawing.Point(50, 100);
            this.logPicture.Name = "logPicture";
            this.logPicture.Size = new System.Drawing.Size(100, 100);
            this.logPicture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.logPicture.TabIndex = 2;
            this.logPicture.TabStop = false;
            // 
            // authorizationForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DimGray;
            this.ClientSize = new System.Drawing.Size(800, 570);
            this.ControlBox = false;
            this.Controls.Add(this.authorizationBox);
            this.Controls.Add(this.authorizationButton);
            this.Controls.Add(this.showCheck);
            this.Controls.Add(this.passText);
            this.Controls.Add(this.logText);
            this.Controls.Add(this.passPicture);
            this.Controls.Add(this.logPicture);
            this.Controls.Add(this.topPanel);
            this.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "authorizationForm";
            this.Text = "Authorization";
            this.topPanel.ResumeLayout(false);
            this.topPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.authorizationBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.passPicture)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.logPicture)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label closeButton;
        private System.Windows.Forms.Panel topPanel;
        private System.Windows.Forms.Label formLabel;
        private System.Windows.Forms.PictureBox logPicture;
        private System.Windows.Forms.PictureBox passPicture;
        private System.Windows.Forms.TextBox logText;
        private System.Windows.Forms.TextBox passText;
        private System.Windows.Forms.CheckBox showCheck;
        private System.Windows.Forms.Button authorizationButton;
        private System.Windows.Forms.ToolTip logTip;
        private System.Windows.Forms.ToolTip passTip;
        private System.Windows.Forms.PictureBox authorizationBox;
    }
}