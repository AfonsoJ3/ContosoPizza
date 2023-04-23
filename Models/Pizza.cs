namespace ContosoPizza.Models;

public class Pizza
{
    private string? _name;
    private int _id;

    public int Id
    {
        get{return _id;} 
        set{_id = value;}
    }

    public string? Name
    {
       get{return _name;}
       set{_name = value;}

    }

    public bool IsGlutenFree{get; set;}
}