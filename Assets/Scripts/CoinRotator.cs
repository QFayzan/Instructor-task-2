using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CoinRotator : MonoBehaviour
{
    

    // Update is called once per frame
    void Update()
    {
        transform.Rotate(0, 60, 0, Space.Self  );
    }
}
