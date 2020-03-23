using System;
using System.Collections.Generic;
using System.Text;

namespace Lab_10_4_Music_Player
{
    class MediaPlayer
    {
        public void PlayMedia(IAudioPlayer media)
        {
            media.Play();
        }

        internal void PlayMedia(Artist prince)
        {
            throw new NotImplementedException();
        }

        internal void PlayMedia(AudioBook howto)
        {
            throw new NotImplementedException();
        }
    }
}
