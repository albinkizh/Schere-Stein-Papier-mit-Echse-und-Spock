int Spielergewinnanzahl = 0;
int Martinggewinnanzahl = 0;




do
{
    //Hier wird eine Random Zahl ausgewählt und dann unten verwendet
    var bans = new List<string> { "Schere", "Stein", "Papier", "Spock", "Echse" };
    int index = Random.Shared.Next(bans.Count);



    Console.WriteLine("Willkommen zum Schere-Stein-Papier mit Echse und Spock Spiel \nKannst du Martin besiegen? \nWähle eines der Fünf aus");
    string ans = Console.ReadLine();

    if (ans == bans[index]) //Hier du kekkkkkkkkkkkkkkkkkkkkkkkkkkkkkkkkkkkkkkkkkkkkkkkkkkkkkkkkkkkkkkkkkkkk
    {
        Console.WriteLine("Unentschieden!");

        Console.WriteLine("---------------------------------------");
        Console.WriteLine("Die Auswahl von Martin war: " + bans[index]);
        Console.WriteLine("Siegesanzahl: DU(" + Spielergewinnanzahl + ")  MARTIN(" + Martinggewinnanzahl + ")");
        Console.WriteLine("---------------------------------------");
        Console.WriteLine("Dayyyyummm \nZeig Ihm das du besser bist! Nochmal? (Ja/Nein)");

        string qans = Console.ReadLine();

        if (qans == "Ja")
        {
            continue;
        }
        else
        {
            break;
        }
    }
    else if (bans[index] == "Schere") //Hier du kekkkkkkkkkkkkkkkkkkkkkkkkkkkkkkkkkkkkkkkkkkkkkkkkkkkkkkkkkkkkkkkkkkkk
    {
        if (ans == "Papier")
        {
            Console.WriteLine("Martin gewinnt!");

            Console.WriteLine("---------------------------------------");
            Console.WriteLine("Die Auswahl von Martin war: " + bans[index]);
            Martinggewinnanzahl++;
            Console.WriteLine("Siegesanzahl: DU(" + Spielergewinnanzahl + ")  MARTIN(" + Martinggewinnanzahl + ")");
            Console.WriteLine("---------------------------------------");
            Console.WriteLine("Skill issue... \nGib nicht auf! Versuch nochmal (Ja/Nein)");


            string qans = Console.ReadLine();

            if (qans == "Ja")
            {
                continue;
            }
            else
            {
                break;
            }
        }
        else if (ans == "Stein")
        {
            Console.WriteLine("Du gewinnst!");

            Console.WriteLine("---------------------------------------");
            Console.WriteLine("Die Auswahl von Martin war: " + bans[index]);
            Spielergewinnanzahl++;
            Console.WriteLine("Siegesanzahl: DU(" + Spielergewinnanzahl + ")  MARTIN(" + Martinggewinnanzahl + ")");
            Console.WriteLine("---------------------------------------");
            Console.WriteLine("Gut gemacht! \nLust Martin nochmal zu besiegen? (Ja/Nein)");

            string qans = Console.ReadLine();

            if (qans == "Ja")
            {
                continue;
            }
            else
            {
                break;
            }
        }
        else if (ans == "Spock")
        {
            Console.WriteLine("Du gewinnst!");

            Console.WriteLine("---------------------------------------");
            Console.WriteLine("Die Auswahl von Martin war: " + bans[index]);
            Spielergewinnanzahl++;
            Console.WriteLine("Siegesanzahl: DU(" + Spielergewinnanzahl + ")  MARTIN(" + Martinggewinnanzahl + ")");
            Console.WriteLine("---------------------------------------");
            Console.WriteLine("Gut gemacht! \nLust Martin nochmal zu besiegen? (Ja/Nein)");

            string qans = Console.ReadLine();

            if (qans == "Ja")
            {
                continue;
            }
            else
            {
                break;
            }
        }
        else if (ans == "Echse")
        {
            Console.WriteLine("Martin gewinnt!");

            Console.WriteLine("---------------------------------------");
            Console.WriteLine("Die Auswahl von Martin war: " + bans[index]);
            Martinggewinnanzahl++;
            Console.WriteLine("Siegesanzahl: DU(" + Spielergewinnanzahl + ")  MARTIN(" + Martinggewinnanzahl + ")");
            Console.WriteLine("---------------------------------------");
            Console.WriteLine("Skill issue... \nGib nicht auf! Versuch nochmal (Ja/Nein)");

            string qans = Console.ReadLine();

            if (qans == "Ja")
            {
                continue;
            }
            else
            {
                break;
            }
        }

    }
    else if (bans[index] == "Stein") //Hier du kekkkkkkkkkkkkkkkkkkkkkkkkkkkkkkkkkkkkkkkkkkkkkkkkkkkkkkkkkkkkkkkkkkkk
    {
        if (ans == "Papier")
        {
            Console.WriteLine("Du gewinnst!");

            Console.WriteLine("---------------------------------------");
            Console.WriteLine("Die Auswahl von Martin war: " + bans[index]);
            Spielergewinnanzahl++;
            Console.WriteLine("Siegesanzahl: DU(" + Spielergewinnanzahl + ")  MARTIN(" + Martinggewinnanzahl + ")");
            Console.WriteLine("---------------------------------------");
            Console.WriteLine("Gut gemacht! \nLust Martin nochmal zu besiegen? (Ja/Nein)");

            string qans = Console.ReadLine();

            if (qans == "Ja")
            {
                continue;
            }
            else
            {
                break;
            }


        }
        else if (ans == "Schere")
        {
            Console.WriteLine("Martin gewinnt!");

            Console.WriteLine("---------------------------------------");
            Console.WriteLine("Die Auswahl von Martin war: " + bans[index]);
            Martinggewinnanzahl++;
            Console.WriteLine("Siegesanzahl: DU(" + Spielergewinnanzahl + ")  MARTIN(" + Martinggewinnanzahl + ")");
            Console.WriteLine("---------------------------------------");
            Console.WriteLine("Skill issue... \nGib nicht auf! Versuch nochmal (Ja/Nein)");

            string qans = Console.ReadLine();

            if (qans == "Ja")
            {
                continue;
            }
            else
            {
                break;
            }
        }
        else if (ans == "Spock")
        {
            Console.WriteLine("Du gewinnst!");

            Console.WriteLine("---------------------------------------");
            Console.WriteLine("Die Auswahl von Martin war: " + bans[index]);
            Spielergewinnanzahl++;
            Console.WriteLine("Siegesanzahl: DU(" + Spielergewinnanzahl + ")  MARTIN(" + Martinggewinnanzahl + ")");
            Console.WriteLine("---------------------------------------");
            Console.WriteLine("Gut gemacht! \nLust Martin nochmal zu besiegen? (Ja/Nein)");

            string qans = Console.ReadLine();

            if (qans == "Ja")
            {
                continue;
            }
            else
            {
                break;
            }
        }
        else if (ans == "Echse")
        {
            Console.WriteLine("Martin gewinnt!");

            Console.WriteLine("---------------------------------------");
            Console.WriteLine("Die Auswahl von Martin war: " + bans[index]);
            Martinggewinnanzahl++;
            Console.WriteLine("Siegesanzahl: DU(" + Spielergewinnanzahl + ")  MARTIN(" + Martinggewinnanzahl + ")");
            Console.WriteLine("---------------------------------------");
            Console.WriteLine("Skill issue... \nGib nicht auf! Versuch nochmal (Ja/Nein)");

            string qans = Console.ReadLine();

            if (qans == "Ja")
            {
                continue;
            }
            else
            {
                break;
            }
        }
    }
    else if (bans[index] == "Echse") //Hier du kekkkkkkkkkkkkkkkkkkkkkkkkkkkkkkkkkkkkkkkkkkkkkkkkkkkkkkkkkkkkkkkkkkkk
    {
        if (ans == "Papier")
        {
            Console.WriteLine("Martin gewinnt!");

            Console.WriteLine("---------------------------------------");
            Console.WriteLine("Die Auswahl von Martin war: " + bans[index]);
            Martinggewinnanzahl++;
            Console.WriteLine("Siegesanzahl: DU(" + Spielergewinnanzahl + ")  MARTIN(" + Martinggewinnanzahl + ")");
            Console.WriteLine("---------------------------------------");
            Console.WriteLine("Skill issue... \nGib nicht auf! Versuch nochmal (Ja/Nein)");

            string qans = Console.ReadLine();

            if (qans == "Ja")
            {
                continue;
            }
            else
            {
                break;
            }


        }
        else if (ans == "Spock")
        {
            Console.WriteLine("Martin gewinnt!");

            Console.WriteLine("---------------------------------------");
            Console.WriteLine("Die Auswahl von Martin war: " + bans[index]);
            Martinggewinnanzahl++;
            Console.WriteLine("Siegesanzahl: DU(" + Spielergewinnanzahl + ")  MARTIN(" + Martinggewinnanzahl + ")");
            Console.WriteLine("---------------------------------------");
            Console.WriteLine("Skill issue... \nGib nicht auf! Versuch nochmal (Ja/Nein)");

            string qans = Console.ReadLine();

            if (qans == "Ja")
            {
                continue;
            }
            else
            {
                break;
            }

        }
        else if (ans == "Schere")
        {
            Console.WriteLine("Du gewinnst!");

            Console.WriteLine("---------------------------------------");
            Console.WriteLine("Die Auswahl von Martin war: " + bans[index]);
            Spielergewinnanzahl++;
            Console.WriteLine("Siegesanzahl: DU(" + Spielergewinnanzahl + ")  MARTIN(" + Martinggewinnanzahl + ")");
            Console.WriteLine("---------------------------------------");
            Console.WriteLine("Gut gemacht! \nLust Martin nochmal zu besiegen? (Ja/Nein)");

            string qans = Console.ReadLine();

            if (qans == "Ja")
            {
                continue;
            }
            else
            {
                break;
            }
        }
        else if (ans == "Stein")
        {
            Console.WriteLine("Du gewinnst!");

            Console.WriteLine("---------------------------------------");
            Console.WriteLine("Die Auswahl von Martin war: " + bans[index]);
            Spielergewinnanzahl++;
            Console.WriteLine("Siegesanzahl: DU(" + Spielergewinnanzahl + ")  MARTIN(" + Martinggewinnanzahl + ")");
            Console.WriteLine("---------------------------------------");
            Console.WriteLine("Gut gemacht! \nLust Martin nochmal zu besiegen? (Ja/Nein)");

            string qans = Console.ReadLine();

            if (qans == "Ja")
            {
                continue;
            }
            else
            {
                break;
            }
        }
    }
    else if (bans[index] == "Spock") //Hier du kekkkkkkkkkkkkkkkkkkkkkkkkkkkkkkkkkkkkkkkkkkkkkkkkkkkkkkkkkkkkkkkkkkkk
    {
        if (ans == "Papier")
        {
            Console.WriteLine("Du gewinnst!");

            Console.WriteLine("---------------------------------------");
            Console.WriteLine("Die Auswahl von Martin war: " + bans[index]);
            Spielergewinnanzahl++;
            Console.WriteLine("Siegesanzahl: DU(" + Spielergewinnanzahl + ")  MARTIN(" + Martinggewinnanzahl + ")");
            Console.WriteLine("---------------------------------------");
            Console.WriteLine("Gut gemacht! \nLust Martin nochmal zu besiegen? (Ja/Nein)");

            string qans = Console.ReadLine();

            if (qans == "Ja")
            {
                continue;
            }
            else
            {
                break;
            }


        }
        else if (ans == "Spock")
        {
            Console.WriteLine("Du gewinnst!");

            Console.WriteLine("---------------------------------------");
            Console.WriteLine("Die Auswahl von Martin war: " + bans[index]);
            Spielergewinnanzahl++;
            Console.WriteLine("Siegesanzahl: DU(" + Spielergewinnanzahl + ")  MARTIN(" + Martinggewinnanzahl + ")");
            Console.WriteLine("---------------------------------------");
            Console.WriteLine("Gut gemacht! \nLust Martin nochmal zu besiegen? (Ja/Nein)");


            string qans = Console.ReadLine();

            if (qans == "Ja")
            {
                continue;
            }
            else
            {
                break;
            }

        }
        else if (ans == "Schere")
        {
            Console.WriteLine("Martin gewinnt!");

            Console.WriteLine("---------------------------------------");
            Console.WriteLine("Die Auswahl von Martin war: " + bans[index]);
            Martinggewinnanzahl++;
            Console.WriteLine("Siegesanzahl: DU(" + Spielergewinnanzahl + ")  MARTIN(" + Martinggewinnanzahl + ")");
            Console.WriteLine("---------------------------------------");
            Console.WriteLine("Gut gemacht! \nLust Martin nochmal zu besiegen? (Ja/Nein)");

            string qans = Console.ReadLine();

            if (qans == "Ja")
            {
                continue;
            }
            else
            {
                break;
            }
        }
        else if (ans == "Stein")
        {
            Console.WriteLine("Martin gewinnt!");

            Console.WriteLine("---------------------------------------");
            Console.WriteLine("Die Auswahl von Martin war: " + bans[index]);
            Spielergewinnanzahl++;
            Console.WriteLine("Siegesanzahl: DU(" + Spielergewinnanzahl + ")  MARTIN(" + Martinggewinnanzahl + ")");
            Console.WriteLine("---------------------------------------");
            Console.WriteLine("Gut gemacht! \nLust Martin nochmal zu besiegen? (Ja/Nein)");

            string qans = Console.ReadLine();

            if (qans == "Ja")
            {
                continue;
            }
            else
            {
                break;
            }
        }

    }


} while (true);