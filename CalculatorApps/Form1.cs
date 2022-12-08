namespace CalculatorApps
{
    public partial class Form1 : Form
    {
        double value = 0;
        string operation = "";
        bool opertion_pressed = false;
        public Form1()
               
        {
            InitializeComponent();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            
        }

        

        private void button_Click(object sender, EventArgs e)
        {
            if ((result.Text == "0") || (opertion_pressed))
                result.Clear();

            opertion_pressed = false;
            Button button = (Button)sender;
            result.Text = result.Text + button.Text;
        } 

        private void button13_Click(object sender, EventArgs e)
        {
            result.Text = "0";
        }

        private void operator_click(object sender, EventArgs e)
        {

            Button button = (Button)sender;
            operation = button.Text;
            value = Double.Parse(result.Text);
            opertion_pressed = true;
            equation.Text = value + "" + operation;
        }

        private void button19_Click(object sender, EventArgs e)
        {
            equation.Text = "0";
            switch (operation)
            {
                case "+":
                      result.Text = (value + Double.Parse(result.Text)).ToString();
                    break;

                case "-":
                    result.Text = (value - Double.Parse(result.Text)).ToString();
                    break;

                case "*":
                    result.Text = (value * Double.Parse(result.Text)).ToString();
                    break;

                case "/":
                    result.Text = (value / Double.Parse(result.Text)).ToString();
                    break;

            }//end switch
            
        }

        private void button17_Click(object sender, EventArgs e)
        {
            result.Clear();
            value = 0;
        }

       
    }
}