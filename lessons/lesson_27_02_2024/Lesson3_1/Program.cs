using OrederedList;

Random r = new Random();

var a = new OrderedList<int>();

for  (int i = 0; i < 10; i++)
{
    a.Add(r.Next(20));
}
Console.WriteLine("________________________________________________________");
Console.WriteLine("Add elements in ordered list");
Console.WriteLine(a);

Console.WriteLine("________________________________________________________");
Console.WriteLine("Add 4");
a.Add(4);
Console.WriteLine(a);

Console.WriteLine("________________________________________________________");
Console.WriteLine("Ordered List contains 4 ?");
Console.WriteLine(a.Contains(4));

Console.WriteLine("________________________________________________________");
Console.WriteLine("Remove 4");
a.Remove(4);
Console.WriteLine(a);

Console.WriteLine("________________________________________________________");
Console.WriteLine("Create new Ordered List");
var b = new OrderedList<int>();
for (int i = 0;i < 15;i++)
{
    b.Add(r.Next(20));
}
Console.WriteLine("b:\n" + b);
Console.WriteLine("a:\n" + a);
Console.WriteLine("Merging both Ordered Lists...");
a.Merge(b);
Console.WriteLine(a);