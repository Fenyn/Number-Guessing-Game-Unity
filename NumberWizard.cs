using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using System.Collections;

public class NumberWizard : MonoBehaviour
{
    // Use this for initialization
    int max;
    int min;
    int guess;
    int guessAttempts = 10;

    public Text guessNumber;

    void Start()
    {
        StartGame();
    }

    void StartGame()
    {
        max = 1000;
        min = 1;
        guess = Random.Range(min, max+1);
        guessNumber.text = guess.ToString();

        max = max + 1;
    }

    // Update is called once per frame
    /*void Update () {
		if (Input.GetKeyDown(KeyCode.UpArrow)) {
			min = guess;
			NextGuess();
		} else if (Input.GetKeyDown(KeyCode.DownArrow)) {
			max = guess;
			NextGuess();
		} else if (Input.GetKeyDown(KeyCode.Return)) {
			print("I won!");
			StartGame();
		}
    }
	*/

    public void GuessHigher()
    {
        min = guess;
        NextGuess();
    }

    public void GuessLower()
    {
        max = guess;
        NextGuess();
    }

    void NextGuess()
    {
        guess = Random.Range(min, max);
        guessAttempts -= 1;
        if (guessAttempts <= 0)
        {
            SceneManager.LoadScene("Win");
        }
        guessNumber.text = guess.ToString();
    }
}