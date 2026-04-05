using UnityEngine;

public class notu_script : MonoBehaviour
{
    [SerializeField] private Vector3 speed = new Vector3(0, -1, 0);
    
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.position += speed * Time.deltaTime;
    }
}
