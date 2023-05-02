using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyObjectX : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        Destroy(gameObject, 2); // destroy particle after 2 seconds
    }

}
