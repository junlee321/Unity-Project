using UnityEngine;


public class MusicPlayer : MonoBehaviour
{

    void Awake()
    {
        int numMusicPlayers = FindObjectsOfType<MusicPlayer>().Length;
        print("Number of music players in this scene" + numMusicPlayers);

        if (numMusicPlayers > 1)
        {
            Destroy(gameObject);
        }
        else
        {
            DontDestroyOnLoad(gameObject);
        }
    }
}

