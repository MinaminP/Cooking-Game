using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CookDough : MonoBehaviour
{
    public float cookingTime = 0;
    public float doneCookingTime;
    public float overCookedTime;

    GameObject board1Pin, board2Pin;
    GameObject stove1Pin, stove2Pin;

    Vector2 board1Location, board2Location;
    Vector2 stove1Location, stove2Location;

    // Start is called before the first frame update
    void Start()
    {
        board1Pin = GameObject.FindGameObjectWithTag("Board1");
        board2Pin = GameObject.FindGameObjectWithTag("Board2");

        stove1Pin = GameObject.FindGameObjectWithTag("Stove1");
        stove2Pin = GameObject.FindGameObjectWithTag("Stove2");

        board1Location = board1Pin.transform.position;
        board2Location = board2Pin.transform.position;

        stove1Location = stove1Pin.transform.position;
        stove2Location = stove2Pin.transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        if(transform.position.x > board2Location.x + 2)
        {
            cookingTime += Time.deltaTime;

            if (cookingTime > doneCookingTime && cookingTime < overCookedTime)
            {
                GetComponent<SpriteRenderer>().color = new Color32(199, 200, 24, 255);
            }
            if (cookingTime > overCookedTime)
            {
                GetComponent<SpriteRenderer>().color = new Color32(79, 59, 5, 255);
            }
        }
    }

    void OnMouseDown()
    {
        if(cookingTime >= doneCookingTime && cookingTime < overCookedTime)
        {
            if (transform.position.x == stove1Location.x)
            {
                GameManager.isStove1Empty = true;
                Debug.Log("Stove 1 empty");
            }
            else if (transform.position.x == stove2Location.x)
            {
                GameManager.isStove2Empty = true;
                Debug.Log("Stove 2 empty");
            }

            if (GameManager.isBoard1Empty == true)
            {
                GetComponent<Transform>().position = new Vector2(board1Location.x, board1Location.y);
                this.gameObject.transform.SetParent(board1Pin.transform);
                GameManager.isBoard1Empty = false;
            } else if (GameManager.isBoard2Empty == true)
            {
                GetComponent<Transform>().position = new Vector2(board2Location.x, board2Location.y);
                this.gameObject.transform.SetParent(board2Pin.transform);
                GameManager.isBoard2Empty = false;
            }
        }
        
        if(cookingTime > overCookedTime)
        {
            if (transform.position.x == stove1Location.x)
            {
                Debug.Log("Thrown away from stove1");
                Destroy(this.gameObject);
                GameManager.isStove1Empty = true;
            }
            else if (transform.position.x == stove2Location.x)
            {
                Debug.Log("Thrown away from stove2");
                Destroy(this.gameObject);
                GameManager.isStove2Empty = true;
            }
        }
    }
}
