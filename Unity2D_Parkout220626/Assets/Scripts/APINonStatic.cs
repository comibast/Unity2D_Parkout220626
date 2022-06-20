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
        //1.定義欄位: 資料類型為類別
        //2.Unity屬性面板: 必須確定該欄位不是空值None
        //3.使用非靜態API(把練習用空物件上的靜態api取消勾選以免干擾)
        [SerializeField]
        private GameObject turtle;

        [SerializeField]
        private Transform startPoint;

        private void Start()
        {
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

        }

        private void Update()
        {
            startPoint.Translate(1.5f, 0, 0);
            startPoint.Rotate(0, 0, 3.5f);

        }

    }

}

