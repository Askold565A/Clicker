using UnityEngine;
using TMPro;



public class EnemyHealth : MonoBehaviour
{

    [SerializeField] private int enemyHealth;
    [SerializeField] private TMP_Text healthValueText;
   


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
       
    }

   

    void OnMouseDown()
    {
        if (Input.GetMouseButton(0))
        {
            enemyHealth--;

            healthValueText.text = enemyHealth.ToString();

            

            if (enemyHealth <= 0 && gameObject.tag == "Enemy") 
            {
              
                Destroy(gameObject);

                MyGameManager.instance.score ++;

                MyGameManager.instance.scoreText.text = MyGameManager.instance.score.ToString();

            }

            else if(enemyHealth <= 0 && gameObject.tag == "BossEnemy")
            {
                Destroy(gameObject);

                MyGameManager.instance.score += 5;

                MyGameManager.instance.scoreText.text = MyGameManager.instance.score.ToString();
            }

            
        }
    }
}

