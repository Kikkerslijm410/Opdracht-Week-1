namespace Pretpark;
public class Kaart{
    public readonly int Breedte;
    public readonly int Hoogte;
    public Kaart(int b, int h){
        this.Breedte = b;
        this.Hoogte = h;
    }
    public List <Pad> paden = new List<Pad>();
    public List <KaartItem> items = new List<KaartItem>();

    public void Teken (Tekener t){
        foreach(var item in items){
            item.TekenConsole(new ConsoleTekener());
        }
        foreach(var pad in paden){
            pad.TekenConsole(new ConsoleTekener());
        }
    }

    public void VoegItemToe (KaartItem item){
        items.Add(item);
    }

    public void VoegPadToe (Pad pad){
        paden.Add(pad);
    }
}