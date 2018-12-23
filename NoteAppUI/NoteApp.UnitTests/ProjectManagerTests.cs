using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;

namespace NoteApp.UnitTests
{
    [TestFixture]
    class ProjectManagerTests
    {
        private Dictionary<string, Project> TestData;
        private string _pathToAssembly = Path.GetDirectoryName(typeof(ProjectManagerTests).Assembly.CodeBase).Replace(@"file:\", string.Empty);

        [SetUp]
        public void InitProject()
        {
            var note1 = new Note(new DateTime(2012, 12, 12));
            note1.NoteName = "Some name here";
            note1.NoteText = "Some text here";
            note1.ChangeDate = new DateTime(2015, 12, 10);
            note1.NoteCategory = NoteCategory.Health;

            Project projectNotEmpty = new Project();
            projectNotEmpty.ListNote = new List<Note>
            {
                new Note(new DateTime(2015, 3, 15)),
                note1,
            };
            TestData = new Dictionary<string, Project>
            {
                {"NotEmpty", projectNotEmpty},
                {"Empty", new Project() }
            };
        }


        [Test]
        [TestCase("NotEmpty", TestName = "Тест сериализации")]
        public void ProjectManagerSaveTest(string projectKey)
        {
            ProjectManager.Save(TestData[projectKey], _pathToAssembly + "\\NotEmpty.notes");
            Assert.True(File.Exists(_pathToAssembly + "\\NotEmpty.notes"));
            using (StreamReader expectedFile = File.OpenText(_pathToAssembly + "\\TestData\\TestCompareToSaved.notes"))
            {
                using (StreamReader actualFile = File.OpenText(_pathToAssembly + "\\NotEmpty.notes"))
                {
                    FileAssert.AreEqual(expectedFile.BaseStream, actualFile.BaseStream);
                }
            }
            
            
        }

        [Test]
        [TestCase("Empty", TestName = "Тест сериализации с пустым списком")]
        public void SaveTestWithEmptyList(string projectKey)
        {
            Assert.Throws<ArgumentException>(
                () => { ProjectManager.Save(TestData[projectKey], _pathToAssembly + "\\TestData\\Empty.notes"); },
                "Save Error"
            );
        }

        [Test]
        [TestCase(TestName = "Тестирование десериализации")]
        public void LoadTest()
        {
            var actualData = ProjectManager.Load(_pathToAssembly + "\\TestData\\TestDeserialize.notes");
            Assert.AreEqual(TestData["NotEmpty"].ListNote.Count, actualData.ListNote.Count);
            Assert.AreEqual(TestData["NotEmpty"].ListNote[0].CreationDate,
                actualData.ListNote[0].ChangeDate);
            Assert.AreEqual(TestData["NotEmpty"].ListNote[0].NoteName,
                actualData.ListNote[0].NoteName);
            Assert.AreEqual(TestData["NotEmpty"].ListNote[0].NoteCategory,
                actualData.ListNote[0].NoteCategory);
            Assert.AreEqual(TestData["NotEmpty"].ListNote[0].NoteText,
                actualData.ListNote[0].NoteText);
            Assert.AreEqual(TestData["NotEmpty"].ListNote[0].ChangeDate,
                actualData.ListNote[0].ChangeDate);
        }

        [Test]
        [TestCase(TestName = "Тестирование десериализации поврежденного файла")]
        public void LoadTestDamagedFile()
        {
            var actualData = ProjectManager.Load(_pathToAssembly + "\\TestData\\TestDeserializeDamaged.notes");
            Assert.IsEmpty(actualData.ListNote);
            
        }

        [TearDown]
        public void DeleteAll()
        {
            File.Delete(_pathToAssembly + "\\NotEmpty.notes");
        }
    }
}
