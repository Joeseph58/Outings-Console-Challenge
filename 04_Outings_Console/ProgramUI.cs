using Outings_Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04_Outings_Console
{
    internal class ProgramUI
    {
        Repository _contentList = new Repository();


        public ProgramUI()
        {

        }
        //run menu
        public void Run()
        {
            _contentList.Seedlist();
            RunMenu();

        }
        //Menu
        public void RunMenu()
        {


            bool ContinueToRun = true;
            while (ContinueToRun)
            {

                Console.WriteLine("Welcome to the Claims Center. Enter the Menu Choice You would like.\n" +
                    "1. See All Outings\n" +
                    "2. Add a new Outing\n" +
                    "3. Calculate cost of event\n" +
                    "4. Exit\n");

                string userInput = Console.ReadLine();

                switch (userInput)
                {
                    case "1":
                        SeeAllOutings();
                        break;
                    case "2":
                        AddNewOutings();
                        break;
                    case "3":
                        CalcOutings();
                        break;
                    case "4":
                        ContinueToRun = false;
                        break;


                }

            }

        }


        public void SeeAllOutings()
        {
            List<Content> content = _contentList.GetOutingsList();
            Console.WriteLine();
            foreach (Content content1 in content)
            {
               Console.WriteLine($"\n" +
                   $"{content1.Number}-\n" +
                   $"{content1.Type}-" +
                   $"{content1.PAttend}-" +
                   $"{content1.Date}-" +
                   $"{content1.PCost}-" +
                   $"{content1.EventCost}");


            }
            Console.ReadKey();
        }
        

        public void AddNewOutings()
        {

            Console.WriteLine("Enter outing id number");
            string number1 = Console.ReadLine();
            int number = int.Parse(number1);

            Console.WriteLine("Enter the Outing Type");
            string type1 = Console.ReadLine();
            EventType type = (EventType)int.Parse(type1);

            Console.WriteLine("Number of people attending");
            string pattend = Console.ReadLine();
            double pAttent = double.Parse(pattend);

            Console.WriteLine("Enter the date of the event outing");
            string date1 = Console.ReadLine();
            DateTime date = DateTime.Parse(date1);

            Console.WriteLine("Enter the cost per person");
            string pcost = Console.ReadLine();
            double pCost = double.Parse(pcost);

            Console.WriteLine("Enter event Cost");
            string eventcost = Console.ReadLine();
            double eventCost = double.Parse(eventcost);



        }
        // this is for lawrance
        public void CalcOutings()
        {
            EventCosts();

        }

        //public void UpdateContentList()
        //{
        //    Content content = new Content();

        //    Content updateContent = new Content(???);
        //    _contentList.UpdateContentList();

        //    Assert.AreEqual(content.Date)

        //}

        //public void CombinedCostsAllEvents()
        //{
        //    List<Content> outingList = _contentList.GetOutingsList();
        //    decimal cost = outingList.Sum(outing => outing.TotalCost);
        //    Console.WriteLine($"The combined total cost of the event is {cost}\n");
        //    Console.WriteLine("Press any key to continue...");
        //    Console.ReadKey();
        //    Console.Clear();
        //}


        public void EventCosts()
        {
            List<Content> outingList = _contentList.GetOutingsList();

            Console.WriteLine("Enter the number of the costs you would like to see: \n" +
                "1. Combined cost of all outings\n" +
                "2. Outing cost by type\n" +
                "3. Return to menu\n");
            string userInput = Console.ReadLine();
            Console.Clear();
            switch (userInput)
            {
                case "1":
                    double cost = _contentList.CalcCostOfAllOutings();
                    Console.WriteLine(cost);
                    Console.ReadKey();
                    break;
                case "2":
                    Console.WriteLine("Please enter the event type 'example' 1-4 ");
                    string userInput2 = Console.ReadLine();
                    EventType event1 = (EventType)int.Parse(userInput2);

                    double cost1 = _contentList.CalcCostByType(event1);
                    Console.WriteLine(cost1);
                    Console.ReadKey();
                    break;
                case "3":
                    break;
            }
        }
        //display a list of all outings


        //add individual outings to a list(dont need to delete)

        //calculations combined cost for all outings
        //    see a display of all outing cost by tybe
        //    ex.--$2000.00 for all bowling outings for 1 year
        //        conserts were $5000.00

    }
}
