using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneManager : MonoBehaviour
{

    private void OnTriggerEnter2D(Collider2D collision)
    {

        Application.LoadLevel("Castle");
        Debug.Log("ss");
    }


}
