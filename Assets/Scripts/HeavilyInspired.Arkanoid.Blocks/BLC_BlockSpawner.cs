using System.Collections;
using System.Collections.Generic;
using UnityEngine;


namespace HeavilyInspired.Arkanoid.Blocks
{
    public class BLC_BlockSpawner : MonoBehaviour
    {
        [Header("References")]
        public Transform blockParent;
        public GameObject blockPrefab; 


        [Header("Values")]
        public int rowCount = 4;
        public int blockCountInRow = 10;
        public float xBlockSpacing = 4;
        public float yBlockSpacing = 5;

        private void Reset() {
            blockParent = this.transform;
        }

        // Start is called before the first frame update
        void Start()
        {
            Generate();    
        }

        public void Generate(){
            int cc = blockParent.childCount;

            for(int i = 0; i < cc; i++){
                Destroy(transform.GetChild(cc).gameObject);
            }


            for(int x = 0; x < blockCountInRow; x++){
                var go = Instantiate(blockPrefab, transform);
                
            }
        }
    }
}
