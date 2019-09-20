using System;
using System.Collections.Generic;
using System.Text;

namespace Entities.StatePattern
{
    public interface TvPowerAction
    {
        string Status();
    }
    public class OnStatus : TvPowerAction
    {
        public string Status()
        {
            return "Off";
        }

    }
    public class OffStatus : TvPowerAction
    {
        public string Status()
        {
            return "On";
        }

    }
    public class TV
    {
        private TvPowerAction TvPowerAction;
        public bool IsOn { get; set; }
        public string Status { get; set; }

        public void PowerPush()
        {
            Status = TvPowerAction.Status();
        }
    }
}
