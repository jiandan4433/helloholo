using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DropHelper : MonoBehaviour
{

    public void DoDrop()
    {
        var rb = GetComponent<Rigidbody>();
        if (rb == null)
            return;

        rb.useGravity = true;
    }
}
