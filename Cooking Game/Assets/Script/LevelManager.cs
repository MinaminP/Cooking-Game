using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;
using UnityEngine.UI;

public class LevelManager : MonoBehaviour
{
    public TextMeshProUGUI level1ButtonText, level2ButtonText;
    public Button level1Button, level2Button;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(LevelData.level1 == 3)
        {
            level1Button.interactable = false;
        }

        if(LevelData.level2 == 3)
        {
            level2Button.interactable = false;
        }

        if(LevelData.level1 == 1)
        {
            level2Button.interactable = true;
        }
    }

    public void Level1ButtonPressed()
    {
        LevelData.level1++;
        Debug.Log("Level 1-" + LevelData.level1.ToString() + "Ready");
        level1ButtonText.text = "1-" + LevelData.level1.ToString();
        if (LevelData.level1 == 1)
        {
            MoveToLevel();
        }
    }

    public void Level2ButtonPressed()
    {
        LevelData.level2++;
        Debug.Log("Level 2-" + LevelData.level2.ToString() + "Ready");
        level2ButtonText.text = "2-" + LevelData.level2.ToString();
        if (LevelData.level2 == 1)
        {
            MoveToLevel();
        }
    }

    public void MoveToLevel()
    {
        SceneManager.LoadScene("Scene2");
    }
}
