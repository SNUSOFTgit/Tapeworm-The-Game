using System.Threading.Tasks;
using UnityEngine;
using UnityEngine.SceneManagement;

public class loadScene : MonoBehaviour
{
    public async void LoadScene(string sceneName)
    {
        await Task.Delay(300);
        SceneManager.LoadScene(sceneName);
    }

    public async void Exit()
    {
        await Task.Delay(700);
        //Zamyka zbuildowaną grę
        Application.Quit();

        //Jeśli w edytorze Unity zamyka się też
        #if UNITY_EDITOR
            UnityEditor.EditorApplication.isPlaying = false;
        #endif
    }
}
