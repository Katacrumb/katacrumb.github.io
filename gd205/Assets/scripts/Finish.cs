using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Finish : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.name == "player")
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex +1 );
        }
    }
}

// when choosing an index add + 1 to the end of a scene to go forward in it. 