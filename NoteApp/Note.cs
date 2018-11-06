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
            }
        }

        /// <summary>
        /// Дата создания
        /// </summary>
        [JsonProperty]
        public DateTime CreationDate { get; private set; }

        /// <summary>
        /// Дата изменения
        /// </summary>
        public DateTime ChangeDate { get; set; }


        #endregion

        #region Private Members

        public Note()
        {

        }

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
        /// Конструктор класса Note при создании заметки
        /// </summary>
        /// <param name="date">Дата создания</param>
        public Note(DateTime date)
        {
            CreationDate = date;
            ChangeDate = date;
            NoteName = "Без Названия";
        }

        #endregion
    }
}
