using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    [SerializeField] private TMP_Text scoreText;
    public static GameManager Instance;
    void Awake()
    {
        Instance = this;
    }

    public void DemarrerJeu()
    {
        SceneManager.LoadScene("Jeu");
    }
    
    public void RetourMenu()
    {
        SceneManager.LoadScene("Menu");
    }

    public void QuitterJeu()
    {
        UnityEditor.EditorApplication.isPlaying = false;
        //Application.Quit();
    }

    private void MettreAJourUI()
    {
        scoreText.text = "Score: ";
    }
}