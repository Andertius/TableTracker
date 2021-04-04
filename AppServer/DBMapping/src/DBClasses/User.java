package DBClasses;
public class User {
    public int Id;
    public String Username;
    public String Avatar;
    public String Email;
    public String Password;
    public int Roles;
    public String Salt;

    public User(){}
    public User(String username, String avatar, String email, String password, int roles, String salt)
    {
        Username = username;
        Avatar = avatar;
        Email = email;
        Password = password;
        Roles = roles;
        Salt = salt;
    }


}
