using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerSimpleMovement : MonoBehaviour
{
    [SerializeField]
    private float _speed;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
         //Now moving 1 meter per second vs 1 meter per frame
        // transform.Translate(Vector3.right * _speed * Time.deltaTime);
        // transform.Translate(new Vector3(-1,0,0) * _speed * Time.deltaTime);
        float HorizontalInput = Input.GetAxis("Horizontal");
        transform.Translate(new Vector3(HorizontalInput,0,0) * _speed * Time.deltaTime);
    }
}
