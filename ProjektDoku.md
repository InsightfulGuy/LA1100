# LA1100
# Projekt-Dokumentation



| Datum | Version | Zusammenfassung                                              |
| ----- | ------- | ------------------------------------------------------------ |
| 23.8.2022 | 0.0.1   | Ich habe mit den Github Auftrag angefangen.|
| 30.08.2022| 0.1.0   | Mit meiner restlichen Zeit, habe ich dem Programm die Möglichkeit gegeben eine zufällige Zahl zu generieren.|
| 06.09.2022| 1.0.0   | Der Generator ist fertig und er hat alle meine Funktionen erfüllt.|
| 13.09.2022| 1.0.0   | Mein Programm wurde von Timo Goedertier bewertet und korrigiert und gebe das Projekt ab.|  
                                                             

## 1 Informieren

### 1.1 Ihr Projekt

Mein Projekt ist ein Number Generator, bei dem der Nutzer eine Zahl zwischen 1 und 100 erraten muss. 

### 1.2 User Stories

| US-№ | Verbindlichkeit | Typ  | Beschreibung                       |
| ---- | --------------- | ---- | ---------------------------------- |
| 1    | muss            |  Funktion    |  Als der Nutzer, will ich eine Zahl zwischen 1 und 100 eingeben können.|
| 2    | muss            |  Funktion    |  Als der Nutzer, will ich vom Programm wissen ob ich die Zahl erraten habe.|
| 3    | muss            |  Funktion    |  Als der Nutzer, möchte vom Programm wissen ob die Zahl zu hoch oder zu tief war.|
| 4    | kann            |  Qualität    |  Als der Nutzer, möchte ich die richtige/falsche Zahl in einer anderen Farbe sehen.|
| 5    | muss            |  Funktion    |  Als der Nutzer, will ich einen weiteren Versuch bekommen, falls die Zahl falsch ist.|
| 6    | muss            |  Funktion    |  Als der Nutzer, muss das Programm mir die Möglichkeit geben, das Spiel zu neustarten.|

### 1.3 Testfälle

| TC-№ | Ausgangslage | Eingabe | Erwartete Ausgabe |
| ---- | ------------ | ------- | ----------------- |
|  1.1 |Random Nummer ist generiert|"Eingabe"|Die Nummer die ich eingegeben habe sollte erscheinen.|
|  2.1 |Random Nummer ist generiert|"Eingabe"|Text der sagt ob ich die Nummer erraten habe.|
|  2.2 |Random Nummer ist generiert|"Eingabe"|Das Programm sollte eine Antwort geben, ob die Zahl zu gross, oder zu klein ist|
|  3.1 |Die Antwort ist ausgegeben|"Ausgabe" |Nummer soll in einer anderen Farbe angezeigt werden, ob sie falsch/richtig ist.|
|  4.1 |Nummer richtig|"Ausgabe"|Das Spiel sollte einem einen neuen Versuch geben.| 
|  5.1 |Die random Nummer wurde erraten, der Text und das Resultat werden angezeigt.|"Neustart"|Es soll eine Möglichkeit geben, das Spiel zu neustarten.
|  6.1 |Andere Zeichen wurden eingegeben|"Ausgabe"|Eine Fehlermeldung|


### 1.4 Diagramme

