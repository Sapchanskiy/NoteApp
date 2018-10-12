using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NoteApp
{
    /// <summary>
    /// Класс проект
    /// </summary>
    public class Project
    {
        /// <summary>
        /// Список заметок
        /// </summary>
        public List<Note> ListNote;
        /// <summary>
        /// Конструктор класса
        /// </summary>
        public Project()
        {
            ListNote = new List<Note>();
        }
    }
}
