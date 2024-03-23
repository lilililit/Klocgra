using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class cowsandbulls : MonoBehaviour
{
    public TextMeshProUGUI textSecretWord;
    public TextMeshProUGUI textSecretWordLength;
    public TextMeshProUGUI textLivesCount;
    public string secretWord = "hello";
    public int playerLives = 3;

    public void RemoveLife()
    {
        playerLives--;
        textLivesCount.text = "You have " + playerLives + "Lives left";
        if (playerLives <= 0) 
        {
            textSecretWord.text = "the word was :" + secretWord;
            textSecretWordLength.text = " Game  over";
            textLivesCount.text = "You have no lives left";
        }
    }
    public int CountBulls(string origin, string guess)
    {
        int bullsCount = 0;
        for (int i = 0;i < origin.Length; i++) 
        {
            if (origin[i] == guess[i])
            {
                bullsCount++;
            }
        }
        return bullsCount;
    }
    public int CountCows(string origin, string guess)
    {
        int cowsCount = 0;
        for (int i = 0; i < origin.Length; i++)
        {
            if (origin.Contains(guess[i] + "") && origin[i] != guess[i])
            {
                cowsCount++;
            }
        }
        return cowsCount;
    }

    // Start is called before the first frame update
    void Start()
    {
        
        textSecretWord.text ="The secret word is [" + secretWord +"]";
        textSecretWordLength.text="The length of the secret word is " + secretWord.Length;
        textLivesCount.text = "You have "+ playerLives + "lives left";


    }

    // Update is called once per frame
    void Update()
    {

    }
    public void OnButtonClick(TMP_InputField input)
    {
        if(playerLives <= 0) 
        {
            return;
        }
        if (input.text == secretWord) 
        {
         Win();
         return;

        }
        
        if (secretWord.Length != input.text.Length) 
        {
            RemoveLife();
            Debug.Log("Wrong length, try again");
            textSecretWord.text = "wrong length ! Try again and press Submit!";
        }
        else 
        {
            RemoveLife();
        int bulls =CountBulls(secretWord, input.text);
        int cows = CountCows(secretWord, input.text);

            textSecretWord.text = "bulls :" + bulls +" " + "Cows :" + cows + " " + "Try again and press enter";
        }
        input.text = "";
    }

    public void Win() 
    {
        textSecretWord.text = "The word was :" + secretWord;
        textSecretWordLength.text = "Congratulations!!";
        textLivesCount.text = "You have " + playerLives + "Lives left";
    }
}
