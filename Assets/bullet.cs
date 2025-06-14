using UnityEngine;

public class bullet : MonoBehaviour
{
    void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Surface") || collision.gameObject.CompareTag("Enemy"))
        {
            Debug.Log("Collision of bullet with surface detected");
            Destroy(gameObject);
        }
    }
}
