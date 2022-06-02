using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class camera : MonoBehaviour
{
    public GameObject Hero;
    // Update is called once per frame 
    void Update()
    {
        transform.position = new Vector3(Hero.transform.position.x, Hero.transform.position.y, -450f);
    }
}