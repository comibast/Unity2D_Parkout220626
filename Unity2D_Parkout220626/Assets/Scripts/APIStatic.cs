using UnityEngine;


namespace Comibast
{

    public class APIStatic : MonoBehaviour
    {
        private Vector3 a = new Vector3(1, 1, 1);
        private Vector3 b = new Vector3(22, 22, 22);
        private void Start()
        {
            #region 學習
            //取得靜態屬性
            //語法: 
            //類別, 靜態屬性名稱
            //print("隨機值:" + Random.value);
            //print("PI:" + Mathf.PI);
            //print("無限大值:" + Mathf.Infinity);
            //Cursor.visible = false;      //隱藏鼠標
            
            Physics2D.gravity = new Vector2(0, -9.8f);   //地心引力,若為負值會飛起
            Time.timeScale = 10f;          //時間同時影響物理和動畫速度
            
            //使用靜態方法:
            //語法:
            //類別.靜態方法名稱(對應引數)
            
            float range = Random.Range(20.5f, 100.5f);
            print("隨機範圍: " + range);        
            

            //print("所有攝影機數量" + );    //Camera
            print("所有攝影機數量: " + Camera.allCamerasCount);

            //print("應用程式的平台:" + );             //Application
            print("目前的平台: " + Application.platform);

            //print("3D 物理睡眠臨界值設定為 10" + );    //Physics3D
            Physics.sleepThreshold = 10;
            print("睡眠臨界值: " + Physics.sleepThreshold);

            //print("時間大小設定為 0.5 (慢動作)" + );   //Time
            Time.timeScale = 0.5f;
            print("時間大小:"+ Time.timeScale);

            //print("對 9.999 去小數點 (不限制去除方式):" + );   //Mathf
            print("9.999 去掉小數點四捨五入" + Mathf.Round(9.999f));

            //print("取得兩點的距離:" + );   //Vector3
            //new Vector3(1, 1, 1), new Vector3(22, 22, 22)
            float distance = Vector3.Distance(a, b);
            print("<color=yellow>距離: " + distance + "</color>");

            ////print("開啟連結 https://unity.com/:" + );   //Application
            Application.OpenURL("http://unity.com/");
            #endregion


        }


        private void Update()
        {
            #region 學習

            //print("隨機整數1~2:(因為不包含3) " + rangeInt);
            //minInclusive:包含最小值, maxExclusive:不包含最大值.
            int rangeInt = Random.Range(1, 3);

            //print("是否輸入任意鍵: " + );            //Input
            print("是否按下任意鍵: " + Input.anyKeyDown);

            //print("遊戲經過時間: " + );            //Time
            print("遊戲經過時間: " + Time.timeSinceLevelLoad);

            //print("是否按下按鍵 (指定為空白鍵): " + );   //Input
            print("<color=red>是否按下空白鍵: "+ Input.GetKeyDown(KeyCode.Space)+"</color>");

            #endregion







        }





    }

}

