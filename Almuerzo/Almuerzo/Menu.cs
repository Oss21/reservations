using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Almuerzo
{
	public partial class Menu : Form
	{
		private Data data;
		private const string Path = "C:/Users/osvan/source/repos/Almuerzo/Almuerzo/datos.txt";
		String[] proteinA = {"Huevo","Pollo","Salmon","Milanesa de cerdo","Milanesa de pollo","Ninguna"};
		String[] grainA = {"Frijoles","Blanquillos","Lentejas","averjas","Ninguna" };
		String[] saladA = { "Zanahoria","habichuela","lechuga","Ninguna" };


		public Menu()
		{
			InitializeComponent();
			data = new Data();
		}

		private void btAdd_Click(object sender, EventArgs e)
		{
			String identification = tbIdentification.Text;
			String name = tbName.Text;
			String protein = tbProtein.Text;
			String grain = tbGrain.Text;
			String salad = tbSalad.Text;

			AddOrder(identification,name,protein,grain,salad);
			

			tbIdentification.Clear();
			tbName.Clear();
		}


		private void AddOrder(string identification, string name, string protein, string grain, string salad)
		{
			StreamWriter writer = new StreamWriter(Path, true);
			writer.WriteLine(identification+"-"+name+"-"+protein+"-"+grain+"-"+salad);
			writer.Close();


		}







		private void Form1_Load(object sender, EventArgs e)
		{
			for (int i = 0; i < proteinA.Length;i++)
			{
			tbProtein.Items.Add(proteinA[i]);
			}
			for (int i = 0; i < grainA.Length; i++)
			{
			tbGrain.Items.Add(grainA[i]);
			}
			for (int i = 0; i < saladA.Length; i++)
			{
			tbSalad.Items.Add(saladA[i]);
			}
			

		}

		private void SeeRecord_Click(object sender, EventArgs e)
		{
			LoadOrder();
			data.ShowDialog();
		}

		private void LoadOrder()
		{
			StreamReader  sr = new StreamReader(Path);
			String line = sr.ReadLine();

			while (line != null)
			{
				string[] values = line.Split('-');
				Console.WriteLine(values.Length);
				
					data.AddElements(values[0],values[1],values[2],values[3],values[4]);

				line = sr.ReadLine();
			}

		}
	}
}
