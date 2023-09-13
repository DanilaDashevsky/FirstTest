using System.ComponentModel.Design;
using WorkTest.Interfaces;

namespace WorkTest.Classes
{
    public class Part1 : IPart1
    {
        //Свойства, которые я использую, чтобы в будущем можно было их переопределить для третьей части
        public virtual string label3 { get => "fizz-"; }
        public virtual string label5 { get => "buzz-"; }
        public virtual string label3And5 { get => "fizz-buzz"; }

        public bool Share(int numerator, int denominator) //проверят, делиться ли числитель(numerator) на знаменатель(denominator)
        {
            if (denominator != 0)
            {
                if (numerator % denominator == 0)
                    return true;
            }
            else throw new ArgumentOutOfRangeException(paramName: nameof(denominator), message: "Знаменатель должен быть > 0");
            return false;
            
        }
        public virtual string ResultStrPart1(int numerator)  //Возвращает результирующую строку в основном метод по итогом проверок на деление
        {
            string resultString = "";
            if (Share(numerator, 3) && Share(numerator, 5))
            { resultString += label3And5; return resultString; }
            else
            {
                if (Share(numerator, 3))
                    resultString += label3;
                if (Share(numerator, 5))
                    resultString += label5;
            }
            if (resultString != "")
                resultString = resultString.Substring(0, resultString.Length - 1);
            return resultString;
        }

        public void ChangeList(int[] arrayNumber) //Основной метод, который принимает в себя массив чисел и выводит результат
        {
            Console.Write("Out:");
            if (arrayNumber != null)
            {
                foreach (int i in arrayNumber)
                {
                    if (ResultStrPart1(i) != "")
                        Console.Write($"{ResultStrPart1(i)},");
                    else Console.Write($"{i},");
                }
            }
        }
    }
}
