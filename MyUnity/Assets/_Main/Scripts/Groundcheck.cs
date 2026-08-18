using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Groundcheck : MonoBehaviour
{

    public bool isGround;

    private void OnTriggerStay2D(Collider2D collision)
    {
    
        {
            isGround = true;
            Debug.Log("me tocaron");
        }
    }
    
        
    

        private void OnTriggerExit2D(Collider2D collision)
        {
          isGround = false;
          Debug.Log("ya no me tocan");
        }
}
