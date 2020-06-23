using System;
using System.Collections.Generic;

namespace Aula
{
    class Program
    {
        static void Main(string[] args)
        {

            //PRODUTO

            //Lista de Produtos
            List<Produto> produtos = new List<Produto>();

            //Produto Simples
            Produto celular1 = new Produto();
            celular1.Codigo = 1;
            celular1.Nome = "Redmi Note 9";
            celular1.Preco = 3499.99f;

            //Adicionar produto na lista
            produtos.Add(celular1);

            //Adicionar mais produtos:
            produtos.Add( new Produto(2, "Galaxy", 2500.99f));
            produtos.Add( new Produto(3, "Redmi 9", 2500.99f));
            produtos.Add( new Produto(4, "Moto G", 2500.99f));
            produtos.Add( new Produto(5, "Lenovo", 2500.99f));

            //Varrer listas com laço foreach
            foreach(Produto p in produtos){
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine($"RS {p.Preco} - {p.Nome}");
            Console.ResetColor();
            }

            //Remove item específico
            produtos.Remove(celular1);

            //Remove atráves de um índice
            produtos.RemoveAt(1);

            System.Console.WriteLine();

            //Removemos atráves da expressão Lambda
            produtos.RemoveAll( p => p.Nome == "Galaxy" );

            //Lista alterada
            foreach(Produto p in produtos){
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine($"RS {p.Preco} - {p.Nome}");
                Console.ResetColor();
            }
            System.Console.WriteLine();

            //Procurando produto específico
            Produto lenovo = produtos.Find( x => x.Nome == "Lenovo" );

            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine( lenovo.Preco );
            Console.ResetColor();

            System.Console.WriteLine();

//-------------------------------------------------------------------------------//
//-------------------------------------------------------------------------------//
            //CARTAO 
            //Instanciar a lista Cartao
            List<Cartao> cartaos = new List<Cartao>();

            //Adicionar a lista
            cartaos.Add( new Cartao(1, "Tiago", 123, "Bradesco", 12/12/25, 231));
            cartaos.Add( new Cartao(2, "Marcelo", 223, "Bradesco", 12/12/25, 331));
            cartaos.Add( new Cartao(3, "Pedro", 323, "Bradesco", 12/12/25, 431));
            cartaos.Add( new Cartao(4, "Paulo", 423, "Bradesco", 12/12/25, 531));

            //Varrer foreach
            foreach(Cartao c in cartaos){
                
                Console.ForegroundColor = ConsoleColor.Cyan;
                Console.WriteLine($"Titular: {c.Titular} - Número: {c.Numero} - Bandeira: {c.Bandeira} - Vencimento: {c.Vencimento} - CVV: {c.Cvv}");
                Console.ResetColor();

            }
            
            //Pegar Cartao Tiago via Lambda
            Cartao tiago = cartaos.Find( t => t.Titular == "Tiago");

            Console.ForegroundColor = ConsoleColor.DarkYellow;
            Console.WriteLine( tiago.Titular );
            Console.WriteLine( tiago.Numero );
            Console.ResetColor();

            //Puxar a partir do CodLista
            int Cod = Int32.Parse(Console.ReadLine());
            
            Cartao listado = cartaos.Find( l => l.CodLista == Cod );
            Console.ForegroundColor = ConsoleColor.DarkGreen;
            Console.WriteLine($"Titular: {listado.Titular}");
        }
    }
}
