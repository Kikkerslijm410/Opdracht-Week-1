namespace Pretpark;
public static class Float{
    /*
    *   Deze klasse bevat een aantal methodes die Floats kunnen vergelijken.
    *   Deze methodes zijn nodig omdat floats niet exact zijn en dus niet altijd
    *   hetzelfde zijn.
    */
    public static String metSuffixen(this float f){
        if (f < 1000) return Math.Round(f,1).ToString() + "";
        if (f < 1000000)return Math.Round(f / 1000,1).ToString() + "K";
        if (f < 1000000000)return Math.Round(f / 1000000,1).ToString() + "M";
        if (f < 1000000000000)return Math.Round(f / 1000000000,1).ToString() + "B";
        return Math.Round(f,1).ToString();
    }
}