using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace MyGame
{
    public class Random : MonoBehaviour
    {
        public bool Flag;
        public int RandomNumber;

        public int Min;
        public int Max;

        // Use this for initialization
        void Start()
        {

        }

        // Update is called once per frame
        void Update()
        {

        }

        private void OnValidate()
        {
            var random = new System.Random();
            RandomNumber = random.Next(Min, Max);
        }
    }
}
