Spaceship Crafting

Stephen wants to build a spaceship and start travelling through the galaxy. He has some materials, which upon mixing can give him the more advanced materials he needs to build the spaceship. You have to help him get the job done.
First, you will be given a sequence of integers, representing chemical liquids. Afterwards, you will be given another sequence of integers representing physical items. 
You need to start from the first liquid and try to mix it with the last physical item. If the sum of their values is equal to any of the items in the table below – create the item corresponding to the value and remove both the liquid and the physical item. Otherwise, remove only the liquid and increase the value of the item by 3. You need to stop combining when you have no more liquids or physical items.


In order to build a spaceship, Stephen needs one of each of the Advanced materials. 
Input
On the first line, you will receive the integers representing the chemical liquids, separated by a single space. 
On the second line, you will receive the integers representing the physical items, separated by a single space.
Output
On the first line of output – print if Stephen succeeded in building the spaceship:
"Wohoo! You succeeded in building the spaceship!"
"Ugh, what a pity! You didn't have enough materials to build the spaceship."
On the second line - print all liquids you have left:
If there are no liquids: "Liquids left: none"
If there are liquids: "Liquids left: {liquid1}, {liquid2}, {liquid3}, (…)"
On the third line - print all physical materials you have left:
If there are no items: "Physical items left: none"
If there are items: "Physical items left: {item1}, {item2}, {item3}, (…)"
Then, you need to print all Advanced Materials and the amount you have of them, ordered alphabetically:
"Aluminium: {amount}"
"Carbon fiber: {amount}"
"Glass: {amount}"
"Lithium: {amount}"
Constraints
All of the given numbers will be valid integers in the range [0, 100].
Advanced materials can be crafted more than once.
Examples






