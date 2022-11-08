using System;

namespace SavingInterface
{
  class TodoList: IDisplayable,IRestable
  {
    public string[] Todos
    { get; private set; }

   public string headerSymbol = "-------";
    public string HeaderSymbol
    {get{
      return headerSymbol;
    }}

    private int nextOpenIndex;
    

    public TodoList()
    {
      Todos = new string[5];
      nextOpenIndex = 0;
    }

    public void Add(string todo)
    {
      Todos[nextOpenIndex] = todo;
      nextOpenIndex++;
    }

    //implement interface method
    public void Display()
    {
     
       Console.WriteLine("Todos");
       Console.WriteLine(HeaderSymbol);
      foreach(string todo in Todos)
      {
        if(String.IsNullOrEmpty(todo)){
          Console.WriteLine("[]");
        }else{
           Console.WriteLine(todo);
        }
       
      }
     
    }

    public void Reset()
    {
      Todos = new string[5];
      nextOpenIndex = 0;
    }
  }
}
