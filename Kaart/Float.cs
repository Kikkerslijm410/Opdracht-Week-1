namespace Pretpark;
public static class Float{
    public static String metSuffixen(this float f){
        if (f < 1000) return Math.Round(f,1).ToString() + "";
        if (f < 1000000)return Math.Round(f / 1000,1).ToString() + "K";
        if (f < 1000000000)return Math.Round(f / 1000000,1).ToString() + "M";
        if (f < 1000000000000)return Math.Round(f / 1000000000,1).ToString() + "B";
        return Math.Round(f,1).ToString();
    }
}