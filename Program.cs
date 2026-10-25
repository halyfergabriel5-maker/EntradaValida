//Solicite que o usuário entre com um valor inteiro entre 1 e 9 (inclusive). Informe que a entrada 0 sinaliza um cancelamento. Não finalize o programa enquanto não houver uma entrada válida ou um cancelamento.

int num;
Console.Write("Digite um numero entre 1 e 9(0 siginifica um cancelamento): ");
num = int.Parse(Console.ReadLine()!);

if(num >= 1 && num <= 9)
{
    Console.WriteLine("volte sempre");
}
else{
        while(num != 0)
                {
                 Console.Write("Digite um numero entre 1 e 9(0 siginifica um cancelamento): ");
                 num = int.Parse(Console.ReadLine()!);
    
                }
}
