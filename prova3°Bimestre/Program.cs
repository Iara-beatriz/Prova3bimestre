using prova3_Bimestre;

while (true)
{
    Console.WriteLine("Digite seu Nome: ");
    string nome = Console.ReadLine();
    DateTime data = DateTime.Now;

    Console.WriteLine("Selecione o seu usuário: ");
    Console.WriteLine("1 - médico");
    Console.WriteLine("2 - FunAdm");
    int opcao = Convert.ToInt32(Console.ReadLine());

    if(opcao == 1)
    {
        List<médico> list = new List<médico>();
        médico m = new médico(nome, "066.301512.08", data, "feminino", 1.500);
        m.recebimento();
    }
    else if(opcao == 2)
    {
        List<funAdm> list = new List<funAdm>();
        funAdm c = new funAdm(nome, "064.512.765.15", data, "Masculino", 1.350);
       c.recebimentoo();
    }
}