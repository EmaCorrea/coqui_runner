using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CoinGenerator : MonoBehaviour {

    public ObjectPooler coinPool;

    public float distanceBetweenCoins;

    public void SpawnCoins(Vector3 startPosition, float platformWidth)
    {

        switch((int) platformWidth)
        {
            case 3:
                GameObject coin1 = coinPool.getPooledObject();
                coin1.transform.position = startPosition;
                coin1.SetActive(true);

                GameObject coin2 = coinPool.getPooledObject();
                coin2.transform.position = new Vector3((startPosition.x - distanceBetweenCoins), startPosition.y, startPosition.z);
                coin2.SetActive(true);

                GameObject coin3 = coinPool.getPooledObject();
                coin3.transform.position = new Vector3(startPosition.x + distanceBetweenCoins, startPosition.y, startPosition.z);
                coin3.SetActive(true);

                break;
            case 5:
                GameObject coin4 = coinPool.getPooledObject();
                coin4.transform.position = startPosition;
                coin4.SetActive(true);

                GameObject coin5 = coinPool.getPooledObject();
                coin5.transform.position = new Vector3((startPosition.x - distanceBetweenCoins), startPosition.y, startPosition.z);
                coin5.SetActive(true);

                GameObject coin5_1 = coinPool.getPooledObject();
                coin5_1.transform.position = new Vector3((startPosition.x - distanceBetweenCoins - 1f), startPosition.y, startPosition.z);
                coin5_1.SetActive(true);

                GameObject coin6 = coinPool.getPooledObject();
                coin6.transform.position = new Vector3(startPosition.x + distanceBetweenCoins, startPosition.y, startPosition.z);
                coin6.SetActive(true);

                GameObject coin6_1 = coinPool.getPooledObject();
                coin6_1.transform.position = new Vector3(startPosition.x + distanceBetweenCoins + 1, startPosition.y, startPosition.z);
                coin6_1.SetActive(true);

                break;
            case 7:
                GameObject coin7 = coinPool.getPooledObject();
                coin7.transform.position = startPosition;
                coin7.SetActive(true);

                GameObject coin8 = coinPool.getPooledObject();
                coin8.transform.position = new Vector3((startPosition.x - distanceBetweenCoins), startPosition.y, startPosition.z);
                coin8.SetActive(true);

                GameObject coin8_1 = coinPool.getPooledObject();
                coin8_1.transform.position = new Vector3((startPosition.x - distanceBetweenCoins - 1), startPosition.y, startPosition.z);
                coin8_1.SetActive(true);

                GameObject coin8_2 = coinPool.getPooledObject();
                coin8_2.transform.position = new Vector3((startPosition.x - distanceBetweenCoins - 2), startPosition.y, startPosition.z);
                coin8_2.SetActive(true);

                GameObject coin9 = coinPool.getPooledObject();
                coin9.transform.position = new Vector3(startPosition.x + distanceBetweenCoins, startPosition.y, startPosition.z);
                coin9.SetActive(true);

                GameObject coin9_1 = coinPool.getPooledObject();
                coin9_1.transform.position = new Vector3(startPosition.x + distanceBetweenCoins + 1, startPosition.y, startPosition.z);
                coin9_1.SetActive(true);

                GameObject coin9_2 = coinPool.getPooledObject();
                coin9_2.transform.position = new Vector3(startPosition.x + distanceBetweenCoins + 2, startPosition.y, startPosition.z);
                coin9_2.SetActive(true);

                break;
            case 9:
                GameObject coin10 = coinPool.getPooledObject();
                coin10.transform.position = startPosition;
                coin10.SetActive(true);

                GameObject coin11 = coinPool.getPooledObject();
                coin11.transform.position = new Vector3((startPosition.x - distanceBetweenCoins), startPosition.y, startPosition.z);
                coin11.SetActive(true);

                GameObject coin11_1 = coinPool.getPooledObject();
                coin11_1.transform.position = new Vector3((startPosition.x - distanceBetweenCoins - 1), startPosition.y, startPosition.z);
                coin11_1.SetActive(true);

                GameObject coin11_2 = coinPool.getPooledObject();
                coin11_2.transform.position = new Vector3((startPosition.x - distanceBetweenCoins - 2), startPosition.y, startPosition.z);
                coin11_2.SetActive(true);

                GameObject coin11_3 = coinPool.getPooledObject();
                coin11_3.transform.position = new Vector3((startPosition.x - distanceBetweenCoins - 3), startPosition.y, startPosition.z);
                coin11_3.SetActive(true);

                GameObject coin12 = coinPool.getPooledObject();
                coin12.transform.position = new Vector3(startPosition.x + distanceBetweenCoins, startPosition.y, startPosition.z);
                coin12.SetActive(true);

                GameObject coin12_1 = coinPool.getPooledObject();
                coin12_1.transform.position = new Vector3(startPosition.x + distanceBetweenCoins + 1, startPosition.y, startPosition.z);
                coin12_1.SetActive(true);

                GameObject coin12_2 = coinPool.getPooledObject();
                coin12_2.transform.position = new Vector3(startPosition.x + distanceBetweenCoins + 2, startPosition.y, startPosition.z);
                coin12_2.SetActive(true);

                GameObject coin12_3 = coinPool.getPooledObject();
                coin12_3.transform.position = new Vector3(startPosition.x + distanceBetweenCoins + 3, startPosition.y, startPosition.z);
                coin12_3.SetActive(true);

                break;
        }

    }

}
