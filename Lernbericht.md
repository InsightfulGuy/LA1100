# Lern-Bericht
Gruppenname: Tristan Evans, Gruppenmitglieder: Tristan Evans

## Einleitung

Ich habe im Lernatelier den Auftrag bekommen, ein random number guessing game zu programmieren.

## Was habe ich gelernt?

Ich habe gelernt, wie man eine try und catch Funktion in ein Programm implementieren.

## Beschreibung

Die try und catch Blöcke werden um den Code herum platziert und das würde dann eine «Ausnahme» auslösen.
Wenn dies ausgelöst wird, überprüfen die try und catch Blöcke das Programm, sodass es keine Fehler gibt im Code, 
oder ob es dann abstürzen würde. Falls es ein Problem geben würde, «fangen» (catch) die try und catch Blöcke das Programm 
und geben dann etwas aus, das von dem Nutzer in einer anderen Klammer definiert wird (z.B. Error: Es gab einen Fehler).

```
      
            try
            {
                Console.Write("Schreiben Sie eine Zahl: ");
                int i = Convert.ToInt32(Console.ReadLine());
                
                
            }
            catch
            {
                Console.ForegroundColor = ConsoleColor.DarkRed;
                Console.WriteLine("Error, nur Zahlen eingeben ");
            }

```
![grafik](https://user-images.githubusercontent.com/110893008/189852293-4067d0b9-ebb8-463b-91a9-c3205d9b2578.png)



## Verifikation

Der Text erklärt die try und catch Blöcke für den Leser.

Der Code zeigt einen typischen Fehler mit der try catch Blöcken.

Die Grafik zeigt die Konsole wenn man den obigen Code ausführt.

# Reflexion zum Arbeitsprozess

Bei mir lief das Lernen der try und catch Blöcken sehr gut, es brauchte nicht lang sie zu verstehen.

51

Bei mir lief aber nicht so gut, die Probleme zu erkennen und ich brauchte ein bisschen länger.

VBV: Durch die Bewertung von Timo Goedertier, habe ich herausgefunden, dass ich keine Funktion habe, dass es negative Zahlen nicht zulässt.

