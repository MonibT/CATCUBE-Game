
using UnityEngine;
using UnityEngine.SceneManagement;

public class Menu : MonoBehaviour
{

    public void Endless()
    {
        SceneManager.LoadScene(1);
    }


    public void Levels()
    {
        SceneManager.LoadScene(2);
    }

}
