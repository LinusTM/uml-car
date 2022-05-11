
namespace test;

internal class Bicycle : IBreakable {
    private int numberOfWheels;
    private string registrationnumber;

    public Bicycle(int numberOfWheels) {
        this.numberOfWheels = numberOfWheels;
        Wheel[] wheels = new Wheel[numberOfWheels];
    }

    public void Brake() { }
}
