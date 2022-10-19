using System.Security.Cryptography.Pkcs;

namespace Restaurant_Order_Management_POS
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Datebl.Text = DateTime.Now.ToLongTimeString();
            timer1.Start();
        }
        //Decleration of Price For Food Items
        Double Friesup = 10, Pizzaup = 20, Kebabup = 20, Ramenup = 5, Pieup = 25, Chickenup = 25, Sodaup = 1, Colaup = 3, Beerup = 5, Coffeeup = 1.50, Hotchocolateup = 6.12;
        //Decleration of Variable to hold total price for each drink and meal
        Double Friestp=10, Pizzatp=20, Kebabtp=20, Ramentp=5, Pietp=25, Chickentp=25, Sodatp=1, Colatp=3, Beertp=5, Coffeetp=1.20, Hotchocolatetp =6.20;
        Double Subtotal = 0;
       
        private void panel2_Paint(object sender, PaintEventArgs e)
        {
            Friestp = Friesup * Convert.ToDouble(FriesTB.Text);
            Pizzatp = Pizzaup * Convert.ToDouble(PizzaTB.Text);
            Kebabtp = Kebabup * Convert.ToDouble(KebabTB.Text);
            Ramentp = Ramenup * Convert.ToDouble(RamenTB.Text);
            Chickentp = Chickenup * Convert.ToDouble(ChickenTB.Text);
            Sodatp = Sodaup * Convert.ToDouble(SodaTB.Text);
            Colatp = Colaup * Convert.ToDouble(ColaTB.Text);
            Pietp = Pieup * Convert.ToDouble(PieTB.Text);
            Beertp = Beerup * Convert.ToDouble(BeerTB.Text);
            Hotchocolatetp = Hotchocolateup * Convert.ToDouble(HotchocolateTB.Text);
            Coffeetp = Coffeeup * Convert.ToDouble(CoffeeTB.Text);
            //Reciept
            RecieptTB.Clear();
            RecieptTB.AppendText(Environment.NewLine);
            RecieptTB.AppendText("\t\t\tWELLSTACKED.CO"+Environment.NewLine);
            RecieptTB.AppendText("\t\t\t**************************************"+Environment.NewLine);
            if (FriesCB.Checked == true) ;
            {
                RecieptTB.AppendText("\tFries:\t"+Friestp+"Eur€"+Environment.NewLine);
                Subtotal = Subtotal + Friestp;
                SubtotalTB.Text = "" + Subtotal;
            }
            if (PizzaCB.Checked == true) ;
            {
                RecieptTB.AppendText("\tPizza:\t" + Pizzatp + "Eur€" + Environment.NewLine);
                Subtotal = Subtotal + Pizzatp;
                SubtotalTB.Text = "" + Subtotal;
            }
            if (KebabCB.Checked == true) ;
            {
                RecieptTB.AppendText("\tKebab:\t" + Kebabtp + "Eur€" + Environment.NewLine);
                Subtotal = Subtotal + Kebabtp;
                SubtotalTB.Text = "" + Subtotal;
            }
            if (RamenCB.Checked == true) ;
            {
                RecieptTB.AppendText("\tRamen:\t" + Ramentp + "Eur€" + Environment.NewLine);
                Subtotal = Subtotal + Ramentp;
                SubtotalTB.Text = "" + Subtotal;
            }
            if (PieCB.Checked == true) ;
            {
                RecieptTB.AppendText("\tPie:\t" + Pietp + "Eur€" + Environment.NewLine);
                Subtotal = Subtotal + Pietp;
                SubtotalTB.Text = "" + Subtotal;
            }
            if (ChickenCB.Checked == true) ;
            {
                RecieptTB.AppendText("\tChicken:\t" + Chickentp + "Eur€" + Environment.NewLine);
                Subtotal = Subtotal + Chickentp;
                SubtotalTB.Text = "" + Subtotal;
            }
            if (SodaCB.Checked == true) ;
            {
                RecieptTB.AppendText("\tSoda:\t" + Sodatp + "Eur€" + Environment.NewLine);
                Subtotal = Subtotal + Sodatp;
                SubtotalTB.Text = "" + Subtotal;
            }
            if (ColaCB.Checked == true) ;
            {
                RecieptTB.AppendText("\tCola:\t" + Colatp + "Eur€" + Environment.NewLine);
                Subtotal = Subtotal + Colatp;
                SubtotalTB.Text = "" + Subtotal;
            }
            if (BeerCB.Checked == true) ;
            {
                RecieptTB.AppendText("\tBeer:\t" + Beertp + "Eur€" + Environment.NewLine);
                Subtotal = Subtotal + Beertp;
                SubtotalTB.Text = "" + Subtotal;
            }
            if (CoffeeCB.Checked == true) ;
            {
                RecieptTB.AppendText("\tCoffee:\t" + Coffeetp + "Eur€" + Environment.NewLine);
                Subtotal = Subtotal + Coffeetp;
                SubtotalTB.Text = "" + Subtotal;
            }
            if (HotchocolateCB.Checked == true) ;
            {
                RecieptTB.AppendText("\tHotchocolate:\t" + Hotchocolatetp + "Eur€" + Environment.NewLine);
                Subtotal = Subtotal + Hotchocolatetp;
                SubtotalTB.Text = "" + Subtotal;
            }
           





























        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (FriesCB.Checked == true) 
            {
                FriesTB.Enabled = true;
            }
            if (FriesCB.Checked == true) ;
            {
                FriesTB.Enabled = true;
                FriesTB.Text = "0";
            }
                

            
        }
       






        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void checkBox11_CheckedChanged(object sender, EventArgs e)
        {
            if (ChickenCB.Checked == true)
            {
                ChickenTB.Enabled = true;
            }
            if (ChickenCB.Checked == false) ;
            {
                ChickenTB.Enabled = true;
                ChickenTB.Text = "0";
            }
        }

        private void textBox8_TextChanged(object sender, EventArgs e)
        {

        }

        private void panel8_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

       

        private void timer1_Tick_1(object sender, EventArgs e)
        {
            Datebl.Text = DateTime.Now.ToLongTimeString();
        }

        private void Cola_CheckedChanged(object sender, EventArgs e)
        {
            if (ColaCB.Checked == true)
            {
                ColaTB.Enabled = true;
            }
            if (ColaCB.Checked == false) ;
            {
                ColaTB.Enabled = true;
                ColaTB.Text = "0";
            }
        }

        private void FriesCB_TextChanged(object sender, EventArgs e)
        {
            if (FriesCB.Checked == true)
            {
                FriesTB.Enabled = true;
            }
            if (FriesCB.Checked == false) ;
            {
                FriesTB.Enabled = true;
                FriesTB.Text = "0";
               
            }
        }

        private void ChickenCB_TextChanged(object sender, EventArgs e)
        {
            if (ChickenCB.Checked == true)
            {
                ChickenTB.Enabled = true;
            }
            if (ChickenCB.Checked == false) ;
            {
                ChickenTB.Enabled = true;
                ChickenTB.Text = "0";
            }
        }

        private void PizzaCB_CheckedChanged(object sender, EventArgs e)
        {
            if (PizzaCB.Checked == true)
            {
                PizzaTB.Enabled = true;
            }
            if (PizzaCB.Checked == false) ;
            {
                PizzaTB.Enabled = true;
                PizzaTB.Text = "0";
            }
        }

        private void PieTB_TextChanged(object sender, EventArgs e)
        {

        }

        private void RamenTB_TextChanged(object sender, EventArgs e)
        {

        }

        private void label13_Click(object sender, EventArgs e)
        {

        }

        private void label11_Click(object sender, EventArgs e)
        {

        }

        private void KebabCB_CheckedChanged(object sender, EventArgs e)
        {
            if (KebabCB.Checked == true)
            {
                KebabTB.Enabled = true;
            }
            if (KebabCB.Checked == false) ;
            {
                KebabTB.Enabled = true;
                KebabTB.Text = "0" ;
            }
        }

        private void RamenCB_CheckedChanged(object sender, EventArgs e)
        {
            if (RamenCB.Checked == true)
            {
                RamenTB.Enabled = true;
            }
            if (RamenCB.Checked == false) ;
            {
                RamenTB.Enabled = true;
                RamenTB.Text = "0";
            }
        }

        private void PieCB_CheckedChanged(object sender, EventArgs e)
        {
            if (PieCB.Checked == true)
            {
                PieTB.Enabled = true;
            }
            if (PieCB.Checked == false) ;
            {
                PieTB.Enabled = true;
                PieTB.Text = "0";
            }
        }

        private void SodaCB_CheckedChanged(object sender, EventArgs e)
        {
            if (SodaCB.Checked == true)
            {
                SodaTB.Enabled = true;
            }
            if (SodaCB.Checked == false) ;
            {
                SodaTB.Enabled = true;
                SodaTB.Text = "0";
            }
        }

        private void BeerCB_CheckedChanged(object sender, EventArgs e)
        {
            if (BeerCB.Checked == true)
            {
                BeerTB.Enabled = true;
            }
            if (BeerCB.Checked == false) ;
            {
                BeerTB.Enabled = true;
                BeerTB.Text = "0";
            }
        }

        private void CoffeeCB_CheckedChanged(object sender, EventArgs e)
        {
            if (CoffeeCB.Checked == true)
            {
                CoffeeTB.Enabled = true;
            }
            if (CoffeeCB.Checked == false) ;
            {
                CoffeeTB.Enabled = true;
                CoffeeTB.Text = "0";
            }
        }

        private void HotchocolateCB_CheckedChanged(object sender, EventArgs e)
        {
            if (HotchocolateCB.Checked == true)
            {
                HotchocolateTB.Enabled = true;
            }
            if (HotchocolateCB.Checked == false) ;
            {
                HotchocolateTB.Enabled = true;
                HotchocolateTB.Text = "0";
            }
        }

        private void CloseBT_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        
        private void PizzaTB_TextChanged(object sender, EventArgs e)
        {
            if (PizzaCB.Checked == true)
            {
                PizzaTB.Enabled = true;
            }
            if (PizzaCB.Checked == true) ;
            {
                PizzaTB.Enabled = true;
                PizzaTB.Text = "0";
            }
        }

        private void KebabTB_TextChanged(object sender, EventArgs e)
        {

        }

        private void label19_Click(object sender, EventArgs e)
        {

        }

        private void panel6_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label23_Click(object sender, EventArgs e)
        {

        }

        private void label22_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void label18_Click(object sender, EventArgs e)
        {

        }

        private void label21_Click(object sender, EventArgs e)
        {

        }

        private void label20_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {

        }
    }


}
        