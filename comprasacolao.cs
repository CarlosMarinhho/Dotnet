using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        enum verdura { couve = 2, brocolis = 2, pera = 1, alho = 4, abobora = 5 }
        static void Main(string[] args)
        {
            string nome;
            int cont = 9, r = 0,rr=0;
            float carteira = 0.0f;
            int abobora = 0, alho = 0, brocolis = 0, couve = 0, pera = 0;
            
            Console.WriteLine("olá bem vindo ao sacolao,digite seu nome para começar");
             nome=Console.ReadLine();  //atribui o nome a pessoa
            Console.WriteLine("quanto $ há na sua carteira " +nome+"?");
            carteira = float.Parse(Console.ReadLine()); //atribui o valor a carteira
        
            Console.WriteLine("qual é o seu desejo hoje "+nome+"?");
            while(cont !=0) {
               
                //while para corrigir o preço da carteira
                while (carteira < 0) {
                       Console.WriteLine("Opa,você passou dos limites possuindo :$"+carteira+", quer tirar algum produto do seu carrinho ?\n  digite o numero respectivo ao produto para retira-lo:)");
                        r = int.Parse(Console.ReadLine());
                    if (r==1 && abobora>0) { carteira =carteira + (int)verdura.abobora;abobora = abobora - 1; }
                   else if (r == 2 && alho>0) { carteira = (int)verdura.alho + carteira; alho = alho - 1; }
                   else if (r == 3 && brocolis>0) { carteira = (int)verdura.brocolis + carteira; brocolis = brocolis - 1; }
                  else  if (r == 4 && couve >0) { carteira = (int)verdura.couve + carteira; couve = couve - 1; }
                  else  if (r == 5 && pera >0) { carteira = (int)verdura.pera + carteira; pera = pera - 1; }
                    else { Console.WriteLine("Ops,você fez algo de errado tente novamente :("); }

                }
                Console.WriteLine("" + nome + " voce possui :$" + carteira + " e  aboboras " + abobora + ", alhos " + alho + ", brocolis " + brocolis
                    + ", couves " + couve + ",peras " + pera + "");

                Console.WriteLine("digite 1 se você quer comprar uma " +verdura.abobora +" por :"+(int)verdura.abobora+"$");
                Console.WriteLine("digite 2 se você quer comprar uma " + verdura.alho + " por :" + (int)verdura.alho + "$");
                Console.WriteLine("digite 3 se você quer comprar uma " + verdura.brocolis + " por :" + (int)verdura.brocolis + "$");
                Console.WriteLine("digite 4 se você quer comprar uma " + verdura.couve + " por :" + (int)verdura.couve + "$");
                Console.WriteLine("digite 5 se você quer comprar uma " + verdura.pera + " por :" + (int)verdura.pera + "$");
                Console.WriteLine("digite 6 para retirar um produto");
                Console.WriteLine("digite 0 para sair");
                cont=int.Parse(Console.ReadLine());
                if (cont ==1)
                {
              carteira=carteira- (int)verdura.abobora;
                    abobora = abobora + 1;
                }
                 if (cont==2)
                {
                    carteira=carteira- (int)verdura.alho;
                    alho = alho + 1;
                }
                 if (cont==3)
                {
                    carteira = carteira - (int)verdura.brocolis;
                    brocolis = brocolis + 1;
                }
                if (cont == 4)
                {
                    carteira = carteira - (int)verdura.couve;
                    couve = couve + 1;
                }
                if (cont == 5)
                {
                    carteira = carteira - (int)verdura.pera;
                    pera = pera + 1;
                }
                if (cont ==6 )
                {
                    Console.WriteLine("Digite o numero do produto que deseja retirar: ");
                    rr = int.Parse(Console.ReadLine());
                    if (rr == 1 && abobora > 0) { carteira = carteira + (int)verdura.abobora; abobora = abobora - 1; }
                  else  if (rr == 2 && alho > 0) { carteira = (int)verdura.alho + carteira; alho = alho - 1; }
                  else  if (rr == 3 && brocolis > 0) { carteira = (int)verdura.brocolis + carteira; brocolis = brocolis - 1; }
                   else if (rr == 4 && couve > 0) { carteira = (int)verdura.couve + carteira; couve = couve - 1; }
                   else if (rr == 5 && pera > 0) { carteira = (int)verdura.pera + carteira; pera = pera - 1; }
                    else  { Console.WriteLine("Ops,você fez algo de errado tente novamente :("); }
                }
               
            }
            Console.WriteLine("Obrigado por comprar conosco " + nome + " volte sempre :)");
            Console.ReadLine();
        }
    }
}
