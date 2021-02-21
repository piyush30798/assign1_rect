using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using assign1_rect;

namespace rectTest
{
    [TestFixture]
    public class rectTest
    {

        [Test]
        public void test_getLength()
        {
            //arrange
            int length = 4;
            int width = 1;

            Rectangle rectangle = new Rectangle(length, width);

            //act
            int result_length = rectangle.GetLength();

            //assert
            Assert.AreEqual(result_length, 4);
        }

        [Test]
        public void test_getWidth()
        {
            //arrange
            int length = 5;
            int width = 5;

            Rectangle rectangle = new Rectangle(length, width);

            //act
            int result_width = rectangle.GetWidth();

            //assert
            Assert.AreEqual(result_width, 5);
        }

        [Test]
        public void test_setLength()
        {
                      

            Rectangle rectangle = new Rectangle();

            //act
            int setLength = rectangle.SetLength(8);

            //assert
            Assert.AreEqual(setLength, 8);
        }

        [Test]
        public void test_setWidth()
        {
           
            Rectangle rectangle = new Rectangle();

            //act
            int setWidth = rectangle.SetLength(6);

            //assert
            Assert.AreEqual(setWidth, 6);
        }
        [Test]
        public void test_Perimeter()
        {
            //arrenge
            int length = 6;
            int width = 2;
            Rectangle rectangle = new Rectangle(length, width);

            //act
            int result_perimeter = rectangle.GetPerimeter();

            //assert
            Assert.AreEqual(result_perimeter, 16);
        }

        [Test]
        public void test_Area()
        {
            //arrenge
            int length = 2;
            int width = 2;
            Rectangle rectangle = new Rectangle(length, width);

            //act
            int result_area = rectangle.GetArea();

            //assert
            Assert.AreEqual(result_area, 4);
        }
    }
}
