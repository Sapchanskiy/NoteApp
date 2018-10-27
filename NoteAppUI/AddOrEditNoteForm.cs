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
        #region Private Fields

        /// <summary>
        /// Флаг закрытия через кнопку OK
        /// </summary>
        private bool _okButtonFlag = false;

        #endregion


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
            NewNote = new Note();
        }

        /// <summary>
        /// Конструктор при редактировании заметки
        /// </summary>
        /// <param name="note">Редактируемая заметка</param>
        public AddOrEditNoteForm(Note note)
        {
            InitializeComponent();
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
                _okButtonFlag = true;
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
            Close();
        }

        /// <summary>
        /// Закрытие через красный крестик
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void AddOrEditNoteForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (!_okButtonFlag)
            {
                NewNote = null;
            }
        }

        #endregion

        private void CreatedDate_ValueChanged(object sender, EventArgs e)
        {

        }
    }
}
