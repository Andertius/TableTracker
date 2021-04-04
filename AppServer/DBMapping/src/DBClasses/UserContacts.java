package DBClasses;

public class UserContacts {
    public int Id;
    public String Name;
    public String Surname;
    public String PhoneNumber;
    public int UserId;
    public UserContacts(){}
    public  UserContacts(int id, String name, String surname, String phoneNumber, int userId)
    {
        Id = id;
        Name=name;
        Surname=surname;
        PhoneNumber=phoneNumber;
        UserId = userId;
    }
}
