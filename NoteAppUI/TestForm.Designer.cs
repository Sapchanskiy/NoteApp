namespace NoteAppUI
{
    partial class TestForm
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
            this.NoteListView = new System.Windows.Forms.DataGridView();
            this.Category = new System.Windows.Forms.ComboBox();
            this.NoteName = new System.Windows.Forms.TextBox();
            this.NoteText = new System.Windows.Forms.TextBox();
            this.NewNote = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.NoteType = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.SaveNotesButton = new System.Windows.Forms.Button();
            this.LoadNotesButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.NoteListView)).BeginInit();
            this.SuspendLayout();
            // 
            // NoteListView
            // 
            this.NoteListView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.NoteListView.Location = new System.Drawing.Point(201, 28);
            this.NoteListView.Name = "NoteListView";
            this.NoteListView.Size = new System.Drawing.Size(560, 284);
            this.NoteListView.TabIndex = 1;
            this.NoteListView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.NoteListView_CellContentClick);
            // 
            // Category
            // 
            this.Category.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.Category.FormattingEnabled = true;
            this.Category.Location = new System.Drawing.Point(23, 28);
            this.Category.Name = "Category";
            this.Category.Size = new System.Drawing.Size(121, 21);
            this.Category.TabIndex = 2;
            // 
            // NoteName
            // 
            this.NoteName.Location = new System.Drawing.Point(9, 76);
            this.NoteName.Name = "NoteName";
            this.NoteName.Size = new System.Drawing.Size(172, 20);
            this.NoteName.TabIndex = 3;
            // 
            // NoteText
            // 
            this.NoteText.Location = new System.Drawing.Point(9, 118);
            this.NoteText.Name = "NoteText";
            this.NoteText.Size = new System.Drawing.Size(172, 20);
            this.NoteText.TabIndex = 4;
            // 
            // NewNote
            // 
            this.NewNote.Location = new System.Drawing.Point(9, 219);
            this.NewNote.Name = "NewNote";
            this.NewNote.Size = new System.Drawing.Size(75, 23);
            this.NewNote.TabIndex = 5;
            this.NewNote.Text = "Create Note";
            this.NewNote.UseVisualStyleBackColor = true;
            this.NewNote.Click += new System.EventHandler(this.NewNote_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(59, 60);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(61, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "Note Name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(67, 102);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(54, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "Note Text";
            // 
            // NoteType
            // 
            this.NoteType.AutoSize = true;
            this.NoteType.Location = new System.Drawing.Point(59, 12);
            this.NoteType.Name = "NoteType";
            this.NoteType.Size = new System.Drawing.Size(53, 13);
            this.NoteType.TabIndex = 8;
            this.NoteType.Text = "Note type";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(198, 9);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(49, 13);
            this.label4.TabIndex = 9;
            this.label4.Text = "Note List";
            // 
            // SaveNotesButton
            // 
            this.SaveNotesButton.Location = new System.Drawing.Point(9, 289);
            this.SaveNotesButton.Name = "SaveNotesButton";
            this.SaveNotesButton.Size = new System.Drawing.Size(75, 23);
            this.SaveNotesButton.TabIndex = 10;
            this.SaveNotesButton.Text = "Save Notes";
            this.SaveNotesButton.UseVisualStyleBackColor = true;
            this.SaveNotesButton.Click += new System.EventHandler(this.SaveNotesButton_Click);
            // 
            // LoadNotesButton
            // 
            this.LoadNotesButton.Location = new System.Drawing.Point(106, 289);
            this.LoadNotesButton.Name = "LoadNotesButton";
            this.LoadNotesButton.Size = new System.Drawing.Size(75, 23);
            this.LoadNotesButton.TabIndex = 11;
            this.LoadNotesButton.Text = "Load Notes";
            this.LoadNotesButton.UseVisualStyleBackColor = true;
            this.LoadNotesButton.Click += new System.EventHandler(this.LoadNotesButton_Click);
            // 
            // TestForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.LoadNotesButton);
            this.Controls.Add(this.SaveNotesButton);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.NoteType);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.NewNote);
            this.Controls.Add(this.NoteText);
            this.Controls.Add(this.NoteName);
            this.Controls.Add(this.Category);
            this.Controls.Add(this.NoteListView);
            this.Name = "TestForm";
            this.Text = "TestForm";
            this.Load += new System.EventHandler(this.TestForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.NoteListView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView NoteListView;
        private System.Windows.Forms.ComboBox Category;
        private System.Windows.Forms.TextBox NoteName;
        private System.Windows.Forms.TextBox NoteText;
        private System.Windows.Forms.Button NewNote;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label NoteType;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button SaveNotesButton;
        private System.Windows.Forms.Button LoadNotesButton;
    }
}

