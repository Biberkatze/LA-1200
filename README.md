# LA 1200
# Projekt-Dokumentation

Gruppe RAM: Tuma, Meister, Spycher, Meyer und Sacher

| Datum | Version | Zusammenfassung                                              |
| ----- | ------- | ------------------------------------------------------------ |
|       | 0.0.1   | ✍️ Jedes Mal, wenn Sie an dem Projekt arbeiten, fügen Sie hier eine neue Zeile ein und beschreiben in *einem* Satz, was Sie erreicht haben. |
|       | ...     |                                                              |
|       | 1.0.0   |                                                              |

## 1 Informieren

### 1.1 Ihr Projekt

Wir entwickeln ein Vokabeltrainer welcher Vokabeln abfragen kann.

### 1.2 User Stories

| US-№ | Verbindlichkeit | Typ  | Beschreibung                       |
| ---- | --------------- | ---- | ---------------------------------- |
| 1    |        Muss         |   Funktional   | Ich will, dass der Nutzer eine Antwort eingeben kann, damit er spielen kann. |
| 2    |        Muss         |   Funktional   | Ich will, dass meine Antwort mit der Richtigen Lösung verglichen wird, dass der Nutzer weiss ob er richtig lag.    |
| 3    |        Muss         |   Funktional   | Ich will, dass der Nutzer zwischen 2 Modi wechseln kann, damit er die Wörter besser lernt.   |
| 4    |        Muss         |   Funktional   | Ich will, dass falsche Wörter in einem zusätzlichen Array gespeichert werden, dass sie später nochmal angezeigt werden.   |
| 5    |        Muss         |   Funktional   | Ich will, dass die Wörter in einer zufälligen Reihenfolge abgefragt werden, damit der Nutzer abwechslung hat.    |
| 6    |        kann         |   Funktional   | Ich will, dass bei jeder korrekten Eingabe die Punktzahl um 1 erhöht wird, um spass zu haben.    |
| 7    |        kann         |   Funktional   | Ich will, dass am Ende der Runde die Punktzahl ausgegeben wird, um zu wissen wie gut man war.   |


✍️ Jede User Story hat eine ganzzahlige Nummer (1, 2, 3 etc.), eine Verbindlichkeit (Muss oder Kann?), und einen Typ (Funktional, Qualität, Rand). Die User Story selber hat folgende Form: *Als ein 🤷‍♂️ möchte ich 🤷‍♂️, damit 🤷‍♂️*.

### 1.3 Testfälle

| TC-№ | Ausgangslage | Eingabe | Erwartete Ausgabe |
| ---- | ------------ | ------- | ----------------- |
| 1.1  |    Programm gestartet          |    Keine eingabe     |    Deutsch -> Englisch / Englisch -> Deutsch             |
| 1.2  |    Programm gestartet          |    Deutsch -> Englisch     |   Es werden Deutsche wörter angezeigt. Bitte übersetzen Sie diese auf Englisch |
| 1.3  |    Programm gestartet          |    richtiges wort     |        Gut gemacht           |
| 1.4  |    Programm gestartet          |    falsches wort     |         bitte nochmal wiederholen          |
| 1.5  |    Programm gestartet          |    letztes richtiges wort  |   Sie haben alle wörter richtig geschrieben.|
| 1.6  |    Programm gestartet          |    Nummer          |           Bitte geben keine Zahl sondern ein Wort ein.     |

### 1.4 Diagramme

![Hauptprogramm 1](https://user-images.githubusercontent.com/110891559/197721147-887673c6-b615-430d-af8a-a3d2f4c320bb.png)


## 2 Planen

| AP-№ | Frist | Zuständig | Beschreibung | geplante Zeit |
| ---- | ----- | --------- | ------------ | ------------- |
| 1.A |   01.11.2022    |    Justus  |      Ich will, dass der Nutzer eine Antwort eingeben kann, damit er spielen kann.        |   45 min.  |
| 2.B |   08.11.2022    |    Justus  | Ich will, dass meine Antwort mit der Richtigen Lösung verglichen wird, dass der Nutzer weiss ob er richtig lag.  |   45 min.  |
| 3.C |   08.11.2022    |    Elias   | Ich will, dass der Nutzer zwischen 2 Modi wechseln kann, damit er die Wörter besser lernt.           |   90 min.  |
| 4.D |   08.11.2022    |    Robin   | Ich will, dass falsche Wörter in einem zusätzlichen Array gespeichert werden, dass sie später nochmal angezeigt werden.|   90 min.  |
| 5.E |   08.11.2022    |    Cedric  |   Ich will, dass die Wörter in einer zufälligen Reihenfolge abgefragt werden, damit der Nutzer abwechslung hat.   |   60 min.  |
| 6.F |   15.11.2022    |    Fabian  |   Ich will, dass bei jeder korrekten Eingabe die Punktzahl um 1 erhöht wird, um spass zu haben.           |   45 min.  |
| 7.G |   15.11.2022    |    Fabian  |    Ich will, dass am Ende der Runde die Punktzahl ausgegeben wird, um zu wissen wie gut man war.          |   45 min.  |

✍️ Die Nummer hat das Format `N.m`, wobei `N` die Nummer der User Story ist, auf die sich das Arbeitspaket bezieht, und `m` von `A` an nach oben buchstabiert. Beispiel: Das dritte Arbeitspaket, das die zweite User Story betrifft, hat also die Nummer `2.C`.

✍️ Ein Arbeitspaket sollte etwa 45' für eine Person in Anspruch nehmen. Die totale Anzahl Arbeitspakete sollte etwa Folgendem entsprechen: `Anzahl R-Sitzungen` ╳ `Anzahl Gruppenmitglieder` ╳ `4`. Wenn Sie also zu dritt an einem Projekt arbeiten, für welches zwei R-Sitzungen geplant sind, sollten Sie auf `2` ╳ `3` ╳`4` = `24` Arbeitspakete kommen. Sollten Sie merken, dass Sie hier nicht genügend Arbeitspakte haben, denken Sie sich weitere "Kann"-User Stories für Kapitel 1.2 aus.

## 3 Entscheiden

Wir wollen Sven nicht in unserer Gruppe, weil er Gagalaris ist

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
