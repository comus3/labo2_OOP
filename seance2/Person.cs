namespace seance2;

public class Person
{
    private string firstName;
    private string lastName;
    public Person(string firstName,string lastName)
    {
        this.firstName = firstName;
        this.lastName = lastName;
    }
    public string displayName()
    {
        return firstName + " " + lastName;
    }
}
