using UnityEngine;

public class NewMonoBehaviourScript : MonoBehaviour
{
    public GameObject towerOne;
    
    
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        Instantiate(towerOne, new Vector3(0, 0, 0), Quaternion.identity);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
