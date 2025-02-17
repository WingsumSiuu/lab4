using UnityEngine;

public class cameraFollow : MonoBehaviour
{
    private float followSpeed = 3f;
    private float xOffset = 1f;
    private float yOffset = 1f;
    public Transform target; 

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 newPos = new Vector3(target.position.x+xOffset, target.position.y+yOffset, -10f);
        transform.position = Vector3.Slerp(transform.position, newPos, followSpeed*Time.deltaTime);
    }
}
