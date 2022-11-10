using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AddTopping : MonoBehaviour
{
    public GameObject topping;
    public Transform board1Location, board2Location;

    public bool isBoard1ToppingAdded, isBoard2ToppingAdded;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    void OnMouseDown()
    {
        Debug.Log("Topping Clicked");
        if (GameManager.isBoard1Empty == false && isBoard1ToppingAdded == false)
        {
            var addedTopping1 = Instantiate(topping, new Vector2(board1Location.position.x, board1Location.position.y), transform.rotation);
            addedTopping1.transform.SetParent(board1Location);
            isBoard1ToppingAdded = true;
        }
        else if (GameManager.isBoard2Empty == false && isBoard2ToppingAdded == false)
        {
            var addedTopping2 = Instantiate(topping, new Vector2(board2Location.position.x, board2Location.position.y), transform.rotation);
            addedTopping2.transform.SetParent(board2Location);
            isBoard2ToppingAdded = true;
        }
    }

}
