using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMO : MonoBehaviour
{
    public float speed;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        MoveByTrans();
    }

    public void MoveByTrans()
    {
        Vector2 temPos = transform.position;
        float x = Input.GetAxis("Horizontal");
        float y = Input.GetAxis("Vertical");
        temPos.x += x * Time.deltaTime * speed;
        temPos.y += y * Time.deltaTime * speed;
        transform.position = temPos;
    }


}
