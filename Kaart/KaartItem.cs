namespace Pretpark;
public abstract class KaartItem{
    public Coordinaat locatie {get; set;}
    public abstract char Karakter {get;}

    public KaartItem (Kaart kaart, Coordinaat Locatie){
        locatie = Locatie;
    }
    public void TekenConsole (ConsoleTekener t){
        t.SchrijfOp(locatie, Karakter.ToString());
    }
}