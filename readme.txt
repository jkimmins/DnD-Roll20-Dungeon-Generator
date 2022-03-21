This file contains instructions on how to use the dungeon generator and generate the created creatures
in Roll20 (A Pro subscription is required to use the script in Roll20).

When the generator is opened 6 options should appear:
	Dungeon Theme
	Tile Style
	Dungeon Size
	Room Size
	Maximum CR
	Maximum Exp

Dungeon Theme determines what creatures the generator will create and has the following options:
	Goblinoids
	Undead
	Bandits
	Cultists

	Goblinoids have the following creature set:
		Goblin
		Hobgoblin
		Worg
		Bugbear
		Ogre
		Troll
	Undead have the following creature set:
		Skeleton
		Zombie
		Shadow
		Ghoul
		Specter
		Ghast
		Minotaur Skeleton
		Ogre Zombie
		Will-o'-Wisp
		Wight
		Ghost
		Wraith
	Bandits have the following creature set:
		Bandit
		Wolf
		Thug
		Bandit Captain
		Veteran
		Gladiator
	Cultists have the following set:
		Cultist
		Acolyte
		Cult Fanatic
		Veteran

	Only creatures found on the 5th edition SRD are used.

Tile Style determines what colour tiles are used in the dungeon image, the options are:
	Black/White - Empty space is black, rooms are white
	Grey - Empty space is dark grey, rooms are light grey
	Brown - Empty Space is dark brown, rooms are light brown

Dungeon Size determines the total size of the dungeon, sizes are:
	Small - 20x20
	Medium - 30x30
	Large - 60x60

Room Size determines how big the rooms can be:
	Small - 10th of the dungeon size
	Medium - 5th of the dungeon size
	Large - 3rd or 4th of the dungeon size

Maxium CR determines the strength of the creatures that will be created and ranges from 0.5 to 5

Maximum EXP limits how many creatures are placed in the dungeon based on their exp value. The maximum exp value may not be reached if there's not enough space for the creatures.

===== GENERATOR OUTPUTS =====
The generator creates two outputs:
	A png of the dungeon
	A .txt file containing the positions of the generated creatures

===== PLACING THE DUNGEON AND CREATURES INTO ROLL20 =====
1. Add the PlaceCreatures.js script into your Roll20 game. (A Pro subscription is required)
2. Create a new page or edit the current page with the following settings based on the dungeon size:
	If the dungeon size is small set height and width to 20px X 70px
	If the dungeon size is medium set height and width to 30px X 70px
	If the dungeon size is large set height and width to 60px X 70px
3. Upload "dungeonFile.png" into your Roll20 library
4. Select the map layer and drag "dungeonFile" onto the page
5. Resize the image so that it fills the entire page. The page squares should fit cleanly with the map.
6. Create a handout in Roll20 called "Positions" (Remove speech marks, this must be spelled correctly).
7. Open "Creatures.txt".
8. Right click and press "Select All".
9. Press CTRL+C or copy.
10. Open the "Positions" handout in Roll20 and paste the contents of "Creatures.txt" into the "notes" section of the "Positions" handout.
11. Save the "Positions" handout.
12. Type "!pm" (no speech marks) into the Roll20 chat. The generated creatures will be placed onto the page with their own tokens which contain their health and armour class.

Note that the tokens will be placed on the page in which the red player bookmark is so make sure it's on the correct page before executing the command.