using System;
using UnityEngine;

namespace DefaultNamespace
{
    public class Knife : MonoBehaviour
    {
        [SerializeField]private float speed = 0f; 

        void Update()
        {
            Vector3 currentPosition = transform.position;
            float newPositionY = currentPosition.y + speed * Time.deltaTime;
            Vector3 newPosition = new Vector3(currentPosition.x, newPositionY, currentPosition.z);
            transform.position = newPosition;
        }

        public void SetSpeed(float speed) 
        {
            this.speed = speed;
        }

        private void OnTriggerEnter2D(Collider2D col)
        {
            if (col.CompareTag("Aim")) // Замените "Player" тегом объекта, который вы хотите обрабатывать
            {
                Debug.Log("Вошел в триггер!");
                speed = 0f;
                this.transform.SetParent(col.transform);
            }
            
        }

    }
}