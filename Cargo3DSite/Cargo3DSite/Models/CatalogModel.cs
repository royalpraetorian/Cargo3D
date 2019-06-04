using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Cargo3DSite.Models
{
    public class CatalogModel
    {

        private List<CreationDisplayModel> items = new List<CreationDisplayModel>();

        private int PageNum = 1;

        private int ItemsPerPage = 24;
        
        public List<CreationDisplayModel> ItemsToDisplay()
        {
            List<CreationDisplayModel> itemsDisplay = new List<CreationDisplayModel>();

            for (int i = 0; i < ItemsPerPage; i ++)
            {
                itemsDisplay.Add(items[(i + (PageNum * ItemsPerPage))]);
            }


            return itemsDisplay;
        }
        
        public void nextPage()
        {
            PageNum++;
        }

        public void prevPage()
        {
            PageNum--;
        }
    }
}