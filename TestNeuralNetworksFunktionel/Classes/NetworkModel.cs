﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

//layer methode / classe vervollständigen
namespace Classes
{
    public class NetworkModel
    {
        public List<NeuralLayer> Layers { get; set; }

        public NetworkModel()
        {
            Layers = new List<NeuralLayer>();
        }

        public void AddLayer(NeuralLayer layer)
        {
            int dendriteCount = 1;

            if (Layers.Count > 0)
            {
                dendriteCount = Layers.Last().Neurons.Count;
            }

            foreach(var element in layer.Neurons)
            {
                for(int i = 0; i < dendriteCount; i++)
                {
                    element.Dendrites.Add(new Dendrite());
                }
            }
        }

        public void Build()
        {
            int i = 0;
            foreach (var layer in Layers)
            {
                if (i >= Layers.Count - 1)
                {
                    break;
                }

                var nextLayer = Layers[i + 1];
                CreateNetwork(layer, nextLayer);

                i++;
            }
        }

        public void Train(NeuralData X, NeuralData Y, int iterations, double lerningRate = 0.1)
        {
            int epoch = 1;
            //Loop till the number of iterations
            while (iterations >= epoch)
            {
                //Get the input layers
                var inputLayer = Layers[0];
                List<double> outputs = new List<double>();

                //Loop through the record
                for (int i = 0; i < X.Data.Length; i++)
                {
                    //Set the input data into the first layer
                    for (int j = 0; j < X.Data[i].Length; j++)
                    {
                        inputLayer.Neurons[j].outputPulse.value = X.Data[i][j];
                    }

                    //Fire all the neurons and collect the output
                    ComputeOutput();
                    outputs.Add(Layers.Last().Neurons.First().outputPulse.value);
                }

                //Check the accuracy score against Y with the actual output
                double accuracySum = 0;
                int y_counter = 0;
                outputs.ForEach((x) =>
                {
                    if (x == Y.Data[y_counter].First())
                    {
                        accuracySum++;
                    }

                    y_counter++;
                });

                //Optimize the synaptic weights
                //OptimizeWeights(accuracySum / y_counter); TODO: Hinzufügen 
                Console.WriteLine("Epoch: {0}, Accuracy: {1} %", epoch, (accuracySum / y_counter) * 100);
                epoch++;
            }
        }

        private void OptimizeWeights(double accuracy)
        {
            float lr = 0.1f;
            //Skip if the accuracy reached 100%
            if (accuracy == 1)
            {
                return;
            }

            if (accuracy > 1)
            {
                lr = -lr;
            }

            //Update the weights for all the layers
            foreach (var layer in Layers)
            {
                //layer.Optimize(lr, 1);  TODO: hinzufügen
            }
        }


        private void ComputeOutput()
        {
            bool first = true;
            foreach (var layer in Layers)
            {
                //Skip first layer as it is input
                if (first)
                {
                    first = false;
                    continue;
                }

                layer.Forward();
            }
        }

        public void Print()
        {

            DataTable dt = new DataTable();
            dt.Columns.Add("Name");
            dt.Columns.Add("Neurons");
            dt.Columns.Add("Weight");

            foreach (var element in Layers)
            {
                DataRow row = dt.NewRow();
                row[0] = element.Name;
                row[1] = element.Neurons.Count;
                row[2] = element.Weight;

                dt.Rows.Add(row);
            }

            //ConsoleTableBuilder builder = ConsoleTableBuilder.From(dt);
            //builder.ExportAndWrite();
        }

        private void CreateNetwork(NeuralLayer connectingFrom, NeuralLayer connectingTo)
        {
            foreach (var to in connectingTo.Neurons)
            {
                foreach (var from in connectingFrom.Neurons)
                {
                    to.Dendrites.Add(new Dendrite() { InputPulse = to.outputPulse, SynapticWeight = connectingTo.Weight });
                }
            }
        }
    }
}
