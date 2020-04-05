using UnityEngine;
using UnityEngine.SceneManagement;

public class Splash : MonoBehaviour
{

    void Awake()
    {
        DontDestroyOnLoad(gameObject);
    }
    // Start is called before the first frame update
    void Start()
    {
        Invoke("LoadNextLevel", 2f);
    }

    // Update is called once per frame
    void Update()
    {

    }

    void LoadNextLevel()
    {
        SceneManager.LoadScene(1);
    }
}

