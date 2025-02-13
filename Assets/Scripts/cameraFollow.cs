using UnityEngine;

public class cameraFollow : MonoBehaviour
{
    private float followSpeed = 2f;
    private float xOffset = 2f;
    private float yOffset = 2f;
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
