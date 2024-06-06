using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyByPosition : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    
    private void LateUpdate()
    {
        if (transform.position.x < -8.65f - 2 ||
            transform.position.x > -5.25f + 2 ||
            transform.position.y < 8.65f -2 ||
            transform.position.y > 5.25f + 2)
        {
            Destroy(gameObject);
        }
    }
}
