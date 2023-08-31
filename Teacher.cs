

//Teacher
//Each teacher has name, birthdate, national_id, salary, gender, home_town
//Teachers are assigned to classes
//Each Teacher is specialized with 1 or more courses
using static System.Console;
using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel.Design;
using System.Net.NetworkInformation;
using System.Security.Cryptography.X509Certificates;

class Teacher
{
    private int SelectedIndex;
    private string[] Options;
    private string Prompt;
    public Teacher(string prompt, string [] options) {
        Prompt = prompt;
        Options = options;
        SelectedIndex =0;
    }
    
    private void DisplayOptions(){
        WriteLine(Prompt);
        for (int i = 0; i < Options.Length;i++)
        {
            string currentOption =Options[i];  
            string Checkpoint;
            if(i==SelectedIndex){
             Checkpoint="*";
            } 
            else{
             Checkpoint=" ";
            }
            WriteLine($"{Checkpoint}<<{currentOption}>>");
        }
    }
 public static void Main(string[] args)
    {

    
    string Prompt="Welcome!\nSelect what you want!\n ---------------------------";

 string[] Options = { "Show my profile information", "Show my assigned classes ","Exit"};
Teacher mainMenu = new Teacher(Prompt, Options);
int SelectedIndex=mainMenu.SchoolTeach();//to get to each choice
/*switch(SelectedIndex){
    case 0:
         Profileinfo();
        break;
        case 1:
        Showassigned();
          break;
            case 2:
                Exitprogram();
                break;
           default:
           break;

} */


}


 int SchoolTeach(){
    ConsoleKey KeyPressed;
    do{
        Clear();
        DisplayOptions();


    ConsoleKeyInfo keyInfo =ReadKey(true);
    KeyPressed=keyInfo.Key;
    if(KeyPressed==ConsoleKey.UpArrow){
        SelectedIndex--;
    }
    else if(KeyPressed==ConsoleKey.DownArrow){
        SelectedIndex++;    
    }

    } while (KeyPressed !=ConsoleKey.Enter);
    return SelectedIndex;
    

}
//the choices

private void Profileinfo()
{
Clear();
WriteLine("Here is your school information!");

}
private void Showassigned()
{
WriteLine("Here is the assigned classes to you!");

}
private void Exitprogram()
{
    //ReadKey(true);
//Environment.Exit(0);

}


}

