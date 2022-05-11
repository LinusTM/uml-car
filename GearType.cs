namespace test;

internal class GearType {
    private string name;

    public static void GetType() { }

    internal class Gearbox {
        private int currentGear;
        
        public void ShiftUp(int steps) { }
        public void ShiftDown(int steps) { }
    }
}
