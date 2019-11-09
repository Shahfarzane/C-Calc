using System;
namespace Lab1_Calculator
{
    public class Calculator
    {
        //Properties
        public int FirstNumber;
        public int SecondNumber;
        public int NumberInMemory;


        //Default Constructor that resets the properties to 0
        public Calculator()
        {

            FirstNumber = 0;
            SecondNumber = 0;
            NumberInMemory = 0;
        }


        public override string ToString()
        {
            return String.Format("First number: {0}\n Second number: {1}\n NumberInMemory: {2}\n", FirstNumber, SecondNumber, NumberInMemory);
        }

        public int SumNumbers()
        {
            return FirstNumber + SecondNumber;
        }

        public int MultiplyNumbers()
        {
            return FirstNumber * SecondNumber;
        }

        public int SumInBetween()
        {
            int answer = 0;
            for (int i = FirstNumber; i <= SecondNumber; i++)
            {
                answer = answer + i;
            }
            return answer;
        }

    }
}