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
    public partial class AddOrEditNoteForm : Form
    {
        #region Public Properties

        public Note NewNote { get; private set; }

        #endregion

        #region Constructors

        /// <summary>
        /// Конструктор при создании заметки
        /// </summary>
        public AddOrEditNoteForm()
        {
            InitializeComponent();
            CategoryCombo.DataSource = Enum.GetValues(typeof(NoteCategory));
            NewNote = new Note(DateTime.Now);
            CreatedDate.Value = DateTime.Now;
            ModifiedDate.Value = DateTime.Now;
        }

        /// <summary>
        /// Метод для установки заметки при редактировании
        /// </summary>
        /// <param name="note">Редактируемая заметка</param>
        public void  SetNote(Note note)
        {
            CategoryCombo.DataSource = Enum.GetValues(typeof(NoteCategory));
            NewNote = note;
            NoteNameTextBox.Text = NewNote.NoteName;
            NoteTextTextBox.Text = NewNote.NoteText;
            CategoryCombo.SelectedItem = NewNote.NoteCategory;
            CreatedDate.Value = NewNote.CreationDate;
            ModifiedDate.Value = NewNote.ChangeDate;
        }

        #endregion

        #region Handlers

        /// <summary>
        /// Нажатие кнопки ОК
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ButtonOK_Click(object sender, EventArgs e)
        {
            try
            {
                NewNote.NoteName = NoteNameTextBox.Text;
                NewNote.NoteText = NoteTextTextBox.Text;
                NewNote.NoteCategory = (NoteCategory)CategoryCombo.SelectedItem;
                NewNote.ChangeDate = DateTime.Now;
                DialogResult = DialogResult.OK;
                Close();
            }
            catch (ArgumentException)
            {
                MessageBox.Show("Too many characters", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        /// <summary>
        /// Нажатие кнопки Отмена
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ButtonCancel_Click(object sender, EventArgs e)
        {
            NewNote = null;
            DialogResult = DialogResult.Cancel;
            Close();
        }

        #endregion
    }
}
