using UnityEngine;

namespace TopDown.Save
{
    public class Save : MonoBehaviour
    {
        public void SavePosition()
        {
            PlayerPrefs.SetFloat("X", transform.position.x);
            PlayerPrefs.SetFloat("Y", transform.position.y);
            PlayerPrefs.SetFloat("Z", transform.position.z);
            PlayerPrefs.SetInt("HasSave", 1);
            PlayerPrefs.Save();
        }

        void Start()
        {
            if (PlayerPrefs.GetInt("HasSave", 0) == 1)
            {
                float x = PlayerPrefs.GetFloat("X");
                float y = PlayerPrefs.GetFloat("Y");
                float z = PlayerPrefs.GetFloat("Z");

                transform.position = new Vector3(x, y, z);
            }
        }
    }

}
