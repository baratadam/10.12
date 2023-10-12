using akasztófa;

var target = new Target();
Console.WriteLine("Kérem adja meg a kitalált szót: ");
target.Word = Console.ReadLine();
Console.WriteLine("Kérem adjon meg betűt: ");
target.SetWord(Console.ReadLine());
do
{
    Console.WriteLine("Írjon be egy betűt");
    target.SetWord(Console.ReadLine());
}
while (true);