using NUnit.Framework;

namespace Library.Test
{
    public class DateFormatTest

    {
        // Test para comprobar que se realiza el formato de forma correcta.
        [Test]
        public void TestFormat()
        {
            string expected = "la fecha 19/04/2020 ahora es 2020-04-19";
            string actual = "19/04/2020";
            DateFormat Format = new DateFormat();
            Assert.AreEqual(expected, Format.Format(actual));

        }
        // Test que comprueba que el método no verifica que la fecha ingresada sea correcta.
        [Test]
        public void TestFormatSecond()
        {   //0200-4/-9/
            string actual = "55/23/-302";
            string expected = "la fecha 55/23/-302 ahora es -302-23-55";
            DateFormat Format = new DateFormat();
            Assert.AreEqual(expected, Format.Format(actual));
        }

        // Test comprueba que el método no verifica que la entrada sea una fecha.
        [Test]
        public void TestFormatThird()
        {
            string actual = "0011223344";
            string expected = "la fecha 0011223344 ahora es 3344-12-00";
            DateFormat Format = new DateFormat();
            Assert.AreEqual(expected, Format.Format(actual));
        }

        // UTILIZANDO TDD.
        // Test que comprueba que se aplica el formato deseado (DD-MM-AAAA)
        [Test]
        public void TestOtherFormat()
        {   
            DateFormat Format = new DateFormat();
            string actual = "19/04/2020";
            string expected = "19-04-2020";

            Assert.AreEqual(expected, Format.OtherFormat(actual));
            
        }
    }
}