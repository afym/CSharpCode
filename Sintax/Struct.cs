using System;
using NUnit.Framework;

namespace CSharpCode.Sintax
{
    [TestFixture]
    class Struct
    {
        [Test]
        public void BookStructTest()
        {
            Book book;
            book.id = 1;
            book.name = "Bible";
            book.date = new DateTime(1960, 1, 1);

            Assert.AreEqual(book.id, 1);
            Assert.AreEqual(book.name, "Bible");
        }
    }

    struct Book
    {
        public int id;
        public string name;
        public DateTime date;

        public string getDescription() 
        {
            return "The book #" + this.id 
                    + " is called " + this.name 
                    + " was printed in " + date.ToString();
        }
    }
}
