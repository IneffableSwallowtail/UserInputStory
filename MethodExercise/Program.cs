// See https://aka.ms/new-console-template for more information
Console.WriteLine("Enter a first name");
string? firstName = Console.ReadLine();
    firstName ??= "[redacted]";

string nominative;
string possessive;
Console.WriteLine($"Enter {firstName}'s pronouns (he, she, or they)");
string? pronoun = Console.ReadLine();
if (pronoun == "he")
{
    nominative = "He";
    possessive = "his";
}
else if (pronoun == "she")
{
    nominative = "She";
    possessive = "her";
}
else if (pronoun == "they")
{
    nominative = "They";
    possessive = "their";
}
else
{
    nominative = "[redacted]";
    possessive = "[redacted]";
}

Console.WriteLine("Enter an adjective");
string? adjective1 = Console.ReadLine();
adjective1 ??= "[redacted]";
string a_n1;
if (adjective1[0] == 'a' || adjective1[0] == 'e' || adjective1[0] == 'i' || adjective1[0] == 'o' || adjective1[0] == 'u')
    a_n1 = "an";
else
    a_n1 = "a";

Console.WriteLine("Enter a place");
string? place = Console.ReadLine();
place ??= "[redacted]";

Console.WriteLine("Enter a profession (noun that typefies a person");
string? profession = Console.ReadLine();
profession ??= "[redacted]";

Console.WriteLine("Enter three nouns");
string? noun1 = Console.ReadLine();
noun1 ??= "[redacted]";
string a_n2;
if (adjective1[0] == 'a' || adjective1[0] == 'e' || adjective1[0] == 'i' || adjective1[0] == 'o' || adjective1[0] == 'u')
    a_n2 = "an";
else
    a_n2 = "a";

string? noun2 = Console.ReadLine();
noun2 ??= "[redacted]";
string a_n3;
if (adjective1[0] == 'a' || adjective1[0] == 'e' || adjective1[0] == 'i' || adjective1[0] == 'o' || adjective1[0] == 'u')
    a_n3 = "an";
else
    a_n3 = "a";

string? noun3 = Console.ReadLine();
noun3 ??= "[redacted]";

Console.WriteLine("Enter another adjective");
string? adjective2 = Console.ReadLine();
adjective2 ??= "[redacted]";
string a_n4;
if (adjective1[0] == 'a' || adjective1[0] == 'e' || adjective1[0] == 'i' || adjective1[0] == 'o' || adjective1[0] == 'u')
    a_n4 = "an";
else
    a_n4 = "a";

Console.WriteLine($"{firstName} was {a_n1} {adjective1} {profession}. {nominative} went to the {place} to practice {possessive} skills. " +
    $"{nominative} used {a_n2} {noun1}, {a_n3} {noun2}, and {a_n4} {adjective2} {noun3} to accomplish this.");
Console.ReadLine();