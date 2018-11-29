using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Gacha
{
    public class Random : MonoBehaviour
    {

        // Use this for initialization
        void Start()
        {

        }

        // Update is called once per frame
        void Update()
        {

        }


        public bool Flag;
        public int RandomNumber;

        public int Min;
        public int Max;

        private void OnValidate()
        {
            var random = new System.Random();
            RandomNumber = random.Next(Min, Max);

        }
    }
}

