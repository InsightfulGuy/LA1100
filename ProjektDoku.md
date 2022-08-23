# LA1100
# Projekt-Dokumentation

☝️ Alle Text-Stellen, welche mit einem ✍️ beginnen, können Sie löschen, sobald Sie die entsprechende Stellen ausgefüllt haben.

✍️ Ihr Gruppenname und Ihre Nachnamen

| Datum | Version | Zusammenfassung                                              |
| ----- | ------- | ------------------------------------------------------------ |
| 23.8.2022 | 0.0.1   | ✍️ Jedes Mal, wenn Sie an dem Projekt arbeiten, fügen Sie hier eine neue Zeile ein und beschreiben in *einem* Satz, was Sie erreicht haben. |
|       | ...     |                                                              |
|       | 1.0.0   |                                                              |

## 1 Informieren

### 1.1 Ihr Projekt

Mein Projekt ist ein Number Generator, bei dem der Nutzer eine Zahl zwischen 1 und 100 erraten muss. 

### 1.2 User Stories

| US-№ | Verbindlichkeit | Typ  | Beschreibung                       |
| ---- | --------------- | ---- | ---------------------------------- |
| 1    | muss            |  Funktion    |  Das Programm muss eine Zahl zwischen 1 und 100 generieren.|
| 2    | muss            |  Funktion    |  Das Programm muss dem User eine Möglichkeit geben eine Nummer einzugeben|
| 3    | muss            |  Funktion    |  Der User möchte vom Programm wissen ob die Zahl zu hoch oder zu tief war.|
| 4    | kann            |  Qualität    |  Der User will vielleicht ein schönes Design des Programms sehen, anstatt die normale Ansicht|


### 1.3 Testfälle

| TC-№ | Ausgangslage | Eingabe | Erwartete Ausgabe |
| ---- | ------------ | ------- | ----------------- |
|  1   | Das Programm wird gestartet, aber gibt keine Rückmeldung|"Eine Eingabe"|Das Programm sollte den Random Number Generator anzeigen|
|  2   | Das Programm wird gestartet, zeigt den Number Generator an, aber gibt dem User nicht die Möglichkeit eine Nummer einzugeben| "Eingabe einer Zahl, aber funktioniert nicht"|Eine Eingabe einer Nummer in den Generator|
|  3   | Das Programm ist gestartet, zeigt den Number Generator an und lässt einem eine Nummer einzugeben, aber gibt nicht eine Anzeige ob die random Number höher oder tiefer ist| Eingabe einer Nummer um die random Nummer herauszufinden| Das Programm sagt einem ob die Nummer zu tief oder zu hoch ist|
|  4   | Das Programm wird getartet, aber das Design des Programms ist verbuggt| Das Programm starten | Das Design ist so aufgebaut wie es wäre beim Starten| 

✍️ Die Nummer hat das Format `N.m`, wobei `N` die Nummer der User Story ist, die der Testfall abdeckt, und `m` von `1` an nach oben gezählt. Beispiel: Der dritte Testfall, der die zweite User Story abdeckt, hat also die Nummer `2.3`.

### 1.4 Diagramme

![grafik](https://user-images.githubusercontent.com/110893008/186104561-695b1c79-6787-401d-87b4-a9b2d80d4771.png)


## 2 Planen

| AP-№ |    Frist  | Zuständig | Beschreibung | geplante Zeit |
| ---- | ----------| --------- | ------------ | ------------- |
| 1.A  | 30.08.2022| Evans Tristan| Code des Number generator fertig programmieren| 4 Stunden |
| 1.B  | 30.08 2022| Evans Tristan| Design des Number         |               |

Total: 

✍️ Die Nummer hat das Format `N.m`, wobei `N` die Nummer der User Story ist, auf die sich das Arbeitspaket bezieht, und `m` von `A` an nach oben buchstabiert. Beispiel: Das dritte Arbeitspaket, das die zweite User Story betrifft, hat also die Nummer `2.C`.

✍️ Ein Arbeitspaket sollte etwa 45' für eine Person in Anspruch nehmen. Die totale Anzahl Arbeitspakete sollte etwa Folgendem entsprechen: `Anzahl R-Sitzungen` ╳ `Anzahl Gruppenmitglieder` ╳ `4`. Wenn Sie also zu dritt an einem Projekt arbeiten, für welches zwei R-Sitzungen geplant sind, sollten Sie auf `2` ╳ `3` ╳`4` = `24` Arbeitspakete kommen. Sollten Sie merken, dass Sie hier nicht genügend Arbeitspakte haben, denken Sie sich weitere "Kann"-User Stories für Kapitel 1.2 aus.

## 3 Entscheiden

✍️ Dokumentieren Sie hier Ihre Entscheidungen und Annahmen, die Sie im Bezug auf Ihre User Stories und die Implementierung getroffen haben.

## 4 Realisieren

| AP-№ | Datum | Zuständig | geplante Zeit | tatsächliche Zeit |
| ---- | ----- | --------- | ------------- | ----------------- |
| 1.A  |       |           |               |                   |
| ...  |       |           |               |                   |

✍️ Tragen Sie jedes Mal, wenn Sie ein Arbeitspaket abschließen, hier ein, wie lang Sie effektiv dafür hatten.

## 5 Kontrollieren

### 5.1 Testprotokoll

| TC-№ | Datum | Resultat | Tester |
| ---- | ----- | -------- | ------ |
| 1.1  |       |          |        |
| ...  |       |          |        |

✍️ Vergessen Sie nicht, ein Fazit hinzuzufügen, welches das Test-Ergebnis einordnet.

### 5.2 Exploratives Testen

| BR-№ | Ausgangslage | Eingabe | Erwartete Ausgabe | Tatsächliche Ausgabe |
| ---- | ------------ | ------- | ----------------- | -------------------- |
| I    |              |         |                   |                      |
| ...  |              |         |                   |                      |

✍️ Verwenden Sie römische Ziffern für Ihre Bug Reports, also I, II, III, IV etc.

## 6 Auswerten

✍️ Fügen Sie hier eine Verknüpfung zu Ihrem Lern-Bericht ein.
