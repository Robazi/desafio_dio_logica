string nome = "Homem Aranha";
string nivel = "";
int XP = 1000001;

switch(XP){
    case <= 1000:
       nivel = "Ferro";
    break;

    case <= 2000:
        nivel = "Bronze";
    break;

    case <= 5000:
        nivel = "Prata";
    break;

    case <= 7000:
        nivel = "Ouro";
    break;

    case <= 8000:
        nivel = "Platina";
    break;

    case <= 9000:
        nivel = "Ascendente";
    break;

    case <= 10000:
        nivel = "Imortal";
    break;

    case > 10000:
        nivel = "Radiante";
    break;
}
    System.Console.WriteLine($"O Herói de nome {nome} está no nível {nivel}");