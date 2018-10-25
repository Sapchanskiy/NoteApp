using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace NoteApp
{
    /// <summary>
    /// Класс NoteApp описывает заметку. Имеет следующие публичные поля: Категория заметки, Имя заметки, Текст заметки.
    /// Приватные поля: Дата создания и дата изменения
    /// </summary>
    public class Note: ICloneable
    {

        #region Private Fields

        /// <summary>
        /// Дата Изменения
        /// </summary>
        private DateTime _changeDate;

        /// <summary>
        /// Текст заметки
        /// </summary>
        private string _noteText;

        /// <summary>
        /// Название заметки
        /// </summary>
        private string _noteName;

        private NoteCategory _noteCategory;

        #endregion

        #region Public Members

        /// <summary>
        /// Категория заметок
        /// </summary>
        public NoteCategory NoteCategory
        {
            get => _noteCategory;
            set
            {
                _noteCategory = value;
                ChangeDate = DateTime.Now;
            }
        }

        /// <summary>
        /// Имя заметки
        /// </summary>
        /// <exception cref="ArgumentOutOfRangeException">Когда количество букв в названии менее 1, или более 49.</exception>
        public string NoteName
        {
            get => _noteName;
            set
            {
                _noteName = value;
                if (value.Length < 1)
                {
                    _noteName = "Без названия";
                }

                if (value.Length >= 50)
                {
                    throw new ArgumentException("Введено слишком много символов");
                }
                ChangeDate = DateTime.Now;
            }
        }
        /// <summary>
        /// Текст заметки
        /// </summary>
        /// <exception cref="ArgumentOutOfRangeException">Когда количество букв в тексте менее 1.</exception>
        public string NoteText
        {
            get => _noteText;
            set
            {
                _noteText = value;
                ChangeDate = DateTime.Now;
            }
        }

        /// <summary>
        /// Дата создания
        /// </summary>
        public DateTime CreationDate { get; }

        /// <summary>
        /// Дата изменения
        /// </summary>
        public DateTime ChangeDate { get => _changeDate; private set => _changeDate = value; }


        #endregion

        #region Private Members


        /// <summary>
        /// реализация интерфейса iCloneable
        /// </summary>
        /// <returns></returns>
        public object Clone()
        {
            throw new NotImplementedException();
        }


        #endregion


        #region Constructor
        /// <summary>
        /// конструктор класса Note
        /// </summary>
        public Note()
        {
            CreationDate = DateTime.Now;
            ChangeDate = DateTime.Now;
            NoteName = "Без Названия";
        }


        #endregion
    }
}
