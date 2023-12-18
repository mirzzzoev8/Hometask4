var person = new Person();
person.FirstName =" FirstName: " + "Yusufjon";
person.LastName ="LastName: " + "Mirzoev";
person.Age ="Age: " + 16;

System.Console.WriteLine(person.GetFullInfo()); 



class Person
{
  public string FirstName; 
  public string LastName;
  public string Age;
  

  public string GetFullInfo()
  {
    return $"{FirstName} \n {LastName} \n {Age} ";
  }
}