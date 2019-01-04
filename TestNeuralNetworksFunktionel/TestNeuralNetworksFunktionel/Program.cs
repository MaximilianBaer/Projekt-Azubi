using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Classes;

namespace TestNeuralNetworksFunktionel
{
    class Program
    {
        static void Main(string[] args)
        {
            Classes.NetworkModel model = new NetworkModel();
            model.Layers.Add(new NeuralLayer(2, 0.1, "INPUT"));
            model.Layers.Add(new NeuralLayer(2, 0.1, "HIDDEN"));
            model.Layers.Add(new NeuralLayer(1, 0.1, "OUTPUT"));

            model.Build();
        }

        private double sigmoid(double x)
        {
            return 1.0 / (1 + Math.Exp(-x));
        }

        private double sigmoid_derivative(double x)
        {
            return x * (1.0 - x);
        }
    }
}
