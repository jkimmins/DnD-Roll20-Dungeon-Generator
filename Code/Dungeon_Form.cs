using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DungeonGenerator
{
    public partial class Dungeon_Form : Form
    {
        public Dungeon_Form()
        {
            InitializeComponent();
        }

        // When the generate button is clicked
        private void Generate_Button_Click(object sender, EventArgs e)
        {
            // Current values are stored in variables
            String dungeonTheme = Dungeon_Theme_ComboBox.Text;
            String tileStyle = Tile_Style_ComboBox.Text;
            String dungeonSize = Dungeon_Size_ComboBox.Text;
            String roomSize = Room_Size_ComboBox.Text;
            String maxCR = Max_CR_ComboBox.Text;
            int maxExp = (int)Max_EXP_UD.Value;

            //// Default values if the user doesn't choose
            //if (dungeonTheme != "Goblinoids" || dungeonTheme != "Undead" || dungeonTheme != "Bandits" || dungeonTheme != "Cultists" || dungeonTheme != "Random Theme")
            //{
            //    dungeonTheme = "Goblinoids";
            //}
            //if (tileStyle != "Black/White" || tileStyle != "Grey" || tileStyle != "Brown" || tileStyle != "Random Style")
            //{
            //    tileStyle = "Black/White";
            //}
            //if (dungeonSize != "Small" || dungeonSize != "Medium" || dungeonSize != "Large" || dungeonSize != "Random Size")
            //{
            //    dungeonSize = "Medium";
            //}
            //if (roomSize != "Small" || roomSize != "Medium" || roomSize != "Large" || roomSize != "Random Size")
            //{
            //    roomSize = "Medium";
            //}
            //if (maxCR != "0.5" || maxCR != "1" || maxCR != "2" || maxCR != "3" || maxCR != "4" || maxCR != "5" || maxCR != "Random CR")
            //{
            //    maxCR = "0.5";
            //}

            // Variables are used as arguments in the display form which also creates the dungeon
            Display_Form displayForm = new Display_Form(dungeonTheme, tileStyle, dungeonSize, roomSize, maxCR, maxExp);
            displayForm.ShowDialog();
        }
    }
}
