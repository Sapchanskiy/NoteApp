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
                
                //использовать стандартное решение
                NotesListBox.SelectedItem = _project.ListNote
                    .Find(t => (t.NoteName == _project.CurrentNote.NoteName 
                    && t.CreationDate == _project.CurrentNote.CreationDate)); 
                UpdateNote();
            }

#if DEBUG
            DebugModeLabel.Visible = true;
#endif
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
        /// Нажатие кнопок клавиатуры в форме
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

            #if DEBUG
            if (e.KeyCode.ToString() == "F")
            {
                StressTest();
            }
            if (e.KeyCode.ToString() == "D")
            {
                DeleteStress();
            }
            #endif
        }

        



        /// <summary>
        /// Окно About через MenuItem
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        /// <summary>
        private void AboutMenuItem_Click(object sender, EventArgs e)
        {
            AboutForm aboutForm = new AboutForm();
            aboutForm.ShowDialog();
        }

        /// Добавление заметки через MenuItem
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void AddNoteMenuItem_Click(object sender, EventArgs e)
        {
            AddNote();
        }

        /// <summary>
        /// Редактирование заметки через MenuItem
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void EditNoteMenuItem_Click(object sender, EventArgs e)
        {
            EditNote();
        }

        /// <summary>
        /// Удаление заметки через MenuItem
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void DeleteNoteMenuItem_Click(object sender, EventArgs e)
        {
            DeleteNote();
        }
        /// <summary>
        /// Закрытие программы через MenuItem
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ExitMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
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
                if (NotesListBox.SelectedItem == null)
                {
                    MessageBox.Show("There's no note selected", "Nothing to edit", 
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                AddOrEditNoteForm addForm = new AddOrEditNoteForm();
                addForm.SetNote((Note)NotesListBox.SelectedItem);
                // При нажатии "редактировать" вызываем форму изменения или добавления заметки. 
                // Если форма не пустая, то перезаписываем текущую заметку.
                addForm.ShowDialog(this);
                if (addForm.DialogResult != DialogResult.OK)
                {
                    return;
                }
                if (addForm.NewNote != null)
                {
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

#if DEBUG
        /// <summary>
        /// Метод нагрузочного тестирования
        /// </summary>
        private void StressTest()
        {
            var stressTestNote = new Note
            {
                NoteName = "Stress Test Note",
                NoteText = "Stress Test Note Text",
                NoteCategory = NoteCategory.Other
            };
            for (int i = 0; i < 200; i++)
            {
                _project.ListNote.Add(stressTestNote);
            }
            UpdateListBox();
        }

        /// <summary>
        /// Удаление всех стрессовых заметок
        /// </summary>
        private void DeleteStress()
        {
            _project.ListNote.RemoveAll(t => t.NoteName == "Stress Test Note");
            UpdateListBox();
            SaveList();
        }
#endif

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
            if (note == null)
            {
                return;
            }
            NoteNameLabel.ForeColor = Color.Black;
            NoteCategoryLabel.Text = "Category: " + note.NoteCategory;
            NoteTextTextBox.Text = note.NoteText;
            NoteNameLabel.Text = note.NoteName;
            CreatedDate.Value = note.CreationDate;
            ModifiedDate.Value = note.ChangeDate;
            CreatedDate.Enabled = false;
            CreatedDate.Enabled = false;
            NoteTextTextBox.SelectionStart = 1;
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
            UpdateNote();
        }

    }
}