![grafik](https://user-images.githubusercontent.com/110893008/186104561-695b1c79-6787-401d-87b4-a9b2d80d4771.png)


## 2 Planen

| AP-№ |    Frist  | Zuständig | Beschreibung | geplante Zeit |
| ---- | ----------| --------- | ------------ | ------------- |
| 1.A  |30.08.2022 |Tristan Evans| Das Programm kann eine zufällige Zahl generieren zwischen 1 und 100.| 40' | 
| 2.A  |06.09.2022 |Tristan Evans| Das Programm macht eine Ausgabe ob die Zahl richtig oder falsch ist.| 40' |
| 2.A  |06.09.2022 |Tristan Evans| Das Programm soll wenn eine Zahl falsch von dem Nutzer geschätzt wird, wird dem Nutzer ein weiterer Versuch geben.| 50' |
| 3.A  |06.09.2022 |Tristan Evans| Das Programm soll eine Rückmeldung geben, ob die Zahl die von dem Nutzer eingegeben wird zu hoch oder zu tief ist.|45'|
| 4.A  |06.09.2022 |Tristan Evans| Das Programm soll eine Fehlermeldung Ausgeben, in der steht, dass man keine Buchstaben eingeben soll.|55'|
| 5.A  |06.09.2022 |Tristan Evans| Das Programm fragt den Nutzer nach beenden der Runde, ob dieser noch eine Runde spielen möchte.|45'|

Total: 

✍️ Die Nummer hat das Format `N.m`, wobei `N` die Nummer der User Story ist, auf die sich das Arbeitspaket bezieht, und `m` von `A` an nach oben buchstabiert. Beispiel: Das dritte Arbeitspaket, das die zweite User Story betrifft, hat also die Nummer `2.C`.

✍️ Ein Arbeitspaket sollte etwa 45' für eine Person in Anspruch nehmen. Die totale Anzahl Arbeitspakete sollte etwa Folgendem entsprechen: `Anzahl R-Sitzungen` ╳ `Anzahl Gruppenmitglieder` ╳ `4`. Wenn Sie also zu dritt an einem Projekt arbeiten, für welches zwei R-Sitzungen geplant sind, sollten Sie auf `2` ╳ `3` ╳`4` = `24` Arbeitspakete kommen. Sollten Sie merken, dass Sie hier nicht genügend Arbeitspakte haben, denken Sie sich weitere "Kann"-User Stories für Kapitel 1.2 aus.

## 3 Entscheiden

Ich werde ein Programm schreiben, in dem man, sobald das Programm gestartet wurde, man eine Nummer in einen Zahlenbereich eingeben kann. Danach generiert das Programm in diesem Zahlenbereich eine zufällige Zahl und der Spieler muss dann eine Zahl, in dem Zahlenbereich schätzen, bis er die richtige Zahl findet, die die der zufälligen Zahl übereinstimmt.Jedes mal, wenn der Spieler die falsche Zahl schätzt gibt das Programm eine Rückmeldung, in der steht, ob die geschätzte Zahl höher oder tiefer als die generierte Zahl. Jedes mal wenn das passiert gibt es dem Spieler einen neuen Versuch. Sobald der Spieler die generierte Zahl herausfindet, fragt das Programm, ob der Spieler noch eine Runde spielen möchte. Als ein kann wegen der Farbe des Textes, habe ich mich entschieden die Antworten farbig zu machen.

## 4 Realisieren

| AP-№ | Datum     | Zuständig    | geplante Zeit | tatsächliche Zeit |
| ---- | ----------| ------------ | ------------- | ----------------- |
| 1.A  | 30.08.2022| Tristan Evans|  40'          |  15'              |
| 2.A  | 06.09.2022| Tristan Evans|  30'          |  20'              |
| 2.A  | 06.09.2022| Tristan Evans|  50           |  25'              |
| 3.A  | 06.09.2022| Tristan Evans|  45'          |  20'              |
| 4.A  | 06.09.2022| Tristan Evans|  55'          |  25'              |
| 5.A  | 06.09.2022| Tristan Evans|  45'          |  15'              |


✍️ Tragen Sie jedes Mal, wenn Sie ein Arbeitspaket abschließen, hier ein, wie lang Sie effektiv dafür hatten.

## 5 Kontrollieren

### 5.1 Testprotokoll

| TC-№ | Datum | Resultat | Tester |
| ---- | ----- | -------- | ------ |
| 1.1  | 13.09.2022      |Die eingegebene Nummer von mir wurde angezeigt|Tristan Evans|
| 2.1  | 13.09.2022      |Das Programm hat mir einen Text ausgegeben, ob ich es richtig oder falsch hatte|Tristan Evans|
| 2.2  | 13.09.2022      |Das Programm gab mir die Meldung dass die Nummer zu klein/ zu gross war|Tristan Evans|
| 3.1  | 13.09.2022      |Die Antwort wurde in verschiedenen Farben ausgegeben.|Tristan Evans|
| 4.1  | 13.09.2022      |Das Spiel gab mir einen weiteren Versuch die Nummer zu erraten.|Tristan Evans|
| 5.1  | 13.09.2022      |Das Spiel gab mir die Meldung y/n um das Spiel neuzustarten.|Tristan Evans|
| 6.1  | 13.09.2022      |Es gab mir die Fehlermeldung, dass nur Zahlen eingegeben werden dürfen.|Tristan Evans|

✍️ Vergessen Sie nicht, ein Fazit hinzuzufügen, welches das Test-Ergebnis einordnet.

### 5.2 Exploratives Testen

Tester: Timo Goedertier

| BR-№ | Ausgangslage | Eingabe | Erwartete Ausgabe | Tatsächliche Ausgabe |
| ---- | ------------ | ------- | ----------------- | -------------------- |
| I    |Am Anfang, wenn mich das Programm nach einer Zahl fragt gebe ich Sachen ein.|zu grosse Zahlen, Buchstaben und Wörter|Das Programm stürzt ab|Das Programm gibt eine Fehlermeldung, aber stürzt nicht ab.|
| II    |Nach dem gewinnen vom Spiel fragt mich das Programm ob ich nochmals spielen möchte.|zu grosse Zahlen, Buchstaben und Wörter|Das Programm stürzt ab|Das Programm gibt eine Fehlermeldung, aber stürzt nicht ab.|
| III   |Am Anfang, wenn mich das Programm nach einer Zahl fragt gebe ich negative Zahlen ein.|Zahlen im negativen Bereich|Fehlermeldung|Das Programm sagt einfach, dass die Zahl zu klein ist, aber es sagt nicht, dass es eine ungültige Eingabe ist. Alles im Zahlenbereich 1 - 100|

✍️ Verwenden Sie römische Ziffern für Ihre Bug Reports, also I, II, III, IV etc.

## 6 Auswerten

✍️ Fügen Sie hier eine Verknüpfung zu Ihrem Lern-Bericht ein.
