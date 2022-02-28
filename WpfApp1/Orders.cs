using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfApp1
{
    public class Orders
    {
        public string Title { get; set; }

        //
        public int Lenght { get; set; }
        public int Width { get; set; }


        public bool Bracing { get; set; }
        public bool GiftPackaging { get; set; }


        //холст
        public int PeopleCount { get; set; }
        public bool ReplaceClothes { get; set; }
        public int Background { get; set; }
        public bool Animals { get; set; }

        //дополнительно
        public string PersonalWishes { get; set; }
        public CustomersData Delivery { get; set; }

        public int TotalPrice { get; set; }
    }
}
