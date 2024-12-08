using JetBrains.Annotations;
using TMPro;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Player : MonoBehaviour
{

    private Rigidbody2D m_Rigidbody;
    private Vector3 lastCheckpointPosition;
    public float RotationSpeed;
    public TextMeshProUGUI DraaiSnelheid;

    public float FlySpeed;
    public TextMeshProUGUI VliegSnelheid;

    
    void Start()
    {
        DraaiSnelheid.text = "Draaisnelheid: " + RotationSpeed;
        VliegSnelheid.text = "Vliegsnelheid: " + FlySpeed;


        m_Rigidbody = GetComponent<Rigidbody2D>();
        lastCheckpointPosition = transform.position; // Startpositie als eerste checkpoint
    }
    //je kan de snelheid 
    public void SpeedChange(float speed)
    {
        RotationSpeed = speed;
        Debug.Log(speed);
    }
    //de vliegsnelheid
    public void VliegSpeed(float Snelheid)
    {
        FlySpeed = Snelheid;
       
    }
    //zorgt er voor dat je kan vliegen
    private void FixedUpdate()
    {
        DraaiSnelheid.text = "Draaisnelheid: " + RotationSpeed;
        VliegSnelheid.text = "Vliegsnelheid: " + FlySpeed;

        m_Rigidbody.rotation += RotationSpeed;
        if(Input.GetAxis("Horizontal") >  0)
        {
            m_Rigidbody.AddForce(new Vector2(FlySpeed, 0));
        }

        if (Input.GetAxis("Horizontal") < 0)
        {
            m_Rigidbody.AddForce(new Vector2(-FlySpeed, 0));
        }

        if(Input.GetAxis("Vertical") > 0)
        {
            m_Rigidbody.AddForce(new Vector2(0, FlySpeed));
        }

        if (Input.GetAxis("Vertical") < 0)
        {
            m_Rigidbody.AddForce(new Vector2(0, -FlySpeed));
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
    //checkpoint
    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Checkpoint"))
        {
            lastCheckpointPosition = other.transform.position;
            Debug.Log("Checkpoint bereikt!");
        }

        if (other.CompareTag("Win"))
        {
            AchieveVictory();
        }
    }

    //zorgt er voor dat je kan vliegen
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

    // roep dit aan als je wint
    private void AchieveVictory()
    {
        SceneManager.LoadScene(2);
    }

    public void RotationspeedText()
    {
        
    }
}

