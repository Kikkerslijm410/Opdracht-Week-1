namespace Pretpark;
public class Kaart{
    public readonly int Breedte;
    public readonly int Hoogte;
    public Kaart(int b, int h){
        this.Breedte = b;
        this.Hoogte = h;
    }

    //useless method because the map gets drawn by other methods
    public void Teken (Tekener t){
        var oppervlak = Breedte * Hoogte;
    }

    public void VoegItemToe (KaartItem item){
        item.TekenConsole(new ConsoleTekener());
    }

    public void VoegPadToe (Pad pad){
        pad.TekenConsole(new ConsoleTekener());
    }
}