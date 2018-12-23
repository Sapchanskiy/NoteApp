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
        /// Текущая заметка
        /// </summary>
        public Note CurrentNote;

        /// <summary>
        /// Конструктор класса
        /// </summary>
        public Project()
        {
            ListNote = new List<Note>();
        }

        /// <summary>
        /// Организовать список по дате создания заметок
        /// </summary>
        /// <returns>Список отсортированных заметок</returns>
        public List<Note> OrderListByCreationDate()
        {
            return ListNote.OrderByDescending(t => t.ChangeDate).ToList();
        }

        /// <summary>
        /// Организовать список заметок по дате создания и отфильтровать по категории
        /// </summary>
        /// <param name="category">Категория заметки</param>
        /// <returns>Список отфильтрованных заметок</returns>
        public List<Note> OrderListByCreationDate(NoteCategory category)
        {
            return OrderListByCreationDate().FindAll(t => t.NoteCategory == category);
        }

    }
}
