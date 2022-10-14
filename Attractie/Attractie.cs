namespace Pretpark{
    public class Attractie : KaartItem{

        public override char Karakter {get;} = 'A';
        private int? minimaleLengte {get; set;}
        private int? angstLevel {get; set;}
        private string naam {get; set;} = "A";
        public Attractie(Kaart k, Coordinaat coord) : base(k, coord){}
    }
}