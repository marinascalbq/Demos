using static System.Console;
public class Program
{


    static void Demo6()
{
        int [] numeros = new int [] {0,2,4,6,8};
        WriteLine ($"Digite o numero que gostaria de encontrar");
        var numero = int.Parse(ReadLine());
        var idxEncontrado = EncontrarNumeros(numeros, numero);
        if (idxEncontrado >= 0)
        {
        WriteLine($"O número encontrado está na posição {idxEncontrado}");
        }
        else
        {
            WriteLine("O número não foi encontrado");
        }
}
    static void Demo5()
    {
          int [] pares = new int[] {0,2,4,6,8};
     
    mudarParaImpar(pares);

    WriteLine($"Os Impares {string.Join("," , pares)}");
    }

    static void Demo4()
    {
    string nome = "Marina";

    TrocarNome(nome, "Anderson");

    WriteLine($"O novo nome é {nome}");

    }

    static Pessoa TrocarNome(Pessoa p1, string nomeNovo)
    {
        p1.Nome = nomeNovo;
        return p1;
    }
    static void Demo3()
    {
         Pessoa p1 = new Pessoa()
        {
            Documento="1234",
            Idade = 25,
            Nome = "Marina"
            
        };
        var p2 = p1;

        p1 = TrocarNome(p1, "João");
        WriteLine($@"
        Nome do P1: {p1.Nome}
        Nome do P2: {p2.Nome}
        ");

    }
    
    static void Demo2()
    {
       Pessoa p1 = new Pessoa();
       p1.Nome="Marina";
       p1.Idade=28;
       p1.Documento="6789";

       Pessoa p2 = p1.Clone();

        TrocarNome(p1, "José");

        WriteLine($@"
        O nome de P1 é :{p1.Nome}
        O nome de P2 é :{p2.Nome}
        ");

    }
    static void Demo1()
    {

         int a = 2;
         a = Adicionar20(a);

         WriteLine($"O valor da variável a é: {a}");

    }
        static int Adicionar20 (int x)
    {
        return  x + 20;
    }

    static void TrocarNome(string nome, string nomeNovo)
    {
        nome= nomeNovo;
    }

    static void mudarParaImpar (int[] pares)
    {
        for (int i = 0; i < pares.Length; i++)
        {
            pares[i] = pares[i] + 1;
        }
    }

    static int EncontrarNumeros(int[] numeros, int numero)
    {
    for (int i = 0; i<numeros.Length;i++)
    {
        if (numeros[i] == numero)
            return i;
    } 
    return -1;
    }

static bool EncontrarPessoa(List<Pessoa> pessoas, Pessoa pessoa)
{
    foreach (var item in pessoas)
    {
        if ( item.Nome == pessoa.Nome)
            {
            return true;
            }
   }
return false;
    }

static bool EncontrarPessoa (List < StrucPessoa > pessoas, StrucPessoa pessoa)
{
    foreach (var item in pessoas)
    {
        if (item.Equals(pessoa))

            {
            return true;
            }
   }
return false;
    }


    public static void Main ()
    {
     List <StrucPessoa> pessoas = new List <StrucPessoa>()
     {

         new StrucPessoa() { Nome = "Ricardo"},
         new StrucPessoa() { Nome = "Anderson"},
         new StrucPessoa() { Nome = "Marina"},
         new StrucPessoa() { Nome = "Marluce"},
         new StrucPessoa() { Nome = "Marcio"},
     };

     WriteLine ("Digite a pessoa que gostaria de localizar: ");
     var nome = ReadLine();
     var pessoa = new StrucPessoa() { Nome = nome };
    var encontrado = EncontrarPessoa ( pessoas , pessoa);
    if (encontrado)
            {
        WriteLine("Pessoa localizada! ");
            }
    else
            {
    WriteLine("Pessoa não encontrada");
            }

    }
}