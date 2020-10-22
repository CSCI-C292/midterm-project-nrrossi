using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rock : MonoBehaviour
{
    [SerializeField] float _rockFallSpeed = 0.01f;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

      //  if(transform.position.y == -5.5f)
     //     Destroy(gameObject);



       // transform.position -= new Vector3(0, Time.deltaTime * _rockFallSpeed, 0); //Old Drop Mechanic

    }
}
