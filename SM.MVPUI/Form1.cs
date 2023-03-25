using SM.UI.Contracts;

namespace SM.MVPUI;

public partial class Form1 : Form, IForm1
{
    
    public Form1()
    {
        InitializeComponent();
    }

    public event EventHandler Add;
    public event EventHandler Divide;

    public int FirstNumber { get => Convert.ToInt32(FirstNumberTextBox.Text); set => FirstNumberTextBox.Text = value.ToString(); }
    public int SecondNumber { get => Convert.ToInt32(SecondNumberTextBox.Text); set => SecondNumberTextBox.Text = value.ToString(); }
    public int Result { get => throw new NotImplementedException(); set => ResultTextBox.Text = value.ToString(); }


    private void AddButton_Click(object sender, EventArgs e)
    {
        Add?.Invoke(sender,e);
    }

    private void DivideButton_Click(object sender, EventArgs e)
    {
        Divide?.Invoke(sender,e);
    }
}