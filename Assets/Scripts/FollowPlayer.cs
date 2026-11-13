using UnityEngine;

public class FollowPlayer : MonoBehaviour
{
    //variables
    public GameObject player;
    private Vector3 offset = new Vector3(0, 5, -8);


    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void LateUpdate()
    {
        cameraFollow();
    }


    private void cameraFollow()
{
    //offset the camera behind the player by adding to the player's position
    transform.position = player.transform.position + offset;
}

}

