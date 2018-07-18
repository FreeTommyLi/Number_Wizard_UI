using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class NumberWizard : MonoBehaviour {

    [SerializeField] int max;
    [SerializeField] int min;
    [SerializeField] TextMeshProUGUI guessText;
    int guess;

    // Use this for initialization
    void Start ()
    {

        StartGame();

	}
    

    void StartGame()
    {
        NextGuess();

    }

    // Update is called once per frame
    public void OnPressHighter()
    {
        max = guess - 1;
        NextGuess();


    }
    public void OnPressLower()
    {
        if (min < 1000)
        {
            min = guess + 1;
        }
        NextGuess();


    }

    public void NextGuess()
    {
        guess = Random.Range(min, max + 1);
        guessText.text = guess.ToString();
    }

    
}
