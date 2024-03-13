using UnityEngine;

namespace DefaultNamespace
{
    public class Aim : MonoBehaviour
    {
        [SerializeField] public float rotationSpeed = 60f; 
        
            void Update()
            {
                // Получаем текущий угол вращения объекта
                float currentRotation = transform.rotation.eulerAngles.z;
                float newRotation = currentRotation + rotationSpeed * Time.deltaTime;
                Quaternion newQuaternion = Quaternion.Euler(0f, 0f, newRotation);
                transform.rotation = newQuaternion;
            }
    }
}