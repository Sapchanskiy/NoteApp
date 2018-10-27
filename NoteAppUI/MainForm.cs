using System;
using System.Drawing;
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

        #endregion

        #region Constructors

        /// <summary>
        /// Основная форма NoteApp
        /// </summary>
        public MainForm()
        {
            InitializeComponent();
            CategoryCombo.DataSource = Enum.GetValues(typeof(NoteCategory));
            InitializeNoteView();
            _project = ProjectManager.Load();
            foreach (var note in _project.ListNote)
            {
                NotesListBox.Items.Add(note.NoteName);
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
        /// Редактировать заметку
        /// </summary>
        private void EditNote()
        {
            try
            {
                var selectedNoteIndex = NotesListBox.SelectedIndex;
                AddOrEditNoteForm addForm = new AddOrEditNoteForm(_project.ListNote[selectedNoteIndex]);
                /// <summary>
                /// При нажатии "редактировать" вызываем форму изменения или добавления заметки. Если форма не пустая, то перезаписываем текущую заметку.
                /// </summary>
                addForm.ShowDialog(this);
                if (addForm.NewNote != null)
                {
                    _project.ListNote.RemoveAt(selectedNoteIndex);//удаляем из списка элемент с указанным индексом в project
                    _project.ListNote.Insert(selectedNoteIndex, addForm.NewNote);//вставляем в список новую заметку по указанному индексу в project
                    NotesListBox.Items.RemoveAt(selectedNoteIndex);//удаляем заметку в форме
                    NotesListBox.Items.Insert(selectedNoteIndex, addForm.NewNote.NoteName); //вствляем обновленную заметку по указанному индексу
                    NotesListBox.SelectedIndex = selectedNoteIndex; //выделяем обновленную заметку
                    UpdateNote();//выполняем обновление списка
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
            if (NotesListBox.Items.Count == 1)
            {
                _project.ListNote.RemoveAt(NotesListBox.SelectedIndex);
                NotesListBox.Items.RemoveAt(NotesListBox.SelectedIndex);
                InitializeNoteView();
            }
            else
            {
                if ((NotesListBox.Items.Count > 0) && (NotesListBox.SelectedIndex >= 0))
                {
                    var selectedNoteIndex = NotesListBox.SelectedIndex;
                    _project.ListNote.RemoveAt(selectedNoteIndex);
                    NotesListBox.Items.RemoveAt(selectedNoteIndex);
                    if (NotesListBox.Items.Count > selectedNoteIndex)
                    {
                        NotesListBox.SelectedIndex = selectedNoteIndex;
                    }
                    else
                    {
                        NotesListBox.SelectedIndex = selectedNoteIndex - 1;
                    }

                    UpdateNote();
                    SaveList();
                }
                else
                {
                    MessageBox.Show("There's no note selected", "Nothing to delete", MessageBoxButtons.OK,
                        MessageBoxIcon.Error);
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
            if (addForm.NewNote != null)
            {
                _project.ListNote.Add(addForm.NewNote);
                NotesListBox.Items.Add(addForm.NewNote.NoteName);
                SaveList();
            }
        }

        /// <summary>
        /// Метод, обновляющий отображение заметки
        /// </summary>
        private void UpdateNote()
        {
            NoteNameLabel.ForeColor = Color.Black;
            NoteCategoryLabel.Text = "Category: " + _project.ListNote[NotesListBox.SelectedIndex].NoteCategory;
            NoteTextTextBox.Text = _project.ListNote[NotesListBox.SelectedIndex].NoteText;
            NoteNameLabel.Text = _project.ListNote[NotesListBox.SelectedIndex].NoteName;
            CreatedDate.Value = _project.ListNote[NotesListBox.SelectedIndex].CreationDate;
            ModifiedDate.Value = _project.ListNote[NotesListBox.SelectedIndex].ChangeDate;
            CreatedDate.Enabled = false;
            CreatedDate.Enabled = false;
        }

        /// <summary>
        /// Метод, осуществляющий сохранение
        /// </summary>
        private void SaveList()
        {
            try
            {
                ProjectManager.Save(_project);
                MessageBox.Show("Saved Correctly", "Success", MessageBoxButtons.OK);
            }
            catch (ArgumentException)
            {
                MessageBox.Show("No notes to save", "Save Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        /// <summary>
        /// Инициализация отображения заметки стандартными значениями
        /// </summary>
        private void InitializeNoteView()
        {
            CreatedDate.Value = DateTime.Now;
            ModifiedDate.Value = DateTime.Now;
            NoteNameLabel.ForeColor = Color.Gray;
            NoteNameLabel.Text = "<<Name of the Note>>";
            NoteTextTextBox.Text = string.Empty;
        }

        #endregion

        private void ShowCatLabel_Click(object sender, EventArgs e)
        {

        }
    }
}
