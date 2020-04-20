using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class BEGINGAME : MonoBehaviour
{
    public void beginTheGame()
    {
        SceneManager.LoadScene("Game");
    }
}
