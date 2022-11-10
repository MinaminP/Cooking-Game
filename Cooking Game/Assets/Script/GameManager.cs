using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    public static bool isStove1Empty = true, isStove2Empty = true;
    public static bool isBoard1Empty = true, isBoard2Empty = true;
    // Start is called before the first frame update
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void BackToLevelSelection()
    {
        SceneManager.LoadScene("Scene1");
    }
}
