using UnityEngine;
using UnityEngine.InputSystem;


public class PlayerInput : MonoBehaviour
{
    public InputAction moveAction;
    public Vector2 moveinput;
    public float moveSpeed = 10f;

    public InputAction fireAction;
    public GameObject projectailPrefab;
   private float xRange = 10f;
   private float yRange = 10f;

   
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        moveAction.Enable();
        fireAction.Enable();
    }

    // Update is called once per frame
    void Update()
    {   //keep bind button
        
        if (transform.position.x  <- xRange)
        {
            transform.position = new Vector3(-xRange, transform.position.y, transform.position.z);
        }
        
        if (transform.position.x  > xRange)
        {
            transform.position = new Vector3(xRange, transform.position.y, transform.position.z);
        }
        moveinput = moveAction.ReadValue<Vector2>();
        transform.Translate(new Vector3(moveinput.x, 0, moveinput.y) * moveSpeed * Time.deltaTime);
        
        if (fireAction.triggered){
            Debug.Log("fire");
            Instantiate(projectailPrefab,transform.position,projectailPrefab.transform.rotation);
        }
    }

}
