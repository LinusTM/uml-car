namespace test;

internal class Factory : Vehicle {
    Vehicle vehicle = new Vehicle();

    private Factory() { }
    public static void Instance() { }
    public Vehicle Create(int type) {
        return vehicle;
    }
}
