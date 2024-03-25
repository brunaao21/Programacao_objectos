
using System.Globalization;

namespace Sqlmappimg.classes
{
    public  class CategoryApartamento
    {
        public int Id_p { get; set; }
        public  int ForeignKey_ap_data { get; set; }

        public string Business { get; set; }
        public string Localization { get; set; }
        public List<Data> data_ap = new List<Data>();


        public CategoryApartamento() {
        }
        public CategoryApartamento(int id_p, string localization,int foreignKey_ap_data,string business)
        {
            Id_p = id_p;
            Localization = localization;
            ForeignKey_ap_data = foreignKey_ap_data;
            Business = business;
        }

      
       public void ViewApartment()
        {
            if (data_ap == null)
            {
                Console.WriteLine("Error, the list is empty.");
            }
            else
            {
                for (int i = 0; i < data_ap.Count; i++)
                {
                    if (ForeignKey_ap_data == data_ap[i].Id)
                    {
                        Console.WriteLine($"Id_d:{data_ap[i].Id}");
                        Console.WriteLine($"Name:{data_ap[i].Name}");
                        Console.WriteLine($"Description:{data_ap[i].Description}");
                        Console.WriteLine($"Price:{data_ap[i].Price.ToString("F2", CultureInfo.InvariantCulture)}");
                        Console.WriteLine();
                    }
                    else
                    {
                        Console.WriteLine($"Error, ForeignKey_ap_data {ForeignKey_ap_data} do not exist !");
                        i = data_ap.Count();
                    }
                }
             
            }
        }

        public override string ToString()
        {
            return "Id_p: " + Id_p + Environment.NewLine +
                   "Localization: " + Localization + Environment.NewLine +
                   "Business: " + Business;
        }



    }
}
