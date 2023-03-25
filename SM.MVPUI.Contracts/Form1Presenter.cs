using SM.MathContracts;

namespace SM.UI.Contracts;

public class Form1Presenter
{
    readonly IForm1 form1;
    readonly IMathCode mathCode;
    public Form1Presenter(IForm1 form1, IMathCode mathCode)
    {
        this.form1 = form1;
        this.mathCode = mathCode;

        form1.Add += Form1_Add;
        form1.Divide += Form1_Divide;
    }

    private void Form1_Divide(object? sender, EventArgs e)
    {
        form1.Result = mathCode.Divide(form1.FirstNumber, form1.SecondNumber);
    }

    private void Form1_Add(object? sender, EventArgs e)
    {
        form1.Result = mathCode.Add(form1.FirstNumber, form1.SecondNumber);
    }
}
