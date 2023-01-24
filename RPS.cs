using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RPS : MonoBehaviour
{
    //mach var
    [Header("Mech Var")]
    public string player_input;
    public string cpu_input;
    private string[] selection = { "Rock", "Paper", "Scissor" };

    //Points
    [Header("Points")]
    public int player_point;
    public int cpu_point;

    //Change
    public int no_of_chance;
    public int chance;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

    }

    public void GameFunction()
    {

        cpu_input = selection[Random.Range(0, selection.Length)];
        
        if (player_input == cpu_input)
        {
            print("Match die");
        }
        //player Input Rock
        else if (player_input=="Rock" && cpu_input=="Paper")
        {
            print("Computer Get Point");
            cpu_point++;
            no_of_chance++;
        }
        else if (player_input == "Rock" && cpu_input == "Scissor")
        {
            print("Player Get Point");
            player_point++;
            no_of_chance++;
        }
        //Player Input Paper
        else if (player_input=="Paper" && cpu_input=="Rock")
        {
            print("Player Get Point");
            player_point++;
            no_of_chance++;
        }
        else if (player_input == "Paper" && cpu_input == "Scissor")
        {
            print("Computer Get Point");
            cpu_point++;
            no_of_chance++;
        }
        //Player Input Scissor
        else if (player_input=="Scissor" && cpu_input=="Paper")
        {
            print("Player Get Point");
            player_point++;
            no_of_chance++;
        }
        else if (player_input=="Scissor" && cpu_input=="Rock")
        {
            print("Computer Get Point");
            cpu_point++;
            no_of_chance++;
        }

        
        //Match Resoult
        if (no_of_chance==chance)
        {
            print("Game Over");

            if (player_point<cpu_point)
            {
                print("Computer Won The Game");
            }
            else if (player_point>cpu_point)
            {
                print("Player Won The Game");
            }
            else
            {
                print("Match Die");
            }
        }
    }

    public void SelecdRock()
    {
        player_input = "Rock";
        GameFunction();
    }

    public void SelectPaper()
    {
        player_input = "Paper";
        GameFunction();
    }

    public void SelectCisser()
    {
        player_input = "Scissor";
        GameFunction();
    }
}
