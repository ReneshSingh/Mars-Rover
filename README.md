# Mars Rover

## About the application 

This application is meant to simulate a navigation system of a Mars rover.

## How it works *****

This application starts by taking two integers as input. These numbers define the boundary of the grid in which the rover will operate. The starting point is assumed to be the point (0, 0).

The second input requested is the rovers starting point and the direction in which it is facing. The format of this input is (x coordinate; space; y coordinate; space; compass point in which the rover is facing). Once this input has been received by the navigation system it does a bound check to see whether the value is within the range indicated, if not the value is adjusted such that it is the next closest value.

The third form of input this application takes is a list of commands to execute. A list of these commands are below and what they are meant to do. During each move or rotation a check is done to make sure that the new value is within the range, if not the move or rotation is rolled back. 
* M = move the rover one space forward in the direction it is pointing.
* R = turn the rover 90 degrees to the right.
* L = turns the rover 90 degrees to the left.

The fourth and final type of input requests the user to enter ‘Y’ if they would like to enter more instructions for the rover to perform.

Once the application has received the list of commands to perform it is sent to the navigation system class where the actions are performed. Once this has happened the new coordinates and viewing direction of the rover is printed to the screen.

## Design of the application *****

I started building the application by designing what the navigation system would look like and determining what the minimum functions and variables would be. Once this determination was made I created the declarations and associated information. As it started taking form I built in some basic checks and defaults to reduce errors and enhance refactoring of and he code if needed. 

As I started building the main program I tested each feature and its associated functional components by running the code and doing a data trace.  

A few decisions that were made and fall outside of the scope of the stated requirements are listed below.
* Bounds check: the location of the rover is checked when the starting location is entered and after any move. The purpose of the check is to keep the rover within the specified grid area. The check also moves the rover back to the nearest point in the grid.
* The feature that takes the instructions to the rover is in a do … while loop to make it easier to test that feature and just in case the user wanted to submit more instructions for the rover to perform.
* The application was billed using OOP (object oriented principals) to insure modularity; reuse and refactoring if necessary. This principle also makes the code easier to read and debug if needed. 

## Credits & acknowledgements *****

This application was developed using Microsoft visual studio 2017 community edition. It was developed by Renesh Singh under instruction from Next 45.

This program was meant as a proof of knowledge and ability.
