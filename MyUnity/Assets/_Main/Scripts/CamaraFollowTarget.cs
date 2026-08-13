using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CamaraFollowTarget : MonoBehaviour
{
    [SerializeField] private Transform target;

    private void Update()
    {
        this.transform.position = new Vector3(target.position.x,this.transform.position.y,this.transform.position.z);
    }





}
