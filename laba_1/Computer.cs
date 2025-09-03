class Computer {
    public string model { get; init; }
    public string manufacture { get; init; }
    public int ram { get; set; }

    public Computer(string model, string manufacture, int ram)
    {
        this.model = model;
        this.manufacture = manufacture;
        this.ram = ram;             
    }

    public void changingRAM()
    {
        this.ram += 10;
    }

    public override string ToString()
    {
        return $"Модель: {this.model}\nПроизводитель: {this.manufacture}\nКол-во оперативной памяти:{this.ram}\n";
    }

}