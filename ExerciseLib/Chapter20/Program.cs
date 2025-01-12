public class Example
{
    static void Main()
    {
        // Lion lion = new Lion(true, 80);
        // lion.CatchPrey(null);

        // AfricanLion lion1 = new AfricanLion(true, 120);
        // lion1.CatchPrey(null);

        Lion lion2 = new AfricanLion(false, 60);
        lion2.CatchPrey(null);
    }
}

public abstract class Felidae
{
    private bool male;
    public Felidae() : this(true)
    {}
    public Felidae(bool male)
    {
        this.male = male;
    }
    public bool Male
    {
        get {return male;}
        set {this.male = value;}
    }
    public virtual void Walk()
    {}
    protected void Hide()
    {}
    protected void Run()
    {}
    public abstract void CatchPrey(object prey);
}
public class Lion : Felidae, Reproducible<Lion>
{
    private int weight;
    private Paw frontLeft;
    private Paw frontRight;
    private Paw bottomLeft;
    private Paw bottomRight;

    public Lion(bool male, int weight) : base(male)
    {
        this.weight = weight;
    }
    public int Weight
    {
        get {return weight;}
        set {this.weight = value;}
    }
    private void MovePaw(Paw paw)
    {}
    public override void Walk()
    {
        this.MovePaw(frontLeft);
        this.MovePaw(frontRight);
        this.MovePaw(bottomLeft);
        this.MovePaw(bottomLeft);
    }
    protected void Ambush()
    {}
    public override void CatchPrey(object prey)
    {
        Console.WriteLine("Lion.CatchPrey");
    }
    Lion[] Reproducible<Lion>.Reproduce(Lion mate)
    {
        return new Lion[]{new Lion(true, 12), new Lion(false, 10)};
    }
}
public class AfricanLion : Lion
{
    public AfricanLion(bool male, int weight) : base(male, weight)
    {}
    public override void CatchPrey(object prey)
    {
        Console.WriteLine("AfricanLion.CatchPrey");
        Console.WriteLine("calling base.CatchPrey");
        Console.Write("\t");
        base.CatchPrey(prey);
        Console.WriteLine("...end of call.");
    }
    public override string ToString()
    {
        return string.Format("(AfricanLion, male: {0}, weight: {1})", this.Male, this.Weight);
    }
}
public interface Reproducible<T> where T : Felidae
{
    T[] Reproduce(T mate);
}
public class Paw
{

}
public abstract class Animal
{
    public void PrintInformation()
    {
        Console.WriteLine("I am a {0}.", this.GetType().Name);
        Console.WriteLine(GetTyicalSound());
    }
    protected abstract String GetTyicalSound();
}
public class Cat : Animal   
{
    protected override string GetTyicalSound()
    {
        return "Meoooow!";
    }
}