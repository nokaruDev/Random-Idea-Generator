using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class RIG : Form
    {
        public RIG()
        {
            InitializeComponent();
        }

        private void ButtonGene_Click(object sender, EventArgs e)
        {
            string[] tab = new string[4] { "Helicopter", "Machine Of Destrucion", "Armor", "Gun" };
            Random random = new Random();
            int index = random.Next(0, 3);
            string text = tab[index];
            txIdea.Text = text;

            string[] tab2 = new string[3] { "with", "on", "linked to" };
            
            int index2 = random.Next(0, 3);
            string text2 = tab2[index2];
            textBox1.Text = text2;

            string[] tab3 = new string[3] {"Mech" , "OP Car" , "Human" };
            
            int index3 = random.Next(0, 3);
            string text3 = tab3[index3];
            textBox2.Text = text3;

        }

        private void ButtonGene2_Click(object sender, EventArgs e)
        {
            string[] tab = new string[3] { "Wooden", "Wooden & Stone", "Stone" };
            Random random = new Random();
            int index = random.Next(0, 3);
            string text = tab[index];
            txIdea.Text = text;

            string[] tab2 = new string[3] { "House", "Safe House", "Staute" };

            int index2 = random.Next(0, 3);
            string text2 = tab2[index2];
            textBox1.Text = text2;

            string[] tab3 = new string[3] { "With redstone", "On survival", "On creative" };

            int index3 = random.Next(0, 3);
            string text3 = tab3[index3];
            textBox2.Text = text3;

        }

        private void ButtonGene3_Click(object sender, EventArgs e)
        {
            string[] tab = new string[3] { "Trap on", "Colleting", "Playing(with)" };
            Random random = new Random();
            int index = random.Next(0, 3);
            string text = tab[index];
            txIdea.Text = text;

            string[] tab2 = new string[3] { "Rabbits(leather)", "Friends", "Caniballs(bones)" };

            int index2 = random.Next(0, 3);
            string text2 = tab2[index2];
            textBox1.Text = text2;

            string[] tab3 = new string[3] { "in day", "in night", "in developer mode" };

            int index3 = random.Next(0, 3);
            string text3 = tab3[index3];
            textBox2.Text = text3;
        }

        private void ButtonGene4_Click(object sender, EventArgs e)
        {
            string[] tab = new string[7] { "V-tol", "Gun", "Human", "Cyborg", "Metal", "Wooden", "Concrete" };
            Random random = new Random();
            int index = random.Next(0, 7);
            string text = tab[index];
            txIdea.Text = text;

            string[] tab2 = new string[3] { "With in", "From", "Out Of (a)" };

            int index2 = random.Next(0, 3);
            string text2 = tab2[index2];
            textBox1.Text = text2;

            string[] tab3 = new string[12] { "Alien", "Shit", "Sheet", "Syringe", "Robot", "Flail", "Mace", "Siege", "Canon", "Masterpiece", "Deep", "Deep within" };

            int index3 = random.Next(0, 12);
            string text3 = tab3[index3];
            textBox2.Text = text3;
        }

        private void ButtonGene5_Click(object sender, EventArgs e)
        {
            string[] tab = new string[15] { "V-tol", "Gun", "Human", "Cyborg", "Metal", "Wooden", "Concrete", "Plane", "Car", "Boat", "Submarine", "Hovercraft", "Bike", "Volt-bike", "Puppet" };
            Random random = new Random();
            int index = random.Next(0, 15);
            string text = tab[index];
            txIdea.Text = text;

            string[] tab2 = new string[3] { "With in", "From", "Out Of (a)" };

            int index2 = random.Next(0, 3);
            string text2 = tab2[index2];
            textBox1.Text = text2;

            string[] tab3 = new string[12] { "Alien", "Shit", "Sheet", "Syringe", "Robot", "Flail", "Mace", "Siege", "Canon", "Masterpiece", "Deep", "Deep within" };

            int index3 = random.Next(0, 12);
            string text3 = tab3[index3];
            textBox2.Text = text3;
        }

        private void ButtonGene6_Click(object sender, EventArgs e)
        {
            string[] tab = new string[6] { "Alien", "Bonzai Tree", "Car", "Human", "Design", "Anime" };
            Random random = new Random();
            int index = random.Next(0, 3);
            string text = tab[index];
            txIdea.Text = text;

            string[] tab2 = new string[3] { "With(in)", "On", "In"};

            int index2 = random.Next(0, 3);
            string text2 = tab2[index2];
            textBox1.Text = text2;

            string[] tab3 = new string[7] { "Moutain", "Cave", "TV", "Game", "Clothes", "Gun", "City" };

            int index3 = random.Next(0, 6);
            string text3 = tab3[index3];
            textBox2.Text = text3;
        }

        private void ButtonGene7_Click(object sender, EventArgs e)
        {
            string[] tab = new string[3] { "Build", "Get", "Destroy" };
            Random random = new Random();
            int index = random.Next(0, 3);
            string text = tab[index];
            txIdea.Text = text;

            string[] tab2 = new string[3] { "Hellevator(Items)", "NPCS", "Big house/Structure in the desert" };

            int index2 = random.Next(0, 3);
            string text2 = tab2[index2];
            textBox1.Text = text2;

            string[] tab3 = new string[3] { "Without Normal or Expert only Master Mode", "With Only Buyable Block/Items From NPC", "With only Natural Blocks/Cave Items" };

            int index3 = random.Next(0, 3);
            string text3 = tab3[index3];
            textBox2.Text = text3;
        }

        private void ButtonGene8_Click(object sender, EventArgs e)
        {
            string[] tab = new string[8] { "Farm", "Stone", "Tek", "Platform", "Mastercraft", "Yourneyman", "Ammo", "Get Every Dinosaur" };
            Random random = new Random();
            int index = random.Next(0, 8);
            string text = tab[index];
            txIdea.Text = text;

            string[] tab2 = new string[5] { "Refill", "Gun", "That is", "For", "Of" };

            int index2 = random.Next(0, 5);
            string text2 = tab2[index2];
            textBox1.Text = text2;

            string[] tab3 = new string[3] { "Station", "Gym", "Practical" };

            int index3 = random.Next(0, 3);
            string text3 = tab3[index3];
            textBox2.Text = text3;
        }

        private void ButtonGene9_Click(object sender, EventArgs e)
        {
            string[] tab = new string[8] { "Farm", "Stone", "Tek", "Platform", "Mastercraft", "Yourneyman", "Ammo", "Get Every Dinosaur" };
            Random random = new Random();
            int index = random.Next(0, 8);
            string text = tab[index];
            txIdea.Text = text;

            string[] tab2 = new string[5] { "Refill", "Gun", "That is", "For", "Of" };

            int index2 = random.Next(0, 5);
            string text2 = tab2[index2];
            textBox1.Text = text2;

            string[] tab3 = new string[3] { "Station", "Gym", "Practical" };

            int index3 = random.Next(0, 3);
            string text3 = tab3[index3];
            textBox2.Text = text3;
        }

        private void ButtonGene10_Click(object sender, EventArgs e)
        {
            string[] tab = new string[2] { "Make", "Create" };
            Random random = new Random();
            int index = random.Next(0, 2);
            string text = tab[index];
            txIdea.Text = text;

            string[] tab2 = new string[2] { "A", "A an" };

            int index2 = random.Next(0, 2);
            string text2 = tab2[index2];
            textBox1.Text = text2;

            string[] tab3 = new string[7] { "Landscape", "Car", "Plane", "Gun", "Melee Weapon", "Boat", "Animation With SMTH" };

            int index3 = random.Next(0, 7);
            string text3 = tab3[index3];
            textBox2.Text = text3;
        }
    }
}
