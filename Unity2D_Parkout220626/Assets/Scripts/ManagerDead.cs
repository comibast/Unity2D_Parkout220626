using UnityEngine;


namespace Comibast
{
    public class ManagerDead : MonoBehaviour
    {
        [SerializeField, Header("�ؼЦW��")]
        private string nameTarget = "�Ԫ��t";
        [SerializeField, Header("�����޲z��")]
        private ManageFinal manageFinal;
        [SerializeField, Header("CM��v�������")]
        private GameObject goCM;


        private void OnTriggerEnter2D(Collider2D collision)
        {
            if (collision.name.Contains(nameTarget))
            {
                manageFinal.stringTitle = "���ѤF~";
                manageFinal.enabled = true;
                goCM.SetActive(false);
            }
        }

    }
}



    
