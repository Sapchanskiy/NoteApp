namespace NoteAppUI
{
    partial class MainForm
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.label4 = new System.Windows.Forms.Label();
            this.DeleteNoteButton = new System.Windows.Forms.Button();
            this.NotesListBox = new System.Windows.Forms.ListBox();
            this.CategoryCombo = new System.Windows.Forms.ComboBox();
            this.ShowCatLabel = new System.Windows.Forms.Label();
            this.NoteNameLabel = new System.Windows.Forms.Label();
            this.NoteCategoryLabel = new System.Windows.Forms.Label();
            this.CreatedDateLabel = new System.Windows.Forms.Label();
            this.CreatedDate = new System.Windows.Forms.DateTimePicker();
            this.ModifiedDateLabel = new System.Windows.Forms.Label();
            this.ModifiedDate = new System.Windows.Forms.DateTimePicker();
            this.NoteTextTextBox = new System.Windows.Forms.RichTextBox();
            this.EditNoteButton = new System.Windows.Forms.Button();
            this.NewNoteButton = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.FileMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ExitMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.EditMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.AddNoteMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.EditNoteMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.DeleteNoteMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.HelpMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.AboutMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 56);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(49, 13);
            this.label4.TabIndex = 9;
            this.label4.Text = "Note List";
            // 
            // DeleteNoteButton
            // 
            this.DeleteNoteButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.DeleteNoteButton.Image = ((System.Drawing.Image)(resources.GetObject("DeleteNoteButton.Image")));
            this.DeleteNoteButton.Location = new System.Drawing.Point(101, 408);
            this.DeleteNoteButton.Name = "DeleteNoteButton";
            this.DeleteNoteButton.Size = new System.Drawing.Size(40, 40);
            this.DeleteNoteButton.TabIndex = 12;
            this.DeleteNoteButton.UseVisualStyleBackColor = true;
            this.DeleteNoteButton.Click += new System.EventHandler(this.DeleteNoteButton_Click);
            // 
            // NotesListBox
            // 
            this.NotesListBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.NotesListBox.FormattingEnabled = true;
            this.NotesListBox.Location = new System.Drawing.Point(9, 72);
            this.NotesListBox.Name = "NotesListBox";
            this.NotesListBox.Size = new System.Drawing.Size(247, 329);
            this.NotesListBox.TabIndex = 13;
            this.NotesListBox.Click += new System.EventHandler(this.NotesListBox_Click);
            // 
            // CategoryCombo
            // 
            this.CategoryCombo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CategoryCombo.FormattingEnabled = true;
            this.CategoryCombo.Items.AddRange(new object[] {
            "All",
            "Work",
            "Home",
            "Health",
            "Sport",
            "People",
            "Documents",
            "Finance",
            "Other"});
            this.CategoryCombo.Location = new System.Drawing.Point(96, 28);
            this.CategoryCombo.Name = "CategoryCombo";
            this.CategoryCombo.Size = new System.Drawing.Size(128, 21);
            this.CategoryCombo.TabIndex = 15;
            this.CategoryCombo.SelectedIndexChanged += new System.EventHandler(this.CategoryCombo_SelectedIndexChanged);
            // 
            // ShowCatLabel
            // 
            this.ShowCatLabel.AutoSize = true;
            this.ShowCatLabel.Location = new System.Drawing.Point(6, 31);
            this.ShowCatLabel.Name = "ShowCatLabel";
            this.ShowCatLabel.Size = new System.Drawing.Size(82, 13);
            this.ShowCatLabel.TabIndex = 16;
            this.ShowCatLabel.Text = "Show Category:";
            // 
            // NoteNameLabel
            // 
            this.NoteNameLabel.AutoSize = true;
            this.NoteNameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.NoteNameLabel.Location = new System.Drawing.Point(256, 31);
            this.NoteNameLabel.Name = "NoteNameLabel";
            this.NoteNameLabel.Size = new System.Drawing.Size(0, 31);
            this.NoteNameLabel.TabIndex = 18;
            // 
            // NoteCategoryLabel
            // 
            this.NoteCategoryLabel.AutoSize = true;
            this.NoteCategoryLabel.Location = new System.Drawing.Point(259, 72);
            this.NoteCategoryLabel.Name = "NoteCategoryLabel";
            this.NoteCategoryLabel.Size = new System.Drawing.Size(52, 13);
            this.NoteCategoryLabel.TabIndex = 19;
            this.NoteCategoryLabel.Text = "Category:";
            // 
            // CreatedDateLabel
            // 
            this.CreatedDateLabel.AutoSize = true;
            this.CreatedDateLabel.Location = new System.Drawing.Point(259, 98);
            this.CreatedDateLabel.Name = "CreatedDateLabel";
            this.CreatedDateLabel.Size = new System.Drawing.Size(47, 13);
            this.CreatedDateLabel.TabIndex = 20;
            this.CreatedDateLabel.Text = "Created:";
            // 
            // CreatedDate
            // 
            this.CreatedDate.Checked = false;
            this.CreatedDate.Cursor = System.Windows.Forms.Cursors.Default;
            this.CreatedDate.Enabled = false;
            this.CreatedDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.CreatedDate.Location = new System.Drawing.Point(312, 92);
            this.CreatedDate.Name = "CreatedDate";
            this.CreatedDate.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.CreatedDate.Size = new System.Drawing.Size(99, 20);
            this.CreatedDate.TabIndex = 21;
            this.CreatedDate.Value = new System.DateTime(2018, 10, 25, 20, 54, 39, 0);
            // 
            // ModifiedDateLabel
            // 
            this.ModifiedDateLabel.AutoSize = true;
            this.ModifiedDateLabel.Location = new System.Drawing.Point(428, 98);
            this.ModifiedDateLabel.Name = "ModifiedDateLabel";
            this.ModifiedDateLabel.Size = new System.Drawing.Size(50, 13);
            this.ModifiedDateLabel.TabIndex = 23;
            this.ModifiedDateLabel.Text = "Modified:";
            // 
            // ModifiedDate
            // 
            this.ModifiedDate.Enabled = false;
            this.ModifiedDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.ModifiedDate.Location = new System.Drawing.Point(484, 92);
            this.ModifiedDate.Name = "ModifiedDate";
            this.ModifiedDate.Size = new System.Drawing.Size(99, 20);
            this.ModifiedDate.TabIndex = 24;
            this.ModifiedDate.Value = new System.DateTime(2018, 10, 25, 20, 54, 39, 0);
            // 
            // NoteTextTextBox
            // 
            this.NoteTextTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.NoteTextTextBox.Location = new System.Drawing.Point(262, 118);
            this.NoteTextTextBox.Name = "NoteTextTextBox";
            this.NoteTextTextBox.ReadOnly = true;
            this.NoteTextTextBox.Size = new System.Drawing.Size(432, 326);
            this.NoteTextTextBox.TabIndex = 25;
            this.NoteTextTextBox.Text = "";
            // 
            // EditNoteButton
            // 
            this.EditNoteButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.EditNoteButton.Image = ((System.Drawing.Image)(resources.GetObject("EditNoteButton.Image")));
            this.EditNoteButton.Location = new System.Drawing.Point(55, 408);
            this.EditNoteButton.Name = "EditNoteButton";
            this.EditNoteButton.Size = new System.Drawing.Size(40, 40);
            this.EditNoteButton.TabIndex = 17;
            this.EditNoteButton.UseVisualStyleBackColor = true;
            this.EditNoteButton.Click += new System.EventHandler(this.EditNoteButton_Click);
            // 
            // NewNoteButton
            // 
            this.NewNoteButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.NewNoteButton.Image = ((System.Drawing.Image)(resources.GetObject("NewNoteButton.Image")));
            this.NewNoteButton.Location = new System.Drawing.Point(9, 408);
            this.NewNoteButton.Name = "NewNoteButton";
            this.NewNoteButton.Size = new System.Drawing.Size(40, 40);
            this.NewNoteButton.TabIndex = 5;
            this.NewNoteButton.UseVisualStyleBackColor = true;
            this.NewNoteButton.Click += new System.EventHandler(this.NewNoteButton_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.FileMenuItem,
            this.EditMenuItem,
            this.HelpMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(694, 24);
            this.menuStrip1.TabIndex = 26;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // FileMenuItem
            // 
            this.FileMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ExitMenuItem});
            this.FileMenuItem.Name = "FileMenuItem";
            this.FileMenuItem.Size = new System.Drawing.Size(37, 20);
            this.FileMenuItem.Text = "File";
            // 
            // ExitMenuItem
            // 
            this.ExitMenuItem.Name = "ExitMenuItem";
            this.ExitMenuItem.Size = new System.Drawing.Size(180, 22);
            this.ExitMenuItem.Text = "Exit";
            this.ExitMenuItem.Click += new System.EventHandler(this.ExitMenuItem_Click);
            // 
            // EditMenuItem
            // 
            this.EditMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.AddNoteMenuItem,
            this.EditNoteMenuItem,
            this.DeleteNoteMenuItem});
            this.EditMenuItem.Name = "EditMenuItem";
            this.EditMenuItem.Size = new System.Drawing.Size(39, 20);
            this.EditMenuItem.Text = "Edit";
            // 
            // AddNoteMenuItem
            // 
            this.AddNoteMenuItem.Name = "AddNoteMenuItem";
            this.AddNoteMenuItem.Size = new System.Drawing.Size(180, 22);
            this.AddNoteMenuItem.Text = "Add Note";
            this.AddNoteMenuItem.Click += new System.EventHandler(this.AddNoteMenuItem_Click);
            // 
            // EditNoteMenuItem
            // 
            this.EditNoteMenuItem.Name = "EditNoteMenuItem";
            this.EditNoteMenuItem.Size = new System.Drawing.Size(180, 22);
            this.EditNoteMenuItem.Text = "Edit Note";
            this.EditNoteMenuItem.Click += new System.EventHandler(this.EditNoteMenuItem_Click);
            // 
            // DeleteNoteMenuItem
            // 
            this.DeleteNoteMenuItem.Name = "DeleteNoteMenuItem";
            this.DeleteNoteMenuItem.Size = new System.Drawing.Size(180, 22);
            this.DeleteNoteMenuItem.Text = "Delete Note";
            this.DeleteNoteMenuItem.Click += new System.EventHandler(this.DeleteNoteMenuItem_Click);
            // 
            // HelpMenuItem
            // 
            this.HelpMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.AboutMenuItem});
            this.HelpMenuItem.Name = "HelpMenuItem";
            this.HelpMenuItem.Size = new System.Drawing.Size(44, 20);
            this.HelpMenuItem.Text = "Help";
            // 
            // AboutMenuItem
            // 
            this.AboutMenuItem.Name = "AboutMenuItem";
            this.AboutMenuItem.Size = new System.Drawing.Size(180, 22);
            this.AboutMenuItem.Text = "About";
            this.AboutMenuItem.Click += new System.EventHandler(this.AboutMenuItem_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(694, 450);
            this.Controls.Add(this.NoteTextTextBox);
            this.Controls.Add(this.ModifiedDate);
            this.Controls.Add(this.ModifiedDateLabel);
            this.Controls.Add(this.CreatedDate);
            this.Controls.Add(this.CreatedDateLabel);
            this.Controls.Add(this.NoteCategoryLabel);
            this.Controls.Add(this.NoteNameLabel);
            this.Controls.Add(this.EditNoteButton);
            this.Controls.Add(this.ShowCatLabel);
            this.Controls.Add(this.CategoryCombo);
            this.Controls.Add(this.NotesListBox);
            this.Controls.Add(this.DeleteNoteButton);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.NewNoteButton);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximumSize = new System.Drawing.Size(4096, 1716);
            this.MinimumSize = new System.Drawing.Size(640, 480);
            this.Name = "MainForm";
            this.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.Text = "NoteApp";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainForm_FormClosing);
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.MainForm_KeyDown);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button NewNoteButton;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button DeleteNoteButton;
        private System.Windows.Forms.ListBox NotesListBox;
        private System.Windows.Forms.ComboBox CategoryCombo;
        private System.Windows.Forms.Label ShowCatLabel;
        private System.Windows.Forms.Button EditNoteButton;
        private System.Windows.Forms.Label NoteNameLabel;
        private System.Windows.Forms.Label NoteCategoryLabel;
        private System.Windows.Forms.Label CreatedDateLabel;
        private System.Windows.Forms.DateTimePicker CreatedDate;
        private System.Windows.Forms.Label ModifiedDateLabel;
        private System.Windows.Forms.DateTimePicker ModifiedDate;
        private System.Windows.Forms.RichTextBox NoteTextTextBox;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem FileMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ExitMenuItem;
        private System.Windows.Forms.ToolStripMenuItem EditMenuItem;
        private System.Windows.Forms.ToolStripMenuItem AddNoteMenuItem;
        private System.Windows.Forms.ToolStripMenuItem EditNoteMenuItem;
        private System.Windows.Forms.ToolStripMenuItem DeleteNoteMenuItem;
        private System.Windows.Forms.ToolStripMenuItem HelpMenuItem;
        private System.Windows.Forms.ToolStripMenuItem AboutMenuItem;
    }
}

