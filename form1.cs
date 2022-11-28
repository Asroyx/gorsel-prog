        private void Form1_Load(object sender, EventArgs e)
        {
            ArrayList listem = new ArrayList();
            listem.Add(35);
            listem.Add(3.14);
            listem.Add("C#");
            listem.Add("Java");
            listem.Add("JavaScript");
            label1.Text = "Eleman sayısı: "+listem.Count+" Kapasite: "+listem.Capacity+"\n";
            label1.Text = label1.Text + "---------------------------------------------\n";
            for (int i = 0; i < listem.Count; i++)
            {
                label1.Text += listem[i].ToString()+"\n";
            }
        }
