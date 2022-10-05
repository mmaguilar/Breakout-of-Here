using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SnowManBrick : MonoBehaviour
{
    private GameManager gm;

    //How many point sis this brick worth?
    public int points;

    private void Start(){
        gm = FindObjectOfType<GameManager>();
    }

    public void OnCollisionEnter2D(Collision2D collision){
        //add points here
        gm.AddPoints(1);
        Destroy(gameObject);
    }
}
