using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    private Vector3 direction;
    public float gravity = -9.8f;
    public float strength = 5f;
    public Transform angleRotation;
    private float angle = 30;

    private void Update()
    {
        
        if (Input.GetKeyDown(KeyCode.Space) || Input.GetMouseButton(0))
        {
            direction = Vector3.up * strength;
            transform.rotation = Quaternion.Euler(0, 0, angle);
        }

        if (Input.touchCount > 0)
        {
            Touch touch = Input.GetTouch(0);
            
            if(touch.phase == TouchPhase.Began)
            {
                direction = Vector3.up * strength;
                transform.rotation = Quaternion.Euler(0, 0, angle);

            }
        }
       if (Input.GetKeyDown(KeyCode.A) || Input.GetMouseButton(1))
        {
            
            //  print(angleRotation.transform.localRotation.z);
            

        }

        transform.rotation = Quaternion.Euler(0, 0, 0);
        direction.y += gravity * Time.deltaTime;
        transform.position += direction * Time.deltaTime;
    }
    
}
