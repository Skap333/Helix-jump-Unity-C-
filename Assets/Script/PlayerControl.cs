using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class PlayerControl : MonoBehaviour
{
    public float sens;
    public Rigidbody snake;
    void Update()
    {
        if (Input.GetMouseButton(0))
        {
            Vector3 delta = Input.mousePosition;
            
            snake.transform.position = new Vector3(delta.x * sens, 0, 0);
        }        
    }
}
