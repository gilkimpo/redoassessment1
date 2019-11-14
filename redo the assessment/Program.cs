using System;

namespace redo_the_assessment
{
    class Program
    {
        static void Main(string[] args)

        {
            string answer;

            
            {
                double grade, grade1, grade2, grade3;
                Console.WriteLine("enter your grade");
                grade = Convert.ToDouble(Console.ReadLine());
                bool passed = IsPassing(grade);
                Console.WriteLine("enter grade1");
                grade1 = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine("enter grade2");
                grade2 = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine("enter grade3");
                grade3 = Convert.ToDouble(Console.ReadLine());
                double average = AverageGrade(grade1, grade2, grade3);
                double OddOrEven = IsEvenOrOddAndPassing(grade);
                
                {
                    Console.WriteLine("is there another person who wants to do this?");
                    answer = Console.ReadLine().ToLower();
                    try
                    {
                        answer = Console.ReadLine().ToLower();
                    }
                    catch (FormatException )
                    {

                        Console.WriteLine("that's not what i asked for");
                    }
                    catch (ApplicationException ex)
                    {
                        Console.WriteLine(ex.Message);
                    }
                    catch(ArgumentNullException)
                    {
                        Console.WriteLine("can't just hit space bar dude");
                    }
                } while (answer != "y");
            } while (answer == "y") ;
            //learn the try catch thing








        }
        public static bool IsPassing(double grade)
        {
            if (grade>65)
            {
                Console.WriteLine("you passed");
                return (grade > 65) == true;
            }
            else 
            {
                Console.WriteLine("failing");
                return (grade < 65) == false;
            }
        }
        public static double AverageGrade(double grade1, double grade2, double grade3)
        {
            Console.WriteLine(" your average grade is " + (grade1 + grade2 + grade3) / 3);
            return ((grade1 + grade2 + grade3)/3);

        }
        public static double IsEvenOrOddAndPassing(double grade)
        {
            if (grade %2==0 && grade >65)
            {
                Console.WriteLine(" you passed and it's even");
                return grade;
            }
            if (grade %2==1 && grade >65)
            {
                Console.WriteLine("you passed and it's odd");
                return grade;
            }
            if (grade %2==0 && grade <65)
            {
                Console.WriteLine("failing and even");
                return grade;
            }
           else  if(grade %2==1 && grade <65)
            {
                Console.WriteLine("failing and odd");
                return grade;
            }
            return grade;

        }
    }
}
