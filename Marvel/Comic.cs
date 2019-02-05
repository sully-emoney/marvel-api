using System;
using System.Collections.Generic;

namespace Marvel
{
    public class Comic
    {
        public string Title { get; set; }
        public DateTime SaleDate { get; set; }

        /// <summary>
        /// Limited to the 1 comic ordered by Name Ascending
        /// </summary>
        /// <param name="title"></param>
        /// <returns></returns>
        public static Comic GetComic(string title)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Limited to the top 5 comics ordered by Name Ascending
        /// </summary>
        /// <param name="character"></param>
        /// <returns></returns>
        public static List<Comic> GetComics(Character character)
        {
            throw new NotImplementedException();
        }
    }
}
