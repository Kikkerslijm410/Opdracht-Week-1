namespace Pretpark;
public static class Float{
    /*
    *   Deze klasse bevat een methode die Floats vergelijkt.
    *   Deze methode is nodig omdat elke groep floats een andere
    *   letter moet teruggeven
    */
    public static String metSuffixen(this float f){
        if (f < 1000) return Math.Round(f,1).ToString() + "";
        if (f < 1000000)return Math.Round(f / 1000,1).ToString() + "K";
        if (f < 1000000000)return Math.Round(f / 1000000,1).ToString() + "M";
        if (f < 1000000000000)return Math.Round(f / 1000000000,1).ToString() + "B";
        return Math.Round(f,1).ToString();
    }
}