using Unity.VisualScripting;
using UnityEngine;

public class Player : MonoBehaviour
{

    private Rigidbody2D m_Rigidbody;
    private Vector3 lastCheckpointPosition;
    void Start()
    {
        m_Rigidbody = GetComponent<Rigidbody2D>();
        lastCheckpointPosition = transform.position; // Startpositie als eerste checkpoint
    }

    private void FixedUpdate()
    {   
        
        m_Rigidbody.rotation += 2f;
        if(Input.GetAxis("Horizontal") >  0)
        {
            m_Rigidbody.AddForce(new Vector2(5, 0));
        }

        if (Input.GetAxis("Horizontal") < 0)
        {
            m_Rigidbody.AddForce(new Vector2(-5, 0));
        }

        if(Input.GetAxis("Vertical") > 0)
        {
            m_Rigidbody.AddForce(new Vector2(0, 5));
        }

        if (Input.GetAxis("Vertical") < 0)
        {
            m_Rigidbody.AddForce(new Vector2(0, -5));
        }
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Obstacle")) // Bijvoorbeeld, obstakels hebben deze tag
        {
            transform.position = lastCheckpointPosition; // Terug naar checkpoint
            Debug.Log("Respawn bij checkpoint");
        }
        else
        {
            transform.position = Vector3.zero; // Reset naar begin als er geen checkpoint is
            Debug.Log("We hebben iets geraakt, terug naar start");
        }
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Checkpoint"))
        {
            lastCheckpointPosition = other.transform.position;
            Debug.Log("Checkpoint bereikt!");
        }
    }


    void Update()
    {
        if(Input.GetAxis("Horizontal") > 0)
        {
            Debug.Log("we bewegen naar rechts");
        }

        if (Input.GetAxis("Horizontal") < 0)
        {
            Debug.Log("we bewegen naar links");
        }

        if (Input.GetAxis("Vertical") > 0)
        {
            Debug.Log("we bewegen naar beneden");
        }

        if (Input.GetAxis("Vertical") < 0)
        {
            Debug.Log("we bewegen naar omhoog");
        }
    }
}

