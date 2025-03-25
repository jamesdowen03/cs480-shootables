using UnityEngine;

public class DestroyOnCollision : MonoBehaviour
{
    public bool destroyWithAnyObject = false;
    public string collisionTag = "";
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    
    void OnCollisionEnter(Collision collision)
    {
        if (destroyWithAnyObject) {
            Destroy(gameObject);
        }
        else {
            if (collision.gameObject.CompareTag(collisionTag)) {
                Destroy(gameObject);
            }
        }
    }
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
