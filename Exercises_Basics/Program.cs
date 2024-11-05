
using System.Reflection.Metadata.Ecma335;

car auto = new car("Citroen","c2","2006");
auto.Displayinfo();
class car(string brand, string model, string data)
{
    public string brand = brand;
    public string model = model;
    public string data = data;
    public void Displayinfo(){
        Console.WriteLine(brand);
        Console.WriteLine(model);
        Console.WriteLine(data);
    }
}

class Student(string name, int grade)
{
    public string Name { get;
        private set; }
    public int grade { get { return grade; }
        set
        {
            if (grade <= 6 && grade >= 1)
            {
                grade = value;
            }

            else
            {
                throw new ArgumentOutOfRangeException("Ocena musi byc z zakresu od 1 do 6");
            }
        }
    }
    public bool isPassing(){
        if (grade >= 2)
        {
            return true;
        }
        else { return false; }
}
}
class Book(string Title, string author, int pages)
{
    public string Title { get; private set; }
    public string Author { get; private set; }
    public int Pages { get; private set; }
    public void GetSummary()
    {
        Console.WriteLine("Title by" + author );
    }
}