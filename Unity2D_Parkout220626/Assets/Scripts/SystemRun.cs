using UnityEngine;    //引用Unity引擎，命名空間(namespace)API
namespace Comibast
{
    //C# 從藍圖變成實體物件
    //1. 場景上的遊戲物件
    //2. 將此腳本掛在該物件變成元件

    /// <summary>
    /// 跑步系統
    /// </summary>
    public class SystemRun : MonoBehaviour
    {
        #region 資料：保存系統需要的資料

        //欄位(Field): 保存資料
        //語法: 
        //修飾詞: 欄位資料類型(公開,私人) 欄位自訂名稱(指定 預設值) 

        //修飾詞
        //公開: 顯示在面板, 允許其他類別存取public
        //私人: 不顯示在面板, 不允許其他類別存取private(封裝)

        //[] Attribute 屬性, 額外功能
        //SSerializeField 序列化欄位: 將私人欄位顯示
        //Header 標題: 可用中文
        //Tooltip 提示: 可以使用中文
        // Range 範圍: 僅限於數值類型資料int, float, byte,long

        [SerializeField,Header("跑步速度"),Tooltip("這是角色的跑步速度"),Range(0,100)]      
        private float speedRun = 3.5f;
        [SerializeField,Header("跳躍高度"), Range(0, 3000)]      
        private float heightJump = 350;
        private Animator ani;
        private Rigidbody2D rig;

        #endregion


        #region 功能：實作該系統的方法

        #endregion


        #region 事件：程式入口
        private void Start()
        {
            print("Hi! 小道! :D");
        }
        #endregion

    }
}

