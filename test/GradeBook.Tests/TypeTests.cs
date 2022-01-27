using System;
using Xunit;

namespace GradeBook.Tests;

public delegate string WriteLogDelegate(string logMessage);

public class TypeTests
{

    int count = 0;

    [Fact]
    public void WriteLogDelegateCanPointToMethod()
    {
        WriteLogDelegate log = ReturnMessage;

        log += ReturnMessage;

        log += IncrementCount;

        var result = log("Hello!");

        Assert.Equal(3, count);
    }

    string IncrementCount(string message)
    {
        count += 1;
        return message.ToLower();
    }
    string ReturnMessage(string message)
    {
        count += 1;
        return message;
    }

    [Fact]
    public void StringsBehaveLikeValueTypes()
    {
        string name = "Luke";
        var upper = MakeUpperCase(name);

        Assert.Equal("Luke", name);
        Assert.Equal("LUKE", upper);          
    }

    private string MakeUpperCase(string parameter)
    {
        return parameter.ToUpper();
    }

    [Fact]
    public void ValueTypesAlsoPassByValue()
    {
        var x = GetInt();
        
        setInt(ref x);
        
        Assert.Equal(42, x);
    }

    private void setInt(ref int z)
    {
        z = 42;
    }

    private int GetInt()
    {
        return 3;
    }

    [Fact]
    public void CSharpCanPassByRef()
    {
        var book1 = GetBook("Book 1");
        GetBookSetName(out book1, "New Name");

        Assert.Equal("New Name", book1.Name);
        
    }

    private void GetBookSetName(out Book book, string name)
    {
        book = new Book(name);
    }

    [Fact]
    public void CSharpIsPassByValue()
    {
        var book1 = GetBook("Book 1");
        GetBookSetName(book1, "New Name");

        Assert.Equal("Book 1", book1.Name);
        
    }

    private void GetBookSetName(Book book, string name)
    {
        book = new Book(name);
    }


    [Fact]
    public void BookReturnsDifferentObjects()
    {
        var book1 = GetBook("Book 1");

        var book2 = GetBook("Book 2");

        Assert.Equal("Book 1", book1.Name);
        Assert.Equal("Book 2", book2.Name);
        
        
    }

    [Fact]
    public void TwoVarsCanReferenceSameObject()
    {
        var book1 = GetBook("Book 1");

        var book2 = book1;

        Assert.Same(book1, book2);
        Assert.True(object.ReferenceEquals(book1, book2));
        
    }

    Book GetBook(string name)
    {
        return new Book(name);
    }

    
    private void SetName(Book book, string name)
    {
        book.Name = name;
    }

}