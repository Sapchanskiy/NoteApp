using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;

namespace NoteApp.UnitTests
{
    [TestFixture]
    class NoteTests
    {
        #region NoteCategory Tests

        [Test]
        [TestCase(NoteCategory.Work, NoteCategory.Work, TestName = "Тест категории по верным значениям")]
        public void NoteCategoryPositiveTests(NoteCategory expectedCategory, NoteCategory categoryToSet)
        {
            var note = new Note
            {
                NoteCategory = categoryToSet
            };
            Assert.True(note.NoteCategory == expectedCategory);
        }

        [Test]
        [TestCase(NoteCategory.Work, NoteCategory.Other, TestName = "Тест категории по неверным значениям")]
        public void NoteCategoryNegativeTests(NoteCategory expectedCategory, NoteCategory categoryToSet)
        {
            var note = new Note
            {
                NoteCategory = categoryToSet
            };
            Assert.False(note.NoteCategory == expectedCategory);
        }

        #endregion

        #region NoteName Tests

        [Test]
        [TestCase("CorrectName", "CorrectName", TestName = "Тестирование свойства NoteName с корректными данными"),
         TestCase("Not Named", "", TestName = "Тестирование свойства NoteName присвоением пустого значения")]
        public void NoteNameTests(string expectedName, string actualName)
        {
            var note = new Note();
            note.NoteName = actualName;
            Assert.AreEqual(expectedName, note.NoteName);
        }

        
        [Test]
        [TestCase(TestName = "Тестирование свойства NoteName строкой длиной больше 50 символов")]
        public void NoteNameValueLengthTest()
        {
            var note = new Note();

            Assert.Throws<ArgumentException>( () =>
            {
                note.NoteName = "Sample Text Sample Text Sample Text Sample Text " +
                                "Sample Text Sample Text Sample Text Sample Text Sample" +
                                " Text Sample Text Sample Text Sample Text Sample Text " +
                                "Sample Text Sample Text Sample Text Sample Text Sample Text ";
            }, "Test Error");
        }

        #endregion

        #region Note CreationDate and ChangeDate Tests

        [Test]
        [TestCase(TestName = "Тест свойств CreationDate и ChangeDate при создании")]
        public void TestDatesOnCreation()
        {
            DateTime date = new DateTime(2012, 12, 12);
            var note = new Note(date);
            Assert.AreEqual(date, note.CreationDate);
            Assert.AreEqual(date, note.ChangeDate);
        }

        [Test]
        [TestCase(TestName = "Тест свойства ChangeDate при изменении")]
        public void TestChange()
        {
            DateTime date = new DateTime(2012, 12, 12);
            var note = new Note(date);
            Assert.AreEqual(date, note.CreationDate);
            Assert.AreEqual(date, note.ChangeDate);
        }
        #endregion

        #region NoteText Tests


        [Test]
        [TestCase("CorrectText", "CorrectText", TestName = "Тестирование свойства NoteText с корректными данными"),
         TestCase("", "", TestName = "Тестирование свойства NoteText присвоением пустого значения")]
        public void NoteTextTests(string expectedText, string actualText)
        {
            var note = new Note();
            note.NoteText = actualText;
            Assert.AreEqual(expectedText, note.NoteText);
        }

        #endregion


    }
}

