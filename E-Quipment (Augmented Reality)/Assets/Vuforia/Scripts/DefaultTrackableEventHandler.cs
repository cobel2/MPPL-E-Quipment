/*==============================================================================
Copyright (c) 2010-2014 Qualcomm Connected Experiences, Inc.
All Rights Reserved.
Confidential and Proprietary - Protected under copyright and other laws.
==============================================================================*/

using UnityEngine;
using UnityEngine.UI;
using System.Collections;
using System.Collections.Generic;


namespace Vuforia
{
    /// <summary>
    /// A custom handler that implements the ITrackableEventHandler interface.
    /// </summary>
    public class DefaultTrackableEventHandler : MonoBehaviour,
                                                ITrackableEventHandler
    {
        //------------Begin Sound----------
        public AudioSource soundTarget;
        public AudioClip clipTarget;
        private AudioSource[] allAudioSources;

        //function to stop all sounds
        void StopAllAudio()
        {
            allAudioSources = FindObjectsOfType(typeof(AudioSource)) as AudioSource[];
            foreach (AudioSource audioS in allAudioSources)
            {
                audioS.Stop();
            }
        }

        //function to play sound
        void playSound(string ss)
        {
            clipTarget = (AudioClip)Resources.Load(ss);
            soundTarget.clip = clipTarget;
            soundTarget.loop = false;
            soundTarget.playOnAwake = false;
            soundTarget.Play();
        }

        public Transform TextTargetName;
        public Transform ButtonAction;
        public Transform TextDescription;
        public Transform PanelDescription;

        #region PRIVATE_MEMBER_VARIABLES

        private TrackableBehaviour mTrackableBehaviour;
    
        #endregion // PRIVATE_MEMBER_VARIABLES



        #region UNTIY_MONOBEHAVIOUR_METHODS
    
        void Start()
        {
            mTrackableBehaviour = GetComponent<TrackableBehaviour>();
            if (mTrackableBehaviour)
            {
                mTrackableBehaviour.RegisterTrackableEventHandler(this);
            }
            soundTarget = (AudioSource)gameObject.AddComponent<AudioSource>();
        }

        #endregion // UNTIY_MONOBEHAVIOUR_METHODS



        #region PUBLIC_METHODS

        /// <summary>
        /// Implementation of the ITrackableEventHandler function called when the
        /// tracking state changes.
        /// </summary>
        public void OnTrackableStateChanged(
                                        TrackableBehaviour.Status previousStatus,
                                        TrackableBehaviour.Status newStatus)
        {
            if (newStatus == TrackableBehaviour.Status.DETECTED ||
                newStatus == TrackableBehaviour.Status.TRACKED ||
                newStatus == TrackableBehaviour.Status.EXTENDED_TRACKED)
            {
                OnTrackingFound();
            }
            else
            {
                OnTrackingLost();
            }
        }

        #endregion // PUBLIC_METHODS



        #region PRIVATE_METHODS


        private void OnTrackingFound()
        {
            Renderer[] rendererComponents = GetComponentsInChildren<Renderer>(true);
            Collider[] colliderComponents = GetComponentsInChildren<Collider>(true);

            // Enable rendering:
            foreach (Renderer component in rendererComponents)
            {
                component.enabled = true;
            }

            // Enable colliders:
            foreach (Collider component in colliderComponents)
            {
                component.enabled = true;
            }

            Debug.Log("Trackable " + mTrackableBehaviour.TrackableName + " found");

            if (mTrackableBehaviour.TrackableName == "Marker_Anjing")
            {
                playSound("sounds/anjing");
            }
            if (mTrackableBehaviour.TrackableName == "Marker_Beruang")
            {
                playSound("sounds/beruang");
            }
            if (mTrackableBehaviour.TrackableName == "Marker_Capung")
            {
                playSound("sounds/capung");
            }
            if (mTrackableBehaviour.TrackableName == "Marker_Domba")
            {
                playSound("sounds/domba");
            }
            if (mTrackableBehaviour.TrackableName == "Marker_Elang")
            {
                playSound("sounds/elang");
            }
            if (mTrackableBehaviour.TrackableName == "Marker_Gajah")
            {
                playSound("sounds/gajah");
            }
            if (mTrackableBehaviour.TrackableName == "Marker_Harimau")
            {
                playSound("sounds/harimau");
            }
            if (mTrackableBehaviour.TrackableName == "Marker_Jerapah")
            {
                playSound("sounds/jerapah");
            }
            if (mTrackableBehaviour.TrackableName == "Marker_Kucing")
            {
                playSound("sounds/kucing");
            }
        }


        private void OnTrackingLost()
        {
            Renderer[] rendererComponents = GetComponentsInChildren<Renderer>(true);
            Collider[] colliderComponents = GetComponentsInChildren<Collider>(true);

            // NonAktif Objek
            foreach (Renderer component in rendererComponents)
            {
                component.enabled = false;
            }

            // NonAktif Objek
            foreach (Collider component in colliderComponents)
            {
                component.enabled = false;
            }

            Debug.Log("Trackable " + mTrackableBehaviour.TrackableName + " lost");

            StopAllAudio();

            TextTargetName.GetComponent<Text>().text = ".";
            ButtonAction.gameObject.SetActive(false);
            TextDescription.gameObject.SetActive(false);
            PanelDescription.gameObject.SetActive(false);
        }

        #endregion
    }
}
