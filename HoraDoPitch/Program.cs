using HoraDoPitch;

Alarme alarme = new Alarme();

string resposta = "S";
while (resposta != "N")
{
    Console.Clear();
    Console.WriteLine("A Hora do Pitch vai começar em breve!");
    Console.Write("Defina o tempo para o alarme disparar (em minutos): ");
    int tempo = int.Parse(Console.ReadLine() ?? "0");

    alarme.Tempo = tempo;
    alarme.Iniciar();
    Console.WriteLine("Hora do Pitch! Seu tempo acabou!");

    Console.Write("Deseja definir outro alarme? (S/N): ");
    resposta = Console.ReadLine()?.ToUpper() ?? "N";
}

Console.WriteLine("Programa encerrado.");
