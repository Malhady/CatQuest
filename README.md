# CatQuest
A game made with the Unity Engine in C#. The 2D Platformer game revolves around a fireman attempting to save as many cats around the map as they can!


# ABOUT
This game was created during a 72-hour Game Jam for the COMP3800 course I took. It was made from scratch with an empty repo at the start. Every piece of art is originally made using Adobe Photoshop. The music and sound effects were made using Bxfr. The language it is coded in is C#. The game was made in Unity Version 2019.4.10f1.


# How to Run the Game!
To play the game all you need is the Unity Engine! 

Fork the Repo. -> 
Open Unity and click "Add" a project. -> 
Open the project by double-clicking.  -> 
Wait a few minutes as the first load may take some time. -> 
Once the game has loaded, you can click the play button in the Unity Engine. 

The game should start and you will be able to use the main menu to navigate your way around the game.


# Run the Game outside of the Unity Engine!
If you would like to run the game outside of Unity you can follow the below steps.

Go to File -> Build settings -> Player Settings Tab -> Configure Game Settings as you would like and select your Platform (Windows/Mac/Linux) -> Click Build

This should create a folder with a .exe file you can run and play outside of the unity engine!
(Source on this info: https://answers.unity.com/questions/325384/how-to-export-a-finished-game-help-please.html)


# How to Play
The game uses the Arrow Keys on the keyboard to move the fireman. The fireman can jump, duck, and move left and right. Scattered throughout the map there are 
14 total Cats. Each of these Cats is stuck in a little platform surrounded by fire! The objective is to save these cats by having the fireman touch them. 
As the fireman goes through the level, each cat that is saved will increase the score by 1. Once the fireman feels they have saved enough cats they can go to that flag
under the spawn point. However, there is a time limit on how long the fireman can save the cats. If the time limit runs out and the fireman does not get to the flag 
they lose and all the cats perish with the fireman! The objective is to speed run and see how many cats the fireman can get while also getting back to the flag.


# Tips
The jump ability raises the fireman enough that if pressed repeatedly on its cooldown, the fireman will fly. However, this is inefficient  time-wise as the fireman 
needs to go as fast as possible

The fireman can stick to walls by holding the left or right arrow next to the wall. By sticking to the wall they can wait for their jump cooldown to reset allowing
them to go higher and higher!


# CREDITS
Mahdi Alhady - Developed functionality of the Main Menu, Final Screen, Pause Screen, Death Screen. Created the Map the fireman plays on. Developed the 
movement ability tp stick to walls, jumping and colliding with the fire and ending flag. 

Kevin Mortimer - Developed the score tracker between scenes. Implemented the Timer, basic movement of the cat, colliding with the Cats and assisted on the ending flag functionally

Erinn Ferguson - Created almost all the imagery, including the Main Menu, Final Screen and, Death Screen. Alongside the background, Cats, logos, etc.

Jonathan Devlin - Created the sound effects and music that played during the game.


