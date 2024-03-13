using DefaultNamespace;
using UnityEngine;

namespace Assets.Scripts
{
    public class HandKnives : MonoBehaviour
    {
        [SerializeField] private int NumberKnives;
        [SerializeField] private float SpeedKnife;
        [SerializeField] private GameObject PrefabKnife;
        [SerializeField] private Transform KnifeSpawn;

        private Knife[] _knives;

        void Start()
        {
            _knives = new Knife[NumberKnives]; 

            for (int i = 0; i < NumberKnives; i++)
            {
                GameObject obj = Instantiate(PrefabKnife, KnifeSpawn.position, Quaternion.identity, transform);
                Knife knife = obj.GetComponent<Knife>();
                knife.gameObject.SetActive(false); 
                _knives[i] = knife;
            }
            
            if (NumberKnives > 0)
            {
                _knives[0].gameObject.SetActive(true);
            }
        }

        void Update()
        {
            if (Input.GetMouseButtonDown(0))
            {
                HandleTouchInput();
            }
        }

        private void HandleTouchInput()
        {
            _knives[0].SetSpeed(SpeedKnife);
        }
    }
}
