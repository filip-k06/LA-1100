# Projekt-Dokumentation

Filip Kritzner

| Datum | Version | Zusammenfassung                                              |
| ----- | ------- | ------------------------------------------------------------ |
|23.08.22| 0.0.1   |Ich habe die Projektdokumentation erstellt.|
|30.08.22| 0.0.2   |Ich habe angefangen den Random Number Guesser zu programmieren.|
|06.09.22| 0.0.3   |Ich habe den Random Number Guesser fertiggestellt.|


## 1 Informieren

### 1.1 Ihr Projekt

Das Projekt wird ein Random Number Guesser .

### 1.2 User Stories

| US-№ | Verbindlichkeit | Typ  | Beschreibung                       |
| ---- | --------------- | ---- | ---------------------------------- |
| 1    |Muss             |Funktional|Als ein User möchte ich nur Zahlen zwischen 1-100 eingeben können, damit das Programm nicht abstürtzt|
|2     |Muss             |Funktional|Als ein User möchte ich meine zuletzt eingegebenen Zahlen sehen können, damit ich nicht die gleiche Zahl zweimal eingebe|
|3     |Muss             |Funktional|Als ein User möchte ich wissen, ob die eingegebene Zahl zu hoch oder zu tief ist, damit es einfacher ist die Lösung zu erraten|
|4     |Muss             |Funktional|Als ein User möchte ich wissen, ob die gesuchte Zahl erraten wurde und wie viele Versuche ich gebraucht habe, damit ich mich mit mir selber vergleichen kann|
|5     |Muss             |Qualität|Als User möchte ich mithilfe von Farben dargestellt bekommen, ob die eingegebene Zahl der gesuchten entspricht oder nicht, damit ich es schnell und klar sehe|
|6     |kann             |Funktional|Als User möchte ich sehen, ob die Zahl die ich eingegeben habe akzeptiert wurde (z.B. String wurde erkannt und Fehler ausgegeben), damit ich erkenne, dass ich einen Text eingegeben habe|
|7     |kann             |Funktional|Als User möchte ich bestimmen in welchem Zahlenbereich ich raten kann.|
|8     |kann             |Qualität|Als User möchte ich einen Sound hören, wenn ich die richtige Zahl erraten habe.|

### 1.3 Testfälle

| TC-№ | Ausgangslage | Eingabe | Erwartete Ausgabe |
| ---- | ------------ | ------- | ----------------- |
| 1.1  | Programm gestartet | *65* | Das Programm ist nicht abgestürtzt. |
| 1.2 | Programm gestartet | *text* | Das Programm gibt einen Fehler aus. *"Es sind nur Zahlen erlaubt!"* |
| 2.1 | Programm gestartet | *75* | Das Programm zeigt meine eingegebenen Zahlen. *"75"* |
| 3.1 | Programm gestartet | *25* | Das Programm sagt, ob die Zahl zu hoch oder zu niedrig ist. *"Ihre Zahl ist zu niedrig!"* |
| 4.1  | Programm gestartet | *34* | Das Programm gibt an, ob meine Zahl der gesuchten Zahl enspricht. *"Sie haben die Zahl erraten!"* |
| 5.1  | Programm gestartet | *89* | Das Programm zeigt mit Farben an, ob die gesuchte Zahl erraten wurde. |
| 6.1  | Programm gestartet | Eine Zahl oder Text eingeben | Wenn ein Text eingegeben wurde, gibt das Programm einen Fehler aus und gibt den Hinweis, dass nur Zahlen zwischen 1-100 akzeptiert werden. *"Es sind nur Zahlen zwischen 1-100 erlaubt!"* |
| 7.1 | Programm gestartet | *15* | *"Der Zahlenbereich 1-15 wurde erfolgreich gewählt!"* |
| 8.1 | Zahlenbereich gewählt und bereit zum Raten | *56* | *"Ihre Zahl ist zu hoch!"* wird ausgegeben und ein error sound wird abgespielt |
| 8.2 | Zahlenbereich gewählt und bereit zum Raten | *25* | *"Sie haben die Zahl erraten!"* wird ausgegeben und ein victory sound wird abgespielt |
| 8.3 | Der User hat das Spiel gewonnen und wird gefragt ob er eine weitere Runde spielen will |*"nein"* | Ein shutdown sound wird abgespielt |

### 1.4 Diagramme

![1100_Diagramm](https://user-images.githubusercontent.com/110892683/186111265-f993801c-6f35-4aa1-a577-ac57c2c8e5cc.png)

## 2 Planen

| AP-№ | Frist | Zuständig | Beschreibung | geplante Zeit |
| ---- | ----- | --------- | ------------ | ------------- |
| 1.A  | 30.08.2022 |Filip Kritzner| Der User muss Zahlen eingeben können | 15min |
| 2.A  | 30.08.2022 |Filip Kritzner| Wenn der User Texte eingibt, soll ein Fehler angezeigt werden | 60min |
| 3.A  | 30.08.2022 |Filip Kritzner| Das Programm gibt an, ob die eingegebene Zahl tiefer oder höher ist als die generierte | 15min |
| 4.A  | 30.08.2022 |Filip Kritzner| Das Programm kann die eingegebene Zahl mit der generierten Vergleichen | 15min |
| 5.A  | 30.08.2022 |Filip Kritzner| Es sollen Farben angezeigt werden | 30min |
| 6.A  | 30.08.2022 |Filip Kritzner| Wenn eine Zahl über 100 eingegeben wird, soll der Hinweis angezeigt werden, dass nur Zahlen zwischen 1-100 erlaubt sind | 30min |
| 7.A  | 06.09.2022 |Filip Kritzner| Der User soll eingeben können, in welchem Zahlenbereich er raten möchte. | 75min |
| 8.A  | 06.09.2022 |Filip Kritzner| Der User soll einen Sound hören wenn er gewinnt. | 75min |
Total: 
## 3 Entscheiden

Als ich bereits frühzeitig mit dem Programm fertig geworden bin, habe ich noch Zusatz Features wie Sounds hinzugefügt.

## 4 Realisieren

| AP-№ | Datum | Zuständig | geplante Zeit | tatsächliche Zeit |
| ---- | ----- | --------- | ------------- | ----------------- |
| 1.A  | 30.08.2022 | Filip | 15min | 20min |
| 2.A  | 30.08.2022 | Filip | 60min | 45min |
| 3.A  | 30.08.2022 | Filip | 15min | 10min |
| 4.A  | 30.08.2022 | Filip | 15min | 20min |
| 5.A  | 30.08.2022 | Filip | 30min | 60min |
| 6.A  | 30.08.2022 | Filip | 30min | 45min |
| 7.A  | 06.09.2022 | Filip | 75min | 90min |
| 8.A  | 06.09.2022 | Filip | 75min | 60min |

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
