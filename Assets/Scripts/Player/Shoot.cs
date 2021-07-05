using Unity.Mathematics;
using UnityEngine;

namespace Player
{
    public class Shoot : MonoBehaviour
    {
        public Transform gunPoint;
        public GameObject bullet;
        public Sprite bulletGraphics;

        protected Input input;

        private void Start()
        {
            input = GetComponent<Input>();
        }

        private void Update()
        {
            if (!input.Shoot) return;
            
            var clone = Instantiate(bullet, gunPoint.position, quaternion.identity);
            clone.GetComponent<SpriteRenderer>().sprite = bulletGraphics;

        }
    }
}