namespace beans;

public class Employee{
    private int id;
    private String name;
    private int sal;

    public Employee(){
        this.id=1;
        this.name="ram";
        this.sal=100000;
    }

    public Employee(int id,string name,int sal){
        this.id=id;
        this.name=name;
        this.sal=sal;
    }

    public int Id{get;set;}
    public int Name{get;set;}
    public int Sal{get;set;}

    public override string ToString(){
       String str = string.Format(("id : "+ id + " ," +"name : " + name +" ," +"sal : " + sal));
        return str;
    }
}
