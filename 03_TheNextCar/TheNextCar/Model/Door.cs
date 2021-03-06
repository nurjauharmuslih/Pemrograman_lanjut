﻿namespace TheNextCar.Model
{
    class Door
    {
        private bool closed;
        private bool locked;

        public void close()
        {
            this.closed = true;
        }
        public void open()
        {
            this.closed = false;
        }
        public void activateLock()
        {
            this.locked = true;
        }
        public void unlock()
        {
            this.locked = false;
        }

        public bool isClosed()
        {
            return this.closed;
        }
        public bool isLocked()
        {
            return this.locked;
        }
    }
}
//https://github.com/nurjauharmuslih