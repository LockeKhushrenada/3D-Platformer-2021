using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PickUp : MonoBehaviour
{
    [SerializeField]
    int goToLevel = 0;

    public int currentCount;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "player")
        {
            GameManager.instance.pickupsLeft(1);
            if (GameManager.instance.currentCount <= 0)
            {
                SceneManager.LoadScene(goToLevel);
            }
            Destroy(gameObject);
        }
        
    }
}
