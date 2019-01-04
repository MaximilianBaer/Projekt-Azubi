using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classes
{
    public class Neuron
    {
        public List<Dendrite> Dendrites { get; set; }

        public Pulse outputPulse { get; set; }

        private double Weight;

        public Neuron()
        {
            Dendrites = new List<Dendrite>();
            outputPulse = new Pulse();
        }

        public void Fire()
        {
            outputPulse.value = Sum();

            outputPulse.value = Activation(outputPulse.value);
        } 

        public void Compute(double learningrate, double delta)
        {
            Weight += learningrate * delta;
            foreach (var terminal in Dendrites)
            {
                terminal.SynapticWeight = Weight;
            }
        }

        private double Sum()
        {
            double computeValue = 0.0f;
            foreach(var d in Dendrites)
            {
                computeValue += d.InputPulse.value * d.SynapticWeight;
            }
            return computeValue;
        }

        private double Activation(double input)
        {
            double threshold = 1;
            return input >= threshold ? 0 : threshold;
        }
    }
}
