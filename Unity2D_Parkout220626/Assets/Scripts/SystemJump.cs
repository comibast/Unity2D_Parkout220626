using UnityEngine;

namespace Comibast
{
    /// <summary>
    /// ���D�t��
    /// </summary>
    public class SystemJump : MonoBehaviour
    {
        #region ���
        [SerializeField, Header("���D����"), Range(0, 3000)]
        private float heightJump = 350;

        private Animator ani;
        private Rigidbody2D rig;
        private bool clickJump;
        #endregion


        #region �ƥ�
        private void Awake()
        {
            ani = GetComponent<Animator>();
            rig = GetComponent<Rigidbody2D>();
        }

        //Input API ��ĳ�b Update �I�s
        //�@���60��
        private void Update()
        {
            Jumpkey();
        }

        //�@��T�w50��
        private void FixedUpdate()
        {
            JumpForce();
        }

        #endregion


        #region �\��
        /// <summary>
        /// ���D����
        /// </summary>
        private void Jumpkey()
        {
            //�p�G ���a ���U �ť��� �N���W ���D
            //if
            //switch
            //if �P�_���y�k: if (���L��) { ���L�� �� ture�� ����{�� }
            if (Input.GetKeyDown(KeyCode.Space))
            {
                print("���D~!");
                clickJump = true;
            }
        }

        private void JumpForce()
        {
            if (clickJump)
            {
                rig.AddForce(new Vector2(0, heightJump));
                clickJump = false;
            }
        }

        #endregion

    }
}
