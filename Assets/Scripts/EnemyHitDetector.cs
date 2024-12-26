using UnityEngine;

public class EnemyHitDetector : MonoBehaviour
{
    void OnTriggerEnter(Collider collider)
    {
        if (collider.gameObject.CompareTag("Weapon"))
        {
            Debug.Log("i got hit");
        }
    }
}
