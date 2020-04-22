using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SelfDestructor : MonoBehaviour
{
    [SerializeField] float selfDFestructTimer = 5f;
    // Start is called before the first frame update
    void Start()
    {
        Destroy(gameObject, selfDFestructTimer); // todo allow customistion
    }
}
