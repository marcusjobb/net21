using Microsoft.VisualStudio.TestTools.UnitTesting;
using UnitTesting_Repetition_Live;

namespace UnitTesting_Repetition_Live.Tests
{
    [TestClass()]
    public class TextListTests
    {
        [TestMethod()]
        public void TextListTest ()
        {
            var file = new TextList("z:adslkfadslkfjkpoem.txt");
            Assert.IsTrue(file.Text.Count == 0);
        }

        [TestMethod()]
        [DataRow("Row2", 1)]
        [DataRow("row2", 1)]
        public void TextListFindRow (string find, int expected)
        {
            var text = new TextList("");
            text.Text.Add("Row1");
            text.Text.Add("Row2");
            text.Text.Add("Row3");

            var actual = text.FindRowContaining(find);
            Assert.AreEqual(expected, actual);
        }

        [TestMethod()]
        public void GetrowTest ()
        {
            var text = new TextList("");
            text.Text.Add("Row1");
            text.Text.Add("Row2");
            text.Text.Add("Row3");
            var actual = text.GetRow(text.FindRowContaining("katt"));
            Assert.AreEqual(string.Empty, actual);
        }

        [TestMethod()]
        public void GetrowTestMax ()
        {
            var text = new TextList("");
            text.Text.Add("Row1");
            text.Text.Add("Row2");
            text.Text.Add("Row3");
            var actual = text.GetRow(text.Text.Count);
            Assert.AreEqual(string.Empty, actual);
        }
    }
}