namespace WorkTest.Classes
{
    public class Part2 : Part1 //Наследуемся от класса Part1, чтобы заново не прописывать его функционал и расширить метод ResultStrPart1
    {
        public override string ResultStrPart1(int numerator)
        {
            string resultString = base.ResultStrPart1(numerator);
            if (Share(numerator, 4))
                resultString += "-muzz";
            if (Share(numerator, 7))
                resultString += "-guzz";

            if (resultString != "")     //Это я делал для красоты, чтобы не было лишних тире(-)
            {
                if (resultString[0] == '-')
                    return resultString.Substring(1, resultString.Length - 1);
                else
                    return resultString;
            }
            else
                return resultString;

        }
    }
}
