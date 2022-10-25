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
| 1    |        Muss         |   Funktional   | Ich will, dass der Nutzer eine Antwort eingeben kann, damit er spielen kann |
| 2    |        Muss         |   Funktional   | Ich will, dass die Antwort verglichen wird mit der richtigen Lösung, damit geprüft wird ob meine Antwort korrekt ist    |
| 3    |        Muss         |   Funktional   | Ich will, dass der Nutzer zwischen 2 Modi wechseln kann    |
| 4    |        Muss         |   Funktional   | Ich will, dass falsche Wörter    |
| 5    |        Muss         |   Funktional   | Ich will, dass die Wörter in einer zufälligen Reihenfolge abgefragt werden, damit der Nutzer abwechslung hat.    |
| 6    |        kann         |   Funktional   | Ich will, dass bei jeder korrekten Eingabe die Punktzahl um 1 erhöht wird, damit der Spieler weiss wie gut er ist.    |
| 6    |        kann         |   Funktional   |    |
| 6    |        kann         |   Funktional   | Ich will, dass ein Timer die Zeit von jedem    |

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

✍️ Hier können Sie PAPs, Use Case- und Gantt-Diagramme oder Ähnliches einfügen.

## 2 Planen

| AP-№ | Frist | Zuständig | Beschreibung | geplante Zeit |
| ---- | ----- | --------- | ------------ | ------------- |
| 1.A  |       |           |              |               |
| ...  |       |           |              |               |

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
