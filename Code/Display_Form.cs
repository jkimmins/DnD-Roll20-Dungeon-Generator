using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace DungeonGenerator
{
    // Struct which contains various attributes about the randomly generated creatures
    public struct Creature
    {
        public int posX, posY;
        public string name, size;
    }

    public partial class Display_Form : Form
    {
        // Function which creates the rooms/corridors for the dungeon and fills them with creatures
        public void createLeaves(ref int[,] _roomArray, ref List<Creature> _creatures, int _dSize, int _rSize, int _maxExp, float _cr, string _theme)
        {
            // Variables initialised/declared
            int maxLeafSize = _dSize / 2;
            int randNum, randRoom;
            int runningExp = 0;
            List<Leaf> leaves = new List<Leaf>();
            Leaf root = new Leaf(0, 0, _dSize - 1, _dSize - 1, _dSize, _rSize);
            leaves.Add(root);
            bool didSplit = true;
            Random random = new Random();
            Creature creature;

            // Splits the dungeon into smaller sections using a binary tree
            while (didSplit)
            {
                didSplit = false;

                foreach (Leaf l in leaves.ToList())
                {
                    if (l.leftChild == null && l.rightChild == null)
                    {
                        if (l.width > maxLeafSize || l.height > maxLeafSize)
                        {
                            if (l.Split())
                            {
                                leaves.Add(l.leftChild);
                                leaves.Add(l.rightChild);
                                didSplit = true;
                            }
                        }
                    }
                }
            }

            // Places rooms in every node on the binary tree
            root.createRooms(ref _roomArray);

            // Random value generated for random dungeon theme option
            randRoom = random.Next(0, 3);

            // Loop which goes through every node on the binary tree
            foreach (Leaf l in leaves)
            {
                // Room tiles are marked with a 9 in the room 2d array
                for (int x = l.room.posX; x <= l.room.posX + l.room.width; x++)
                {
                    _roomArray[x, l.room.posY] = 9;
                    _roomArray[x, (l.room.posY + l.room.height)] = 9;
                }

                for (int y = l.room.posY; y <= l.room.posY + l.room.height; y++)
                {
                    _roomArray[l.room.posX, y] = 9;
                    _roomArray[(l.room.posX + l.room.width), y] = 9;
                }

                for (int z = (l.room.height - 2); z >= 0; z--)
                {
                    for (int a = (l.room.width - 2); a >= 0; a--)
                    {
                        _roomArray[(l.room.posX + a + 1), (l.room.posY + z + 1)] = 9;
                    }
                }

                // If statements checks which dungeon theme is being used
                if (_theme == "Goblinoids" || (_theme == "Random Theme" && randRoom == 0))
                {
                    // Loops through every position in the room
                    for (int b = l.room.posX + 1; b < l.room.width + l.room.posX; b++)
                    {
                        for (int a = l.room.posY + 1; a < l.room.height + l.room.posY; a++)
                        {
                            // If the exp created by generated creatures doesn't exceed the maximum exp allowed
                            if (runningExp < _maxExp)
                            {
                                // A random creature is created if it's exp value doesn't exceed the maximum
                                randNum = random.Next(1, 145);
                                if (randNum <= 35 && (runningExp + 50) <= _maxExp)
                                {
                                    // creature struct is filled in with relevent values and added to the creature list. Creatures exp value is added to the running value
                                    creature.posX = a;
                                    creature.posY = b;
                                    creature.size = "Small";
                                    creature.name = "Goblin";
                                    _creatures.Add(creature);
                                    runningExp += 50;
                                }
                                else if (randNum > 35 && randNum <= 65 && (runningExp + 100) <= _maxExp)
                                {
                                    creature.posX = a;
                                    creature.posY = b;
                                    creature.size = "Medium";
                                    creature.name = "Hobgoblin";
                                    _creatures.Add(creature);
                                    runningExp += 100;
                                }
                                else if (randNum > 65 && randNum <= 95 && (runningExp + 100) <= _maxExp)
                                {
                                    creature.posX = a;
                                    creature.posY = b;
                                    creature.size = "Large";
                                    creature.name = "Worg";
                                    _creatures.Add(creature);
                                    runningExp += 100;
                                    a++;
                                    b++;
                                }
                                else if (randNum > 95 && randNum <= 120 && (runningExp + 200) <= _maxExp && _cr > 0.5)
                                {
                                    creature.posX = a;
                                    creature.posY = b;
                                    creature.size = "Medium";
                                    creature.name = "Bugbear";
                                    _creatures.Add(creature);
                                    runningExp += 200;
                                }
                                else if (randNum > 120 && randNum <= 140 && (runningExp + 450) <= _maxExp && _cr > 1)
                                {
                                    creature.posX = a;
                                    creature.posY = b;
                                    creature.size = "Large";
                                    creature.name = "Ogre";
                                    _creatures.Add(creature);
                                    runningExp += 450;
                                    a++;
                                    b++;
                                }
                                else if (randNum > 140 && randNum <= 145 && (runningExp + 1800) <= _maxExp && _cr > 4)
                                {
                                    creature.posX = a;
                                    creature.posY = b;
                                    creature.size = "Large";
                                    creature.name = "Troll";
                                    _creatures.Add(creature);
                                    runningExp += 1800;
                                    a++;
                                    b++;
                                }
                            }
                        }
                    }
                }
                // Same process as Goblinoids just with different creatures
                else if (_theme == "Undead" || (_theme == "Random Theme" && randRoom == 1))
                {
                    for (int b = l.room.posX + 1; b < l.room.width + l.room.posX; b++)
                    {
                        for (int a = l.room.posY + 1; a < l.room.height + l.room.posY; a++)
                        {
                            if (runningExp < _maxExp)
                            {
                                randNum = random.Next(1, 260);
                                if (randNum <= 35 && (runningExp + 50) <= _maxExp)
                                {
                                    creature.posX = a;
                                    creature.posY = b;
                                    creature.size = "Medium";
                                    creature.name = "Skeleton";
                                    _creatures.Add(creature);
                                    runningExp += 50;
                                }
                                else if (randNum > 35 && randNum <= 70 && (runningExp + 50) <= _maxExp)
                                {
                                    creature.posX = a;
                                    creature.posY = b;
                                    creature.size = "Medium";
                                    creature.name = "Zombie";
                                    _creatures.Add(creature);
                                    runningExp += 50;
                                }
                                else if (randNum > 70 && randNum <= 100 && (runningExp + 100) <= _maxExp)
                                {
                                    creature.posX = a;
                                    creature.posY = b;
                                    creature.size = "Medium";
                                    creature.name = "Shadow";
                                    _creatures.Add(creature);
                                    runningExp += 100;
                                }
                                else if (randNum > 100 && randNum <= 125 && (runningExp + 200) <= _maxExp && _cr > 0.5)
                                {
                                    creature.posX = a;
                                    creature.posY = b;
                                    creature.size = "Medium";
                                    creature.name = "Ghoul";
                                    _creatures.Add(creature);
                                    runningExp += 200;
                                }
                                else if (randNum > 125 && randNum <= 150 && (runningExp + 200) <= _maxExp && _cr > 0.5)
                                {
                                    creature.posX = a;
                                    creature.posY = b;
                                    creature.size = "Medium";
                                    creature.name = "Specter";
                                    _creatures.Add(creature);
                                    runningExp += 200;
                                }
                                else if (randNum > 150 && randNum <= 170 && (runningExp + 450) <= _maxExp && _cr > 1)
                                {
                                    creature.posX = a;
                                    creature.posY = b;
                                    creature.size = "Medium";
                                    creature.name = "Ghast";
                                    _creatures.Add(creature);
                                    runningExp += 450;
                                }
                                else if (randNum > 170 && randNum <= 190 && (runningExp + 450) <= _maxExp && _cr > 1)
                                {
                                    creature.posX = a;
                                    creature.posY = b;
                                    creature.size = "Large";
                                    creature.name = "Minotaur_Skeleton";
                                    _creatures.Add(creature);
                                    runningExp += 450;
                                    a++;
                                    b++;
                                }
                                else if (randNum > 190 && randNum <= 210 && (runningExp + 450) <= _maxExp && _cr > 1)
                                {
                                    creature.posX = a;
                                    creature.posY = b;
                                    creature.size = "Large";
                                    creature.name = "Ogre_Zombie";
                                    _creatures.Add(creature);
                                    runningExp += 450;
                                    a++;
                                    b++;
                                }
                                else if (randNum > 210 && randNum <= 230 && (runningExp + 450) <= _maxExp && _cr > 1)
                                {
                                    creature.posX = a;
                                    creature.posY = b;
                                    creature.size = "Tiny";
                                    creature.name = "Will-o-Wisp";
                                    _creatures.Add(creature);
                                    runningExp += 450;
                                }
                                else if (randNum > 230 && randNum <= 245 && (runningExp + 700) <= _maxExp && _cr > 2)
                                {
                                    creature.posX = a;
                                    creature.posY = b;
                                    creature.size = "Medium";
                                    creature.name = "Wight";
                                    _creatures.Add(creature);
                                    runningExp += 700;
                                }
                                else if (randNum > 245 && randNum <= 255 && (runningExp + 1100) <= _maxExp && _cr > 3)
                                {
                                    creature.posX = a;
                                    creature.posY = b;
                                    creature.size = "Medium";
                                    creature.name = "Ghost";
                                    _creatures.Add(creature);
                                    runningExp += 1100;
                                }
                                else if (randNum > 255 && randNum <= 260 && (runningExp + 1800) <= _maxExp && _cr > 4)
                                {
                                    creature.posX = a;
                                    creature.posY = b;
                                    creature.size = "Medium";
                                    creature.name = "Wraith";
                                    _creatures.Add(creature);
                                    runningExp += 1800;
                                }
                            }
                        }
                    }
                }
                // Same process as Goblinoids just with different creatures
                else if (_theme == "Bandits" || (_theme == "Random Theme" && randRoom == 2))
                {
                    for (int b = l.room.posX + 1; b < l.room.width + l.room.posX; b++)
                    {
                        for (int a = l.room.posY + 1; a < l.room.height + l.room.posY; a++)
                        {
                            if (runningExp < _maxExp)
                            {
                                randNum = random.Next(1, 145);
                                if (randNum <= 40 && (runningExp + 25) <= _maxExp)
                                {
                                    creature.posX = a;
                                    creature.posY = b;
                                    creature.size = "Medium";
                                    creature.name = "Bandit";
                                    _creatures.Add(creature);
                                    runningExp += 25;
                                }
                                else if (randNum > 40 && randNum <= 75 && (runningExp + 50) <= _maxExp)
                                {
                                    creature.posX = a;
                                    creature.posY = b;
                                    creature.size = "Medium";
                                    creature.name = "Wolf";
                                    _creatures.Add(creature);
                                    runningExp += 50;
                                }
                                else if (randNum > 75 && randNum <= 105 && (runningExp + 100) <= _maxExp)
                                {
                                    creature.posX = a;
                                    creature.posY = b;
                                    creature.size = "Medium";
                                    creature.name = "Thug";
                                    _creatures.Add(creature);
                                    runningExp += 100;
                                }
                                else if (randNum > 105 && randNum <= 125 && (runningExp + 450) <= _maxExp && _cr > 1)
                                {
                                    creature.posX = a;
                                    creature.posY = b;
                                    creature.size = "Medium";
                                    creature.name = "Bandit_Captain";
                                    _creatures.Add(creature);
                                    runningExp += 450;
                                }
                                else if (randNum > 125 && randNum <= 140 && (runningExp + 700) <= _maxExp && _cr > 2)
                                {
                                    creature.posX = a;
                                    creature.posY = b;
                                    creature.size = "Medium";
                                    creature.name = "Veteran";
                                    _creatures.Add(creature);
                                    runningExp += 700;
                                }
                                else if (randNum > 140 && randNum <= 145 && (runningExp + 1800) <= _maxExp && _cr > 4)
                                {
                                    creature.posX = a;
                                    creature.posY = b;
                                    creature.size = "Medium";
                                    creature.name = "Gladiator";
                                    _creatures.Add(creature);
                                    runningExp += 1800;
                                }
                            }
                        }
                    }
                }
                // Same process as Goblinoids just with different creatures
                else // Cultists
                {
                    for (int b = l.room.posX + 1; b < l.room.width + l.room.posX; b++)
                    {
                        for (int a = l.room.posY + 1; a < l.room.height + l.room.posY; a++)
                        {
                            if (runningExp < _maxExp)
                            {
                                randNum = random.Next(1, 110);
                                if (randNum <= 40 && (runningExp + 25) <= _maxExp)
                                {
                                    creature.posX = a;
                                    creature.posY = b;
                                    creature.size = "Medium";
                                    creature.name = "Cultist";
                                    _creatures.Add(creature);
                                    runningExp += 25;
                                }
                                else if (randNum > 40 && randNum <= 75 && (runningExp + 50) <= _maxExp)
                                {
                                    creature.posX = a;
                                    creature.posY = b;
                                    creature.size = "Medium";
                                    creature.name = "Acolyte";
                                    _creatures.Add(creature);
                                    runningExp += 50;
                                }
                                else if (randNum > 75 && randNum <= 95 && (runningExp + 450) <= _maxExp && _cr > 1)
                                {
                                    creature.posX = a;
                                    creature.posY = b;
                                    creature.size = "Medium";
                                    creature.name = "Cult_Fanatic";
                                    _creatures.Add(creature);
                                    runningExp += 450;
                                }
                                else if (randNum > 95 && randNum <= 110 && (runningExp + 700) <= _maxExp && _cr > 2)
                                {
                                    creature.posX = a;
                                    creature.posY = b;
                                    creature.size = "Medium";
                                    creature.name = "Veteran";
                                    _creatures.Add(creature);
                                    runningExp += 700;
                                }
                            }
                        }
                    }
                }
            }
        }

        public Display_Form(string _dungeonTheme, string _tileStyle, string _dungeonSize, string _roomSize, string _maxCR, int _maxExp)
        {
            InitializeComponent();

            // Displays chosen values on the display form
            Dungeon_Theme_Display.Text = _dungeonTheme;
            Tile_Style_Display.Text = _tileStyle;
            Dungeon_Size_Display.Text = _dungeonSize;
            Room_Size_Display.Text = _roomSize;
            Max_CR_Display.Text = _maxCR;
            Max_EXP_Display.Text = _maxExp.ToString();

            Random random = new Random();
            int rand;
            int dSize;
            int rSize;
            float cr;

            // Dungeon size is set based on the chosen option
            switch (_dungeonSize)
            {
                case "Small":
                    dSize = 20;
                    break;
                case "Medium":
                    dSize = 30;
                    break;
                case "Large":
                    dSize = 60;
                    break;
                case "Random Size":
                    rand = random.Next(0, 2);

                    switch (rand)
                    {
                        case 0:
                            dSize = 20;
                            break;
                        case 1:
                            dSize = 30;
                            break;
                        case 2:
                            dSize = 60;
                            break;
                        default:
                            dSize = 20;
                            break;
                    }
                    break;
                default:
                    dSize = 20;
                    break;
            }

            // Room size is set based on the chosen option
            switch (_roomSize)
            {
                case "Small":
                    if (dSize == 20)
                    {
                        rSize = 5;
                    }
                    else
                    {
                        rSize = 10;
                    }
                    break;
                case "Medium":
                    rSize = 5;
                    break;
                case "Large":
                    rSize = 3;
                    break;
                case "Random Size":
                    rand = random.Next(0, 2);

                    switch (rand)
                    {
                        case 0:
                            if (dSize == 20)
                            {
                                rSize = 5;
                            }
                            else
                            {
                                rSize = 10;
                            }
                            break;
                        case 1:
                            rSize = 5;
                            break;
                        case 2:
                            if (dSize == 20)
                            {
                                rSize = 4;
                            }
                            else
                            {
                                rSize = 3;
                            }
                            break;
                        default:
                            rSize = 10;
                            break;
                    }
                    break;
                default:
                    rSize = 10;
                    break;
            }

            // Maxiumum Challenge Rating is set based on the chosen option
            // Challenge rating is a measuring tool used in D&D to describe how powerful a creature is, the higher the CR the more powerful the creature is.
            switch (_maxCR)
            {
                case "0.5":
                    cr = 0.5f;
                    break;
                case "1":
                    cr = 1;
                    break;
                case "2":
                    cr = 2;
                    break;
                case "3":
                    cr = 3;
                    break;
                case "4":
                    cr = 4;
                    break;
                case "5":
                    cr = 5;
                    break;
                case "Random CR":
                    rand = random.Next(0, 5);

                    switch (rand)
                    {
                        case 0:
                            cr = 0.5f;
                            break;
                        case 1:
                            cr = 1;
                            break;
                        case 2:
                            cr = 2;
                            break;
                        case 3:
                            cr = 3;
                            break;
                        case 4:
                            cr = 4;
                            break;
                        case 5:
                            cr = 5;
                            break;
                        default:
                            cr = 0.5f;
                            break;
                    }
                    break;
                default:
                    cr = 0.5f;
                    break;
            }

            // List of creatures and 2d array for the dungeon is created
            List<Creature> creatures = new List<Creature>();
            int[,] roomArray = new int[dSize, dSize];

            // New bitmap object is created based on the dungeon size
            Bitmap bmp = new Bitmap(dSize * 5, dSize * 5);

            // Every space in the 2d array is filled with 0's
            for (int x = 0; x <= dSize - 1; x++)
            {
                for (int y = 0; y <= dSize - 1; y++)
                {
                    roomArray[x, y] = 0;
                }
            }

            // This function creates the dungeon/monsters by taking relevant values as arguments
            createLeaves(ref roomArray, ref creatures, dSize, rSize, _maxExp, cr, _dungeonTheme);

            // Dungeon 2D array is written out in the console for debugging
            Console.WriteLine();
            for (int x = 0; x < dSize; x++)
            {
                for (int y = 0; y < dSize; y++)
                {
                    Console.Write(roomArray[x, y]);
                }
                Console.WriteLine();
            }

            // Variables which will be used to create the dungeon image are initilised/declared
            Graphics g = Graphics.FromImage(bmp);
            Point point = new Point();
            roomArray[0, 0] = 0;
            string tile1 = "";
            string tile2 = "";
            rand = random.Next(0, 2);

            // Dungeon appearance is set based on the chosen option
            switch(_tileStyle)
            {
                case "Black/White":
                    tile1 = "whiteTile.bmp";
                    tile2 = "blackTile.bmp";
                    break;
                case "Grey":
                    tile1 = "lightGreyTile.bmp";
                    tile2 = "greyTile.bmp";
                    break;
                case "Brown":
                    tile1 = "lightBrownTile.bmp";
                    tile2 = "brownTile.bmp";
                    break;
                case "Random Style":
                    switch(rand)
                    {
                        case 0:
                            tile1 = "whiteTile.bmp";
                            tile2 = "blackTile.bmp";
                            break;
                        case 1:
                            tile1 = "lightGreyTile.bmp";
                            tile2 = "greyTile.bmp";
                            break;
                        case 2:
                            tile1 = "lightBrownTile.bmp";
                            tile2 = "brownTile.bmp";
                            break;
                    }
                    break;
                default:
                    tile1 = "whiteTile.bmp";
                    tile2 = "blackTile.bmp";
                    break;
            }

            // For loops go through the dungeons 2d array and places a tile in the bmp image based on the current position in the array
            for (int x = 0; x <= dSize - 1; x++)
            {
                for (int y = 0; y <= dSize - 1; y++)
                {
                    point.X = x * 5;
                    point.Y = y * 5;

                    // Room tile
                    if (roomArray[y, x] == 9)
                    {
                        g.DrawImage(Image.FromFile(tile1), point);
                    }
                    // Empty Tile
                    if (roomArray[y, x] == 0)
                    {
                        g.DrawImage(Image.FromFile(tile2), point);
                    }
                }
            }
            // Image is saved to the computer
            bmp.Save("dungeonFile.png");

            // Variables which will be used to create the creatures text file are initilised/declared
            string textPath = "Creatures.txt";
            var creatureFile = File.Open(textPath, FileMode.Create);
            creatureFile.Close();
            TextWriter tw = new StreamWriter(textPath);
            Console.WriteLine();
            // For loops goes through the creature list and writes the creatures position, size and name into the text file and into the console for debugging
            for (int x = 0; x < creatures.Count(); x++)
            {
                tw.Write(creatures[x].posX + " ");
                tw.Write(creatures[x].posY + " ");
                tw.Write(creatures[x].size + " ");
                tw.Write(creatures[x].name + " ");

                Console.Write(creatures[x].posX + " " + creatures[x].posY + " " + creatures[x].name);
                Console.WriteLine();
            }
            tw.Close();
        }
    }

    // Room class contains inportant values for the rooms that will be created
    public class Room
    {
        public int posX, posY, width, height;
    }

    // Cell struct contains an x/y position which is used to find positions in the dungeon 2d array
    public struct Cell
    {
        public int posX, posY;
    }

    // The leaf class is used to split the dunegon into smaller sections in which the rooms are placed
    public class Leaf
    {
        // Leaf variables are initialised/declared
        private readonly Random _random = new Random();
        private int min_leaf_size;
        public int x, y, width, height, dSize, rSize;
        public Leaf leftChild, rightChild;
        public Room room = new Room();

        public Leaf(int _x, int _y, int _width, int _height, int _dSize, int _rSize)
        {
            x = _x;
            y = _y;
            width = _width;
            height = _height;
            dSize = _dSize;
            rSize = _rSize;
            min_leaf_size = _dSize / _rSize;
        }

        // Split function splits a leaf into smaller leaves
        public bool Split()
        {
            bool splitH;
            int max;

            // If the leaf already has children then new ones can't be created
            if (leftChild != null && rightChild != null)
            {
                return false;
            }

            // Random value is generated to decide whether the leaf should be split horizontally or vertically
            int rand = _random.Next(0, 1);

            // If the width is greater than the height of the leaf then the leaf will be split vertically
            if (width > height && width / height >= 1.25)
            {
                splitH = false;
            }

            // If the height is greater than the width of the leaf then the leaf will be split horizontally
            else if (height > width && height / width >= 1.25)
            {
                splitH = true;
            }

            // If neither of the previous conditions are met the split angle will be randomly determined
            else if (rand == 0)
            {
                splitH = false;
            }

            else
            {
                splitH = true;
            }

            // Max size is set depending on how the leaf was split
            if (splitH)
            {
                max = height - min_leaf_size;
            }
            else
            {
                max = width - min_leaf_size;
            }

            // If the max size is less than the minimum leaf size then the split can't happen
            if (max <= min_leaf_size)
            {
                return false;
            }

            // Split location is randomly chosen
            int split = _random.Next(min_leaf_size, max);

            // CHildren for the current leaf are created based on the split direction
            if (splitH)
            {
                leftChild = new Leaf(x, y, width, split, dSize, rSize);
                rightChild = new Leaf(x, y + split, width, height - split, dSize, rSize);
            }
            else
            {
                leftChild = new Leaf(x, y, split, height, dSize, rSize);
                rightChild = new Leaf(x + split, y, width - split, height, dSize, rSize);
            }

            return true;
        }

        // Function which returns the room of the left or right child
        public Room getRoom()
        {
            if (room != null && room.height != 0)
            {
                return room;
            }
            else
            {
                Room lRoom = new Room();
                Room rRoom = new Room();
                int rv = _random.Next(0, 1);

                if (leftChild != null)
                {
                    lRoom = leftChild.getRoom();
                }
                if (rightChild != null)
                {
                    rRoom = rightChild.getRoom();
                }
                if (rRoom == null && lRoom.height != 0)
                {
                    return lRoom;
                }
                else if (lRoom == null && rRoom.height != 0)
                {
                    return rRoom;
                }
                else if (rv == 1 && lRoom.height != 0)
                {
                    return lRoom;
                }
                else if (rv == 0 && rRoom.height != 0)
                {
                    return rRoom;
                }
                else
                {
                    return null;
                }
            }
        }

        // Rooms and corridors are created
        public void createRooms(ref int[,] _roomArray)
        {
            if (leftChild != null && rightChild != null)
            {
                if (leftChild != null)
                {
                    leftChild.createRooms(ref _roomArray);
                }
                if (rightChild != null)
                {
                    rightChild.createRooms(ref _roomArray);
                }
                if (leftChild != null && rightChild != null)
                {
                    createHall(leftChild.getRoom(), rightChild.getRoom(), ref _roomArray);
                }
            }

            else
            {
                Cell roomSize;
                Cell roomPos;

                roomSize.posX = _random.Next(min_leaf_size / 2, width - 2);
                roomSize.posY = _random.Next(min_leaf_size / 2, height - 2);

                roomPos.posX = _random.Next(1, width - roomSize.posX - 1);
                roomPos.posY = _random.Next(1, height - roomSize.posY - 1);

                room.posX = x + roomPos.posX;
                room.posY = y + roomPos.posY;
                room.width = roomSize.posX;
                room.height = roomSize.posY;
            }
        }

        // Function creates the dungeon corridors
        public void createHall(Room _l, Room _r, ref int[,] _roomArray)
        {
            // Variables are intialised/declared
            List<Room> halls = new List<Room>();
            Room funcRoom = new Room();
            Room funcRoom2 = new Room();
            int w, h, rv;

            // Random positions are chosen in each of the rooms which are going to be connected
            Cell point1;
            point1.posX = _random.Next(_l.posX, _l.posX + _l.width);
            point1.posY = _random.Next(_l.posY, _l.posY + _l.height);

            Cell point2;
            point2.posX = _random.Next(_r.posX, _r.posX + _r.width);
            point2.posY = _random.Next(_r.posY, _r.posY + _r.height);

            w = point2.posX - point1.posX;
            h = point2.posY - point1.posY;
            rv = _random.Next(0, 1);

            // If statements are used to check the positions of the 2 points to be connected and the correct corridors are created
            if (w < 0)
            {
                if (h < 0)
                {
                    if (rv == 1)
                    {
                        // Multiple corridors are created in the case a right angle is need to connect 2 points
                        funcRoom.posX = point2.posX;
                        funcRoom.posY = point1.posY;
                        funcRoom.width = Math.Abs(w);
                        funcRoom.height = 1;
                        halls.Add(funcRoom);

                        funcRoom2.posX = point2.posX;
                        funcRoom2.posY = point2.posY;
                        funcRoom2.width = 1;
                        funcRoom2.height = Math.Abs(h);
                        halls.Add(funcRoom2);
                    }
                    else
                    {
                        funcRoom.posX = point2.posX;
                        funcRoom.posY = point2.posY;
                        funcRoom.width = Math.Abs(w);
                        funcRoom.height = 1;
                        halls.Add(funcRoom);

                        funcRoom2.posX = point1.posX;
                        funcRoom2.posY = point2.posY;
                        funcRoom2.width = 1;
                        funcRoom2.height = Math.Abs(h);
                        halls.Add(funcRoom2);
                    }
                }
                else if (h > 0)
                {
                    if (rv == 1)
                    {
                        funcRoom.posX = point2.posX;
                        funcRoom.posY = point1.posY;
                        funcRoom.width = Math.Abs(w);
                        funcRoom.height = 1;
                        halls.Add(funcRoom);

                        funcRoom2.posX = point2.posX;
                        funcRoom2.posY = point1.posY;
                        funcRoom2.width = 1;
                        funcRoom2.height = Math.Abs(h);
                        halls.Add(funcRoom2);
                    }
                    else
                    {
                        funcRoom.posX = point2.posX;
                        funcRoom.posY = point2.posY;
                        funcRoom.width = Math.Abs(w);
                        funcRoom.height = 1;
                        halls.Add(funcRoom);

                        funcRoom2.posX = point1.posX;
                        funcRoom2.posY = point1.posY;
                        funcRoom2.width = 1;
                        funcRoom2.height = Math.Abs(h);
                        halls.Add(funcRoom2);
                    }
                }
                else
                {
                    funcRoom.posX = point2.posX;
                    funcRoom.posY = point2.posY;
                    funcRoom.width = Math.Abs(w);
                    funcRoom.height = 1;
                    halls.Add(funcRoom);
                }
            }
            else if (w > 0)
            {
                if (h < 0)
                {
                    if (rv == 1)
                    {
                        funcRoom.posX = point1.posX;
                        funcRoom.posY = point2.posY;
                        funcRoom.width = Math.Abs(w);
                        funcRoom.height = 1;
                        halls.Add(funcRoom);

                        funcRoom2.posX = point1.posX;
                        funcRoom2.posY = point2.posY;
                        funcRoom2.width = 1;
                        funcRoom2.height = Math.Abs(h);
                        halls.Add(funcRoom2);
                    }
                    else
                    {
                        funcRoom.posX = point1.posX;
                        funcRoom.posY = point1.posY;
                        funcRoom.width = Math.Abs(w);
                        funcRoom.height = 1;
                        halls.Add(funcRoom);

                        funcRoom2.posX = point2.posX;
                        funcRoom2.posY = point2.posY;
                        funcRoom2.width = 1;
                        funcRoom2.height = Math.Abs(h);
                        halls.Add(funcRoom2);
                    }
                }
                else if (h > 0)
                {
                    if (rv == 1)
                    {
                        funcRoom.posX = point1.posX;
                        funcRoom.posY = point1.posY;
                        funcRoom.width = Math.Abs(w);
                        funcRoom.height = 1;
                        halls.Add(funcRoom);

                        funcRoom2.posX = point2.posX;
                        funcRoom2.posY = point1.posY;
                        funcRoom2.width = 1;
                        funcRoom2.height = Math.Abs(h);
                        halls.Add(funcRoom2);
                    }
                    else
                    {
                        funcRoom.posX = point1.posX;
                        funcRoom.posY = point2.posY;
                        funcRoom.width = Math.Abs(w);
                        funcRoom.height = 1;
                        halls.Add(funcRoom);

                        funcRoom2.posX = point1.posX;
                        funcRoom2.posY = point1.posY;
                        funcRoom2.width = 1;
                        funcRoom2.height = Math.Abs(h);
                        halls.Add(funcRoom2);
                    }
                }
                else
                {
                    funcRoom.posX = point1.posX;
                    funcRoom.posY = point1.posY;
                    funcRoom.width = Math.Abs(w);
                    funcRoom.height = 1;
                    halls.Add(funcRoom);
                }
            }
            else
            {
                if (h < 0)
                {
                    funcRoom.posX = point2.posX;
                    funcRoom.posY = point2.posY;
                    funcRoom.width = 1;
                    funcRoom.height = Math.Abs(h);
                    halls.Add(funcRoom);
                }
                else if (h > 0)
                {
                    funcRoom2.posX = point1.posX;
                    funcRoom2.posY = point1.posY;
                    funcRoom2.width = 1;
                    funcRoom2.height = Math.Abs(h);
                    halls.Add(funcRoom2);
                }
            }

            // Corridors are placed into the dunegon 2d array
            for (int i = 0; i < halls.Count(); i++)
            {
                for (int x = halls[i].posX; x <= halls[i].posX + halls[i].width; x++)
                {
                    _roomArray[x, halls[i].posY] = 9;
                    _roomArray[x, (halls[i].posY + halls[i].height)] = 9;
                }

                for (int y = halls[i].posY; y <= halls[i].posY + halls[i].height; y++)
                {
                    _roomArray[halls[i].posX, y] = 9;
                    _roomArray[(halls[i].posX + halls[i].width), y] = 9;
                }
            }
        }
    }
}