namespace IM_Lab_work_2
{
    partial class eventForm
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
            this.topPanel = new System.Windows.Forms.Panel();
            this.formLabel = new System.Windows.Forms.Label();
            this.closeButton = new System.Windows.Forms.Label();
            this.authorizationBox = new System.Windows.Forms.PictureBox();
            this.authorizationButton = new System.Windows.Forms.Button();
            this.calendarGroupBox = new System.Windows.Forms.GroupBox();
            this.eventCalendar = new System.Windows.Forms.MonthCalendar();
            this.optionGroupBox = new System.Windows.Forms.GroupBox();
            this.eventTextBox = new System.Windows.Forms.TextBox();
            this.eventTimePicker = new System.Windows.Forms.DateTimePicker();
            this.eventTypeBox = new System.Windows.Forms.ComboBox();
            this.typeLabel = new System.Windows.Forms.Label();
            this.textLabel = new System.Windows.Forms.Label();
            this.timeLabel = new System.Windows.Forms.Label();
            this.topPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.authorizationBox)).BeginInit();
            this.calendarGroupBox.SuspendLayout();
            this.optionGroupBox.SuspendLayout();
            this.SuspendLayout();
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
            this.topPanel.TabIndex = 2;
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
            this.formLabel.Size = new System.Drawing.Size(43, 17);
            this.formLabel.TabIndex = 2;
            this.formLabel.Text = "Event";
            // 
            // closeButton
            // 
            this.closeButton.AutoSize = true;
            this.closeButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.closeButton.Font = new System.Drawing.Font("Segoe UI Light", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.closeButton.ForeColor = System.Drawing.Color.DimGray;
            this.closeButton.Location = new System.Drawing.Point(762, 9);
            this.closeButton.Name = "closeButton";
            this.closeButton.Size = new System.Drawing.Size(26, 17);
            this.closeButton.TabIndex = 0;
            this.closeButton.Text = "⚫";
            this.closeButton.Click += new System.EventHandler(this.closeButton_Click);
            this.closeButton.MouseEnter += new System.EventHandler(this.closeButton_MouseEnter);
            this.closeButton.MouseLeave += new System.EventHandler(this.closeButton_MouseLeave);
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
            this.authorizationBox.TabIndex = 10;
            this.authorizationBox.TabStop = false;
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
            this.authorizationButton.TabIndex = 11;
            this.authorizationButton.Text = "OK";
            this.authorizationButton.UseVisualStyleBackColor = false;
            // 
            // calendarGroupBox
            // 
            this.calendarGroupBox.Controls.Add(this.eventCalendar);
            this.calendarGroupBox.Font = new System.Drawing.Font("Segoe UI Black", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.calendarGroupBox.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.calendarGroupBox.Location = new System.Drawing.Point(12, 41);
            this.calendarGroupBox.Name = "calendarGroupBox";
            this.calendarGroupBox.Size = new System.Drawing.Size(776, 226);
            this.calendarGroupBox.TabIndex = 12;
            this.calendarGroupBox.TabStop = false;
            this.calendarGroupBox.Text = "Calendar";
            // 
            // eventCalendar
            // 
            this.eventCalendar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.eventCalendar.BackColor = System.Drawing.SystemColors.Window;
            this.eventCalendar.CalendarDimensions = new System.Drawing.Size(3, 1);
            this.eventCalendar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.eventCalendar.FirstDayOfWeek = System.Windows.Forms.Day.Monday;
            this.eventCalendar.Font = new System.Drawing.Font("Segoe UI Black", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.eventCalendar.Location = new System.Drawing.Point(43, 30);
            this.eventCalendar.MinDate = new System.DateTime(1900, 1, 1, 0, 0, 0, 0);
            this.eventCalendar.Name = "eventCalendar";
            this.eventCalendar.ShowToday = false;
            this.eventCalendar.TabIndex = 5;
            this.eventCalendar.TrailingForeColor = System.Drawing.SystemColors.Window;
            // 
            // optionGroupBox
            // 
            this.optionGroupBox.Controls.Add(this.eventTextBox);
            this.optionGroupBox.Controls.Add(this.eventTimePicker);
            this.optionGroupBox.Controls.Add(this.eventTypeBox);
            this.optionGroupBox.Controls.Add(this.typeLabel);
            this.optionGroupBox.Controls.Add(this.textLabel);
            this.optionGroupBox.Controls.Add(this.timeLabel);
            this.optionGroupBox.Font = new System.Drawing.Font("Segoe UI Black", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.optionGroupBox.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.optionGroupBox.Location = new System.Drawing.Point(12, 273);
            this.optionGroupBox.Name = "optionGroupBox";
            this.optionGroupBox.Size = new System.Drawing.Size(776, 184);
            this.optionGroupBox.TabIndex = 13;
            this.optionGroupBox.TabStop = false;
            this.optionGroupBox.Text = "Options";
            // 
            // eventTextBox
            // 
            this.eventTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.eventTextBox.Location = new System.Drawing.Point(264, 85);
            this.eventTextBox.Name = "eventTextBox";
            this.eventTextBox.Size = new System.Drawing.Size(250, 25);
            this.eventTextBox.TabIndex = 5;
            // 
            // eventTimePicker
            // 
            this.eventTimePicker.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.eventTimePicker.CalendarFont = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.eventTimePicker.Cursor = System.Windows.Forms.Cursors.Hand;
            this.eventTimePicker.Location = new System.Drawing.Point(6, 85);
            this.eventTimePicker.MinDate = new System.DateTime(1900, 1, 1, 0, 0, 0, 0);
            this.eventTimePicker.Name = "eventTimePicker";
            this.eventTimePicker.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.eventTimePicker.ShowUpDown = true;
            this.eventTimePicker.Size = new System.Drawing.Size(250, 25);
            this.eventTimePicker.TabIndex = 4;
            this.eventTimePicker.Value = new System.DateTime(2020, 4, 4, 14, 37, 0, 0);
            // 
            // eventTypeBox
            // 
            this.eventTypeBox.Cursor = System.Windows.Forms.Cursors.Hand;
            this.eventTypeBox.FormattingEnabled = true;
            this.eventTypeBox.Location = new System.Drawing.Point(520, 85);
            this.eventTypeBox.Name = "eventTypeBox";
            this.eventTypeBox.Size = new System.Drawing.Size(250, 25);
            this.eventTypeBox.TabIndex = 3;
            // 
            // typeLabel
            // 
            this.typeLabel.AutoSize = true;
            this.typeLabel.Location = new System.Drawing.Point(517, 63);
            this.typeLabel.Name = "typeLabel";
            this.typeLabel.Size = new System.Drawing.Size(38, 17);
            this.typeLabel.TabIndex = 2;
            this.typeLabel.Text = "Type";
            // 
            // textLabel
            // 
            this.textLabel.AutoSize = true;
            this.textLabel.Location = new System.Drawing.Point(261, 63);
            this.textLabel.Name = "textLabel";
            this.textLabel.Size = new System.Drawing.Size(36, 17);
            this.textLabel.TabIndex = 1;
            this.textLabel.Text = "Text";
            // 
            // timeLabel
            // 
            this.timeLabel.AutoSize = true;
            this.timeLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.timeLabel.Location = new System.Drawing.Point(6, 63);
            this.timeLabel.Name = "timeLabel";
            this.timeLabel.Size = new System.Drawing.Size(41, 19);
            this.timeLabel.TabIndex = 0;
            this.timeLabel.Text = "Time";
            // 
            // eventForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DimGray;
            this.ClientSize = new System.Drawing.Size(800, 570);
            this.ControlBox = false;
            this.Controls.Add(this.optionGroupBox);
            this.Controls.Add(this.calendarGroupBox);
            this.Controls.Add(this.authorizationButton);
            this.Controls.Add(this.authorizationBox);
            this.Controls.Add(this.topPanel);
            this.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "eventForm";
            this.Text = "Event";
            this.topPanel.ResumeLayout(false);
            this.topPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.authorizationBox)).EndInit();
            this.calendarGroupBox.ResumeLayout(false);
            this.optionGroupBox.ResumeLayout(false);
            this.optionGroupBox.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel topPanel;
        private System.Windows.Forms.Label formLabel;
        private System.Windows.Forms.Label closeButton;
        private System.Windows.Forms.PictureBox authorizationBox;
        private System.Windows.Forms.Button authorizationButton;
        private System.Windows.Forms.GroupBox calendarGroupBox;
        public System.Windows.Forms.MonthCalendar eventCalendar;
        private System.Windows.Forms.GroupBox optionGroupBox;
        private System.Windows.Forms.Label timeLabel;
        private System.Windows.Forms.Label typeLabel;
        private System.Windows.Forms.Label textLabel;
        private System.Windows.Forms.TextBox eventTextBox;
        private System.Windows.Forms.DateTimePicker eventTimePicker;
        private System.Windows.Forms.ComboBox eventTypeBox;
    }
}