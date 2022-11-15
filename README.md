# LA 1200
# Projekt-Dokumentation

Gruppe RAM: Tuma, Meister, Spycher, Meyer und Sacher

| Datum | Version | Zusammenfassung                                              |
| ----- | ------- | ------------------------------------------------------------ |
|   25.10.2022    | 0.0.1   |  Wir haben alle Userstories kreiert und angefangen die Datenbank zu schreiben.     | 
|   01.11.2022    | 0.1.0   |  Die Datenbank wurde fertiggestellt und die ersten Userstories wurden abgearbeitet.       |
|   08.11.2022    | 0.1.1   |  Wir haben das Programm fertig programmiert.    |

## 1 Informieren

### 1.1 Ihr Projekt

Wir entwickeln ein Vokabeltrainer welcher Vokabeln abfragen kann.

### 1.2 User Stories

| US-№ | Verbindlichkeit | Typ  | Beschreibung                       |
| ---- | --------------- | ---- | ---------------------------------- |
| 1    |        Muss         |   Funktional   | Ich will, dass die erstellte Datenbank eingelesen wird, dass wir Wörter in einem Array speichern können |
| 2    |        Muss         |   Funktional   | Ich will, dass der Nutzer eine Antwort eingeben kann, damit er spielen kann. |
| 3    |        Muss         |   Funktional   | Ich will, dass meine Antwort mit der Richtigen Lösung verglichen wird, dass der Nutzer weiss ob er richtig lag.    |
| 4    |        Muss         |   Funktional   | Ich will, dass alles mit Try Catch behandelt wird, dass es keine Fehler gibt.   |
| 5    |        Muss         |   Funktional   | Ich will, dass falsche Wörter in einem zusätzlichen Array gespeichert werden, dass sie später nochmal angezeigt werden.   |
| 6    |        Muss         |   Funktional   | Ich will, dass die Wörter in einer zufälligen Reihenfolge abgefragt werden, damit der Nutzer abwechslung hat.    |
| 7    |        kann         |   Funktional   | Ich will, dass bei jeder korrekten Eingabe die Punktzahl um 1 erhöht wird, um spass zu haben.    |
| 8    |        kann         |   Funktional   | Ich will, dass am Ende der Runde die Punktzahl ausgegeben wird, um zu wissen wie gut man war.   |




### 1.3 Testfälle

| TC-№ | Ausgangslage | Eingabe | Erwartete Ausgabe |
| ---- | ------------ | ------- | ----------------- |
| 1.2  |    Programm gestartet          |    Keine eingabe     |    Deutsch -> Englisch / Englisch -> Deutsch             |
| 1.3  |    Programm gestartet          |    Deutsch -> Englisch     |   Es werden Deutsche wörter angezeigt. Bitte übersetzen Sie diese auf Englisch |
| 1.4  |    Programm gestartet          |    faklsche SChreibweise   |        Eingabe ungültig, probiere nochmal         |
| 1.5  |    Programm gestartet          |    falsches wort     |         bitte nochmal wiederholen          |
| 1.6  |    Programm gestartet          |    letztes richtiges wort  |   Sie haben alle wörter richtig geschrieben.|
| 1.7  |    Programm gestartet          |    Nummer          |           Bitte geben keine Zahl sondern ein Wort ein.     |

### 1.4 Diagramme

![Hauptprogramm 1](https://user-images.githubusercontent.com/110891559/197721147-887673c6-b615-430d-af8a-a3d2f4c320bb.png)


## 2 Planen

| AP-№ | Frist | Zuständig | Beschreibung | geplante Zeit |
| ---- | ----- | --------- | ------------ | ------------- |
| 1.A |   01.11.2022    |    Justus  | die Datenbank einlesen  |   45 min.  |
| 2.B |   01.11.2022    |    Justus  | Antwort Eingabe  |   45 min.  |
| 3.C |   01.11.2022    |    Cedric  | Überprüfung der eingegebenen Antwort.  |   45 min.  |
| 4.D |   08.11.2022    |    Elias   | Alles mit Try Catch behandeln.          |   90 min.  |
| 5.E |   08.11.2022    |    Robin   | speichern von falschen Wörtern fürs Repetieren   |   90 min.  |
| 6.F |   08.11.2022    |    Cedric  | Zufällige Reihenfolge von den Wörtern  |   60 min.  |
| 7.G |   08.11.2022    |    Fabian  | Scorecounter der immer um 1 erhöht wird.        |   45 min.  |
| 8.H |   08.11.2022    |    Fabian  | Ausgabe der Punkte am Ende der Runde.   |   45 min.  |


## 3 Entscheiden

Wir haben uns entschieden nur funktionale Userstories im muss umzusetzen, weil wir zu wenig Zeit haben.

## 4 Realisieren

| AP-№ | Datum | Zuständig | geplante Zeit | tatsächliche Zeit |
| ---- | ----- | --------- | ------------- | ----------------- |
| 1.A  |   01.11.2022    |     Justus      |       45 min.        |          90 min         |
| 2.B  |   08.11.2022    |     Justus      |       45 min.        |          90 min         |
| 3.C  |   08.11.2022    |     Cedric      |       45 min.        |                   |
| 4.D  |   08.11.2022    |     Elias       |       90 min.        |                   |
| 5.E  |   08.11.2022    |     Robin       |       90 min.        |                   |
| 6.F  |   08.11.2022    |     Fabian      |       60 min.        |                   |



## 5 Kontrollieren

### 5.1 Testprotokoll

| TC-№ | Datum | Resultat | Tester |
| ---- | ----- | -------- | ------ |
| 1.2  |   15.11.2022    |          |    Fabian    |
| 1.3  |   15.11.2022    |          |    Fabian    |
| 1.4  |   15.11.2022    |          |    Fabian    |
| 1.5  |   15.11.2022    |          |    Fabian    |
| 1.6  |   15.11.2022    |          |    Fabian    |
| 1.7  |   15.11.2022    |          |    Fabian    |


## 6 Auswerten

✍️ Fügen Sie hier eine Verknüpfung zu Ihrem Lern-Bericht ein.
