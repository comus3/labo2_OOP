namespace seance2;

public class Cote
{
    private int note;
    public Cote(int note)
    {
        this.note = note;
    }
    public int Note
    {
        get {
            return note;
        }
    }
    public void SetNote(int note)
    {
        this.note = note;
    }

}
