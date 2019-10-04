using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Outings_Repository
{
    public class Repository
    {
        //(<----------------Bring in List and make New------------------->)
        List<Content> _contentList = new List<Content>();
        public Repository()
        {

        }




        //(<----------------Add to List------------------->)

        public void AddNewOutings(Content content)
        {

            _contentList.Add(content);
        }


        public List<Content> GetOutingsList()
        {
            return _contentList;
        }

        //(<----------------Seed List------------------->)
        public List<Content> SeeAllOutings()
        {
            return _contentList;

        }

        public double CalcCostOfAllOutings()
        {

            double cost = 0;
            foreach (Content outing in _contentList)
            {
                cost = cost + outing.CalcComboCost;
            }
            return cost;
        }

        public double CalcCostByType(EventType type)
        {
            double cost = 0;


            foreach (Content outing in _contentList)
            {
                if(outing.Type == type)
                {
                    cost = cost + outing.CalcComboCost;

                }
               
            }
            return cost;
        }




        //double sum = pAmount * type1;

        //double pAmount = double.Parse(pAmount);
        //EventType type = EventType.Parse(type1);
        //double type1 = type;
        //return sum;






        //public void UpdateContentList()
        //{
        //    Content content = new Content

        //        content.Date = updatedContent.Date
        //}

        public void Seedlist()
        {
         

            Content content = new Content(1, EventType.Bowling, 68, new DateTime(2015, 10, 01), 8, 2000.00);
            Content contentTwo = new Content(1, EventType.Concerts, 47, new DateTime(2015, 10, 01), 8, 4000.00);
            Content contentThree = new Content(1, EventType.Amusementpark, 91, new DateTime(2015, 10, 01), 8, 9000.00);

            AddNewOutings(content);
            AddNewOutings(contentTwo);
            AddNewOutings(contentThree);



        }


    }
}
