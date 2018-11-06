using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace NoteApp
{
    /// <summary>
    /// Класс, осуществляющий сохранение и загрузку проекта
    /// </summary>
    public static class ProjectManager
    {
        /// <summary>
        /// Путь к файлу с данными
        /// </summary>
        private const string _notesName = "C:\\Users\\User\\Documents\\Notes.notes";
        /// <summary>
        /// Сохранение файла
        /// </summary>
        /// <param name="project">Список заметок</param>
        public static void Save(Project project)
        {
            if (!project.ListNote.Any())
            {
                throw new ArgumentException("Список заметок пуст");
            }
            JsonSerializer serializer = new JsonSerializer();  //Открытие потока
          
            using (StreamWriter sw = new StreamWriter(_notesName))
            using (JsonWriter writer = new JsonTextWriter(sw))
            {
                
                serializer.Serialize(writer, project);//Вызываем сериализацию и передаём объект для сериализации
            }
        }
        /// <summary>
        /// Загрузка файла
        /// </summary>
        /// <returns></returns>
        public static Project Load()
        {
            Project notes = new Project();
            
            JsonSerializer serializer = new JsonSerializer(); //Создаём экземпляр сериализатора. 

            using (StreamReader streamread = new StreamReader(_notesName)) //Открываем поток для чтения из файла с указанием пути.
            using (JsonReader reader = new JsonTextReader(streamread))
            {
                var noteList = serializer.Deserialize<Project>(reader);   //Вызываем десериализацию
                notes = noteList;
              
            }
            return notes;
        }
    }
    }
