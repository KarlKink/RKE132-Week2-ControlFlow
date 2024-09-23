// See https://aka.ms/new-console-template for more information


//rakendus küsib kasutajalt sisetada tema vanuse
//kui kasutaja vanus on väiksem kui 13, siis konsoolis kuvatakse:
//"You are too young to use Instagram"
//muul juhul
//konsoolis kuvatakse "Welcome to Instagram!"

using System.ComponentModel.Design;
using System.Runtime.Intrinsics.X86;

Console.WriteLine(" Enter your age");

int userAge = Int32.Parse(Console.ReadLine());    // "13" - heap, - stack

if (userAge >= 13)
{
    Console.WriteLine("Welcome to Isntagram!");
} 
else  //if (userAge < 13)
{
    Console.WriteLine("You are too young to use Instagram.");
}

