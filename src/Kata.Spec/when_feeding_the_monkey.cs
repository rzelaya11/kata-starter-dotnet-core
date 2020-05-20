using System;
using FluentAssertions;
using Machine.Specifications;

namespace Kata.Spec
{
    public class when_feeding_the_monkey
    {
        static Monkey _systemUnderTest;
        
        Establish context = () => 
            _systemUnderTest = new Monkey();

        Because of = () => 
            _systemUnderTest.Eat("banana");

        It should_have_the_food_in_its_belly = () =>
            _systemUnderTest.Belly.Should().Contain("banana");
    }
}

public class when_sending_empty_string_as_parameter
{
    private static Calculator _systemUnderTest;
    private static object _result;
    
    Establish _context = () =>
    {
        _systemUnderTest = new Calculator();
    };

    Because of = () => { _result = _systemUnderTest.Sum(""); };

    It should_return_0 = () => { _result.Should().Be(0); };
    
}

public class when_sending_only_one_number
{
    private static object _result;
    private static Calculator _systemUnderTest;
    
    Establish _context = () =>
    {
        _systemUnderTest = new Calculator();
    };

    Because of = () => { _result = _systemUnderTest.Sum("1"); };

    It should_return_same_the_same_number = () => { _result.Should().Be(1); };
    
}

public class when_sending_two_numbers
{
    private static Calculator _systemUnderTest;
    private static object _result;

    private Establish _context = () => { _systemUnderTest = new Calculator(); };

    Because of = () => { _result = _systemUnderTest.Sum("1,2"); };

    It should_should_return_the_sume_of_both = () => { _result.Should().Be(3); };
    
}

public class when_Sending_Several_numbers
{
    Establish _context = () =>
    {
        _systemUnderTest = new Calculator();
    };

    Because of = () => { _result = _systemUnderTest.Sum("1,2,3"); };

    It should_Return_The_Sum_Of_ALL = () => { _result.Should().Be(6); };
    private static Calculator _systemUnderTest;
    private static object _result;
}

public class when_Using_two_delimiters
{
    Establish _context = () =>
    {
        _systemUnderTest = new Calculator();
    };

    Because of = () => { _result = _systemUnderTest.Sum("1\n2,3"); };

    It should_Return_the_sum_of_numbers = () => { _result.Should().Be(6); };
    private static Calculator _systemUnderTest;
    private static int _result;
}

public class when_Using_custom_delimiter
{
    Establish _context = () =>
    {
        _systemUnderTest = new Calculator();
    };

    Because of = () => { _result = _systemUnderTest.Sum("//;\n1;2"); };

    It should_Return_THe_Sum_of_All = () => { _result.Should().Be(3); };
    private static Calculator _systemUnderTest;
    private static int _result;
}

public class when_Sending_Negatives
{
    Establish _context = () =>
    {
        _systemUnderTest = new Calculator();
    };

    Because of = () =>
    {
        _result = Catch.Exception(() =>_systemUnderTest.Sum("1,2,-3"));
    };
    It should_Return_An_Exception = () => { _result.Message.Should().Be("Negatives are Not Allowed: -3"); };
    private static Calculator _systemUnderTest;
    private static Exception _result;
}

public class when_Sending_Several_Negatives
{
    Establish _context = () =>
    {
        _systemUnderTest = new Calculator();
    };

    private Because of = () => { _result = Catch.Exception(() => _systemUnderTest.Sum("-1,2,-3,-4")); };

    It should_thrown_an_Exception_showing_all_numbers = () => { _result.Message.Should().Be("Negatives are Not Allowed: -1,-3,-4"); };
    private static Calculator _systemUnderTest;
    private static Exception _result;
}

public class when_there_is_numbers_larger_than_1000
{
    Establish _context = () =>
    {
        _systemUnderTest = new Calculator();
    };

    Because of = () => { _result = _systemUnderTest.Sum("2,1001"); };

    It should_should_ignore_those = () => { _result.Should().Be(2); };
    private static Calculator _systemUnderTest;
    private static int _result;
}

public class when_having_custom_multiple_Character_delimiter
{
    Establish _context = () =>
    {
        _systemUnderTest = new Calculator();
    };

    Because of = () => { _result = _systemUnderTest.Sum("//[***]\n1***2***3"); };

    It should_Return_the_sum_of_all_numbers = () => { _result.Should().Be(6); };
    private static Calculator _systemUnderTest;
    private static int _result;
}

public class when_Sendind_multiple_multiline_delimiters
{
    Establish _context = () =>
    {
        _systemUnderTest = new Calculator();
    };

    Because of = () => { _result = _systemUnderTest.Sum("//[*][%]\n1*2%3"); };

    It should_Return_THe_sum = () => { _result.Should().Be(6); };
    private static Calculator _systemUnderTest;
    private static int _result;
}
// 10. Given the user input is multiple numbers with a custom multi-character delimiter when calculating the sum then it should return the sum of all the numbers. (example: “//[***]\n1***2***3” should return 6)
// 11. Given the user input is multiple numbers with multiple custom delimiters when calculating the sum then it should return the sum of all the numbers. (example “//[*][%]\n1*2%3” should return 6)