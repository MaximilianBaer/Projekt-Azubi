using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain
{
    public class Question : Entity
    {
        public string text { get; set; }
        public questionType type { get; set; }

        public Survey surveyID { get; set; }

        public void AddQuestion()
        {

        }




        public enum questionType{
            Freitext = 0,
            MultipleChoice = 1
        }
    }
}
