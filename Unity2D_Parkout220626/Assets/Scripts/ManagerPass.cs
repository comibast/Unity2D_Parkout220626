using UnityEngine;

namespace Comibast
{
    /// <summary>
    /// �޲z�L��
    /// </summary>

    public class ManagerPass : MonoBehaviour
    {
        [SerializeField, Header("�ؼЦW��")]
        private string nameTarget = "�Ԫ��t";
        [SerializeField, Header("�]�B�t��")]
        private SystemRun systemrun;
        [SerializeField, Header("���D�t��")]
        private SystemJump systemJump;
        [SerializeField, Header("�����޲z��")]
        private ManageFinal manageFinal;



        #region �䤤�@�Ӫ��󦳤Ŀ� Is trigger
        //��Ӫ���I���ɰ���@��
        private void OnTriggerEnter2D(Collider2D collision)
        {
            print(collision.name);

            //�p�G �I�����󪺦W�� �]�t (�Ԫ��t)
            if (collision.name.Contains(nameTarget))
            {
                systemrun.enabled = false;       //�����]�B�t��
                systemJump.enabled = false;      //�������D�t��
                manageFinal.enabled = true;      //�Ұʵ����޲z��
                manageFinal.stringTitle = "���߳q�L!!";
            }

        }

        //��Ӫ���I�����}�ɰ���@��
        private void OnTriggerExit2D(Collider2D collision)
        {
            
        }
        
        //��Ӫ���I�����|�ɫ������
        private void OnTriggerStay2D(Collider2D collision)
        {
            
        }
        #endregion



        #region ��Ӫ��󳣨S���Ŀ� Is trigger
       
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

