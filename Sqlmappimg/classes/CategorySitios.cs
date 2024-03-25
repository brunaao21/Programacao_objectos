
using System.Globalization;

namespace Sqlmappimg.classes
{
    public  class CategorySitios
    {
        public int Id_s { get; set; }

        public string Business { get; set; }
        public int ForeignKey_sitios_data { get; set; }
        public string Localization { get; set; }
        public List<Data> dados_sitios = new List<Data>();


        public CategorySitios() { }
        public CategorySitios(int id_s, string localization, int foreignKey_sitios_data, string business)
        {
            Id_s = id_s;
            Localization = localization;
            ForeignKey_sitios_data = foreignKey_sitios_data;
            Business = business;
        }

        public void ViewSitios()
        {
            if (dados_sitios == null)
            {
                Console.WriteLine("Error, the list is empty.");

            }
            else
            {
                for(int i = 0; i < dados_sitios.Count; i++)
                {
                    if (ForeignKey_sitios_data == dados_sitios[i].Id) {
                        Console.WriteLine($"Id_d:{dados_sitios[i].Id}");
                        Console.WriteLine($"Name:{dados_sitios[i].Name}");
                        Console.WriteLine($"Description:{dados_sitios[i].Description}");
                        Console.WriteLine($"Price:{dados_sitios[i].Price.ToString("F2",CultureInfo.InvariantCulture)}");
                        Console.WriteLine();
                    }
                    else
                    {
                        Console.WriteLine($"Error, the ForeignKey_sitios_data {ForeignKey_sitios_data} do not exist..");
                        i = dados_sitios.Count();
                    }
                }
            }
        }
        public override string ToString()
        {
            return "Id_s: " + Id_s + Environment.NewLine +
                   "Localization: " + Localization + Environment.NewLine +
                   "Business: " + Business;
        }


    }
}
