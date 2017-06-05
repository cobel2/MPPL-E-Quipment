using UnityEngine;
using UnityEngine.UI;
using System.Collections;
using System.Collections.Generic;

namespace Vuforia
{
    public class targetData : MonoBehaviour
    {

        public Transform TextTargetName;
        public Transform TextDescription;
        public Transform ButtonAction;
        public Transform PanelDescription;

        public AudioSource soundTarget;
        public AudioClip clipTarget;

        // Use this for initialization
        void Start()
        {
            //add Audio Source as new game object component
            soundTarget = (AudioSource)gameObject.AddComponent<AudioSource>();
        }

        // Update is called once per frame
        void Update()
        {
            StateManager sm = TrackerManager.Instance.GetStateManager();
            IEnumerable<TrackableBehaviour> tbs = sm.GetActiveTrackableBehaviours();

            foreach (TrackableBehaviour tb in tbs)
            {
                string name = tb.TrackableName;
                ImageTarget it = tb.Trackable as ImageTarget;
                Vector2 size = it.GetSize();

                Debug.Log("Active image target:" + name + "  -size: " + size.x + ", " + size.y);

                TextTargetName.GetComponent<Text>().text = name;
                ButtonAction.gameObject.SetActive(true);
                TextDescription.gameObject.SetActive(true);
                PanelDescription.gameObject.SetActive(true);

                //Marker Anjing
                if (name == "Marker_Anjing")
                {
                    ButtonAction.GetComponent<Button>().onClick.AddListener(delegate { playSound("sounds/suaraanjing"); });
                    TextDescription.GetComponent<Text>().text = "";
                }

                //Marker Beruang
                if (name == "Marker_Beruang")
                {
                    ButtonAction.GetComponent<Button>().onClick.AddListener(delegate { playSound("sounds/suaraberuang"); });
                    TextDescription.GetComponent<Text>().text = "";
                }

                //Marker Capung
                if (name == "Marker_Capung")
                {
                    ButtonAction.GetComponent<Button>().onClick.AddListener(delegate { playSound("sounds/suaracapung"); });
                    TextDescription.GetComponent<Text>().text = "";
                }

                //Marker Domba
                if (name == "Marker_Domba")
                {
                    ButtonAction.GetComponent<Button>().onClick.AddListener(delegate { playSound("sounds/suaradomba"); });
                    TextDescription.GetComponent<Text>().text = "";
                }
                //Marker Elang
                if (name == "Marker_Elang")
                {
                    ButtonAction.GetComponent<Button>().onClick.AddListener(delegate { playSound("sounds/suaraelang"); });
                    TextDescription.GetComponent<Text>().text = ".";
                }

                //Marker Gajah
                if (name == "Marker_Gajah")
                {
                    ButtonAction.GetComponent<Button>().onClick.AddListener(delegate { playSound("sounds/suaragajah"); });
                    TextDescription.GetComponent<Text>().text = ".";
                }

                //Marker Harimau
                if (name == "Marker_Harimau")
                {
                    ButtonAction.GetComponent<Button>().onClick.AddListener(delegate { playSound("sounds/suaraharimau"); });
                    TextDescription.GetComponent<Text>().text = ".";
                }

                //Marker Jerapah
                if (name == "Marker_Jerapah")
                {
                    ButtonAction.GetComponent<Button>().onClick.AddListener(delegate { playSound("sounds/suarajerapah"); });
                    TextDescription.GetComponent<Text>().text = ".";
                }

                //Marker Kucing
                if (name == "Marker_Kucing")
                {
                    ButtonAction.GetComponent<Button>().onClick.AddListener(delegate { playSound("sounds/suarakucing"); });
                    TextDescription.GetComponent<Text>().text = ".";
                }
            }
        }

        //Fungsi untuk mulai suara
        void playSound(string ss)
        {
            clipTarget = (AudioClip)Resources.Load(ss);
            soundTarget.clip = clipTarget;
            soundTarget.loop = false;
            soundTarget.playOnAwake = false;
            soundTarget.Play();
        }
    }
}
