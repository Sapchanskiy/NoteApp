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
    public partial class TestForm : Form
    {
        private Project _project;

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

        private void SaveNotesButton_Click(object sender, EventArgs e)
        {
            ProjectManager.Save(_project);
            MessageBox.Show("Saved Succesfully");
        }

        private void LoadNotesButton_Click(object sender, EventArgs e)
        {
            _project = ProjectManager.Load();

            NoteListView.DataSource = null;
            NoteListView.DataSource = _project.ListNote.GetRange(0, _project.ListNote.Count);
        }
    }
}
