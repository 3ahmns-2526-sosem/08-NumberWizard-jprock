using UnityEngine;
using TMPro;

public class NumberWizard : MonoBehaviour
{
    public int min = 1;
    public int max = 100;
    private int guess;
    public TextMeshProUGUI winText;
    public GameObject higherButton;
    public GameObject lowerButton;
    public GameObject correctButton;

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

    public void OnLowerButton()
    {
    max = guess - 1;
    guess = (min + max) / 2;
    guessText.text = guess.ToString();
    }

    public void OnCorrectButton()
    {
    winText.gameObject.SetActive(true);
    higherButton.SetActive(false);
    lowerButton.SetActive(false);
    correctButton.SetActive(false);
    }
}
