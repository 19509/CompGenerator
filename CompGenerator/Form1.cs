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

        //Fields that show whether one of the role has a character in it or not.
        bool tank1 = false;
        bool tank2 = false;
        bool dps1 = false;
        bool dps2 = false;
        bool supp1 = false;
        bool supp2 = false;

        /*
         * ^
         * These two are very inefficient. Find way to create new button property.
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
        // ---------------------------
        bool winstonFirstPos = true;
        bool zaryaFirstPos = true;


        // Initial position of all characters
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
        //------------------------------------
        Point winstionInitial = new Point(183, 150);
        Point zaryaInitial = new Point(305, 298);

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
            if (!btnAna.Visible)
            {
                btnAna.Visible = true;
                btnBap.Visible = true;
                btnBrig.Visible = true;
                btnLucio.Visible = true;
                btnMercy.Visible = true;
                btnMoira.Visible = true;
                btnZen.Visible = true;
            }

            if (btnBall.Visible)
            {
                btnBall.Visible = false;
                btnDva.Visible = false;
                btnWinston.Visible = false;
                btnRein.Visible = false;
                btnOrisa.Visible = false;
                btnSig.Visible = false;
                btnZarya.Visible = false;
                btnHog.Visible = false;
            }

            if (btnGenji.Visible)
            {
                btnAshe.Visible = false;
                btnBastion.Visible = false;
                btnCree.Visible = false;
                btnDoom.Visible = false;
                btnEcho.Visible = false;
                btnGenji.Visible = false;
                btnHanzo.Visible = false;
                btnJunk.Visible = false;
                btnMei.Visible = false;
                btnPharah.Visible = false;
                btnReaper.Visible = false;
                btnSoldier.Visible = false;
                btnSombra.Visible = false;
                btnSym.Visible = false;
                btnTorb.Visible = false;
                btnTracer.Visible = false;
                btnWidow.Visible = false;
            }
        }

        /*
         * When pressing the tank button, all other roles are hidden, showing only tank characters.
         */
        private void btnTank_Click(object sender, EventArgs e)
        {
            if (!btnBall.Visible)
            {
                btnBall.Visible = true;
                btnDva.Visible = true;
                btnWinston.Visible = true;
                btnRein.Visible = true;
                btnOrisa.Visible = true;
                btnSig.Visible = true;
                btnZarya.Visible = true;
                btnHog.Visible = true;
            }

            if (btnAna.Visible)
            {
                btnAna.Visible = false;
                btnBap.Visible = false;
                btnBrig.Visible = false;
                btnLucio.Visible = false;
                btnMercy.Visible = false;
                btnMoira.Visible = false;
                btnZen.Visible = false;
            }

            if (btnGenji.Visible)
            {
                btnAshe.Visible = false;
                btnBastion.Visible = false;
                btnCree.Visible = false;
                btnDoom.Visible = false;
                btnEcho.Visible = false;
                btnGenji.Visible = false;
                btnHanzo.Visible = false;
                btnJunk.Visible = false;
                btnMei.Visible = false;
                btnPharah.Visible = false;
                btnReaper.Visible = false;
                btnSoldier.Visible = false;
                btnSombra.Visible = false;
                btnSym.Visible = false;
                btnTorb.Visible = false;
                btnTracer.Visible = false;
                btnWidow.Visible = false;
            }
        }

        /*
         * When pressing the DPS button, all character outside the role will be hidden, showing only dps characters.
         */
        private void btnDPS_Click(object sender, EventArgs e)
        {
            if (!btnGenji.Visible)
            {
                btnAshe.Visible = true;
                btnBastion.Visible = true;
                btnCree.Visible = true;
                btnDoom.Visible = true;
                btnEcho.Visible = true;
                btnGenji.Visible = true;
                btnHanzo.Visible = true;
                btnJunk.Visible = true;
                btnMei.Visible = true;
                btnPharah.Visible = true;
                btnReaper.Visible = true;
                btnSoldier.Visible = true;
                btnSombra.Visible = true;
                btnSym.Visible = true;
                btnTorb.Visible = true;
                btnTracer.Visible = true;
                btnWidow.Visible = true;
            }

            if (btnAna.Visible)
            {
                btnAna.Visible = false;
                btnBap.Visible = false;
                btnBrig.Visible = false;
                btnLucio.Visible = false;
                btnMercy.Visible = false;
                btnMoira.Visible = false;
                btnZen.Visible = false;
            }

            if (btnBall.Visible)
            {
                btnBall.Visible = false;
                btnDva.Visible = false;
                btnWinston.Visible = false;
                btnRein.Visible = false;
                btnOrisa.Visible = false;
                btnSig.Visible = false;
                btnZarya.Visible = false;
                btnHog.Visible = false;
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
    }
}
