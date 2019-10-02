using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Greetings_Repository
{

    public enum EventType { Current, Potential, Past }
    public class Content
    {
        public Content()
        {

        }

        public Content(string name, int pAttend, DateTime date, decimal pCost, decimal eventCost, EventType type)
        {
            Name = name;
            PAttend = pAttend;
            Date = date;
            PCost = pCost;
            EventCost = eventCost;
            Type = type




        }

        public string Name { get; set; }
        public int PAttend { get; set; }
        public DateTime Date { get; set; }
        public decimal PCost { get; set; }
        public decimal EventCost { get; set; }
        public EventType Type { get; set; }










    }













}
