using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;

namespace NoteApp.UnitTests
{
    [TestFixture]
    class ProjectTests
    {
        private Project _project = new Project();
        
        private List<Note> _listExpected = new List<Note>
        {
            new Note(new DateTime(2058, 3, 12)),
            new Note(new DateTime(2020, 3, 12)),
            new Note(new DateTime(2015, 3, 15)),
            new Note(new DateTime(2012, 3, 12)),
            new Note(new DateTime(218, 3, 12)),
        };

        private Project _projectForOrder = new Project
        {
            ListNote = new List<Note>
            {
                new Note(new DateTime(2015, 3, 15)),
                new Note(new DateTime(2018, 3, 12)){NoteCategory = NoteCategory.Other},
                new Note(new DateTime(2012, 3, 12)),
                new Note(new DateTime(2020, 3, 12)),
                new Note(new DateTime(2058, 3, 12)),
                new Note(new DateTime(2008, 3, 12)){NoteCategory = NoteCategory.Other},
                new Note(new DateTime(218, 3, 12)),

            }
        };

        [SetUp]
        public void InitProject()
        {
            var note1 = new Note(new DateTime(2012, 12, 12));
            note1.NoteName = "Some name here";
            note1.NoteText = "Some text here";
            note1.ChangeDate = new DateTime(2015, 12, 10);
            note1.NoteCategory = NoteCategory.Health;
            
            _project.ListNote = new List<Note>
            {
                new Note(new DateTime(2015, 3, 15)),
                note1,
            };
            
        }

        [Test]
        [TestCase(TestName = "Тест свойства класса ListNote Project")]
        public void TestProject()
        {

            var expectedNoteAmount = 2;
            string[] expectedNames = {"Not Named", "Some name here"};
            string[] expectedTexts = {string.Empty, "Some text here"};
            NoteCategory[] expectedCategories = {NoteCategory.Work, NoteCategory.Health};
            DateTime[] expectedCreationDates = { new DateTime(2015, 3, 15), new DateTime(2012, 12, 12),};
            DateTime[] expectedChangeDates = { new DateTime(2015, 3, 15), new DateTime(2015, 12, 10)};
            Assert.AreEqual(expectedNoteAmount, _project.ListNote.Count);
            for (int i = 0; i < expectedNoteAmount; i++)
            {
                Assert.AreEqual(expectedNames[i], _project.ListNote[i].NoteName);
                Assert.AreEqual(expectedTexts[i], _project.ListNote[i].NoteText);
                Assert.AreEqual(expectedCategories[i], _project.ListNote[i].NoteCategory);
                Assert.AreEqual(expectedChangeDates[i], _project.ListNote[i].ChangeDate);
                Assert.AreEqual(expectedCreationDates[i], _project.ListNote[i].CreationDate);
            }
        }

        [Test]
        [TestCase(TestName = "Тест метода сортировки по дате модифицирования")]
        public void OrderByModifiedDateFilterTest()
        {
            var filteredList = _projectForOrder.OrderListByCreationDate(NoteCategory.Work);
            Assert.AreEqual(_listExpected.Count, filteredList.Count);
            for (int i = 0; i < filteredList.Count; i++)
            {
                Assert.AreEqual(_listExpected[i].NoteCategory, filteredList[i].NoteCategory);
                Assert.AreEqual(_listExpected[i].ChangeDate, filteredList[i].ChangeDate);
            }
        }


    }
}
