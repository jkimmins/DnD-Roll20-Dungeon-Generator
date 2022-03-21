namespace DungeonGenerator
{
    partial class Dungeon_Form
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.Dungeon_Theme_Label = new System.Windows.Forms.Label();
            this.Tile_Style_Label = new System.Windows.Forms.Label();
            this.Dungeon_Size_Label = new System.Windows.Forms.Label();
            this.Room_Size_Label = new System.Windows.Forms.Label();
            this.Dunegon_Generator_Label = new System.Windows.Forms.Label();
            this.Dungeon_Theme_ComboBox = new System.Windows.Forms.ComboBox();
            this.Room_Size_ComboBox = new System.Windows.Forms.ComboBox();
            this.Dungeon_Size_ComboBox = new System.Windows.Forms.ComboBox();
            this.Tile_Style_ComboBox = new System.Windows.Forms.ComboBox();
            this.Generate_Button = new System.Windows.Forms.Button();
            this.Max_CR_Label = new System.Windows.Forms.Label();
            this.Max_Exp_Label = new System.Windows.Forms.Label();
            this.Max_EXP_UD = new System.Windows.Forms.NumericUpDown();
            this.Max_CR_ComboBox = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.Max_EXP_UD)).BeginInit();
            this.SuspendLayout();
            // 
            // Dungeon_Theme_Label
            // 
            this.Dungeon_Theme_Label.AutoSize = true;
            this.Dungeon_Theme_Label.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Dungeon_Theme_Label.Location = new System.Drawing.Point(50, 100);
            this.Dungeon_Theme_Label.Name = "Dungeon_Theme_Label";
            this.Dungeon_Theme_Label.Size = new System.Drawing.Size(114, 17);
            this.Dungeon_Theme_Label.TabIndex = 0;
            this.Dungeon_Theme_Label.Text = "Dungeon Theme";
            // 
            // Tile_Style_Label
            // 
            this.Tile_Style_Label.AutoSize = true;
            this.Tile_Style_Label.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Tile_Style_Label.Location = new System.Drawing.Point(550, 100);
            this.Tile_Style_Label.Name = "Tile_Style_Label";
            this.Tile_Style_Label.Size = new System.Drawing.Size(66, 17);
            this.Tile_Style_Label.TabIndex = 1;
            this.Tile_Style_Label.Text = "Tile Style";
            // 
            // Dungeon_Size_Label
            // 
            this.Dungeon_Size_Label.AutoSize = true;
            this.Dungeon_Size_Label.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Dungeon_Size_Label.Location = new System.Drawing.Point(50, 200);
            this.Dungeon_Size_Label.Name = "Dungeon_Size_Label";
            this.Dungeon_Size_Label.Size = new System.Drawing.Size(97, 17);
            this.Dungeon_Size_Label.TabIndex = 3;
            this.Dungeon_Size_Label.Text = "Dungeon Size";
            // 
            // Room_Size_Label
            // 
            this.Room_Size_Label.AutoSize = true;
            this.Room_Size_Label.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Room_Size_Label.Location = new System.Drawing.Point(550, 200);
            this.Room_Size_Label.Name = "Room_Size_Label";
            this.Room_Size_Label.Size = new System.Drawing.Size(76, 17);
            this.Room_Size_Label.TabIndex = 4;
            this.Room_Size_Label.Text = "Room Size";
            // 
            // Dunegon_Generator_Label
            // 
            this.Dunegon_Generator_Label.AutoSize = true;
            this.Dunegon_Generator_Label.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Dunegon_Generator_Label.Location = new System.Drawing.Point(323, 24);
            this.Dunegon_Generator_Label.Name = "Dunegon_Generator_Label";
            this.Dunegon_Generator_Label.Size = new System.Drawing.Size(253, 31);
            this.Dunegon_Generator_Label.TabIndex = 7;
            this.Dunegon_Generator_Label.Text = "Dungeon Generator";
            // 
            // Dungeon_Theme_ComboBox
            // 
            this.Dungeon_Theme_ComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.Dungeon_Theme_ComboBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Dungeon_Theme_ComboBox.FormattingEnabled = true;
            this.Dungeon_Theme_ComboBox.Items.AddRange(new object[] {
            "Goblinoids",
            "Undead",
            "Bandits",
            "Cultists",
            "Random Theme"});
            this.Dungeon_Theme_ComboBox.Location = new System.Drawing.Point(200, 97);
            this.Dungeon_Theme_ComboBox.Name = "Dungeon_Theme_ComboBox";
            this.Dungeon_Theme_ComboBox.Size = new System.Drawing.Size(150, 24);
            this.Dungeon_Theme_ComboBox.TabIndex = 8;
            // 
            // Room_Size_ComboBox
            // 
            this.Room_Size_ComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.Room_Size_ComboBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Room_Size_ComboBox.FormattingEnabled = true;
            this.Room_Size_ComboBox.Items.AddRange(new object[] {
            "Small",
            "Medium",
            "Large",
            "Random Size"});
            this.Room_Size_ComboBox.Location = new System.Drawing.Point(700, 197);
            this.Room_Size_ComboBox.Name = "Room_Size_ComboBox";
            this.Room_Size_ComboBox.Size = new System.Drawing.Size(150, 24);
            this.Room_Size_ComboBox.TabIndex = 9;
            // 
            // Dungeon_Size_ComboBox
            // 
            this.Dungeon_Size_ComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.Dungeon_Size_ComboBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Dungeon_Size_ComboBox.FormattingEnabled = true;
            this.Dungeon_Size_ComboBox.Items.AddRange(new object[] {
            "Small",
            "Medium",
            "Large",
            "Random Size"});
            this.Dungeon_Size_ComboBox.Location = new System.Drawing.Point(200, 197);
            this.Dungeon_Size_ComboBox.Name = "Dungeon_Size_ComboBox";
            this.Dungeon_Size_ComboBox.Size = new System.Drawing.Size(150, 24);
            this.Dungeon_Size_ComboBox.TabIndex = 10;
            // 
            // Tile_Style_ComboBox
            // 
            this.Tile_Style_ComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.Tile_Style_ComboBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Tile_Style_ComboBox.FormattingEnabled = true;
            this.Tile_Style_ComboBox.Items.AddRange(new object[] {
            "Black/White",
            "Grey",
            "Brown",
            "Random Style"});
            this.Tile_Style_ComboBox.Location = new System.Drawing.Point(700, 97);
            this.Tile_Style_ComboBox.Name = "Tile_Style_ComboBox";
            this.Tile_Style_ComboBox.Size = new System.Drawing.Size(150, 24);
            this.Tile_Style_ComboBox.TabIndex = 12;
            // 
            // Generate_Button
            // 
            this.Generate_Button.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Generate_Button.Location = new System.Drawing.Point(390, 370);
            this.Generate_Button.Name = "Generate_Button";
            this.Generate_Button.Size = new System.Drawing.Size(120, 50);
            this.Generate_Button.TabIndex = 14;
            this.Generate_Button.Text = "Generate";
            this.Generate_Button.UseVisualStyleBackColor = true;
            this.Generate_Button.Click += new System.EventHandler(this.Generate_Button_Click);
            // 
            // Max_CR_Label
            // 
            this.Max_CR_Label.AutoSize = true;
            this.Max_CR_Label.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Max_CR_Label.Location = new System.Drawing.Point(50, 300);
            this.Max_CR_Label.Name = "Max_CR_Label";
            this.Max_CR_Label.Size = new System.Drawing.Size(89, 17);
            this.Max_CR_Label.TabIndex = 15;
            this.Max_CR_Label.Text = "Maximum CR";
            // 
            // Max_Exp_Label
            // 
            this.Max_Exp_Label.AutoSize = true;
            this.Max_Exp_Label.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Max_Exp_Label.Location = new System.Drawing.Point(550, 300);
            this.Max_Exp_Label.Name = "Max_Exp_Label";
            this.Max_Exp_Label.Size = new System.Drawing.Size(97, 17);
            this.Max_Exp_Label.TabIndex = 17;
            this.Max_Exp_Label.Text = "Maximum EXP";
            // 
            // Max_EXP_UD
            // 
            this.Max_EXP_UD.Location = new System.Drawing.Point(700, 297);
            this.Max_EXP_UD.Maximum = new decimal(new int[] {
            1000000,
            0,
            0,
            0});
            this.Max_EXP_UD.Name = "Max_EXP_UD";
            this.Max_EXP_UD.Size = new System.Drawing.Size(120, 20);
            this.Max_EXP_UD.TabIndex = 18;
            // 
            // Max_CR_ComboBox
            // 
            this.Max_CR_ComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.Max_CR_ComboBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Max_CR_ComboBox.FormattingEnabled = true;
            this.Max_CR_ComboBox.Items.AddRange(new object[] {
            "0.5",
            "1",
            "2",
            "3",
            "4",
            "5",
            "Random CR"});
            this.Max_CR_ComboBox.Location = new System.Drawing.Point(200, 297);
            this.Max_CR_ComboBox.Name = "Max_CR_ComboBox";
            this.Max_CR_ComboBox.Size = new System.Drawing.Size(150, 24);
            this.Max_CR_ComboBox.TabIndex = 19;
            // 
            // Dungeon_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(884, 461);
            this.Controls.Add(this.Max_CR_ComboBox);
            this.Controls.Add(this.Max_EXP_UD);
            this.Controls.Add(this.Max_Exp_Label);
            this.Controls.Add(this.Max_CR_Label);
            this.Controls.Add(this.Generate_Button);
            this.Controls.Add(this.Tile_Style_ComboBox);
            this.Controls.Add(this.Dungeon_Size_ComboBox);
            this.Controls.Add(this.Room_Size_ComboBox);
            this.Controls.Add(this.Dungeon_Theme_ComboBox);
            this.Controls.Add(this.Dunegon_Generator_Label);
            this.Controls.Add(this.Room_Size_Label);
            this.Controls.Add(this.Dungeon_Size_Label);
            this.Controls.Add(this.Tile_Style_Label);
            this.Controls.Add(this.Dungeon_Theme_Label);
            this.Name = "Dungeon_Form";
            this.Text = "Dungeon Generator";
            ((System.ComponentModel.ISupportInitialize)(this.Max_EXP_UD)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Dungeon_Theme_Label;
        private System.Windows.Forms.Label Tile_Style_Label;
        private System.Windows.Forms.Label Dungeon_Size_Label;
        private System.Windows.Forms.Label Room_Size_Label;
        private System.Windows.Forms.Label Dunegon_Generator_Label;
        private System.Windows.Forms.ComboBox Dungeon_Theme_ComboBox;
        private System.Windows.Forms.ComboBox Room_Size_ComboBox;
        private System.Windows.Forms.ComboBox Dungeon_Size_ComboBox;
        private System.Windows.Forms.ComboBox Tile_Style_ComboBox;
        private System.Windows.Forms.Button Generate_Button;
        private System.Windows.Forms.Label Max_CR_Label;
        private System.Windows.Forms.Label Max_Exp_Label;
        private System.Windows.Forms.NumericUpDown Max_EXP_UD;
        private System.Windows.Forms.ComboBox Max_CR_ComboBox;
    }
}

