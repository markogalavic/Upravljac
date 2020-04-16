using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace upravljac
{
    class MediaPlayer
    {
        public bool IsStopped;

        public bool IsPaused;

        public bool FastForward;

        public bool FastReverse;

     
        public int PlayPosition;



        public MediaPlayer()

        {

           
        }
        public bool getIsStopped()
        {
            return IsStopped;
        }
        public void setIsStopped(bool IsStopped)
        {
            this.IsStopped = IsStopped;
        }
        public bool getIsPaused()
        {
            return IsPaused;
        }
        public void setIsPaused(bool IsPaused)
        {
            this.IsPaused = IsPaused;
        }
        public bool getFastForward()
        {
            return FastForward;
        }
        public void setFastForward(bool FastForward)
        {
            this.FastForward = FastForward;
        }
        public bool getFastReverse()
        {
            return FastReverse;
        }
        public void setFastReverse(bool FastReverse)
        {
            this.FastReverse = FastReverse;
        }
        public int getPlayPosition()
        {
            return PlayPosition;
        }
        public void setPlayPosition(int PlayPosition)
        {
            this.PlayPosition = 0;
        }

    }
}
