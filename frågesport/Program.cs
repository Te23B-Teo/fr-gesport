Console.BackgroundColor = ConsoleColor.Magenta;
Console.ForegroundColor = ConsoleColor.Green;
Console.Clear();

string Start;
string fråga1;
string fråga2;
string fråga3;
string fråga4;
string resultat;
int Svar = 0;
int ickecorrectasvar = 0;

quiz();
Start = Console.ReadLine().ToLower();
Console.Clear();
if (Start == "ja"){
   Console.WriteLine($" Du har {Svar} poäng");
   Console.WriteLine("Fråga 1, vad är dom första decimalerna i pi?"); // C: 3.14159265358
   Console.WriteLine("A: 3.14159265247    B: 3.15249265297");
   Console.WriteLine("C: 3.14159265358    D: 3.15148265358");
   Console.WriteLine("");
   camp();
   fråga1 = Console.ReadLine().ToLower();
   Console.Clear();

if (fråga1 == "c")
{
   Console.WriteLine("Grattis rätt svar");
   Svar++;
   Console.WriteLine($" Du har {Svar} poäng");
}
else if (fråga1 == "b" ||fråga1 == "a" ||fråga1 == "d"){
   Console.WriteLine("Womp Womp fel svar");
   Svar--;
   Console.WriteLine($"Du har {Svar} poäng fel");
}
else{
   Console.WriteLine("du får inget poäng");
   ickecorrectasvar++;
}



Console.WriteLine("Fråga 2, vad betyder ordet firabel?"); // A: det betyder arbete man gör utöver ens huvudjobb
Console.WriteLine("A: det betyder arbete man gör utöver ens huvudjobb   B: det är ett annat ord för att spränga i berg ");
Console.WriteLine("C: det är när någon som fyller 65 firar sig          D: det är ett annat ord för ett material blandning när man blandar");
Console.WriteLine("                                                        plast och gummi");
Console.WriteLine("");
camp();
fråga2 = Console.ReadLine().ToLower();
Console.Clear();

if (fråga2.ToLower() == "a")
{
   Svar++;
   Console.WriteLine($"rätt svar, Du har {Svar} poäng");
      Console.WriteLine("");
}
else if (fråga2 == "b" || fråga2 == "c" || fråga2 == "d"){
 Svar--;
   Console.WriteLine($"Fel svar, Du har {Svar} poäng");
   Console.WriteLine("");
}
else{
   Console.WriteLine("du får inget poäng");
   ickecorrectasvar++;
}

Console.WriteLine("Fråga 3, Vad innebär det att något är fermenterad?"); // D:att något har blivit gäst och mögligt
Console.WriteLine("A: att något blivit torkat                  B: att något har blivit lagrat i salt");
Console.WriteLine("C: att något har blivit stekt på låg värme  D: att något har blivit gäst och mögligt");
Console.WriteLine("");
camp();
fråga3 = Console.ReadLine().ToLower();
Console.Clear();
if(fråga3.ToLower() == "d"){
   Console.WriteLine($"rätt svar, Du har {Svar} poäng");
   Svar++;
   Console.WriteLine("");
}
else if (fråga3 == "b" || fråga3 == "c" || fråga3 == "a"){
   Console.WriteLine($"Fel svar, Du har {Svar} poäng");
   Svar--;
   Console.WriteLine("");
}
else{
   Console.WriteLine("du får inget poäng");
   ickecorrectasvar++;
}




Console.WriteLine(" fråga 4, vilket år blev uganda självständigt?"); //D:1962
Console.WriteLine("A:1944  B: 1988");
Console.WriteLine("C:1897  D:1962");
Console.WriteLine("");
camp();
fråga4 = Console.ReadLine().ToLower();
Console.Clear();
if(fråga4 == "d"){
   Console.WriteLine("rätt svar");
   Svar++;
   Console.WriteLine("");
}
else if (fråga4 == "b" || fråga4 == "c" || fråga4 == "d"){
   Console.WriteLine("Fel svar.");
   Svar--;
   Console.WriteLine("");
}
else{
   Console.WriteLine("du får inget poäng");
   ickecorrectasvar++;
}
Console.WriteLine(" Redo för resultat?");
resultat = Console.ReadLine().ToLower();
Console.Clear();

if( resultat == "ja"){
   Console.WriteLine($"Du fick {Svar} poäng");
   if( Svar == 4){
      Console.WriteLine("bra jobbat alla rätt");
   }
   if( Svar == -4){
      Console.WriteLine("Alla fel ajdå");
   }
   Console.WriteLine($"du fick {ickecorrectasvar} fel skrivna poäng");
sailboat();
   }
else if (resultat == "nej"){
 Console.WriteLine("rädd för att se dina svar");
}
Console.ReadLine();
}



static void sailboat()
{
   Console.WriteLine("""
        ~~~          |
         ~~~~      -----                    |
     ~~~           )___(                  -----
                     |                    )___(
                 ---------                  |
                /         \              -------
               /___________\            /       \
                     |                 /_________\
              ---------------               |
             /               \        -------------
            /                 \      /             \
           /___________________\    /_______________\
         ____________|______________________|__________
          \_                                        _/
            \______________________________________/
     ~~..             ...~~~.           ....~~~...     ..~
   
   """);
}
static void camp()
{
   Console.WriteLine("""
           (                 ,&&&.
            )                .,.&&
           (  (              \=__/
               )             ,'-'.
         (    (  ,,      _.__|/ /|
          ) /\ -((------((_|___/ |
        (  // | (`'      ((  `'--|
      _ -.;_/ \\--._      \\ \-._/.
     (_;-// | \ \-'.\    <_,\_\`--'|
     ( `.__ _  ___,')      <_,-'__,'
      `'(_ )_)(_)_)'
   """);
}
static void quiz()
{
   Console.WriteLine("""
                                                                                                                      _
     \    / _  |  _  _  ._ _   _    _|_  _    _|_ |_   _     _.     o _       _. ._ _        _        ._ _   _.  _|     ) 
      \/\/ (/_ | (_ (_) | | | (/_    |_ (_)    |_ | | (/_   (_| |_| | /_ o   (_| | (/_   \/ (_) |_|   | (/_ (_| (_| \/ o  
                                                              |                          /                          /     
   """);
}