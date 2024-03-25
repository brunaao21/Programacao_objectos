using Sqlmappimg.classes;
namespace Project
{
    class Sqlmodel
    {
        static void Main(string[] args)
        {
            CategoryApartamento categoryApartamento = new CategoryApartamento();
            CategoryCasas categoryCasas = new CategoryCasas();
            CategorySitios categorySitios = new CategorySitios();



            int control = 1;
            while (control > 0)
            {
                Console.WriteLine("-------  IMÓVEIS -------------");
                Console.WriteLine();
                Console.WriteLine("1-Inserir Imóveis");
                Console.WriteLine();
                Console.WriteLine("2-Visualizar Imóveis.");
                Console.WriteLine();
                Console.Write("Escolha uma opção: ");
                int options = int.Parse(Console.ReadLine());
                Console.WriteLine();
                switch (options)
                {
                    case 1:
                        Console.WriteLine("---- Imóveis ------");
                        Console.WriteLine();
                        Console.WriteLine("1-Apartamento");
                        Console.WriteLine("2-Casas");
                        Console.WriteLine("3-Sítios");
                        Console.Write("Escolha uma opção: ");
                        int sub_options = int.Parse(Console.ReadLine());
                        Console.WriteLine();
                        switch (sub_options)
                        {
                            case 1:
                                Console.Write("Insira o id da tabela dados: ");
                                int id_data_p = int.Parse(Console.ReadLine());
                                Console.WriteLine();
                                Console.Write("Insira o id do apartamento: ");
                                int id_p = int.Parse(Console.ReadLine());
                                Console.WriteLine();
                                Console.Write("Informe a localidade do apartamento: ");
                                string local_p = Console.ReadLine();
                                Console.WriteLine();
                                Console.Write("Informa o tipo de negócio :");
                                string business_p= Console.ReadLine();
                                Console.WriteLine();
                                Console.Write("Insira o nome do apartamento: ");
                                string name_p = Console.ReadLine();
                                Console.WriteLine();
                                Console.Write("Insira a descrição: ");
                                string description_p = Console.ReadLine();
                                Console.WriteLine();
                                Console.Write("Insira o preço: ");
                                double price = double.Parse(Console.ReadLine());
                                Data data = new Data(id_data_p, name_p, description_p, price);
                                categoryApartamento = new CategoryApartamento(id_p, local_p, id_data_p,business_p);
                                categoryApartamento.data_ap.Add(data);
                                break;

                            case 2:
                                Console.Write("Insira o id da tabela dados: ");
                                int id_data_c = int.Parse(Console.ReadLine());
                                Console.WriteLine();
                                Console.Write("Insira o id da casa: ");
                                int id_c = int.Parse(Console.ReadLine());
                                Console.WriteLine();
                                Console.Write("Informe a localidade da casa: ");
                                string local_c = Console.ReadLine();
                                Console.WriteLine();
                                Console.Write("Informa o tipo de negócio :");
                                string business_c = Console.ReadLine();
                                Console.WriteLine();
                                Console.Write("Insira o nome da casa: ");
                                string name_c = Console.ReadLine();
                                Console.WriteLine();
                                Console.Write("Insira a descrição: ");
                                string description_c = Console.ReadLine();
                                Console.WriteLine();
                                Console.Write("Insira o preço: ");
                                double price_c = double.Parse(Console.ReadLine());
                                categoryCasas = new CategoryCasas(id_c, local_c, id_data_c,business_c);
                                Data data_c = new Data(id_c, name_c, description_c, price_c);
                                categoryCasas.dados_casa.Add(data_c);
                                break;

                            case 3:
                                Console.Write("Insira o id da tabela dados: ");
                                int id_data_s = int.Parse(Console.ReadLine());
                                Console.WriteLine();
                                Console.Write("Insira o id da tabela sítios: ");
                                int id_s = int.Parse(Console.ReadLine());
                                Console.WriteLine();
                                Console.Write("Insira o nome do sítio: ");
                                string name_s = Console.ReadLine();
                                Console.WriteLine();
                                Console.Write("Informe a localidade do sítio: ");
                                string local_s = Console.ReadLine();
                                Console.WriteLine();
                                Console.Write("Informa o tipo de negócio :");
                                string business_s = Console.ReadLine();
                                Console.WriteLine();
                                Console.Write("Insira a descrição: ");
                                string description_s = Console.ReadLine();
                                Console.WriteLine();
                                Console.Write("Insira o preço: ");
                                double price_s = double.Parse(Console.ReadLine());
                                categorySitios = new CategorySitios(id_s, local_s, id_data_s,business_s);
                                Data data_s = new Data(id_s, name_s, description_s, price_s);
                                categorySitios.dados_sitios.Add(data_s);
                                break;

                            default:
                                Console.WriteLine("Erro: Opção inválida.");
                                break;
                        }
                        break;

                    case 2:
                        Console.WriteLine();
                        Console.WriteLine("-------- VISUALIZAÇÃO --------");
                        Console.WriteLine();
                        Console.WriteLine("1-Apartamento");
                        Console.WriteLine("2-Casas");
                        Console.WriteLine("3-Sítios");
                        Console.WriteLine();
                        Console.Write("Escolha uma opção: ");
                        int options_sub = int.Parse(Console.ReadLine());
                        Console.WriteLine();
                        switch (options_sub)
                        {
                            case 1:
                                Console.WriteLine(categoryApartamento);
                                categoryApartamento.ViewApartment();
                                break;
                            case 2:
                                Console.WriteLine(categoryCasas);
                                categoryCasas.ViewCasas();
                                break;
                            case 3:
                                Console.WriteLine(categorySitios);
                                categorySitios.ViewSitios();
                                break;
                            default:
                                Console.WriteLine("Erro: Opção inválida.");
                                break;
                        }
                        break;

                    case 3:
                        Console.WriteLine("Olá");
                        break;

                }
                Console.WriteLine("Deseja continuar? [1-sim/0-Não]");
                int options_loop = int.Parse(Console.ReadLine());
                if (options_loop == 0)
                {
                    control = -1;
                }
                else
                {
                    control = 1;
                }

                Console.WriteLine("");

            }
        }
    }
}
