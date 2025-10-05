using System;
using System.Collections.Generic;

namespace laba_5
{
    public class ComboDevice : ISensor, IActuator
    {
        public string Id { get; set; }
        public double LastMeasurement { get; set; }
        public bool IsOn { get; set; }

        public ComboDevice(string id)
        {
            Id = id;
            LastMeasurement = 0;
            IsOn = false;
        }

        public void Report(IController controller)
        {
            controller.Route(this, this);
        }

        public void ReceiveCommand(IController controller, string command)
        {
            if (command == "On" && !IsOn)
            {
                IsOn = true;
                Console.WriteLine($"{Id}: включён");

            }
            else if ((command == "Off") && IsOn)
            {
                IsOn = false;
                Console.WriteLine($"{Id}: выключён");
            }
            else
            {
                Console.WriteLine($"{Id}: команда {command} проигнорирована");
            }
        }

        public void UpdateMeasurement(double value)
        {
            LastMeasurement = value;
        }

    }
}