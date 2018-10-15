using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using NoteApp;

namespace NoteAppUI
{
   /// <summary>
   /// Класс тестовой формы
   /// </summary>
    public partial class TestForm : Form
    {
        private Project _project;

        /// <summary>
        /// Форма с перечислением типов заметки
        /// </summary>
        public TestForm()
        {
            InitializeComponent();
            Category.DataSource = Enum.GetValues(typeof(NoteCategory));
            _project = new Project();
            NoteListView.DataSource = _project.ListNote.GetRange(0, _project.ListNote.Count);

        }

        private void TestForm_Load(object sender, EventArgs e)
        {
            
        }
        /// <summary>
        /// Событие клика на кнопку
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void NewNote_Click(object sender, EventArgs e)
        {
            Note note;
            try
            {
                note = new Note
                {
                    NoteName = NoteName.Text,
                    NoteCategory = (NoteCategory)Category.SelectedItem,
                    NoteText = NoteText.Text
                };
                _project.ListNote.Add(note);
                NoteListView.DataSource = null;
                NoteListView.DataSource = _project.ListNote.GetRange(0, _project.ListNote.Count);
            }
            catch (ArgumentException)
            {
                MessageBox.Show("Too many Symbols");
                NoteName.Text = string.Empty;
            }
        }
        /// <summary>
        /// Сохранение состояния
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>

        private void SaveNotesButton_Click(object sender, EventArgs e)
        {
            ProjectManager.Save(_project);
            MessageBox.Show("Saved Succesfully");
        }

        /// <summary>
        /// Загрузка состояния
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void LoadNotesButton_Click(object sender, EventArgs e)
        {
            _project = ProjectManager.Load();

            NoteListView.DataSource = null;
            NoteListView.DataSource = _project.ListNote.GetRange(0, _project.ListNote.Count);
        }
        /// <summary>
        /// Блок отображения записей
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>

        private void NoteListView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
