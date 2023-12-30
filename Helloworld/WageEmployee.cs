using beans;

public class WageEmployee:Employee{
    private int hours;

    public WageEmployee(){
        this.hours=60;
    }

    public WageEmployee(int id,string name,int sal, int hours):base(id,name,sal){
        this.hours=hours;
    }

    public int Hours{
        set;get;
    }

    public override string ToString(){
        return base.ToString()+"  hours :"+hours;
    }

}