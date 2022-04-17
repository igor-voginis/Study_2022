namespace CCC_repair
{
    public partial class Form1 : Form
    {

        public Form1()
        {
            InitializeComponent();

                     

           }

        private void btnSum_Click(object sender, EventArgs e)
        {
            
            try
            {
                Convert.ToDouble(tb5cm.Text);
                Convert.ToDouble(tb7cm.Text);
                Convert.ToDouble(tb9cm.Text);
                Convert.ToDouble(tb12cm.Text);
                Convert.ToDouble(tb3cm.Text);
            }
            catch 
            {

               MessageBox.Show("¬ведено не число");
                return;
            }

            double n5 = Convert.ToDouble(tb5cm.Text);
            tb5cmResult.Text = (n5 * 11.98/100).ToString();
            n5 = Convert.ToDouble(tb5cmResult.Text);

            double n7 = Convert.ToDouble(tb7cm.Text);
            tb7cmResult.Text = (n7 * 16.6 / 100).ToString();
            n7 = Convert.ToDouble(tb7cmResult.Text);

            double n9 = Convert.ToDouble(tb9cm.Text);
            tb9cmResult.Text = (n9 * 21.66 / 100).ToString();
            n9 = Convert.ToDouble(tb9cmResult.Text);

            double n12 = Convert.ToDouble(tb12cm.Text);
            tb12cmResult.Text = (n12 * 28.92 / 100).ToString();
            n12 = Convert.ToDouble(tb12cmResult.Text);
            
            double n3 = Convert.ToDouble(tb3cm.Text);
           
            switch (cb3cm.Text)
            {
                case "3.0 см":
                    tb3cmResult.Text = (n3 * 7.14 / 100).ToString();
                    n3 = Convert.ToDouble(tb3cmResult.Text);
                    break;
                case "3.5 см":
                    tb3cmResult.Text = (n3 * 8.35 / 100).ToString();
                    n3 = Convert.ToDouble(tb3cmResult.Text);
                    break;
                case "4.0 см":
                    tb3cmResult.Text = (n3 * 9.56 / 100).ToString();
                    n3 = Convert.ToDouble(tb3cmResult.Text);
                    break;
                case "4.5 см":
                    tb3cmResult.Text = (n3 * 10.77 / 100).ToString();
                    n3 = Convert.ToDouble(tb3cmResult.Text);
                    break;
                case "6.0 см":
                    tb3cmResult.Text = (n3 * 14.4 / 100).ToString();
                    n3 = Convert.ToDouble(tb3cmResult.Text);
                    break;
            }
                        

            double result = n5 + n7 + n9 + n12+ n3;
            tbAllResult.Text = result.ToString();
        }

    }
}