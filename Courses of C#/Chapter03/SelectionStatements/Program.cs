﻿#region Branching with the If Statement

/*string password = "ninja";

if (password.Length < 8)
{
    WriteLine("Your password is too short. Use at least 8 chars ");
}
else 
{
    WriteLine("Your password is strong.");
}
//Pattern matching with the If Statement

// Add and remove the "" to change between string and int.
int o = 3;
int j = 4;

if( o is int i) 
{
    WriteLine($"{i} * {j} = {i * j}");
}
else 
{
    WriteLine("o is not an int so it cannot multiply!");
}
*/

#endregion

#region Branching with Switch Statement
/*
// Inclusive Lower bound but exclusive upper bound.
int number = Random.Shared.Next(minValue: 1, maxValue: 7);
WriteLine($"My random number is {number}");

switch (number)
{
    case 1:
        WriteLine("One");
        break; // Jumps to end of switch statement.
    case 2:
        WriteLine("Two");
        goto case 1;
    case 3: // Multiple case section.
    case 4:
        WriteLine("Three or four");
        goto case 1;
    case 5:
        goto A_label;
    default:
        WriteLine("Default");
        break;
} // End of switch statement.
WriteLine("After end of switch");
A_label:
WriteLine($"After A_label");
*/
#endregion

#region Pattern matching with the Switch Statement

// Array of nullable Animal objects with different types and attributes.
var animals = new Animal?[]
{
 new Cat { Name = "Karen", Born = new(year: 2022, month: 8,
    day: 23), Legs = 4, IsDomestic = true },
 null,

 new Cat { Name = "Mufasa", Born = new(year: 1994, month: 6,
    day: 12) },

 new Spider { Name = "Sid Vicious", Born = DateTime.Today,
    IsPoisonous = true},

 new Spider { Name = "Captain Furry", Born = DateTime.Today }
};

// Display a message for each animal based on its type and attributes.
foreach (Animal? animal in animals)
{
    string message;

    switch (animal)
    {
        case Cat fourLeggedCat when fourLeggedCat.Legs == 4:
            message = $"The cat named {fourLeggedCat.Name} has four legs.";
            break;

        case Cat wildCat when wildCat.IsDomestic == false:
            message = $"The non-domestic cat is named {wildCat.Name}.";
            break;

        case Cat cat:
            message = $"The cat is named {cat.Name}.";
            break;
        default: // default is always evaluated Last.
            message = $"{animal.Name} is a {animal.GetType().Name}.";
            break;

        case Spider spider when spider.IsPoisonous:
            message = $"The {spider.Name} spider is poisonous. Run!";
            break;

        case null:
            message = "The animal is null.";
            break;
    }
    WriteLine($"switch statement: {message}");




#endregion

#region Simplifying Switch Statements with Switch Expressions

message = animal switch
{
    Cat fourLeggedCat when fourLeggedCat.Legs == 4
    => $"The cat named {fourLeggedCat.Name} has four legs.",
    Cat wildCat when wildCat.IsDomestic == false
    => $"The non-domestic cat is named {wildCat.Name}.",
    Cat cat
    => $"The cat is named {cat.Name}.",
    Spider spider when spider.IsPoisonous
    => $"The {spider.Name} spider is poisonous. Run!",
    null
    => "The animal is null.",
    _
    => $"{animal.Name} is a {animal.GetType().Name}."
};
WriteLine($"switch expression: {message}");
}

#endregion