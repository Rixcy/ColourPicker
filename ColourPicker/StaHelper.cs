using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ColourPicker
{
    abstract class StaHelper
    {
        readonly ManualResetEvent _complete = new ManualResetEvent(false);

        public void Go()
        {
            var thread = new Thread(new ThreadStart(DoWork))
            {
                IsBackground = true,
            };
            thread.SetApartmentState(ApartmentState.STA);
            thread.Start();
        }

        // Thread entry method
        private void DoWork()
        {
            try
            {
                _complete.Reset();
                Work();
            }
            catch (Exception ex)
            {
                if (DontRetryWorkOnFailed)
                    throw;
                else
                {
                    try
                    {
                        Thread.Sleep(1000);
                        Work();
                    }
                    catch
                    {
                        // ex from first exception
                        LogAndShowMessage(ex);
                    }
                }
            }
            finally
            {
                _complete.Set();
            }
        }

        internal abstract void LogAndShowMessage(Exception ex);

        public bool DontRetryWorkOnFailed { get; set; }

        // Implemented in base class to do actual work.
        protected abstract void Work();
    }
}
