
using System.Reflection;

Utils.GetProprietiesAndMethods(new Animal());
Animal animal = Utils.CreateInstance<Animal>();
Console.WriteLine(animal);
class Animal 
{
    public string Name { get; set; }
    public int idade { get; set; } = 0;

    public void voar()
    {
        Console.WriteLine("Voando");
    }
    protected void Andar()
    {
        Console.WriteLine("Andando");
    }

}
class Utils
{
    public static void GetProprieties<T>(T obj) where T : class
    {
        Console.WriteLine("Propriedades:");
        var proprieties = obj.GetType().GetRuntimeProperties();
        Console.WriteLine(string.Join("\n", proprieties));
    }
    public static void getMethods<T>(T obj) where T : class
    {
        Console.WriteLine("Metodos:");
        var proprieties = obj.GetType().GetRuntimeMethods();
        Console.WriteLine(string.Join("\n", proprieties));
    }

    public static void GetProprietiesAndMethods<T>(T obj) where T : class
    {
        GetProprieties(obj);
        getMethods(obj);
    }

    public static T CreateInstance<T>()
    {
        return (T)Activator.CreateInstance<T>();
    }
}