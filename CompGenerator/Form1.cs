using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CompGenerator
{
    public partial class Form1 : Form
    {
        // Visibility fields will be used so no method pointers fall on individual button controls.
        bool tankScreen = false;
        bool dpsScreen = false;
        bool suppScreen = false;


        //Fields that show whether one of the role slots has a character in it or not.
        bool tank1 = false;
        bool tank2 = false;
        bool dps1 = false;
        bool dps2 = false;
        bool supp1 = false;
        bool supp2 = false;

        /*
         * initiates field showing that a character is still in first position.
         * very inefficient. Find way to create new button property.
         * v
         */

        bool asheFirstPos = true;
        bool bastionFirstPos = true;
        bool creeFirstPos = true;
        bool doomFirstPos = true;
        bool echoFirstPos = true;
        bool genjiFirstPos = true;
        bool hanzoFirstPos = true;
        bool junkFirstPos = true;
        bool meiFirstPos = true;
        bool pharahFirstPos = true;
        bool reaperFirstPos = true;
        bool soldierFirstPos = true;
        bool sombraFirstPos = true;
        bool symFirstPos = true;
        bool torbFirstPos = true;
        bool tracerFirstPos = true;
        bool widowFirstPos = true;
        // -------------First position of tank bool--------------
        bool winstonFirstPos = true;
        bool zaryaFirstPos = true;
        bool dvaFirstPos = true;
        bool sigFirstPos = true;
        bool ballFirstPos = true;
        bool orisaFirstPos = true;
        bool hogFirstPos = true;
        bool reinFirstPos = true;
        // ------------First Position of support bool-------------
        bool moiraFirstPos = true;
        bool anaFirstPos = true;
        bool bapFirstPos = true;
        bool brigFirstPos = true;
        bool zenFirstPos = true;
        bool mercyFirstPos = true;
        bool lucioFirstPos = true;


        // Initial position of dps characters
        Point asheInitial = new Point(133, 150);
        Point bastionInitial = new Point(254, 150);
        Point creeInitial = new Point(375, 150);
        Point doomInitial = new Point(496, 150);
        Point echoInitial = new Point(617, 150);
        Point genjiInitial = new Point(133, 245);
        Point hanzoInitial = new Point(254, 245);
        Point junkInitial = new Point(375, 245);
        Point meiInitial = new Point(496, 245);
        Point pharahInitial = new Point(617, 245);
        Point reaperInitial = new Point(738, 204);
        Point soldierInitial = new Point(133, 344);
        Point sombraInitial = new Point(254, 344);
        Point symInitial = new Point(375, 344);
        Point torbInitial = new Point(496, 344);
        Point tracerInitial = new Point(617, 344);
        Point widowInitial = new Point(738, 298);
        //-------------Tanks-----------------------
        Point winstionInitial = new Point(183, 150);
        Point zaryaInitial = new Point(305, 298);
        Point dvaInitial = new Point(183, 298);
        Point reinInitial = new Point(305, 150);
        Point orisaInitial = new Point(427, 150);
        Point hogInitial = new Point(427, 298);
        Point sigInitial = new Point(549, 150);
        Point ballInitial = new Point(549, 298);
        //------------Supports---------------------

        public Form1()
        {
            InitializeComponent();
        }

        /*
         * returns the location of role slots.
         */
        private Point Tank1()
        {
            Point newTank1 = picTank1.Location;
            return newTank1;
        }
        private Point Tank2()
        {
            Point newTank2 = picTank2.Location;
            return newTank2;
        }
        private Point DPS1()
        {
            Point newDPS1 = picDPS1.Location;
            return newDPS1;
        }
        private Point DPS2()
        {
            Point newDPS2 = picDPS2.Location;
            return newDPS2;
        }
        private Point Support1()
        {
            Point newSupp1 = picSupport1.Location;
            return newSupp1;
        }
        private Point Support2()
        {
            Point newSupp2 = picSupport2.Location;
            return newSupp2;
        }

        /*
         * When the support button is pressed, all other roles are hidden, showing only characters of the support role.
         */
        private void btnSupport_Click(object sender, EventArgs e)
        {
            roleHide(false, false, true);
            suppScreen = true;
        }

        /*
         * When pressing the tank button, all other roles are hidden, showing only tank characters.
         */
        private void btnTank_Click(object sender, EventArgs e)
        {
            roleHide(true, false, false);
            tankScreen = true;
        }

        /*
         * When pressing the DPS button, all character outside the role will be hidden, showing only dps characters.
         */
        private void btnDPS_Click(object sender, EventArgs e)
        {
            roleHide(false, true, false);
            dpsScreen = true;
        }

        
        /*
         * Allows swapping between role screens to reduce app clutter
         */
        private void roleHide(bool tank, bool dps, bool supp)
        {
            btnAshe.Visible = dps;
            btnBastion.Visible = dps;
            btnCree.Visible = dps;
            btnDoom.Visible = dps;
            btnEcho.Visible = dps;
            btnGenji.Visible = dps;
            btnHanzo.Visible = dps;
            btnJunk.Visible = dps;
            btnMei.Visible = dps;
            btnPharah.Visible = dps;
            btnReaper.Visible = dps;
            btnSoldier.Visible = dps;
            btnSombra.Visible = dps;
            btnSym.Visible = dps;
            btnTorb.Visible = dps;
            btnTracer.Visible = dps;
            btnWidow.Visible = dps;

            btnAna.Visible = supp;
            btnBap.Visible = supp;
            btnBrig.Visible = supp;
            btnLucio.Visible = supp;
            btnMercy.Visible = supp;
            btnMoira.Visible = supp;
            btnZen.Visible = supp;

            btnBall.Visible = tank;
            btnDva.Visible = tank;
            btnWinston.Visible = tank;
            btnRein.Visible = tank;
            btnOrisa.Visible = tank;
            btnSig.Visible = tank;
            btnZarya.Visible = tank;
            btnHog.Visible = tank;
            checkTop();
        }



        /*
         * When changing between role screens, checks to see if buttons are taking role slots. If they are, they retain visibility as the role screens are changed.
         */
        private void checkTop()
        {
            if (!asheFirstPos)
            {
                btnAshe.Visible = true;
            }

            if (!bastionFirstPos)
            {
                btnBastion.Visible = true;
            }

            if (!creeFirstPos)
            {
                btnCree.Visible = true;
            }

            if (!doomFirstPos)
            {
                btnDoom.Visible = true;
            }

            if (!echoFirstPos)
            {
                btnEcho.Visible = true;
            }

            if (!genjiFirstPos)
            {
                btnGenji.Visible = true;
            }

            if (!hanzoFirstPos)
            {
                btnHanzo.Visible = true;
            }

            if (!junkFirstPos)
            {
                btnJunk.Visible = true;
            }

            if (!meiFirstPos)
            {
                btnMei.Visible = true;
            }

            if (!pharahFirstPos)
            {
                btnPharah.Visible = true;
            }

            if (!reaperFirstPos)
            {
                btnReaper.Visible = true;
            }

            if (!soldierFirstPos)
            {
                btnSoldier.Visible = true;
            }

            if (!sombraFirstPos)
            {
                btnSombra.Visible = true;
            }

            if (!symFirstPos)
            {
                btnSym.Visible = true;
            }

            if (!torbFirstPos)
            {
                btnTorb.Visible = true;
            }

            if (!tracerFirstPos)
            {
                btnTracer.Visible = true;
            }

            if (!widowFirstPos)
            {
                btnWidow.Visible = true;
            }

            if (!winstonFirstPos)
            {
                btnWinston.Visible = true;
            }

            if (!dvaFirstPos)
            {
                btnDva.Visible = true;
            }

            if (!reinFirstPos)
            {
                btnRein.Visible = true;
            }

            if (!zaryaFirstPos)
            {
                btnZarya.Visible = true;
            }

            if (!orisaFirstPos)
            {
                btnOrisa.Visible = true;
            }    

            if (!hogFirstPos)
            {
                btnHog.Visible = true;
            }

            if (!sigFirstPos)
            {
                btnSig.Visible = true;
            }

            if (!ballFirstPos)
            {
                btnBall.Visible = true;
            }

            if (!moiraFirstPos)
            {
                btnMoira.Visible = true;
            }

            if (!anaFirstPos)
            {
                btnAna.Visible = true;
            }

            if (!bapFirstPos)
            {
                btnBap.Visible = true;
            }

            if (!brigFirstPos)
            {
                btnBrig.Visible = true;
            }

            if (!zenFirstPos)
            {
                btnZen.Visible = true;
            }

            if (!mercyFirstPos)
            {
                btnMercy.Visible = true;
            }

            if (!lucioFirstPos)
            {
                btnLucio.Visible = true;
            }
        }

        /*
         * Returns the initial position of a given character.
         */
        private Point GetLoc(string me)
        {
            Point position = new Point(0, 0);

            switch (me)
            {
                case "ashe":
                    position = asheInitial;
                    break;

                case "bastion":
                    position = bastionInitial;
                    break;

                case "cree":
                    position = creeInitial;
                    break;

                case "doom":
                    position = doomInitial;
                    break;

                case "echo":
                    position = echoInitial;
                    break;

                case "genji":
                    position = genjiInitial;
                    break;

                case "hanzo":
                    position = hanzoInitial;
                    break;

                case "junk":
                    position = junkInitial;
                    break;

                case "mei":
                    position = meiInitial;
                    break;

                case "pharah":
                    position = pharahInitial;
                    break;

                case "reaper":
                    position = reaperInitial;
                    break;

                case "soldier":
                    position = soldierInitial;
                    break;

                case "sombra":
                    position = sombraInitial;
                    break;

                case "sym":
                    position = symInitial;
                    break;

                case "torb":
                    position = torbInitial;
                    break;

                case "tracer":
                    position = tracerInitial;
                    break;

                case "widow":
                    position = widowInitial;
                    break;

                case "winston":
                    position = winstionInitial;
                    break;

                case "zarya":
                    position = zaryaInitial;
                    break;

                case "dva":
                    position = dvaInitial;
                    break;

                case "rein":
                    position = reinInitial;
                    break;

                case "orisa":
                    position = orisaInitial;
                    break;

                case "hog":
                    position = hogInitial;
                    break;

                case "sigma":
                    position = sigInitial;
                    break;

                case "ball":
                    position = ballInitial;
                    break;
            }
            return position;
        }

        /*
         * Returns a character's first position value.
         */
        private bool GetMe(string me)
        {
            bool name = false;
            

            switch (me)
            {
                case "ashe":
                    name = asheFirstPos;
                    break;

                case "bastion":
                    name = bastionFirstPos;
                    break;

                case "cree":
                    name = creeFirstPos;
                    break;

                case "doom":
                    name = doomFirstPos;
                    break;

                case "echo":
                    name = echoFirstPos;
                    break;

                case "genji":
                    name = genjiFirstPos;
                    break;

                case "hanzo":
                    name = hanzoFirstPos;
                    break;

                case "junk":
                    name = junkFirstPos;
                    break;

                case "mei":
                    name = meiFirstPos;
                    break;

                case "pharah":
                    name = pharahFirstPos;
                    break;

                case "reaper":
                    name = reaperFirstPos;
                    break;

                case "soldier":
                    name = soldierFirstPos;
                    break;

                case "sombra":
                    name = sombraFirstPos;
                    break;

                case "sym":
                    name = symFirstPos;
                    break;

                case "torb":
                    name = torbFirstPos;
                    break;

                case "tracer":
                    name = tracerFirstPos;
                    break;

                case "widow":
                    name = widowFirstPos;
                    break;

                case "winston":
                    name = winstonFirstPos;
                    break;

                case "zarya":
                    name = zaryaFirstPos;
                    break;

                case "dva":
                    name = dvaFirstPos;
                    break;

                case "rein":
                    name = reinFirstPos;
                    break;

                case "orisa":
                    name = orisaFirstPos;
                    break;

                case "hog":
                    name = hogFirstPos;
                    break;

                case "sigma":
                    name = sigFirstPos;
                    break;

                case "ball":
                    name = ballFirstPos;
                    break;
            }
            return name;
            
        }

        /*
         * Changes the character's first positional value.
         */
        private void SetMe(string me, bool value)
        {
            switch (me)
            {
                case "ashe":
                    asheFirstPos = value;
                    break;

                case "bastion":
                    bastionFirstPos = value;
                    break;

                case "cree":
                    creeFirstPos = value;
                    break;

                case "doom":
                    doomFirstPos = value;
                    break;

                case "echo":
                    echoFirstPos = value;
                    break;

                case "genji":
                    genjiFirstPos = value;
                    break;

                case "hanzo":
                    hanzoFirstPos = value;
                    break;

                case "junk":
                    junkFirstPos = value;
                    break;

                case "mei":
                    meiFirstPos = value;
                    break;

                case "pharah":
                    pharahFirstPos = value;
                    break;

                case "reaper":
                    reaperFirstPos = value;
                    break;

                case "soldier":
                    soldierFirstPos = value;
                    break;

                case "sombra":
                    sombraFirstPos = value;
                    break;

                case "sym":
                    symFirstPos = value;
                    break;

                case "torb":
                    torbFirstPos = value;
                    break;

                case "tracer":
                    tracerFirstPos = value;
                    break;

                case "widow":
                    widowFirstPos = value;
                    break;

                case "winston":
                    winstonFirstPos = value;
                    break;

                case "zarya":
                    zaryaFirstPos = value;
                    break;

                case "dva":
                    dvaFirstPos = value;
                    break;

                case "rein":
                    reinFirstPos = value;
                    break;

                case "orisa":
                    orisaFirstPos = value;
                    break;

                case "hog":
                    hogFirstPos = value;
                    break;

                case "sigma":
                    sigFirstPos = value;
                    break;

                case "ball":
                    ballFirstPos = value;
                    break;
            }
        }

        /*
         * Method controlling movement of character icon into and out of role slots.
         */
        private void move(String use, Button self, String role)
        {
            {
                if (role == "dps")
                {
                    if (GetMe(use) && dps1 == false) // Checks if character is in it's initial position and if the first dps slot is occupied
                    {
                        self.Location = DPS1(); // Moves the character into the first dps slot.
                        SetMe(use, false); // Sets the character's first position field to false.
                        dps1 = true;
                    }

                    else if (GetMe(use) && dps1 == true && dps2 == false)
                    {
                        self.Location = DPS2();
                        SetMe(use, false);
                        dps2 = true;
                    }

                    else if (!GetMe(use) && self.Location == DPS1()) // Checks if character is not in it's initial position and if the character is in the first dps slot
                    {
                        self.Location = GetLoc(use);
                        SetMe(use, true);
                        dps1 = false;
                    }

                    else if (!GetMe(use) && self.Location == DPS2())
                    {
                        self.Location = GetLoc(use);
                        SetMe(use, true);
                        dps2 = false;
                    }
                }
                // -----------------Same as above but for tank-----------------------------
                else if (role == "tank")
                {
                    if (GetMe(use) && tank1 == false)
                    {
                        self.Location = Tank1();
                        SetMe(use, false);
                        tank1 = true;
                    }

                    else if (GetMe(use) && tank1 == true && tank2 == false)
                    {
                        self.Location = Tank2();
                        SetMe(use, false);
                        tank2 = true;
                    }

                    else if (!GetMe(use) && self.Location == Tank1())
                    {
                        self.Location = GetLoc(use);
                        SetMe(use, true);
                        tank1 = false;
                    }

                    else if (!GetMe(use) && self.Location == Tank2())
                    {
                        self.Location = GetLoc(use);
                        SetMe(use, true);
                        tank2 = false;
                    }
                }
            }
        }
       

        /*
         * *All of the below*
         * used to move around characters on press
         */
        private void btnAshe_Click(object sender, EventArgs e)
        {
            move("ashe", btnAshe, "dps");

        }

        private void btnBastion_Click(object sender, EventArgs e)
        {
            move("bastion", btnBastion, "dps");
        }

        private void btnCree_Click(object sender, EventArgs e)
        {
            move("cree", btnCree, "dps");
        }

        private void btnDoom_Click(object sender, EventArgs e)
        {
            move("doom", btnDoom, "dps");
        }

        private void btnEcho_Click(object sender, EventArgs e)
        {
            move("echo", btnEcho, "dps");
        }

        private void btnGenji_Click(object sender, EventArgs e)
        {
            move("genji", btnGenji, "dps");
        }

        private void btnHanzo_Click(object sender, EventArgs e)
        {
            move("hanzo", btnHanzo, "dps");
        }

        private void btnJunk_Click(object sender, EventArgs e)
        {
            move("junk", btnJunk, "dps");
        }

        private void btnMei_Click(object sender, EventArgs e)
        {
            move("mei", btnMei, "dps");
        }

        private void btnPharah_Click(object sender, EventArgs e)
        {
            move("pharah", btnPharah, "dps");
        }

        private void btnReaper_Click(object sender, EventArgs e)
        {
            move("reaper", btnReaper, "dps");
        }

        private void btnSoldier_Click(object sender, EventArgs e)
        {
            move("soldier", btnSoldier, "dps");
        }

        private void btnSombra_Click(object sender, EventArgs e)
        {
            move("sombra", btnSombra, "dps");
        }

        private void btnSym_Click(object sender, EventArgs e)
        {
            move("sym", btnSym, "dps");
        }

        private void btnTorb_Click(object sender, EventArgs e)
        {
            move("torb", btnTorb, "dps");
        }

        private void btnTracer_Click(object sender, EventArgs e)
        {
            move("tracer", btnTracer, "dps");
        }

        private void btnWidow_Click(object sender, EventArgs e)
        {
            move("widow", btnWidow, "dps");
        }

        private void btnWinston_Click(object sender, EventArgs e)
        {
            move("winston", btnWinston, "tank");
        }

        private void btnZarya_Click(object sender, EventArgs e)
        {
            move("zarya", btnZarya, "tank");
        }

        private void btnDva_Click(object sender, EventArgs e)
        {
            move("dva", btnDva, "tank");
        }

        private void btnRein_Click(object sender, EventArgs e)
        {
            move("rein", btnRein, "tank");
        }

        private void btnOrisa_Click(object sender, EventArgs e)
        {
            move("orisa", btnOrisa, "tank");
        }

        private void btnHog_Click(object sender, EventArgs e)
        {
            move("hog", btnHog, "tank");
        }

        private void btnSig_Click(object sender, EventArgs e)
        {
            move("sigma", btnSig, "tank");
        }

        private void btnBall_Click(object sender, EventArgs e)
        {
            move("ball", btnBall, "tank");
        }
    }
}
