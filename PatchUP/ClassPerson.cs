using System;

public class person
{
   public string Name;
   public string Email;
   public string Password;

    public person(string name, string email, string password)
    {
        this.Name = name;
        this.Email = email;
        this.Password = password;
    }
}

public class admin: person
{
    public int adminID;
    public admin(int AdminID, string name, string email, string password ):base(name, email, password)
    {
        this.adminID = AdminID;
    }

    public int PostTutorial()
    {
        Console.WriteLine("Apakah ingin melakukan post artikel dan video, 1= Ya, 0=Tidak");
        int pilihan = Console.Read();
        return pilihan;
        //pengembangan selanjutnya menggunakan database
    }
    public int DeleteTutorial()
    {
        Console.WriteLine("Apakah ingin melakukan delete artikel dan video ini");
        int pilihan = Console.Read();
        return pilihan;
        // pengembangan selanjutnya menggunakan database

    }
}

public class user: person
{
    public int userID;
    public user(int UserID, string name, string email, string password) : base(name, email, password)
    {
        this.userID = UserID;
    }
    public int CreatePlaylist()
    {
        //dummy for get video ID
        int videoID = Console.Read();
        return videoID;
    }
    public string addComment(string comment)
    {
       return comment;
    }
    public int deleteComment(int commentID)
    {
        return commentID;
    }
    public void addPost()
    {
       
    }
    public void makeTutorialRequest()
    {

    }
    public void makeQuestion()
    {

    }
}