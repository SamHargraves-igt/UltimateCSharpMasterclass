namespace Coding.Exercise
{

    public class _01_CSharpFundamentals_PersonalAnswers
    {

        public static int CalculateSumOfNumbersBetween(int firstNumber, int lastNumber)
        {
            int sum = 0;
            while (lastNumber >= firstNumber)
            {
                sum += firstNumber;
                firstNumber++;
            }
            return sum;
        }

        public static string RepeatCharacter(char character, int targetLength)
        {
            string result = "";
            if (targetLength <= 0)
            {
                result += character;
            }
            else
            {
                while (targetLength > 0)
                {
                    result += character;
                }
            }
            return result;
        }

        public static int Factorial(int number)
        {
            var result = 1;
            for (int i = 1; i <= number; ++i)
            {
                result *= i;
            }
            return result;
        }


    }

}






