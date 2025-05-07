using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowCamera : MonoBehaviour
{
    public Transform target;
    float offsetx;

    // Start is called before the first frame update
    void Start()
    {
        if (target == null)
            return;

        offsetx = transform.position.x - target.position.x;
    }

    // Update is called once per frame
    void Update()
    {
        if(target == null)
            return;
        Vector3 pos = transform.position;
        pos.x = target.position.x + offsetx;
        transform.position = pos;
    }
}
