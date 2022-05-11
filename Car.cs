namespace test;

internal class Car : Vehicle, IGasolineEngine {
    private string registrationnumber;
    private string registrationYear;
    private IEngine engine;

    protected Car() {
        GearType.Gearbox gearbox = new GearType.Gearbox();
        Wheel[] wheels = new Wheel[4];
    }
    public Car(string color) {
        GearType.Gearbox gearbox = new GearType.Gearbox();
        Wheel[] wheels = new Wheel[4];
    }
    
    public Car(string color, float size) {
        GearType.Gearbox gearbox = new GearType.Gearbox();
        Wheel[] wheels = new Wheel[4];
    }

    public void Start() { }
    public void TurnOff() { }
    public void Inject() { }
}
