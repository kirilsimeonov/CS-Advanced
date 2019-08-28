Space Station Establishment

Stephen successfully started his journey in the galaxy and now he has to collect some star power in order to establish his very own Space Station.
You will be given an integer n for the size of the galaxy with square shape. On the next n lines, you will receive the rows of the galaxy. Stephen’s spaceship will be placed on a random position, marked with the letter 'S'. On random positions there will be stars, marked with a single digit. There may also be black holes. Their count will be either 0 or 2 and they are marked with the letter - 'O'. All of the empty positions will be marked with '-'.
Each turn, you will be given commands for the player’s movement. Move commands will be: "up", "down", "left", "right". If he moves to a star, he collects energy equal to the digit there and the star disappears. If he moves to a black hole, he appears on the position of the other black hole and then both black holes disappear. If a player goes out of the galaxy, he goes into the void, disappears from the galaxy and is lost forever. He needs at least 50 star power to build the Space Station.
When the player is lost in the void or collects enough star power, the journey ends.
Input
On the first line, you are given the integer n – the size of the square matrix.
The next n lines holds the values for every row.
On each of the next lines you will get a move command.
Output
On the first line:
If the player goes to the void, print: "Bad news, the spaceship went to the void."
If the player collects enough star power, print: "Good news! Stephen succeeded in collecting enough star power!"
On the second line print all star power collected: "Star power collected: {starPower}"
In the end print the matrix.
Constraints
The size of the square matrix will be between [2…10].
There will always be 0 or 2 black holes, marked with the letter - 'O'.
The player position will be marked with 'S'.
The player will always go to the void or collect enough star power.Examples
