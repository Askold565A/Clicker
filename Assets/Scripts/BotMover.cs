using UnityEngine;


public class BotMover : MonoBehaviour
{
    [Header("Parameters")]
    [SerializeField] private float speed;
    [SerializeField] private float maxDistance;
    

    private Transform botTransform;
    private float forwardPosition;

    private Vector3 initialPosition;
    
    void Start()
    {
        botTransform = transform;
        initialPosition = botTransform.position;
    }

    void Update()
    {
        forwardPosition += Time.deltaTime * speed;
        botTransform.position = initialPosition + transform.forward * forwardPosition;
        
        if (forwardPosition > maxDistance)
        {
            Destroy(gameObject);
            MyGameManager.instance.playerHealth--;
            MyGameManager.instance.playerHealthText.text = MyGameManager.instance.playerHealth.ToString();
        }
        
    }

   
}
