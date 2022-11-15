
# Lern-Bericht
Gruppe RAM: Tuma, Meyer, Spycher, Meister, Sacher

## Einleitung

In unserem Projekt haben wir ein Vokabeltrainer programmiert.

## Was haben wir gelernt?

Wir haben gelernt wie man Texdateien in ein Programm einlesen und diese in eine Array speichern kann.

## Beschreibung

✍️ Verwenden Sie drei verschiedene Medien, um zu zeigen, was Sie gelernt haben. Zum Beispiel:

* Eine textliche Beschreibung
![grafik](https://user-images.githubusercontent.com/110892658/201874804-8427aaf2-d867-4710-9c82-2a0726569112.png)

man sieht wie nach der letzten Frage alle falschen Antworten ausgegeben werden, diese Wörter wurden zuvor über die txt eingelesen.

![grafik](https://user-images.githubusercontent.com/110892658/201876578-85e2bdef-5fef-44f0-afaf-44a441041416.png)

Hier sieht man Wörter die falsch oder





![grafik](https://user-images.githubusercontent.com/110892658/201871767-33d21430-f99a-45c4-acc4-20a024732e25.png)


```c#
 string inPathG = @"List_G.txt";
            string inPathE = @"List_E.txt";
            string textG = File.ReadAllText(inPathG);
            string textE = File.ReadAllText(inPathE);
            string[] linesG = textG.Split("\r\n");
            string[] linesE = textE.Split("\r\n");
            List<int> gaggao = new List<int>();
            String[] answers = new string[20];
```

In diesem Auschnitt unseres Codes werden die zwei Textfiles mit den englischen Wörtern und den deutschen Übersetzungen in zwei verschiedenen Arrays gespeichert

In line 1 und 2 ist der Dateipfad der beiden Textfiles angegeben

In Line 3 und 4 werden die Textfiles zu einem langen string eingelesen

In line 5 und 6 werden diese beiden langen strings in einzelne Wörter zerlegt und dann in zwei verschiedene Arrays eingespeichert.

In der line 7 wird eine Liste erstellt, in welcher später der Index von den schon abgefragten Wörter eingespeichert wird

In line 8 wir ein Array erstellt welches später für die eingegebenen antworten des Benutzers verwendet wird.





* Ein Link zu einem *selbst aufgenommenen* youtube-Video oder `.gif`.

## Verifikation

✍️ Erklären Sie kurz und bündig, inwiefern die von Ihnen verwendeten Medien zeigen, was Sie gelernt haben.

# Reflexion zum Arbeitsprozess

👍 Überlegen Sie sich jeweils etwas, was gut an Ihrer Arbeit lief;

 

Wir hatten Probleme mit dem Organisieren, weil mehrere Mitglieder technische Probleme mit den Audiogeräten hatten, zudem war unser Gruppenleiter an einem Tag krankheitsbedingt nicht anwesend.

**VBV**: ✍️ Formulieren Sie davon ausgehend einen *handelbaren* Verbesserungsvorschlag.

Wir hätten den Gruppenleiter fragen sollen, was zu tun ist und wie wir weiter vorgehen sollen.
