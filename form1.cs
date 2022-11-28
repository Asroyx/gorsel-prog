using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace kombobox1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            ArrayList listem = new ArrayList();
            listem.Add(35);
            listem.Add(3.14);
            listem.Add("C#");
            listem.Add("Java");
            listem.Add("JavaScript");

            label1.Text = "Eleman sayısı: " + listem.Count + " Kapasite: " + listem.Capacity + "\n";
            label1.Text = label1.Text + "---------------------------------------------\n";

            for (int i = 0; i < listem.Count; i++)
            {
                label1.Text += listem[i].ToString() + "\n";
            }

            label1.Text += "----------foreach ile----------\n";

            foreach (object nesne in listem)
                label1.Text += nesne.ToString() + "\n";
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            //komnobox ın seçimi değişti olayı
            int indis;
            object SecilenOge;
            //seçilen öğenin indeksi
            indis = comboBox1.SelectedIndex;
            //seçilen öğe
            SecilenOge = comboBox1.SelectedItem;
            //SecilenOge = comboBox1.Items[indis];

            SecilenOge = comboBox1.Items[indis];
            label1.Text = "Secilen öge:" + SecilenOge.ToString() + " combobox'ın" + indis.ToString() + ". öğesi";

            //Seçilen öğeyi bulma
            this.Text = comboBox1.Text;
        }

        private void textBox1_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string oge = textBox1.Text;
                comboBox1.Items.Remove(oge);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            int indis = int.Parse(textBox1.Text);
            comboBox1.Items.RemoveAt(indis);

        }

        private void button4_Click(object sender, EventArgs e)
        {
            string oge = textBox1.Text;
            if (comboBox1.Items.Contains(oge))
                MessageBox.Show(oge + " var.");
            else 
                MessageBox.Show(oge + " yok.");
        }

        private void button5_Click(object sender, EventArgs e)
        {
            string oge = textBox1.Text;
            int indis = comboBox1.Items.IndexOf(oge);
            if (indis > -1)
                label1.Text = oge + " var, " + indis.ToString() + ". öğe.";
            else label1.Text = oge + " yok!";                                   
        }

        private void button6_Click(object sender, EventArgs e)
        {
            string mesaj = "";
            int bas, son;
            bas = 0;
            son = comboBox1.Items.Count;
            for (int i = bas; i < son; i++)
            {
                mesaj += i.ToString()+") "+comboBox1.Items[i].ToString()
                    +Environment.NewLine;
            }
            label1.Text = mesaj;
        }
    }
}
