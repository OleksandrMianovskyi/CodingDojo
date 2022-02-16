namespace Randori._8_StudentsFinalGrade
{
    internal class Program
    {
        public static void Main(string[] args)
        {
        }
        
        /*
         This function should return a number (final grade). There are four types of final grades:
        100, if a grade for the exam is more than 90 or if a number of completed projects more than 10.
        90, if a grade for the exam is more than 75 and if a number of completed projects is minimum 5.
        75, if a grade for the exam is more than 50 and if a number of completed projects is minimum 2.
        0, in other cases
        */
        public static int FinalGrade(int e, int p) => e<91&p<11?e<76|p<5?e<51&p<2?0:75:90:100;
    }
}