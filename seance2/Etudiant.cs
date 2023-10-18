namespace seance2;

public class Etudiant : Person
{
    List<Eval> evaluations;
    public Etudiant(string firstName,string lastName,List<Eval> evaluations) :
    base(firstName,lastName)
    {
        this.evaluations = evaluations;
    }
    public void Add(Eval eval)
    {
        evaluations.Add(eval);
    }
    public double Average()
    {
        return 0;
    }
    public string Bulletin()
    {
        return "space";
    }
}
