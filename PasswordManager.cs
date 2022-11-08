using System;

namespace SavingInterface
{
  class PasswordManager: IDisplayable,IRestable
  {
    private string Password
    { 
      get
      {
        return Password;
      }
    set
    {
      //password must be at least 8
      if(value.Length >= 8){Password= value;}
      
    } 
    }

    public bool Hidden
    { get; private set; }

    public string headerSymbol = "-------";
    public string HeaderSymbol
    {get{
      return headerSymbol;
    }}


    public PasswordManager(string password, bool hidden)
    {
      Password = password;
      Hidden = hidden;
    }

    //method
   public bool ChangePassword(string oldPassword, string newPassword)
   {
     if(oldPassword == newPassword)
     {
       Password = newPassword;
       return true;
     }
     else 
     {
       return false;
     }
   }
    
    //implement interface method
    public void Display()
    {
        Console.WriteLine("Password");
       Console.WriteLine(HeaderSymbol);
      if(!Hidden)
      {
        Console.WriteLine(Password);
      }     
      else
      {
         Console.WriteLine("*********");
      }

    }

    public void Reset()
    {
      Password = "";
      Hidden = false;
    }

  }
}
