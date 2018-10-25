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
            this.NewNoteButton = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.DeleteNoteButton = new System.Windows.Forms.Button();
            this.NotesListBox = new System.Windows.Forms.ListBox();
            this.UserBar = new System.Windows.Forms.ToolStrip();
            this.FileToolStripDropDown = new System.Windows.Forms.ToolStripDropDownButton();
            this.ExitToolStripButton = new System.Windows.Forms.ToolStripMenuItem();
            this.EditToolStripDropDown = new System.Windows.Forms.ToolStripDropDownButton();
            this.AddNoteToolStripButton = new System.Windows.Forms.ToolStripMenuItem();
            this.EditNoteToolStripButton = new System.Windows.Forms.ToolStripMenuItem();
            this.DeleteNoteToolStripButton = new System.Windows.Forms.ToolStripMenuItem();
            this.HelpToolStripDropDown = new System.Windows.Forms.ToolStripDropDownButton();
            this.AboutToolStripButton = new System.Windows.Forms.ToolStripMenuItem();
            this.CategoryCombo = new System.Windows.Forms.ComboBox();
            this.ShowCatLabel = new System.Windows.Forms.Label();
            this.EditNoteButton = new System.Windows.Forms.Button();
            this.NoteNameLabel = new System.Windows.Forms.Label();
            this.NoteCategoryLabel = new System.Windows.Forms.Label();
            this.CreatedDateLabel = new System.Windows.Forms.Label();
            this.CreatedDate = new System.Windows.Forms.DateTimePicker();
            this.ModifiedDateLabel = new System.Windows.Forms.Label();
            this.ModifiedDate = new System.Windows.Forms.DateTimePicker();
            this.NoteTextTextBox = new System.Windows.Forms.RichTextBox();
            this.UserBar.SuspendLayout();
            this.SuspendLayout();
            // 
            // NewNoteButton
            // 
            this.NewNoteButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.NewNoteButton.Location = new System.Drawing.Point(9, 415);
            this.NewNoteButton.Name = "NewNoteButton";
            this.NewNoteButton.Size = new System.Drawing.Size(75, 23);
            this.NewNoteButton.TabIndex = 5;
            this.NewNoteButton.Text = "Create Note";
            this.NewNoteButton.UseVisualStyleBackColor = true;
            this.NewNoteButton.Click += new System.EventHandler(this.NewNoteButton_Click);
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
            this.DeleteNoteButton.Location = new System.Drawing.Point(171, 415);
            this.DeleteNoteButton.Name = "DeleteNoteButton";
            this.DeleteNoteButton.Size = new System.Drawing.Size(75, 23);
            this.DeleteNoteButton.TabIndex = 12;
            this.DeleteNoteButton.Text = "Delete Note";
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
            this.NotesListBox.Size = new System.Drawing.Size(237, 329);
            this.NotesListBox.TabIndex = 13;
            this.NotesListBox.Click += new System.EventHandler(this.NotesListBox_Click);
            // 
            // UserBar
            // 
            this.UserBar.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.UserBar.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.FileToolStripDropDown,
            this.EditToolStripDropDown,
            this.HelpToolStripDropDown});
            this.UserBar.Location = new System.Drawing.Point(0, 0);
            this.UserBar.Name = "UserBar";
            this.UserBar.Size = new System.Drawing.Size(694, 25);
            this.UserBar.TabIndex = 14;
            this.UserBar.Text = "UserBar";
            // 
            // FileToolStripDropDown
            // 
            this.FileToolStripDropDown.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.FileToolStripDropDown.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ExitToolStripButton});
            this.FileToolStripDropDown.Image = ((System.Drawing.Image)(resources.GetObject("FileToolStripDropDown.Image")));
            this.FileToolStripDropDown.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.FileToolStripDropDown.Name = "FileToolStripDropDown";
            this.FileToolStripDropDown.Size = new System.Drawing.Size(38, 22);
            this.FileToolStripDropDown.Text = "File";
            // 
            // ExitToolStripButton
            // 
            this.ExitToolStripButton.Name = "ExitToolStripButton";
            this.ExitToolStripButton.Size = new System.Drawing.Size(92, 22);
            this.ExitToolStripButton.Text = "Exit";
            this.ExitToolStripButton.Click += new System.EventHandler(this.ExitToolStripButton_Click);
            // 
            // EditToolStripDropDown
            // 
            this.EditToolStripDropDown.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.EditToolStripDropDown.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.AddNoteToolStripButton,
            this.EditNoteToolStripButton,
            this.DeleteNoteToolStripButton});
            this.EditToolStripDropDown.Image = ((System.Drawing.Image)(resources.GetObject("EditToolStripDropDown.Image")));
            this.EditToolStripDropDown.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.EditToolStripDropDown.Name = "EditToolStripDropDown";
            this.EditToolStripDropDown.Size = new System.Drawing.Size(40, 22);
            this.EditToolStripDropDown.Text = "Edit";
            // 
            // AddNoteToolStripButton
            // 
            this.AddNoteToolStripButton.Name = "AddNoteToolStripButton";
            this.AddNoteToolStripButton.Size = new System.Drawing.Size(136, 22);
            this.AddNoteToolStripButton.Text = "Add Note";
            this.AddNoteToolStripButton.Click += new System.EventHandler(this.AddNoteToolStripButton_Click);
            // 
            // EditNoteToolStripButton
            // 
            this.EditNoteToolStripButton.Name = "EditNoteToolStripButton";
            this.EditNoteToolStripButton.Size = new System.Drawing.Size(136, 22);
            this.EditNoteToolStripButton.Text = "Edit Note";
            this.EditNoteToolStripButton.Click += new System.EventHandler(this.EditNoteToolStripButton_Click);
            // 
            // DeleteNoteToolStripButton
            // 
            this.DeleteNoteToolStripButton.Name = "DeleteNoteToolStripButton";
            this.DeleteNoteToolStripButton.Size = new System.Drawing.Size(180, 22);
            this.DeleteNoteToolStripButton.Text = "Delete Note";
            this.DeleteNoteToolStripButton.Click += new System.EventHandler(this.DeleteNoteToolStripButton_Click);
            // 
            // HelpToolStripDropDown
            // 
            this.HelpToolStripDropDown.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.HelpToolStripDropDown.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.AboutToolStripButton});
            this.HelpToolStripDropDown.Image = ((System.Drawing.Image)(resources.GetObject("HelpToolStripDropDown.Image")));
            this.HelpToolStripDropDown.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.HelpToolStripDropDown.Name = "HelpToolStripDropDown";
            this.HelpToolStripDropDown.Size = new System.Drawing.Size(45, 22);
            this.HelpToolStripDropDown.Text = "Help";
            // 
            // AboutToolStripButton
            // 
            this.AboutToolStripButton.Name = "AboutToolStripButton";
            this.AboutToolStripButton.Size = new System.Drawing.Size(107, 22);
            this.AboutToolStripButton.Text = "About";
            this.AboutToolStripButton.Click += new System.EventHandler(this.AboutToolStripButton_Click);
            // 
            // CategoryCombo
            // 
            this.CategoryCombo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CategoryCombo.FormattingEnabled = true;
            this.CategoryCombo.Location = new System.Drawing.Point(94, 31);
            this.CategoryCombo.Name = "CategoryCombo";
            this.CategoryCombo.Size = new System.Drawing.Size(128, 21);
            this.CategoryCombo.TabIndex = 15;
            // 
            // ShowCatLabel
            // 
            this.ShowCatLabel.AutoSize = true;
            this.ShowCatLabel.Location = new System.Drawing.Point(6, 34);
            this.ShowCatLabel.Name = "ShowCatLabel";
            this.ShowCatLabel.Size = new System.Drawing.Size(82, 13);
            this.ShowCatLabel.TabIndex = 16;
            this.ShowCatLabel.Text = "Show Category:";
            // 
            // EditNoteButton
            // 
            this.EditNoteButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.EditNoteButton.Location = new System.Drawing.Point(90, 415);
            this.EditNoteButton.Name = "EditNoteButton";
            this.EditNoteButton.Size = new System.Drawing.Size(75, 23);
            this.EditNoteButton.TabIndex = 17;
            this.EditNoteButton.Text = "Edit";
            this.EditNoteButton.UseVisualStyleBackColor = true;
            this.EditNoteButton.Click += new System.EventHandler(this.EditNoteButton_Click);
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
            this.NoteTextTextBox.Size = new System.Drawing.Size(426, 320);
            this.NoteTextTextBox.TabIndex = 25;
            this.NoteTextTextBox.Text = "";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(694, 444);
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
            this.Controls.Add(this.UserBar);
            this.Controls.Add(this.NotesListBox);
            this.Controls.Add(this.DeleteNoteButton);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.NewNoteButton);
            this.MaximumSize = new System.Drawing.Size(4096, 1716);
            this.MinimumSize = new System.Drawing.Size(640, 480);
            this.Name = "MainForm";
            this.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.Text = "TestForm";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainForm_FormClosing);
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.MainForm_KeyDown);
            this.UserBar.ResumeLayout(false);
            this.UserBar.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button NewNoteButton;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button DeleteNoteButton;
        private System.Windows.Forms.ListBox NotesListBox;
        private System.Windows.Forms.ToolStrip UserBar;
        private System.Windows.Forms.ToolStripDropDownButton FileToolStripDropDown;
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
        private System.Windows.Forms.ToolStripMenuItem ExitToolStripButton;
        private System.Windows.Forms.ToolStripDropDownButton EditToolStripDropDown;
        private System.Windows.Forms.ToolStripMenuItem AddNoteToolStripButton;
        private System.Windows.Forms.ToolStripMenuItem EditNoteToolStripButton;
        private System.Windows.Forms.ToolStripMenuItem DeleteNoteToolStripButton;
        private System.Windows.Forms.ToolStripDropDownButton HelpToolStripDropDown;
        private System.Windows.Forms.ToolStripMenuItem AboutToolStripButton;
    }
}

