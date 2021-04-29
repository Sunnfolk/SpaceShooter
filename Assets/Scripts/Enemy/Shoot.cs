using System;
using UnityEditor.UIElements;
using UnityEngine;


namespace Enemy
{
    
    public class Shoot : MonoBehaviour
    {
    
        public Transform gunPoint;
        public GameObject bullet;
        
        
        public Sprite bulletGraphics;

        public  EnumField _field;
      
        
        // Update is called once per frame
        public void Start()
        {
            
            InvokeRepeating(nameof(Shooting), 2f, 2f);
        }

        public void Shooting()
        {
            var clone = Instantiate(bullet, gunPoint.position, Quaternion.Euler(transform.eulerAngles));
            clone.GetComponent<SpriteRenderer>().sprite = bulletGraphics;
        }
    }
}