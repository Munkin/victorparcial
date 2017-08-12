using UnityEngine;

public class Catapult : MonoBehaviour
{
    [SerializeField]
    private GameObject projectileToFire;

    [SerializeField]
    private Transform projectileSpawnTranform;

    public void Fire()
    {
       GameObject tempBullet = Instantiate(projectileToFire, projectileSpawnTranform.position, projectileSpawnTranform.rotation);
       tempBullet.GetComponent<Rigidbody>().AddRelativeForce(Vector3.forward * 5f);
    }
}