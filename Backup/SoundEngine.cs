using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.DirectX.DirectSound;
using System.Drawing;
using Microsoft.DirectX.AudioVideoPlayback;

namespace Sharpshooter_Fk
{
    public class SoundEngine
    {
        public Device dSound;
        public BufferDescription bufferDescription;
        public Audio bgm;
        public bool bgmPlaying = false;
        public List<SecondaryBuffer> soundBuffers = new List<SecondaryBuffer>();


        //Constructor Method
        public SoundEngine(MainForm mainForm)
        {
            dSound = new Device();
            dSound.SetCooperativeLevel(mainForm.Handle, CooperativeLevel.Priority);
            bufferDescription = new BufferDescription();
            bufferDescription.ControlVolume = true;
        }

        //Public VOid playsound
        public void playSound(string fileName, PointF position)
        {
            //Check for and remove finished sounds. 
            //This is necessary to prevent memory leakage.
            for (int i = 0; i < soundBuffers.Count; i++)
            {
                if (!soundBuffers[i].Status.Playing)
                {
                    soundBuffers[i].Dispose();
                    soundBuffers.RemoveAt(i);
                }
            }
            //Create a new buffer dawg
            SecondaryBuffer sound = new SecondaryBuffer(fileName, bufferDescription, dSound);
            //Add the sound to the list, so we can track it
            soundBuffers.Add(sound);

            // Reduce the volume based on distance
            sound.Volume -= (int)(
                Math.Abs(MainForm.player1.location.X - position.X)
            + Math.Abs(MainForm.player1.location.Y - position.Y)) * 2;

            //Play the sound
            sound.Play(0, BufferPlayFlags.Default);
        }

        public void playBGM(string fileName)
        {
            //Don't play if already playing
            if (bgmPlaying == true)
            {
                return;
            }
            bgm = new Audio(fileName);
            //Play it.
            bgm.Play();
            bgm.Volume -= 1000;
            bgm.Ending += new EventHandler(bgm_Ending);

            bgmPlaying = true;
        }

        void bgm_Ending(object sender, EventArgs e)
        {
            bgm.SeekCurrentPosition(0.0, SeekPositionFlags.AbsolutePositioning);
        }
        public void stopBGM()
        {
            bgmPlaying = false;
            bgm.Stop();
        }

    }
}
