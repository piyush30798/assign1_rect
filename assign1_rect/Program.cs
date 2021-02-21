using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace assign1_rect
{
    public class Rectangle
    {
        private int l;
        private int w;

        public Rectangle()
        {
            l = 1;
            w = 1;
        }

        public Rectangle(int len, int wid)
        {
            l = len;
            w = wid;
        }

        public int GetLength()
        {
            return l;
        }

        public int SetLength(int length)
        {
            l = length;
            return l;
        }
        public int GetWidth()
        {
            return w;
        }
        public int SetWidth(int width)
        {
            w = width;
            return w;
        }
        public int GetPerimeter()
        {
            return (2 * l + 2 * w);
        }
        public int GetArea()
        {
            return (l * w);
        }


    }
    class Program
    {
        static void Main(string[] args)
        {

            int caseSwitch = 0;

            Console.WriteLine("Enter the length of the rectangle");
            int length = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter the width of the rectangle");
            int width = Convert.ToInt32(Console.ReadLine());

            Rectangle rectangle = new Rectangle(length, width);

            Console.WriteLine("Select from the following options");
            while (caseSwitch != 7)
            {
                Console.WriteLine("1. Get Rectangle Length");
                Console.WriteLine("2. Change Rectangle Length");
                Console.WriteLine("3. Get Rectangle Width");
                Console.WriteLine("4. Change Rectangle Width");
                Console.WriteLine("5. Get Rectangle Perimeter");
                Console.WriteLine("6. Get Rectangle Area");
                Console.WriteLine("7. Exit");

                caseSwitch = Convert.ToInt32(Console.ReadLine());

                switch (caseSwitch)
                {
                    case 1:

                        int rectleng = rectangle.GetLength();
                        Console.WriteLine("Length of the rectangle : {0}", rectleng);
                        break;

                    case 2:

                        Console.WriteLine("Enter new length for the rectangle :");
                        int newleng = Convert.ToInt32(Console.ReadLine());
                        if(newleng<1)
                        {
                            Console.WriteLine("Please enter length greater than 0.");
                            break;
                        }
                        else
                        {
                            rectangle.SetLength(newleng);
                            Console.WriteLine("Length of the rectangle updated.");
                            break;

                        }
                        
                    case 3:

                        int rectwidt = rectangle.GetWidth();
                        Console.WriteLine("Width of the rectangle: {0}", width);
                        break;

                    case 4:

                        Console.WriteLine("Enter new width for the recatngle :");
                        int newwidth = Convert.ToInt32(Console.ReadLine());
                        if(newwidth<1)
                        {
                            Console.WriteLine("Please enter width greater than 0.");
                            break;
                        }
                        else
                        {
                            rectangle.SetWidth(newwidth);
                            Console.WriteLine("Width of the rectangle updated.");
                            break;
                        }
          
                    case 5:

                        int rectPeri = rectangle.GetPerimeter();
                        Console.WriteLine("Perimeter of the rectangle is: {0}", rectPeri);
                        break;

                    case 6:

                        int rectArea = rectangle.GetArea();
                        Console.WriteLine("Area of the rectangle is: {0}", rectArea);
                        break;

                    case 7:
                        break;
                }
            }
        }
    }
}
