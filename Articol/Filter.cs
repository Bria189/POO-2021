using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Articol
{
    class Filter
    {
        public static List<Articol> ByAuthor(List<Articol> articles, string author)
        {
            List<Articol> filteredList = new List<Articol>();

            for (int i = 0; i < articles.Count; i++)
            {
                if (articles[i].Authors.Contains(author))
                    filteredList.Add(articles[i]);
            }

            return filteredList;
        }

        public static List<Articol> ByTag(List<Articol> articles, string tag)
        {
            List<Articol> filteredList = new List<Articol>();

            for (int i = 0; i < articles.Count; i++)
            {
                if (articles[i].Tag == tag)
                    filteredList.Add(articles[i]);
            }

            return filteredList;
        }

        public static List<Articol> ByDatePosted(List<Articol> articles, DateTime startDate, DateTime endDate)
        {
            List<Articol> filteredList = new List<Articol>();

            for (int i = 0; i < articles.Count; i++)
            {
                DateTime dateToCheck = articles[i].DatePosted;

                if (dateToCheck >= startDate && dateToCheck <= endDate)
                    filteredList.Add(articles[i]);
            }

            return filteredList;
        }

        public static List<Articol> PostedOnWeekend(List<Articol> articles)
        {
            List<Articol> filteredList = new List<Articol>();

            for (int i = 0; i < articles.Count; i++)
            {
                if (articles[i].DatePosted.DayOfWeek == DayOfWeek.Saturday || articles[i].DatePosted.DayOfWeek == DayOfWeek.Sunday)
                {
                    filteredList.Add(articles[i]);
                }
            }
            return filteredList;
        }
    }
}
