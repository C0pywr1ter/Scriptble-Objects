using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PingPong : MonoBehaviour
{
    private void Update()
    {
        var Xcoord = Mathf.PingPong(Time.time, 5);

        transform.position = new Vector3(Xcoord, 0, 0);
    }
}
