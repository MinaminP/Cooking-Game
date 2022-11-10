using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AddDough : MonoBehaviour
{
    public GameObject martabak;
    public Transform stove1Location, stove2Location;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnMouseDown()
    {
        if(GameManager.isStove1Empty == true)
        {
            Instantiate(martabak, new Vector2(stove1Location.position.x, stove1Location.position.y), transform.rotation);
            GameManager.isStove1Empty = false;
        } else if (GameManager.isStove2Empty == true)
        {
            Instantiate(martabak, new Vector2(stove2Location.position.x, stove2Location.position.y), transform.rotation);
            GameManager.isStove2Empty = false;
        }
    }
}