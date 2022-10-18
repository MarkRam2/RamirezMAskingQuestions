//  mark ramirez
//  10/18/2022
//  Questions project
// it askes your name and what time you woke up

int idk = 0;
bool validation = true;
bool playing = true;

while(playing == true)
{

Console.Clear();

Console.WriteLine("Hello user what is your name");

string Name = Console.ReadLine();


string Hour = "";

Console.WriteLine($"thank you {Name}");
validation = true;
while(validation == true){
Console.WriteLine("what hour did you wake up");

Hour = Console.ReadLine();
    bool NuM1 = Int32.TryParse(Hour, out idk);
    if(NuM1 == true ){
        validation = false;
    }else if(NuM1 == false){
    }
}

validation = true;
string minute = "";

while(validation == true){
Console.WriteLine("what minute did you wake up");

minute = Console.ReadLine();
    bool NuM1 = Int32.TryParse(minute, out idk);
    if(NuM1 == true ){
        validation = false;
    }else if(NuM1 == false){
    }
}

Console.WriteLine($"thank you {Name}");

Console.WriteLine($"{Name} you woke up at {Hour}:{minute}");


bool yessir = true;
Console.WriteLine($"want to play again");
string responce = Console.ReadLine();
while(yessir == true)
{
responce.ToLower();
if(responce == "yes" ){
yessir = false;
playing = true;
}else if(responce == "no" ){
yessir = false;
playing = false;
}else{
Console.WriteLine($"so like i need a yes or no not this \"{responce}\" ");
responce = Console.ReadLine();
}
}
}