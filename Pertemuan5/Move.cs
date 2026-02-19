
using UnityEngine;

namespace TopDown.Movement
{
    // Namespace = wadah / folder LOGIS untuk kode mencegah bentrok antar class

    [RequireComponent(typeof(Rigidbody2D))]
    //Jika Rigidbody2D belum ada → Unity otomatis
    //menambahkan Jika dihapus → Unity akan memaksa ada lagi
    public class Move : MonoBehaviour
    {
        // [SerializeField] → tetap muncul di Inspector
        [SerializeField] private float moveSpeed;
        private Rigidbody2D body;
        protected Vector3 currentInpunt;

        //Awake() dipanggil: Saat object pertama kali aktif Sebelum Start()
        private void Awake()
        {
            body = GetComponent<Rigidbody2D>();
        }

        //digunakan untuk component yang berhubungan dengan fisika
        private void FixedUpdate()
        {
            //Mengatur kecepatan gerak Rigidbody2D, current input Arah gerak (vector), menjaga kecepatan tetap konsisten
            body.velocity = moveSpeed * currentInpunt * Time.fixedDeltaTime;
        }


    }

}
