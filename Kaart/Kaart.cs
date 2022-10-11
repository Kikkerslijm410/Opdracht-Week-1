namespace Pretpark;
public class Kaart{
    public readonly int Breedte;
    public readonly int Hoogte;
    public Kaart(int b, int h){
        this.Breedte = b;
        this.Hoogte = h;
    }

    public void Teken (Tekener t){
        //useless method because the map gets drawn by other methods
    }

    public void VoegItemToe (KaartItem item){
        item.TekenConsole(new ConsoleTekener());
    }

    public void VoegPadToe (Pad pad){
        pad.TekenConsole(new ConsoleTekener());
    }
}