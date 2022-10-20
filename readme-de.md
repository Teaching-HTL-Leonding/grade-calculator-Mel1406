# Notenrechner

## Einleitung

In dieser Übung müssen Sie einen *Notenrechner* implementieren. Benutzer geben die Punkte ein, die sie bei Prüfungen und Hausaufgaben erreicht haben. Daraus errechnet sich die Note. Die Übung ist in Levels gegliedert. Versuche so viele wie möglich zu lösen.

## Level 1

* Fragen Sie die Person, ob sie an der ersten schriftlichen Prüfung teilgenommen hat.
  * Wenn ja, fragen Sie nach der Punktzahl, die sie in der ersten schriftlichen Prüfung hatte (0-20 Punkte).
* Fragen Sie die Person, ob sie an der zweiten schriftlichen Prüfung teilgenommen hat.
  * Wenn ja, fragen Sie nach der Punktzahl, die sie in der zweiten Klausur hatte (0-20 Punkte).
* Berechnen Sie den Prozentsatz der Punkte, die die Person erreicht hat (*Gesamtpunktzahl / mögliche Punkte \* 100*)
* Ermitteln Sie die Note anhand des Prozentsatzes gemäß der folgenden Tabelle:

| Note  | Min. Prozentsatz (incl.) |
| ----- | ------------------------ |
| 1     | 89                       |
| 2     | 76                       |
| 3     | 63                       |
| 4     | 50                       |
| 5     | Less than 50 perc.       |

* Zeigen Sie die Note auf dem Bildschirm an.

## Level 2

Level 2 hat die gleichen Anforderungen wie Level 1 und zusätzlich folgende:

* Fragen Sie die Person nach der Anzahl der Punkte, die sie durch die Hausaufgaben erreicht hat (0-20 Punkte).
  * Berücksichtigen Sie die Hausaufgabenpunkte bei der Notenberechnung

## Level 3

Level 3 hat die gleichen Anforderungen wie Level 2 und zusätzlich folgende:

* Fragen Sie die Person, ob sie eine mündliche Prüfung abgelegt hat.
  * Wenn ja, fragen Sie nach der Punktzahl, die sie für die mündliche Prüfung erreicht hat (0-20 Punkte).
* Berücksichtigen Sie die Punkte für die mündliche Prüfung bei der Notenberechnung

## Level 4

Level 4 hat die gleichen Anforderungen wie Level 3 und zusätzlich folgende:

* Berechnen Sie, ob die Person eine bessere Note bekommen hätte, wenn sie alle möglichen Punkte für Hausaufgaben (20) erreicht hätte.
  * Wenn ja, gib eine Nachricht auf dem Bildschirm aus (z. B. *Du hättest eine bessere Note bekommen können, wenn du die Hausaufgaben gemacht hättest!*)
