
using System.Data;
using System.Globalization;

namespace Sqlmappimg.classes
{
    public  class CategoryCasas
    {
        public int Id_c { get; set; }
        public int ForeignKey_data_casa { get; set; }
        public string Business { get; set; }
        public string Localization { get; set; }
        public List<Data> dados_casa = new List<Data>();

        public CategoryCasas() { }
        public CategoryCasas(int id_c, string localization, int foreignKey_data_casa,string business)
        {
            Id_c = id_c;
            Localization = localization;
            ForeignKey_data_casa = foreignKey_data_casa;
            Business = business;
        }

        public  void ViewCasas()
        {
            if(dados_casa == null)
            {
                Console.WriteLine("Error, the list is empty.");
            }
            else
            {
                for(int i = 0; i < dados_casa.Count; i++)
                {
                    if (ForeignKey_data_casa == dados_casa[i].Id)
                    {
                        Console.WriteLine($"Id_d:{dados_casa[i].Id}");
                        Console.WriteLine($"Name:{dados_casa[i].Name}");
                        Console.WriteLine($"Description:{dados_casa[i].Description}");
                        Console.WriteLine($"Price:{dados_casa[i].Price.ToString("F4",CultureInfo.InvariantCulture)}");
                        Console.WriteLine();
                    }

                    else
                    {
                        Console.WriteLine($"Error the Foreign_key_data_casa {ForeignKey_data_casa} do not exist");
                        i = dados_casa.Count();
                    }
                }
            }
        }
        public override string ToString()
        {
            return "Id_c: " + Id_c + Environment.NewLine +
                   "Localization: " + Localization + Environment.NewLine +
                   "Business: " + Business;
        }


    }
}
