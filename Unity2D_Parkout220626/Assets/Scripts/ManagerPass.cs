using UnityEngine;

namespace Comibast
{
    /// <summary>
    /// 管理過關
    /// </summary>

    public class ManagerPass : MonoBehaviour
    {
        [SerializeField, Header("目標名稱")]
        private string nameTarget = "忍者龜";
        [SerializeField, Header("跑步系統")]
        private SystemRun systemrun;
        [SerializeField, Header("跳躍系統")]
        private SystemJump systemJump;
        [SerializeField, Header("結束管理器")]
        private ManageFinal manageFinal;



        #region 其中一個物件有勾選 Is trigger
        //兩個物件碰撞時執行一次
        private void OnTriggerEnter2D(Collider2D collision)
        {
            print(collision.name);

            //如果 碰撞物件的名稱 包含 (忍者龜)
            if (collision.name.Contains(nameTarget))
            {
                systemrun.enabled = false;       //關閉跑步系統
                systemJump.enabled = false;      //關閉跳躍系統
                manageFinal.enabled = true;      //啟動結束管理器
                manageFinal.stringTitle = "恭喜通過!!";
            }

        }

        //兩個物件碰撞離開時執行一次
        private void OnTriggerExit2D(Collider2D collision)
        {
            
        }
        
        //兩個物件碰撞重疊時持續執行
        private void OnTriggerStay2D(Collider2D collision)
        {
            
        }
        #endregion



        #region 兩個物件都沒有勾選 Is trigger
       
        private void OnCollisionEnter(Collision collision)
        {
            
        }

        private void OnCollisionEnter2D(Collision2D collision)
        {
            
        }

        private void OnCollisionStay2D(Collision2D collision)
        {
            
        }

        #endregion

        // Start is called before the first frame update
        void Start()
        {

        }

        // Update is called once per frame
        void Update()
        {

        }
    }

}

