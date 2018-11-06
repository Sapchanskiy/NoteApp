namespace NoteAppUI
{
    partial class AddOrEditNoteForm
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
            this.TitleLabel = new System.Windows.Forms.Label();
            this.CategoryLabel = new System.Windows.Forms.Label();
            this.CreatedDateLabel = new System.Windows.Forms.Label();
            this.ModifiedDateLabel = new System.Windows.Forms.Label();
            this.CreatedDate = new System.Windows.Forms.DateTimePicker();
            this.ModifiedDate = new System.Windows.Forms.DateTimePicker();
            this.CategoryCombo = new System.Windows.Forms.ComboBox();
            this.NoteNameTextBox = new System.Windows.Forms.TextBox();
            this.NoteTextTextBox = new System.Windows.Forms.RichTextBox();
            this.GeneralTableLayout = new System.Windows.Forms.TableLayoutPanel();
            this.ButtonsTableLayout = new System.Windows.Forms.TableLayoutPanel();
            this.ButtonCancel = new System.Windows.Forms.Button();
            this.ButtonOK = new System.Windows.Forms.Button();
            this.GeneralTableLayout.SuspendLayout();
            this.ButtonsTableLayout.SuspendLayout();
            this.SuspendLayout();
            // 
            // TitleLabel
            // 
            this.TitleLabel.AutoSize = true;
            this.TitleLabel.Location = new System.Drawing.Point(12, 14);
            this.TitleLabel.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.TitleLabel.Name = "TitleLabel";
            this.TitleLabel.Size = new System.Drawing.Size(30, 13);
            this.TitleLabel.TabIndex = 0;
            this.TitleLabel.Text = "Title:";
            // 
            // CategoryLabel
            // 
            this.CategoryLabel.AutoSize = true;
            this.CategoryLabel.Location = new System.Drawing.Point(12, 43);
            this.CategoryLabel.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.CategoryLabel.Name = "CategoryLabel";
            this.CategoryLabel.Size = new System.Drawing.Size(52, 13);
            this.CategoryLabel.TabIndex = 1;
            this.CategoryLabel.Text = "Category:";
            // 
            // CreatedDateLabel
            // 
            this.CreatedDateLabel.AutoSize = true;
            this.CreatedDateLabel.Location = new System.Drawing.Point(12, 77);
            this.CreatedDateLabel.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.CreatedDateLabel.Name = "CreatedDateLabel";
            this.CreatedDateLabel.Size = new System.Drawing.Size(47, 13);
            this.CreatedDateLabel.TabIndex = 2;
            this.CreatedDateLabel.Text = "Created:";
            // 
            // ModifiedDateLabel
            // 
            this.ModifiedDateLabel.AutoSize = true;
            this.ModifiedDateLabel.Location = new System.Drawing.Point(170, 77);
            this.ModifiedDateLabel.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.ModifiedDateLabel.Name = "ModifiedDateLabel";
            this.ModifiedDateLabel.Size = new System.Drawing.Size(50, 13);
            this.ModifiedDateLabel.TabIndex = 3;
            this.ModifiedDateLabel.Text = "Modified:";
            // 
            // CreatedDate
            // 
            this.CreatedDate.Enabled = false;
            this.CreatedDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.CreatedDate.Location = new System.Drawing.Point(65, 71);
            this.CreatedDate.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.CreatedDate.Name = "CreatedDate";
            this.CreatedDate.Size = new System.Drawing.Size(99, 20);
            this.CreatedDate.TabIndex = 22;
            this.CreatedDate.Value = new System.DateTime(2018, 10, 27, 18, 5, 0, 0);
            // 
            // ModifiedDate
            // 
            this.ModifiedDate.Enabled = false;
            this.ModifiedDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.ModifiedDate.Location = new System.Drawing.Point(226, 71);
            this.ModifiedDate.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.ModifiedDate.Name = "ModifiedDate";
            this.ModifiedDate.Size = new System.Drawing.Size(99, 20);
            this.ModifiedDate.TabIndex = 23;
            this.ModifiedDate.Value = new System.DateTime(2018, 10, 27, 0, 0, 0, 0);
            // 
            // CategoryCombo
            // 
            this.CategoryCombo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CategoryCombo.FormattingEnabled = true;
            this.CategoryCombo.Location = new System.Drawing.Point(65, 40);
            this.CategoryCombo.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.CategoryCombo.Name = "CategoryCombo";
            this.CategoryCombo.Size = new System.Drawing.Size(121, 21);
            this.CategoryCombo.TabIndex = 24;
            // 
            // NoteNameTextBox
            // 
            this.NoteNameTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.NoteNameTextBox.Location = new System.Drawing.Point(65, 11);
            this.NoteNameTextBox.Name = "NoteNameTextBox";
            this.NoteNameTextBox.Size = new System.Drawing.Size(261, 20);
            this.NoteNameTextBox.TabIndex = 25;
            // 
            // NoteTextTextBox
            // 
            this.NoteTextTextBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.NoteTextTextBox.Location = new System.Drawing.Point(3, 3);
            this.NoteTextTextBox.MinimumSize = new System.Drawing.Size(303, 175);
            this.NoteTextTextBox.Name = "NoteTextTextBox";
            this.NoteTextTextBox.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.NoteTextTextBox.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.Vertical;
            this.NoteTextTextBox.Size = new System.Drawing.Size(305, 175);
            this.NoteTextTextBox.TabIndex = 26;
            this.NoteTextTextBox.Text = "";
            // 
            // GeneralTableLayout
            // 
            this.GeneralTableLayout.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.GeneralTableLayout.ColumnCount = 1;
            this.GeneralTableLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.GeneralTableLayout.Controls.Add(this.NoteTextTextBox, 0, 0);
            this.GeneralTableLayout.Controls.Add(this.ButtonsTableLayout, 0, 1);
            this.GeneralTableLayout.Location = new System.Drawing.Point(15, 99);
            this.GeneralTableLayout.Name = "GeneralTableLayout";
            this.GeneralTableLayout.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.GeneralTableLayout.RowCount = 2;
            this.GeneralTableLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 84.23237F));
            this.GeneralTableLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 15.76763F));
            this.GeneralTableLayout.Size = new System.Drawing.Size(311, 208);
            this.GeneralTableLayout.TabIndex = 29;
            // 
            // ButtonsTableLayout
            // 
            this.ButtonsTableLayout.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.ButtonsTableLayout.ColumnCount = 2;
            this.ButtonsTableLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.ButtonsTableLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.ButtonsTableLayout.Controls.Add(this.ButtonOK, 1, 0);
            this.ButtonsTableLayout.Controls.Add(this.ButtonCancel, 0, 0);
            this.ButtonsTableLayout.Location = new System.Drawing.Point(136, 178);
            this.ButtonsTableLayout.Name = "ButtonsTableLayout";
            this.ButtonsTableLayout.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.ButtonsTableLayout.RowCount = 1;
            this.ButtonsTableLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.ButtonsTableLayout.Size = new System.Drawing.Size(172, 27);
            this.ButtonsTableLayout.TabIndex = 27;
            // 
            // ButtonCancel
            // 
            this.ButtonCancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.ButtonCancel.Location = new System.Drawing.Point(89, 3);
            this.ButtonCancel.MinimumSize = new System.Drawing.Size(75, 23);
            this.ButtonCancel.Name = "ButtonCancel";
            this.ButtonCancel.Size = new System.Drawing.Size(80, 23);
            this.ButtonCancel.TabIndex = 1;
            this.ButtonCancel.Text = "Cancel";
            this.ButtonCancel.UseVisualStyleBackColor = true;
            this.ButtonCancel.Click += new System.EventHandler(this.ButtonCancel_Click);
            // 
            // ButtonOK
            // 
            this.ButtonOK.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.ButtonOK.Location = new System.Drawing.Point(3, 3);
            this.ButtonOK.MinimumSize = new System.Drawing.Size(75, 23);
            this.ButtonOK.Name = "ButtonOK";
            this.ButtonOK.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.ButtonOK.Size = new System.Drawing.Size(75, 23);
            this.ButtonOK.TabIndex = 0;
            this.ButtonOK.Text = "OK";
            this.ButtonOK.UseVisualStyleBackColor = true;
            this.ButtonOK.Click += new System.EventHandler(this.ButtonOK_Click);
            // 
            // AddOrEditNoteForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(338, 312);
            this.Controls.Add(this.GeneralTableLayout);
            this.Controls.Add(this.NoteNameTextBox);
            this.Controls.Add(this.CategoryCombo);
            this.Controls.Add(this.ModifiedDate);
            this.Controls.Add(this.CreatedDate);
            this.Controls.Add(this.ModifiedDateLabel);
            this.Controls.Add(this.CreatedDateLabel);
            this.Controls.Add(this.CategoryLabel);
            this.Controls.Add(this.TitleLabel);
            this.MaximumSize = new System.Drawing.Size(4096, 1716);
            this.MinimumSize = new System.Drawing.Size(354, 351);
            this.Name = "AddOrEditNoteForm";
            this.Text = "AddOrEditNoteForm";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.AddOrEditNoteForm_FormClosing);
            this.GeneralTableLayout.ResumeLayout(false);
            this.ButtonsTableLayout.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label TitleLabel;
        private System.Windows.Forms.Label CategoryLabel;
        private System.Windows.Forms.Label CreatedDateLabel;
        private System.Windows.Forms.Label ModifiedDateLabel;
        private System.Windows.Forms.DateTimePicker CreatedDate;
        private System.Windows.Forms.DateTimePicker ModifiedDate;
        private System.Windows.Forms.ComboBox CategoryCombo;
        private System.Windows.Forms.TextBox NoteNameTextBox;
        private System.Windows.Forms.RichTextBox NoteTextTextBox;
        private System.Windows.Forms.TableLayoutPanel GeneralTableLayout;
        private System.Windows.Forms.TableLayoutPanel ButtonsTableLayout;
        private System.Windows.Forms.Button ButtonOK;
        private System.Windows.Forms.Button ButtonCancel;
    }
}