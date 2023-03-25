namespace SM.UI.Contracts;

public interface IForm1
{
    public int FirstNumber { get; set; }
    public int SecondNumber { get; set; }
    public int Result { get; set; }

    public event EventHandler Add;
    public event EventHandler Divide;

}
