using System.Collections;
using System.Collections.Generic;
using UnityEngine;


namespace HeavilyInspired.Arkanoid.Player
{
    public class PLR_Controller : MonoBehaviour
    {
        [Tooltip("Speed at which player moves")]
        public float speed = 1f;

        [Tooltip("The rightmost border of the screen, used to clamp player position")]
        public Vector3 borderDistance = new Vector3(10, 0, 0);

        public float hitForce = 2f;

        public float englishFactor = 1f;

        //Private vars

        private Vector3 newPosition;
        private float horizontal = 0;

        void Update()
        {
            horizontal = Input.GetAxis("Horizontal");

            //This actually moves the player
            transform.position += new Vector3((speed * Time.deltaTime) * horizontal, 0, 0);

            //Quick cache cuz its quicker i think
            var tp = transform.position;
            newPosition = new Vector3(tp.x, tp.y, tp.z);

            //Clamp the newPosition which should be equal to player position, we clamp it to borderDistance
            newPosition.x = Mathf.Clamp(newPosition.x, -borderDistance.x, borderDistance.x);

            //Apply newPosition to the transform
            transform.position = newPosition;
        }
    }
}
