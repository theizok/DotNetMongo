public class User {
   private int userId;
   private string userName {get; set;};
   private string email {get; set;};
   private string password {get; set;};
    
    public User(string userName, string email, string password){
        this.userName = userName;
        this.email = email;
        this.password = password;
    }

}