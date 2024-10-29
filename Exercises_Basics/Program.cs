
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