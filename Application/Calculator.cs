using System.Collections.Generic;

namespace Application
{
    public class Calculator
    {
        public int Add(AddInput input) {
            int result = 0;
            foreach(int number in input.Numbers){
                result += number;
            }
            return result;
        }

        

        public int Substract(SubstractInput input) {
            int result = input.Numbers[0];

            for(int i = 1; i < input.Numbers.Length; i++) {
                result -= input.Numbers[i];
            }

            return result;
        }

        public int Multiply(MultiplyInput input) {
            int result = 1;

            foreach(int number in input.Numbers) {
                result *= number;
            }

            return result;
        }

        public double Divide(DivideInput input) {
            double result = input.Numbers[0];

            for(int i = 1; i < input.Numbers.Length; i++) {
                result = result / input.Numbers[i];
            }

            return result;
        }

        public List<int> SplitEq(SplitEqInput input) {
            List<int> result = new List<int>();

            int total = input.Numbers[0];
            int times = input.Numbers[1];

            for(int i = 0; i < times; i++) {
                result.Add(total/times);
            }

            return result;
        }

        public int SplitNum(SplitNumInput input) {
            int result = input.Numbers[0];

            for(int i = 1; i < input.Numbers.Length; i++) {
                result = result - input.Numbers[i] < 0 ? 0 : result - input.Numbers[i];
            }

            return result;
        }

        
    }
}