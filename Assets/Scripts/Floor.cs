using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Floor : MonoBehaviour
{
   public GameManager gm;

    public void OnCollisionEnter2D(Collision2D collision){
        gm.GameOver();
    }
}
