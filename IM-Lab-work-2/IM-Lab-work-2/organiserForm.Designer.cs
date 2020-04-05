namespace IM_Lab_work_2
{
    partial class organiserForm
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
            this.viewPanel = new System.Windows.Forms.Panel();
            this.viewGroupBox = new System.Windows.Forms.GroupBox();
            this.viewLayoutPanel = new System.Windows.Forms.TableLayoutPanel();
            this.viewComboBox = new System.Windows.Forms.ComboBox();
            this.CategoryRadioButton = new System.Windows.Forms.RadioButton();
            this.EventRadioButton = new System.Windows.Forms.RadioButton();
            this.operationPanel = new System.Windows.Forms.Panel();
            this.operationGroupBox = new System.Windows.Forms.GroupBox();
            this.addButton = new System.Windows.Forms.Button();
            this.findButton = new System.Windows.Forms.Button();
            this.filterButton = new System.Windows.Forms.Button();
            this.mainDataGridView = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.topPanel.SuspendLayout();
            this.viewPanel.SuspendLayout();
            this.viewGroupBox.SuspendLayout();
            this.viewLayoutPanel.SuspendLayout();
            this.operationPanel.SuspendLayout();
            this.operationGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.mainDataGridView)).BeginInit();
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
            this.formLabel.Size = new System.Drawing.Size(70, 17);
            this.formLabel.TabIndex = 2;
            this.formLabel.Text = "Organiser";
            // 
            // closeButton
            // 
            this.closeButton.AutoSize = true;
            this.closeButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.closeButton.Font = new System.Drawing.Font("Segoe UI Light", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.closeButton.ForeColor = System.Drawing.Color.DimGray;
            this.closeButton.Location = new System.Drawing.Point(765, 9);
            this.closeButton.Name = "closeButton";
            this.closeButton.Size = new System.Drawing.Size(26, 17);
            this.closeButton.TabIndex = 0;
            this.closeButton.Text = "⚫";
            this.closeButton.Click += new System.EventHandler(this.closeButton_Click);
            this.closeButton.MouseEnter += new System.EventHandler(this.closeButton_MouseEnter);
            this.closeButton.MouseLeave += new System.EventHandler(this.closeButton_MouseLeave);
            // 
            // viewPanel
            // 
            this.viewPanel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.viewPanel.BackColor = System.Drawing.Color.DimGray;
            this.viewPanel.Controls.Add(this.viewGroupBox);
            this.viewPanel.Location = new System.Drawing.Point(0, 35);
            this.viewPanel.Name = "viewPanel";
            this.viewPanel.Size = new System.Drawing.Size(800, 90);
            this.viewPanel.TabIndex = 3;
            // 
            // viewGroupBox
            // 
            this.viewGroupBox.Controls.Add(this.viewLayoutPanel);
            this.viewGroupBox.Font = new System.Drawing.Font("Segoe UI Black", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.viewGroupBox.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.viewGroupBox.Location = new System.Drawing.Point(9, 3);
            this.viewGroupBox.Name = "viewGroupBox";
            this.viewGroupBox.Size = new System.Drawing.Size(782, 84);
            this.viewGroupBox.TabIndex = 0;
            this.viewGroupBox.TabStop = false;
            this.viewGroupBox.Text = "View";
            // 
            // viewLayoutPanel
            // 
            this.viewLayoutPanel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.viewLayoutPanel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.viewLayoutPanel.ColumnCount = 2;
            this.viewLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.viewLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.viewLayoutPanel.Controls.Add(this.viewComboBox, 1, 0);
            this.viewLayoutPanel.Controls.Add(this.CategoryRadioButton, 0, 0);
            this.viewLayoutPanel.Controls.Add(this.EventRadioButton, 0, 1);
            this.viewLayoutPanel.Location = new System.Drawing.Point(6, 18);
            this.viewLayoutPanel.Name = "viewLayoutPanel";
            this.viewLayoutPanel.RowCount = 2;
            this.viewLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.viewLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.viewLayoutPanel.Size = new System.Drawing.Size(770, 57);
            this.viewLayoutPanel.TabIndex = 1;
            // 
            // viewComboBox
            // 
            this.viewComboBox.BackColor = System.Drawing.SystemColors.Window;
            this.viewComboBox.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.viewComboBox.ForeColor = System.Drawing.Color.Black;
            this.viewComboBox.FormattingEnabled = true;
            this.viewComboBox.Items.AddRange(new object[] {
            "Memo",
            "Meeting",
            "Task"});
            this.viewComboBox.Location = new System.Drawing.Point(388, 3);
            this.viewComboBox.Name = "viewComboBox";
            this.viewComboBox.Size = new System.Drawing.Size(365, 25);
            this.viewComboBox.TabIndex = 5;
            // 
            // CategoryRadioButton
            // 
            this.CategoryRadioButton.AutoSize = true;
            this.CategoryRadioButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CategoryRadioButton.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.CategoryRadioButton.ForeColor = System.Drawing.Color.Black;
            this.CategoryRadioButton.Location = new System.Drawing.Point(3, 3);
            this.CategoryRadioButton.Name = "CategoryRadioButton";
            this.CategoryRadioButton.Size = new System.Drawing.Size(121, 21);
            this.CategoryRadioButton.TabIndex = 6;
            this.CategoryRadioButton.TabStop = true;
            this.CategoryRadioButton.Text = "All by Category";
            this.CategoryRadioButton.UseVisualStyleBackColor = true;
            // 
            // EventRadioButton
            // 
            this.EventRadioButton.AutoSize = true;
            this.EventRadioButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.EventRadioButton.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.EventRadioButton.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.EventRadioButton.Location = new System.Drawing.Point(3, 31);
            this.EventRadioButton.Name = "EventRadioButton";
            this.EventRadioButton.Size = new System.Drawing.Size(86, 21);
            this.EventRadioButton.TabIndex = 7;
            this.EventRadioButton.TabStop = true;
            this.EventRadioButton.Text = "All Events";
            this.EventRadioButton.UseVisualStyleBackColor = true;
            // 
            // operationPanel
            // 
            this.operationPanel.BackColor = System.Drawing.Color.DimGray;
            this.operationPanel.Controls.Add(this.operationGroupBox);
            this.operationPanel.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.operationPanel.Location = new System.Drawing.Point(0, 470);
            this.operationPanel.Name = "operationPanel";
            this.operationPanel.Size = new System.Drawing.Size(800, 100);
            this.operationPanel.TabIndex = 4;
            // 
            // operationGroupBox
            // 
            this.operationGroupBox.Controls.Add(this.addButton);
            this.operationGroupBox.Controls.Add(this.findButton);
            this.operationGroupBox.Controls.Add(this.filterButton);
            this.operationGroupBox.Font = new System.Drawing.Font("Segoe UI Black", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.operationGroupBox.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.operationGroupBox.Location = new System.Drawing.Point(9, 3);
            this.operationGroupBox.Name = "operationGroupBox";
            this.operationGroupBox.Size = new System.Drawing.Size(782, 85);
            this.operationGroupBox.TabIndex = 0;
            this.operationGroupBox.TabStop = false;
            this.operationGroupBox.Text = "Operations";
            // 
            // addButton
            // 
            this.addButton.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.addButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.addButton.ForeColor = System.Drawing.Color.DimGray;
            this.addButton.Location = new System.Drawing.Point(526, 26);
            this.addButton.Name = "addButton";
            this.addButton.Size = new System.Drawing.Size(250, 50);
            this.addButton.TabIndex = 2;
            this.addButton.Text = "Add";
            this.addButton.UseVisualStyleBackColor = false;
            this.addButton.Click += new System.EventHandler(this.addButton_Click);
            // 
            // findButton
            // 
            this.findButton.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.findButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.findButton.ForeColor = System.Drawing.Color.DimGray;
            this.findButton.Location = new System.Drawing.Point(266, 26);
            this.findButton.Name = "findButton";
            this.findButton.Size = new System.Drawing.Size(250, 50);
            this.findButton.TabIndex = 1;
            this.findButton.Text = "Find";
            this.findButton.UseVisualStyleBackColor = false;
            // 
            // filterButton
            // 
            this.filterButton.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.filterButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.filterButton.ForeColor = System.Drawing.Color.DimGray;
            this.filterButton.Location = new System.Drawing.Point(6, 26);
            this.filterButton.Name = "filterButton";
            this.filterButton.Size = new System.Drawing.Size(250, 50);
            this.filterButton.TabIndex = 0;
            this.filterButton.Text = "Filter";
            this.filterButton.UseVisualStyleBackColor = false;
            // 
            // mainDataGridView
            // 
            this.mainDataGridView.BackgroundColor = System.Drawing.SystemColors.Window;
            this.mainDataGridView.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.mainDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.mainDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3});
            this.mainDataGridView.GridColor = System.Drawing.SystemColors.Control;
            this.mainDataGridView.Location = new System.Drawing.Point(9, 134);
            this.mainDataGridView.Name = "mainDataGridView";
            this.mainDataGridView.Size = new System.Drawing.Size(782, 330);
            this.mainDataGridView.TabIndex = 5;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Data";
            this.Column1.Name = "Column1";
            this.Column1.Width = 250;
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Time";
            this.Column2.Name = "Column2";
            this.Column2.Width = 250;
            // 
            // Column3
            // 
            this.Column3.HeaderText = "Event";
            this.Column3.Name = "Column3";
            this.Column3.Width = 250;
            // 
            // organiserForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DimGray;
            this.ClientSize = new System.Drawing.Size(800, 570);
            this.ControlBox = false;
            this.Controls.Add(this.mainDataGridView);
            this.Controls.Add(this.operationPanel);
            this.Controls.Add(this.viewPanel);
            this.Controls.Add(this.topPanel);
            this.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "organiserForm";
            this.Text = "Organiser";
            this.Load += new System.EventHandler(this.organiserForm_Load);
            this.topPanel.ResumeLayout(false);
            this.topPanel.PerformLayout();
            this.viewPanel.ResumeLayout(false);
            this.viewGroupBox.ResumeLayout(false);
            this.viewLayoutPanel.ResumeLayout(false);
            this.viewLayoutPanel.PerformLayout();
            this.operationPanel.ResumeLayout(false);
            this.operationGroupBox.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.mainDataGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel topPanel;
        private System.Windows.Forms.Label formLabel;
        private System.Windows.Forms.Label closeButton;
        private System.Windows.Forms.Panel viewPanel;
        private System.Windows.Forms.Panel operationPanel;
        private System.Windows.Forms.GroupBox viewGroupBox;
        private System.Windows.Forms.TableLayoutPanel viewLayoutPanel;
        private System.Windows.Forms.ComboBox viewComboBox;
        private System.Windows.Forms.RadioButton CategoryRadioButton;
        private System.Windows.Forms.RadioButton EventRadioButton;
        private System.Windows.Forms.DataGridView mainDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.GroupBox operationGroupBox;
        private System.Windows.Forms.Button addButton;
        private System.Windows.Forms.Button findButton;
        private System.Windows.Forms.Button filterButton;
    }
}