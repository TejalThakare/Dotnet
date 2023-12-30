namespace banking;

public class Account
{

    public float balance{
        set;get;
    }

    public void Deposit(float bal){
        this.balance=this.balance+bal;
    }

    public void Withdraw(float bal){
        this.balance=this.balance-bal;
    }
}
