using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Domain
{
    [Serializable]
    public class Settings
    {
        public int Seperations { get; set; }
        public List<int> Amount { get; set; }
        public List<int> Values { get; set; }

        public void SaveLocal(DataGridViewCellCollection value, DataGridViewCellCollection amount, int seperations)
        {
            Amount = new List<int>();
            Values = new List<int>();
            foreach (DataGridViewTextBoxCell cell in value)
            {
                Values.Add(Convert.ToInt32(cell.Value));
            }
            foreach (DataGridViewTextBoxCell cell in amount)
            {
                Amount.Add(Convert.ToInt32(cell.Value));
            }
            Seperations = seperations;
        }
    }
    public enum ABC
    {
        A = 0,
        B = 1,
        C = 2,
        D = 3,
        E = 4,
        F = 5,
        G = 6,
        H = 7,
        I = 8,
        J = 9,
        K = 10,
        L = 11,
        M = 12,
        N = 13,
        O = 14,
        P = 15,
        Q = 16,
        R = 17,
        S = 18,
        T = 19,
        U = 20,
        V = 21,
        W = 22,
        X = 23,
        Y = 24,
        Z = 25
    }
}
