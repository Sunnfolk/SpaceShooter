using UnityEngine;

public class AutoShoot : MonoBehaviour
{
        [Header("Setup")]
        [Tooltip("This Variable sets the point we spawn the bullet at (We don't want to spawn the bullet inside the Ship)")]
    public Transform gunPoint;
    
        [Tooltip("This Variable is how we access the Bullet Prefab and use it to create clones")]
    public GameObject projectile;
    
        [Tooltip("This Variable allows us to change the graphics of the Bullet to avoid having multiple bullets")]
    public Sprite bulletGraphics;

        [Space(10)]
        [Header("Time")]
    
        [Tooltip("This Variable decides the time between each shot")]
    public float shootTime = 0.3f;
    
        [Tooltip("This Variable decides the time between game start and the first shot")]
    public float startBuffer = 1f;

        [Tooltip("This Variable is used to change the Tag of the projectile to be spawned")]
    public new string tag;
    
    private void Start()
    {
        
        InvokeRepeating(nameof(Shooting), startBuffer, shootTime );
    }

    private void Shooting()
    {
        var clone = Instantiate(projectile, gunPoint.position, Quaternion.Euler(transform.eulerAngles));
        clone.GetComponent<SpriteRenderer>().sprite = bulletGraphics;
        clone.GetComponent<Transform>().tag = tag;
    }
}