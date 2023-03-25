using SM.MathContracts;
using SM.MathImplementation;

namespace SM.UI
{
    public partial class Form1 : Form
    {
        private readonly IMathCode mathCode;

        public Form1()
        {
            InitializeComponent();
            mathCode = new MyMathLibrary();
        }

        


        private void AddButton_Click(object sender, EventArgs e)
        {
            int a, b;
            a = Convert.ToInt16(FirstNumberTextBox.Text);
            b = Convert.ToInt16(SecondNumberTextBox.Text);

            ResultTextBox.Text = mathCode.Add(a,b).ToString();

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void DivideButton_Click(object sender, EventArgs e)
        {
            int a, b;
            a = Convert.ToInt16(FirstNumberTextBox.Text);
            b = Convert.ToInt16(SecondNumberTextBox.Text);

            ResultTextBox.Text = mathCode.Divide(a, b).ToString();
        }
    }
}