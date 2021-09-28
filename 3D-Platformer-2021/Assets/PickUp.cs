using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PickUp : MonoBehaviour
{
    private GameObject[] getCount;
    public int currentCount;
    // Start is called before the first frame update
    void Start()
    {
        getCount = GameObject.FindGameObjectsWithTag("pickup");
    }

    // Update is called once per frame
    void Update()
    {
        currentCount = getCount.Length;
    }
    private void OnTriggerEnter(Collider other)
    {
        GameManager.instance.AddScore(1);
        currentCount -= 1;
        if(currentCount == 0)
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
        }
        Destroy(gameObject);
    }
}
