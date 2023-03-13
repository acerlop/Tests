using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerPosition : MonoBehaviour
{
    public GameObject Player;
    public Transform positionRoom;
    public Transform positionKitchen;
    public Transform positionStreet;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void Room()
    {
        Player.transform.position = positionRoom.position;
    }

    public void Kitchen()
    {
        Player.transform.position = positionKitchen.position;
    }

    public void Street()
    {
        Player.transform.position = positionStreet.position;
    }
}
