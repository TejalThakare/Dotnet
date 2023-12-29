namespace BusinessObjectLayer;

public class Product{
    private int id;
    private string name;
    private string description;

    

    public Product(){
        this.id=0;
        this.name="chocolate";
        this.description="Made with chocolate";

    }
    public Product(int id,string name,string description){
        this.id=id;
        this.name=name;
        this.description=description;
    }

    public int Id{
         get { return id; }
        set { id = value; }
    }
    public string Name{
       get { return name; }
        set { name = value; }
    }
    public string Description{
       get { return description; }
        set { description = value; }
    }
}