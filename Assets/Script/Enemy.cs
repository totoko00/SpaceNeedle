using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    public GameObject enemyprefab;


    //敵の生成感覚を決める。Elapsedは経過という意味
    public float timeOut = 1.0f;
    private float timeElapsed = 0;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        //timeElapsedに経過時間（Time.deltaTime）を加算
        timeElapsed += Time.deltaTime;
        if (timeElapsed > timeOut)
        {
            //時間経過を0.0fに戻す
            timeElapsed = 0.0f;

            //GameObjectでPrefabの中のEnemyを読み込み。この時ちゃんと「as GameObject」でちゃんと「GameObject型」であるようにする
            //GameObject obj = Resources.Load("Prefab/Enemy") as GameObject;
            GameObject obj = Instantiate(enemyprefab) as GameObject;
            float px = Random.Range(-3, 4);
            float py = Random.Range(3, 7);
            obj.transform.position = new Vector2(px, py);
        }
        if (Input.GetMouseButtonDown(0))
        {
            Debug.Log("マウスクリック！");//ここまではOK
            Destroy();//←ここがわからず……
        }
    }
}
