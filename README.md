# Projekt-Dokumentation

☝️ Alle Text-Stellen, welche mit einem ✍️ beginnen, können Sie löschen, sobald Sie die entsprechende Stellen ausgefüllt haben.

Filip Kritzner

| Datum | Version | Zusammenfassung                                              |
| ----- | ------- | ------------------------------------------------------------ |
|       | 0.0.1   |Ich habe User-Stories erstellt.|
|       | 0.0.2   |Ich habe ein Diagramm hinzugefügt.|
|       | 0.0.3   |Ich habe Testfälle erstellt.|
|       | 0.0.4   |Ich habe Arbeitspakete erstellt.|

## 1 Informieren

### 1.1 Ihr Projekt

Das Projekt wird ein Random Number Guesser .

### 1.2 User Stories

| US-№ | Verbindlichkeit | Typ  | Beschreibung                       |
| ---- | --------------- | ---- | ---------------------------------- |
| 1    |Muss             |      | Als ein User möchte ich nur Zahlen zwischen 1-100 eingeben können, damit das Programm nicht abstürtzt|
|2     |Muss             |      |Als ein User möchte ich meine zuletzt eingegebenen Zahlen sehen können, damit ich nicht die gleiche Zahl zweimal eingebe|
|3     |Muss             |      |Als ein User möchte ich wissen, ob die eingegebene Zahl zu hoch oder zu tief ist, damit es einfacher ist die Lösung zu erraten|
|4     |Muss             |      |Als ein User möchte ich wissen, ob die gesuchte Zahl erraten wurde und wie viele Versuche ich gebraucht habe, damit ich mich mit mir selber vergleichen kann|
|5     |Muss             |      |Als User möchte ich mithilfe von Farben dargestellt bekommen, ob die eingegebene Zahl der gesuchten entspricht oder nicht, damit ich es schnell und klar sehe|
|6     |kann             |      |Als User möchte ich sehen, ob die Zahl die ich eingegeben habe akzeptiert wurde (z.B. String wurde erkannt und Fehler ausgegeben), damit ich erkenne, dass ich einen Text eingegeben habe|

✍️ Jede User Story hat eine ganzzahlige Nummer (1, 2, 3 etc.), eine Verbindlichkeit (Muss oder Kann?), und einen Typ (Funktional, Qualität, Rand). Die User Story selber hat folgende Form: *Als ein 🤷‍♂️ möchte ich 🤷‍♂️, damit 🤷‍♂️*.

### 1.3 Testfälle

| TC-№ | Ausgangslage | Eingabe | Erwartete Ausgabe |
| ---- | ------------ | ------- | ----------------- |
| 1.1  | Programm gestartet | Eine Zahl eingeben | Das Programm ist nicht abgestürtzt. |
| 1.2 | Programm gestartet | Einen Text eingeben | Das Programm gibt einen Fehler aus. |
| 2.1 | Programm gestartet | Eine Zahl eingeben | Das Programm zeigt meine eingegebenen Zahlen. |
| 3.1 | Programm gestartet | Eine Zahl eingeben | Das Programm sagt, ob die Zahl zu hoch oder zu tief ist. |
| 4.1  | Programm gestartet | Eine Zahl eingeben | Das Programm gibt an, ob meine Zahl der gesuchten Zahl enspricht. |
| 5.1  | Programm gestartet | Eine Zahl eingeben | Das Programm zeigt mit Farben an, ob die gesuchte Zahl erraten wurde. |
| 6.1  | Programm gestartet | Eine Zahl oder Text eingeben | Wenn ein Text eingegeben wurde, gibt das Programm einen Fehler aus und gibt den Hinweis, dass nur Zahlen zwischen 1-100 akzeptiert werden. |

✍️ Die Nummer hat das Format `N.m`, wobei `N` die Nummer der User Story ist, die der Testfall abdeckt, und `m` von `1` an nach oben gezählt. Beispiel: Der dritte Testfall, der die zweite User Story abdeckt, hat also die Nummer `2.3`.

### 1.4 Diagramme

![1100_Diagramm](https://user-images.githubusercontent.com/110892683/186111265-f993801c-6f35-4aa1-a577-ac57c2c8e5cc.png)

## 2 Planen

| AP-№ | Frist | Zuständig | Beschreibung | geplante Zeit |
| ---- | ----- | --------- | ------------ | ------------- |
| 1.A  | 30.08.2022 |           | Der User muss Zahlen eingeben können | 15min |
| 2.A  | 30.08.2022 |           | Wenn der User Texte eingibt, soll ein Fehler angezeigt werden | 60min |
| 3.A  | 30.08.2022 |           | Das Programm gibt an, ob die eingegebene Zahl tiefer oder höher ist als die generierte | 15min |
| 4.A  | 30.08.2022 |           | Das Programm kann die eingegebene Zahl mit der generierten Vergleichen | 15min |
| 5.A  | 30.08.2022 |           | Es sollen Farben angezeigt werden | 30min |
| 6.A  | 30.08.2022 |           | Wenn eine Zahl über 100 eingegeben wird, soll der Hinweis angezeigt werden, dass nur Zahlen zwischen 1-100 erlaubt sind | 30min |
Total: 

✍️ Die Nummer hat das Format `N.m`, wobei `N` die Nummer der User Story ist, auf die sich das Arbeitspaket bezieht, und `m` von `A` an nach oben buchstabiert. Beispiel: Das dritte Arbeitspaket, das die zweite User Story betrifft, hat also die Nummer `2.C`.

✍️ Ein Arbeitspaket sollte etwa 45' für eine Person in Anspruch nehmen. Die totale Anzahl Arbeitspakete sollte etwa Folgendem entsprechen: `Anzahl R-Sitzungen` ╳ `Anzahl Gruppenmitglieder` ╳ `4`. Wenn Sie also zu dritt an einem Projekt arbeiten, für welches zwei R-Sitzungen geplant sind, sollten Sie auf `2` ╳ `3` ╳`4` = `24` Arbeitspakete kommen. Sollten Sie merken, dass Sie hier nicht genügend Arbeitspakte haben, denken Sie sich weitere "Kann"-User Stories für Kapitel 1.2 aus.

## 3 Entscheiden

✍️ Dokumentieren Sie hier Ihre Entscheidungen und Annahmen, die Sie im Bezug auf Ihre User Stories und die Implementierung getroffen haben.

## 4 Realisieren

| AP-№ | Datum | Zuständig | geplante Zeit | tatsächliche Zeit |
| ---- | ----- | --------- | ------------- | ----------------- |
| 1.A  | 30.08.2022 | Filip | 15min | 20min |
| 2.A  | 30.08.2022 | Filip | 60min | 45min |
| 3.A  | 30.08.2022 | Filip | 15min | 10min |
| 4.A  | 30.08.2022 | Filip | 15min | 20min |
| 5.A  | 30.08.2022 | Filip | 30min | 60min |
| 6.A  | 30.08.2022 | Filip | 30min | 45min |

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
