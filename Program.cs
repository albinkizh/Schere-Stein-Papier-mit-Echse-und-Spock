enum Choices
{
    Schere,
    Stein,
    Papier,
    Echse,
    Spock
}
class test
{
    static void Main(string[] args)
    {
        int Spielergewinnanzahl = 0;
        int Martinggewinnanzahl = 0;
        int Runden = 0;



        do
        {

            var bans = new List<Choices> { Choices.Schere, Choices.Stein, Choices.Papier, Choices.Spock, Choices.Echse };
            int index = Random.Shared.Next(bans.Count);
            Console.WriteLine("Willkommen zum Schere-Stein-Papier mit Echse und Spock Spiel \nKannst du Martin besiegen? \nWas ist deine Wahl? (Schere, Stein, Papier, Echse, Spock)");
            string ans = Console.ReadLine();
            Enum.TryParse(ans, out Choices userchoice);


            if (userchoice == bans[index]) //Hier du kekkkkkkkkkkkkkkkkkkkkkkkkkkkkkkkkkkkkkkkkkkkkkkkkkkkkkkkkkkkkkkkkkkkk
            {
                Console.WriteLine("Unentschieden!");

                Console.WriteLine("---------------------------------------");
                Console.WriteLine("Die Auswahl von Martin war: " + bans[index]);
                Runden++;
                Console.WriteLine("Siegesanzahl: DU(" + Spielergewinnanzahl + ")  MARTIN(" + Martinggewinnanzahl + ")");
                Console.WriteLine("Runde: " + Runden);
                Console.WriteLine("---------------------------------------");

                if (Spielergewinnanzahl == 3 && Martinggewinnanzahl == 3)
                {
                    Console.WriteLine("Es ist ein Unentschieden GG Rundenanzahl: " + Runden);
                    Console.WriteLine("Neues Spiel? (Ja/Nein)");
                }
                else if (Spielergewinnanzahl == 3)
                {
                    Console.WriteLine("Du hast gewonnen!!!!! Rundenanzahl: " + Runden);
                    break;
                }
                else if (Martinggewinnanzahl == 3)
                {
                    Console.WriteLine("Martin hat gewonnen!!! Rundenanzahl: " + Runden);
                    break;
                }


                Console.WriteLine("Dayyyyummm \nNächste Runde? (Ja/Nein)");

                string qans = Console.ReadLine();

                if (qans == "Ja")
                {
                    Console.Clear();
                    continue;
                }
                else
                {
                    break;
                }
            }
            else if (bans[index] == Choices.Schere) //Hier du kekkkkkkkkkkkkkkkkkkkkkkkkkkkkkkkkkkkkkkkkkkkkkkkkkkkkkkkkkkkkkkkkkkkk
            {
                if (userchoice == Choices.Papier)
                {
                    Console.WriteLine("Martin gewinnt!");

                    Console.WriteLine("---------------------------------------");
                    Console.WriteLine("Die Auswahl von Martin war: " + bans[index]);
                    Martinggewinnanzahl++;
                    Runden++;
                    Console.WriteLine("Siegesanzahl: DU(" + Spielergewinnanzahl + ")  MARTIN(" + Martinggewinnanzahl + ")");
                    Console.WriteLine("Runde: " + Runden);
                    Console.WriteLine("---------------------------------------");

                    if (Spielergewinnanzahl == 3 && Martinggewinnanzahl == 3)
                    {
                        Console.WriteLine("Es ist ein Unentschieden GG Rundenanzahl: " + Runden);
                        Console.WriteLine("Neues Spiel? (Ja/Nein)");
                    }
                    else if (Spielergewinnanzahl == 3)
                    {
                        Console.WriteLine("Du hast gewonnen!!!!! Rundenanzahl: " + Runden);
                        break;
                    }
                    else if (Martinggewinnanzahl == 3)
                    {
                        Console.WriteLine("Martin hat gewonnen!!! Rundenanzahl: " + Runden);
                        break;
                    }


                    Console.WriteLine("Skill issue... \nNächste Runde? (Ja/Nein)");


                    string qans = Console.ReadLine();

                    if (qans == "Ja")
                    {
                        Console.Clear();
                        continue;
                    }
                    else
                    {
                        break;
                    }
                }
                else if (userchoice == Choices.Stein)
                {
                    Console.WriteLine("Du gewinnst!");

                    Console.WriteLine("---------------------------------------");
                    Console.WriteLine("Die Auswahl von Martin war: " + bans[index]);
                    Spielergewinnanzahl++;
                    Runden++;
                    Console.WriteLine("Siegesanzahl: DU(" + Spielergewinnanzahl + ")  MARTIN(" + Martinggewinnanzahl + ")");
                    Console.WriteLine("Runde: " + Runden);
                    Console.WriteLine("---------------------------------------");

                    if (Spielergewinnanzahl == 3 && Martinggewinnanzahl == 3)
                    {
                        Console.WriteLine("Es ist ein Unentschieden GG Rundenanzahl: " + Runden);
                        Console.WriteLine("Neues Spiel? (Ja/Nein)");
                    }
                    else if (Spielergewinnanzahl == 3)
                    {
                        Console.WriteLine("Du hast gewonnen!!!!! Rundenanzahl: " + Runden);
                        break;
                    }
                    else if (Martinggewinnanzahl == 3)
                    {
                        Console.WriteLine("Martin hat gewonnen!!! Rundenanzahl: " + Runden);
                        break;
                    }


                    Console.WriteLine("Gut gemacht! \nNächste Runde? (Ja/Nein)");

                    string qans = Console.ReadLine();

                    if (qans == "Ja")
                    {
                        Console.Clear();
                        continue;
                    }
                    else
                    {
                        break;
                    }
                }
                else if (userchoice == Choices.Spock)
                {
                    Console.WriteLine("Du gewinnst!");

                    Console.WriteLine("---------------------------------------");
                    Console.WriteLine("Die Auswahl von Martin war: " + bans[index]);
                    Spielergewinnanzahl++;
                    Runden++;
                    Console.WriteLine("Siegesanzahl: DU(" + Spielergewinnanzahl + ")  MARTIN(" + Martinggewinnanzahl + ")");
                    Console.WriteLine("Runde: " + Runden);
                    Console.WriteLine("---------------------------------------");

                    if (Spielergewinnanzahl == 3 && Martinggewinnanzahl == 3)
                    {
                        Console.WriteLine("Es ist ein Unentschieden GG Rundenanzahl: " + Runden);
                        Console.WriteLine("Neues Spiel? (Ja/Nein)");
                    }
                    else if (Spielergewinnanzahl == 3)
                    {
                        Console.WriteLine("Du hast gewonnen!!!!! Rundenanzahl: " + Runden);
                        break;
                    }
                    else if (Martinggewinnanzahl == 3)
                    {
                        Console.WriteLine("Martin hat gewonnen!!! Rundenanzahl: " + Runden);
                        break;
                    }


                    Console.WriteLine("Gut gemacht! \nNächste Runde? (Ja/Nein)");

                    string qans = Console.ReadLine();

                    if (qans == "Ja")
                    {
                        Console.Clear();
                        continue;
                    }
                    else
                    {
                        break;
                    }
                }
                else if (userchoice == Choices.Echse)
                {
                    Console.WriteLine("Martin gewinnt!");

                    Console.WriteLine("---------------------------------------");
                    Console.WriteLine("Die Auswahl von Martin war: " + bans[index]);
                    Martinggewinnanzahl++;
                    Runden++;
                    Console.WriteLine("Siegesanzahl: DU(" + Spielergewinnanzahl + ")  MARTIN(" + Martinggewinnanzahl + ")");
                    Console.WriteLine("Runde: " + Runden);
                    Console.WriteLine("---------------------------------------");

                    if (Spielergewinnanzahl == 3 && Martinggewinnanzahl == 3)
                    {
                        Console.WriteLine("Es ist ein Unentschieden GG Rundenanzahl: " + Runden);
                        Console.WriteLine("Neues Spiel? (Ja/Nein)");
                    }
                    else if (Spielergewinnanzahl == 3)
                    {
                        Console.WriteLine("Du hast gewonnen!!!!! Rundenanzahl: " + Runden);
                        break;
                    }
                    else if (Martinggewinnanzahl == 3)
                    {
                        Console.WriteLine("Martin hat gewonnen!!! Rundenanzahl: " + Runden);
                        break;
                    }


                    Console.WriteLine("Skill issue... \nNächste Runde? (Ja/Nein)");

                    string qans = Console.ReadLine();

                    if (qans == "Ja")
                    {
                        Console.Clear();
                        continue;
                    }
                    else
                    {
                        break;
                    }
                }

            }
            else if (bans[index] == Choices.Stein) //Hier du kekkkkkkkkkkkkkkkkkkkkkkkkkkkkkkkkkkkkkkkkkkkkkkkkkkkkkkkkkkkkkkkkkkkk
            {
                if (userchoice == Choices.Papier)
                {
                    Console.WriteLine("Du gewinnst!");

                    Console.WriteLine("---------------------------------------");
                    Console.WriteLine("Die Auswahl von Martin war: " + bans[index]);
                    Spielergewinnanzahl++;
                    Runden++;
                    Console.WriteLine("Siegesanzahl: DU(" + Spielergewinnanzahl + ")  MARTIN(" + Martinggewinnanzahl + ")");
                    Console.WriteLine("Runde: " + Runden);
                    Console.WriteLine("---------------------------------------");

                    if (Spielergewinnanzahl == 3)
                    {
                        Console.WriteLine("Du hast gewonnen!!!!! Rundenanzahl: " + Runden);
                        break;
                    }
                    else if (Martinggewinnanzahl == 3)
                    {
                        Console.WriteLine("Martin hat gewonnen!!! Rundenanzahl: " + Runden);
                        break;
                    }


                    Console.WriteLine("Gut gemacht! \nNächste Runde? (Ja/Nein)");

                    string qans = Console.ReadLine();

                    if (qans == "Ja")
                    {
                        Console.Clear();
                        continue;
                    }
                    else
                    {
                        break;
                    }


                }
                else if (userchoice == Choices.Schere)
                {
                    Console.WriteLine("Martin gewinnt!");

                    Console.WriteLine("---------------------------------------");
                    Console.WriteLine("Die Auswahl von Martin war: " + bans[index]);
                    Martinggewinnanzahl++;
                    Runden++;
                    Console.WriteLine("Siegesanzahl: DU(" + Spielergewinnanzahl + ")  MARTIN(" + Martinggewinnanzahl + ")");
                    Console.WriteLine("Runde: " + Runden);
                    Console.WriteLine("---------------------------------------");

                    if (Spielergewinnanzahl == 3)
                    {
                        Console.WriteLine("Du hast gewonnen!!!!! Rundenanzahl: " + Runden);
                        break;
                    }
                    else if (Martinggewinnanzahl == 3)
                    {
                        Console.WriteLine("Martin hat gewonnen!!! Rundenanzahl: " + Runden);
                        break;
                    }


                    Console.WriteLine("Skill issue... \nNächste Runde? (Ja/Nein)");
                    string qans = Console.ReadLine();

                    if (qans == "Ja")
                    {
                        Console.Clear();
                        continue;
                    }
                    else
                    {
                        break;
                    }
                }
                else if (userchoice == Choices.Spock)
                {
                    Console.WriteLine("Du gewinnst!");

                    Console.WriteLine("---------------------------------------");
                    Console.WriteLine("Die Auswahl von Martin war: " + bans[index]);
                    Spielergewinnanzahl++;
                    Runden++;
                    Console.WriteLine("Siegesanzahl: DU(" + Spielergewinnanzahl + ")  MARTIN(" + Martinggewinnanzahl + ")");
                    Console.WriteLine("Runde: " + Runden);
                    Console.WriteLine("---------------------------------------");

                    if (Spielergewinnanzahl == 3)
                    {
                        Console.WriteLine("Du hast gewonnen!!!!! Rundenanzahl: " + Runden);
                        break;
                    }
                    else if (Martinggewinnanzahl == 3)
                    {
                        Console.WriteLine("Martin hat gewonnen!!! Rundenanzahl: " + Runden);
                        break;
                    }


                    Console.WriteLine("Gut gemacht! \nNächste Runde? (Ja/Nein)");

                    string qans = Console.ReadLine();

                    if (qans == "Ja")
                    {
                        Console.Clear();
                        continue;
                    }
                    else
                    {
                        break;
                    }
                }
                else if (userchoice == Choices.Echse)
                {
                    Console.WriteLine("Martin gewinnt!");

                    Console.WriteLine("---------------------------------------");
                    Console.WriteLine("Die Auswahl von Martin war: " + bans[index]);
                    Martinggewinnanzahl++;
                    Runden++;
                    Console.WriteLine("Siegesanzahl: DU(" + Spielergewinnanzahl + ")  MARTIN(" + Martinggewinnanzahl + ")");
                    Console.WriteLine("Runde: " + Runden);
                    Console.WriteLine("---------------------------------------");

                    if (Spielergewinnanzahl == 3)
                    {
                        Console.WriteLine("Du hast gewonnen!!!!! Rundenanzahl: " + Runden);
                        break;
                    }
                    else if (Martinggewinnanzahl == 3)
                    {
                        Console.WriteLine("Martin hat gewonnen!!! Rundenanzahl: " + Runden);
                        break;
                    }


                    Console.WriteLine("Skill issue... \nNächste Runde? (Ja/Nein)");

                    string qans = Console.ReadLine();

                    if (qans == "Ja")
                    {
                        Console.Clear();
                        continue;
                    }
                    else
                    {
                        break;
                    }
                }
            }
            else if (bans[index] == Choices.Echse) //Hier du kekkkkkkkkkkkkkkkkkkkkkkkkkkkkkkkkkkkkkkkkkkkkkkkkkkkkkkkkkkkkkkkkkkkk
            {
                if (userchoice == Choices.Papier)
                {
                    Console.WriteLine("Martin gewinnt!");

                    Console.WriteLine("---------------------------------------");
                    Console.WriteLine("Die Auswahl von Martin war: " + bans[index]);
                    Martinggewinnanzahl++;
                    Runden++;
                    Console.WriteLine("Siegesanzahl: DU(" + Spielergewinnanzahl + ")  MARTIN(" + Martinggewinnanzahl + ")");
                    Console.WriteLine("Runde: " + Runden);
                    Console.WriteLine("---------------------------------------");

                    if (Spielergewinnanzahl == 3)
                    {
                        Console.WriteLine("Du hast gewonnen!!!!! Rundenanzahl: " + Runden);
                        break;
                    }
                    else if (Martinggewinnanzahl == 3)
                    {
                        Console.WriteLine("Martin hat gewonnen!!! Rundenanzahl: " + Runden);
                        break;
                    }


                    Console.WriteLine("Skill issue... \nNächste Runde? (Ja/Nein)");

                    string qans = Console.ReadLine();

                    if (qans == "Ja")
                    {
                        Console.Clear();
                        continue;
                    }
                    else
                    {
                        break;
                    }


                }
                else if (userchoice == Choices.Spock)
                {
                    Console.WriteLine("Martin gewinnt!");

                    Console.WriteLine("---------------------------------------");
                    Console.WriteLine("Die Auswahl von Martin war: " + bans[index]);
                    Martinggewinnanzahl++;
                    Runden++;
                    Console.WriteLine("Siegesanzahl: DU(" + Spielergewinnanzahl + ")  MARTIN(" + Martinggewinnanzahl + ")");
                    Console.WriteLine("Runde: " + Runden);
                    Console.WriteLine("---------------------------------------");

                    if (Spielergewinnanzahl == 3)
                    {
                        Console.WriteLine("Du hast gewonnen!!!!! Rundenanzahl: " + Runden);
                        break;
                    }
                    else if (Martinggewinnanzahl == 3)
                    {
                        Console.WriteLine("Martin hat gewonnen!!! Rundenanzahl: " + Runden);
                        break;
                    }


                    Console.WriteLine("Skill issue... \nNächste Runde? (Ja/Nein)");

                    string qans = Console.ReadLine();

                    if (qans == "Ja")
                    {
                        Console.Clear();
                        continue;
                    }
                    else
                    {
                        break;
                    }

                }
                else if (userchoice == Choices.Schere)
                {
                    Console.WriteLine("Du gewinnst!");

                    Console.WriteLine("---------------------------------------");
                    Console.WriteLine("Die Auswahl von Martin war: " + bans[index]);
                    Spielergewinnanzahl++;
                    Runden++;
                    Console.WriteLine("Siegesanzahl: DU(" + Spielergewinnanzahl + ")  MARTIN(" + Martinggewinnanzahl + ")");
                    Console.WriteLine("Runde: " + Runden);
                    Console.WriteLine("---------------------------------------");

                    if (Spielergewinnanzahl == 3)
                    {
                        Console.WriteLine("Du hast gewonnen!!!!! Rundenanzahl: " + Runden);
                        break;
                    }
                    else if (Martinggewinnanzahl == 3)
                    {
                        Console.WriteLine("Martin hat gewonnen!!! Rundenanzahl: " + Runden);
                        break;
                    }


                    Console.WriteLine("Gut gemacht! \nNächste Runde? (Ja/Nein)");

                    string qans = Console.ReadLine();

                    if (qans == "Ja")
                    {
                        Console.Clear();
                        continue;
                    }
                    else
                    {
                        break;
                    }
                }
                else if (userchoice == Choices.Stein)
                {
                    Console.WriteLine("Du gewinnst!");

                    Console.WriteLine("---------------------------------------");
                    Console.WriteLine("Die Auswahl von Martin war: " + bans[index]);
                    Spielergewinnanzahl++;
                    Runden++;
                    Console.WriteLine("Siegesanzahl: DU(" + Spielergewinnanzahl + ")  MARTIN(" + Martinggewinnanzahl + ")");
                    Console.WriteLine("Runde: " + Runden);
                    Console.WriteLine("---------------------------------------");

                    if (Spielergewinnanzahl == 3)
                    {
                        Console.WriteLine("Du hast gewonnen!!!!! Rundenanzahl: " + Runden);
                        break;
                    }
                    else if (Martinggewinnanzahl == 3)
                    {
                        Console.WriteLine("Martin hat gewonnen!!! Rundenanzahl: " + Runden);
                        break;
                    }

                    Console.WriteLine("Gut gemacht! \nNächste Runde? (Ja/Nein)");

                    string qans = Console.ReadLine();

                    if (qans == "Ja")
                    {
                        Console.Clear();
                        continue;
                    }
                    else
                    {
                        break;
                    }
                }
            }
            else if (bans[index] == Choices.Spock) //Hier du kekkkkkkkkkkkkkkkkkkkkkkkkkkkkkkkkkkkkkkkkkkkkkkkkkkkkkkkkkkkkkkkkkkkk
            {
                if (userchoice == Choices.Papier)
                {
                    Console.WriteLine("Du gewinnst!");

                    Console.WriteLine("---------------------------------------");
                    Console.WriteLine("Die Auswahl von Martin war: " + bans[index]);
                    Spielergewinnanzahl++;
                    Runden++;
                    Console.WriteLine("Siegesanzahl: DU(" + Spielergewinnanzahl + ")  MARTIN(" + Martinggewinnanzahl + ")");
                    Console.WriteLine("Runde: " + Runden);
                    Console.WriteLine("---------------------------------------");

                    if (Spielergewinnanzahl == 3)
                    {
                        Console.WriteLine("Du hast gewonnen!!!!! Rundenanzahl: " + Runden);
                        break;
                    }
                    else if (Martinggewinnanzahl == 3)
                    {
                        Console.WriteLine("Martin hat gewonnen!!! Rundenanzahl: " + Runden);
                        break;
                    }


                    Console.WriteLine("Gut gemacht! \nNächste Runde? (Ja/Nein)");

                    string qans = Console.ReadLine();

                    if (qans == "Ja")
                    {
                        Console.Clear();
                        continue;
                    }
                    else
                    {
                        break;
                    }


                }
                else if (userchoice == Choices.Spock)
                {
                    Console.WriteLine("Du gewinnst!");

                    Console.WriteLine("---------------------------------------");
                    Console.WriteLine("Die Auswahl von Martin war: " + bans[index]);
                    Spielergewinnanzahl++;
                    Runden++;
                    Console.WriteLine("Siegesanzahl: DU(" + Spielergewinnanzahl + ")  MARTIN(" + Martinggewinnanzahl + ")");
                    Console.WriteLine("Runde: " + Runden);
                    Console.WriteLine("---------------------------------------");

                    if (Spielergewinnanzahl == 3)
                    {
                        Console.WriteLine("Du hast gewonnen!!!!! Rundenanzahl: " + Runden);
                        break;
                    }
                    else if (Martinggewinnanzahl == 3)
                    {
                        Console.WriteLine("Martin hat gewonnen!!! Rundenanzahl: " + Runden);
                        break;
                    }


                    Console.WriteLine("Gut gemacht! \nNächste Runde? (Ja/Nein)");


                    string qans = Console.ReadLine();

                    if (qans == "Ja")
                    {
                        Console.Clear();
                        continue;
                    }
                    else
                    {
                        break;
                    }

                }
                else if (userchoice == Choices.Schere)
                {
                    Console.WriteLine("Martin gewinnt!");

                    Console.WriteLine("---------------------------------------");
                    Console.WriteLine("Die Auswahl von Martin war: " + bans[index]);
                    Martinggewinnanzahl++;
                    Runden++;
                    Console.WriteLine("Siegesanzahl: DU(" + Spielergewinnanzahl + ")  MARTIN(" + Martinggewinnanzahl + ")");
                    Console.WriteLine("Runde: " + Runden);
                    Console.WriteLine("---------------------------------------");

                    if (Spielergewinnanzahl == 3)
                    {
                        Console.WriteLine("Du hast gewonnen!!!!! Rundenanzahl: " + Runden);
                        break;
                    }
                    else if (Martinggewinnanzahl == 3)
                    {
                        Console.WriteLine("Martin hat gewonnen!!! Rundenanzahl: " + Runden);
                        break;
                    }


                    Console.WriteLine("Ahhh Schade! \nNächste Runde? (Ja/Nein)");

                    string qans = Console.ReadLine();

                    if (qans == "Ja")
                    {
                        Console.Clear();
                        continue;
                    }
                    else
                    {
                        break;
                    }
                }
                else if (userchoice == Choices.Stein)
                {
                    Console.WriteLine("Martin gewinnt!");

                    Console.WriteLine("---------------------------------------");
                    Console.WriteLine("Die Auswahl von Martin war: " + bans[index]);
                    Spielergewinnanzahl++;
                    Runden++;
                    Console.WriteLine("Siegesanzahl: DU(" + Spielergewinnanzahl + ")  MARTIN(" + Martinggewinnanzahl + ")");
                    Console.WriteLine("Runde: " + Runden);
                    Console.WriteLine("---------------------------------------");

                    if (Spielergewinnanzahl == 3)
                    {
                        Console.WriteLine("Du hast gewonnen!!!!! Rundenanzahl: " + Runden);
                        break;
                    }
                    else if (Martinggewinnanzahl == 3)
                    {
                        Console.WriteLine("Martin hat gewonnen!!! Rundenanzahl: " + Runden);
                        break;
                    }


                    Console.WriteLine("Ahhh Schade! \nNächste Runde? (Ja/Nein)");

                    string qans = Console.ReadLine();

                    if (qans == "Ja")
                    {
                        Console.Clear();
                        continue;
                    }
                    else
                    {
                        break;
                    }
                }

            }
            else if (bans[index] == Choices.Papier)
            {
                if (userchoice == Choices.Stein)
                {
                    Console.WriteLine("Martin gewinnt!");

                    Console.WriteLine("---------------------------------------");
                    Console.WriteLine("Die Auswahl von Martin war: " + bans[index]);
                    Martinggewinnanzahl++;
                    Runden++;
                    Console.WriteLine("Siegesanzahl: DU(" + Spielergewinnanzahl + ")  MARTIN(" + Martinggewinnanzahl + ")");
                    Console.WriteLine("Runde: " + Runden);
                    Console.WriteLine("---------------------------------------");

                    if (Spielergewinnanzahl == 3)
                    {
                        Console.WriteLine("Du hast gewonnen!!!!! Rundenanzahl: " + Runden);
                        break;
                    }
                    else if (Martinggewinnanzahl == 3)
                    {
                        Console.WriteLine("Martin hat gewonnen!!! Rundenanzahl: " + Runden);
                        break;
                    }


                    Console.WriteLine("Skill issue... \nNächste Runde? (Ja/Nein)");
                    string qans = Console.ReadLine();

                    if (qans == "Ja")
                    {
                        Console.Clear();
                        continue;
                    }
                    else
                    {
                        break;
                    }
                }

                else if (userchoice == Choices.Schere)
                {
                    Console.WriteLine("Martin gewinnt!");

                    Console.WriteLine("---------------------------------------");
                    Console.WriteLine("Die Auswahl von Martin war: " + bans[index]);
                    Martinggewinnanzahl++;
                    Runden++;
                    Console.WriteLine("Siegesanzahl: DU(" + Spielergewinnanzahl + ")  MARTIN(" + Martinggewinnanzahl + ")");
                    Console.WriteLine("Runde: " + Runden);
                    Console.WriteLine("---------------------------------------");

                    if (Spielergewinnanzahl == 3)
                    {
                        Console.WriteLine("Du hast gewonnen!!!!! Rundenanzahl: " + Runden);
                        break;
                    }
                    else if (Martinggewinnanzahl == 3)
                    {
                        Console.WriteLine("Martin hat gewonnen!!! Rundenanzahl: " + Runden);
                        break;
                    }


                    Console.WriteLine("Skill issue... \nNächste Runde? (Ja/Nein)");
                    string qans = Console.ReadLine();

                    if (qans == "Ja")
                    {
                        Console.Clear();
                        continue;
                    }
                    else
                    {
                        break;
                    }
                }
                else if (userchoice == Choices.Spock)
                {
                    Console.WriteLine("Du gewinnst!");

                    Console.WriteLine("---------------------------------------");
                    Console.WriteLine("Die Auswahl von Martin war: " + bans[index]);
                    Spielergewinnanzahl++;
                    Runden++;
                    Console.WriteLine("Siegesanzahl: DU(" + Spielergewinnanzahl + ")  MARTIN(" + Martinggewinnanzahl + ")");
                    Console.WriteLine("Runde: " + Runden);
                    Console.WriteLine("---------------------------------------");

                    if (Spielergewinnanzahl == 3 && Martinggewinnanzahl == 3)
                    {
                        Console.WriteLine("Es ist ein Unentschieden GG Rundenanzahl: " + Runden);
                        Console.WriteLine("Neues Spiel? (Ja/Nein)");
                    }
                    else if (Spielergewinnanzahl == 3)
                    {
                        Console.WriteLine("Du hast gewonnen!!!!! Rundenanzahl: " + Runden);
                        break;
                    }
                    else if (Martinggewinnanzahl == 3)
                    {
                        Console.WriteLine("Martin hat gewonnen!!! Rundenanzahl: " + Runden);
                        break;
                    }


                    Console.WriteLine("Gut gemacht! \nNächste Runde? (Ja/Nein)");

                    string qans = Console.ReadLine();

                    if (qans == "Ja")
                    {
                        Console.Clear();
                        continue;
                    }
                    else
                    {
                        break;
                    }
                }
                else if (userchoice == Choices.Echse)
                {
                    Console.WriteLine("Martin gewinnt!");

                    Console.WriteLine("---------------------------------------");
                    Console.WriteLine("Die Auswahl von Martin war: " + bans[index]);
                    Martinggewinnanzahl++;
                    Runden++;
                    Console.WriteLine("Siegesanzahl: DU(" + Spielergewinnanzahl + ")  MARTIN(" + Martinggewinnanzahl + ")");
                    Console.WriteLine("Runde: " + Runden);
                    Console.WriteLine("---------------------------------------");

                    if (Spielergewinnanzahl == 3)
                    {
                        Console.WriteLine("Du hast gewonnen!!!!! Rundenanzahl: " + Runden);
                        break;
                    }
                    else if (Martinggewinnanzahl == 3)
                    {
                        Console.WriteLine("Martin hat gewonnen!!! Rundenanzahl: " + Runden);
                        break;
                    }


                    Console.WriteLine("Skill issue... \nNächste Runde? (Ja/Nein)");

                    string qans = Console.ReadLine();

                    if (qans == "Ja")
                    {
                        Console.Clear();
                        continue;
                    }
                    else
                    {
                        break;
                    }

                }
                else
                {
                    Console.WriteLine("Oh etwas ist schiefgelaufen! Versuchs Nochmal");
                    Console.WriteLine("----------------------------------------------");
                    continue;
                }

            }
        } while (true);
    }
}