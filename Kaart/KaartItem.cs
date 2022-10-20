namespace Pretpark;
public abstract class KaartItem{
    public Coordinaat locatie {get; set;}
    public abstract char Karakter {get;}
    public List<KaartItem> ItemList = new List<KaartItem>();

    public KaartItem (Kaart kaart, Coordinaat Locatie){
        locatie = Locatie;
        ItemList.Add(this);
    }
    public void TekenConsole (ConsoleTekener t){
        t.SchrijfOp(locatie, Karakter.ToString());
    }
}