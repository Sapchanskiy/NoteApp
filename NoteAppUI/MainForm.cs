using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Windows.Forms;
using NoteApp;

namespace NoteAppUI
{
    /// <summary>
    /// Класс тестовой формы
    /// </summary>
    public partial class MainForm : Form
    {
        #region Private Fields

        private Project _project;

        /// <summary>
        /// Путь к файлу с данными
        /// </summary>
        private readonly string _notesName = Path.Combine(Environment.ExpandEnvironmentVariables("%userprofile%"), "Notes.notes");

        #endregion

        #region Constructors

        /// <summary>
        /// Основная форма NoteApp
        /// </summary>
        public MainForm()
        {
            InitializeComponent();
            
            try
            {
                _project = ProjectManager.Load(_notesName);
                _project.ListNote = _project.OrderListByCreationDate();
            }
            catch (FileNotFoundException)
            {
                MessageBox.Show(".notes file was deleted or moved.", "File not found", 
                    MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

                _project = new Project();
            }
            CategoryCombo.SelectedIndex = 0;
            if (_project.CurrentNote != null)
            {
                int index = 0;
                for (int i = 0; i < _project.ListNote.Count; i++)
                {
                    if (_project.ListNote[i].NoteName == _project.CurrentNote.NoteName)
                    {
                        index = i;
                        break;
                    }
                }

                NotesListBox.SelectedIndex = index;
                UpdateNote();
            }
        }

        

        #endregion

        #region Event Handlers

        /// <summary>
        /// Создание новой заметки
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void NewNoteButton_Click(object sender, EventArgs e)
        {
            AddNote();
        }

        
        /// <summary>
        /// Редактирование заметки
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void EditNoteButton_Click(object sender, EventArgs e)
        {
            EditNote();
        }

        /// <summary>
        /// Выбор отображаемой заметки
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void NotesListBox_Click(object sender, EventArgs e)
        {
            if ((NotesListBox.Items.Count != 0) && (NotesListBox.SelectedIndex >= 0))
            {
                UpdateNote();
            }
        }

        /// <summary>
        /// Удаление заметки
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void DeleteNoteButton_Click(object sender, EventArgs e)
        {
            DeleteNote();
        }

        

        /// <summary>
        /// Закрытие программы через ToolStrip
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ExitToolStripButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        
        
        /// <summary>
        /// Добавление заметки через ToolStrip
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void AddNoteToolStripButton_Click(object sender, EventArgs e)
        {
            AddNote();
        }

        /// <summary>
        /// Редактирование заметки через ToolStrip
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void EditNoteToolStripButton_Click(object sender, EventArgs e)
        {
            EditNote();
        }

        

        /// <summary>
        /// Окно About через ToolStrip
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void AboutToolStripButton_Click(object sender, EventArgs e)
        {
            var aboutForm = new AboutForm();

            aboutForm.ShowDialog(this);
        }

        /// <summary>
        /// Закрытие программы
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (NotesListBox.SelectedItem != null)
            {
                _project.CurrentNote = (Note) NotesListBox.SelectedItem;
            }
            SaveList();
        }

        /// <summary>
        /// Загрузка формы
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void MainForm_Load(object sender, EventArgs e)
        {
            KeyPreview = true;
        }

        /// <summary>
        /// Нажатие F1
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void MainForm_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode.ToString() == "F1")
            {
                var aboutForm = new AboutForm();
                aboutForm.ShowDialog();
            }
        }

        /// <summary>
        /// Удаление заметки через ToolStrip
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void DeleteNoteToolStripButton_Click(object sender, EventArgs e)
        {
            DeleteNote();
        }

        #endregion

        #region Private Methods

        /// <summary>
        /// Обновление ListBox
        /// </summary>
        private void UpdateListBox()
        {
            NotesListBox.DataSource = null;
            if (CategoryCombo.SelectedIndex <= 0)
            {
                NotesListBox.DataSource = _project.OrderListByCreationDate();
            }
            else if (CategoryCombo.SelectedIndex > 0)
            {
                NotesListBox.DataSource = _project.OrderListByCreationDate((NoteCategory)CategoryCombo.SelectedIndex);
            }
            NotesListBox.DisplayMember = "NoteName";
        }

        /// <summary>
        /// Редактировать заметку
        /// </summary>
        private void EditNote()
        {
            try
            {
                var selectedNoteIndex = NotesListBox.SelectedIndex;
                AddOrEditNoteForm addForm = new AddOrEditNoteForm();
                addForm.SetNote(_project.ListNote[selectedNoteIndex]);
                // При нажатии "редактировать" вызываем форму изменения или добавления заметки. Если форма не пустая, то перезаписываем текущую заметку.
                addForm.ShowDialog(this);
                if (addForm.DialogResult != DialogResult.OK)
                {
                    return;
                }
                if (addForm.NewNote != null)
                {
                    _project.ListNote.RemoveAt(selectedNoteIndex);//удаляем из списка элемент с указанным индексом в project
                    _project.ListNote.Insert(selectedNoteIndex, addForm.NewNote);//вставляем в список новую заметку по указанному индексу в project
                    NotesListBox.SelectedItem = addForm.NewNote;
                    UpdateNote();//выполняем обновление заметки
                    UpdateListBox();
                    SaveList();
                }
            }
            catch (ArgumentOutOfRangeException)
            {
                MessageBox.Show("There's no note selected", "Nothing to edit", MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
            
        }

        /// <summary>
        /// Удалить заметку
        /// </summary>
        private void DeleteNote()
        {
            if (NotesListBox.SelectedItem != null)
            {
                if (MessageBox.Show($"Do you really want to delete this note?", "Query",
                        MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
                {
                    _project.ListNote.Remove((Note)NotesListBox.SelectedItem);
                    UpdateListBox();
                    UpdateNote();
                }
            }
        }
        
        /// <summary>
        /// Добавить заметку
        /// </summary>
        private void AddNote()
        {
            AddOrEditNoteForm addForm = new AddOrEditNoteForm();
            addForm.ShowDialog(this);
            if (addForm.DialogResult != DialogResult.OK)
            {
                return;
            }
            if (addForm.NewNote != null)
            {
                _project.ListNote.Add(addForm.NewNote);
                UpdateListBox();
                SaveList();
            }
        }

        /// <summary>
        /// Метод, обновляющий отображение заметки
        /// </summary>
        private void UpdateNote()
        {
            var note = (Note) NotesListBox.SelectedItem;
            NoteNameLabel.ForeColor = Color.Black;
            NoteCategoryLabel.Text = "Category: " + note.NoteCategory;
            NoteTextTextBox.Text = note.NoteText;
            NoteNameLabel.Text = note.NoteName;
            CreatedDate.Value = note.CreationDate;
            ModifiedDate.Value = note.ChangeDate;
            CreatedDate.Enabled = false;
            CreatedDate.Enabled = false;
        }

        /// <summary>
        /// Метод, осуществляющий сохранение
        /// </summary>
        private void SaveList()
        {
            ProjectManager.Save(_project, _notesName);
        }

        #endregion

        private void CategoryCombo_SelectedIndexChanged(object sender, EventArgs e)
        {
            UpdateListBox();
            
        }
    }
}
