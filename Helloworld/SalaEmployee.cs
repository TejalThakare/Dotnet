using beans;

public class SalaEmployee:WageEmployee{
    private float rate;
    private int Target;
    private int intsen=0;
    
    public SalaEmployee():this(1,"saurabh",500000,100,56,1100)
    {

    }

    public SalaEmployee(int id,string name,int sal,int hours,int rate,int Target):base(id,name,sal,hours){
        this.rate=rate;
        this.Target=Target;
    }

    public int insesetive(int Target,int rate){
        if(Target==1000){
            return intsen=5000;
        }
        else{
            return intsen=0;
        }

    }

    public int Rate{
        set;get;
    }

    public override String ToString(){
        return base.ToString() +" rate :"+rate+" intsen :"+intsen;
    }
}
