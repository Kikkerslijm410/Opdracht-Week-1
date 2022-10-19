namespace Pretpark;
public struct Coordinaat{
    public readonly int x;
    public readonly int y;
    public Coordinaat(int xx, int yy){
        if (xx < 0){
            x = 0;
        }else{
            x = xx;
        }
        if (yy < 0){
            y = 0;
        }else{
            y = yy;
        }
    }
}
