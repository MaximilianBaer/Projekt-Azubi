using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Domain;
using Domain.Acces;

namespace KIzuna
{
    public class KIzunaAI
    {
        public static void Decide()
        {
            Acces.DeciData.Tolerance = 5; //TODO: Nach Hinzufügen der Lernmethode entfernen
            DecideStage1();
        }

        #region Stage1
        private static void DecideStage1()
        {
            foreach (Data data in Acces.DataSet)
            {
                var groupOfAmmount = EvaluateGroupOfAmmountStage1(data.Menge);
                var groupOfValue = EvaluateGroupOfValueStage1(data.Wert*data.Menge);
                var same = CompareGoup(groupOfValue, groupOfAmmount);
                //TODO: Auslagern
                if (same)
                {
                    GroupedData dat = new GroupedData() { Data = data, Group = groupOfAmmount };
                    Acces.groupedData.Add(dat);
                }
                else
                {
                    DecideStage2(data, groupOfValue, groupOfAmmount);
                }
            }
            var a = Acces.groupedData;//TODO: Entfernen
        }

        private static int EvaluateGroupOfAmmountStage1(int amount)
        {
            int completeAmount = Acces.DataSet.Sum(a => a.Menge);
            double percent = 100 * (Convert.ToDouble(amount) / Convert.ToDouble(completeAmount));
            var i = 0;
            List<int> listamount = new List<int>();
            listamount = Acces.Setting.Amount;
            foreach (var data in listamount)
            {
                if (percent <= data)
                {
                    return i;
                }
                i++;
            }
            return i--;
        }

        private static int EvaluateGroupOfValueStage1(int value)
        {
            int completeValue = Acces.DataSet.Sum(a => a.Wert * a.Menge);
            double percent = 100 * (Convert.ToDouble(value) / Convert.ToDouble(completeValue));
            var i = 0;
            foreach (var data in Acces.Setting.Values)
            {
                if (percent >= data)
                {
                    return i;
                }
                i++;
            }
            return i--;
        }

        private static bool CompareGoup(int groupOfValue, int groupOfAmmount)
        {
            return groupOfAmmount == groupOfValue;
        }
        #endregion

        #region Stage2
        private static void DecideStage2(Data data, int groupValue, int groupAmount)
        {
            var groupDictance = groupAmount - groupValue;
            int? group = null;
            //TODO: auslagern
            if (groupDictance == 1 || groupDictance == -1)
            {
                LetKIzunaDecide(data, groupValue, groupAmount);            
            }
            else
            {
                if(groupDictance > 0)
                {
                    group = groupValue;
                    GroupedData dat = new GroupedData() { Data = data, Group = Convert.ToInt32(group)};
                    Acces.groupedData.Add(dat);
                }
                else
                {
                    //TODO: add Groupe Diffenrence bigger 1
                }
            }


        }

        private static void LetKIzunaDecide(Data data, int groupValueOld, int groupAmmountOld)
        {
            int groupAmmount = EvaluateGroupOfAmmountStage2(data.Menge);
            int groupValue = EvaluateGroupOfValueStage2(data.Wert);
            var same1 = CompareGoup(groupValue, groupAmmountOld);
            var same2 = CompareGoup(groupAmmount, groupValueOld );
            //TODO: Auslagern



            if(same1 == same2)
            {
                DecideStage3(data);
                var a = 2 + 2; //HINWEIS: Abfangen von fehlern
            }

            if (same1)
            {
                GroupedData dat = new GroupedData() { Data = data, Group = groupValue };
                Acces.groupedData.Add(dat);
            }
            else if (same2)
            {
                GroupedData dat = new GroupedData() { Data = data, Group = groupAmmount };
                Acces.groupedData.Add(dat);
            }

        }

        private static int EvaluateGroupOfValueStage2(int value)
        {
            int completeValue = Acces.DataSet.Sum(a => a.Wert * a.Menge);
            double percent = (100 * (Convert.ToDouble(value) / Convert.ToDouble(completeValue))) + Acces.DeciData.Tolerance;
            var i = 0;
            foreach (var data in Acces.Setting.Values)
            {
                if (percent >= data)
                {
                    return i;
                }
                i++;
            }
            return i--;
        }

        private static int EvaluateGroupOfAmmountStage2(int ammount)
        {
            int completeAmount = Acces.DataSet.Sum(a => a.Menge);
            double percent = 100 * ((Convert.ToDouble(ammount) / Convert.ToDouble(completeAmount))) + Acces.DeciData.Tolerance;
            var i = 0;
            List<int> listamount = new List<int>();
            listamount = Acces.Setting.Amount;
            foreach (var data in listamount)
            {
                if (percent <= data)
                {
                    return i;
                }
                i++;
            }
            return i--;
        }

        #endregion

        #region Stage3
        private static void DecideStage3(Data data)
        {
            //TODO: Erweitern (Prioritäten enfügen)
            throw new NotImplementedException();
        }
        #endregion

        #region Learn
        public void Learn()
        {

            //TODO: KIzuna das Lernen beibringen

        }
        #endregion
        /*
         .-.-.-.-.-.-.-.-.-.-.-.-.-.
        (   .   .   .   .   .   .   )
        (                           )
        ( .   .   .   .   .   .   . )
        (                           )
        (   .   .   .   .   .   .   )
        (                           )
        ( .   .   .   .   .   .   . )
        (                           )
         '-'-'-'-'-'-'-'-'-'-'-'-'-' 
         * 
         * 
         * 
         */
    }
}
