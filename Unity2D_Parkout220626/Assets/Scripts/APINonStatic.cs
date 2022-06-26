using UnityEngine;

namespace Comibast
{
    /// <summary>
    /// 非靜態API
    /// 與靜態的差別在於需要實體物件
    /// 實體物件:存在於場景上的遊戲物件(Game Object)
    /// </summary>
    public class APINonStatic : MonoBehaviour
    {
        /*
        //1.定義欄位: 資料類型為類別
        //2.Unity屬性面板: 必須確定該欄位不是空值None
        //3.使用非靜態API(把練習用空物件上的靜態api取消勾選以免干擾)
        [SerializeField]
        private GameObject turtle;

        [SerializeField]
        private Transform startPoint;
        */


        //攝影機深度 (Depth) | Camera
        [SerializeField] Camera cam;

        //球體碰撞器半徑       | Sphere Collider
        [SerializeField] SphereCollider scol;

        //攝影機的背景顏色指定為隨機顏色 | Camera
        [SerializeField] Transform capsule, cube;
        Rigidbody capsule_body;

        //膠囊體尺寸改為 3, 2, 1 | Transform
        private void Awake()
        {
            capsule_body = capsule.GetComponent<Rigidbody>();
        }



        private void Start()
        {
            /*
            //非靜態屬性
            //1.取得
            //語法:
            //欄位名稱.非靜態屬性
            print("忍者龜的啟動狀態: " + turtle.activeInHierarchy);
            print("忍者龜的預設圖層: " + turtle.layer);
            print("起點的座標: " + startPoint.position);

            //2.設定
            //語法:
            //欄位名稱.非靜態屬性 指定 值:
            //turtle.activeInHierarchy = false; (錯誤: 唯讀屬性 官方沒寫)
            turtle.tag = "Player";
            turtle.layer = 4;
            startPoint.position = new Vector3(0, 5, 0);

            //3.使用非靜態方法
            //語法: 欄位名稱.非靜態方法(對應的引數);
            turtle.SetActive(false);
            */


            print(cam.depth);
            print(scol.radius);
            capsule.localScale = new Vector3(3, 2, 1);
            Color color = new Color();
            color.r = Random.Range(0f, 1f);
            color.g = Random.Range(0f, 1f);
            color.b = Random.Range(0f, 1f);
            cam.backgroundColor = color;



        }

        private void Update()
        {
            /*
            startPoint.Translate(1.5f, 0, 0);
            startPoint.Rotate(0, 0, 3.5f);
            */

            //讓立方體看著球體旋轉 | Transform
            cube.RotateAround(scol.gameObject.transform.position, Vector3.forward, 200 * Time.deltaTime);

            //讓膠囊體往上產生推力 | Rigidbody
            capsule_body.AddForce(Vector2.up * 1000 * Time.deltaTime);


        }

    }

}

