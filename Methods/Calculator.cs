namespace Methods
{
    partial class Program{
        public class Calculator{
            public int Add(params int[] numbers){
                var sum = 0;
                foreach (var number in numbers){
                    sum = sum + number;
                }
                return sum;
            }
        }
    }
}