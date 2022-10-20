# Grade Calculator

## Introduction

In this exercise you have to implement a *grade calculator*. Users enter the points that they got on exams and on homework. Based on that, you must calculate the grade. The exercise is structured in levels. Try to solve as many as possible.

## Level 1

* Ask the student if she has participated in the first written exam.
  * If she has, ask for the number of points she had in the first written exam (0-20 points).
* Ask the student if she has participated in the second written exam.
  * If she has, ask for the number of points she had in the second written exam (0-20 points).
* Calculate the percentage of points the student reached (*total points / possible points \* 100*)
* Find out the grade based on the percentage according to the following table:

| Grade | Min. Percentage (incl.) |
| ----- | ----------------------- |
| 1     | 89                      |
| 2     | 76                      |
| 3     | 63                      |
| 4     | 50                      |
| 5     | Less than 50 perc.      |

* Print the grade on the screen

## Level 2

Level 2 has the same requirements as level 1, and additionally the following:

* Ask the student for the number of points she got through homework (0-20 points).
* Consider the homework points when doing the grade calculations

## Level 3

Level 3 has the same requirements as level 2, and additionally the following:

* Ask the student if she has done an oral exam.
  * If she has, ask for the number of points she became for the oral exam (0-20 points).
* Consider the points for the oral exam when doing the grade calculations

## Level 4

Level 4 has the same requirements as level 3, and additionally the following:

* Calculate if the student would have gotten a better grade if she had reached all possible points for homework (20).
  * If she would have, print a message on the screen (e.g. *But you could have gotten a better grade if you had done the homework!*)
