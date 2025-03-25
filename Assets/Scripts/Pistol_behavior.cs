using UnityEngine;

public class Pistol_behavior : MonoBehaviour
{
    public GameObject laserTemplate;
    public Transform spawnPoint;
    public float thrust = 1.0f;

    public int clipSize = 10;
    public int shotsRemaining = 10;

    public void ShootLaser()
    {
        if (shotsRemaining > 0) {
            GameObject laser = Instantiate(laserTemplate, spawnPoint.position, spawnPoint.rotation);
            Rigidbody rb = laser.GetComponent<Rigidbody>();
            rb.AddForce(spawnPoint.forward * thrust, ForceMode.Impulse);
            shotsRemaining -= 1;
        }
        
        // Rigidbody rb = laserTemplate.GetComponent<Rigidbody>();
        // laserTemplate = Instantiate(laserTemplate, spawnPoint.position, spawnPoint.rotation);
        // rb.AddForce(spawnPoint.forward * laserSpeed, ForceMode.Impulse);
    }

    public void reload() {
        shotsRemaining = clipSize;
    }
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
