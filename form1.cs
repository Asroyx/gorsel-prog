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
            label1.Text = "Se.ilen öpe:" + SecilenOge.ToString() + " combobox'ın" + indis.ToString() + ". öğesi";
        }
    }
}
