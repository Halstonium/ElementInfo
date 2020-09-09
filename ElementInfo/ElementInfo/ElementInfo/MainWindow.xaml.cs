using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.Windows.Forms;

namespace ElementInfo
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            // Store the content of the selected button as a string
            object obj = (sender as System.Windows.Controls.Button).Content;
            string str = (string)obj;

            // Contains all strings that involve properties of elements
            string[] strings =
            {
                "Element Name: Hydrogen\nAtomic Number: 1\nAtomic Mass: 1.008",
                "Element Name: Helium\nAtomic Number: 2\nAtomic Mass: 4.0026",
                "Element Name: Lithium\nAtomic Number: 3\nAtomic Mass: 6.94",
                "Element Name: Beryllium\nAtomic Number: 4\nAtomic Mass: 9.0122",
                "Element Name: Boron\nAtomic Number: 5\nAtomic Mass: 10.81",
                "Element Name: Carbon\nAtomic Number: 6\nAtomic Mass: 12.011",
                "Element Name: Nitrogen\nAtomic Number: 7\nAtomic Mass: 14.007",
                "Element Name: Oxygen\nAtomic Number: 8\nAtomic Mass: 15.999",
                "Element Name: Fluorine\nAtomic Number: 9\nAtomic Mass: 18.998",
                "Element Name: Neon\nAtomic Number: 10\nAtomic Mass: 20.180",
                "Element Name: Sodium\nAtomic Number: 11\nAtomic Mass: 22.990",
                "Element Name: Magnesium\nAtomic Number: 12\nAtomic Mass: 24.305",
                "Element Name: Aluminium\nAtomic Number: 13\nAtomic Mass: 26.982",
                "Element Name: Silicon\nAtomic Number: 14\nAtomic Mass: 28.085",
                "Element Name: Phosphorus\nAtomic Number: 15\nAtomic Mass: 30.974",
                "Element Name: Sulfur\nAtomic Number: 16\nAtomic Mass: 32.06",
                "Element Name: Chlorine\nAtomic Number: 17\nAtomic Mass: 35.45",
                "Element Name: Argon\nAtomic Number: 18\nAtomic Mass: 39.95",
                "Element Name: Potassium\nAtomic Number: 19\nAtomic Mass: 39.098",
                "Element Name: Calcium\nAtomic Number: 20\nAtomic Mass: 40.078",
                "Element Name: Scandium\nAtomic Number: 21\nAtomic Mass: 44.956",
                "Element Name: Titanium\nAtomic Number: 22\nAtomic Mass: 47.867",
                "Element Name: Vanadium\nAtomic Number: 23\nAtomic Mass: 50.942",
                "Element Name: Chromium\nAtomic Number: 24\nAtomic Mass: 51.996",
                "Element Name: Manganese\nAtomic Number: 25\nAtomic Mass: 54.938",
                "Element Name: Iron\nAtomic Number: 26\nAtomic Mass: 55.845",
                "Element Name: Cobalt\nAtomic Number: 27\nAtomic Mass: 58.933",
                "Element Name: Nickel\nAtomic Number: 28\nAtomic Mass: 58.693",
                "Element Name: Copper\nAtomic Number: 29\nAtomic Mass: 63.546",
                "Element Name: Zinc\nAtomic Number: 30\nAtomic Mass: 65.38",
                "Element Name: Gallium\nAtomic Number: 31\nAtomic Mass: 69.723",
                "Element Name: Germanium\nAtomic Number: 32\nAtomic Mass: 72.630",
                "Element Name: Arsenic\nAtomic Number: 33\nAtomic Mass: 74.922",
                "Element Name: Selenium\nAtomic Number: 34\nAtomic Mass: 78.971",
                "Element Name: Bromine\nAtomic Number: 35\nAtomic Mass: 79.904",
                "Element Name: Krypton\nAtomic Number: 36\nAtomic Mass: 83.798",
                "Element Name: Rubidium\nAtomic Number: 37\nAtomic Mass: 85.468",
                "Element Name: Strontium\nAtomic Number: 38\nAtomic Mass: 87.62",
                "Element Name: Yttrium\nAtomic Number: 39\nAtomic Mass: 88.906",
                "Element Name: Zirconium\nAtomic Number: 40\nAtomic Mass: 91.224",
                "Element Name: Niobium\nAtomic Number: 41\nAtomic Mass: 92.906",
                "Element Name: Molybdenum\nAtomic Number: 42\nAtomic Mass: 95.95",
                "Element Name: Technetium\nAtomic Number: 43\nAtomic Mass: [97]",
                "Element Name: Ruthenium\nAtomic Number: 44\nAtomic Mass: 101.07",
                "Element Name: Rhodium\nAtomic Number: 45\nAtomic Mass: 102.91",
                "Element Name: Palladium\nAtomic Number: 46\nAtomic Mass: 106.42",
                "Element Name: Silver\nAtomic Number: 47\nAtomic Mass: 107.87",
                "Element Name: Cadmium\nAtomic Number: 48\nAtomic Mass: 112.41",
                "Element Name: Indium\nAtomic Number: 49\nAtomic Mass: 114.82",
                "Element Name: Tin\nAtomic Number: 50\nAtomic Mass: 118.71",
                "Element Name: Antimony\nAtomic Number: 51\nAtomic Mass: 121.76",
                "Element Name: Tellurium\nAtomic Number: 52\nAtomic Mass: 127.60",
                "Element Name: Iodine\nAtomic Number: 53\nAtomic Mass: 126.90",
                "Element Name: Xenon\nAtomic Number: 54\nAtomic Mass: 131.29",
                "Element Name: Caesium\nAtomic Number: 55\nAtomic Mass: 132.91",
                "Element Name: Barium\nAtomic Number: 56\nAtomic Mass: 137.33",
                "Element Name: Lanthanum\nAtomic Number: 57\nAtomic Mass: 138.91",
                "Element Name: Cerium\nAtomic Number: 58\nAtomic Mass: 140.12",
                "Element Name: Praseodymium\nAtomic Number: 59\nAtomic Mass: 140.91",
                "Element Name: Neodymium\nAtomic Number: 60\nAtomic Mass: 144.24",
                "Element Name: Promethium\nAtomic Number: 61\nAtomic Mass: [145]",
                "Element Name: Samarium\nAtomic Number: 62\nAtomic Mass: 150.36",
                "Element Name: Europium\nAtomic Number: 63\nAtomic Mass: 151.96",
                "Element Name: Gadolinium\nAtomic Number: 64\nAtomic Mass: 157.25",
                "Element Name: Terbium\nAtomic Number: 65\nAtomic Mass: 158.93",
                "Element Name: Dysprosium\nAtomic Number: 66\nAtomic Mass: 162.50",
                "Element Name: Holmium\nAtomic Number: 67\nAtomic Mass: 164.93",
                "Element Name: Erbium\nAtomic Number: 68\nAtomic Mass: 167.26",
                "Element Name: Thulium\nAtomic Number: 69\nAtomic Mass: 168.93",
                "Element Name: Ytterbium\nAtomic Number: 70\nAtomic Mass: 173.05",
                "Element Name: Lutetium\nAtomic Number: 71\nAtomic Mass: 174.97",
                "Element Name: Hafnium\nAtomic Number: 72\nAtomic Mass: 178.49",
                "Element Name: Tantalum\nAtomic Number: 73\nAtomic Mass: 180.95",
                "Element Name: Tungsten\nAtomic Number: 74\nAtomic Mass: 183.84",
                "Element Name: Rhenium\nAtomic Number: 75\nAtomic Mass: 186.21",
                "Element Name: Osmium\nAtomic Number: 76\nAtomic Mass: 190.23",
                "Element Name: Iridium\nAtomic Number: 77\nAtomic Mass: 192.22",
                "Element Name: Platinum\nAtomic Number: 78\nAtomic Mass: 195.08",
                "Element Name: Gold\nAtomic Number: 79\nAtomic Mass: 196.97",
                "Element Name: Mercury\nAtomic Number: 80\nAtomic Mass: 200.59",
                "Element Name: Thallium\nAtomic Number: 81\nAtomic Mass: 204.38",
                "Element Name: Lead\nAtomic Number: 82\nAtomic Mass: 207.2",
                "Element Name: Bismuth\nAtomic Number: 83\nAtomic Mass: 208.98",
                "Element Name: Polonium\nAtomic Number: 84\nAtomic Mass: [209]",
                "Element Name: Astatine\nAtomic Number: 85\nAtomic Mass: [210]",
                "Element Name: Radon\nAtomic Number: 86\nAtomic Mass: [222]",
                "Element Name: Francium\nAtomic Number: 87\nAtomic Mass: [223]",
                "Element Name: Radium\nAtomic Number: 88\nAtomic Mass: [226]",
                "Element Name: Actinium\nAtomic Number: 89\nAtomic Mass: [227]",
                "Element Name: Thorium\nAtomic Number: 90\nAtomic Mass: 232.04",
                "Element Name: Protactinium\nAtomic Number: 91\nAtomic Mass: 231.04",
                "Element Name: Uranium\nAtomic Number: 92\nAtomic Mass: 238.03",
                "Element Name: Neptunium\nAtomic Number: 93\nAtomic Mass: [237]",
                "Element Name: Plutonium\nAtomic Number: 94\nAtomic Mass: [244]",
                "Element Name: Americium\nAtomic Number: 95\nAtomic Mass: [243]",
                "Element Name: Curium\nAtomic Number: 96\nAtomic Mass: [247]",
                "Element Name: Berkelium\nAtomic Number: 97\nAtomic Mass: [247]",
                "Element Name: Californium\nAtomic Number: 98\nAtomic Mass: [251]",
                "Element Name: Einsteinium\nAtomic Number: 99\nAtomic Mass: [252]",
                "Element Name: Fermium\nAtomic Number: 100\nAtomic Mass: [257]",
                "Element Name: Mendelevium\nAtomic Number: 101\nAtomic Mass: [258]",
                "Element Name: Nobelium\nAtomic Number: 102\nAtomic Mass: [259]",
                "Element Name: Lawrencium\nAtomic Number: 103\nAtomic Mass: [266]",
                "Element Name: Rutherfordium\nAtomic Number: 104\nAtomic Mass: [267]",
                "Element Name: Dubnium\nAtomic Number: 105\nAtomic Mass: [268]",
                "Element Name: Seaborgium\nAtomic Number: 106\nAtomic Mass: [269]",
                "Element Name: Bohrium\nAtomic Number: 107\nAtomic Mass: [270]",
                "Element Name: Hassium\nAtomic Number: 108\nAtomic Mass: [269]",
                "Element Name: Meitnerium\nAtomic Number: 109\nAtomic Mass: [278]",
                "Element Name: Darmstadtium\nAtomic Number: 110\nAtomic Mass: [281]",
                "Element Name: Roentgenium\nAtomic Number: 111\nAtomic Mass: [282]",
                "Element Name: Copernicium\nAtomic Number: 112\nAtomic Mass: [285]",
                "Element Name: Nihonium\nAtomic Number: 113\nAtomic Mass: [286]",
                "Element Name: Flerovium\nAtomic Number: 114\nAtomic Mass: [289]",
                "Element Name: Moscovium\nAtomic Number: 115\nAtomic Mass: [290]",
                "Element Name: Livermorium\nAtomic Number: 116\nAtomic Mass: [293]",
                "Element Name: Tennessine\nAtomic Number: 117\nAtomic Mass: [294]",
                "Element Name: Oganesson\nAtomic Number: 118\nAtomic Mass: [294]",
            };

            switch (str)
            {
                case "H":
                    System.Windows.Forms.MessageBox.Show(strings[0], "Element Informer", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    break;
                case "He":
                    System.Windows.Forms.MessageBox.Show(strings[1], "Element Informer", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    break;
                case "Li":
                    System.Windows.Forms.MessageBox.Show(strings[2], "Element Informer", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    break;
                case "Be":
                    System.Windows.Forms.MessageBox.Show(strings[3], "Element Informer", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    break;
                case "B":
                    System.Windows.Forms.MessageBox.Show(strings[4], "Element Informer", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    break;
                case "C":
                    System.Windows.Forms.MessageBox.Show(strings[5], "Element Informer", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    break;
                case "N":
                    System.Windows.Forms.MessageBox.Show(strings[6], "Element Informer", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    break;
                case "O":
                    System.Windows.Forms.MessageBox.Show(strings[7], "Element Informer", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    break;
                case "F":
                    System.Windows.Forms.MessageBox.Show(strings[8], "Element Informer", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    break;
                case "Ne":
                    System.Windows.Forms.MessageBox.Show(strings[9], "Element Informer", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    break;
                case "Na":
                    System.Windows.Forms.MessageBox.Show(strings[10], "Element Informer", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    break;
                case "Mg":
                    System.Windows.Forms.MessageBox.Show(strings[11], "Element Informer", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    break;
                case "Al":
                    System.Windows.Forms.MessageBox.Show(strings[12], "Element Informer", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    break;
                case "Si":
                    System.Windows.Forms.MessageBox.Show(strings[13], "Element Informer", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    break;
                case "P":
                    System.Windows.Forms.MessageBox.Show(strings[14], "Element Informer", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    break;
                case "S":
                    System.Windows.Forms.MessageBox.Show(strings[15], "Element Informer", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    break;
                case "Cl":
                    System.Windows.Forms.MessageBox.Show(strings[16], "Element Informer", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    break;
                case "Ar":
                    System.Windows.Forms.MessageBox.Show(strings[17], "Element Informer", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    break;
                case "K":
                    System.Windows.Forms.MessageBox.Show(strings[18], "Element Informer", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    break;
                case "Ca":
                    System.Windows.Forms.MessageBox.Show(strings[19], "Element Informer", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    break;
                case "Sc":
                    System.Windows.Forms.MessageBox.Show(strings[20], "Element Informer", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    break;
                case "Ti":
                    System.Windows.Forms.MessageBox.Show(strings[21], "Element Informer", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    break;
                case "V":
                    System.Windows.Forms.MessageBox.Show(strings[22], "Element Informer", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    break;
                case "Cr":
                    System.Windows.Forms.MessageBox.Show(strings[23], "Element Informer", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    break;
                case "Mn":
                    System.Windows.Forms.MessageBox.Show(strings[24], "Element Informer", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    break;
                case "Fe":
                    System.Windows.Forms.MessageBox.Show(strings[25], "Element Informer", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    break;
                case "Co":
                    System.Windows.Forms.MessageBox.Show(strings[26], "Element Informer", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    break;
                case "Ni":
                    System.Windows.Forms.MessageBox.Show(strings[27], "Element Informer", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    break;
                case "Cu":
                    System.Windows.Forms.MessageBox.Show(strings[28], "Element Informer", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    break;
                case "Zn":
                    System.Windows.Forms.MessageBox.Show(strings[29], "Element Informer", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    break;
                case "Ga":
                    System.Windows.Forms.MessageBox.Show(strings[30], "Element Informer", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    break;
                case "Ge":
                    System.Windows.Forms.MessageBox.Show(strings[31], "Element Informer", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    break;
                case "As":
                    System.Windows.Forms.MessageBox.Show(strings[32], "Element Informer", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    break;
                case "Se":
                    System.Windows.Forms.MessageBox.Show(strings[33], "Element Informer", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    break;
                case "Br":
                    System.Windows.Forms.MessageBox.Show(strings[34], "Element Informer", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    break;
                case "Kr":
                    System.Windows.Forms.MessageBox.Show(strings[35], "Element Informer", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    break;
                case "Rb":
                    System.Windows.Forms.MessageBox.Show(strings[36], "Element Informer", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    break;
                case "Sr":
                    System.Windows.Forms.MessageBox.Show(strings[37], "Element Informer", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    break;
                case "Y":
                    System.Windows.Forms.MessageBox.Show(strings[38], "Element Informer", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    break;
                case "Zr":
                    System.Windows.Forms.MessageBox.Show(strings[39], "Element Informer", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    break;
                case "Nb":
                    System.Windows.Forms.MessageBox.Show(strings[40], "Element Informer", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    break;
                case "Mo":
                    System.Windows.Forms.MessageBox.Show(strings[41], "Element Informer", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    break;
                case "Tc":
                    System.Windows.Forms.MessageBox.Show(strings[42], "Element Informer", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    break;
                case "Ru":
                    System.Windows.Forms.MessageBox.Show(strings[43], "Element Informer", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    break;
                case "Rh":
                    System.Windows.Forms.MessageBox.Show(strings[44], "Element Informer", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    break;
                case "Pd":
                    System.Windows.Forms.MessageBox.Show(strings[45], "Element Informer", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    break;
                case "Ag":
                    System.Windows.Forms.MessageBox.Show(strings[46], "Element Informer", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    break;
                case "Cd":
                    System.Windows.Forms.MessageBox.Show(strings[47], "Element Informer", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    break;
                case "In":
                    System.Windows.Forms.MessageBox.Show(strings[48], "Element Informer", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    break;
                case "Sn":
                    System.Windows.Forms.MessageBox.Show(strings[49], "Element Informer", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    break;
                case "Sb":
                    System.Windows.Forms.MessageBox.Show(strings[50], "Element Informer", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    break;
                case "Te":
                    System.Windows.Forms.MessageBox.Show(strings[51], "Element Informer", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    break;
                case "I":
                    System.Windows.Forms.MessageBox.Show(strings[52], "Element Informer", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    break;
                case "Xe":
                    System.Windows.Forms.MessageBox.Show(strings[53], "Element Informer", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    break;
                case "Cs":
                    System.Windows.Forms.MessageBox.Show(strings[54], "Element Informer", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    break;
                case "Ba":
                    System.Windows.Forms.MessageBox.Show(strings[55], "Element Informer", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    break;
                case "La":
                    System.Windows.Forms.MessageBox.Show(strings[56], "Element Informer", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    break;
                case "Ce":
                    System.Windows.Forms.MessageBox.Show(strings[57], "Element Informer", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    break;
                case "Pr":
                    System.Windows.Forms.MessageBox.Show(strings[58], "Element Informer", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    break;
                case "Nd":
                    System.Windows.Forms.MessageBox.Show(strings[59], "Element Informer", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    break;
                case "Pm":
                    System.Windows.Forms.MessageBox.Show(strings[60], "Element Informer", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    break;
                case "Sm":
                    System.Windows.Forms.MessageBox.Show(strings[61], "Element Informer", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    break;
                case "Eu":
                    System.Windows.Forms.MessageBox.Show(strings[62], "Element Informer", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    break;
                case "Gd":
                    System.Windows.Forms.MessageBox.Show(strings[63], "Element Informer", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    break;
                case "Tb":
                    System.Windows.Forms.MessageBox.Show(strings[64], "Element Informer", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    break;
                case "Dy":
                    System.Windows.Forms.MessageBox.Show(strings[65], "Element Informer", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    break;
                case "Ho":
                    System.Windows.Forms.MessageBox.Show(strings[66], "Element Informer", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    break;
                case "Er":
                    System.Windows.Forms.MessageBox.Show(strings[67], "Element Informer", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    break;
                case "Tm":
                    System.Windows.Forms.MessageBox.Show(strings[68], "Element Informer", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    break;
                case "Yb":
                    System.Windows.Forms.MessageBox.Show(strings[69], "Element Informer", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    break;
                case "Lu":
                    System.Windows.Forms.MessageBox.Show(strings[70], "Element Informer", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    break;
                case "Hf":
                    System.Windows.Forms.MessageBox.Show(strings[71], "Element Informer", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    break;
                case "Ta":
                    System.Windows.Forms.MessageBox.Show(strings[72], "Element Informer", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    break;
                case "W":
                    System.Windows.Forms.MessageBox.Show(strings[73], "Element Informer", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    break;
                case "Re":
                    System.Windows.Forms.MessageBox.Show(strings[74], "Element Informer", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    break;
                case "Os":
                    System.Windows.Forms.MessageBox.Show(strings[75], "Element Informer", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    break;
                case "Ir":
                    System.Windows.Forms.MessageBox.Show(strings[76], "Element Informer", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    break;
                case "Pt":
                    System.Windows.Forms.MessageBox.Show(strings[77], "Element Informer", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    break;
                case "Au":
                    System.Windows.Forms.MessageBox.Show(strings[78], "Element Informer", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    break;
                case "Hg":
                    System.Windows.Forms.MessageBox.Show(strings[79], "Element Informer", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    break;
                case "Tl":
                    System.Windows.Forms.MessageBox.Show(strings[80], "Element Informer", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    break;
                case "Pb":
                    System.Windows.Forms.MessageBox.Show(strings[81], "Element Informer", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    break;
                case "Bi":
                    System.Windows.Forms.MessageBox.Show(strings[82], "Element Informer", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    break;
                case "Po":
                    System.Windows.Forms.MessageBox.Show(strings[83], "Element Informer", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    break;
                case "At":
                    System.Windows.Forms.MessageBox.Show(strings[84], "Element Informer", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    break;
                case "Rn":
                    System.Windows.Forms.MessageBox.Show(strings[85], "Element Informer", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    break;
                case "Fr":
                    System.Windows.Forms.MessageBox.Show(strings[86], "Element Informer", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    break;
                case "Ra":
                    System.Windows.Forms.MessageBox.Show(strings[87], "Element Informer", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    break;
                case "Ac":
                    System.Windows.Forms.MessageBox.Show(strings[88], "Element Informer", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    break;
                case "Th":
                    System.Windows.Forms.MessageBox.Show(strings[89], "Element Informer", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    break;
                case "Pa":
                    System.Windows.Forms.MessageBox.Show(strings[90], "Element Informer", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    break;
                case "U":
                    System.Windows.Forms.MessageBox.Show(strings[91], "Element Informer", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    break;
                case "Np":
                    System.Windows.Forms.MessageBox.Show(strings[92], "Element Informer", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    break;
                case "Pu":
                    System.Windows.Forms.MessageBox.Show(strings[93], "Element Informer", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    break;
                case "Am":
                    System.Windows.Forms.MessageBox.Show(strings[94], "Element Informer", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    break;
                case "Cm":
                    System.Windows.Forms.MessageBox.Show(strings[95], "Element Informer", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    break;
                case "Bk":
                    System.Windows.Forms.MessageBox.Show(strings[96], "Element Informer", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    break;
                case "Cf":
                    System.Windows.Forms.MessageBox.Show(strings[97], "Element Informer", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    break;
                case "Es":
                    System.Windows.Forms.MessageBox.Show(strings[98], "Element Informer", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    break;
                case "Fm":
                    System.Windows.Forms.MessageBox.Show(strings[99], "Element Informer", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    break;
                case "Md":
                    System.Windows.Forms.MessageBox.Show(strings[100], "Element Informer", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    break;
                case "No":
                    System.Windows.Forms.MessageBox.Show(strings[101], "Element Informer", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    break;
                case "Lr":
                    System.Windows.Forms.MessageBox.Show(strings[102], "Element Informer", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    break;
                case "Rf":
                    System.Windows.Forms.MessageBox.Show(strings[103], "Element Informer", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    break;
                case "Db":
                    System.Windows.Forms.MessageBox.Show(strings[104], "Element Informer", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    break;
                case "Sg":
                    System.Windows.Forms.MessageBox.Show(strings[105], "Element Informer", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    break;
                case "Bh":
                    System.Windows.Forms.MessageBox.Show(strings[106], "Element Informer", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    break;
                case "Hs":
                    System.Windows.Forms.MessageBox.Show(strings[107], "Element Informer", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    break;
                case "Mt":
                    System.Windows.Forms.MessageBox.Show(strings[108], "Element Informer", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    break;
                case "Ds":
                    System.Windows.Forms.MessageBox.Show(strings[109], "Element Informer", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    break;
                case "Rg":
                    System.Windows.Forms.MessageBox.Show(strings[110], "Element Informer", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    break;
                case "Cn":
                    System.Windows.Forms.MessageBox.Show(strings[111], "Element Informer", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    break;
                case "Nh":
                    System.Windows.Forms.MessageBox.Show(strings[112], "Element Informer", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    break;
                case "Fl":
                    System.Windows.Forms.MessageBox.Show(strings[113], "Element Informer", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    break;
                case "Mc":
                    System.Windows.Forms.MessageBox.Show(strings[114], "Element Informer", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    break;
                case "Lv":
                    System.Windows.Forms.MessageBox.Show(strings[115], "Element Informer", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    break;
                case "Ts":
                    System.Windows.Forms.MessageBox.Show(strings[116], "Element Informer", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    break;
                case "Og":
                    System.Windows.Forms.MessageBox.Show(strings[117], "Element Informer", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    break;
            }
        }
    }
}
