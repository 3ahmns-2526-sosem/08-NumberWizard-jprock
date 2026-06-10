using UnityEngine;
using TMPro;

public class NumberWizard : MonoBehaviour
{
    public int min = 1;
    public int max = 100;
    private int guess;

    public TextMeshProUGUI guessText;

    void Start()
    {
        StartGame();
    }

    void StartGame()
    {
        guess = (min + max) / 2;
        guessText.text = guess.ToString();
    }
    
    public void OnHigherButton()
    {
    min = guess + 1;
    guess = (min + max) / 2;
    guessText.text = guess.ToString();
    }
}
