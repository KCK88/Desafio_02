using System;

namespace Desafio_02
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Quantos alunos?");
            var alunos = int.Parse(Console.ReadLine());
            
            var nomeDoAlunoComMaiorNota = "";
            var notaDoAlunoComMaiorNota = float.MinValue;
            for (var i = 0; i < alunos; i++)
            {
                Console.WriteLine("Nome do aluno?");
                var nomeAlunoAtual = Console.ReadLine();
                Console.WriteLine("Qual a nota?");
                var notaAlunoAtual = float.Parse(Console.ReadLine());
                if (notaAlunoAtual > notaDoAlunoComMaiorNota)
                {
                    notaDoAlunoComMaiorNota = notaAlunoAtual;
                    nomeDoAlunoComMaiorNota = nomeAlunoAtual;
                }
            }    
            Console.WriteLine(nomeDoAlunoComMaiorNota);        
        }


    }
}
