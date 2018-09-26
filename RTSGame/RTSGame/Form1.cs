using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RTSGame
{
    public partial class Form1 : Form
    {
       public abstract class Unit: Button
       {
            //Private fields
            private int xPos = 0;
            private int yPos = 0;
            private int health;
            private int speed;
            private int attack;
            private int attackRange;
            private string team;
            protected string name;
            private char symbol;
            protected int distance;

            //Get and Sets all private fields to make them public.
            public int XPos
            {
                get { return xPos; }
                set { xPos = value; }
            }

            public int YPos
            {
                get { return yPos; }
                set { yPos = value; }
            }

            public int Health
            {
                get { return health; }
                set { health = value; }
            }

            public int Attack
            {
                get { return attack; }
                set { attack = value; }
            }

            public int AttackRange
            {
                get { return attackRange; }
                set { attackRange = value; }
            }

            public int Speed
            {
                get { return speed; }
                set { speed = value; }
            }

            public string Team
            {
                get { return team; }
                set { team = value; }
            }

            public string Name
            {
                get { return name; }
                set { name = value; }
            }

            public char Symbol
            {
                get { return symbol; }
                set { symbol = value; }
            }

            //Class contructor
            public Unit()
            {
                
            }

            //Methods for movements
            public virtual void movePos()
            {

            }

            public virtual void combatUnit()
            {

            }

            public virtual bool inRange()
            {
                return false;
            }

            public virtual void closestUnit()
            {

            }

            public virtual void death()
            {

            }

            public virtual void unitInfo()
            {

            }

            public virtual string ToString()
            {
                return null;
            }

            //Saving all information as an object to later be read.
            public abstract void Save(string FileName, Unit NewUnits);
       }

        public abstract class Building : Button
        {
            //protected fields for buildings 
            protected int buildXPos;
            protected int buildYPos;
            protected int buildHealth = 500;
            protected string buildFaction;
            protected char buildSymbol;

            //Get and Set protected values
            public int BuildXPos
            {
                get { return buildXPos; }
                set { buildXPos = value; }
            }

            public int BuildYPos
            {
                get { return buildYPos; }
                set { buildYPos = value; }
            }

            public int BuildHealth
            {
                get { return buildHealth; }
                set { buildHealth = value; }
            }

            public string BuildFaction
            {
                get { return buildFaction; }
                set { buildFaction = value; }
            }

            public char BuildSymbol
            {
                get { return buildSymbol; }
                set { buildSymbol = value; }
            }

            //class contructor
            public Building()
            {

            }

            //All methods for hanldling buildings
            public virtual void buildDestruction()
            {

            }

            public virtual void ToString()
            {

            }

            //Saving all information and storing it as an object to be stored and read later.
            public abstract void Save(string FileName, Building NewBuildings);
        }

        [Serializable]
        public class MeleeUnit : Unit
        {
            int closeX, closeY;
            Map map;
            Form1 form1;

            // Constructor for the class
            public MeleeUnit(Map map, Form1 form1)
            {
                this.form1 = form1;
                this.map = map;
            }

            //Methods to handle movements of Ranged Units
            public override void movePos()
            {
                
            }

            public override void combatUnit()
            {
                
            }

            public override bool inRange()
            {
                if (distance <= AttackRange)
                {
                    return true;
                }
                else return false;
            }

            public override void closestUnit()
            {
                //if (map.myMap[XPos, YPos].Name == "♥" && map.myMap[XPos, YPos].Name == "♦")
                //{
                //    for (int x = 0; x < 20; x++)
                //    {
                //        for (int y = 0; y < 20; y++)
                //        {
                //            if (map.myMap[x, y].Name == "♥" || map.myMap[x, y].Name == "♦" && map.myMap[x, y].Name == map.myMap[XPos, YPos].Name)
                //            {
                //                double r = Math.Sqrt((x * XPos) + (y * YPos));
                //                if (r < distance)
                //                {
                //                    closeX = x;
                //                    closeY = y;
                //                    distance = Convert.ToInt32(r);
                //                }
                //            }
                //        }
                //    }
                //}
            }

            public override void death()
            {

            }

            public override string ToString()
            {
                string info;
                info = "Team: Humans " + Environment.NewLine + "Symbol: ♥" + Environment.NewLine + "Health: 100" + Environment.NewLine + "Attack: 20" + Environment.NewLine + "Speed: 1" + Environment.NewLine + "Range: 1";
                return info;
            }


            //Save method to save objects to later be read into the game
            public string FileName = @"F:\Saves\RTSMelee.ser";
            public override void Save(string FileName, Unit NewUnits)
            {
                FStream = new FileStream(FileName, FileMode.Append, FileAccess.Write);
                Bformatter = new BinaryFormatter();
                Bformatter.Serialize(FStream, NewUnits);
                FStream.Close();
            }
        }

        [Serializable]
        public class RangedUnit : Unit
        {

            //Constructor for ranged unit
            public RangedUnit()
            {

            }

            //Methods to handle movements of Ranged Units
            public override void movePos()
            {
                
            }

            public override void combatUnit()
            {

            }

            public override bool inRange()
            {
                if (distance <= AttackRange)
                {
                    return true;
                }
                else return false;
            }

            public override void closestUnit()
            {

            }

            public override void death()
            {

            }

            public override string ToString()
            {
                string info;
                info = "Team: Undead " + Environment.NewLine + "Symbol: ♦" + Environment.NewLine + "Health: 50" + Environment.NewLine + "Attack: 10" + Environment.NewLine + "Speed: 1" + Environment.NewLine + "Range: 1";
                return info;
            }

            public string FileName = @"F:\Saves\RTSRange.ser";
            public override void Save(string FileName, Unit NewUnits)
            {
                FStream = new FileStream(FileName, FileMode.Append, FileAccess.Write);
                Bformatter = new BinaryFormatter();
                Bformatter.Serialize(FStream, NewUnits);
                FStream.Close();
            }
        }

        [Serializable]
        public class Map
        {

            int x, y;
            TableLayoutPanel gridMap;
            Form1 form1;
            
            public Button[,] myMap = new Button[20, 20];       

            public Map(TableLayoutPanel gridMap, Form1 form1)
            {
                this.gridMap = gridMap;
                this.form1 = form1;
            }

            //Run through the array and randomly generate a unit.
            public void drawUnit()
            {
                for (int i = 0; i < 20; i++)
                {
                    for (int k = 0; k < 20; k++)
                    {
                        //Creates an empty spot on map before anything else is initialized.
                        //EmptyTile emptyT = new EmptyTile();
                        //emptyT.Name = "Empty";
                        //emptyT.XPos = i;
                        //emptyT.YPos = k;
                        //emptyT.Text = "○";
                        //myMap[i, k] = emptyT;
                    }
                }

                // team 1 melee units
                for (int i = 0; i < 6; i++)
                {
                    MeleeUnit mu = new MeleeUnit(this,form1);
                    Random randPlacement = new Random(Guid.NewGuid().GetHashCode());
                    x = randPlacement.Next(0, 20);
                    y = randPlacement.Next(0, 20);
                    
                    if (myMap[x, y].Name != "XRbuild" && myMap[x, y].Name != "YRbuild" && myMap[x, y].Name != "XFbuild" && myMap[x, y].Name != "YFbuild" && myMap[x, y].Name != "UW" && myMap[x, y].Name != "HW")
                    {
                        mu.XPos = x;
                        mu.YPos = y;
                        mu.Team = "Humans";
                        mu.Name = "♥";
                        mu.Text = "♥";
                        mu.BackColor = Color.Orange;
                        myMap[x, y] = mu;
                    }
                }

                // team 1 ranged units
                for (int i = 0; i < 4; i++)
                {
                    RangedUnit rU = new RangedUnit();
                    Random randPlacement = new Random(Guid.NewGuid().GetHashCode());
                    x = randPlacement.Next(0, 20);
                    y = randPlacement.Next(0, 20);

                    if(myMap[x, y].Name != "YRbuild" && myMap[x, y].Name != "XRbuild" && myMap[x, y].Name != "XFbuild" && myMap[x, y].Name != "YFbuild")
                    {
                        rU.XPos = x;
                        rU.YPos = y;
                        rU.Team = "Humans";
                        rU.Name = "♥";
                        rU.Text = "♥";
                        rU.BackColor = Color.Orange;
                        myMap[x, y] = rU;
                    }
                }

                // team 2 melee units
                for (int i = 0; i < 6; i++)
                {
                    MeleeUnit mu = new MeleeUnit(this, form1);
                    Random randPlacement = new Random(Guid.NewGuid().GetHashCode());
                    x = randPlacement.Next(0, 20);
                    y = randPlacement.Next(0, 20);

                    if (myMap[x, y].Name != "XRbuild" && myMap[x, y].Name != "YRbuild" && myMap[x, y].Name != "XFbuild" && myMap[x, y].Name != "YFbuild")
                    {                        
                        mu.XPos = x;
                        mu.YPos = y;
                        mu.Team = "Undead";
                        mu.Name = "♦";
                        mu.Text = "♦";
                        mu.BackColor = Color.MediumAquamarine;
                        myMap[x, y] = mu;
                    }
                }

                // team 2 ranged units
                for (int i = 0; i < 4; i++)
                {
                    RangedUnit rU = new RangedUnit();
                    Random randPlacement = new Random(Guid.NewGuid().GetHashCode());
                    x = randPlacement.Next(0, 20);
                    y = randPlacement.Next(0, 20);

                    if (myMap[x, y].Name != "♥" && myMap[x, y].Name != "YRbuild" && myMap[x, y].Name != "XRbuild" && myMap[x, y].Name != "XFbuild" && myMap[x, y].Name != "YFbuild")
                    {  
                        rU.XPos = x;
                        rU.YPos = y;
                        rU.Team = "Undead";
                        rU.Name = "♦";
                        rU.Text = "♦";
                        rU.BackColor = Color.MediumAquamarine;
                        myMap[x, y] = rU; 
                    }
                }
            }

            public void newMap()
            {
                gridMap.Controls.Clear();
                drawUnit();

                for (int i = 0; i < 20; i++)
                {
                    for (int k = 0; k < 20; k++)
                    {
                        myMap[i, k].Height = 45;
                        myMap[i, k].Width = 45;
                        gridMap.Controls.Add(myMap[i, k]);
                        if (myMap[i, k].Name == "Empty")
                        {
                            myMap[i, k].Click += new EventHandler(form1.btnEmpty);
                            gridMap.Controls.Add(myMap[i, k]);
                        }
                        else if (myMap[i, k].Name == "XRbuild")
                        {
                            myMap[i, k].Click += new EventHandler(form1.btnBuildingR);
                            gridMap.Controls.Add(myMap[i, k]);
                        }
                        else if (myMap[i, k].Name == "XFbuild")
                        {
                            myMap[i, k].Click += new EventHandler(form1.btnBuildingF);
                            gridMap.Controls.Add(myMap[i, k]);
                        }
                        else if (myMap[i, k].Name == "YRbuild")
                        {
                            myMap[i, k].Click += new EventHandler(form1.btnBuildingR);
                            gridMap.Controls.Add(myMap[i, k]);
                        }
                        else if (myMap[i, k].Name == "YFbuild")
                        {
                            myMap[i, k].Click += new EventHandler(form1.btnBuildingF);
                            gridMap.Controls.Add(myMap[i, k]);
                        }
                        else if (myMap[i, k].Text == "♥")
                        {
                            myMap[i, k].Click += new EventHandler(form1.btnMelee);
                            gridMap.Controls.Add(myMap[i, k]);
                        }
                        else if (myMap[i, k].Text == "♦")
                        {
                            myMap[i, k].Click += new EventHandler(form1.btnRange);
                            gridMap.Controls.Add(myMap[i, k]);
                        }
                        else if (myMap[i, k].Text == "|")
                        {
                            myMap[i, k].Click += new EventHandler(form1.btnDeposit);
                            gridMap.Controls.Add(myMap[i, k]);
                        }
                    }
                }
            }

            public void moveUnit()
            {

            }

            public void updatePos()
            {

            }

            public static Form1[] AllObjects(string FileName)
            {
                FStream = new FileStream(FileName, FileMode.Open, FileAccess.Read);
                Bformatter = new BinaryFormatter();

                Form1[] ObjectArr = new Form1[0];
                int i = 0;

                while (FStream.Position < FStream.Length)
                {
                    Array.Resize(ref ObjectArr, ObjectArr.Length + 1);
                    ObjectArr[i] = (Form1)Bformatter.Deserialize(FStream);

                    i++;
                }

                FStream.Close();
                return ObjectArr;
            }
        }

        [Serializable]
        public class GameEngine
        {
            MeleeUnit swordsman;
            RangedUnit archer;
            Form1 form1;
            Map map;

            public MeleeUnit Swordsman
            {
                get { return swordsman; }

                set { swordsman = value; }
            }

            public RangedUnit Archer
            {
                get { return archer; }

                set { archer = value; }
            }

            public GameEngine(Form1 form1,Map map)
            {
                this.map = map;
                this.form1 = form1;
                swordsman = new MeleeUnit(map, form1);
                archer = new RangedUnit();
            }
        }

        public Form1()
        {
            InitializeComponent();
        }

        int timeMs, timeSec, timeMin;
        bool isActive;
        public Form1[] AllObjects = new Form1[0];
        GameEngine MainEngine;
        Map map;
        public static BinaryFormatter Bformatter { get; set; }
        public static FileStream FStream { get; set; }

        //Function to draw new time on labels
        //https://www.youtube.com/watch?v=lp9cJJUDUsk&t=1s
        public void DrawTime()
        {
            lblMill.Text = String.Format("{0:00}", timeMs);
            lblSec.Text = String.Format("{0:00}", timeSec);
            lblMin.Text = String.Format("{0:00}", timeMin);           
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            MainEngine = new GameEngine(this, map);
            //Setting default times
            timeMs = 0;
            timeSec = 0;
            timeMin = 0;

            //Instances of the classes
            Unit meleeSoldier = new MeleeUnit(map, this);
            meleeSoldier.XPos = 0;
            meleeSoldier.YPos = 0;
            meleeSoldier.Health = 100;
            meleeSoldier.Speed = 1;
            meleeSoldier.Attack = 20;
            meleeSoldier.AttackRange = 1;

            Unit rangeSoldier = new RangedUnit();
            rangeSoldier.XPos = 0;
            rangeSoldier.YPos = 0;
            rangeSoldier.Health = 60;
            rangeSoldier.Speed = 1;
            rangeSoldier.Attack = 15;
            rangeSoldier.AttackRange = 4;

            //Draws a clean map
            Map gameMap = new Map(gridMap, this);
            gameMap.newMap();
        }

        private void btnBuildingR(object sender, EventArgs e)
        {
            unitLbl.Text = "This building accumulates War Resources!";
        }

        private void btnBuildingF(object sender, EventArgs e)
        {
            unitLbl.Text = "This building produces units!";
        }

        private void btnEmpty(object sender, EventArgs e)
        {
            unitLbl.Text = "Empty space!";
        }

        private void btnMelee(object sender, EventArgs e)
        {
            MeleeUnit mu= new MeleeUnit(map,this);
            unitLbl.Text = mu.ToString();
        }

        private void btnRange(object sender, EventArgs e)
        {
            RangedUnit ru = new RangedUnit();
            unitLbl.Text = ru.ToString();
        }

        private void btnDeposit(object sender, EventArgs e)
        {
            unitLbl.Text = "This is a mining hotspot. It can produce iron and coal!";
        }

        private void startButton_Click(object sender, EventArgs e)
        {
            isActive = true;
        }

        private void pauseButton_Click(object sender, EventArgs e)
        {
            isActive = false;
        }

        //Button asks user to reset, then produces a new game with a fresh timer or the same timer.
        private void resetButton_Click(object sender, EventArgs e)
        {
            DialogResult result1 = MessageBox.Show("Are you sure you want to restart?", "Reset The Game", MessageBoxButtons.OKCancel);
            if (result1 == DialogResult.OK)
            {
                DialogResult result2 = MessageBox.Show("Do you want to reset the timer and the coins?", "Reset the timer", MessageBoxButtons.YesNo);
                if (result2 == DialogResult.Yes)
                {
                    isActive = false;
                    timeMs = 0;
                    timeSec = 0;
                    timeMin = 0;
                    unitLbl.Text = "";
                    //Draws a new map when reset
                    Map gameMap = new Map(gridMap, this);
                    gameMap.newMap();
                }
                else
                {
                    unitLbl.Text = "";
                    //Draws a new map when reset
                    Map gameMap = new Map(gridMap, this);
                    gameMap.newMap();
                }
            }
        }

        private void teamMeleeBtn_Click(object sender, EventArgs e)
        {
            MeleeUnit mu = new MeleeUnit(map, this);
            unitLbl.Text = mu.ToString();
        }

        private void teamRangeBtn_Click(object sender, EventArgs e)
        {
            RangedUnit ru = new RangedUnit();
            unitLbl.Text = ru.ToString();
        }

        private void loadButton_Click(object sender, EventArgs e)
        {
            DialogResult result1 = MessageBox.Show("You are about to load your previous save!", "Load Game", MessageBoxButtons.OKCancel);
            //if (result1 == DialogResult.OK)
            //{
            //    Map readSave = new Map(gridMap, this);
            //    readSave.Read();
            //}
        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            DialogResult result1 = MessageBox.Show("Do you want to save your game?", "Save Game", MessageBoxButtons.YesNo);
            if (result1 == DialogResult.Yes)
            {
                //Form1[] AllObjects = MeleeUnit.Save(MainEngine.Swordsman.FileName);
                //Form1[] AllObjects = RangedUnit.Save(MainEngine.Archer.FileName);
                //Form1[] AllObjects = ResourceBuilding.Save(MainEngine.Resources.FileName);
                //Form1[] AllObjects = FactoryBuilding.Save(MainEngine.SpawnUnits.FileName);

                //MainEngine.Swordsman.Save(FileName, );
                //MainEngine.Archer.Save();
                //MainEngine.Resources.Save();
                //MainEngine.SpawnUnits.Save();
            }
        }

        private void gameTimer_Tick(object sender, EventArgs e)
        {
            //Making a correct timer.
            if (isActive)
            {
                timeMs++;

                if (timeMs >= 100)
                {
                    timeSec++;
                    timeMs = 0;
                    MainEngine.Swordsman.closestUnit();
                    //MainEngine.SpawnUnits.spawnNewUnits();

                    if (timeSec >=60)
                    {
                        timeMin++;
                        timeSec = 0;
                    }
                }
                
            }
            DrawTime();
        }

        private void lblMill_Click(object sender, EventArgs e)
        {

        }

    }
}