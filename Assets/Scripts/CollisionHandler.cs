using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement; // ok as loon as this is the only script that loads scenes 

public class CollisionHandler : MonoBehaviour
{
    [SerializeField] float levelLoadDelay = 1f;

    void OnTriggerEnter(Collider other)
    {
        print("Player Trigger something");
        StartDeathSequence();
    }
    private void StartDeathSequence()
    {
        SendMessage("OnPlayerDeath");
    }
}
