using UnityEngine;
using System.Threading.Tasks;

public class Attack : MonoBehaviour
{
    public GameObject attackPrefab;
    public Transform attackTransform;
    public int attackCooldown;
    private GameObject currentAttack;

    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            PerformAttack();
        }
    }

    public async void PerformAttack()
    {
        currentAttack = Instantiate(attackPrefab, attackTransform.position, attackTransform.rotation);
        await Task.Delay(attackCooldown);
        Destroy(currentAttack);
    }
}
