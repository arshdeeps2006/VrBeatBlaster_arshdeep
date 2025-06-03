using UnityEngine;

public class Zmotion : MonoBehaviour
{
    [SerializeField]
    public float playerSpeed = 2f; // Units per second

    void Update()
    {
        transform.Translate(Vector3.forward * playerSpeed * Time.deltaTime);
    }
}
