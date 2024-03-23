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
        Debug.Log("Input was : " + input.text);
    }
}
