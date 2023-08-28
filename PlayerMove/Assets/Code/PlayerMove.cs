using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMove : MonoBehaviour
{
    [SerializeField] Rigidbody rigid;
    [SerializeField] float speed = 10f;
    [SerializeField] float rotSpeed = 5f;

    private Vector3 dir = Vector3.zero;

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        dir.x = Input.GetAxis("Horizontal"); // A D
        dir.z = Input.GetAxis("Vertical"); // W S
        dir.Normalize();
        
    }


    private void FixedUpdate()
    {
        if (dir != Vector3.zero)
        {
            if(Mathf.Sign(transform.forward.x) != Mathf.Sign(dir.x) || Mathf.Sign(transform.forward.z) != Mathf.Sign(dir.z))
            {
                transform.Rotate(0, 1, 0);
            }
            transform.forward = Vector3.Lerp(transform.forward, dir, rotSpeed * Time.fixedDeltaTime);
        }

        rigid.MovePosition(transform.position + dir * speed * Time.fixedDeltaTime);
    }
}
