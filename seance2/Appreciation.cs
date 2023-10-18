namespace seance2;

public class Appreciation : Eval
{
    private string appreciation;
    public Appreciation(string appreciation,Activite activite):
    base(activite)
    {
        this.appreciation = appreciation;
    }
    public override int Note()
    {
        if (appreciation == "A"){return 20;}else if (appreciation == "B"){return 16;}
        else if (appreciation == "C"){return 12;}
        else if (appreciation == "D"){return 8;}
        else if (appreciation == "E"){return 4;}
        else{return 0;}
    }
    public void setNote(string note)
    {
        appreciation = note;
    }
}
