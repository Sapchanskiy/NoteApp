using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

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
        /// Дата создания
        /// </summary>
        private readonly DateTime _creationDate;

        /// <summary>
        /// дата Изменения
        /// </summary>
        private DateTime _changeDate;

        /// <summary>
        /// Поле категорий заметки
        /// </summary>
        private NoteCategory _noteCategory;

        /// <summary>
        /// Текст заметки
        /// </summary>
        private string _noteText;

        /// <summary>
        /// Название заметки
        /// </summary>
        private string _noteName;

        #endregion

        #region Public Members
        /// <summary>
        /// Категория заметок
        /// </summary>
        public NoteCategory NoteCategory
        {
            get
            {
                return _noteCategory;
            }
            set { _noteCategory = value; }

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
                _changeDate = DateTime.Now;
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
                _changeDate = DateTime.Now;
            }
        }


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
            _creationDate = DateTime.Now;
            _changeDate = DateTime.Now;
            NoteName = "Без Названия";
    
            

        }


        #endregion
    }
}
