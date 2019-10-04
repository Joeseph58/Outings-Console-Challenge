using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Outings_Repository
{


    public enum EventType { Bowling, Concerts, Amusementpark, Golf }
    public class Content
    {
        public Content()
        {

        }

        public Content(int number, EventType type, double pAttend, DateTime date, double pCost, double eventCost)
        {
            Number = number;
            PAttend = pAttend;
            Date = date;
            PCost = pCost;
            EventCost = eventCost;
            Type = type;
            CalcComboCost = pCost * pAttend + eventCost;



        }

        public int Number { get; set; }
        public double PAttend { get; set; }
        public DateTime Date { get; set; }
        public double PCost { get; set; }
        public double EventCost { get; set; }
        public EventType Type { get; set; }
        public double CalcComboCost { get; set; }

    }
}