using Moq;
using SM.MathContracts;
using SM.UI.Contracts;

namespace SM.Testing;

public class UITests
{

    [Fact]
    public void TestFirstNumber_ShouldReturnInteger()
    {
        var formMock = new Mock<IForm1>();

        formMock.SetupProperty(p => p.FirstNumber, 1);
        formMock.SetupProperty(p => p.SecondNumber, 2);

        IForm1 form1form = formMock.Object;

        Assert.Equal(1, form1form.FirstNumber);
        Assert.Equal(2,form1form.SecondNumber);

    }

    [Fact]
    public void TestEventAddRaised()
    {
        var formMock = new Mock<IForm1>();
        var mathMock = new Mock<IMathCode>();

        var presenter = new Form1Presenter(formMock.Object, mathMock.Object);


        formMock.Raise(m => m.Add += null, new EventArgs());
        mathMock.Verify(m=>m.Add(It.IsAny<int>(),It.IsAny<int>()),Times.Once());

    }
    [Fact]
    public void TestEventDivideRaised()
    {
        var formMock = new Mock<IForm1>();
        var mathMock = new Mock<IMathCode>();

        var presenter = new Form1Presenter(formMock.Object, mathMock.Object);


        formMock.Raise(m => m.Divide += null, new EventArgs());
        mathMock.Verify(m=>m.Divide(It.IsAny<int>(),It.IsAny<int>()),Times.Once());

    }

    
}
