internal class Toyota :  IGasolineEngine, IBreakable {
    private float capacity;

    internal Toyota(float c) {
        this.capacity = c;
    }

    public void Start() { }
    public void TurnOff() { }
    public void Inject() { }
    public void Brake() { }
}
