namespace sprzet;

public enum UserType
{
    Student,
    Employee
}

public class Uzytkownik
{
    public static int Count = 1;
    UserType userType;
    private string name, surname;
    
    public int Id { get; set; }
    
    public Uzytkownik(UserType userType, string name, string surname)
    {
        this.userType = userType;
        this.name = name;
        this.surname = surname;
        Id = Count++;
    }
}