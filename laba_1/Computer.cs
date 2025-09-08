class Computer {
    public string Model { get; init; }
    public string Manufacture { get; init; }
    public int Ram { get; set; }

    public Computer(string model, string manufacture, int ram)
    {
        this.Model = model;
        this.Manufacture = manufacture;
        this.Ram = ram;             
    }

    public void ChangingRAM(int count)
    {
        this.Ram += count;
    }

    public override string ToString()
    {
        return $"Модель: {this.Model}\nПроизводитель: {this.Manufacture}\nКол-во оперативной памяти:{this.Ram}\n";
    }

}