using UnityEngine;

public class ProppellerRotation : MonoBehaviour
{

    //variable 

    public float speed = 5.0f;


    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //transform.Rotate(Vector3.forward * Time.deltaTime * speed );
        transform.Rotate(0, 0, speed * Time.deltaTime);
    }
}
