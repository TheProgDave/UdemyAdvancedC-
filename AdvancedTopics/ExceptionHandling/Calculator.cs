namespace ExceptionHandling
{
    public class Calculator
    {
        public static float Divide(params int[] numbers)
        {
            var result = numbers[0];
            for (var i = 1; i < numbers.Length; i++)
            {
                result /= numbers[i];
            }
            return result;
        }
    }
}