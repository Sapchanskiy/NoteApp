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
        #region Private Fields

        #endregion

        #region Public Methods

        /// <summary>
        /// Загрузка файла
        /// </summary>
        /// <param name="filepath">Путь к файлу</param>
        /// <returns></returns>
        public static Project Load(string filePath)
        {
            Project notes = new Project();

            JsonSerializer serializer = new JsonSerializer(); //Создаём экземпляр сериализатора. 

            using (StreamReader streamread = new StreamReader(filePath)
            ) //Открываем поток для чтения из файла с указанием пути.
            using (JsonReader reader = new JsonTextReader(streamread))
            {
                var noteList = serializer.Deserialize<Project>(reader); //Вызываем десериализацию
                notes = noteList;
            }

            return notes;
        }

        /// <summary>
        /// Сохранение файла
        /// </summary>
        /// <param name="project">Сохраняемый проект</param>
        /// <param name="filepath">Путь к файлу</param>
        public static void Save(Project project, string filepath)
        {
            /*if (!project.ListNote.Any())
            {
                throw new ArgumentException("Список заметок пуст");
            }*/

            JsonSerializer serializer = new JsonSerializer(); //Открытие потока

            using (StreamWriter sw = new StreamWriter(filepath))
            using (JsonWriter writer = new JsonTextWriter(sw))
            {
                serializer.Serialize(writer, project); //Вызываем сериализацию и передаём объект для сериализации
            }
        }

        #endregion

    }
}
