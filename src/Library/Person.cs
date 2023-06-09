namespace Library
{
public class Person
{
    public string Name { get; set; }
    public int Age { get; set; }

    public Person(string name,int age)
    
    {
        this.Age=age;
        this.Name=name;
    }
}
}