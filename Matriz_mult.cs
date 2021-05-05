using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Matriz_mult
    {

        static void Main()
        {

            /*array de duas dimensões*/
            string[,] aluno = new string[3, 3];


            // Atribuir 
                /*coluna 0 nome
                 * coluna 1 sexo
                 * coluna 2 email
                 */
            aluno[0, 0] = "edeson";
            aluno[0, 1] = "m";
            aluno[0, 2] = "edeson@senac.com";

            aluno[1, 0] = "brito";
            aluno[1, 1] = "m";
            aluno[1, 2] = "brito@gg.com";

            aluno[2, 0] = "caio";
            aluno[2, 1] = "m";
            aluno[2, 2] = "caio@24.com";


            Console.WriteLine(aluno[1, 0]);

            for (int linha = 0; linha < 3; linha++)
            {


                for(int coluna = 0; coluna < 3; coluna++){
                Console.Write(aluno[linha, coluna]+ "");

                }

                Console.WriteLine("----");

            }

            
                Console.Read();







        }


    }
}
