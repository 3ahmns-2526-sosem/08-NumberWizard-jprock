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
    public GameObject restartButton;
    public TextMeshProUGUI guessText;

    private void Start()
    {
        StartGame();
    }

    private void StartGame()
    {
        guess = (min + max) / 2;
        guessText.text = guess.ToString();
    }
    
   public void OnHigherButton()
{
    // gesuchte Zahl ist höher → untere Grenze hochsetzen
    min = guess + 1;
    // neuer Guess in der Mitte des verbleibenden Bereichs
    guess = (min + max) / 2;
    guessText.text = guess.ToString();
}

public void OnLowerButton()
{
    // gesuchte Zahl ist niedriger → obere Grenze runtersetzen
    max = guess - 1;
    // neuer Guess in der Mitte des verbleibenden Bereichs
    guess = (min + max) / 2;
    guessText.text = guess.ToString();
}

    public void OnCorrectButton()
    {
    winText.gameObject.SetActive(true);
    higherButton.SetActive(false);
    lowerButton.SetActive(false);
    correctButton.SetActive(false);
    restartButton.SetActive(true);
    }

    public void OnRestartButton()
    {
    min = 1;
    max = 100;
    winText.gameObject.SetActive(false);
    higherButton.SetActive(true);
    lowerButton.SetActive(true);
    correctButton.SetActive(true);
    restartButton.SetActive(false);
    guess = (min + max) / 2;
    guessText.text = guess.ToString();
    }
}
