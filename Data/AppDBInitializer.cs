using Fornecedores.Models;

namespace Fornecedores.Data
{
    public class AppDBInitializer
    { 
        public static void Seed(IApplicationBuilder applicationBuilder)
        {
            using (var serviceScope = applicationBuilder.ApplicationServices.CreateScope())
            {
                var context = serviceScope.ServiceProvider.GetService<AppCont>();
                context.Database.EnsureCreated();

                //Criar as Tarefas
                if (!context.Tarefas.Any())
                {
                    context.Tarefas.AddRange(new List<Fornecedor>()
                    {
                        new Fornecedor()
                        {
                            RazaoSocial = "Innovatech Solutions",
                            NomeFantasia = "Innovatech",
                            Email = "contact@innovatech.com",
                            Telefone = "(11) 98765-4321",
                            Logradouro = "Rua das Inovações",
                            Numero = 101,
                            Complemento = "Sala 305",
                            Bairro = "TecVille",
                            Cidade = "Tecnópolis",
                            Estado = "SP",
                            CEP = "12345-678",
                            NomePessoaContato = "Carlos da Silva"
                        },
                        new Fornecedor()
                        {
                            RazaoSocial = "Green Future Ltda",
                            NomeFantasia = "Green Future",
                            Email = "info@greenfuture.com",
                            Telefone = "(21) 99887-6654",
                            Logradouro = "Avenida Verde",
                            Numero = 789,
                            Complemento = "Bloco B, Apto 202",
                            Bairro = "EcoPark",
                            Cidade = "Sustentável City",
                            Estado = "RJ",
                            CEP = "87654-321",
                            NomePessoaContato = "Ana Oliveira"
                        },
                        new Fornecedor()
                        {
                            RazaoSocial = "CodeFactory Inc.",
                            NomeFantasia = "CodeFactory",
                            Email = "support@codefactory.io",
                            Telefone = "(31) 91234-5678",
                            Logradouro = "Alameda dos Desenvolvedores",
                            Numero = 456,
                            Complemento = "2º Andar",
                            Bairro = "TechLab",
                            Cidade = "Codeville",
                            Estado = "MG",
                            CEP = "54321-876",
                            NomePessoaContato = "Pedro Henrique"
                        },
                        new Fornecedor()
                        {
                            RazaoSocial = "Artisan Creations",
                            NomeFantasia = "Artisan",
                            Email = "hello@artisancreations.com",
                            Telefone = "(19) 99876-5432",
                            Logradouro = "Travessa das Artes",
                            Numero = 67,
                            Complemento = "Casa 4",
                            Bairro = "Inspiração",
                            Cidade = "Arte Nova",
                            Estado = "SP",
                            CEP = "65432-109",
                            NomePessoaContato = "Mariana Santos"
                        }
                    });
                    context.SaveChanges();
                }
            }
        }
    }

}
