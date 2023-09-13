
namespace WorkTest.Classes
{
    public class Part3 : Part2 //Переопределяем свойства класса Part2, чтобы метод ResultStrPart1, соответствовал задаче из первой части
    {
        public override string label3 { get => "dog-"; }
        public override string label5 { get => "cat-"; }
        public override string label3And5 { get => "good-boy"; }
    }
}
