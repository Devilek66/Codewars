public class Person
{
  public string FirstName;
  public string LastName;
  public int Age;
  public string Gender;
  public Person(string firstName="John",string lastName="Doe",int age=0,string gender="Male")
  {
    this.FirstName=firstName;
    this.LastName=lastName;
    this.Age=age;
    this.Gender=gender;
  }
  public string SayFullName()
  {
    return FirstName + " " + LastName;
  }
  public static string GreetExtraTerrestrials(string raceName)
  {
    return "Welcome to Planet Earth " + raceName;
  }
}
