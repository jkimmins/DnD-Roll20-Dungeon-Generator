namespace DungeonGenerator
{
    partial class Display_Form
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
            this.Dungeon_Theme_Display = new System.Windows.Forms.Label();
            this.Dungeon_Size_Display = new System.Windows.Forms.Label();
            this.Max_CR_Display = new System.Windows.Forms.Label();
            this.Tile_Style_Display = new System.Windows.Forms.Label();
            this.Room_Size_Display = new System.Windows.Forms.Label();
            this.Max_EXP_Display = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // Dungeon_Theme_Display
            // 
            this.Dungeon_Theme_Display.AutoSize = true;
            this.Dungeon_Theme_Display.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Dungeon_Theme_Display.Location = new System.Drawing.Point(60, 30);
            this.Dungeon_Theme_Display.Name = "Dungeon_Theme_Display";
            this.Dungeon_Theme_Display.Size = new System.Drawing.Size(46, 17);
            this.Dungeon_Theme_Display.TabIndex = 0;
            this.Dungeon_Theme_Display.Text = "label1";
            // 
            // Dungeon_Size_Display
            // 
            this.Dungeon_Size_Display.AutoSize = true;
            this.Dungeon_Size_Display.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Dungeon_Size_Display.Location = new System.Drawing.Point(60, 110);
            this.Dungeon_Size_Display.Name = "Dungeon_Size_Display";
            this.Dungeon_Size_Display.Size = new System.Drawing.Size(46, 17);
            this.Dungeon_Size_Display.TabIndex = 1;
            this.Dungeon_Size_Display.Text = "label2";
            // 
            // Max_CR_Display
            // 
            this.Max_CR_Display.AutoSize = true;
            this.Max_CR_Display.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Max_CR_Display.Location = new System.Drawing.Point(60, 190);
            this.Max_CR_Display.Name = "Max_CR_Display";
            this.Max_CR_Display.Size = new System.Drawing.Size(46, 17);
            this.Max_CR_Display.TabIndex = 2;
            this.Max_CR_Display.Text = "label3";
            // 
            // Tile_Style_Display
            // 
            this.Tile_Style_Display.AutoSize = true;
            this.Tile_Style_Display.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Tile_Style_Display.Location = new System.Drawing.Point(300, 30);
            this.Tile_Style_Display.Name = "Tile_Style_Display";
            this.Tile_Style_Display.Size = new System.Drawing.Size(46, 17);
            this.Tile_Style_Display.TabIndex = 3;
            this.Tile_Style_Display.Text = "label4";
            // 
            // Room_Size_Display
            // 
            this.Room_Size_Display.AutoSize = true;
            this.Room_Size_Display.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Room_Size_Display.Location = new System.Drawing.Point(300, 110);
            this.Room_Size_Display.Name = "Room_Size_Display";
            this.Room_Size_Display.Size = new System.Drawing.Size(46, 17);
            this.Room_Size_Display.TabIndex = 4;
            this.Room_Size_Display.Text = "label5";
            // 
            // Max_EXP_Display
            // 
            this.Max_EXP_Display.AutoSize = true;
            this.Max_EXP_Display.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Max_EXP_Display.Location = new System.Drawing.Point(300, 190);
            this.Max_EXP_Display.Name = "Max_EXP_Display";
            this.Max_EXP_Display.Size = new System.Drawing.Size(46, 17);
            this.Max_EXP_Display.TabIndex = 5;
            this.Max_EXP_Display.Text = "label6";
            // 
            // Display_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(404, 261);
            this.Controls.Add(this.Max_EXP_Display);
            this.Controls.Add(this.Room_Size_Display);
            this.Controls.Add(this.Tile_Style_Display);
            this.Controls.Add(this.Max_CR_Display);
            this.Controls.Add(this.Dungeon_Size_Display);
            this.Controls.Add(this.Dungeon_Theme_Display);
            this.Name = "Display_Form";
            this.Text = "Display Form";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Dungeon_Theme_Display;
        private System.Windows.Forms.Label Dungeon_Size_Display;
        private System.Windows.Forms.Label Max_CR_Display;
        private System.Windows.Forms.Label Tile_Style_Display;
        private System.Windows.Forms.Label Room_Size_Display;
        private System.Windows.Forms.Label Max_EXP_Display;
    }
}